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
        private int _repairID = 0,
                    _insuranceID = 0,
                    _registrationID = 0,
                    _fuelID = 0;
                       

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
                       _repairPaidBy = "",
                       _fuelVehicle = "",
                       _typeOffuel = "",
                       _fuelSupplier = "",
                       _fuelPaidBy = "",
                       _issuedTo = "";
        private double _amount = 0.00,
                       _insuranceAmount = 0.00,
                       _repairAmount = 0.00,
                       _fuelAmount = 0.00;
        private DateTime _orDate = DateTime.Now,
                         _crDate = DateTime.Now,
                         _renewal = DateTime.Now,
                         _insuranceDurationFrom = DateTime.Now,
                         _insuranceDurationTo = DateTime.Now,
                         _insuranceRenewal = DateTime.Now,
                         _repairDate = DateTime.Now,
                         _fuelDate = DateTime.Now;

        private Vehicle      _vehicle = new Vehicle();
        private Registration _registration = new Registration();
        private Insurance    _insurance = new Insurance();
        private Repair       _repair = new Repair();
        private Fuel         _fuel = new Fuel();
        private Supplier    _supplier = new Supplier();
        private Payment      _payment = new Payment();
        List<Vehicle>      _vehicles = new List<Vehicle>();
        List<Registration> _registrations = new List<Registration>();
        List<Insurance>    _insurances = new List<Insurance>();
        List<Repair>       _repairs = new List<Repair>();
        List<Fuel>         _fuels = new List<Fuel>();
        List<Supplier> _suppliers = new List<Supplier>();
        List<Payment> _payments = new List<Payment>();
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            ListViewLoad();
            ComboBoxLoad();

        }
        #endregion

        #region Load
        private void ListViewLoad()
        {
            _vehicles = _vehicle.RetrieveVehicleList();
            foreach (Vehicle v in _vehicles)
            {
                vehicleListLV.Items.Add(v.PlateNumber);
            }
        }
        private void ComboBoxLoad()
        {
            _suppliers = _supplier.RetrieveSupplierList();
            foreach (Supplier s in _suppliers)
            {
                repairSupplierCB.Items.Add(s.SupplierName);
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
               // _plateNumber = repair.PlateNumber;
                _repairDate = repair.RepairDate;
                _typeOfRepair = repair.TypeOfRepair;
                _repairSupplier = _supplier.RetrieveSupplierInfo(repair.SupplierID).SupplierName;
                _repairAmount = repair.Amount;
             //   _repairPaidBy = repair.PaidBy;

                ListViewItem searchRepair = new ListViewItem(_repairID.ToString());
                searchRepair.SubItems.Add(_repairDate.ToShortDateString());
                searchRepair.SubItems.Add(_typeOfRepair);
                searchRepair.SubItems.Add(_repairSupplier);
                searchRepair.SubItems.Add(_repairAmount.ToString("N2"));
                searchRepair.SubItems.Add(_repairPaidBy);

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
          //      _fuelPaidBy = fuel.PaidBy;

                ListViewItem searchfuel = new ListViewItem(_fuelID.ToString());
                searchfuel.SubItems.Add(_plateNumber);
                searchfuel.SubItems.Add(_fuelDate.ToShortDateString());
                searchfuel.SubItems.Add(_typeOffuel);
                searchfuel.SubItems.Add(_fuelSupplier);
                searchfuel.SubItems.Add(_fuelAmount.ToString("N2"));
                searchfuel.SubItems.Add(_fuelPaidBy);

                fuelLV.Items.Add(searchfuel);
            }
        }
        #endregion
        
        private void ShowData(string plateNumber)
        {
            LoadRegistration(_plateNumber);
            LoadInsurance(_plateNumber);
            LoadRepair(_plateNumber);
            Loadfuel(_plateNumber);
            
            plateNumberTB.Text = _vehicle.PlateNumber;
            crNumberTB.Text = _vehicle.CRNumber;
            crDateDTP.Value = _vehicle.CRDate;
            listingCB.Text = _vehicle.Listing;
            brandCB.Text = _vehicle.Brand;
            categoryCB.Text = _vehicle.Category;
            issuedToTB.Text = _vehicle.IssuedTo;

            registrationPlateNumberTB.Text = _registration.PlateNumber;
            registeredNameTB.Text = registrationRegisteredNameTB.Text = _registration.RegisteredName;
            registrationORNumberTB.Text = _registration.ORNumber;
            registrationRenewalDTP.Value = _registration.Renewal;
            registrationAmountTB.Text = _registration.Amount.ToString("N2");
            remarksRTB.Text = _registration.Remarks;
            
            insurancePlateNumberTB.Text = _insurance.PlateNumber;
            insuranceRegisteredNameTB.Text = _registration.RegisteredName;
            insuranceCompanyTB.Text = _insurance.Company;
            insuranceDurationFromDTP.Value = _insurance.DurationFrom;
            insuranceDurationToDTP.Value = _insurance.DurationTo;
            insuranceRenewalDTP.Value = _insurance.Renewal;
            insuranceAmountTB.Text = _insurance.Amount.ToString("N2");

          //  repairPlateNumberTB.Text = _repair.PlateNumber;
            repairDateDTP.Value = _repair.RepairDate;
            repairTypeOfRepairTB.Text = _repair.TypeOfRepair;
            repairSupplierCB.Text = _supplier.RetrieveSupplierInfo(_repair.SupplierID).SupplierName;
            repairAmountTB.Text = _repair.Amount.ToString("N2");
          //  repairPaidByTB.Text = _repair.PaidBy;
            
            fuelPlateNumberTB.Text = _fuel.PlateNumber;
            fuelVehicleTB.Text = _vehicle.RetrieveVehicleInfo(_fuel.PlateNumber).Category;
            fuelDateDTP.Value = _fuel.FuelDate;
            fuelTypeOfFuelCB.Text = _fuel.TypeOfFuel;
            fuelSupplierTB.Text = _supplier.RetrieveSupplierInfo(_fuel.SupplierID).SupplierName;
            fuelAmountTB.Text = _fuel.Amount.ToString("N2");
           // fuelPaidByTB.Text = _fuel.PaidBy;
        }



        #region Tool Strip Menu
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }
        private void newVehicleTSM_Click(object sender, EventArgs e)
        {
            NewVehicleForm newVehicleForm = new NewVehicleForm();
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
        private void newMaintenanceTSM_Click(object sender, EventArgs e)
        {
         /*   NewMaintenanceForm newMaintenanceForm = new NewMaintenanceForm();
            newMaintenanceForm.ShowDialog();*/
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
            }
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

                LoadInsurance(_plateNumber);
            }
        }
        private void editRepairTSM_Click(object sender, EventArgs e)
        {
           /* if (repairEditB.Text == "Edit")
            {
                repairEditB.Text = "Save";
                EnableRepair();
            }
            else if (repairEditB.Text == "Save")
            {
                if (
                    _repairDate != repairDateDTP.Value ||
                    _typeOfRepair != repairTypeOfRepairTB.Text ||
                    _repairSupplier != repairSupplierCB.Text ||
                    _repairAmount != double.Parse(repairAmountTB.Text) ||
                    _repairPaidBy != repairPaidByTB.Text)
                {
                    _repair = new Repair(_repair.RepairID, _repair.PlateNumber,repairDateDTP.Value,repairTypeOfRepairTB.Text,int.Parse(repairSupplierCB.Text),repairSupplierInvoiceNumberTB.Text,double.Parse(repairAmountTB.Text),repairPaidByTB.Text);
                }
                _repair.UpdateRepairInfo(_repair);
                DisableRepair();
                repairEditB.Text = "Edit";

                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
            }*/
        }
        private void editFuelTSM_Click(object sender, EventArgs e)
        {
           /* switch (fuelEditB.Text)
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
                    _fuelAmount != double.Parse(fuelAmountTB.Text) ||
                    _fuelPaidBy != fuelPaidByTB.Text)
                    {
                        _fuel = new Fuel(_fuel.FuelID,
                                        _fuel.PlateNumber,
                                       fuelDateDTP.Value,
                                       fuelTypeOfFuelCB.Text,
                                       int.Parse(fuelSupplierTB.Text),
                                       double.Parse(fuelAmountTB.Text),
                                       fuelPaidByTB.Text);
                    }

                    _fuel.UpdateFuelInfo(_fuel);
                    DisableFuel();
                    fuelEditB.Text = "Edit";

                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    break;
            }*/
        }

        private void vehicleListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleListLV.SelectedItems.Count > 0) 
            { 
                _plateNumber = vehicleListLV.SelectedItems[0].Text;
                ShowData(_plateNumber);
            }
        }
        private void repairLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (repairLV.SelectedItems.Count > 0)
            {
                _repairID = int.Parse(repairLV.SelectedItems[0].Text);
                _repair.RetrieveRepairInfo(_repairID);

             //   repairPlateNumberTB.Text = _repair.PlateNumber;
                repairDateDTP.Value = _repair.RepairDate;
                repairTypeOfRepairTB.Text = _repair.TypeOfRepair;
                repairSupplierCB.Text = _supplier.RetrieveSupplierInfo(_repair.SupplierID).SupplierName;
                repairAmountTB.Text = _repair.Amount.ToString("N2");
             //   repairPaidByTB.Text = _repair.PaidBy;
            }
        }
        private void viewRepairB_Click(object sender, EventArgs e)
        {
            RepairDetailsForm repairDetailsForm = new RepairDetailsForm();
            repairDetailsForm.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPaymentForm newPaymentForm = new NewPaymentForm();
            newPaymentForm.ShowDialog();
        }
        #endregion

        #region Edit Cancel Clear
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
                    _vehicle = new Vehicle(plateNumberTB.Text, listingCB.Text, brandCB.Text, categoryCB.Text, crNumberTB.Text, crDateDTP.Value, issuedToTB.Text);
                }

                _vehicle.UpdateVehicleInfo(_vehicle);
                DisableInformation();
                editB.Text = "Edit";

                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
            }
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

                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
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


                LoadRegistration(_plateNumber);
                LoadInsurance(_plateNumber);
                LoadRepair(_plateNumber);
                Loadfuel(_plateNumber);
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

          /*  switch (bt.Text)
            {
                case "Edit":
                    repairEditB.Text = "Save";
                    EnableRepair();
                    break;

                case "Save":
                    if (_repairDate != repairDateDTP.Value ||
                    _typeOfRepair != repairTypeOfRepairTB.Text ||
                    _repairSupplier != repairSupplierCB.Text ||
                    _repairAmount != double.Parse(repairAmountTB.Text) ||
                    _repairPaidBy != repairPaidByTB.Text)
                    {
                        _repair = new Repair(_repair.RepairID,
                                             _repair.PlateNumber,
                                             repairDateDTP.Value,
                                             repairTypeOfRepairTB.Text,
                                             int.Parse(repairSupplierCB.Text),
                                             repairSupplierInvoiceNumberTB.Text,
                                             double.Parse(repairAmountTB.Text),
                                             repairPaidByTB.Text);
                    }

                    _repair.UpdateRepairInfo(_repair);
                    DisableRepair();
                    repairEditB.Text = "Edit";
                    
                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    break;
            }*/
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
            /*switch (fuelEditB.Text)
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
                    _fuelAmount != double.Parse(fuelAmountTB.Text) ||
                    _fuelPaidBy != fuelPaidByTB.Text)
                    {
                        _fuel = new Fuel(_fuel.FuelID,
                                       _fuel.PlateNumber,
                                       fuelDateDTP.Value,
                                       fuelTypeOfFuelCB.Text,
                                       int.Parse(fuelSupplierTB.Text),
                                       double.Parse(fuelAmountTB.Text),
                                       fuelPaidByTB.Text);
                    }

                    _fuel.UpdateFuelInfo(_fuel);
                    DisableFuel();
                    fuelEditB.Text = "Edit";

                    LoadRegistration(_plateNumber);
                    LoadInsurance(_plateNumber);
                    LoadRepair(_plateNumber);
                    Loadfuel(_plateNumber);
                    break;
            }*/
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
            repairPaidByTB.Enabled = true;

            repairCancelB.Visible = true;
            repairClearB.Visible = true;
        }
        private void ClearRepair()
        {
            repairDateDTP.Value = DateTime.Now;
            repairTypeOfRepairTB.Text = "";
            repairAmountTB.Text = "";
            repairPaidByTB.Text = "";
        }
        private void DisableRepair()
        {
            repairPlateNumberTB.Enabled = false;
            repairDateDTP.Enabled = false;
            repairTypeOfRepairTB.Enabled = false;
            repairAmountTB.Enabled = false;
            repairPaidByTB.Enabled = false;

            repairCancelB.Visible = false;
            repairClearB.Visible = false;
        }

        #endregion
    }
}
