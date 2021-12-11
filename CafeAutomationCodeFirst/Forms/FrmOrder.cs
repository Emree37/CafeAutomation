using CafeAutomationCodeFirst.Data;
using CafeAutomationCodeFirst.Models;
using CafeAutomationCodeFirst.Repository;
using CafeAutomationCodeFirst.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            categories = categoryRepository.Get().ToList();
            flpCategories.Controls.Clear();
            foreach (Category category in categories)
            {
                Button button = new Button()
                {
                    Text = category.CategoryName,
                    Size = new Size(220, 150),
                    //BackgroundImage = Image.FromStream(new MemoryStream(kategori.Fotograf)),
                    //BackgroundImageLayout = ImageLayout.Stretch,
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

            //List<Product> products = selectedCategory.Products.ToList();
            List<Product> products = productRepository.Get().Where(x => x.CategoryId == selectedCategory.Id).ToList();


            flpProducts.Controls.Clear();
            foreach (Product product in products)
            {
                Button button = new Button()
                {
                    Text = product.ProductName,
                    Size = new Size(220, 150),
                    //BackgroundImage = Image.FromStream(new MemoryStream(urun.Fotograf)),
                    //BackgroundImageLayout = ImageLayout.Stretch,
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
            x.TableId == selectedTable.Id && x.OrderStatus == true); 
            if (order == null)
            {
                Order newOrder = new Order()
                {
                    Quantity = 1,
                    Price = selectedProduct.Price,
                    SubTotal = selectedProduct.Price * 1,
                    OrderStatus = true,
                    DateTime = DateTime.Now,
                    DateTimeDay = DateTime.Now.ToString("MM/dd/yyyy"),
                    DateTimeHour = DateTime.Now.ToString("HH:mm:ss"),
                    TableId = selectedTable.Id,
                    ProductId = selectedProduct.Id,
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
            //dgvOrders.Columns["ProductId"].Visible = false;
            //dgvOrders.Columns["ProductId"].Visible = false;
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
            var selected = dgvOrders.SelectedRows[0];
            int selectedOrderId = Convert.ToInt32(selected.Cells[0].Value);
            var order = orderRepository.Get().FirstOrDefault(x => x.Id == selectedOrderId);

            if(order.Quantity == 1)
            {
                orderRepository.Remove(order);
            }
            else
            {
                order.Quantity--;
                order.SubTotal = order.Quantity * order.Price;
                orderRepository.Update(order);
            }
            GetOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dgvOrders.SelectedRows[0];
            int selectedOrderId = Convert.ToInt32(selected.Cells[0].Value);
            var order = orderRepository.Get().FirstOrDefault(x => x.Id == selectedOrderId);
            orderRepository.Remove(order);
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
                if (item.TableId == selectedTable.Id)
                {
                    item.OrderStatus = false;
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
    }
}
