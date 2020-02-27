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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.partCB = new System.Windows.Forms.ComboBox();
            this.DoneB = new System.Windows.Forms.Button();
            this.newB = new System.Windows.Forms.Button();
            this.repairB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Part:";
            // 
            // plateNumberCB
            // 
            this.plateNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plateNumberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plateNumberCB.FormattingEnabled = true;
            this.plateNumberCB.Location = new System.Drawing.Point(105, 26);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(285, 28);
            this.plateNumberCB.TabIndex = 0;
            // 
            // partCB
            // 
            this.partCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partCB.FormattingEnabled = true;
            this.partCB.Location = new System.Drawing.Point(105, 59);
            this.partCB.Name = "partCB";
            this.partCB.Size = new System.Drawing.Size(285, 28);
            this.partCB.TabIndex = 1;
            // 
            // DoneB
            // 
            this.DoneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneB.Location = new System.Drawing.Point(312, 93);
            this.DoneB.Name = "DoneB";
            this.DoneB.Size = new System.Drawing.Size(78, 28);
            this.DoneB.TabIndex = 4;
            this.DoneB.Text = "Done";
            this.DoneB.UseVisualStyleBackColor = true;
            this.DoneB.Click += new System.EventHandler(this.doneB_Click);
            // 
            // newB
            // 
            this.newB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newB.Location = new System.Drawing.Point(12, 93);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(78, 28);
            this.newB.TabIndex = 2;
            this.newB.Text = "New Part";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // repairB
            // 
            this.repairB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairB.Location = new System.Drawing.Point(228, 93);
            this.repairB.Name = "repairB";
            this.repairB.Size = new System.Drawing.Size(78, 28);
            this.repairB.TabIndex = 3;
            this.repairB.Text = "Repair";
            this.repairB.UseVisualStyleBackColor = true;
            this.repairB.Click += new System.EventHandler(this.repairB_Click);
            // 
            // NewMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 134);
            this.Controls.Add(this.newB);
            this.Controls.Add(this.repairB);
            this.Controls.Add(this.DoneB);
            this.Controls.Add(this.partCB);
            this.Controls.Add(this.plateNumberCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMaintenanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.ComboBox partCB;
        private System.Windows.Forms.Button DoneB;
        private System.Windows.Forms.Button newB;
        private System.Windows.Forms.Button repairB;
    }
}
