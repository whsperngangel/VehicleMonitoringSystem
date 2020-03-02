using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    public partial class NewSupplierForm : Form
    {
        private int _supplierID;
        private string _supplierName = "";

        DBOperation _dbOp = new DBOperation();
        private Supplier _Supplier = new Supplier();
        private MainForm _mainForm = new MainForm();
        public NewSupplierForm()
        {
            InitializeComponent();
        }
        //here
        private void SaveB_Click(object sender, EventArgs e)
        {
            if (supplierTB.Text != "") 
            { 
                _supplierID = int.Parse(_Supplier.CreateSupplierID().ToString());
                _supplierName = supplierTB.Text.Trim();

                _Supplier = new Supplier(_supplierID, _supplierName);

                _Supplier.InsertSupplier(_Supplier);
                supplierTB.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter supplier name", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
