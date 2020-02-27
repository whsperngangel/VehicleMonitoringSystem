using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Vehicle
    {
        #region Variables
        public string PlateNumber,
                      Listing,
                      Brand,
                      Category,
                      CRNumber,
                      IssuedTo;
        public DateTime CRDate;
        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Vehicle() { }
        
        public Vehicle(string plateNumber, string listing, string brand, string category, string cRNumber, DateTime cRDate, string issuedTo)
        {
            PlateNumber = plateNumber;
            Listing = listing;
            Brand = brand;
            Category = category;
            CRNumber = cRNumber;
            CRDate = cRDate;
            IssuedTo = issuedTo;
        }
        #endregion

        #region Vehicle Methods
        public void InsertVehicle(Vehicle vehicle)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Vehicle(PlateNumber, Listing, Brand, Category, CRNumber, CRDate, IssuedTo)
                                    VALUES(@PlateNumber, @Listing, @Brand, @Category, @CRNumber, @CRDate, @IssuedTo)";
        
                cmd.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                cmd.Parameters.AddWithValue("@Listing", vehicle.Listing);
                cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
                cmd.Parameters.AddWithValue("@Category", vehicle.Category);
                cmd.Parameters.AddWithValue("@CRNumber", vehicle.CRNumber);
                cmd.Parameters.AddWithValue("@CRDate", vehicle.CRDate);
                cmd.Parameters.AddWithValue("@IssuedTo", vehicle.IssuedTo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New vehicle information has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Vehicle RetrieveVehicleInfo(string plateNumber)
        {
            Vehicle temp = new Vehicle();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Vehicle " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

               while(reader.Read())
                {
                    PlateNumber = (string)reader.GetValue(0);
                    Listing = (string)reader.GetValue(1);
                    Brand = (string)reader.GetValue(2);
                    Category = (string)reader.GetValue(3);
                    CRNumber = (string)reader.GetValue(4);
                    CRDate = (DateTime)reader.GetValue(5);
                    IssuedTo = (string)reader.GetValue(6);

                    temp = new Vehicle(PlateNumber, Listing, Brand, Category, CRNumber, CRDate, IssuedTo);
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

        public List<Vehicle> RetrieveVehicleList()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Vehicle";
                MySqlDataReader reader = cmd.ExecuteReader();
                Vehicle temp = new Vehicle();

                while(reader.Read())
                {
                    PlateNumber = (string)reader.GetValue(0);
                    Listing = (string)reader.GetValue(1);
                    Brand = (string)reader.GetValue(2);
                    Category = (string)reader.GetValue(3);
                    CRNumber = (string)reader.GetValue(4);
                    CRDate = (DateTime)reader.GetValue(5);
                    IssuedTo = (string)reader.GetValue(6);

                    temp = new Vehicle(PlateNumber, Listing, Brand, Category, CRNumber, CRDate, IssuedTo);
                    vehicleList.Add(temp);
                }

                reader.Close();

                _dbOp.DBClose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return vehicleList;
        }

        public void UpdateVehicleInfo(Vehicle vehicle)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Vehicle SET PlateNumber = @PlateNumber,Listing = @Listing,Brand = @Brand,Category = @Category,CRNumber = @CRNumber,CRDate = @CRDate,IssuedTo = @IssuedTo " + "WHERE PlateNumber = @PlateNumber";

                cmd.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                cmd.Parameters.AddWithValue("@Listing", vehicle.Listing);
                cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
                cmd.Parameters.AddWithValue("@Category", vehicle.Category);
                cmd.Parameters.AddWithValue("@CRNumber", vehicle.CRNumber);
                cmd.Parameters.AddWithValue("@CRDate", vehicle.CRDate);
                cmd.Parameters.AddWithValue("@IssuedTo", vehicle.IssuedTo);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Vehicle information successfully updated!");

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion
    }

}
