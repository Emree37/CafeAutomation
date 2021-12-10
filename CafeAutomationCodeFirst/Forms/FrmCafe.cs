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
    public partial class FrmCafe : Form
    {
        public FrmCafe()
        {
            InitializeComponent();
        }

        private CafeContext cafeContext = new CafeContext();
        private FloorRepository floorRepository = new FloorRepository();
        private TableRepository tableRepository = new TableRepository();
        private OrderRepository orderRepository = new OrderRepository();

        Color selectedFloorColor = Color.Coral, defaultFloorColor = Color.CornflowerBlue;

        private void FrmCafe_Load(object sender, EventArgs e)
        {
            List<Floor> floors = floorRepository.Get().ToList();

            for (int i = 0; i < floors.Count; i++)
            {
                Floor floor = floors[i];
                Button btn = new Button()
                {
                    Text = floor.FloorName,
                    Size = new Size(140,95),
                    BackColor = defaultFloorColor,
                    Tag = floor
                };
                btn.Click += KatBtn_Click;
                flpFloors.Controls.Add(btn);
            }
        }

        private Floor selectedFloor;
        private void KatBtn_Click(object sender,EventArgs e)
        {
            Button selectedButton = sender as Button;
            selectedFloor = selectedButton.Tag as Floor;

            //List<Table> tables = selectedFloor.Tables.ToList();
            List<Table> tables = tableRepository.Get().Where(x => x.FloorId == selectedFloor.Id).ToList();


            flpTables.Controls.Clear();
            foreach (Table table in tables)
            {
                Button btn = new Button()
                {
                    Text = table.TableName,
                    Size = new Size(140, 95),
                    BackColor = defaultFloorColor,
                    Tag = table
                };
                btn.Click += MasaBtn_Click;
                flpTables.Controls.Add(btn);
            }

            foreach (Button button in flpFloors.Controls)
            {
                button.BackColor = defaultFloorColor;
                if(button.Text == selectedButton.Text)
                {
                    button.BackColor = selectedFloorColor;
                }
            }

            TableColorControl();
            
        }

        private void TableColorControl()
        {
            //Masanın Siparişleri Varsa Renklendir Ona Göre
        }

        private FrmOrder frmOrder;
        private void MasaBtn_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (frmOrder == null || frmOrder.IsDisposed)
            {
                frmOrder = new FrmOrder(selectedButton.Tag as Table);
            }
            frmOrder.Show();
            frmOrder.WindowState = FormWindowState.Maximized;
            //frmOrder.selectedTable = selectedButton.Tag as Table;

        }

    }
}
