namespace VehicleMonitoringSystem
{
    partial class NewMaintenanceForm
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
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.newB = new System.Windows.Forms.Button();
            this.repairB = new System.Windows.Forms.Button();
            this.DoneB = new System.Windows.Forms.Button();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusCB
            // 
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "For Repair",
            "For Replacement",
            "On Going Repair"});
            this.statusCB.Location = new System.Drawing.Point(130, 119);
            this.statusCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(454, 28);
            this.statusCB.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(13, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Status:";
            // 
            // newB
            // 
            this.newB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newB.Location = new System.Drawing.Point(13, 167);
            this.newB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(117, 43);
            this.newB.TabIndex = 37;
            this.newB.Text = "New Part";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // repairB
            // 
            this.repairB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairB.Location = new System.Drawing.Point(338, 167);
            this.repairB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repairB.Name = "repairB";
            this.repairB.Size = new System.Drawing.Size(117, 43);
            this.repairB.TabIndex = 38;
            this.repairB.Text = "Repair";
            this.repairB.UseVisualStyleBackColor = true;
            this.repairB.Click += new System.EventHandler(this.repairB_Click);
            // 
            // DoneB
            // 
            this.DoneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneB.Location = new System.Drawing.Point(467, 167);
            this.DoneB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DoneB.Name = "DoneB";
            this.DoneB.Size = new System.Drawing.Size(117, 43);
            this.DoneB.TabIndex = 39;
            this.DoneB.Text = "Done";
            this.DoneB.UseVisualStyleBackColor = true;
            // 
            // partCB
            // 
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(130, 71);
            this.partCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(454, 28);
            this.partCB.TabIndex = 35;
            // 
            // plateNumberCB
            // 
            this.plateNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateNumberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plateNumberCB.FormattingEnabled = true;
            this.plateNumberCB.Location = new System.Drawing.Point(130, 24);
            this.plateNumberCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(454, 28);
            this.plateNumberCB.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Vehicle Part:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Plate Number:";
            // 
            // NewMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 226);
            this.Controls.Add(this.newB);
            this.Controls.Add(this.repairB);
            this.Controls.Add(this.DoneB);
            this.Controls.Add(this.partCB);
            this.Controls.Add(this.plateNumberCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMaintenanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button newB;
        private System.Windows.Forms.Button repairB;
        private System.Windows.Forms.Button DoneB;
        private System.Windows.Forms.ComboBox partCB;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
