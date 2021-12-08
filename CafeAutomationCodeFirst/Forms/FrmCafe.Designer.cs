
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
            this.SuspendLayout();
            // 
            // flpFloors
            // 
            this.flpFloors.Location = new System.Drawing.Point(13, 13);
            this.flpFloors.Name = "flpFloors";
            this.flpFloors.Size = new System.Drawing.Size(775, 100);
            this.flpFloors.TabIndex = 0;
            // 
            // flpTables
            // 
            this.flpTables.Location = new System.Drawing.Point(13, 137);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(775, 301);
            this.flpTables.TabIndex = 1;
            // 
            // FrmCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpTables);
            this.Controls.Add(this.flpFloors);
            this.Name = "FrmCafe";
            this.Text = "FrmCafe";
            this.Load += new System.EventHandler(this.FrmCafe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFloors;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
    }
}