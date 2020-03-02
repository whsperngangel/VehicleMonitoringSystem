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
    public partial class NewVehicleForm : Form
    {
        #region Variable
        public int registrationID;
        public string plateNumber,
                      registeredName,
                      orNumber,
                      crNumber,
                      listing,
                      brand,
                      category,
                      companyService,
                      remarks,
                      issuedTo;
        public DateTime orDate,
                        crDate,
                        renewal;
        public double amount;

        private Vehicle _vehicle = new Vehicle();
        private Registration _registration = new Registration();
        List<Vehicle> _vehicles = new List<Vehicle>();
        private MainForm _mainForm;
        #endregion

        #region  Constructors
        public NewVehicleForm()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        internal NewVehicleForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        #endregion

        #region Vehicle Methods
        private void ComboBoxLoad()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                listingCB.Items.Add(v.Listing);
                brandCB.Items.Add(v.Brand);
                categoryCB.Items.Add(v.Category);
            }
        }
        private void amountTB_Click(object sender, EventArgs e)
        {
            amountTB.Text = "";
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

        private void saveB_Click(object sender, EventArgs e)
        {
            if (plateNumberTB.Text == "")
            {
                MessageBox.Show("Please enter a PLATE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (registeredNameTB.Text == "")
            {
                MessageBox.Show("Please enter the REGISTERED NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (orNumberTB.Text == "")
            {
                MessageBox.Show("Please enter the vehicle's OR NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (crNumberTB.Text == "")
            {
                MessageBox.Show("Please enter the vehicle's CR NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listingCB.Text == "")
            {
                MessageBox.Show("Please choose a LISTING type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (brandCB.Text == "")
            {
                MessageBox.Show("Please choose a BRAND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (categoryCB.Text == "")
            {
                MessageBox.Show("Please choose a CATEGORY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (amountTB.Text == "")
            {
                MessageBox.Show("Please insert the AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (issuedToTB.Text == "")
            {
                MessageBox.Show("Please write down to whome the vehicle is ISSUED TO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    plateNumber = plateNumberTB.Text.Trim();
                    registeredName = registeredNameTB.Text.Trim();
                    orNumber = orNumberTB.Text.Trim();
                    orDate = orDateDTP.Value;
                    crNumber = crNumberTB.Text.Trim();
                    crDate = crDateDTP.Value;
                    renewal = renewalDTP.Value;
                    listing = listingCB.Text.Trim();
                    brand = brandCB.Text.Trim();
                    category = categoryCB.Text.Trim();
                    amount = double.Parse(amountTB.Text.Trim());
                    issuedTo = issuedToTB.Text.Trim();
                    remarks = remarksRTB.Text.Trim();

                    _vehicle = new Vehicle(plateNumber, listing, brand, category, crNumber, crDate, issuedTo);
                    _registration = new Registration(registrationID, plateNumber, registeredName, orNumber, orDate, renewal, amount, remarks);

                    _vehicle.InsertVehicle(_vehicle);
                    _registration.InsertRegistration(_registration);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                _mainForm.ListViewLoad();
            }
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearB_Click(object sender, EventArgs e)
        {
            plateNumberTB.Text = "";
            registeredNameTB.Text = "";
            orNumberTB.Text = "";
            orDateDTP.Value = DateTime.Now;
            crNumberTB.Text = "";
            crDateDTP.Value = DateTime.Now;
            renewalDTP.Value = DateTime.Now;
            listingCB.Text = "";
            brandCB.Text = "";
            categoryCB.Text = "";
            amountTB.Text = "";
            remarksRTB.Text = "";
        }
        #endregion
    }
}
