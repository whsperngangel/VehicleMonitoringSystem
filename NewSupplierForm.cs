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
        private int _supplierID = 0;
        private string _supplierName = "";

        DBOperation _dbOp = new DBOperation();
        private Supplier _suppliers = new Supplier();
        private MainForm _mainForm = new MainForm();
        public NewSupplierForm()
        {
            InitializeComponent();
            supplierIDTB.Text = _suppliers.CreateSupplierID().ToString();
        }

        //internal NewSupplierForm(MainForm mainForm)
        //{
        //    InitializeComponent();
        //    supplierIDTB.Text = _suppliers.CreateSupplierID().ToString();
        //    _mainForm = mainForm;
        //}

        private void saveB_Click(object sender, EventArgs e)
        {
            if (supplierTB.Text != "") 
            { 
                _supplierID = int.Parse(supplierIDTB.Text.Trim());
                _supplierName = supplierTB.Text.Trim();

                _suppliers = new Supplier(_supplierID, _supplierName);

                _suppliers.InsertSupplier(_suppliers);
            }
            else
            {
                MessageBox.Show("Please enter supplier name", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
