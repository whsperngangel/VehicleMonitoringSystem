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
        private string _invoiceNumber;
        public int _repairID, _partID, _supplierID, _getID;
        private DateTime _purchasedDate;
        private double _amount, _totalAmt; //added
        private bool _paid;
        private Part _part = new Part();
        private Supplier _supplier = new Supplier();
        private RepairDetail _repairdetail = new RepairDetail();
        List<RepairDetail> _repairdetails = new List<RepairDetail>();
        private MainForm _mainForm;
        #endregion
        public RepairDetailsForm()
        {
            InitializeComponent();
            LoadDetails();
            
        }
        //dito
        internal RepairDetailsForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadDetails();
        }
        public void LoadDetails()
        {
            _getID = _mainForm._repairID;
            _repairdetails = _repairdetail.RetrieveRepairDetailList(_getID);
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
        private void Compute()
        {
            foreach (RepairDetail r in _repairdetails)
            {
                _totalAmt += r.Amount;
            }

            partTotalTB.Text = "P " + _totalAmt.ToString("N2");
        }
        //doon



    }
}
