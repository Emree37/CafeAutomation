
namespace CafeAutomationCodeFirst.Forms
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvMonthReport = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(21, 47);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(685, 306);
            this.dgvOrders.TabIndex = 0;
            // 
            // dgvMonthReport
            // 
            this.dgvMonthReport.AllowUserToAddRows = false;
            this.dgvMonthReport.AllowUserToDeleteRows = false;
            this.dgvMonthReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthReport.Location = new System.Drawing.Point(725, 47);
            this.dgvMonthReport.MultiSelect = false;
            this.dgvMonthReport.Name = "dgvMonthReport";
            this.dgvMonthReport.ReadOnly = true;
            this.dgvMonthReport.RowTemplate.Height = 25;
            this.dgvMonthReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthReport.Size = new System.Drawing.Size(685, 306);
            this.dgvMonthReport.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(21, 370);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(38, 15);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "label1";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(251, 370);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(38, 15);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1316, 718);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 92);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "GERİ DÖN";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(725, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 23);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(910, 18);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(179, 23);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1113, 18);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "FİLTRELE";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilterPrice
            // 
            this.lblFilterPrice.AutoSize = true;
            this.lblFilterPrice.Location = new System.Drawing.Point(725, 369);
            this.lblFilterPrice.Name = "lblFilterPrice";
            this.lblFilterPrice.Size = new System.Drawing.Size(248, 15);
            this.lblFilterPrice.TabIndex = 9;
            this.lblFilterPrice.Text = "SEÇİLİ GÜNLER ARASI TOPLAM CİRO :     0.00₺";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1446, 822);
            this.Controls.Add(this.lblFilterPrice);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvMonthReport);
            this.Controls.Add(this.dgvOrders);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvMonthReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterPrice;
    }
}