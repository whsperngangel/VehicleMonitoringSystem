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
        #region Variable
        public int maintenanceID,
                   partID,
                   repairID;
        public string plateNumber,
                      typeOfRepair,
                      description;
        public DateTime date;

        private Maintenance _maintenance = new Maintenance();
        private Repair _repair = new Repair();
        private Part _part = new Part();


        List<Maintenance> _maintenances = new List<Maintenance>();
        List<Repair> _repairs = new List<Repair>();
        List<Part> _parts = new List<Part>();
        #endregion



        #region Constructors
        public NewMaintenanceForm()
        {
            InitializeComponent();
        }
        #endregion



        #region Maintenance Form Methods
        private void nextB_Click(object sender, EventArgs e)
        {
            NewRepairForm newRepairForm = new NewRepairForm();
            newRepairForm.Show();
        }

        #endregion
    }
}
