using CafeAutomationCodeFirst.Data;
using CafeAutomationCodeFirst.Repository;
using CafeAutomationCodeFirst.ViewModels;
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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            DayReport();
            FilterLoad();
            
        }

        private decimal toplam = 0;
        private void DayReport()
        {
            lblDay.Text = $"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} GÜNÜ TOPLAM CİROSU :";

            var query = from ord in cafeContext.Orders
                        join prod in cafeContext.Products on ord.ProductId equals prod.Id
                        join tbl in cafeContext.Tables on ord.TableId equals tbl.Id
                        select new ReportViewModel()
                        {
                            //OrderId = ord.Id,
                            //ProductId = ord.ProductId,
                            TableName = tbl.TableName,
                            ProductName = prod.ProductName,
                            SubTotal = ord.SubTotal,
                            //TableId = ord.TableId,
                            OrderStatus = ord.OrderStatus,
                            DateTime = ord.DateTime,
                            DateTimeDay = ord.DateTimeDay,
                            DateTimeHour = ord.DateTimeHour
                        };

            var liste = query.Where(x => x.DateTimeDay == dateTimePicker1.Value.ToString("dd/MM/yyyy") && x.OrderStatus == false).OrderByDescending(x=>x.DateTimeHour).ToList();
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = liste;
            dgvOrders.Columns["OrderStatus"].Visible = false;
            dgvOrders.Columns["DateTimeDay"].Visible = false;
            dgvOrders.Columns["DateTimeHour"].Visible = false;

            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.SubTotal;
            }
            lblTotalPrice.Text = $"{toplam}₺";
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DayReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilterLoad()
        {
            var query = from ord in cafeContext.Orders
                        join prod in cafeContext.Products on ord.ProductId equals prod.Id
                        join tbl in cafeContext.Tables on ord.TableId equals tbl.Id
                        select new ReportViewModel()
                        {
                            //OrderId = ord.Id,
                            //ProductId = ord.ProductId,
                            TableName = tbl.TableName,
                            ProductName = prod.ProductName,
                            SubTotal = ord.SubTotal,
                            //TableId = ord.TableId,
                            OrderStatus = ord.OrderStatus,
                            DateTime = ord.DateTime,
                            DateTimeDay = ord.DateTimeDay,
                            DateTimeHour = ord.DateTimeHour
                        };

            var liste = query.Where(x => x.DateTimeDay == dateTimePicker2.Value.ToString("dd/MM/yyyy")).OrderByDescending(x => x.DateTimeDay).ThenByDescending(x => x.DateTimeHour).ToList();

            dgvMonthReport.DataSource = null;
            dgvMonthReport.DataSource = liste;
            dgvMonthReport.Columns["OrderStatus"].Visible = false;
            dgvMonthReport.Columns["DateTime"].Visible = false;
            dgvMonthReport.Columns["DateTimeHour"].Visible = false;
            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.SubTotal;
            }
            lblFilterPrice.Text = $"SEÇİLİ GÜNLER ARASI TOPLAM CİRO :     {toplam}₺";
        }  //Form Yüklenirken O Güne Ait Rapor
        
        private void MonthFilter()
        {
            var query = from ord in cafeContext.Orders
                        join prod in cafeContext.Products on ord.ProductId equals prod.Id
                        join tbl in cafeContext.Tables on ord.TableId equals tbl.Id
                        select new ReportViewModel()
                        {
                            //OrderId = ord.Id,
                            //ProductId = ord.ProductId,
                            TableName = tbl.TableName,
                            ProductName = prod.ProductName,
                            SubTotal = ord.SubTotal,
                            //TableId = ord.TableId,
                            OrderStatus = ord.OrderStatus,
                            DateTime = ord.DateTime,
                            DateTimeDay = ord.DateTimeDay,
                            DateTimeHour = ord.DateTimeHour
                        };

            var liste = query.Where(x => x.DateTime >= dateTimePicker2.Value && x.DateTime <= dateTimePicker3.Value).OrderByDescending(x => x.DateTimeDay).ThenByDescending(x => x.DateTimeHour).ToList();

            dgvMonthReport.DataSource = null;
            dgvMonthReport.DataSource = liste;
            dgvMonthReport.Columns["OrderStatus"].Visible = false;
            dgvMonthReport.Columns["DateTime"].Visible = false;
            dgvMonthReport.Columns["DateTimeHour"].Visible = false;
            toplam = 0;
            foreach (var item in liste)
            {
                toplam += item.SubTotal;
            }
            lblFilterPrice.Text = $"SEÇİLİ GÜNLER ARASI TOPLAM CİRO :     {toplam}₺";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MonthFilter();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            MonthFilter();
        }
    }
}
