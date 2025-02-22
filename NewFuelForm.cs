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
    public partial class NewFuelForm : Form
    {
        #region Variable
        private int fuelID,
                    supplierID;

        private string plateNumber,
                       vehicle,
                       typeOfFuel,
                       invoiceNumber;
        private bool paid = false;

        private DateTime date;
        private double amount;
        private Fuel _fuel = new Fuel();
        private Statement _statement = new Statement();
        private Vehicle _vehicle = new Vehicle();
        private Supplier _supplier = new Supplier();
        private List<Fuel> _fuels = new List<Fuel>();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Supplier> _Supplier = new List<Supplier>();
        #endregion

        #region  Constructors
        public NewFuelForm()
        {
            InitializeComponent();
            ComboBoxLoad();
        }
        #endregion

        #region Gas Methods
        private void ShowData(string plateNumber)
        {
            _fuel = _fuel.RetrieveFuelInfo(plateNumber);
            plateNumberCB.Text = _fuel.PlateNumber;
            dateDTP.Value = _fuel.FuelDate;
            typeOfFuelCB.Text = _fuel.TypeOfFuel;
           // supplierCB.Text = _fuel.SupplierID;
            amountTB.Text = _fuel.Amount.ToString("N2");
        }
        private void ComboBoxLoad()
        {
            _fuels = _fuel.RetrieveFuelList();
            foreach (Fuel f in _fuels)
            {
                typeOfFuelCB.Items.Add(f.TypeOfFuel);
            }
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                plateNumberCB.Items.Add(v.PlateNumber);
            }
            _Supplier = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _Supplier)
            {
                supplierCB.Items.Add(s.SupplierName);
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

        private void saveB_Click(object sender, EventArgs e)
        {
            if (plateNumberCB.Text == "")
            {
                MessageBox.Show("Please choose a PLATE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (typeOfFuelCB.Text == "")
            {
                MessageBox.Show("Please choose the TYPE OF FUEL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (invoiceNumberTB.Text == "")
            {
                MessageBox.Show("Please insert an INVOICE NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (supplierCB.Text == "")
            {
                MessageBox.Show("Please choose a SUPPLIER/n If the SUPPLIER does not exist, create NEW SUPPLIER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (amountTB.Text == "")
            {
                MessageBox.Show("Please insert the AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    fuelID = _fuel.CreateFuelID();
                    plateNumber = plateNumberCB.Text.Trim();
                    date = dateDTP.Value;
                    typeOfFuel = typeOfFuelCB.Text.Trim();
                    invoiceNumber = invoiceNumberTB.Text.Trim();
                    supplierID = _supplier.RetrieveSupplierID(supplierCB.Text.Trim());
                    amount = double.Parse(amountTB.Text.Trim());
                    string type = "Fuel";
                    string status = "Unpaid";

                    _fuel = new Fuel(fuelID,
                                     plateNumber, //some part here
                                     date,
                                     typeOfFuel,
                                     invoiceNumber,
                                     supplierID,
                                     amount);
                    _statement = new Statement();

                    _fuel.InsertFuel(_fuel);
                 //   _statement.InsertStatement(_statement.CreateStatementID(), supplierID, type, invoiceNumber, status);
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
            plateNumberCB.Text = "";
            dateDTP.Value = DateTime.Now;
            typeOfFuelCB.Text = "";
            supplierCB.Text = "";
            amountTB.Text = "";
            invoiceNumberTB.Text = "";
        }
        #endregion
    }
}
