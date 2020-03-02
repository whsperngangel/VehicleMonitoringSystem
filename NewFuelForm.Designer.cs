namespace VehicleMonitoringSystem
{
    partial class NewFuelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFuelForm));
            this.saveB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.typeOfFuelCB = new System.Windows.Forms.ComboBox();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.invoiceNumberTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveB.Location = new System.Drawing.Point(500, 261);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 29);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(581, 261);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 29);
            this.cancelB.TabIndex = 1;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(662, 261);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 29);
            this.clearB.TabIndex = 2;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plate Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(141, 221);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(596, 26);
            this.amountTB.TabIndex = 10;
            this.amountTB.Text = "PHP 0.00";
            this.amountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTB_KeyPress);
            // 
            // dateDTP
            // 
            this.dateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(141, 52);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(596, 26);
            this.dateDTP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type of Fuel:";
            // 
            // plateNumberCB
            // 
            this.plateNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateNumberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberCB.FormattingEnabled = true;
            this.plateNumberCB.Location = new System.Drawing.Point(141, 9);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(596, 28);
            this.plateNumberCB.TabIndex = 12;
            // 
            // typeOfFuelCB
            // 
            this.typeOfFuelCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfFuelCB.FormattingEnabled = true;
            this.typeOfFuelCB.Items.AddRange(new object[] {
            "Diesel",
            "Unleaded",
            "LPG"});
            this.typeOfFuelCB.Location = new System.Drawing.Point(141, 94);
            this.typeOfFuelCB.Name = "typeOfFuelCB";
            this.typeOfFuelCB.Size = new System.Drawing.Size(596, 28);
            this.typeOfFuelCB.TabIndex = 12;
            // 
            // supplierCB
            // 
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(141, 178);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(596, 28);
            this.supplierCB.TabIndex = 12;
            // 
            // invoiceNumberTB
            // 
            this.invoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberTB.Location = new System.Drawing.Point(141, 137);
            this.invoiceNumberTB.Name = "invoiceNumberTB";
            this.invoiceNumberTB.Size = new System.Drawing.Size(596, 26);
            this.invoiceNumberTB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Invoice Number:";
            // 
            // NewFuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 302);
            this.Controls.Add(this.invoiceNumberTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supplierCB);
            this.Controls.Add(this.typeOfFuelCB);
            this.Controls.Add(this.plateNumberCB);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFuelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Fuel Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.ComboBox typeOfFuelCB;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.TextBox invoiceNumberTB;
        private System.Windows.Forms.Label label7;
    }
}
