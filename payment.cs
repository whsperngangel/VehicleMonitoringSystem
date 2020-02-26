using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem.Payment
{
    class Payments
    {
        #region Variables
        public int PaymentID,
                   StatementID;
        public string DatePaid,
                      AmountPaid,
                      PaidBy;

        DBOperation _dbOp = new DBOperation();
        #endregion


        #region Constructors
        public Payments() { }

        public Payments (int paymentID,
                         int statementID,
                         string datePaid,
                         string amountPaid,
                         string paidBy)
        {
            PaymentID = paymentID;
            StatementID = statementID;
            DatePaid = datePaid;
            AmountPaid = amountPaid;
            PaidBy = paidBy;
        }
        #endregion


        #region Payment Methods
        public void InsertPayment(Payments payments)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Payment(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy)
                                                  VALUE(@PaymentID, @StatementID, @DatePaid, @AmountPaid, @PaidBy)";

                cmd.Parameters.AddWithValue("@PaymentID", payments.PaymentID);
                cmd.Parameters.AddWithValue("@StatementID", payments.StatementID);
                cmd.Parameters.AddWithValue("@DatePaid", payments.DatePaid);
                cmd.Parameters.AddWithValue("@AmountPaid", payments.AmountPaid);
                cmd.Parameters.AddWithValue("@PaidBy", payments.PaidBy);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Payment Record has been saved!");
                _dbOp.DBClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Payments RetrievePaymentInfo(int paymentID)
        {
            Payments temp = new Payments();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Payment " + "WHERE PaymentID = @PaymentID";
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PaymentID = (int)reader.GetValue(0);
                    StatementID = (int)reader.GetValue(1);
                    DatePaid = (string)reader.GetValue(2);
                    AmountPaid = (string)reader.GetValue(3);
                    PaidBy = (string)reader.GetValue(4);

                    temp = new Payments(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy);
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

        public List<Payments> RetrievePaymentList()
        {
            List<Payments> paymentList = new List<Payments>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Payment";
                MySqlDataReader reader = cmd.ExecuteReader();
                Payments temp = new Payments();

                while (reader.Read())
                {
                    PaymentID = (int)reader.GetValue(0);
                    StatementID = (int)reader.GetValue(1);
                    DatePaid = (string)reader.GetValue(2);
                    AmountPaid = (string)reader.GetValue(3);
                    PaidBy = (string)reader.GetValue(4);

                    temp = new Payments(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy);
                    paymentList.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return paymentList;
        }

        public void UpdatePaymentInfo(Payments payments)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Payment SET PaymentID = @PaymentID,  
                                                       StatementID = @StatementID,
                                                       DatePaid = @DatePaid, 
                                                       AmountPaid = @AmountPaid
                                                       PaidBy = @PaidBy";

                cmd.Parameters.AddWithValue("@PaymentID", payments.PaymentID);
                cmd.Parameters.AddWithValue("@StatementID", payments.StatementID);
                cmd.Parameters.AddWithValue("@DatePaid", payments.DatePaid);
                cmd.Parameters.AddWithValue("@AmountPaid", payments.AmountPaid);
                cmd.Parameters.AddWithValue("@PaidBy", payments.PaidBy);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Record has been updated!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int CreatePayment()
        {
            PaymentID = CountPayment();

            return PaymentID;
        }

        public int CountPayment()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Payment";

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
