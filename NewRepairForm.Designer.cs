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
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.partAmountTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.addB = new System.Windows.Forms.Button();
            this.partDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
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
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierGB = new System.Windows.Forms.GroupBox();
            this.vehicleDetailGB = new System.Windows.Forms.GroupBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.payB = new System.Windows.Forms.Button();
            this.doneB = new System.Windows.Forms.Button();
            this.repairGB.SuspendLayout();
            this.supplierGB.SuspendLayout();
            this.vehicleDetailGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // repairDateDTP
            // 
            this.repairDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.repairDateDTP.Location = new System.Drawing.Point(139, 81);
            this.repairDateDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairDateDTP.Name = "repairDateDTP";
            this.repairDateDTP.Size = new System.Drawing.Size(277, 26);
            this.repairDateDTP.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Amount:";
            // 
            // repairAmountTB
            // 
            this.repairAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairAmountTB.Location = new System.Drawing.Point(139, 172);
            this.repairAmountTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairAmountTB.Name = "repairAmountTB";
            this.repairAmountTB.Size = new System.Drawing.Size(277, 26);
            this.repairAmountTB.TabIndex = 22;
            this.repairAmountTB.Text = "PHP 0.00";
            this.repairAmountTB.Click += new System.EventHandler(this.repairAmountTB_Click);
            this.repairAmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repairAmountTB_KeyPress);
            // 
            // repairSupplierCB
            // 
            this.repairSupplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repairSupplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairSupplierCB.FormattingEnabled = true;
            this.repairSupplierCB.Location = new System.Drawing.Point(139, 33);
            this.repairSupplierCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairSupplierCB.Name = "repairSupplierCB";
            this.repairSupplierCB.Size = new System.Drawing.Size(277, 28);
            this.repairSupplierCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Repair Shop:";
            // 
            // typeOfRepairCB
            // 
            this.typeOfRepairCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfRepairCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfRepairCB.FormattingEnabled = true;
            this.typeOfRepairCB.Items.AddRange(new object[] {
            "General",
            "Minor"});
            this.typeOfRepairCB.Location = new System.Drawing.Point(139, 217);
            this.typeOfRepairCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeOfRepairCB.Name = "typeOfRepairCB";
            this.typeOfRepairCB.Size = new System.Drawing.Size(277, 28);
            this.typeOfRepairCB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type of Repair:";
            // 
            // repairGB
            // 
            this.repairGB.Controls.Add(this.payB);
            this.repairGB.Controls.Add(this.statusCB);
            this.repairGB.Controls.Add(this.doneB);
            this.repairGB.Controls.Add(this.partAmountTB);
            this.repairGB.Controls.Add(this.label6);
            this.repairGB.Controls.Add(this.partCB);
            this.repairGB.Controls.Add(this.addB);
            this.repairGB.Controls.Add(this.cancelB);
            this.repairGB.Controls.Add(this.partDateDTP);
            this.repairGB.Controls.Add(this.label2);
            this.repairGB.Controls.Add(this.label7);
            this.repairGB.Controls.Add(this.partInvoiceNumberTB);
            this.repairGB.Controls.Add(this.label14);
            this.repairGB.Controls.Add(this.label15);
            this.repairGB.Controls.Add(this.partSupplierCB);
            this.repairGB.Controls.Add(this.label13);
            this.repairGB.Location = new System.Drawing.Point(454, 14);
            this.repairGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairGB.Name = "repairGB";
            this.repairGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairGB.Size = new System.Drawing.Size(435, 397);
            this.repairGB.TabIndex = 38;
            this.repairGB.TabStop = false;
            this.repairGB.Text = "Parts";
            // 
            // statusCB
            // 
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Repaired",
            "Replaced"});
            this.statusCB.Location = new System.Drawing.Point(139, 255);
            this.statusCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(283, 28);
            this.statusCB.TabIndex = 30;
            // 
            // partAmountTB
            // 
            this.partAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAmountTB.Location = new System.Drawing.Point(139, 214);
            this.partAmountTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partAmountTB.Name = "partAmountTB";
            this.partAmountTB.Size = new System.Drawing.Size(283, 26);
            this.partAmountTB.TabIndex = 29;
            this.partAmountTB.Text = "PHP 0.00";
            this.partAmountTB.Click += new System.EventHandler(this.partAmountTB_Click);
            this.partAmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partAmountTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Amount:";
            // 
            // partCB
            // 
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(139, 167);
            this.partCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(283, 28);
            this.partCB.TabIndex = 27;
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(293, 293);
            this.addB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(129, 43);
            this.addB.TabIndex = 26;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // partDateDTP
            // 
            this.partDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.partDateDTP.Location = new System.Drawing.Point(139, 79);
            this.partDateDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partDateDTP.Name = "partDateDTP";
            this.partDateDTP.Size = new System.Drawing.Size(283, 26);
            this.partDateDTP.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Invoice Number:";
            // 
            // partInvoiceNumberTB
            // 
            this.partInvoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInvoiceNumberTB.Location = new System.Drawing.Point(139, 124);
            this.partInvoiceNumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partInvoiceNumberTB.Name = "partInvoiceNumberTB";
            this.partInvoiceNumberTB.Size = new System.Drawing.Size(283, 26);
            this.partInvoiceNumberTB.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 258);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 170);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.partSupplierCB.Location = new System.Drawing.Point(139, 33);
            this.partSupplierCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partSupplierCB.Name = "partSupplierCB";
            this.partSupplierCB.Size = new System.Drawing.Size(283, 28);
            this.partSupplierCB.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Supplier:";
            // 
            // repairInvoiceNumberTB
            // 
            this.repairInvoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairInvoiceNumberTB.Location = new System.Drawing.Point(139, 126);
            this.repairInvoiceNumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairInvoiceNumberTB.Name = "repairInvoiceNumberTB";
            this.repairInvoiceNumberTB.Size = new System.Drawing.Size(277, 26);
            this.repairInvoiceNumberTB.TabIndex = 14;
            // 
            // vehicleNameL
            // 
            this.vehicleNameL.AutoSize = true;
            this.vehicleNameL.Location = new System.Drawing.Point(134, 85);
            this.vehicleNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicleNameL.Name = "vehicleNameL";
            this.vehicleNameL.Size = new System.Drawing.Size(0, 20);
            this.vehicleNameL.TabIndex = 16;
            // 
            // vehicleDetailL
            // 
            this.vehicleDetailL.AutoSize = true;
            this.vehicleDetailL.Location = new System.Drawing.Point(134, 85);
            this.vehicleDetailL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicleDetailL.Name = "vehicleDetailL";
            this.vehicleDetailL.Size = new System.Drawing.Size(0, 20);
            this.vehicleDetailL.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.plateNumberCB.Location = new System.Drawing.Point(138, 38);
            this.plateNumberCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(277, 28);
            this.plateNumberCB.TabIndex = 12;
            this.plateNumberCB.SelectedIndexChanged += new System.EventHandler(this.plateNumberCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plate Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.amountHeader,
            this.statusHeader});
            this.partListLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partListLV.FullRowSelect = true;
            this.partListLV.HideSelection = false;
            this.partListLV.Location = new System.Drawing.Point(14, 421);
            this.partListLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partListLV.Name = "partListLV";
            this.partListLV.Size = new System.Drawing.Size(876, 298);
            this.partListLV.TabIndex = 39;
            this.partListLV.UseCompatibleStateImageBehavior = false;
            this.partListLV.View = System.Windows.Forms.View.Details;
            this.partListLV.SelectedIndexChanged += new System.EventHandler(this.PartListLV_SelectedIndexChanged);
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "";
            this.IDHeader.Width = 0;
            // 
            // partSupplierHeader
            // 
            this.partSupplierHeader.Text = "Supplier ";
            this.partSupplierHeader.Width = 116;
            // 
            // purchasedDateHeader
            // 
            this.purchasedDateHeader.Text = "Purchased Date";
            this.purchasedDateHeader.Width = 180;
            // 
            // partInvoiceHeader
            // 
            this.partInvoiceHeader.Text = "Invoice Number";
            this.partInvoiceHeader.Width = 189;
            // 
            // partHeader
            // 
            this.partHeader.Text = "Repair Part";
            this.partHeader.Width = 161;
            // 
            // amountHeader
            // 
            this.amountHeader.Text = "Amount";
            this.amountHeader.Width = 132;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 96;
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
            this.supplierGB.Location = new System.Drawing.Point(13, 148);
            this.supplierGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierGB.Name = "supplierGB";
            this.supplierGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierGB.Size = new System.Drawing.Size(433, 263);
            this.supplierGB.TabIndex = 37;
            this.supplierGB.TabStop = false;
            this.supplierGB.Text = "Repair";
            // 
            // vehicleDetailGB
            // 
            this.vehicleDetailGB.Controls.Add(this.vehicleNameL);
            this.vehicleDetailGB.Controls.Add(this.vehicleDetailL);
            this.vehicleDetailGB.Controls.Add(this.label11);
            this.vehicleDetailGB.Controls.Add(this.plateNumberCB);
            this.vehicleDetailGB.Controls.Add(this.label1);
            this.vehicleDetailGB.Location = new System.Drawing.Point(13, 14);
            this.vehicleDetailGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleDetailGB.Name = "vehicleDetailGB";
            this.vehicleDetailGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleDetailGB.Size = new System.Drawing.Size(433, 124);
            this.vehicleDetailGB.TabIndex = 36;
            this.vehicleDetailGB.TabStop = false;
            this.vehicleDetailGB.Text = "Vehicle Detail";
            // 
            // cancelB
            // 
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(156, 346);
            this.cancelB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(129, 43);
            this.cancelB.TabIndex = 35;
            this.cancelB.Text = "Cancel";
            // 
            // payB
            // 
            this.payB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payB.Location = new System.Drawing.Point(19, 346);
            this.payB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payB.Name = "payB";
            this.payB.Size = new System.Drawing.Size(129, 43);
            this.payB.TabIndex = 40;
            this.payB.Text = "Pay";
            this.payB.UseVisualStyleBackColor = true;
            this.payB.Click += new System.EventHandler(this.payB_Click);
            // 
            // doneB
            // 
            this.doneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneB.Location = new System.Drawing.Point(293, 346);
            this.doneB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doneB.Name = "doneB";
            this.doneB.Size = new System.Drawing.Size(129, 43);
            this.doneB.TabIndex = 42;
            this.doneB.Text = "Done";
            this.doneB.UseVisualStyleBackColor = true;
            // 
            // NewRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 731);
            this.Controls.Add(this.repairGB);
            this.Controls.Add(this.partListLV);
            this.Controls.Add(this.supplierGB);
            this.Controls.Add(this.vehicleDetailGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance and Repair Form";
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
        private System.Windows.Forms.GroupBox vehicleDetailGB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.TextBox partAmountTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button payB;
        private System.Windows.Forms.Button doneB;
    }
}
