using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Payment
    {
        #region Variables
        public int PaymentID,
                   SupplierID;

        public string InvoiceNumber,
                      DatePaid,
                      AmountPaid,
                      PaidBy;

        DBOperation _dbOp = new DBOperation();
        #endregion


        #region Constructors
        public Payment() { }

        public Payment (int paymentID,
                         int supplierID,
                         string InvoiceNumber,
                         string datePaid,
                         string amountPaid,
                         string paidBy)
        {
            PaymentID = paymentID;
            SupplierID = supplierID;
            DatePaid = datePaid;
            AmountPaid = amountPaid;
            PaidBy = paidBy;
        }
        #endregion


        #region Payment Methods
        public void InsertPayment(Payment payments)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Payment(PaymentID, SupplierID, InvoiceNumber, DatePaid, AmountPaid, PaidBy)
                                                  VALUE(@PaymentID, @StatementID, @InvoiceNumber, @DatePaid, @AmountPaid, @PaidBy)";

                cmd.Parameters.AddWithValue("@PaymentID", payments.PaymentID);
                cmd.Parameters.AddWithValue("@SupplierID", payments.SupplierID);
                cmd.Parameters.AddWithValue("@InvoiceNumber", payments.InvoiceNumber);
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

        public Payment RetrievePaymentInfo(int paymentID)
        {
            Payment temp = new Payment();

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
                    SupplierID = (int)reader.GetValue(1);
                    InvoiceNumber = (string)reader.GetValue(2);
                    DatePaid = (string)reader.GetValue(3);
                    AmountPaid = (string)reader.GetValue(4);
                    PaidBy = (string)reader.GetValue(5);

                    temp = new Payment(PaymentID, SupplierID, InvoiceNumber, DatePaid, AmountPaid, PaidBy);
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

        public List<Payment> RetrievePaymentList()
        {
            List<Payment> paymentList = new List<Payment>();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Payment";
                MySqlDataReader reader = cmd.ExecuteReader();
                Payment temp = new Payment();

                while (reader.Read())
                {
                    PaymentID = (int)reader.GetValue(0);
                    SupplierID = (int)reader.GetValue(1);
                    InvoiceNumber = (string)reader.GetValue(2);
                    DatePaid = (string)reader.GetValue(3);
                    AmountPaid = (string)reader.GetValue(4);
                    PaidBy = (string)reader.GetValue(5);

                    temp = new Payment(PaymentID, SupplierID, InvoiceNumber, DatePaid, AmountPaid, PaidBy);
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

        public void UpdatePaymentInfo(Payment payments)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE Payment SET PaymentID = @PaymentID,  
                                                       SupplierID = @SupplierID,
                                                       DatePaid = @DatePaid, 
                                                       AmountPaid = @AmountPaid
                                                       PaidBy = @PaidBy";

                cmd.Parameters.AddWithValue("@PaymentID", payments.PaymentID);
                cmd.Parameters.AddWithValue("@SupplierID", payments.SupplierID);
                cmd.Parameters.AddWithValue("@InvoiceNumber", payments.InvoiceNumber);
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
