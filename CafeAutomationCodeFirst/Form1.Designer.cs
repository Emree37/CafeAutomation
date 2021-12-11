
namespace CafeAutomationCodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kURULUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATMASAAYARLARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kURULUMToolStripMenuItem,
            this.kAFEToolStripMenuItem,
            this.rAPORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kURULUMToolStripMenuItem
            // 
            this.kURULUMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÜToolStripMenuItem,
            this.kATMASAAYARLARIToolStripMenuItem});
            this.kURULUMToolStripMenuItem.Name = "kURULUMToolStripMenuItem";
            this.kURULUMToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kURULUMToolStripMenuItem.Text = "KURULUM";
            // 
            // mENÜToolStripMenuItem
            // 
            this.mENÜToolStripMenuItem.Name = "mENÜToolStripMenuItem";
            this.mENÜToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mENÜToolStripMenuItem.Text = "MENÜ";
            this.mENÜToolStripMenuItem.Click += new System.EventHandler(this.mENÜToolStripMenuItem_Click);
            // 
            // kATMASAAYARLARIToolStripMenuItem
            // 
            this.kATMASAAYARLARIToolStripMenuItem.Name = "kATMASAAYARLARIToolStripMenuItem";
            this.kATMASAAYARLARIToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kATMASAAYARLARIToolStripMenuItem.Text = "KAT/MASA AYARLARI";
            this.kATMASAAYARLARIToolStripMenuItem.Click += new System.EventHandler(this.kATMASAAYARLARIToolStripMenuItem_Click);
            // 
            // kAFEToolStripMenuItem
            // 
            this.kAFEToolStripMenuItem.Name = "kAFEToolStripMenuItem";
            this.kAFEToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kAFEToolStripMenuItem.Text = "KAFE";
            this.kAFEToolStripMenuItem.Click += new System.EventHandler(this.kAFEToolStripMenuItem_Click);
            // 
            // rAPORToolStripMenuItem
            // 
            this.rAPORToolStripMenuItem.Name = "rAPORToolStripMenuItem";
            this.rAPORToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rAPORToolStripMenuItem.Text = "RAPOR";
            this.rAPORToolStripMenuItem.Click += new System.EventHandler(this.rAPORToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kURULUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENÜToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATMASAAYARLARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORToolStripMenuItem;
    }
}

