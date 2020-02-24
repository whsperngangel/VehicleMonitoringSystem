using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Registration
    {
        #region Variable
        public int RegistrationID;
        public string PlateNumber,
                      RegisteredName,
                      ORNumber,
                      Remarks;
        public DateTime Renewal,
                        ORDate;
        public double Amount;
        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Registration() { }

        public Registration(int registrationID,
                            string plateNumber, 
                            string registeredName, 
                            string orNumber, 
                            DateTime orDate, 
                            DateTime renewal, 
                            double amount, 
                            string remarks)
        {
            RegistrationID = registrationID;
            PlateNumber = plateNumber;
            RegisteredName = registeredName;
            ORNumber = orNumber;
            ORDate = orDate;
            Renewal = renewal;
            Amount = amount;
            Remarks = remarks;
        }
        #endregion

        #region Registration Methods
        public void InsertRegistration(Registration registration)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Registration(RegistrationID, PlateNumber, RegisteredName, ORNumber, ORDate, Renewal, Amount, Remarks)
                                                      VALUES(@RegistrationID, @PlateNumber, @RegisteredName, @ORNumber, @ORDate, @Renewal, @Amount, @Remarks)";

                cmd.Parameters.AddWithValue("@RegistrationID", registration.RegistrationID);
                cmd.Parameters.AddWithValue("@PlateNumber", registration.PlateNumber);
                cmd.Parameters.AddWithValue("@RegisteredName", registration.RegisteredName);
                cmd.Parameters.AddWithValue("@ORNumber", registration.ORNumber);
                cmd.Parameters.AddWithValue("@ORDate", registration.ORDate);
                cmd.Parameters.AddWithValue("@Renewal", registration.Renewal);
                cmd.Parameters.AddWithValue("@Amount", registration.Amount);
                cmd.Parameters.AddWithValue("@Remarks", registration.Remarks);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Vehicle Registration has been saved.");
                _dbOp.DBClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Registration RetrieveRegistrationInfo(string plateNumber)
        {
            Registration temp = new Registration();
            try 
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Registration " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    RegistrationID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    RegisteredName = (string)reader.GetValue(2);
                    ORNumber = (string)reader.GetValue(3);                    
                    ORDate = (DateTime)reader.GetValue(4);
                    Renewal = (DateTime)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Remarks = (string)reader.GetValue(7);

                    temp = new Registration(RegistrationID, plateNumber,RegisteredName,ORNumber,ORDate,Renewal,Amount,Remarks);
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

        public List<Registration> RetrieveRegistrationList(string plateNumber)
        {
            List<Registration> registrationList = new List<Registration>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Registration " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                MySqlDataReader reader = cmd.ExecuteReader();
                Registration temp = new Registration();

                while(reader.Read())
                {
                    RegistrationID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    RegisteredName = (string)reader.GetValue(2);
                    ORNumber = (string)reader.GetValue(3);
                    ORDate = (DateTime)reader.GetValue(4);
                    Renewal = (DateTime)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);
                    Remarks = (string)reader.GetValue(7);

                    temp = new Registration(RegistrationID,PlateNumber,RegisteredName,ORNumber,ORDate,Renewal,Amount,Remarks);
                    
                    registrationList.Add(temp);
                    
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return registrationList;
            
        }

        public void UpdateRegistrationInfo(Registration registration)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Registration SET RegistrationID = @RegistrationID, 
                                                            PlateNumber = @PlateNumber, 
                                                            RegisteredName = @RegisteredName, 
                                                            ORNumber = @ORNumber, 
                                                            ORDate = @ORDate, 
                                                            Renewal = @Renewal, 
                                                            Amount = @Amount, 
                                                            Remarks = @Remarks " + "WHERE RegistrationID = @RegistrationID";

                cmd.Parameters.AddWithValue("@RegistrationID", registration.RegistrationID);
                cmd.Parameters.AddWithValue("@PlateNumber", registration.PlateNumber);
                cmd.Parameters.AddWithValue("@RegisteredName", registration.RegisteredName);
                cmd.Parameters.AddWithValue("@ORNumber", registration.ORNumber);
                cmd.Parameters.AddWithValue("@ORDate", registration.ORDate);
                cmd.Parameters.AddWithValue("@Renewal", registration.Renewal);
                cmd.Parameters.AddWithValue("@Amount", registration.Amount);
                cmd.Parameters.AddWithValue("@Remarks", registration.Remarks);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Vehicle Registration has been saved.");
                _dbOp.DBClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
