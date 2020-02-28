using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleMonitoringSystem
{
    public partial class NewInsuranceForm : Form
    {
        #region Variable
        private int    insuranceID;

        private string plateNumber,
                       registeredName,
                       company;

        private DateTime durationFrom,
                         durationTo,
                         renewal;
        private double amount;

        private Insurance _insurance = new Insurance();
        private Vehicle _vehicle = new Vehicle();
        private Registration _registration = new Registration();

        List<Insurance> _insurances = new List<Insurance>();
        List<Vehicle> _vehicles = new List<Vehicle>();
        #endregion

        #region Constructors
        public NewInsuranceForm()
        {
            InitializeComponent();
            insuranceIDTB.Text = _insurance.CreateInsurance().ToString();
            ComboBoxLoad();
        }
        #endregion

        #region Insurance Methods
        private void ShowData(string plateNumber)
        {
            _insurance = _insurance.RetrieveInsuranceInfo(plateNumber);
            insuranceIDTB.Text = _insurance.InsuranceID.ToString();
            plateNumberCB.Text = _insurance.PlateNumber;
            registeredNameTB.Text = _registration.RegisteredName;
            companyCB.Text = _insurance.Company;
            durationFromDTP.Value = _insurance.DurationFrom;
            durationToDTP.Value = _insurance.DurationTo;
            renewalDTP.Value = _insurance.Renewal;
            amountTB.Text = _insurance.Amount.ToString("N2");
        }
        private void ComboBoxLoad()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                plateNumberCB.Items.Add(v.PlateNumber);
            }

            _insurances = _insurance.RetrieveInsuranceList();
            foreach (Insurance i in _insurances)
            {
                companyCB.Items.Add(i.Company);
            }
        }


        private void saveB_Click(object sender, EventArgs e)
        {
            if (plateNumberCB.Text == "")
            {
                MessageBox.Show("Please choose a PLATE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (registeredNameTB.Text == "")
            {
                MessageBox.Show("Please enter the REGISTERED NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (companyCB.Text == "")
            {
                MessageBox.Show("Please choose a COMPANY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (amountTB.Text == "")
            {
                MessageBox.Show("Please insert an AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (renewalDTP.Value == DateTime.Now)
            {
                MessageBox.Show("Please insert the RENEWAL DATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    insuranceID = int.Parse(insuranceIDTB.Text.Trim());
                    plateNumber = plateNumberCB.Text.Trim();
                    registeredName = registeredNameTB.Text.Trim();
                    company = companyCB.Text.Trim();
                    durationFrom = durationFromDTP.Value;
                    durationTo = durationToDTP.Value;
                    amount = double.Parse(amountTB.Text.Trim());
                    renewal = renewalDTP.Value;

                    _insurance = new Insurance(insuranceID,
                                              plateNumber,
                                              company,
                                              durationFrom,
                                              durationTo,
                                              renewal,
                                              amount);

                    //    _registration = new Registration(platenumber,registeredName);

                    _insurance.InsertInsurance(_insurance);
                    _registration.InsertRegistration(_registration);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            plateNumber = plateNumberCB.Text = "";
            registeredName = registeredNameTB.Text = "";
            company = companyCB.Text = "";
            durationFrom = durationFromDTP.Value = DateTime.Now;
            durationTo = durationToDTP.Value = DateTime.Now;
            amount = double.Parse(amountTB.Text = "");
            renewal = renewalDTP.Value = DateTime.Now;
        }
        #endregion
    }
}
