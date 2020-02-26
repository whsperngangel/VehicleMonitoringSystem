using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleMonitoringSystem.Payment;

namespace VehicleMonitoringSystem
{
    public partial class NewPaymentForm : Form
    {
        #region Variables
        private int supplierID,
                    paymentID,
                    statementID;
        private string supplierName,
                       datePaid,
                       paidBy,
                       amountPaid;
        private double balance; 

        private Supplier _supplier = new Supplier();
        private Payments _payment = new Payments();
        List<Supplier> _suppliers = new List<Supplier>();
        List<Payments> _payments = new List<Payments>();
        #endregion

        #region Constructors
        public NewPaymentForm()
        {
            InitializeComponent();
            ComboBoxLoad();
        }


        #endregion

        #region Payment Methods
        private void ComboBoxLoad()
        {
            _suppliers = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _suppliers)
            {
                supplierCB.Items.Add(s.SupplierName);
            }

            _payments = _payment.RetrievePaymentList();
            foreach (Payments p in _payments)
            {
                paidByCB.Items.Add(p. PaidBy);
            }
        }



        private void saveB_Click(object sender, EventArgs e)
        {
            try
            {
                supplierName = supplierCB.Text.Trim();
                datePaid = datePaidDTP.Value.ToString();
                amountPaid = amountPaidTB.Text.Trim();
                paidBy = paidByCB.Text.Trim();

                _supplier = new Supplier(supplierID, supplierName);
                _payment = new Payments(paymentID, statementID, datePaid, amountPaid, paidBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void supplierCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            supplierCB.Text = "";
            balanceTB.Text = "P 0.00";
            datePaidDTP.Value = DateTime.Now;
            amountPaidTB.Text = "P 0.00";
            paidByCB.Text = "";
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }









        private void supplierCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void balanceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void amountPaidTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        #endregion
    }
}
