using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Insurance
    {
        #region Variable
        public int      InsuranceID;

        public string   PlateNumber,
                        Company;

        public DateTime DurationFrom, 
                        DurationTo,
                        Renewal;

        public double   Amount;

        List<Insurance> _insurance = new List<Insurance>();

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public Insurance() { }

        public Insurance(int insuranceID,
                         string plateNumber, 
                         string company,
                         DateTime durationFrom,
                         DateTime durationTo, 
                         DateTime renewal, 
                         double amount)
        {
            InsuranceID = insuranceID;
            PlateNumber = plateNumber;
            Company = company;
            DurationFrom = durationFrom;
            DurationTo = durationTo;
            Renewal = renewal;
            Amount = amount;
        }
        #endregion

        #region Insurance Methods
        public void InsertInsurance(Insurance insurance)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Insurance(InsuranceID,PlateNumber,Company,DurationFrom,DurationTo,Renewal,Amount) 
                                                   VALUES(@InsuranceID,@PlateNumber,@Company,@DurationFrom,@DurationTo,@Renewal,@Amount)";

                cmd.Parameters.AddWithValue("@InsuranceID", insurance.InsuranceID);
                cmd.Parameters.AddWithValue("@PlateNumber", insurance.PlateNumber);
                cmd.Parameters.AddWithValue("@Company", insurance.Company);
                cmd.Parameters.AddWithValue("@DurationFrom", insurance.DurationFrom);
                cmd.Parameters.AddWithValue("@DurationTo", insurance.DurationTo);
                cmd.Parameters.AddWithValue("@Renewal", insurance.Renewal);
                cmd.Parameters.AddWithValue("@Amount", insurance.Amount);


                cmd.ExecuteNonQuery();
                MessageBox.Show("New Insurance Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Insurance RetrieveInsuranceInfo(string plateNumber)
        {
            Insurance temp = new Insurance();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT InsuranceID, PlateNumber, Company, DurationFrom, DurationTo,Renewal,insurance.Amount FROM insurance " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);

                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    InsuranceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    Company = (string)reader.GetValue(2);
                    DurationFrom = (DateTime)reader.GetValue(3);
                    DurationTo = (DateTime)reader.GetValue(4);
                    Renewal = (DateTime)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Insurance(InsuranceID,PlateNumber,Company,DurationFrom,DurationTo,Renewal,Amount);
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

        public List<Insurance> RetrieveInsuranceList()
        {
            List<Insurance> insuranceList = new List<Insurance>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Insurance ";

                MySqlDataReader reader = cmd.ExecuteReader();
                Insurance temp = new Insurance();

                while(reader.Read())
                {
                    InsuranceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    Company = (string)reader.GetValue(2);
                    DurationFrom = (DateTime)reader.GetValue(3);
                    DurationTo = (DateTime)reader.GetValue(4);
                    Renewal = (DateTime)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Insurance(InsuranceID,PlateNumber,Company,DurationFrom,DurationTo,Renewal,Amount);
                    insuranceList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return insuranceList;
        }

        public List<Insurance> RetrieveInsuranceList(string plateNumber)
        {
            List<Insurance> insuranceList = new List<Insurance>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Insurance " + "WHERE PlateNumber = @PlateNumber";
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);

                MySqlDataReader reader = cmd.ExecuteReader();
                Insurance temp = new Insurance();

                while(reader.Read())
                {
                    InsuranceID = (int)reader.GetValue(0);
                    PlateNumber = (string)reader.GetValue(1);
                    Company = (string)reader.GetValue(2);
                    DurationFrom = (DateTime)reader.GetValue(3);
                    DurationTo = (DateTime)reader.GetValue(4);
                    Renewal = (DateTime)reader.GetValue(5);
                    Amount = (double)reader.GetValue(6);

                    temp = new Insurance(InsuranceID, PlateNumber, Company, DurationFrom, DurationTo, Renewal, Amount);
                    insuranceList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return insuranceList;
        }

        public void UpdateInsuranceInfo(Insurance insurance)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Insurance SET InsuranceID = @InsuranceID, PlateNumber = @PlateNumber, Company = @Company,DurationFrom = @DurationFrom,DurationTo = @DurationTo,Renewal = @Renewal,Amount = @Amount " + "WHERE InsuranceID = @InsuranceID";

                cmd.Parameters.AddWithValue("@InsuranceID", insurance.InsuranceID);
                cmd.Parameters.AddWithValue("@PlateNumber", insurance.PlateNumber);
                cmd.Parameters.AddWithValue("@Company", insurance.Company);
                cmd.Parameters.AddWithValue("@DurationFrom", insurance.DurationFrom);
                cmd.Parameters.AddWithValue("@DurationTo", insurance.DurationTo);
                cmd.Parameters.AddWithValue("@Renewal", insurance.Renewal);
                cmd.Parameters.AddWithValue("@Amount", insurance.Amount);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Insurance Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int CreateInsurance()
        {
            InsuranceID = CountInsurance();

            return InsuranceID;
        }

        public int CountInsurance()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM insurance";

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
