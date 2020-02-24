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
                       partDescription;
      
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
        private List<Supplier> _suppliers = new List<Supplier>();

        private Maintenance _maintenance = new Maintenance();
        private List<Maintenance> _maintenances = new List<Maintenance>();

        #endregion

        #region Constructors
        public NewRepairForm()
        {
            InitializeComponent();
            ComboBoxLoad();
            MaintenanceListLoad();
            repairID = _repair.CreateRepairID();

        }
        #endregion

        #region Repair Method
        private void ComboBoxLoad()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                plateNumberCB.Items.Add(v.PlateNumber);
            }

            _suppliers = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _suppliers)
            {
                partSupplierCB.Items.Add(s.SupplierName);
                repairSupplierCB.Items.Add(s.SupplierName);
            }

            _parts = _part.RetrievePartList();
            foreach (Part p in _parts)
            {
                partCB.Items.Add(p.Description);
            }
        }

        private void addMaintenanceB_Click(object sender, EventArgs e)
        {
            NewMaintenanceForm maintenanceForm = new NewMaintenanceForm();
            maintenanceForm.Show();
        }

        private void MaintenanceListLoad()
        {
            _maintenances = _maintenance.RetrieveMaintenanceList();
            foreach (Maintenance m in _maintenances)
            {
                maintenanceID = m.MaintenanceID;
                plateNumber = m.PlateNumber;
                partID = m.PartID;

                ListViewItem maintenanceList = new ListViewItem();
                maintenanceList.SubItems.Add(maintenanceID.ToString());
                maintenanceList.SubItems.Add(plateNumber);
                maintenanceList.SubItems.Add(partID.ToString());

                maintenanceLV.Items.Add(maintenanceList);
            }
        }
      
        #region Buttons
        private void partListLV_SelectedIndexChanged(object sender, EventArgs e)
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
                
               // _repairDetail = new RepairDetail(repairID, partID, purchasedDate,partAmount,partInvoiceNumber,partSupplierID);
                partListLV.SelectedItems[0].Remove();
            }

        }
        private void plateNumberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _vehicle.RetrieveVehicleInfo(plateNumberCB.Text);
            vehicleNameL.Text = _vehicle.Listing;
        }
        private void addB_Click(object sender, EventArgs e)
        {
                DisableRepair();
             //   _repairDetail = new RepairDetail(repairID, partID, purchasedDate, partAmount, partInvoiceNumber, partSupplierID);
                    AddItem();

                    partCB.Focus();
           if (addB.Text == "Update")
            {
                addB.Text = "Add";
            }

           
            /*else
            {
                if (isDuplicated() == false){
                    AddItem();
                    partCB.Focus();
                }
                else
                {
                    if(partListLV.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("This item already exists","Duplicate Invoice Number");
                        partCB.Focus();
                    }
                    else
                    {
                       // PartUpdate(_repairDetail);
                    }
                }
            }*/

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
        //    _repairDetail = new RepairDetail(repairID, partID, purchasedDate, partAmount, partInvoiceNumber, partSupplierID);
            _repairDetails.Add(_repairDetail);


            partLVI.SubItems.Add(partSupplierCB.Text);
            partLVI.SubItems.Add(partDateDTP.Value.ToShortDateString());
            partLVI.SubItems.Add(partInvoiceNumberTB.Text);
            partLVI.SubItems.Add(partCB.Text);
            partLVI.SubItems.Add(partAmountTB.Text);
            partListLV.Items.Add(partLVI);

            Clear();
        }
        private bool isDuplicated()
        {
            //if duplicate entry in database
            bool duplicate = false;

            for (int i = 0; i < _repairDetails.Count; i++)
            {
                if (_repairDetail.InvoiceNumber == _repairDetails[i].InvoiceNumber && _repairDetail.SupplierID == _repairDetails[i].SupplierID)
                {
                    duplicate = true;
                    break;
                }
                else duplicate = true;
            }
            return duplicate;
        }
        private void saveB_Click(object sender, EventArgs e)
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
                repairSupplierID = _supplier.RetrieveSupplierID(repairSupplierCB.Text.Trim());
                repairInvoiceNumber = repairInvoiceNumberTB.Text.Trim();
                repairAmount = double.Parse(repairAmountTB.Text.Trim());

            //    _repair = new Repair(repairID,plateNumber,repairDate,typeOfRepair,repairSupplierID,repairInvoiceNumber,repairAmount);
                _repair.InsertRepair(_repair);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cancelB_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            //part
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
        #endregion
    }
}
