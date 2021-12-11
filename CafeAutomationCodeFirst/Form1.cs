using CafeAutomationCodeFirst.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomationCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FrmMenu frmMenu;
        private void mENÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmMenu == null || frmMenu.IsDisposed)
            {
                frmMenu = new FrmMenu();
            }
            //frmMenu.MdiParent = this;
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
            
        }

        private FrmFloorSetting frmFloorSetting;
        private void kATMASAAYARLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmFloorSetting == null || frmFloorSetting.IsDisposed)
            {
                frmFloorSetting = new FrmFloorSetting();
            }
            frmFloorSetting.Show();
            frmFloorSetting.WindowState = FormWindowState.Maximized;
        }

        private FrmCafe frmCafe;
        private void kAFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCafe == null || frmCafe.IsDisposed)
            {
                frmCafe = new FrmCafe();
            }
            frmCafe.Show();
            frmCafe.WindowState = FormWindowState.Maximized;
        }

        private FrmReport frmReport;
        private void rAPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReport == null || frmReport.IsDisposed)
            {
                frmReport = new FrmReport();
            }
            frmReport.Show();
            frmReport.WindowState = FormWindowState.Maximized;
        }
    }
}
