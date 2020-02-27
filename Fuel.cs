using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Fuel
    {
        #region Variable
        public int    FuelID,
                      SupplierID;
        public string PlateNumber,
                      TypeOfFuel,
                      InvoiceNumber;
        public bool Paid;
        public DateTime FuelDate;
        public double Amount;
        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Fuel() { }

        public Fuel(int fuelID,
                    string plateNumber, 
                    DateTime fuelDate, 
                    string typeOfFuel,
                    string invoiceNumber,
                    int supplierID,
                    double amount, 
                    bool paid)
        {
            FuelID = fuelID;
            PlateNumber = plateNumber;
            FuelDate = fuelDate;
            TypeOfFuel = typeOfFuel;
            InvoiceNumber = invoiceNumber;
            SupplierID = supplierID;
            Amount = amount;
            Paid = paid;
        }
        #endregion

        #region Fuel Methods
        public void InsertFuel(Fuel fuel)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Fuel(FuelID,PlateNumber,FuelDate,TypeOfFuel,InvoiceNumber,SupplierID,Amount,PaidBy)VALUE(@FuelID,@PlateNumber,@FuelDate,@TypeOfFuel,@InvoiceNumber,@SupplierID,@Amount,@PaidBy)";

                cmd.Parameters.AddWithValue("@FuelID", fuel.FuelID);
                cmd.Parameters.AddWithValue("@PlateNumber", fuel.PlateNumber);
                cmd.Parameters.AddWithValue("@FuelDate", fuel.FuelDate);
                cmd.Parameters.AddWithValue("@TypeOfFuel", fuel.TypeOfFuel);
                cmd.Parameters.AddWithValue("@InvoiceNumber", fuel.InvoiceNumber);
                cmd.Parameters.AddWithValue("@SupplierID", fuel.SupplierID);
                cmd.Parameters.AddWithValue("@Amount", fuel.Amount);
                cmd.Parameters.AddWithValue("@PaidBy", fuel.Paid);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Fuel Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public Fuel RetrieveFuelInfo(string plateNumber)
        {
            Fuel temp = new Fuel();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Fuel " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    FuelID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    FuelDate = (DateTime)reader.GetValue(2);
                    TypeOfFuel = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Fuel(FuelID, PlateNumber, FuelDate, TypeOfFuel, InvoiceNumber, SupplierID, Amount, Paid);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return temp;
        }
        public Fuel RetrieveFuelInfo(int fuelID)
        {
            Fuel temp = new Fuel();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Fuel " + "WHERE FuelID = @FuelID";
                cmd.Parameters.AddWithValue("@FuelID", fuelID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FuelID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    FuelDate = (DateTime)reader.GetValue(2);
                    TypeOfFuel = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Fuel(FuelID, PlateNumber, FuelDate, TypeOfFuel, InvoiceNumber, SupplierID, Amount, Paid);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return temp;
        }

        public List<Fuel> RetrieveFuelList()
        {
            List<Fuel> fuelList = new List<Fuel>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Fuel";
                MySqlDataReader reader = cmd.ExecuteReader();
                Fuel temp = new Fuel();

                while(reader.Read())
                {
                    FuelID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    FuelDate = (DateTime)reader.GetValue(2);
                    TypeOfFuel = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Fuel(FuelID, PlateNumber, FuelDate, TypeOfFuel, InvoiceNumber, SupplierID, Amount, Paid);

                    fuelList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return fuelList;
        }

        public List<Fuel> RetrieveFuelList(string plateNumber)
        {
            List<Fuel> fuelList = new List<Fuel>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Fuel " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();
                Fuel temp = new Fuel();

                while(reader.Read())
                {
                    FuelID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    FuelDate = (DateTime)reader.GetValue(2);
                    TypeOfFuel = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Fuel(FuelID, PlateNumber, FuelDate, TypeOfFuel, InvoiceNumber, SupplierID, Amount, Paid);

                    fuelList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return fuelList;
        }

        public void UpdateFuelInfo(Fuel fuel)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Fuel SET FuelID = @FuelID, PlateNumber = @PlateNumber,FuelDate = @FuelDate,TypeOfFuel = @TypeOfFuel, InvoiceNumber = @InvoiceNumber, SupplierID = @SupplierID,Amount = @Amount,Paid = @Paid " + "WHERE FuelID = @FuelID";

                cmd.Parameters.AddWithValue("@FuelID", fuel.FuelID);
                cmd.Parameters.AddWithValue("@PlateNumber", fuel.PlateNumber);
                cmd.Parameters.AddWithValue("@FuelDate", fuel.FuelDate);
                cmd.Parameters.AddWithValue("@TypeOfFuel", fuel.TypeOfFuel);
                cmd.Parameters.AddWithValue("@InvoiceNumber", fuel.InvoiceNumber);
                cmd.Parameters.AddWithValue("@SupplierID", fuel.SupplierID);
                cmd.Parameters.AddWithValue("@Amount", fuel.Amount);
                cmd.Parameters.AddWithValue("@PaidBy", fuel.Paid);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fuel Record has been updated!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int CreateFuel()
        {
            FuelID = CountFuel();

            return FuelID;
        }

        public int CountFuel()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Fuel";

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                count++;
            }
            reader.Close();
            _dbOp.DBClose();

            return count;

        }
        #endregion
    }
}
