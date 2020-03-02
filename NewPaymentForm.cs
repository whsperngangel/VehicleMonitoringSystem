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
                    statementID, ID;
        private string supplierName,
                       invoiceNumber,
                       datePaid,
                       paidBy,
                       amountPaid, type;
        private double balance; 

        private Supplier _supplier = new Supplier();
        private Part _part = new Part();
        private Payment _payment = new Payment();
        private Maintenance _maintenance = new Maintenance();
        List<Supplier> _suppliers = new List<Supplier>();
        List<Payment> _payments = new List<Payment>();
        List<Maintenance> _maintenances = new List<Maintenance>();
        List<Part> _parts = new List<Part>();
        #endregion

        #region Constructors
        public NewPaymentForm()
        {
            InitializeComponent();
            ComboBoxLoad();
        }
        #endregion

        #region Payment Methods
        #region Selected Index

        //private void supplierCB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    supplierName = supplierCB.Text.Trim();
        //    supplierID = _supplier.RetrieveSupplierID(supplierName);
        //    invoiceNumberCB.Items.Clear();

        //    _payments = _payment.RetrievePaymentInvoiceNumber(supplierID);
        //    foreach (Payment p in _payments)
        //    {
        //        invoiceNumberCB.Items.Add(p.InvoiceNumber);
        //    }
        //}

        //private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    type = typeCB.Text.Trim();
        //    supplierCB.Items.Clear();
        //    invoiceNumberCB.Items.Clear();
        //    EnablePayment();
        //    if(type == "Part")
        //    {
        //        type = "repairdetail";
        //    }
        //    _payments = _payment.RetrieveAllTypeList(type);
            
        //    foreach (Payment p in _payments)
        //    {
        //        _payments = _payment.RetireveSupplierIDList(type);
        //        foreach (Payment sid in _payments)
        //        {
        //            supplierCB.Items.Add(sid.SupplierID);
        //            _payments = _payment.RetrievePaymentInvoiceNumber(sid.SupplierID);
        //            foreach (Payment inid in _payments)
        //            {
        //                invoiceNumberCB.Items.Add(inid.SupplierID);
        //            }
        //        }
                
        //    }
        //}

        #endregion

        private void ComboBoxLoad()
        {
            //_payments = _payment.RetrievePaymentSupplierList();
            //foreach (Payment p in _payments)
            //{
            //    supplierCB.Items.Add(_supplier.RetrieveSupplierInfo(p.SupplierID).SupplierName);
            //}

            _payments = _payment.RetrievePaymentList();
            foreach (Payment p in _payments)
            {
                paidByCB.Items.Add(p.PaidBy);
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

                //_payment = new Payment(paymentID, _supplier.RetrieveSupplierID(supplierName), invoiceNumber, datePaid, amountPaid, paidBy);
                //_payment.InsertPayment(_payment);

                //ID = _payment.RetrievePaymentUpdateStatus(_supplier.RetrieveSupplierID(supplierName), invoiceNumber).ID;
                //type = _payment.RetrievePaymentUpdateStatus(_supplier.RetrieveSupplierID(supplierName), invoiceNumber).Type;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
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
        private void EnablePayment()
        {
            supplierCB.Enabled = true;
            invoiceNumberCB.Enabled = true;
            datePaidDTP.Enabled = true;
            amountPaidTB.Enabled = true;
            saveB.Enabled = true;
            cancelB.Enabled = true;
            clearB.Enabled = true;
        }
        private void DisablePayment()
        {
            supplierCB.Enabled = true;
            invoiceNumberCB.Enabled = true;
            datePaidDTP.Enabled = true;
            amountPaidTB.Enabled = true;
            saveB.Enabled = true;
            cancelB.Enabled = true;
            clearB.Enabled = true;
        }

        #endregion
    }
}
