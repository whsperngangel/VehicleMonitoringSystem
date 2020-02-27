namespace VehicleMonitoringSystem
{
    partial class NewRepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRepairForm));
            this.repairDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.repairAmountTB = new System.Windows.Forms.TextBox();
            this.repairSupplierCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeOfRepairCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repairGB = new System.Windows.Forms.GroupBox();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.addB = new System.Windows.Forms.Button();
            this.partDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.partAmountTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.partInvoiceNumberTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.partSupplierCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.repairInvoiceNumberTB = new System.Windows.Forms.TextBox();
            this.vehicleNameL = new System.Windows.Forms.Label();
            this.vehicleDetailL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partListLV = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partSupplierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchasedDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partInvoiceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierGB = new System.Windows.Forms.GroupBox();
            this.doneB = new System.Windows.Forms.Button();
            this.vehicleDetailGB = new System.Windows.Forms.GroupBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.payB = new System.Windows.Forms.Button();
            this.repairGB.SuspendLayout();
            this.supplierGB.SuspendLayout();
            this.vehicleDetailGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // repairDateDTP
            // 
            this.repairDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.repairDateDTP.Location = new System.Drawing.Point(132, 48);
            this.repairDateDTP.Name = "repairDateDTP";
            this.repairDateDTP.Size = new System.Drawing.Size(233, 26);
            this.repairDateDTP.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Amount:";
            // 
            // repairAmountTB
            // 
            this.repairAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairAmountTB.Location = new System.Drawing.Point(134, 115);
            this.repairAmountTB.Name = "repairAmountTB";
            this.repairAmountTB.Size = new System.Drawing.Size(231, 26);
            this.repairAmountTB.TabIndex = 22;
            // 
            // repairSupplierCB
            // 
            this.repairSupplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repairSupplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairSupplierCB.FormattingEnabled = true;
            this.repairSupplierCB.Location = new System.Drawing.Point(132, 14);
            this.repairSupplierCB.Name = "repairSupplierCB";
            this.repairSupplierCB.Size = new System.Drawing.Size(231, 28);
            this.repairSupplierCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Repair Shop:";
            // 
            // typeOfRepairCB
            // 
            this.typeOfRepairCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfRepairCB.FormattingEnabled = true;
            this.typeOfRepairCB.Items.AddRange(new object[] {
            "General",
            "Minor"});
            this.typeOfRepairCB.Location = new System.Drawing.Point(132, 151);
            this.typeOfRepairCB.Name = "typeOfRepairCB";
            this.typeOfRepairCB.Size = new System.Drawing.Size(231, 28);
            this.typeOfRepairCB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type of Repair:";
            // 
            // repairGB
            // 
            this.repairGB.Controls.Add(this.partCB);
            this.repairGB.Controls.Add(this.addB);
            this.repairGB.Controls.Add(this.partDateDTP);
            this.repairGB.Controls.Add(this.label2);
            this.repairGB.Controls.Add(this.partAmountTB);
            this.repairGB.Controls.Add(this.label7);
            this.repairGB.Controls.Add(this.partInvoiceNumberTB);
            this.repairGB.Controls.Add(this.label14);
            this.repairGB.Controls.Add(this.label15);
            this.repairGB.Controls.Add(this.partSupplierCB);
            this.repairGB.Controls.Add(this.label13);
            this.repairGB.Location = new System.Drawing.Point(404, 15);
            this.repairGB.Name = "repairGB";
            this.repairGB.Size = new System.Drawing.Size(376, 316);
            this.repairGB.TabIndex = 38;
            this.repairGB.TabStop = false;
            this.repairGB.Text = "Parts";
            // 
            // partCB
            // 
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(132, 154);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(184, 28);
            this.partCB.TabIndex = 27;
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(230, 250);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(86, 28);
            this.addB.TabIndex = 26;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // partDateDTP
            // 
            this.partDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.partDateDTP.Location = new System.Drawing.Point(133, 70);
            this.partDateDTP.Name = "partDateDTP";
            this.partDateDTP.Size = new System.Drawing.Size(184, 26);
            this.partDateDTP.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // partAmountTB
            // 
            this.partAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAmountTB.Location = new System.Drawing.Point(133, 187);
            this.partAmountTB.Name = "partAmountTB";
            this.partAmountTB.Size = new System.Drawing.Size(184, 26);
            this.partAmountTB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Invoice Number:";
            // 
            // partInvoiceNumberTB
            // 
            this.partInvoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInvoiceNumberTB.Location = new System.Drawing.Point(133, 105);
            this.partInvoiceNumberTB.Name = "partInvoiceNumberTB";
            this.partInvoiceNumberTB.Size = new System.Drawing.Size(184, 26);
            this.partInvoiceNumberTB.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Amount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(76, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Part:";
            // 
            // partSupplierCB
            // 
            this.partSupplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partSupplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSupplierCB.FormattingEnabled = true;
            this.partSupplierCB.Location = new System.Drawing.Point(133, 36);
            this.partSupplierCB.Name = "partSupplierCB";
            this.partSupplierCB.Size = new System.Drawing.Size(184, 28);
            this.partSupplierCB.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Supplier:";
            // 
            // repairInvoiceNumberTB
            // 
            this.repairInvoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairInvoiceNumberTB.Location = new System.Drawing.Point(133, 83);
            this.repairInvoiceNumberTB.Name = "repairInvoiceNumberTB";
            this.repairInvoiceNumberTB.Size = new System.Drawing.Size(231, 26);
            this.repairInvoiceNumberTB.TabIndex = 14;
            // 
            // vehicleNameL
            // 
            this.vehicleNameL.AutoSize = true;
            this.vehicleNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vehicleNameL.Location = new System.Drawing.Point(128, 78);
            this.vehicleNameL.Name = "vehicleNameL";
            this.vehicleNameL.Size = new System.Drawing.Size(0, 20);
            this.vehicleNameL.TabIndex = 16;
            // 
            // vehicleDetailL
            // 
            this.vehicleDetailL.AutoSize = true;
            this.vehicleDetailL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vehicleDetailL.Location = new System.Drawing.Point(129, 83);
            this.vehicleDetailL.Name = "vehicleDetailL";
            this.vehicleDetailL.Size = new System.Drawing.Size(0, 20);
            this.vehicleDetailL.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Vehicle Listing:";
            // 
            // plateNumberCB
            // 
            this.plateNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateNumberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberCB.FormattingEnabled = true;
            this.plateNumberCB.Location = new System.Drawing.Point(132, 39);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(186, 28);
            this.plateNumberCB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plate Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Invoice Number:";
            // 
            // partListLV
            // 
            this.partListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.partSupplierHeader,
            this.purchasedDateHeader,
            this.partInvoiceHeader,
            this.partHeader,
            this.amountHeader});
            this.partListLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partListLV.FullRowSelect = true;
            this.partListLV.HideSelection = false;
            this.partListLV.Location = new System.Drawing.Point(12, 359);
            this.partListLV.Name = "partListLV";
            this.partListLV.Size = new System.Drawing.Size(768, 232);
            this.partListLV.TabIndex = 39;
            this.partListLV.UseCompatibleStateImageBehavior = false;
            this.partListLV.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "";
            this.IDHeader.Width = 0;
            // 
            // partSupplierHeader
            // 
            this.partSupplierHeader.Text = "Supplier ";
            this.partSupplierHeader.Width = 146;
            // 
            // purchasedDateHeader
            // 
            this.purchasedDateHeader.Text = "Purchased Date";
            this.purchasedDateHeader.Width = 136;
            // 
            // partInvoiceHeader
            // 
            this.partInvoiceHeader.Text = "Invoice Number";
            this.partInvoiceHeader.Width = 148;
            // 
            // partHeader
            // 
            this.partHeader.Text = "Repair Part";
            this.partHeader.Width = 161;
            // 
            // amountHeader
            // 
            this.amountHeader.Text = "Amount";
            this.amountHeader.Width = 171;
            // 
            // supplierGB
            // 
            this.supplierGB.Controls.Add(this.repairDateDTP);
            this.supplierGB.Controls.Add(this.label9);
            this.supplierGB.Controls.Add(this.label5);
            this.supplierGB.Controls.Add(this.repairAmountTB);
            this.supplierGB.Controls.Add(this.repairSupplierCB);
            this.supplierGB.Controls.Add(this.label4);
            this.supplierGB.Controls.Add(this.typeOfRepairCB);
            this.supplierGB.Controls.Add(this.label3);
            this.supplierGB.Controls.Add(this.label8);
            this.supplierGB.Controls.Add(this.repairInvoiceNumberTB);
            this.supplierGB.Location = new System.Drawing.Point(12, 129);
            this.supplierGB.Name = "supplierGB";
            this.supplierGB.Size = new System.Drawing.Size(371, 202);
            this.supplierGB.TabIndex = 37;
            this.supplierGB.TabStop = false;
            this.supplierGB.Text = "Repair";
            // 
            // doneB
            // 
            this.doneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneB.Location = new System.Drawing.Point(711, 597);
            this.doneB.Name = "doneB";
            this.doneB.Size = new System.Drawing.Size(69, 28);
            this.doneB.TabIndex = 34;
            this.doneB.Text = "Done";
            this.doneB.UseVisualStyleBackColor = true;
            this.doneB.Click += new System.EventHandler(this.doneB_Click);
            // 
            // vehicleDetailGB
            // 
            this.vehicleDetailGB.Controls.Add(this.vehicleNameL);
            this.vehicleDetailGB.Controls.Add(this.vehicleDetailL);
            this.vehicleDetailGB.Controls.Add(this.label11);
            this.vehicleDetailGB.Controls.Add(this.plateNumberCB);
            this.vehicleDetailGB.Controls.Add(this.label1);
            this.vehicleDetailGB.Location = new System.Drawing.Point(12, 12);
            this.vehicleDetailGB.Name = "vehicleDetailGB";
            this.vehicleDetailGB.Size = new System.Drawing.Size(371, 111);
            this.vehicleDetailGB.TabIndex = 36;
            this.vehicleDetailGB.TabStop = false;
            this.vehicleDetailGB.Text = "Vehicle Detail";
            // 
            // cancelB
            // 
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(636, 597);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(69, 28);
            this.cancelB.TabIndex = 35;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click_1);
            // 
            // payB
            // 
            this.payB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payB.Location = new System.Drawing.Point(561, 597);
            this.payB.Name = "payB";
            this.payB.Size = new System.Drawing.Size(69, 28);
            this.payB.TabIndex = 34;
            this.payB.Text = "Pay";
            this.payB.UseVisualStyleBackColor = true;
            // 
            // NewRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 631);
            this.Controls.Add(this.repairGB);
            this.Controls.Add(this.partListLV);
            this.Controls.Add(this.supplierGB);
            this.Controls.Add(this.payB);
            this.Controls.Add(this.doneB);
            this.Controls.Add(this.vehicleDetailGB);
            this.Controls.Add(this.cancelB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Form";
            this.repairGB.ResumeLayout(false);
            this.repairGB.PerformLayout();
            this.supplierGB.ResumeLayout(false);
            this.supplierGB.PerformLayout();
            this.vehicleDetailGB.ResumeLayout(false);
            this.vehicleDetailGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox repairPartsAmount;
        private System.Windows.Forms.DateTimePicker repairDateDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairAmountTB;
        private System.Windows.Forms.ComboBox repairSupplierCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeOfRepairCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox repairGB;
        private System.Windows.Forms.ComboBox partCB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.DateTimePicker partDateDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partAmountTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox partInvoiceNumberTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox partSupplierCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox repairInvoiceNumberTB;
        private System.Windows.Forms.Label vehicleNameL;
        private System.Windows.Forms.Label vehicleDetailL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView partListLV;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader partSupplierHeader;
        private System.Windows.Forms.ColumnHeader purchasedDateHeader;
        private System.Windows.Forms.ColumnHeader partInvoiceHeader;
        private System.Windows.Forms.ColumnHeader partHeader;
        private System.Windows.Forms.ColumnHeader amountHeader;
        private System.Windows.Forms.GroupBox supplierGB;
        private System.Windows.Forms.Button doneB;
        private System.Windows.Forms.GroupBox vehicleDetailGB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button payB;
    }
}
