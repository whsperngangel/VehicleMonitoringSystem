namespace VehicleMonitoringSystem
{
    partial class RepairDetailsForm
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
            this.detailListLV = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partSupplierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partInvoiceNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.partTotalTB = new System.Windows.Forms.TextBox();
            this.partDescriptionL = new System.Windows.Forms.Label();
            this.invoiceNumberTB = new System.Windows.Forms.TextBox();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.repairCancelB = new System.Windows.Forms.Button();
            this.repairEditB = new System.Windows.Forms.Button();
            this.purchaseDateDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // detailListLV
            // 
            this.detailListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.partDescriptionHeader,
            this.partDateHeader,
            this.partSupplierHeader,
            this.partInvoiceNumberHeader,
            this.amountHeader});
            this.detailListLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.detailListLV.FullRowSelect = true;
            this.detailListLV.HideSelection = false;
            this.detailListLV.Location = new System.Drawing.Point(18, 170);
            this.detailListLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailListLV.Name = "detailListLV";
            this.detailListLV.Size = new System.Drawing.Size(894, 284);
            this.detailListLV.TabIndex = 63;
            this.detailListLV.UseCompatibleStateImageBehavior = false;
            this.detailListLV.View = System.Windows.Forms.View.Details;
            this.detailListLV.SelectedIndexChanged += new System.EventHandler(this.DetailListLV_SelectedIndexChanged);
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 0;
            // 
            // partDescriptionHeader
            // 
            this.partDescriptionHeader.Text = "Part Description";
            this.partDescriptionHeader.Width = 179;
            // 
            // partDateHeader
            // 
            this.partDateHeader.Text = "Date";
            this.partDateHeader.Width = 167;
            // 
            // partSupplierHeader
            // 
            this.partSupplierHeader.Text = "Supplier";
            this.partSupplierHeader.Width = 164;
            // 
            // partInvoiceNumberHeader
            // 
            this.partInvoiceNumberHeader.Text = "Invoice Number";
            this.partInvoiceNumberHeader.Width = 166;
            // 
            // amountHeader
            // 
            this.amountHeader.Text = "Amount";
            this.amountHeader.Width = 184;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 479);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Total:";
            // 
            // partTotalTB
            // 
            this.partTotalTB.Enabled = false;
            this.partTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTotalTB.Location = new System.Drawing.Point(680, 474);
            this.partTotalTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partTotalTB.Name = "partTotalTB";
            this.partTotalTB.Size = new System.Drawing.Size(232, 26);
            this.partTotalTB.TabIndex = 64;
            this.partTotalTB.Text = "0.00";
            // 
            // partDescriptionL
            // 
            this.partDescriptionL.AutoSize = true;
            this.partDescriptionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partDescriptionL.Location = new System.Drawing.Point(13, 27);
            this.partDescriptionL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partDescriptionL.Name = "partDescriptionL";
            this.partDescriptionL.Size = new System.Drawing.Size(126, 20);
            this.partDescriptionL.TabIndex = 66;
            this.partDescriptionL.Text = "Part Description:";
            // 
            // invoiceNumberTB
            // 
            this.invoiceNumberTB.Enabled = false;
            this.invoiceNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.invoiceNumberTB.Location = new System.Drawing.Point(630, 26);
            this.invoiceNumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceNumberTB.Name = "invoiceNumberTB";
            this.invoiceNumberTB.Size = new System.Drawing.Size(282, 26);
            this.invoiceNumberTB.TabIndex = 67;
            // 
            // partCB
            // 
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Enabled = false;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(157, 24);
            this.partCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(290, 28);
            this.partCB.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Purchased Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Supplier:";
            // 
            // supplierCB
            // 
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.Enabled = false;
            this.supplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(157, 116);
            this.supplierCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(290, 28);
            this.supplierCB.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(499, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Invoice Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(499, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Amount:";
            // 
            // amountTB
            // 
            this.amountTB.Enabled = false;
            this.amountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountTB.Location = new System.Drawing.Point(630, 70);
            this.amountTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(282, 26);
            this.amountTB.TabIndex = 74;
            this.amountTB.Text = "PHP 0.00";
            this.amountTB.Click += new System.EventHandler(this.amountTB_Click);
            this.amountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTB_KeyPress);
            // 
            // repairCancelB
            // 
            this.repairCancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCancelB.Location = new System.Drawing.Point(798, 112);
            this.repairCancelB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairCancelB.Name = "repairCancelB";
            this.repairCancelB.Size = new System.Drawing.Size(112, 35);
            this.repairCancelB.TabIndex = 77;
            this.repairCancelB.Text = "Cancel";
            this.repairCancelB.UseVisualStyleBackColor = true;
            this.repairCancelB.Visible = false;
            this.repairCancelB.Click += new System.EventHandler(this.RepairCancelB_Click);
            // 
            // repairEditB
            // 
            this.repairEditB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairEditB.Location = new System.Drawing.Point(678, 112);
            this.repairEditB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairEditB.Name = "repairEditB";
            this.repairEditB.Size = new System.Drawing.Size(112, 35);
            this.repairEditB.TabIndex = 78;
            this.repairEditB.Text = "Edit";
            this.repairEditB.UseVisualStyleBackColor = true;
            this.repairEditB.Click += new System.EventHandler(this.RepairEditB_Click);
            // 
            // purchaseDateDTP
            // 
            this.purchaseDateDTP.Enabled = false;
            this.purchaseDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchaseDateDTP.Location = new System.Drawing.Point(157, 71);
            this.purchaseDateDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purchaseDateDTP.Name = "purchaseDateDTP";
            this.purchaseDateDTP.Size = new System.Drawing.Size(290, 26);
            this.purchaseDateDTP.TabIndex = 79;
            // 
            // RepairDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 516);
            this.Controls.Add(this.purchaseDateDTP);
            this.Controls.Add(this.repairCancelB);
            this.Controls.Add(this.repairEditB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplierCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partCB);
            this.Controls.Add(this.invoiceNumberTB);
            this.Controls.Add(this.partDescriptionL);
            this.Controls.Add(this.detailListLV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partTotalTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RepairDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView detailListLV;
        private System.Windows.Forms.ColumnHeader partDateHeader;
        private System.Windows.Forms.ColumnHeader partDescriptionHeader;
        private System.Windows.Forms.ColumnHeader partInvoiceNumberHeader;
        private System.Windows.Forms.ColumnHeader partSupplierHeader;
        private System.Windows.Forms.ColumnHeader amountHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partTotalTB;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.Label partDescriptionL;
        private System.Windows.Forms.TextBox invoiceNumberTB;
        private System.Windows.Forms.ComboBox partCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Button repairCancelB;
        private System.Windows.Forms.Button repairEditB;
        private System.Windows.Forms.DateTimePicker purchaseDateDTP;
    }
}
