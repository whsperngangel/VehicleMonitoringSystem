namespace VehicleMonitoringSystem
{
    partial class NewPartForm
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
            this.addPartB = new System.Windows.Forms.Button();
            this.partListLV = new System.Windows.Forms.ListView();
            this.partIDHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label33 = new System.Windows.Forms.Label();
            this.partDescriptionTB = new System.Windows.Forms.TextBox();
            this.partIDTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPartB
            // 
            this.addPartB.Location = new System.Drawing.Point(360, 68);
            this.addPartB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPartB.Name = "addPartB";
            this.addPartB.Size = new System.Drawing.Size(112, 35);
            this.addPartB.TabIndex = 1;
            this.addPartB.Text = "Add";
            this.addPartB.UseVisualStyleBackColor = true;
            this.addPartB.Click += new System.EventHandler(this.addPartB_Click);
            // 
            // partListLV
            // 
            this.partListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partIDHead,
            this.descriptionHeader});
            this.partListLV.FullRowSelect = true;
            this.partListLV.HideSelection = false;
            this.partListLV.Location = new System.Drawing.Point(17, 122);
            this.partListLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partListLV.Name = "partListLV";
            this.partListLV.Size = new System.Drawing.Size(455, 290);
            this.partListLV.TabIndex = 78;
            this.partListLV.UseCompatibleStateImageBehavior = false;
            this.partListLV.View = System.Windows.Forms.View.Details;
            this.partListLV.SelectedIndexChanged += new System.EventHandler(this.partListLV_SelectedIndexChanged);
            // 
            // partIDHead
            // 
            this.partIDHead.Text = "ID";
            this.partIDHead.Width = 46;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 237;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(13, 26);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 20);
            this.label33.TabIndex = 73;
            this.label33.Text = "Description:";
            // 
            // partDescriptionTB
            // 
            this.partDescriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionTB.Location = new System.Drawing.Point(114, 23);
            this.partDescriptionTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partDescriptionTB.Name = "partDescriptionTB";
            this.partDescriptionTB.Size = new System.Drawing.Size(358, 26);
            this.partDescriptionTB.TabIndex = 0;
            // 
            // partIDTB
            // 
            this.partIDTB.Location = new System.Drawing.Point(114, 68);
            this.partIDTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partIDTB.Name = "partIDTB";
            this.partIDTB.Size = new System.Drawing.Size(98, 26);
            this.partIDTB.TabIndex = 81;
            this.partIDTB.Visible = false;
            // 
            // NewPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 429);
            this.Controls.Add(this.partIDTB);
            this.Controls.Add(this.addPartB);
            this.Controls.Add(this.partListLV);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.partDescriptionTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NewPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Part Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPartB;
        private System.Windows.Forms.ListView partListLV;
        private System.Windows.Forms.ColumnHeader partIDHead;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox partDescriptionTB;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.TextBox partIDTB;
    }
}
