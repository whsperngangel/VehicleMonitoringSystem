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
        #region Variable
        public int MaintenanceID;
        public string PlateNumber; //removed
        public bool Status = false;
        public int PartID;

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructor
        public Maintenance() { }
        public Maintenance(int maintenanceID, string plateNumber, int partID, bool status) //added
        {
            MaintenanceID = maintenanceID;
            PlateNumber = plateNumber;
            PartID = partID;
            Status = status;
        }
        
        #endregion

        #region Maintenance Method
        //dito
        public void InsertMaintenance(Maintenance maintenance)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Maintenance(MaintenanceID,PlateNumber,PartID,Status) 
                                    VALUES(@MaintenanceID,@PlateNumber,@PartID,@Status)";

                cmd.Parameters.AddWithValue("@MaintenanceID", maintenance.MaintenanceID);
                cmd.Parameters.AddWithValue("@PlateNumber", maintenance.PlateNumber);
                cmd.Parameters.AddWithValue("@PartID", maintenance.PartID);
                cmd.Parameters.AddWithValue("@Status", Status);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Maintence Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Maintenance RetrieveMaintenanceInfo(int maintenanceID)
        {
            Maintenance _maintenance = new Maintenance();
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Maintenance " + "WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", maintenanceID);

                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Status = (bool)reader.GetValue(3);

                    _maintenance = new Maintenance(MaintenanceID, PlateNumber, PartID, Status);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return _maintenance;
        }
        public List<Maintenance> RetrieveMaintenanceList()
        {
            List<Maintenance> _maintenances = new List<Maintenance>();
            
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Maintenance";
                MySqlDataReader reader = cmd.ExecuteReader();
                Maintenance _maintenance = new Maintenance();
                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Status = (bool)reader.GetValue(3);

                    _maintenance = new Maintenance(MaintenanceID, PlateNumber, PartID, Status);
                    _maintenances.Add(_maintenance);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return _maintenances;
        }
        public List<Maintenance> RetrieveMaintenancePart(string plateNumber)
        {
            List<Maintenance> maintenancePartList = new List<Maintenance>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Maintenance " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();
                Maintenance temp = new Maintenance();

                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Status = (bool)reader.GetValue(3);

                    temp = new Maintenance(MaintenanceID, PlateNumber, PartID, Status);
                    maintenancePartList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return maintenancePartList;
        }
        public int RetrieveMaintenanceID(string plateNumber, int partID)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM Maintenance " + "WHERE PlateNumber = @PlateNumber AND PartID = @PartID";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                cmd.Parameters.AddWithValue("@PartID", partID);
                Maintenance _maintenance = new Maintenance();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MaintenanceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    PartID = (int)reader.GetValue(2);
                    Status = (bool)reader.GetValue(3);

                    _maintenance = new Maintenance(MaintenanceID, PlateNumber, PartID, Status);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return PartID;
        }
        public void UpdateMaintenanceStatus(bool status)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Maintenance SET Status = @Status" + " WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UpdateMaintenanceInfo(Maintenance maintenance)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Maintenance SET MaintenanceID = @MaintenanceID,PlateNumber = @PlateNumber, PartID = @PartID" + " WHERE MaintenanceID = @MaintenanceID";
                cmd.Parameters.AddWithValue("@MaintenanceID", maintenance.MaintenanceID);
                cmd.Parameters.AddWithValue("@PlateNumber", maintenance.PlateNumber);
                cmd.Parameters.AddWithValue("@PartID", maintenance.PartID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Maintenance Record has been updated!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public int CreateMaintenanceID()
        {
            PartID = CountMaintenance();
            return PartID;
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
