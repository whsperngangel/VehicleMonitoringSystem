using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Maintenance
    {
        #region Variables
        public int MaintenanceID,
                   PartID;
        public string PlateNumber;
        public DateTime Date;

        List<Maintenance> _maintenance = new List<Maintenance>();
        DBOperation _dbOp = new DBOperation();
        #endregion


        #region Constructors
        public Maintenance() { }
        public Maintenance(int maintenanceID,
                            string plateNumber,
                            int partID,
                            DateTime date)
        {
            MaintenanceID = maintenanceID;
            PlateNumber = plateNumber;
            PartID = partID;
            Date = date;
        }
        #endregion


        #region Maintenance Methods
        public void InsertMaintenance(Maintenance maintenance)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Maintenance(MaintenanceID,PlateNumber,PartID,Date) 
                                                     VALUES(@MaintenanceID,@PlateNumber,@PartID,@Date)";

                cmd.Parameters.AddWithValue("@MaintenanceID", maintenance.MaintenanceID);
                cmd.Parameters.AddWithValue("@PlateNumber", maintenance.PlateNumber);
                cmd.Parameters.AddWithValue("@PartID", maintenance.PartID);
                cmd.Parameters.AddWithValue("@Date", maintenance.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show(PlateNumber + " Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Maintenance RetrieveMaintenanceInfo(int maintenanceID)
        {
            Maintenance temp = new Maintenance();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Maintenance " + "WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Date = (DateTime)reader.GetValue(3);

                    temp = new Maintenance(MaintenanceID, PlateNumber, PartID, Date);
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
        public List<Maintenance> RetrieveMaintenanceList()
        {
            List<Maintenance> maintenanceList = new List<Maintenance>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Maintenance";
                MySqlDataReader reader = cmd.ExecuteReader();
                Maintenance temp = new Maintenance();

                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Date = (DateTime)reader.GetValue(3);

                    temp = new Maintenance(MaintenanceID, PlateNumber, PartID, Date);
                    maintenanceList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return maintenanceList;    
        }
        public int RetrieveMaintenanceID(string maintenanceID)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM Maintenance " + "WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Maintenance temp = new Maintenance();

                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Date = (DateTime)reader.GetValue(3);

                    temp = new Maintenance(MaintenanceID, PlateNumber, PartID, Date);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return MaintenanceID;
        }
        public void UpdateMaintenanceInfo(Maintenance maintenance)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Maintenance SET MaintenanceID = @MaintenanceID,
                                                           PlateNumber = @PlateNumber,
                                                           PartID = @PartID,
                                                           Date = @Date" + " WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", maintenance.MaintenanceID);
                cmd.Parameters.AddWithValue("@PlateNumber", maintenance.PlateNumber);
                cmd.Parameters.AddWithValue("@PartID", maintenance.PartID);
                cmd.Parameters.AddWithValue("@Date", maintenance.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show(PlateNumber + "has been updated!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public int CreateMaintenanceID()
        {
            MaintenanceID = CountMaintenance();
            return MaintenanceID;
        }

        public int CountMaintenance()
        {
            int count = 1;
            _dbOp.DBConnect();
            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Maintenance";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
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

