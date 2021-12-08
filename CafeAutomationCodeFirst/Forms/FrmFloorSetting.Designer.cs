
namespace CafeAutomationCodeFirst.Forms
{
    partial class FrmFloorSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFloorName = new System.Windows.Forms.TextBox();
            this.txtTableCount = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtFloorOrder = new System.Windows.Forms.TextBox();
            this.btnFloorAdd = new System.Windows.Forms.Button();
            this.lstFloor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAT ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIRASI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "KODU :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "MASA SAYISI :";
            // 
            // txtFloorName
            // 
            this.txtFloorName.Location = new System.Drawing.Point(151, 47);
            this.txtFloorName.Name = "txtFloorName";
            this.txtFloorName.Size = new System.Drawing.Size(100, 23);
            this.txtFloorName.TabIndex = 4;
            // 
            // txtTableCount
            // 
            this.txtTableCount.Location = new System.Drawing.Point(151, 137);
            this.txtTableCount.Name = "txtTableCount";
            this.txtTableCount.Size = new System.Drawing.Size(100, 23);
            this.txtTableCount.TabIndex = 5;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(151, 105);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 23);
            this.txtWord.TabIndex = 6;
            // 
            // txtFloorOrder
            // 
            this.txtFloorOrder.Location = new System.Drawing.Point(151, 76);
            this.txtFloorOrder.Name = "txtFloorOrder";
            this.txtFloorOrder.Size = new System.Drawing.Size(100, 23);
            this.txtFloorOrder.TabIndex = 7;
            // 
            // btnFloorAdd
            // 
            this.btnFloorAdd.Location = new System.Drawing.Point(151, 190);
            this.btnFloorAdd.Name = "btnFloorAdd";
            this.btnFloorAdd.Size = new System.Drawing.Size(100, 57);
            this.btnFloorAdd.TabIndex = 8;
            this.btnFloorAdd.Text = "KAYDET";
            this.btnFloorAdd.UseVisualStyleBackColor = true;
            this.btnFloorAdd.Click += new System.EventHandler(this.btnFloorAdd_Click);
            // 
            // lstFloor
            // 
            this.lstFloor.FormattingEnabled = true;
            this.lstFloor.ItemHeight = 15;
            this.lstFloor.Location = new System.Drawing.Point(279, 47);
            this.lstFloor.Name = "lstFloor";
            this.lstFloor.Size = new System.Drawing.Size(157, 199);
            this.lstFloor.TabIndex = 9;
            this.lstFloor.SelectedIndexChanged += new System.EventHandler(this.lstFloor_SelectedIndexChanged);
            // 
            // FrmFloorSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFloor);
            this.Controls.Add(this.btnFloorAdd);
            this.Controls.Add(this.txtFloorOrder);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtTableCount);
            this.Controls.Add(this.txtFloorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFloorSetting";
            this.Text = "FrmFloorSetting";
            this.Load += new System.EventHandler(this.FrmFloorSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.TextBox txtTableCount;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtFloorOrder;
        private System.Windows.Forms.Button btnFloorAdd;
        private System.Windows.Forms.ListBox lstFloor;
    }
}