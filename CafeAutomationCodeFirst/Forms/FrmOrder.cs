﻿using CafeAutomationCodeFirst.Data;
using CafeAutomationCodeFirst.Models;
using CafeAutomationCodeFirst.Repository;
using CafeAutomationCodeFirst.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomationCodeFirst.Forms
{
    public partial class FrmOrder : Form
    {
        public Table selectedTable { get; set; }
        public FrmOrder(Table _selectedTable)
        {
            InitializeComponent();
            selectedTable = _selectedTable;
        }

        private CafeContext cafeContext = new CafeContext();
        private CategoryRepository categoryRepository = new CategoryRepository();
        private ProductRepository productRepository = new ProductRepository();
        private OrderRepository orderRepository = new OrderRepository();
        private TableRepository tableRepository = new TableRepository();
        
        public List<Order> OrdersInTable { get; set; }

        private List<Category> categories;

        private void GetCategories()
        {
            categories = categoryRepository.Get(x=>x.IsDeleted == false).ToList();
            flpCategories.Controls.Clear();
            foreach (Category category in categories)
            {
                Button button = new Button()
                {
                    Text = category.CategoryName,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(category.CategoryPicture)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = category
                };
                button.Click += CategoryBtn_Click;
                flpCategories.Controls.Add(button);
            }
            //lstSiparis.FullRowSelect = true;
            //ListeyiDoldur()
        }

        private Category selectedCategory;
        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            selectedCategory = selectedButton.Tag as Category;
            List<Product> products = productRepository.Get().Where(x => x.CategoryId == selectedCategory.Id && x.IsDeleted == false).ToList();


            flpProducts.Controls.Clear();
            foreach (Product product in products)
            {
                Button button = new Button()
                {
                    Text = product.ProductName,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(product.ProductPicture)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = product
                };
                button.Click += ProductBtn_Click;
                flpProducts.Controls.Add(button);
            }
        }

        Product selectedProduct;
        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            selectedProduct = selectedButton.Tag as Product;

            var order = orderRepository.Get().FirstOrDefault(x => x.ProductId == selectedProduct.Id &&
            x.TableId == selectedTable.Id && x.OrderStatus == true && x.IsDeleted == false); 
            if (order == null)
            {
                Order newOrder = new Order()
                {
                    Quantity = 1,
                    Price = selectedProduct.Price,
                    SubTotal = selectedProduct.Price * 1,
                    OrderStatus = true,
                    DateTime = DateTime.Now,
                    DateTimeDay = DateTime.Now.ToString("dd/MM/yyyy"),
                    DateTimeHour = DateTime.Now.ToString("HH:mm:ss"),
                    TableId = selectedTable.Id,
                    ProductId = selectedProduct.Id,
                    IsDeleted = false
                };
                orderRepository.Add(newOrder);
            }
            else
            {
                order.Quantity++;
                order.SubTotal = order.Quantity * order.Price;
                orderRepository.Update(order);
            }
            
            GetOrders();
        }

        private void GetOrders()
        {
            
            var query = from ord in cafeContext.Orders
                        join prod in cafeContext.Products on ord.ProductId equals prod.Id
                        where ord.IsDeleted == false
                        select new OrderViewModel()
                        {
                            OrderId = ord.Id,
                            OrderStatus = ord.OrderStatus,
                            ProductId = ord.ProductId,
                            ProductName = prod.ProductName,
                            Quantity = ord.Quantity,
                            Price = ord.Price,
                            SubTotal = ord.SubTotal,
                            TableId = ord.TableId
                        };
            var liste = query.Where(x => x.TableId == selectedTable.Id && x.OrderStatus == true).ToList();

            
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = liste;
            dgvOrders.Columns["OrderId"].Visible = false;
            dgvOrders.Columns["OrderStatus"].Visible = false;
            dgvOrders.Columns["ProductId"].Visible = false;
            dgvOrders.Columns["TableId"].Visible = false;
            dgvOrders.Columns[2].HeaderText = "ÜRÜN ADI";
            dgvOrders.Columns[3].HeaderText = "ADET";
            dgvOrders.Columns[4].HeaderText = "FİYAT";
            dgvOrders.Columns[5].HeaderText = "ARA TOPLAM";
            dgvOrders.ClearSelection();

            decimal totalPrice = 0;
            foreach (var item in liste)
            {
                totalPrice += item.SubTotal;
            }
            lblTotalPrice.Text = $"TOPLAM TUTAR : {totalPrice:c2}";
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetOrders();
        }

        private void btnDecrase_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvOrders.SelectedRows[0];
                int selectedOrderId = Convert.ToInt32(selected.Cells[0].Value);
                var order = orderRepository.Get().FirstOrDefault(x => x.Id == selectedOrderId);

                if (order.Quantity == 1)
                {
                    orderRepository.Remove(order);
                }
                else
                {
                    order.Quantity--;
                    order.SubTotal = order.Quantity * order.Price;
                    orderRepository.Update(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Azaltacağınız Siparişi Seçiniz");
            }
            
            GetOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = dgvOrders.SelectedRows[0];
                int selectedOrderId = Convert.ToInt32(selected.Cells[0].Value);
                var order = orderRepository.Get().FirstOrDefault(x => x.Id == selectedOrderId);
                orderRepository.Remove(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Sileceğiniz Siparişi Seçiniz");
            }
            GetOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var orderList = orderRepository.Get().ToList();
            foreach (var item in orderList)
            {
                if(item.TableId == selectedTable.Id)
                {
                    orderRepository.Remove(item);
                }
            }
            GetOrders();
            Close();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            var orderList = orderRepository.Get().ToList();
            foreach (var item in orderList)
            {
                if (item.TableId == selectedTable.Id && item.OrderStatus == true)
                {
                    item.OrderStatus = false;
                    item.DateTime = DateTime.Now;
                    item.DateTimeDay = DateTime.Now.ToString("dd/MM/yyyy");
                    item.DateTimeHour = DateTime.Now.ToString("HH:mm:ss");
                    orderRepository.Update(item);
                }
            }
            GetOrders();
            Close();
        }

        private FrmCafe frmCafe;
        private void FrmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmCafe == null || frmCafe.IsDisposed)
            {
                frmCafe = new FrmCafe();
            }
            frmCafe.Show();
            frmCafe.WindowState = FormWindowState.Maximized;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
         new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/yazdir.txt", false))
            {
                file.WriteLine("   ----------  CAFE AUTOMATİON  ----------   ");
                file.WriteLine("--- Masa Detay : ---");
                file.WriteLine(" |     Ürün    |    Fiyat    |     Adet   ");
                string lines = "";

                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {

                        lines = lines + " | " + dgvOrders.Rows[row].Cells[col].Value.ToString();
                        if (col == 2)
                        {
                            file.WriteLine(lines);
                            lines = "";
                        }
                    }

                }
                file.WriteLine(" ------------------------");
                file.WriteLine(" Toplam :" + lblTotalPrice.Text.ToString());

            }


            var pi = new ProcessStartInfo("yazdir.txt");
            pi.UseShellExecute = true;
            pi.Verb = "print";
            //var process = System.Diagnostics.Process.Start(pi);

            MessageBox.Show("YAZDIRILIYOR...");
        }
    }
}
