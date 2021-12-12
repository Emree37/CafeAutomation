using CafeAutomationCodeFirst.Data;
using CafeAutomationCodeFirst.Models;
using CafeAutomationCodeFirst.Repository;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private CafeContext cafeContext = new CafeContext();
        private CategoryRepository categoryRepository = new CategoryRepository();
        private ProductRepository productRepository = new ProductRepository();

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();
        }

        private void GetCategories()
        {
            lstCategory.DataSource = null;
            lstCategory.DataSource = categoryRepository.Get().ToList();
        }

        private void GetProducts()
        {
            lstProduct.DataSource = null;
            lstProduct.DataSource = productRepository.Get()
                .Where(x => x.CategoryId == selectedCategory.Id)
                .ToList();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            categoryRepository.Add(category);
            GetCategories();
        }

        private Category selectedCategory;
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;

            selectedCategory = lstCategory.SelectedItem as Category;
            GetProducts();
            
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductName = txtProductName.Text,
                Price = nFiyat.Value
            };

            categoryRepository.AddProduct(selectedCategory, product);
            //lstProduct.DataSource = null;
            //lstProduct.DataSource = selectedCategory.Products.ToList();
            GetProducts();
            
        }
    }
}
