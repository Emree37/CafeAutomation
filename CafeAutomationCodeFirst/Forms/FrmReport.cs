using CafeAutomationCodeFirst.Data;
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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private CafeContext cafeContext = new CafeContext();
        private CategoryRepository categoryRepository = new CategoryRepository();
        private ProductRepository productRepository = new ProductRepository();
        private OrderRepository orderRepository = new OrderRepository();
        private TableRepository tableRepository = new TableRepository();

        private void FrmReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DayReport();
        }

        private decimal toplam = 0;
        private void DayReport()
        {
            lblDay.Text = $"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} Günü Toplam Cirosu";
            var liste = orderRepository.Get(x => x.DateTimeDay == dateTimePicker1.Value.ToString("dd/MM/yyyy")
                        && x.OrderStatus == false).ToList();
            dgvOrders.DataSource = liste;

            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.SubTotal;
            }
            lblTotalPrice.Text = toplam.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DayReport();
        }
    }
}
