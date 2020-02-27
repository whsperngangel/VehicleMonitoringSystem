using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Supplier
    {
        #region Variable
        public int SupplierID;
        public string SupplierName;

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructor
        public Supplier() { }
        public Supplier(int supplierID,
                        string supplierName)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
        }
        #endregion

        #region Supplier Method
        public void InsertSupplier(Supplier supplier)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Supplier(SupplierID, SupplierName) 
                                VALUES(@SupplierID, @SupplierName)";

                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Supplier Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Supplier RetrieveSupplierInfo(int supplierID)
        {
            Supplier temp = new Supplier();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Supplier " + "WHERE SupplierID = @SupplierID";
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    SupplierName = (string)reader.GetValue(1);

                    temp = new Supplier(SupplierID, SupplierName);
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

        public List<Supplier> RetrieveSupplierList()
        {
            List<Supplier> supplierList = new List<Supplier>();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM supplier";
                MySqlDataReader reader = cmd.ExecuteReader();
                Supplier temp = new Supplier();

                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    SupplierName = (string)reader.GetValue(1);

                    temp = new Supplier(SupplierID, SupplierName);
                    supplierList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return supplierList;
        }

        public int RetrieveSupplierID(string supplierName)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Supplier " + "WHERE SupplierName = @SupplierName";
                cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                MySqlDataReader reader = cmd.ExecuteReader();
                Supplier temp = new Supplier();

                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    SupplierName = (string)reader.GetValue(1);

                    temp = new Supplier(SupplierID, SupplierName);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return SupplierID;
        }
        public void UpdateSupplierInfo(Supplier supplier)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Supplier SET SupplierID = @SupplierID,SupplierName = @SupplierName" + " WHERE SupplierID = @SupplierID";
                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Supplier Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int CreateSupplierID()
        {
            SupplierID = CountSupplier();

            return SupplierID;
        }

        public int CountSupplier()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Supplier";

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
