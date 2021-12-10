using CafeAutomationCodeFirst.Data;
using CafeAutomationCodeFirst.Models;
using CafeAutomationCodeFirst.Repository;
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
        public FrmOrder()
        {
            InitializeComponent();
        }

        private CafeContext cafeContext = new CafeContext();
        private CategoryRepository categoryRepository = new CategoryRepository();
        private ProductRepository productRepository = new ProductRepository();
        private OrderRepository orderRepository = new OrderRepository();
        private TableRepository tableRepository = new TableRepository();
        public Table selectedTable { get; set; }
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

            var order = orderRepository.Get().FirstOrDefault(x => x.ProductId == selectedProduct.Id);
            if (order == null)
            {
                Order newOrder = new Order()
                {
                    Quantity = 1,
                    Price = selectedProduct.Price,
                    OrderStatus = false,
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
                orderRepository.Save();
            }
            GetOrders();
        }

        private void GetOrders()
        {
            var query = from ord in cafeContext.Orders
                        join prod in cafeContext.Products on ord.ProductId equals prod.Id
                        select new
                        {
                            prod.ProductName,
                            ord.Quantity,
                            ord.Price,
                            ord.SubTotal
                        };
            dgvOrders.DataSource = query.ToList();

            //burada toplam tutarı hesaplaman lazım
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetOrders();
        }
    }
}
