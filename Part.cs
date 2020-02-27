using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Part
    {
        #region Variable
        public int PartID;
        public string Description;

        List<Part> _parts = new List<Part>();

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructor
        public Part() { }
        public Part(int partID, string description)
        {
            PartID = partID;
            Description = description;
        }
        #endregion

        #region Part Method
        public void InsertPart(Part part)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Part(PartID,Description) 
                                    VALUES(@PartID,@Description)";

                cmd.Parameters.AddWithValue("@PartID", part.PartID);
                cmd.Parameters.AddWithValue("@Description", part.Description);

                cmd.ExecuteNonQuery();
                MessageBox.Show(Description + " Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Part RetrievePartInfo(int partID)
        {
            Part temp = new Part();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Part " + "WHERE PartID = @PartID";
                cmd.Parameters.AddWithValue("@PartID", partID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PartID = (int)reader.GetValue(0);
                    Description = (string)reader.GetValue(1);

                    temp = new Part(PartID, Description);
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
        public List<Part> RetrievePartList()
        {
            List<Part> partList = new List<Part>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Part";
                MySqlDataReader reader = cmd.ExecuteReader();
                Part temp = new Part();

                while (reader.Read())
                {
                    PartID = (int)reader.GetValue(0);
                    Description = (string)reader.GetValue(1);

                    temp = new Part(PartID,Description);
                    partList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return partList;
        }
        public int RetrievePartID(string description)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM Part " + "WHERE Description = @Description";
                cmd.Parameters.AddWithValue("@Description", description);

                MySqlDataReader reader = cmd.ExecuteReader();

                Part temp = new Part();

                while (reader.Read())
                {
                    PartID = (int)reader.GetValue(0);
                    Description = (string)reader.GetValue(1);

                    temp = new Part(PartID, Description);
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
        public void UpdatePartInfo(Part part)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Part SET PartID = @PartID,Description = @Description" + " WHERE PartID = @PartID";
                cmd.Parameters.AddWithValue("@PartID", part.PartID);
                cmd.Parameters.AddWithValue("@Description", part.Description);

                cmd.ExecuteNonQuery();
                MessageBox.Show(@Description + "has been updated!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public int CreatePartID()
        {
            PartID = CountPart();
            return PartID;
        }

        public int CountPart()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Part";

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
