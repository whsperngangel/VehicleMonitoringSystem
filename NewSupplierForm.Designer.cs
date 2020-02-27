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
            this.label2 = new System.Windows.Forms.Label();
            this.supplierIDTB = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // supplierTB
            // 
            this.supplierTB.Location = new System.Drawing.Point(133, 48);
            this.supplierTB.Name = "supplierTB";
            this.supplierTB.Size = new System.Drawing.Size(253, 22);
            this.supplierTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            this.label2.Visible = false;
            // 
            // supplierIDTB
            // 
            this.supplierIDTB.Location = new System.Drawing.Point(43, 97);
            this.supplierIDTB.Name = "supplierIDTB";
            this.supplierIDTB.Size = new System.Drawing.Size(253, 22);
            this.supplierIDTB.TabIndex = 1;
            this.supplierIDTB.Visible = false;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(311, 76);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 30);
            this.saveB.TabIndex = 3;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // NewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 126);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierIDTB);
            this.Controls.Add(this.supplierTB);
            this.Controls.Add(this.label1);
            this.Name = "NewSupplierForm";
            this.Text = "Add New Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierIDTB;
        private System.Windows.Forms.Button saveB;
    }
}
