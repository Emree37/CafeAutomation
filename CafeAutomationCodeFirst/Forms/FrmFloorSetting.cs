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
    public partial class FrmFloorSetting : Form
    {
        public FrmFloorSetting()
        {
            InitializeComponent();
        }

        private CafeContext cafeContext = new CafeContext();
        private FloorRepository floorRepository = new FloorRepository();
        private TableRepository tableRepository = new TableRepository();

        private void FrmFloorSetting_Load(object sender, EventArgs e)
        {
            lstFloor.DataSource = floorRepository.Get().OrderBy(x => x.FloorOrder)
                .ToList();
        }

        private void btnFloorAdd_Click(object sender, EventArgs e)
        {
            Floor newFloor = new Floor()
            {
                FloorName = txtFloorName.Text,
                Word = txtWord.Text,
                FloorOrder = Convert.ToInt32(txtFloorOrder.Text)
            };

            int tableCount = Convert.ToInt32(txtTableCount.Text);

            for (int i = 0; i < tableCount; i++)
            {
                Table newTable = new Table()
                {
                    TableOrder = i + 1,
                    TableName = $"{newFloor.Word}/Masa {i + 1}",
                    TableStatus = false
                };
                newFloor.Tables.Add(newTable);
            }

            floorRepository.Add(newFloor);
            lstFloor.DataSource = null;
            lstFloor.DataSource = floorRepository.Get()
                .OrderBy(x => x.FloorOrder).ToList();

        }

        private Floor selectedFloor;
        private void lstFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFloor.SelectedItem == null) return;

            selectedFloor = lstFloor.SelectedItem as Floor;
            txtFloorName.Text = selectedFloor.FloorName;
            txtFloorOrder.Text = selectedFloor.FloorOrder.ToString();
            txtWord.Text = selectedFloor.Word;
            //txtTableCount.Text = selectedFloor.Tables.Count().ToString();

            var liste = tableRepository.Get().Where(x => x.FloorId == selectedFloor.Id).ToList();
            txtTableCount.Text = liste.Count().ToString();

        }
    }
}
