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
    public partial class NewRepairForm : Form
    {
        #region Variables
        private int repairID, repairSupplierID, partID, partSupplierID,maintenanceID;

        private string plateNumber,
                       typeOfRepair,
                       partInvoiceNumber,
                       repairInvoiceNumber,
                       partDescription,
                       status; //here
        private bool paid = false;
        private DateTime repairDate, purchasedDate;
        private double repairAmount, partAmount;

        //repair
        private Repair _repair = new Repair();
        private RepairDetail _repairDetail = new RepairDetail();
        private List<Repair> _repairs = new List<Repair>();
        private List<RepairDetail> _repairDetails = new List<RepairDetail>();
        //part
        private Part _part = new Part();
        List<Part> _parts = new List<Part>();

        private Vehicle _vehicle = new Vehicle();
        private Supplier _supplier = new Supplier();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Supplier> _Supplier = new List<Supplier>();

        private Maintenance _maintenance = new Maintenance();
        

        private List<Maintenance> _maintenances = new List<Maintenance>();


        #endregion

        #region Constructors
        public NewRepairForm()
        {
            InitializeComponent();
            ComboBoxLoad();
            repairID = _repair.CreateRepairID();
        }

        #endregion

        #region Repair Method
        private void plateNumberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            plateNumber = plateNumberCB.Text.Trim();
            _vehicle.RetrieveVehicleInfo(plateNumberCB.Text);
            vehicleNameL.Text = _vehicle.Listing;

            partCB.Items.Clear();
            _maintenances = _maintenance.RetrieveMaintenancePart(plateNumber);
            foreach (Maintenance m in _maintenances)
            {
                _part = _part.RetrievePartInfo(m.PartID);
                partCB.Items.Add(_part.Description);
            }
        }
        private void PartListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            addB.Text = "Update";
            partSupplierCB.Enabled = true;
            partDateDTP.Enabled = true;
            partInvoiceNumberTB.Enabled = true;
            if (partListLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = partListLV.SelectedItems[0];
                string partItemNo = selectedPart.SubItems[0].Text;

                partCB.Text = selectedPart.SubItems[4].Text;
                partID = _part.RetrievePartID(partCB.Text);
                purchasedDate = partDateDTP.Value = DateTime.Parse(selectedPart.SubItems[2].Text);
                partSupplierCB.Text = selectedPart.SubItems[1].Text;
                partSupplierID = _supplier.RetrieveSupplierID(partSupplierCB.Text);
                partInvoiceNumber = partInvoiceNumberTB.Text = selectedPart.SubItems[3].Text;
                partAmountTB.Text = selectedPart.SubItems[5].Text;
                partAmount = double.Parse(partAmountTB.Text);
                
                _repairDetail = new RepairDetail(repairID, partID, purchasedDate,partAmount,partInvoiceNumber,partSupplierID);
                partListLV.SelectedItems[0].Remove();
            }

        }

        private void partAmountTB_KeyPress(object sender, KeyPressEventArgs e)
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
        private void repairAmountTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void repairAmountTB_Click(object sender, EventArgs e)
        {
            repairAmountTB.Text = "";
        }
        private void partAmountTB_Click(object sender, EventArgs e)
        {
            partAmountTB.Text = "";
        }
        #endregion

        #region Others
        private void ComboBoxLoad()
        {
            _maintenances = _maintenance.RetrieveMaintenanceUniquePlateNumber();
            
            foreach (Maintenance m in _maintenances)
            {
              plateNumberCB.Items.Add(m.PlateNumber);
            }

            _Supplier = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _Supplier)
            {
                partSupplierCB.Items.Add(s.SupplierName);
                repairSupplierCB.Items.Add(s.SupplierName);
            }
        }
        private void AddItem()
        {
            ListViewItem partLVI = new ListViewItem();

            partSupplierID = _supplier.RetrieveSupplierID(partSupplierCB.Text);
            partID = _part.RetrievePartID(partCB.Text);
            purchasedDate = partDateDTP.Value;
            partInvoiceNumber = partInvoiceNumberTB.Text;
            partDescription = partCB.Text;
            partAmount = double.Parse(partAmountTB.Text);

            _repairDetail = new RepairDetail(repairID, partID, purchasedDate, partAmount, partInvoiceNumber, partSupplierID);

            _repairDetails.Add(_repairDetail);

            partLVI.SubItems.Add(partSupplierCB.Text);
            partLVI.SubItems.Add(partDateDTP.Value.ToShortDateString());
            partLVI.SubItems.Add(partInvoiceNumberTB.Text);
            partLVI.SubItems.Add(partCB.Text);
            partLVI.SubItems.Add(partAmountTB.Text);
            partLVI.SubItems.Add(statusCB.Text);
            partListLV.Items.Add(partLVI);

            this.Clear();
        }
        private void Clear()
        {
            partCB.Text = "";
            partAmountTB.Text = "";
        }
        private void DisableRepair()
        {
            plateNumberCB.Enabled = false;
            repairSupplierCB.Enabled = false;
            repairDateDTP.Enabled = false;
            repairInvoiceNumberTB.Enabled = false;
            repairAmountTB.Enabled = false;
            typeOfRepairCB.Enabled = false;
            partSupplierCB.Enabled = false;
            partDateDTP.Enabled = false;
            partInvoiceNumberTB.Enabled = false;

        }
        #endregion

        #region Buttons
        private void AddB_Click(object sender, EventArgs e)
        {
            DisableRepair();
            _repairDetail = new RepairDetail(repairID, partID, purchasedDate, partAmount, partInvoiceNumber, partSupplierID);
            AddItem();

            partCB.Focus();
            if (addB.Text == "Update")
            {
                addB.Text = "Add";
            }
        }
        private void doneB_Click(object sender, EventArgs e)
        {
            //repair
            repairSupplierID = _supplier.RetrieveSupplierID(repairSupplierCB.Text);
            repairDate = repairDateDTP.Value;
            repairInvoiceNumber = repairInvoiceNumberTB.Text;
            repairAmount = double.Parse(repairAmountTB.Text);
            typeOfRepair = typeOfRepairCB.Text;

            try
            {
                foreach (RepairDetail repairDetail in _repairDetails)
                {
                    _repairDetail.InsertRepairDetail(repairDetail);
                }
                //repair
                plateNumber = plateNumberCB.Text.Trim();
                repairDate = repairDateDTP.Value;
                typeOfRepair = typeOfRepairCB.Text.Trim();
                partID = _part.RetrievePartID(partCB.Text);
                maintenanceID = _maintenance.RetrieveMaintenanceID(plateNumber, partID);

                repairSupplierID = _supplier.RetrieveSupplierID(repairSupplierCB.Text.Trim());
                repairInvoiceNumber = repairInvoiceNumberTB.Text.Trim();
                repairAmount = double.Parse(repairAmountTB.Text.Trim());
                status = statusCB.Text.Trim();

                _repair = new Repair(repairID, maintenanceID, repairDate, typeOfRepair, repairInvoiceNumber, repairSupplierID, repairAmount);
                _repair.InsertRepair(_repair);

                _maintenance = new Maintenance(maintenanceID, plateNumber, partID, status);
                _maintenance.UpdateMaintenanceInfo(_maintenance);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void payB_Click(object sender, EventArgs e)
        {
            repairSupplierID = _supplier.RetrieveSupplierID(repairSupplierCB.Text);
            repairDate = repairDateDTP.Value;
            repairInvoiceNumber = repairInvoiceNumberTB.Text;
            repairAmount = double.Parse(repairAmountTB.Text);
            typeOfRepair = typeOfRepairCB.Text;

            try
            {
                foreach (RepairDetail repairDetail in _repairDetails)
                {
                    _repairDetail.InsertRepairDetail(repairDetail);
                }
                plateNumber = plateNumberCB.Text.Trim();
                repairDate = repairDateDTP.Value;
                typeOfRepair = typeOfRepairCB.Text.Trim();
                partID = _part.RetrievePartID(partCB.Text);
                maintenanceID = _maintenance.RetrieveMaintenanceID(plateNumber, partID);

                repairSupplierID = _supplier.RetrieveSupplierID(repairSupplierCB.Text.Trim());
                repairInvoiceNumber = repairInvoiceNumberTB.Text.Trim();
                repairAmount = double.Parse(repairAmountTB.Text.Trim());
                status = statusCB.Text.Trim();

                _repair = new Repair(repairID, maintenanceID, repairDate, typeOfRepair, repairInvoiceNumber, repairSupplierID, repairAmount);
                _repair.InsertRepair(_repair);

                _maintenance = new Maintenance(maintenanceID, plateNumber, partID, status);
                _maintenance.UpdateMaintenanceInfo(_maintenance);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            NewPaymentForm newPaymentForm = new NewPaymentForm();
            newPaymentForm.ShowDialog();
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
