namespace VehicleMonitoringSystem
{
    partial class NewSupplierForm
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
            this.supplierTB = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // supplierTB
            // 
            this.supplierTB.Location = new System.Drawing.Point(100, 39);
            this.supplierTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierTB.Name = "supplierTB";
            this.supplierTB.Size = new System.Drawing.Size(191, 20);
            this.supplierTB.TabIndex = 1;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(233, 62);
            this.saveB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(56, 24);
            this.saveB.TabIndex = 3;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // NewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 102);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.supplierTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewSupplierForm";
            this.Text = "Add New Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierTB;
        private System.Windows.Forms.Button saveB;
    }
}
