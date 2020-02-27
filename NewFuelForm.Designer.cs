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
            this.doneB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.payB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.typeOfFuelCB = new System.Windows.Forms.ComboBox();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.vehicleCB = new System.Windows.Forms.ComboBox();
            this.fuelIDTB = new System.Windows.Forms.TextBox();
            this.invoiceNumberTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doneB
            // 
            this.doneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneB.Location = new System.Drawing.Point(757, 258);
            this.doneB.Name = "doneB";
            this.doneB.Size = new System.Drawing.Size(75, 29);
            this.doneB.TabIndex = 8;
            this.doneB.Text = "Done";
            this.doneB.UseVisualStyleBackColor = true;
            this.doneB.Click += new System.EventHandler(this.doneB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(676, 258);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 29);
            this.cancelB.TabIndex = 9;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // payB
            // 
            this.payB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payB.Location = new System.Drawing.Point(595, 258);
            this.payB.Name = "payB";
            this.payB.Size = new System.Drawing.Size(75, 29);
            this.payB.TabIndex = 10;
            this.payB.Text = "Pay";
            this.payB.UseVisualStyleBackColor = true;
            this.payB.Click += new System.EventHandler(this.payB_Click);
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
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(141, 226);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(691, 26);
            this.amountTB.TabIndex = 6;
            this.amountTB.Text = "0.00";
            // 
            // dateDTP
            // 
            this.dateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(141, 82);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(691, 26);
            this.dateDTP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vehicle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
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
            this.plateNumberCB.Size = new System.Drawing.Size(691, 28);
            this.plateNumberCB.TabIndex = 0;
            // 
            // typeOfFuelCB
            // 
            this.typeOfFuelCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfFuelCB.FormattingEnabled = true;
            this.typeOfFuelCB.Items.AddRange(new object[] {
            "Diesel",
            "Unleaded",
            "Premium",
            "LPG"});
            this.typeOfFuelCB.Location = new System.Drawing.Point(141, 117);
            this.typeOfFuelCB.Name = "typeOfFuelCB";
            this.typeOfFuelCB.Size = new System.Drawing.Size(691, 28);
            this.typeOfFuelCB.TabIndex = 3;
            // 
            // supplierCB
            // 
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(141, 188);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(691, 28);
            this.supplierCB.TabIndex = 5;
            // 
            // vehicleCB
            // 
            this.vehicleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCB.FormattingEnabled = true;
            this.vehicleCB.Location = new System.Drawing.Point(141, 47);
            this.vehicleCB.Name = "vehicleCB";
            this.vehicleCB.Size = new System.Drawing.Size(691, 28);
            this.vehicleCB.TabIndex = 1;
            // 
            // fuelIDTB
            // 
            this.fuelIDTB.Location = new System.Drawing.Point(141, 266);
            this.fuelIDTB.Name = "fuelIDTB";
            this.fuelIDTB.Size = new System.Drawing.Size(100, 20);
            this.fuelIDTB.TabIndex = 13;
            // 
            // invoiceNumberTB
            // 
            this.invoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberTB.Location = new System.Drawing.Point(141, 154);
            this.invoiceNumberTB.Name = "invoiceNumberTB";
            this.invoiceNumberTB.Size = new System.Drawing.Size(691, 26);
            this.invoiceNumberTB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Invoice Number:";
            // 
            // newB
            // 
            this.newB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newB.Location = new System.Drawing.Point(12, 258);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(109, 29);
            this.newB.TabIndex = 7;
            this.newB.Text = "New Supplier";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // NewFuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 296);
            this.Controls.Add(this.invoiceNumberTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fuelIDTB);
            this.Controls.Add(this.supplierCB);
            this.Controls.Add(this.typeOfFuelCB);
            this.Controls.Add(this.vehicleCB);
            this.Controls.Add(this.plateNumberCB);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.newB);
            this.Controls.Add(this.doneB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFuelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Fuel Record";
            this.Load += new System.EventHandler(this.NewFuelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button payB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.ComboBox typeOfFuelCB;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.ComboBox vehicleCB;
        private System.Windows.Forms.TextBox fuelIDTB;
        private System.Windows.Forms.TextBox invoiceNumberTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button newB;
    }
}
