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
        private string _plateNumber;
        private int _maintenanceID, _partID;

        private Maintenance _maintenance = new Maintenance();
        private Vehicle _vehicle = new Vehicle();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Maintenance> _maintenances = new List<Maintenance>();
        private Part _part = new Part();
        private List<Part> _parts = new List<Part>();
        #endregion

        #region Constructors
        public NewMaintenanceForm()
        {
            InitializeComponent();
            ComboBox();
        }

        #endregion

        #region UI Methods
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
                partCB.Items.Add(p.Description);
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            NewPartForm newPartForm = new NewPartForm();
            newPartForm.ShowDialog();
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void nextB_Click(object sender, EventArgs e)
        {
            _maintenanceID = _maintenance.CreateMaintenanceID();
            _plateNumber = plateNumberCB.Text.Trim();
            _partID = _part.RetrievePartID(partCB.Text.Trim());

            _maintenance = new Maintenance(_maintenanceID, _plateNumber, _partID);
            _maintenance.InsertMaintenance(_maintenance);

            Close();
            NewRepairForm newRepairForm = new NewRepairForm();
            newRepairForm.ShowDialog();
        }
        private void doneB_Click(object sender, EventArgs e)
        {
            _maintenanceID = _maintenance.CreateMaintenanceID();
            _plateNumber = plateNumberCB.Text.Trim();
            _partID = _part.RetrievePartID(partCB.Text.Trim());

            _maintenance = new Maintenance(_maintenanceID, _plateNumber, _partID);
            _maintenance.InsertMaintenance(_maintenance);


        }
        #endregion
    }
}
