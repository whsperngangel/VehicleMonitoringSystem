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
    public partial class MainForm : Form
    {
        #region Variables
        public int _repairID,
                    _insuranceID,
                    _registrationID,
                    _fuelID,
                    _partID,
                    _supplierID,
                    _maintenanceID;
        private string _plateNumber = "",
                       _registeredName = "",
                       _orNumber = "",
                       _crNumber = "",
                       _listing = "",
                       _brand = "",
                       _category = "",
                       _remarks = "",
                       _insuranceCompany = "",
                       _insuranceRegisteredName = "",
                       _typeOfRepair = "",
                       _repairSupplier = "",
                       _fuelVehicle = "",
                       _typeOffuel = "",
                       _fuelSupplier = "",
                       _issuedTo = "",
                       _partDescription = "",
                       _repairInvoiceNumber = "",
                       _invoiceNumber = "",
                       _conditionString1 = "",
                       _type, _status;
        private bool _fuelPaid = false; //added
        private double _amount,
                       _insuranceAmount,
                        _fuelAmount,
                       _repairAmount,
                       _totalFuel,
                       _totalRepair, //added
                       _totalPart, //added
                       _totalAmt; //added
        private DateTime _orDate = DateTime.Now,
                         _crDate = DateTime.Now,
                         _renewal = DateTime.Now,
                         _insuranceDurationFrom = DateTime.Now,
                         _insuranceDurationTo = DateTime.Now,
                         _insuranceRenewal = DateTime.Now,
                         _repairDate = DateTime.Now,
                         _fuelDate = DateTime.Now,
                        _datedue = DateTime.Now,
                        _repairDueDate = DateTime.Now;

        private Vehicle _vehicle = new Vehicle();
        private Registration _registration = new Registration();
        private Insurance _insurance = new Insurance();
        private Maintenance _maintenance = new Maintenance();
        private Repair _repair = new Repair();
        private Fuel _fuel = new Fuel();
        private Supplier _supplier = new Supplier();
        private Statement _statement = new Statement();
        private Part _part = new Part();
        List<Vehicle> _vehicles = new List<Vehicle>();
        List<Registration> _registrations = new List<Registration>();
        List<Insurance> _insurances = new List<Insurance>();
        List<Maintenance> _maintenances = new List<Maintenance>();
        List<Repair> _repairs = new List<Repair>();
        List<RepairDetail> _repairDetails = new List<RepairDetail>();
        List<Fuel> _fuels = new List<Fuel>();
        List<Supplier> _Supplier = new List<Supplier>();
        List<Statement> _statements = new List<Statement>();
        List<Part> _parts = new List<Part>();
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            ListViewLoad();
            ComboBoxLoad();
            LoadALLStatement();
            Compute();
        }
        #endregion

        #region Populate ListViews
        public void ListViewLoad()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            vehicleListLV.Items.Clear();
            foreach (Vehicle v in _vehicles)
            {
                vehicleListLV.Items.Add(v.PlateNumber);
            }
        }
        private void ComboBoxLoad()
        {
            _Supplier = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _Supplier)
            {
                repairSupplierCB.Items.Add(s.SupplierName);
                supplierSortCB.Items.Add(s.SupplierName);
            }
            _parts = _part.RetrievePartList();
            foreach (Part p in _parts)
            {
                partCB.Items.Add(p.Description);
            }
            _vehicles = _vehicle.RetrieveVehicleList();
           foreach (Vehicle v in _vehicles)
            {
                plateNumberCB.Items.Add(v.PlateNumber);
            }
            _repairs = _repair.RetrieveRepairList();
            foreach (Repair r in _repairs)
            {
                repairInvoiceNumberCB.Items.Add(r.InvoiceNumber);
            }
            _fuels = _fuel.RetrieveFuelList();
            foreach (Fuel f in _fuels)
            {
                fuelInvoiceNumberCB.Items.Add(f.InvoiceNumber);
            }
        }
        private void MaintenanceListLoad(string plateNumber)
        {
            maintenanceLV.Items.Clear();
            _maintenances = _maintenance.RetrieveMaintenancePart(plateNumber);
            foreach (Maintenance m in _maintenances)
            {
                _maintenanceID = m.MaintenanceID;
                _plateNumber = m.PlateNumber;
                _partID = m.PartID;
                _status = m.Status;

                ListViewItem maintenanceList = new ListViewItem(_maintenanceID.ToString());
                maintenanceList.SubItems.Add(_part.RetrievePartInfo(_partID).Description);
                maintenanceList.SubItems.Add(_status);

                maintenanceLV.Items.Add(maintenanceList);
            }
        }
        public void LoadRegistration(string plateNumber)
        {
            _registrations = _registration.RetrieveRegistrationList(plateNumber);
            registrationLV.Items.Clear();

            foreach (Registration registration in _registrations)
            {
                _registrationID = registration.RegistrationID;
                _plateNumber = registration.PlateNumber;
                _registeredName = registration.RegisteredName;
                _orNumber = registration.ORNumber;
                _orDate = registration.ORDate;
                _renewal = registration.Renewal;
                _amount = registration.Amount;
                _remarks = registration.Remarks;


                ListViewItem searchRegistration = new ListViewItem(_registrationID.ToString());
                searchRegistration.SubItems.Add(_plateNumber);
                searchRegistration.SubItems.Add(_registeredName);
                searchRegistration.SubItems.Add(_orNumber);
                searchRegistration.SubItems.Add(_orDate.ToShortDateString());
                searchRegistration.SubItems.Add(_renewal.ToShortDateString());
                searchRegistration.SubItems.Add(_amount.ToString("N2"));
                searchRegistration.SubItems.Add(_remarks);
                registrationLV.Items.Add(searchRegistration);
            }
        }
        public void LoadInsurance(string plateNumber)
        {
            _insurances = _insurance.RetrieveInsuranceList(plateNumber);
            insuranceLV.Items.Clear();

            foreach (Insurance insurance in _insurances)
            {
                _insuranceID = insurance.InsuranceID;
                _plateNumber = insurance.PlateNumber;
                _insuranceCompany = insurance.Company;
                _insuranceDurationFrom = insurance.DurationFrom;
                _insuranceDurationTo = insurance.DurationTo;
                _insuranceRenewal = insurance.Renewal;
                _insuranceAmount = insurance.Amount;

                ListViewItem searchInsurance = new ListViewItem(_insuranceID.ToString());
                searchInsurance.SubItems.Add(_plateNumber);
                searchInsurance.SubItems.Add(_insuranceRegisteredName);
                searchInsurance.SubItems.Add(_insuranceCompany);
                searchInsurance.SubItems.Add(_insuranceDurationFrom.ToShortDateString());
                searchInsurance.SubItems.Add(_insuranceDurationTo.ToShortDateString());
                searchInsurance.SubItems.Add(_insuranceRenewal.ToShortDateString());
                searchInsurance.SubItems.Add(_insuranceAmount.ToString("N2"));

                insuranceLV.Items.Add(searchInsurance);
            }
        }
        public void LoadRepair(string plateNumber)
        {
            _repairs = _repair.RetrieveRepairList(plateNumber);
            repairLV.Items.Clear();

            foreach (Repair repair in _repairs)
            {
                _repairID = repair.RepairID;
                _plateNumber = plateNumber;
                _repairDate = repair.RepairDate;
                _typeOfRepair = repair.TypeOfRepair;
                _repairSupplier = _supplier.RetrieveSupplierInfo(repair.SupplierID).SupplierName;
                _repairInvoiceNumber = repair.InvoiceNumber;
                _repairAmount = repair.Amount;

                ListViewItem searchRepair = new ListViewItem(_repairID.ToString());
                searchRepair.SubItems.Add(_repairDate.ToShortDateString());
                searchRepair.SubItems.Add(_typeOfRepair);
                searchRepair.SubItems.Add(_repairSupplier);
                searchRepair.SubItems.Add(_repairInvoiceNumber);
                searchRepair.SubItems.Add(_repairAmount.ToString("N2"));

                repairLV.Items.Add(searchRepair);
            }

        }
        public void Loadfuel(string plateNumber)
        {
            _fuels = _fuel.RetrieveFuelList(plateNumber);
            fuelLV.Items.Clear();

            foreach (Fuel fuel in _fuels)
            {
                _fuelID = fuel.FuelID;
                _plateNumber = fuel.PlateNumber;
                _fuelDate = fuel.FuelDate;
                _typeOffuel = fuel.TypeOfFuel;
                _fuelSupplier = _supplier.RetrieveSupplierInfo(fuel.SupplierID).SupplierName;
                _fuelAmount = fuel.Amount;
                _fuelPaid = fuel.Paid;

                ListViewItem searchfuel = new ListViewItem(_fuelID.ToString());
                searchfuel.SubItems.Add(_plateNumber);
                searchfuel.SubItems.Add(_fuelDate.ToShortDateString());
                searchfuel.SubItems.Add(_typeOffuel);
                searchfuel.SubItems.Add(_fuelSupplier);
                searchfuel.SubItems.Add(_fuelAmount.ToString("N2"));

                fuelLV.Items.Add(searchfuel);
            }
        }
        public void LoadALLStatement()
        {
            _statements = _statement.RetrieveStatementList(_conditionString1);
            _totalFuel = 0;
            foreach (Statement statement in _statements)
            {

             //   _statementID = statement.StatementID;
                _supplierID = statement.SupplierID;
                _type = statement.Type;
                _invoiceNumber = statement.InvoiceNumber;
                _status = statement.Status;
                _totalFuel += statement.AmountDue;


                ListViewItem searchStatement = new ListViewItem(_supplierID.ToString());
                searchStatement.SubItems.Add(_fuelID.ToString());
                searchStatement.SubItems.Add(_invoiceNumber);
                searchStatement.SubItems.Add(_type);
                searchStatement.SubItems.Add(_amount.ToString("N2"));

                statementLV.Items.Add(searchStatement);

            }
        }

        /*public void LoadRepairStatement()
        {
            _statements = _statement.RetrieveRepairStatement(_conditionString1);
            _totalRepair = 0;
            foreach (Statement statement in _statements)
            {
                _supplierID = statement.SupplierID;
                _repairID = statement.ID;
                _invoiceNumber = statement.InvoiceNumber;
                _type = statement.Type;
                _repairAmount = statement.AmountDue;
                _totalRepair += statement.AmountDue;

                ListViewItem searchStatement = new ListViewItem(_supplierID.ToString());
                searchStatement.SubItems.Add(_repairID.ToString());
                searchStatement.SubItems.Add(_invoiceNumber);
                searchStatement.SubItems.Add(_type);
                searchStatement.SubItems.Add(_repairAmount.ToString("N2"));

                statementLV.Items.Add(searchStatement);
            }
        }
        public void LoadRepairDetailStatement()
        {
            _statements = _statement.RetrieveRepairDetailStatement(_conditionString1);
            _totalPart = 0;
            foreach (Statement statement in _statements)
            {
                _supplierID = statement.SupplierID;
                _partID = statement.ID;
                _invoiceNumber = statement.InvoiceNumber;
                _type = statement.Type;
                _repairAmount = statement.AmountDue;
                _totalPart += statement.AmountDue;

                ListViewItem searchStatement = new ListViewItem(_supplierID.ToString());
                searchStatement.SubItems.Add(_partID.ToString());
                searchStatement.SubItems.Add(_invoiceNumber);
                searchStatement.SubItems.Add(_type);
                searchStatement.SubItems.Add(_repairAmount.ToString("N2"));

                statementLV.Items.Add(searchStatement);
            }
        }*/
        #endregion

        #region Other Methods
        private void ShowData(string plateNumber)
        {
            LoadRegistration(plateNumber);
            LoadInsurance(plateNumber);
            LoadRepair(plateNumber);
            Loadfuel(plateNumber);

            _vehicle = _vehicle.RetrieveVehicleInfo(plateNumber);
            plateNumberTB.Text = _vehicle.PlateNumber;
            crNumberTB.Text = _vehicle.CRNumber;
            crDateDTP.Value = _vehicle.CRDate;
            listingCB.Text = _vehicle.Listing;
            brandCB.Text = _vehicle.Brand;
            categoryCB.Text = _vehicle.Category;
            issuedToTB.Text = _vehicle.IssuedTo;

            _registration = _registration.RetrieveRegistrationInfo(plateNumber);
            registrationPlateNumberTB.Text = _registration.PlateNumber;
            registeredNameTB.Text = registrationRegisteredNameTB.Text = _registration.RegisteredName;
            registrationORNumberTB.Text = _registration.ORNumber;
            
            if (_registration.Renewal.ToString() != "01/01/0001 12:00:00 AM")
            {
                registrationRenewalDTP.Value = _registration.Renewal;
            }
            else
            {
                registrationRenewalDTP.Value = DateTime.Now;
            }
            registrationAmountTB.Text = _registration.Amount.ToString("N2");
            remarksRTB.Text = _registration.Remarks;

            _insurance = _insurance.RetrieveInsuranceInfo(plateNumber);
            insurancePlateNumberTB.Text = plateNumber;
            insuranceRegisteredNameTB.Text = _registration.RegisteredName;
            insuranceCompanyTB.Text = _insurance.Company;
           // insuranceDurationFromDTP.Value = _insurance.DurationFrom;
           // insuranceDurationToDTP.Value = _insurance.DurationTo;
            //insuranceRenewalDTP.Value = _insurance.Renewal;
            insuranceAmountTB.Text = _insurance.Amount.ToString("N2");

            _repairs = _repair.RetrieveRepairList(plateNumber);
            repairPlateNumberTB.Text = plateNumber; //this
            //repairDateDTP.Value = _repair.RepairDate;
            repairTypeOfRepairTB.Text = _repair.TypeOfRepair;
            repairSupplierCB.Text = _supplier.RetrieveSupplierInfo(_repair.SupplierID).SupplierName;
            repairSupplierInvoiceNumberTB.Text = _repair.InvoiceNumber;
            repairAmountTB.Text = _repair.Amount.ToString("N2");

            _fuel = _fuel.RetrieveFuelInfo(plateNumber); 
            fuelPlateNumberTB.Text = plateNumber; //this
            fuelVehicleTB.Text = _vehicle.RetrieveVehicleInfo(_fuel.PlateNumber).Category;
           // fuelDateDTP.Value = _fuel.FuelDate;
            fuelTypeOfFuelCB.Text = _fuel.TypeOfFuel;
            fuelSupplierTB.Text = _supplier.RetrieveSupplierInfo(_fuel.SupplierID).SupplierName;
            fuelAmountTB.Text = _fuel.Amount.ToString("N2");
        }
        public void AddPart()
        {
            NewPartForm partForm = new NewPartForm(this);
            partForm.Show();
        }
        public void Compute()
        {
            _totalAmt = _totalFuel + _totalRepair + _totalPart;
            totalDueTB.Text = "P " + _totalAmt.ToString("N2");
        }
        #endregion

        #region Selected Index Changed
        private void SupplierSortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierSortCB.SelectedIndex > -1)
            {
                _conditionString1 = "AND supplier.SupplierName = '" + supplierSortCB.Text + "' ";
                LoadALLStatement();
                Compute();
            }
            else
            {
                _conditionString1 = "";
            }

        }
        private void VehicleListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFuel();
            ClearRepair();
            ClearMaintenance();
            ClearInformation();
            ClearInsurance();
            ClearRegistration();
            if (vehicleListLV.SelectedItems.Count > 0)
            {
                _plateNumber = vehicleListLV.SelectedItems[0].Text;
                ShowData(_plateNumber);
                MaintenanceListLoad(_plateNumber);
            }
        }
        private void RepairLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repairLV.SelectedItems.Count > 0)
            {
                _repairID = int.Parse(repairLV.SelectedItems[0].Text);
                _repair.RetrieveRepairInfo(_repairID);
                _plateNumber = _maintenance.RetrieveMaintenanceInfo(_repair.MaintenanceID).PlateNumber;
                repairPlateNumberTB.Text = _plateNumber;
                repairDateDTP.Value = _repair.RepairDate;
                repairTypeOfRepairTB.Text = _repair.TypeOfRepair;
                repairSupplierCB.Text = _supplier.RetrieveSupplierInfo(_repair.SupplierID).SupplierName;
                repairAmountTB.Text = _repair.Amount.ToString("N2");
            }
        }
        private void statementLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFuel();
            ClearRepair();
            if (statementLV.SelectedItems.Count > 0)
            {
                fuelLV.Items.Clear();
                repairLV.Items.Clear();
                if (statementLV.SelectedItems[0].SubItems[3].Text == "Fuel")
                {
                    informationTC.SelectedTab = fuelTP;
                    fuelPlateNumberTB.Text = _fuel.RetrieveFuelInfo(_fuelID).PlateNumber;
                    _plateNumber = _fuel.RetrieveFuelInfo(_fuelID).PlateNumber;
                    fuelVehicleTB.Text = _vehicle.RetrieveVehicleInfo(_plateNumber).Brand;
                    _fuelID = int.Parse(statementLV.SelectedItems[0].SubItems[1].Text);
                    fuelTypeOfFuelCB.Text = _fuel.RetrieveFuelInfo(_fuelID).TypeOfFuel;
                    fuelAmountTB.Text = statementLV.SelectedItems[0].SubItems[4].Text;
                    fuelInvoiceNumberTB.Text = statementLV.SelectedItems[0].SubItems[2].Text;
                    _supplierID = int.Parse(statementLV.SelectedItems[0].SubItems[0].Text);
                    fuelSupplierTB.Text = _supplier.RetrieveSupplierInfo(_supplierID).SupplierName;

                }
                else if (statementLV.SelectedItems[0].SubItems[3].Text == "Repair")
                {
                    informationTC.SelectedTab = repairTP;
                    _repairID = int.Parse(statementLV.SelectedItems[0].SubItems[1].Text);
                    _maintenanceID = _repair.RetrieveRepairInfo(_repairID).MaintenanceID;
                    repairPlateNumberTB.Text = _maintenance.RetrieveMaintenanceInfo(_maintenanceID).PlateNumber;
                    repairTypeOfRepairTB.Text = _repair.RetrieveRepairInfo(_repairID).TypeOfRepair;
                    _supplierID = int.Parse(statementLV.SelectedItems[0].SubItems[0].Text);
                    repairSupplierCB.Text = _supplier.RetrieveSupplierInfo(_supplierID).SupplierName;
                    repairSupplierInvoiceNumberTB.Text = statementLV.SelectedItems[0].SubItems[2].Text;
                    repairAmountTB.Text = statementLV.SelectedItems[0].SubItems[4].Text;
                }
                else if (statementLV.SelectedItems[0].SubItems[3].Text == "Part")
                {
                    RepairDetailsForm repairDetailsForm = new RepairDetailsForm(this);
                    int _getID = int.Parse(statementLV.SelectedItems[0].SubItems[1].Text);
                    _invoiceNumber = statementLV.SelectedItems[0].SubItems[2].Text;


                    repairDetailsForm._partID = _getID;
                    repairDetailsForm._invoiceNumber = _invoiceNumber;

                    repairDetailsForm.LoadStatementRepair(_getID, _invoiceNumber);
                    repairDetailsForm.ShowDialog();
                }
            }
        }
        private void vehicleListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleListLV.SelectedItems.Count > 0)
            {
                _plateNumber = vehicleListLV.SelectedItems[0].Text;
                ShowData(_plateNumber);
            }
        }
        private void maintenanceLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maintenanceLV.SelectedItems.Count > 0)
            {
                _maintenanceID = int.Parse(maintenanceLV.SelectedItems[0].Text);
                _maintenance.RetrieveMaintenanceInfo(_maintenanceID);

                plateNumberCB.Text = _plateNumber;
                partCB.Text = _part.RetrievePartInfo(_maintenance.PartID).Description;
                statusCB.Text = _maintenance.Status;
            }
        }
        #endregion

        #region Tool Strip Menu
        /* private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
         {
             ReportsForm reportsForm = new ReportsForm();
             reportsForm.Show();
         }*/
        private void newVehicleTSM_Click(object sender, EventArgs e)
        {
            NewVehicleForm newVehicleForm = new NewVehicleForm(this);
            newVehicleForm.ShowDialog();
        }
        private void newInsuranceTSM_Click(object sender, EventArgs e)
        {
            NewInsuranceForm newInsuranceForm = new NewInsuranceForm();
            newInsuranceForm.ShowDialog();
        }
        private void newRepairTSM_Click(object sender, EventArgs e)
        {
            NewRepairForm repairForm = new NewRepairForm();
            repairForm.ShowDialog();
        }
        private void newFuelTSM_Click(object sender, EventArgs e)
        {
            NewFuelForm newfuelForm = new NewFuelForm();
            newfuelForm.ShowDialog();
        }
        private void editInformationTSM_Click(object sender, EventArgs e)
        {
            if (editB.Text == "Edit")
            {
                editB.Text = "Save";
                EnableInformation();
            }
            else if (editB.Text == "Save")
            {
                if (_registeredName != registeredNameTB.Text ||
                   _listing != listingCB.Text ||
                   _brand != brandCB.Text ||
                   _category != categoryCB.Text ||
                   _crNumber != crNumberTB.Text ||
                   _crDate != crDateDTP.Value ||
                   _issuedTo != issuedToTB.Text)
                {
                    _vehicle = new Vehicle(_vehicle.PlateNumber, listingCB.Text, brandCB.Text, categoryCB.Text, crNumberTB.Text, crDateDTP.Value, issuedToTB.Text);
                }
                _vehicle.UpdateVehicleInfo(_vehicle);
                editB.Text = "Edit";
                DisableInformation();
            }
        }
        private void editRegistrationTSM_Click(object sender, EventArgs e)
        {
            if (registrationEditB.Text == "Edit")
            {
                registrationEditB.Text = "Save";
                EnableRegistration();
            }
            else if (registrationEditB.Text == "Save")
            {
                if (_registeredName != registrationRegisteredNameTB.Text ||
                    _orNumber != registrationORNumberTB.Text ||
                    _orDate != registrationORDateDTP.Value ||
                    _renewal != registrationRenewalDTP.Value ||
                    _amount != double.Parse(registrationAmountTB.Text.Trim()) ||
                    _remarks != remarksRTB.Text)
                {
                    _registration = new Registration(_registration.RegistrationID, _registration.PlateNumber,
                                                     registrationRegisteredNameTB.Text,
                                                     registrationORNumberTB.Text,
                                                     registrationORDateDTP.Value,
                                                     registrationRenewalDTP.Value,
                                                     double.Parse(registrationAmountTB.Text.Trim()),
                                                     remarksRTB.Text);
                }

                _registration.UpdateRegistrationInfo(_registration);
                registrationEditB.Text = "Edit";
                DisableRegistration();
                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
                MaintenanceListLoad(_plateNumber);
            }
        }
        private void sortClearB_Click(object sender, EventArgs e)
        {
            supplierSortCB.SelectedIndex = -1;
            LoadALLStatement();
            Compute();
        }
        private void editInsuranceTSM_Click(object sender, EventArgs e)
        {
            if (insuranceEditB.Text == "Edit")
            {
                insuranceEditB.Text = "Save";
                EnableInsurance();
            }
            else if (insuranceEditB.Text == "Save")
            {
                if (_insuranceRegisteredName != insuranceRegisteredNameTB.Text ||
                    _insuranceCompany != insuranceCompanyTB.Text ||
                    _insuranceDurationFrom != insuranceDurationFromDTP.Value ||
                    _insuranceDurationTo != insuranceDurationToDTP.Value ||
                    _insuranceRenewal != insuranceDurationToDTP.Value ||
                    _insuranceRenewal != insuranceRenewalDTP.Value ||
                    _insuranceAmount != double.Parse(insuranceAmountTB.Text))
                {
                    _insurance = new Insurance(_insurance.InsuranceID,
                                               _insurance.PlateNumber,
                                               insuranceCompanyTB.Text,
                                               insuranceDurationFromDTP.Value,
                                               insuranceDurationToDTP.Value,
                                               insuranceRenewalDTP.Value,
                                               double.Parse(insuranceAmountTB.Text.Trim()));
                }
                _insurance.UpdateInsuranceInfo(_insurance);
                insuranceEditB.Text = "Edit";
                DisableInsurance();

                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
                MaintenanceListLoad(_plateNumber);
            }
        }
        private void aboutTSM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEVELOPERS:\nAlma Anne Angel Salipot\nIvan Roi Lomahan\nLheamour Pasing\n\nTG Home Builders\n© 2020 All Rights Reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void editFuelTSM_Click(object sender, EventArgs e)
        {
            switch (fuelEditB.Text)
            {
                case "Edit":
                    fuelEditB.Text = "Save";
                    EnableFuel();
                    break;

                case "Save":
                    if (_fuelVehicle != fuelVehicleTB.Text ||
                    _fuelDate != fuelDateDTP.Value ||
                    _typeOffuel != fuelTypeOfFuelCB.Text ||
                    _fuelSupplier != fuelSupplierTB.Text ||
                    _fuelAmount != double.Parse(fuelAmountTB.Text))
                    {
                        _fuel = new Fuel(_fuel.FuelID,
                                        _fuel.PlateNumber,
                                       fuelDateDTP.Value,
                                       fuelTypeOfFuelCB.Text,
                                       fuelInvoiceNumberTB.Text,
                                       int.Parse(fuelSupplierTB.Text),
                                       double.Parse(fuelAmountTB.Text));
                    }

                    _fuel.UpdateFuelInfo(_fuel);
                    DisableFuel();
                    fuelEditB.Text = "Edit";

                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    MaintenanceListLoad(_plateNumber);
                    break;
            }
        }
        private void editMaintenanceB_Click(object sender, EventArgs e)
        {
            switch (editMaintenanceB.Text)
            {
                case "Edit":
                    editMaintenanceB.Text = "Update";
                    EnableMaintenance();
                    break;

                case "Update":

                    _maintenanceID = int.Parse(maintenanceLV.SelectedItems[0].Text);
                    _partID = _part.RetrievePartID(partCB.Text);
                   _maintenance = new Maintenance(_maintenance.MaintenanceID,
                                    _maintenance.PlateNumber,
                                   _partID, _status); //added

                    _maintenance.UpdateMaintenanceInfo(_maintenance);
                    editMaintenanceB.Text = "Edit";

                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    MaintenanceListLoad(_plateNumber);
                    DisableMaintenance();
                    break;
            }
        }
        private void MaintenanceTSM_Click(object sender, EventArgs e)
        {
            NewMaintenanceForm newMaintenanceForm = new NewMaintenanceForm();
            newMaintenanceForm.ShowDialog();
        }
        private void viewRepairDetailB_Click(object sender, EventArgs e)
        {
            RepairDetailsForm repairDetailsForm = new RepairDetailsForm(this);
            int _getID = _repairID;
            string _getPlateNumber = _plateNumber;
            repairDetailsForm._repairID = _getID;
            repairDetailsForm._plateNumber = _getPlateNumber;
            repairDetailsForm.ShowDialog();
        }
        private void PaymentTSM_Click(object sender, EventArgs e)
        {
            NewPaymentForm newPaymentForm = new NewPaymentForm();
            newPaymentForm.ShowDialog();
        }
        private void SupplierTSM_Click(object sender, EventArgs e)
        {
            NewSupplierForm newSupplier = new NewSupplierForm();
            newSupplier.ShowDialog();
        }
        private void PartsForRepairTSM_Click(object sender, EventArgs e)
        {
            NewPartForm partForm = new NewPartForm();
            partForm.Show();
        }
        private void maintenanceCancelB_Click(object sender, EventArgs e)
        {
            DisableMaintenance();
            editMaintenanceB.Text = "Edit";
        }
        #endregion

        #region Edit Cancel Clear
        //HERE all contents of load()
        private void editB_Click(object sender, EventArgs e)
        {
            if (editB.Text == "Edit")
            {
                editB.Text = "Save";
                EnableInformation();
            }
            else if (editB.Text == "Save")
            {
                if (_plateNumber != plateNumberTB.Text ||
                   _registeredName != registeredNameTB.Text ||
                   _listing != listingCB.Text ||
                   _brand != brandCB.Text ||
                   _category != categoryCB.Text ||
                   _crNumber != crNumberTB.Text || 
                   _crDate != crDateDTP.Value ||
                   _issuedTo != issuedToTB.Text)
                {
                    _registration = new Registration();
                    _vehicle = new Vehicle(plateNumberTB.Text, listingCB.Text, brandCB.Text, categoryCB.Text, crNumberTB.Text, crDateDTP.Value, issuedToTB.Text);
                }
                _registration.UpdateRegistrationName(registeredNameTB.Text, plateNumberTB.Text);
                _vehicle.UpdateVehicleInfo(_vehicle);
                DisableInformation();
                editB.Text = "Edit";
            }
            LoadRegistration(plateNumberTB.Text);
            LoadInsurance(plateNumberTB.Text);
            LoadRepair(plateNumberTB.Text);
            Loadfuel(plateNumberTB.Text);
        }
        private void cancelB_Click(object sender, EventArgs e)
        {
            DisableInformation();
            editB.Text = "Edit";

            LoadRegistration(_plateNumber);
            LoadInsurance(_plateNumber);
            LoadRepair(_plateNumber);
            Loadfuel(_plateNumber);
        }
        private void clearB_Click(object sender, EventArgs e)
        {
            ClearInformation();
        }
        
        private void registrationEditB_Click(object sender, EventArgs e)
        {
            if (registrationEditB.Text == "Edit")
            {
                registrationEditB.Text = "Save";
                EnableRegistration();
            }
            else if (registrationEditB.Text == "Save")
            {
                if (_registeredName != registrationRegisteredNameTB.Text ||
                    _orNumber != registrationORNumberTB.Text ||
                    _orDate != registrationORDateDTP.Value ||
                    _renewal != registrationRenewalDTP.Value ||
                    _amount != double.Parse(registrationAmountTB.Text.Trim()) ||
                    _remarks != remarksRTB.Text)
                {
                    _registration = new Registration(_registration.RegistrationID,_registration.PlateNumber,
                                                     registrationRegisteredNameTB.Text,
                                                     registrationORNumberTB.Text,
                                                     registrationORDateDTP.Value,
                                                     registrationRenewalDTP.Value,
                                                     double.Parse(registrationAmountTB.Text.Trim()),
                                                     remarksRTB.Text);
                }

                _registration.UpdateRegistrationInfo(_registration);
                DisableRegistration();
                registrationEditB.Text = "Edit";

                LoadRegistration(_registration.PlateNumber);
                LoadInsurance(_registration.PlateNumber);
                LoadRepair(_registration.PlateNumber);
                Loadfuel(_registration.PlateNumber);
            }
        }
        private void registrationCancelB_Click(object sender, EventArgs e)
        {
            DisableRegistration();
            registrationEditB.Text = "Edit";

            LoadRegistration(_plateNumber);
            LoadInsurance(_plateNumber);
            LoadRepair(_plateNumber);
            Loadfuel(_plateNumber);
        }
        private void registrationClearB_Click(object sender, EventArgs e)
        {
            ClearRegistration();
        }

        private void insuranceEditB_Click(object sender, EventArgs e)
        {
            if (insuranceEditB.Text == "Edit")
            {
                insuranceEditB.Text = "Save";
                EnableInsurance();
            }
            else if (insuranceEditB.Text == "Save")
            {
                if (_insuranceRegisteredName != insuranceRegisteredNameTB.Text ||
                    _insuranceCompany != insuranceCompanyTB.Text ||
                    _insuranceDurationFrom != insuranceDurationFromDTP.Value ||
                    _insuranceDurationTo != insuranceDurationToDTP.Value ||
                    _insuranceRenewal != insuranceDurationToDTP.Value ||
                    _insuranceRenewal != insuranceRenewalDTP.Value ||
                    _insuranceAmount != double.Parse(insuranceAmountTB.Text))
                {
                    _insurance = new Insurance(_insurance.InsuranceID,
                                               _insurance.PlateNumber,
                                               insuranceCompanyTB.Text,
                                               insuranceDurationFromDTP.Value,
                                               insuranceDurationToDTP.Value,
                                               insuranceRenewalDTP.Value,
                                               double.Parse(insuranceAmountTB.Text.Trim()));
                }

                _insurance.UpdateInsuranceInfo(_insurance);
                DisableInsurance();
                insuranceEditB.Text = "Edit";


                LoadRegistration(_insurance.PlateNumber);
                LoadInsurance(_insurance.PlateNumber);
                LoadRepair(_insurance.PlateNumber);
                Loadfuel(_insurance.PlateNumber);
            }
        }
        private void insuranceCancelB_Click(object sender, EventArgs e)
        {
            DisableInsurance();
            insuranceEditB.Text = "Edit";

            LoadInsurance(_plateNumber);
        }
        private void insuranceClearB_Click(object sender, EventArgs e)
        {
            ClearInsurance();
        }
       
        private void repairEditB_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            switch (bt.Text)
            {
                case "Edit":
                    repairEditB.Text = "Save";
                    EnableRepair();
                    break;

                case "Save":
                    if (_repairDate != repairDateDTP.Value ||
                    _typeOfRepair != repairTypeOfRepairTB.Text ||
                    _repairSupplier != repairSupplierCB.Text ||
                    _repairAmount != double.Parse(repairAmountTB.Text))
                    {
                        _repair = new Repair(int.Parse(_repair.RepairID.ToString()),
                                             _repair.MaintenanceID,
                                             repairDateDTP.Value,
                                             repairTypeOfRepairTB.Text, 
                                             repairSupplierInvoiceNumberTB.Text,
                                             _supplier.RetrieveSupplierID(repairSupplierCB.Text),
                                             double.Parse(repairAmountTB.Text));
                    }

                    _repair.UpdateRepairInfo(_repair);
                    DisableRepair();
                    repairEditB.Text = "Edit";

                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    break;
            }
        }
        private void repairCancelB_Click(object sender, EventArgs e)
        {
            DisableRepair();
            repairEditB.Text = "Edit";
            LoadRepair(_plateNumber);
        }
        private void repairClearB_Click(object sender, EventArgs e)
        {
            ClearRepair();
        }

        private void fuelEditB_Click(object sender, EventArgs e)
        {
            switch (fuelEditB.Text)
            {
                case "Edit":
                    fuelEditB.Text = "Save";
                    EnableFuel();
                    break;

                case "Save":
                    if (_fuelVehicle != fuelVehicleTB.Text ||
                    _fuelDate != fuelDateDTP.Value ||
                    _typeOffuel != fuelTypeOfFuelCB.Text ||
                    _fuelSupplier != fuelSupplierTB.Text ||
                    _fuelAmount != double.Parse(fuelAmountTB.Text))
                    {
                        _fuel = new Fuel(_fuel.FuelID,
                                       _fuel.PlateNumber,
                                       fuelDateDTP.Value,
                                       fuelTypeOfFuelCB.Text,
                                       fuelInvoiceNumberTB.Text,
                                       int.Parse(fuelSupplierTB.Text),
                                       double.Parse(fuelAmountTB.Text));
                    }

                    _fuel.UpdateFuelInfo(_fuel);
                    DisableFuel();
                    fuelEditB.Text = "Edit";

                    LoadRegistration(_fuel.PlateNumber);
                    LoadInsurance(_fuel.PlateNumber);
                    LoadRepair(_fuel.PlateNumber);
                    Loadfuel(_fuel.PlateNumber);
                    break;
            }
        }
        private void fuelCancelB_Click(object sender, EventArgs e)
        {
            DisableFuel();
            fuelEditB.Text = "Edit";
            Loadfuel(_plateNumber);
        }
        private void fuelClearB_Click(object sender, EventArgs e)
        {
            ClearFuel();
        }
        #endregion

        #region Enable Disable Clear
        private void EnableInformation()
        {
            plateNumberTB.Enabled = true;
            registeredNameTB.Enabled = true;
            listingCB.Enabled = true;
            brandCB.Enabled = true;
            categoryCB.Enabled = true;

            cancelB.Visible = true;
            clearB.Visible = true;
        }
        private void ClearInformation()
        {
            registeredNameTB.Text = "";
            crNumberTB.Text = "";
            crDateDTP.Value = DateTime.Now;
            listingCB.Text = "";
            brandCB.Text = "";
            categoryCB.Text = "";
            issuedToTB.Text = "";
        }
        private void DisableInformation()
        {
            plateNumberTB.Enabled = false;
            registeredNameTB.Enabled = false;
            crNumberTB.Enabled = false;
            crDateDTP.Enabled = false;
            listingCB.Enabled = false;
            brandCB.Enabled = false;
            categoryCB.Enabled = false;

            cancelB.Visible = false;
            clearB.Visible = false;
        }

        private void EnableRegistration()
        {
            registrationPlateNumberTB.Enabled = true;
            registrationRegisteredNameTB.Enabled = true;
            registrationORNumberTB.Enabled = true;
            registrationORDateDTP.Enabled = true;
            registrationRenewalDTP.Enabled = true;
            registrationAmountTB.Enabled = true;
            remarksRTB.Enabled = true;

            registrationCancelB.Visible = true;
            registrationClearB.Visible = true;
        }
        private void ClearRegistration()
        {
            registrationRegisteredNameTB.Text = "";
            registrationORNumberTB.Text = "";
            registrationORDateDTP.Value = DateTime.Now;
            registrationRenewalDTP.Text = "";
            registrationAmountTB.Text = "";
            remarksRTB.Text = "";
        }
        private void DisableRegistration()
        {
            registrationPlateNumberTB.Enabled = false;
            registrationRegisteredNameTB.Enabled = false;
            registrationORNumberTB.Enabled = false;
            registrationORDateDTP.Enabled = false;
            registrationRenewalDTP.Enabled = false;
            registrationAmountTB.Enabled = false;
            remarksRTB.Enabled = false;

            registrationCancelB.Visible = false;
            registrationClearB.Visible = false;
        }

        private void EnableInsurance()
        {

            insurancePlateNumberTB.Enabled = true;
            insuranceRegisteredNameTB.Enabled = true;
            insuranceCompanyTB.Enabled = true;
            insuranceDurationFromDTP.Enabled = true;
            insuranceDurationToDTP.Enabled = true;
            insuranceRenewalDTP.Enabled = true;
            insuranceAmountTB.Enabled = true;

            insuranceCancelB.Visible = true;
            insuranceClearB.Visible = true;
        }
        private void ClearInsurance()
        {
            insuranceRegisteredNameTB.Text = "";
            insuranceCompanyTB.Text = "";
            insuranceDurationFromDTP.Value = DateTime.Now;
            insuranceDurationToDTP.Value = DateTime.Now;
            insuranceRenewalDTP.Value = DateTime.Now;
            insuranceAmountTB.Text = "";
        }
        private void DisableInsurance()
        {
            insurancePlateNumberTB.Enabled = false;
            insuranceRegisteredNameTB.Enabled = false;
            insuranceCompanyTB.Enabled = false;
            insuranceDurationFromDTP.Enabled = false;
            insuranceDurationToDTP.Enabled = false;
            insuranceRenewalDTP.Enabled = false;
            insuranceAmountTB.Enabled = false;

            insuranceCancelB.Visible = false;
            insuranceClearB.Visible = false;
        }

        private void EnableFuel()
        {
            fuelVehicleTB.Enabled = true;
            fuelDateDTP.Enabled = true;
            fuelTypeOfFuelCB.Enabled = true;
            fuelSupplierTB.Enabled = true;
            fuelAmountTB.Enabled = true;
            fuelPaidByTB.Enabled = true;

            fuelCancelB.Visible = true;
            fuelClearB.Visible = true;
        }
        private void ClearFuel()
        {
            fuelVehicleTB.Text = "";
            fuelDateDTP.Value = DateTime.Now;
            fuelTypeOfFuelCB.Text = "";
            fuelSupplierTB.Text = "";
            fuelAmountTB.Text = "";
            fuelPaidByTB.Text = "";
        }
        private void DisableFuel()
        {
            fuelVehicleTB.Enabled = false;
            fuelDateDTP.Enabled = false;
            fuelTypeOfFuelCB.Enabled = false;
            fuelSupplierTB.Enabled = false;
            fuelAmountTB.Enabled = false;
            fuelPaidByTB.Enabled = false;

            fuelCancelB.Visible = false;
            fuelClearB.Visible = false;
        }

        private void EnableRepair()
        {
            repairPlateNumberTB.Enabled = true;
            repairDateDTP.Enabled = true;
            repairTypeOfRepairTB.Enabled = true;
            repairAmountTB.Enabled = true;
            repairSupplierCB.Enabled = true;

            repairCancelB.Visible = true;
            repairClearB.Visible = true;
        }
        private void ClearRepair()
        {
            repairPlateNumberTB.Text = "";
            repairDateDTP.Value = DateTime.Now;
            repairTypeOfRepairTB.Text = "";
            repairSupplierCB.Text = "";
            repairSupplierInvoiceNumberTB.Text = "";
            repairAmountTB.Text = "";
            repairDueDateDTP.Value = DateTime.Now;

        }
        private void DisableRepair()
        {
            repairPlateNumberTB.Enabled = false;
            repairDateDTP.Enabled = false;
            repairTypeOfRepairTB.Enabled = false;
            repairAmountTB.Enabled = false;
            repairDueDateDTP.Enabled = false;
            repairSupplierCB.Enabled = false;

            repairCancelB.Visible = false;
            repairClearB.Visible = false;
        }

        private void ClearMaintenance()
        {
            plateNumberCB.Text = "";
            partCB.Text = "";
            statusCB.Text = "";
        }
        private void EnableMaintenance()
        {
            partCB.Enabled = true;
            statusCB.Enabled = true;
            maintenanceCancelB.Visible = true;

        }
        private void DisableMaintenance()
        {
            partCB.Enabled = false;
            statusCB.Enabled = false;
            maintenanceCancelB.Visible = false;
        }
        #endregion
    }
}
