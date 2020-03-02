using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Repair
    {
        #region Variable
        public int RepairID, MaintenanceID, SupplierID; //added

        public string TypeOfRepair, //removed
                      InvoiceNumber;
        public bool Paid = false;

        public DateTime RepairDate, DueDate;

        public double Amount;

        List<Repair> _repairs = new List<Repair>();

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Repair() { }

        public Repair(int repairID,
                       int maintenanceID,
                       DateTime repairDate,
                       string typeOfRepair,
                       string invoiceNumber,
                       int supplierID,
                       double amount)
        {
            RepairID = repairID;
            MaintenanceID = maintenanceID;
            RepairDate = repairDate;
            TypeOfRepair = typeOfRepair;
            SupplierID = supplierID;
            InvoiceNumber = invoiceNumber;
            Amount = amount;
        }
        #endregion

        #region Repair Methods
        public void InsertRepair(Repair repair)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmdRepair = _dbOp._dbConn.CreateCommand();

                cmdRepair.CommandText = @"INSERT INTO Repair(RepairID, MaintenanceID, RepairDate, TypeOfRepair, SupplierID, InvoiceNumber, Amount) 
                            VALUES(@RepairID, @MaintenanceID, @RepairDate, @TypeOfRepair,@SupplierID, @InvoiceNumber, @Amount)";

                cmdRepair.Parameters.AddWithValue("@RepairID", repair.RepairID);
                cmdRepair.Parameters.AddWithValue("@MaintenanceID", repair.MaintenanceID);
                cmdRepair.Parameters.AddWithValue("@RepairDate", repair.RepairDate);
                cmdRepair.Parameters.AddWithValue("@TypeOfRepair", repair.TypeOfRepair);
                cmdRepair.Parameters.AddWithValue("@SupplierID", repair.SupplierID);
                cmdRepair.Parameters.AddWithValue("@InvoiceNumber", repair.InvoiceNumber);
                cmdRepair.Parameters.AddWithValue("@Amount", repair.Amount);

                cmdRepair.ExecuteNonQuery();

                MessageBox.Show("New Repair Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public Repair RetrieveRepairInfo (int repairID)
        {
            Repair temp = new Repair();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Repair " + "WHERE RepairID = @RepairID";
                cmd.Parameters.AddWithValue("@RepairID", repairID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    RepairDate = (DateTime)reader.GetValue(2);
                    TypeOfRepair = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Repair(RepairID, MaintenanceID, RepairDate, TypeOfRepair, InvoiceNumber, SupplierID, Amount);
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

        public List<Repair> RetrieveRepairList()
        {
            List<Repair> repairList = new List<Repair>();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Repair";
                MySqlDataReader reader = cmd.ExecuteReader();
                Repair temp = new Repair();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    RepairDate = (DateTime)reader.GetValue(2);
                    TypeOfRepair = (string)reader.GetValue(3);
                    SupplierID = (int)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Repair(RepairID, MaintenanceID, RepairDate, TypeOfRepair, InvoiceNumber, SupplierID, Amount);

                    repairList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairList;
        }
        public List<Repair> RetrieveRepairList(string plateNumber)
        {
            List<Repair> repairList = new List<Repair>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM repair " + "WHERE MaintenanceID IN (SELECT MaintenanceID FROM maintenance " + "WHERE PlateNumber = @PlateNumber)";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();

                Repair temp = new Repair();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    RepairDate = (DateTime)reader.GetValue(2);
                    TypeOfRepair = (string)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Repair(RepairID, MaintenanceID, RepairDate, TypeOfRepair, InvoiceNumber, SupplierID, Amount);

                    repairList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairList;
        }
        public List<Repair> RetrieveRepairIDList(int repairID)
        {
            List<Repair> repairList = new List<Repair>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM Repair " + "WHERE RepairID = @RepairID";
                cmd.Parameters.AddWithValue("@RepairID", repairID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Repair temp = new Repair();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    RepairDate = (DateTime)reader.GetValue(2);
                    TypeOfRepair = (string)reader.GetValue(3);
                    SupplierID = (int)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Repair(RepairID, MaintenanceID, RepairDate, TypeOfRepair, InvoiceNumber, SupplierID, Amount);

                    repairList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairList;
        }
        public int RetriveRepairID(int maintenanceID)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM Repair " + "WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", maintenanceID); ;
                Repair _repair = new Repair();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(1);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return RepairID;

        }
        public void UpdateRepairInfo(Repair repair)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Repair SET RepairID = @RepairID, MaintenanceID = @MaintenanceID,RepairDate = @RepairDate,TypeOfRepair = @TypeOfRepair,SupplierID = @SupplierID, InvoiceNumber = @InvoiceNumber,Amount = @Amount " + "WHERE RepairID = @RepairID";

                cmd.Parameters.AddWithValue("@RepairID", repair.RepairID);
                cmd.Parameters.AddWithValue("@MaintenanceID", repair.MaintenanceID);
                cmd.Parameters.AddWithValue("@RepairDate", repair.RepairDate);
                cmd.Parameters.AddWithValue("@TypeOfRepair", repair.TypeOfRepair);
                cmd.Parameters.AddWithValue("@SupplierID", repair.SupplierID);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repair.InvoiceNumber);
                cmd.Parameters.AddWithValue("@Amount", repair.Amount);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Repair Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int CreateRepairID()
        {
            RepairID = CountRepair();

            return RepairID;
        }

        public int CountRepair()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM repair";

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
