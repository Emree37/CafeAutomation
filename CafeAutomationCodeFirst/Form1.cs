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
            frmMenu.MdiParent = this;
            frmMenu.WindowState = FormWindowState.Maximized;
            frmMenu.Show();
        }
    }
}
