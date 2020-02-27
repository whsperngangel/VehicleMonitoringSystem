using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    public partial class NewPaymentForm : Form
    {
        #region Variables
        private int supplierID,
                    paymentID,
                    statementID;
        private string supplierName,
                       invoiceNumber,
                       datePaid,
                       paidBy,
                       amountPaid;
        private double balance;

        private Fuel _fuel = new Fuel();
        private Repair _repair = new Repair();
        private RepairDetail _repairDetail = new RepairDetail();
        private Supplier _supplier = new Supplier();
        private Payment _payment = new Payment();

        List<Fuel> _fuels = new List<Fuel>();
        List<Repair> _repairs = new List<Repair>();
        List<RepairDetail> _repairDetails = new List<RepairDetail>();
        List<Supplier> _suppliers = new List<Supplier>();
        List<Payment> _payments = new List<Payment>();
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
            foreach (Payment p in _payments)
            {
                paidByCB.Items.Add(p.PaidBy);
            }

            _fuels = _fuel.RetrieveFuelList();
            foreach (Fuel f in _fuels)
            {
                invoiceNumberCB.Items.Add(f.InvoiceNumber);
            }

            _repairs = _repair.RetrieveRepairList();
            foreach (Repair r in _repairs)
            {
                invoiceNumberCB.Items.Add(r.InvoiceNumber);
            }

            _repairDetails = _repairDetail.RetrieveRepairDetailList();
            foreach (RepairDetail rd in _repairDetails)
            {
                invoiceNumberCB.Items.Add(rd.InvoiceNumber);
            }
        }


        private void saveB_Click(object sender, EventArgs e)
        {
            try
            {
                supplierName = supplierCB.Text.Trim();
                invoiceNumber = invoiceNumberCB.Text.Trim();
                datePaid = datePaidDTP.Value.ToString();
                amountPaid = amountPaidTB.Text.Trim();
                paidBy = paidByCB.Text.Trim();

                _supplier = new Supplier(supplierID, supplierName);
                _payment = new Payment(paymentID, statementID, invoiceNumber, datePaid, amountPaid, paidBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
