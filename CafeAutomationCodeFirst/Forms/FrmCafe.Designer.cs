﻿
namespace CafeAutomationCodeFirst.Forms
{
    partial class FrmCafe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpFloors = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpFloors
            // 
            this.flpFloors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFloors.AutoSize = true;
            this.flpFloors.Location = new System.Drawing.Point(0, 0);
            this.flpFloors.Name = "flpFloors";
            this.flpFloors.Size = new System.Drawing.Size(1766, 0);
            this.flpFloors.TabIndex = 0;
            // 
            // flpTables
            // 
            this.flpTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTables.AutoScroll = true;
            this.flpTables.Location = new System.Drawing.Point(12, 144);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(1741, 750);
            this.flpTables.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1631, 939);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 65);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 1061);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flpTables);
            this.Controls.Add(this.flpFloors);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCafe";
            this.Text = "FrmCafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCafe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpFloors;
        public System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Button btnBack;
    }
}