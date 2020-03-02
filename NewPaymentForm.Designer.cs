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
            this.label6 = new System.Windows.Forms.Label();
            this.invoiceNumberCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Paid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Paid:";
            // 
            // supplierCB
            // 
            this.supplierCB.AllowDrop = true;
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.Enabled = false;
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(144, 65);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(462, 28);
            this.supplierCB.Sorted = true;
            this.supplierCB.TabIndex = 3;
            this.supplierCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplierCB_KeyPress);
            // 
            // datePaidDTP
            // 
            this.datePaidDTP.Enabled = false;
            this.datePaidDTP.Location = new System.Drawing.Point(144, 193);
            this.datePaidDTP.Name = "datePaidDTP";
            this.datePaidDTP.Size = new System.Drawing.Size(462, 26);
            this.datePaidDTP.TabIndex = 4;
            // 
            // amountPaidTB
            // 
            this.amountPaidTB.Enabled = false;
            this.amountPaidTB.Location = new System.Drawing.Point(144, 235);
            this.amountPaidTB.Name = "amountPaidTB";
            this.amountPaidTB.Size = new System.Drawing.Size(462, 26);
            this.amountPaidTB.TabIndex = 5;
            this.amountPaidTB.Text = "PHP 0.00";
            this.amountPaidTB.Click += new System.EventHandler(this.amountPaidTB_Click);
            this.amountPaidTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountPaidTB_KeyPress);
            // 
            // saveB
            // 
            this.saveB.Enabled = false;
            this.saveB.Location = new System.Drawing.Point(369, 320);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 27);
            this.saveB.TabIndex = 6;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // clearB
            // 
            this.clearB.Enabled = false;
            this.clearB.Location = new System.Drawing.Point(531, 320);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 27);
            this.clearB.TabIndex = 7;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Enabled = false;
            this.cancelB.Location = new System.Drawing.Point(450, 320);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 27);
            this.cancelB.TabIndex = 8;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paid By:";
            // 
            // paidByCB
            // 
            this.paidByCB.Enabled = false;
            this.paidByCB.FormattingEnabled = true;
            this.paidByCB.Location = new System.Drawing.Point(144, 276);
            this.paidByCB.Name = "paidByCB";
            this.paidByCB.Size = new System.Drawing.Size(462, 28);
            this.paidByCB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance:";
            // 
            // balanceTB
            // 
            this.balanceTB.Enabled = false;
            this.balanceTB.Location = new System.Drawing.Point(144, 152);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(462, 26);
            this.balanceTB.TabIndex = 5;
            this.balanceTB.Text = "PHP 0.00";
            this.balanceTB.Click += new System.EventHandler(this.balanceTB_Click);
            this.balanceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Invoice Number:";
            // 
            // invoiceNumberCB
            // 
            this.invoiceNumberCB.AllowDrop = true;
            this.invoiceNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoiceNumberCB.Enabled = false;
            this.invoiceNumberCB.FormattingEnabled = true;
            this.invoiceNumberCB.Location = new System.Drawing.Point(144, 108);
            this.invoiceNumberCB.Name = "invoiceNumberCB";
            this.invoiceNumberCB.Size = new System.Drawing.Size(462, 28);
            this.invoiceNumberCB.Sorted = true;
            this.invoiceNumberCB.TabIndex = 10;
            // 
            // typeCB
            // 
            this.typeCB.AllowDrop = true;
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Fuel",
            "Part",
            "Repair"});
            this.typeCB.Location = new System.Drawing.Point(144, 22);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(462, 28);
            this.typeCB.Sorted = true;
            this.typeCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type:";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(623, 362);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.invoiceNumberCB);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox invoiceNumberCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label7;
    }
}
