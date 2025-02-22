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
    public partial class NewMaintenanceForm : Form
    {
        #region Variables
        private string _plateNumber, _status, _description;
        private int _maintenanceID, _partID, _repairID;

        private Maintenance _maintenance = new Maintenance();
        private Vehicle _vehicle = new Vehicle();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Maintenance> _maintenances = new List<Maintenance>();
        private Part _part = new Part();
        private Repair _repair = new Repair();

        private void repairB_Click(object sender, EventArgs e)
        {
            if (plateNumberCB.Text == "")
            {
                MessageBox.Show("Please choose a PLATE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (partCB.Text == "")
            {
                MessageBox.Show("Please choose a VEHICLE PART/n If VEHICLE PART does exist on the choices, please ADD a NEW PART.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _maintenanceID = _maintenance.CreateMaintenanceID();
                _repairID = _repair.CreateRepairID();
                _plateNumber = plateNumberCB.Text.Trim();
                _partID = _part.RetrievePartID(partCB.Text.Trim());
                _maintenance = new Maintenance(_maintenanceID, _plateNumber, _partID, _status);
                _maintenance.InsertMaintenance(_maintenance);
                plateNumberCB.Text = "";
                partCB.Text = "";
            }
            NewRepairForm newRepairForm = new NewRepairForm();
            newRepairForm.ShowDialog();
            Close();
        }

        private void newB_Click(object sender, EventArgs e)
        {
            NewPartForm newPartForm = new NewPartForm();
            newPartForm.ShowDialog();
        }

        private void doneB_Click(object sender, EventArgs e)
        {
            if (plateNumberCB.Text == "")
            {
                MessageBox.Show("Please choose a PLATE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (partCB.Text == "")
            {
                MessageBox.Show("Please choose a VEHICLE PART/n If VEHICLE PART does exist on the choices, please ADD a NEW PART.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _maintenanceID = _maintenance.CreateMaintenanceID();
                _repairID = _repair.CreateRepairID();
                _plateNumber = plateNumberCB.Text.Trim();
                _partID = _part.RetrievePartID(partCB.Text.Trim());
                _maintenance = new Maintenance(_maintenanceID, _plateNumber, _partID, _status);
                _maintenance.InsertMaintenance(_maintenance);
                plateNumberCB.Text = "";
                partCB.Text = "";
            }
            Close();
        }

        private List<Part> _parts = new List<Part>();
        #endregion

        #region Constructors
        public NewMaintenanceForm()
        {
            InitializeComponent();
            ComboBox();
        }

        #endregion

        #region Maintenance Methods
        private void ComboBox()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                plateNumberCB.Items.Add(v.PlateNumber);
            }
            
            _parts = _part.RetrievePartList();
            foreach (Part p in _parts)
            {
                _description = p.Description;
            }
        }
        private void addB_Click(object sender, EventArgs e)
        {
            _maintenanceID = _maintenance.CreateMaintenanceID();
            _repairID = _repair.CreateRepairID();
            _plateNumber = plateNumberCB.Text.Trim();
            _status = statusCB.Text;
            plateNumberCB.Text = "";
            statusCB.Text = "";
            _maintenance = new Maintenance(_maintenanceID, _plateNumber, _partID, _status);
            _maintenance.InsertMaintenance(_maintenance);
        }
        #endregion
    }
}
