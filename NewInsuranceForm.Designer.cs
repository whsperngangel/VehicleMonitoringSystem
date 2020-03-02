namespace VehicleMonitoringSystem
{
    partial class NewInsuranceForm
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
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox registeredNameTB;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.DateTimePicker durationFromDTP;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button cencelB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.DateTimePicker renewalDTP;
        private System.Windows.Forms.DateTimePicker durationToDTP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox plateNumberCB;
        private System.Windows.Forms.ComboBox companyCB;
        private System.Windows.Forms.TextBox insuranceIDTB;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInsuranceForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.registeredNameTB = new System.Windows.Forms.TextBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.durationFromDTP = new System.Windows.Forms.DateTimePicker();
            this.saveB = new System.Windows.Forms.Button();
            this.cencelB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.renewalDTP = new System.Windows.Forms.DateTimePicker();
            this.durationToDTP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plateNumberCB = new System.Windows.Forms.ComboBox();
            this.companyCB = new System.Windows.Forms.ComboBox();
            this.insuranceIDTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plate Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registered Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Duration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Renewal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Amount:";
            // 
            // registeredNameTB
            // 
            this.registeredNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredNameTB.Location = new System.Drawing.Point(155, 57);
            this.registeredNameTB.Name = "registeredNameTB";
            this.registeredNameTB.Size = new System.Drawing.Size(592, 26);
            this.registeredNameTB.TabIndex = 7;
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.Location = new System.Drawing.Point(155, 183);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(592, 26);
            this.amountTB.TabIndex = 11;
            this.amountTB.Text = "PHP 0.00";
            this.amountTB.Click += new System.EventHandler(this.amountTB_Click);
            this.amountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTB_KeyPress);
            // 
            // durationFromDTP
            // 
            this.durationFromDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationFromDTP.Location = new System.Drawing.Point(155, 142);
            this.durationFromDTP.Name = "durationFromDTP";
            this.durationFromDTP.Size = new System.Drawing.Size(275, 26);
            this.durationFromDTP.TabIndex = 12;
            // 
            // saveB
            // 
            this.saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveB.Location = new System.Drawing.Point(510, 264);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 29);
            this.saveB.TabIndex = 13;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // cencelB
            // 
            this.cencelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cencelB.Location = new System.Drawing.Point(591, 264);
            this.cencelB.Name = "cencelB";
            this.cencelB.Size = new System.Drawing.Size(75, 29);
            this.cencelB.TabIndex = 14;
            this.cencelB.Text = "Cancel";
            this.cencelB.UseVisualStyleBackColor = true;
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(672, 264);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 29);
            this.clearB.TabIndex = 15;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            // 
            // renewalDTP
            // 
            this.renewalDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewalDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.renewalDTP.Location = new System.Drawing.Point(155, 224);
            this.renewalDTP.Name = "renewalDTP";
            this.renewalDTP.Size = new System.Drawing.Size(592, 26);
            this.renewalDTP.TabIndex = 12;
            // 
            // durationToDTP
            // 
            this.durationToDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationToDTP.Location = new System.Drawing.Point(473, 142);
            this.durationToDTP.Name = "durationToDTP";
            this.durationToDTP.Size = new System.Drawing.Size(274, 26);
            this.durationToDTP.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "From:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(436, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Company:";
            // 
            // plateNumberCB
            // 
            this.plateNumberCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberCB.FormattingEnabled = true;
            this.plateNumberCB.Location = new System.Drawing.Point(155, 14);
            this.plateNumberCB.Name = "plateNumberCB";
            this.plateNumberCB.Size = new System.Drawing.Size(592, 28);
            this.plateNumberCB.TabIndex = 12;
            // 
            // companyCB
            // 
            this.companyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyCB.FormattingEnabled = true;
            this.companyCB.Location = new System.Drawing.Point(155, 99);
            this.companyCB.Name = "companyCB";
            this.companyCB.Size = new System.Drawing.Size(592, 28);
            this.companyCB.TabIndex = 12;
            // 
            // insuranceIDTB
            // 
            this.insuranceIDTB.Location = new System.Drawing.Point(155, 270);
            this.insuranceIDTB.Name = "insuranceIDTB";
            this.insuranceIDTB.Size = new System.Drawing.Size(100, 20);
            this.insuranceIDTB.TabIndex = 16;
            this.insuranceIDTB.Visible = false;
            // 
            // NewInsuranceForm
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 306);
            this.Controls.Add(this.insuranceIDTB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.cencelB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.companyCB);
            this.Controls.Add(this.renewalDTP);
            this.Controls.Add(this.plateNumberCB);
            this.Controls.Add(this.durationToDTP);
            this.Controls.Add(this.durationFromDTP);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.registeredNameTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewInsuranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Insurance Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
