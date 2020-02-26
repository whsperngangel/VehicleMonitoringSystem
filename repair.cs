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
        public int RepairID,
                   MaintenanceID,
                   SupplierID;
        public string TypeOfRepair,
                      InvoiceNumber;
        public DateTime RepairDate;
        public double Amount;
        public bool Paid;

        List<Repair> _repairs = new List<Repair>();

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Repair() { }

        public Repair(int repairID,
                      int maintenanceID,
                      int supplierID,
                      DateTime repairDate,
                      string typeOfRepair,
                      string invoiceNumber,
                      double amount,
                      bool paid)
        {
            RepairID = repairID;
            MaintenanceID = maintenanceID;
            SupplierID = supplierID;
            RepairDate = repairDate;
            TypeOfRepair = typeOfRepair;
            InvoiceNumber = invoiceNumber;
            Amount = amount;
            Paid = paid;
        }
        #endregion

        #region Repair Methods
        public void InsertRepair(Repair repair)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmdRepair = _dbOp._dbConn.CreateCommand();

                cmdRepair.CommandText = @"INSERT INTO Repair(RepairID,  
                                                             MaintenanceID,
                                                             SupplierID,  
                                                             PlateNumber,  
                                                             RepairDate,  
                                                             TypeOfRepair,  
                                                             InvoiceNumber,  
                                                             Amount,  
                                                             Paid)

                                                      VALUES(@RepairID,  
                                                             @MaintenanceID,
                                                             @SupplierID,  
                                                             @PlateNumber,  
                                                             @RepairDate,  
                                                             @TypeOfRepair,  
                                                             @InvoiceNumber,  
                                                             @Amount,  
                                                             @Paid)";

                cmdRepair.Parameters.AddWithValue("@RepairID", repair.RepairID);
                cmdRepair.Parameters.AddWithValue("@MaintenanceID", repair.MaintenanceID);
                cmdRepair.Parameters.AddWithValue("@SupplierID", repair.SupplierID);
                cmdRepair.Parameters.AddWithValue("@RepairDate", repair.RepairDate);
                cmdRepair.Parameters.AddWithValue("@TypeOfRepair", repair.TypeOfRepair);
                cmdRepair.Parameters.AddWithValue("@InvoiceNumber", repair.InvoiceNumber);
                cmdRepair.Parameters.AddWithValue("@Amount", repair.Amount);
                cmdRepair.Parameters.AddWithValue("@Paid", repair.Paid);

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

                while(reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    SupplierID = (int)reader.GetValue(2);
                    RepairDate = (DateTime)reader.GetValue(3);
                    TypeOfRepair = (string)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Repair(RepairID,
                                      MaintenanceID,
                                      SupplierID,
                                      RepairDate,
                                      TypeOfRepair,
                                      InvoiceNumber,
                                      Amount,
                                      Paid);
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

                while(reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    SupplierID = (int)reader.GetValue(2);
                    RepairDate = (DateTime)reader.GetValue(3);
                    TypeOfRepair = (string)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Repair(RepairID,
                                      MaintenanceID,
                                      SupplierID,
                                      RepairDate,
                                      TypeOfRepair,
                                      InvoiceNumber,
                                      Amount,
                                      Paid);

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

        public List<Repair> RetrieveRepairList(string repairID)
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

                while(reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    MaintenanceID = (int)reader.GetValue(1);
                    SupplierID = (int)reader.GetValue(2);
                    RepairDate = (DateTime)reader.GetValue(3);
                    TypeOfRepair = (string)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Paid = (bool)reader.GetValue(7);

                    temp = new Repair(RepairID,
                                      MaintenanceID,
                                      SupplierID,
                                      RepairDate,
                                      TypeOfRepair,
                                      InvoiceNumber,
                                      Amount,
                                      Paid);

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

        public void UpdateRepairInfo(Repair repair)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Repair SET RepairID = @RepairID,  
                                                      MaintenanceID = @MaintenanceID,
                                                      SupplierID = @SupplierID,  
                                                      PlateNumber = @PlateNumber, 
                                                      RepairDate = @RepairDate, 
                                                      TypeOfRepair = @TypeOfRepair, 
                                                      InvoiceNumber = @InvoiceNumber, 
                                                      Amount = @Amount,  
                                                      DueDate = @DueDate " + "WHERE RepairID = @RepairID";

                cmd.Parameters.AddWithValue("@RepairID", repair.RepairID);
                cmd.Parameters.AddWithValue("@MaintenanceID", repair.MaintenanceID);
                cmd.Parameters.AddWithValue("@SupplierID", repair.SupplierID);
                cmd.Parameters.AddWithValue("@RepairDate", repair.RepairDate);
                cmd.Parameters.AddWithValue("@TypeOfRepair", repair.TypeOfRepair);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repair.InvoiceNumber);
                cmd.Parameters.AddWithValue("@Amount", repair.Amount);
                cmd.Parameters.AddWithValue("@Paid", repair.Paid);

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
