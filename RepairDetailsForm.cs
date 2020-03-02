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
    public partial class RepairDetailsForm : Form
    {
        #region Variables
        public string _invoiceNumber, _plateNumber, _partDescription, _supplierName;
        public int _repairID, _partID, _supplierID;
        private DateTime _purchasedDate;
        private double _amount, _totalAmt; //added
        private bool _paid;
        private Part _part = new Part();
        private Supplier _supplier = new Supplier();
        private RepairDetail _repairdetail = new RepairDetail();
        List<RepairDetail> _repairdetails = new List<RepairDetail>();
        private MainForm _mainForm;
        List<Part> _parts = new List<Part>();
        List<Supplier> _Supplier = new List<Supplier>();
        #endregion

        #region Constructor
        public RepairDetailsForm()
        {
            InitializeComponent();
            LoadDetails();
            ComboBoxLoad();
        }
        internal RepairDetailsForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadDetails();
            ComboBoxLoad();
        }
        #endregion

        #region Other Method
        public void LoadDetails()
        {
            detailListLV.Items.Clear();
            _repairID = _mainForm._repairID;
            _repairdetails = _repairdetail.RetrieveRepairDetailList(_repairID);
            foreach (RepairDetail r in _repairdetails)
            {
                _repairID = r.RepairID;
                _partID = r.PartID;
                _purchasedDate = r.PurchasedDate;
                _amount = r.Amount;
                _invoiceNumber = r.InvoiceNumber;
                _supplierID = r.SupplierID;
                _paid = r.Paid;
                _partDescription = _part.RetrievePartInfo(_partID).Description;
                _supplierName = _supplier.RetrieveSupplierInfo(_supplierID).SupplierName;

                ListViewItem searchRepair = new ListViewItem(_repairID.ToString());
                searchRepair.SubItems.Add(_partDescription);
                searchRepair.SubItems.Add(_purchasedDate.ToShortDateString());
                searchRepair.SubItems.Add(_supplierName);
                searchRepair.SubItems.Add(_invoiceNumber);
                searchRepair.SubItems.Add(_amount.ToString("N2"));

                detailListLV.Items.Add(searchRepair);
            }
            this.Compute();
        }
        private void ComboBoxLoad()
        {
            _Supplier = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _Supplier)
            {
                supplierCB.Items.Add(s.SupplierName);
            }
            _parts = _part.RetrievePartList();
            foreach (Part p in _parts)
            {
                partCB.Items.Add(p.Description);
            }
        }
        public void LoadStatementRepair(int partID, string invoiceNumber)
        {
            detailListLV.Items.Clear();
            _partID = partID;
            _invoiceNumber = invoiceNumber;
            _repairdetails = _repairdetail.RetrieveStatementRepair(_partID, _invoiceNumber);
            foreach (RepairDetail r in _repairdetails)
            {
                _repairID = r.RepairID;
                _partID = r.PartID;
                _purchasedDate = r.PurchasedDate;
                _amount = r.Amount;
                _invoiceNumber = r.InvoiceNumber;
                _supplierID = r.SupplierID;
                _paid = r.Paid;

                ListViewItem searchRepair = new ListViewItem(_repairID.ToString());
                searchRepair.SubItems.Add(_part.RetrievePartInfo(_partID).Description);
                searchRepair.SubItems.Add(_purchasedDate.ToShortDateString());
                searchRepair.SubItems.Add(_supplier.RetrieveSupplierInfo(_supplierID).SupplierName);
                searchRepair.SubItems.Add(_invoiceNumber);
                searchRepair.SubItems.Add(_amount.ToString("N2"));

                detailListLV.Items.Add(searchRepair);
            }
            this.Compute();
        }

        private void DetailListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detailListLV.SelectedItems.Count > 0)
            {
                partCB.Text = detailListLV.SelectedItems[0].SubItems[1].Text;
                supplierCB.Text = detailListLV.SelectedItems[0].SubItems[3].Text;
                invoiceNumberTB.Text = detailListLV.SelectedItems[0].SubItems[4].Text;
                amountTB.Text = detailListLV.SelectedItems[0].SubItems[5].Text;
              //  purchaseDateDTP.Value = Date.Parse(detailListLV.SelectedItems[2].Text);
            }
        }

        private void amountTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void amountTB_Click(object sender, EventArgs e)
        {
            amountTB.Text = "";
        }
        #endregion

        #region Edit Cancel Clear
        private void RepairEditB_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;


            switch (bt.Text)
            {
                case "Edit":
                    EnableRepair();
                    break;

                case "Save":
                    if (_partDescription != partCB.Text ||
                    _purchasedDate != purchaseDateDTP.Value ||
                    _supplierName != supplierCB.Text ||
                    _invoiceNumber != invoiceNumberTB.Text ||
                    _amount != int.Parse(amountTB.Text))
                    {
                        _repairdetail = new RepairDetail(_repairdetail.RepairID, _repairdetail.PartID, purchaseDateDTP.Value, int.Parse(amountTB.Text), invoiceNumberTB.Text, _supplier.RetrieveSupplierID(supplierCB.Text));
                    }
                    _repairdetail.UpdateRepairDetailInfo(_repairdetail);
                    
                    LoadDetails();
                    DisableRepair();
                    break;
            }
        }
        private void RepairCancelB_Click(object sender, EventArgs e)
        {
            DisableRepair();
            LoadDetails();
        }
        private void Compute()
        {
            _totalAmt = 0;
            foreach (RepairDetail r in _repairdetails)
            {
                _totalAmt += r.Amount;
            }
            partTotalTB.Text = "P " + _totalAmt.ToString("N2");
        }
        #endregion

        #region Enable Disabled Button
        private void DisableRepair()
        {
            repairEditB.Text = "Edit";
            partCB.Enabled = false;
            purchaseDateDTP.Enabled = false;
            supplierCB.Enabled = false;
            invoiceNumberTB.Enabled = false;
            amountTB.Enabled = false;


            repairCancelB.Visible = false;
        }
        private void EnableRepair()
        {
            repairEditB.Text = "Save";
            purchaseDateDTP.Enabled = true;
            supplierCB.Enabled = true;
            amountTB.Enabled = true;

            repairCancelB.Visible = true;
        }
        #endregion


    }
}
