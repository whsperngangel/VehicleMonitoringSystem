namespace VehicleMonitoringSystem
{
    partial class NewPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPaymentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.datePaidDTP = new System.Windows.Forms.DateTimePicker();
            this.amountPaidTB = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.paidByCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.invoiceNumberTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Paid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Paid:";
            // 
            // supplierCB
            // 
            this.supplierCB.AllowDrop = true;
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(141, 12);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(523, 28);
            this.supplierCB.Sorted = true;
            this.supplierCB.TabIndex = 0;
            this.supplierCB.SelectedIndexChanged += new System.EventHandler(this.supplierCB_SelectedIndexChanged);
            this.supplierCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplierCB_KeyPress);
            // 
            // datePaidDTP
            // 
            this.datePaidDTP.Location = new System.Drawing.Point(141, 139);
            this.datePaidDTP.Name = "datePaidDTP";
            this.datePaidDTP.Size = new System.Drawing.Size(523, 26);
            this.datePaidDTP.TabIndex = 3;
            // 
            // amountPaidTB
            // 
            this.amountPaidTB.Location = new System.Drawing.Point(141, 180);
            this.amountPaidTB.Name = "amountPaidTB";
            this.amountPaidTB.Size = new System.Drawing.Size(523, 26);
            this.amountPaidTB.TabIndex = 4;
            this.amountPaidTB.Text = "P 0.00";
            this.amountPaidTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountPaidTB_KeyPress);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(427, 264);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 27);
            this.saveB.TabIndex = 6;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(589, 264);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 27);
            this.clearB.TabIndex = 8;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(508, 264);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 27);
            this.cancelB.TabIndex = 7;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paid By:";
            // 
            // paidByCB
            // 
            this.paidByCB.FormattingEnabled = true;
            this.paidByCB.Location = new System.Drawing.Point(141, 221);
            this.paidByCB.Name = "paidByCB";
            this.paidByCB.Size = new System.Drawing.Size(523, 28);
            this.paidByCB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance:";
            // 
            // balanceTB
            // 
            this.balanceTB.Enabled = false;
            this.balanceTB.Location = new System.Drawing.Point(141, 98);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(523, 26);
            this.balanceTB.TabIndex = 2;
            this.balanceTB.Text = "P 0.00";
            this.balanceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTB_KeyPress);
            // 
            // invoiceNumberTB
            // 
            this.invoiceNumberTB.Location = new System.Drawing.Point(141, 56);
            this.invoiceNumberTB.Name = "invoiceNumberTB";
            this.invoiceNumberTB.Size = new System.Drawing.Size(523, 26);
            this.invoiceNumberTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Invoice Number:";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(679, 304);
            this.Controls.Add(this.invoiceNumberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.balanceTB);
            this.Controls.Add(this.amountPaidTB);
            this.Controls.Add(this.datePaidDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paidByCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supplierCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.DateTimePicker datePaidDTP;
        private System.Windows.Forms.TextBox amountPaidTB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox paidByCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.TextBox invoiceNumberTB;
        private System.Windows.Forms.Label label6;
    }
}
