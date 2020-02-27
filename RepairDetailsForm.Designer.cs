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
            this.detailListLV.HideSelection = false;
            this.detailListLV.Location = new System.Drawing.Point(12, 12);
            this.detailListLV.Name = "detailListLV";
            this.detailListLV.Size = new System.Drawing.Size(789, 232);
            this.detailListLV.TabIndex = 63;
            this.detailListLV.UseCompatibleStateImageBehavior = false;
            this.detailListLV.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            // 
            // partDescriptionHeader
            // 
            this.partDescriptionHeader.Text = "Part Description";
            this.partDescriptionHeader.Width = 155;
            // 
            // partDateHeader
            // 
            this.partDateHeader.Text = "Date";
            this.partDateHeader.Width = 149;
            // 
            // partSupplierHeader
            // 
            this.partSupplierHeader.Text = "Supplier";
            this.partSupplierHeader.Width = 192;
            // 
            // partInvoiceNumberHeader
            // 
            this.partInvoiceNumberHeader.Text = "Invoice Number";
            this.partInvoiceNumberHeader.Width = 149;
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
            this.label2.Location = new System.Drawing.Point(576, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Total:";
            // 
            // partTotalTB
            // 
            this.partTotalTB.Enabled = false;
            this.partTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTotalTB.Location = new System.Drawing.Point(639, 257);
            this.partTotalTB.Name = "partTotalTB";
            this.partTotalTB.Size = new System.Drawing.Size(158, 26);
            this.partTotalTB.TabIndex = 64;
            this.partTotalTB.Text = "0.00";
            // 
            // RepairDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 295);
            this.Controls.Add(this.detailListLV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partTotalTB);
            this.Name = "RepairDetailsForm";
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
    }
}
