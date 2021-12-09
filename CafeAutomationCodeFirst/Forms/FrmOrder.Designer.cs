﻿
namespace CafeAutomationCodeFirst.Forms
{
    partial class FrmOrder
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
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // flpCategories
            // 
            this.flpCategories.AutoScroll = true;
            this.flpCategories.Location = new System.Drawing.Point(12, 31);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(530, 147);
            this.flpCategories.TabIndex = 0;
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(12, 184);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(530, 147);
            this.flpProducts.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 68);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(227, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 68);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(334, 372);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(101, 68);
            this.btnBill.TabIndex = 5;
            this.btnBill.Text = "ADİSYON";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.Location = new System.Drawing.Point(441, 372);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(101, 68);
            this.btnCloseTable.TabIndex = 6;
            this.btnCloseTable.Text = "MASAYI KAPAT";
            this.btnCloseTable.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 15;
            this.lstOrders.Location = new System.Drawing.Point(606, 31);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(293, 409);
            this.lstOrders.TabIndex = 7;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 537);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.flpCategories);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.ListBox lstOrders;
    }
}