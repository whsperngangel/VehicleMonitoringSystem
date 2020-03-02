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
        public int PaymentID, StatementID;

        public string DatePaid,
                      AmountPaid,
                      PaidBy;

        DBOperation _dbOp = new DBOperation();
        #endregion


        #region Constructors
        public Payment(){ }
        //public Payment(int id, string inv, int sid) 
        //{
        //    ID = id;
        //    InvoiceNumber = inv;
        //    SupplierID = sid;
        //}
        //public Payment(string invoice)
        //{
        //    InvoiceNumber = invoice;
        //}
        //public Payment(int id)
        //{
        //    SupplierID = id;
        //}

        public Payment (int paymentID,
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
        public void InsertPayment(Payment Payment)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Payment(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy)
                                                  VALUE(@PaymentID, @StatementID, @InvoiceNumber, @DatePaid, @AmountPaid, @PaidBy)";

                cmd.Parameters.AddWithValue("@PaymentID", Payment.PaymentID);
                cmd.Parameters.AddWithValue("@StatementID", Payment.StatementID);
                cmd.Parameters.AddWithValue("@DatePaid", Payment.DatePaid);
                cmd.Parameters.AddWithValue("@AmountPaid", Payment.AmountPaid);
                cmd.Parameters.AddWithValue("@PaidBy", Payment.PaidBy);

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
                    StatementID = (int)reader.GetValue(1);
                    DatePaid = (string)reader.GetValue(2);
                    AmountPaid = (string)reader.GetValue(3);
                    PaidBy = (string)reader.GetValue(4);

                    temp = new Payment(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy);
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
        //public List<Payment> RetrievePaymentSupplierList()
        //{
        //    List<Payment> paymentSuppliers = new List<Payment>();
        //    try
        //    {
        //        _dbOp.DBConnect();
        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
        //        cmd.CommandText = "SELECT FuelID, SupplierID, InvoiceNumber FROM fuel " + "WHERE paid = false " + "UNION SELECT RepairID, SupplierID, InvoiceNumber FROM repair " + "WHERE paid = false " + "UNION SELECT PartID, SupplierID, InvoiceNumber FROM repairdetail " + "WHERE paid = false " + "GROUP BY SupplierID";
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        Payment temp = new Payment();

        //        while (reader.Read())
        //        {
        //            ID = (int)reader.GetValue(0);
        //            SupplierID = (int)reader.GetValue(1);

        //            temp = new Payment(ID, SupplierID, InvoiceNumber);
        //            paymentSuppliers.Add(temp);
        //        }
        //        reader.Close();
        //        _dbOp.DBClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return paymentSuppliers;
        //}
        //public List<Payment> RetrieveAllTypeList(string type)
        //{
        //    List<Payment> typeData = new List<Payment>();
        //    try
        //    {
        //        _dbOp.DBConnect();
        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
        //        if ()
        //        {

        //        }
        //        cmd.CommandText = @"SELECT * FROM @Type";
        //        cmd.Parameters.AddWithValue("@Type", type);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        Payment temp = new Payment();

        //        while (reader.Read())
        //        {
        //            ID = (int)reader.GetValue(0);
        //            InvoiceNumber = (string)reader.GetValue(4);
        //            SupplierID = (int)reader.GetValue(5);

        //            temp = new Payment(PaymentID, InvoiceNumber, SupplierID);
        //            typeData.Add(temp);
        //        }
        //        reader.Close();
        //        _dbOp.DBClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return typeData;
        //}
        //public Payment RetrievePaymentUpdateStatus(int supplierID, string invoiceNumber)
        //{
        //    Payment temp = new Payment();
        //    try
        //    {
        //        _dbOp.DBConnect();
        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
        //        cmd.CommandText = @"SELECT FuelID FROM fuel " + "WHERE SupplierID = @SupplierID AND InvoiceNumber = @InvoiceNumber";
        //        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
        //        cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            ID = (int)reader.GetValue(0);
        //            Type = "fuel";

        //            temp = new Payment(ID, Type);
        //        }
        //        else
        //        {
        //            cmd.CommandText = @"SELECT RepairID FROM repair " + "WHERE SupplierID = @SID AND InvoiceNumber = @INV";
        //            cmd.Parameters.AddWithValue("@SID", supplierID);
        //            cmd.Parameters.AddWithValue("@INV", invoiceNumber);
        //        }
        //        if (reader.Read())
        //        {
        //            ID = (int)reader.GetValue(0);
        //            Type = "repair";

        //            temp = new Payment(ID, Type);
        //        }
        //        else 
        //        { 
        //            cmd.CommandText = @"SELECT RepairID FROM repairdetail " + "WHERE SupplierID = @SUP AND InvoiceNumber = @INUM";
        //            cmd.Parameters.AddWithValue("@SUP", supplierID);
        //            cmd.Parameters.AddWithValue("@INUM", invoiceNumber);

        //            if (reader.Read())
        //            {
        //                ID = (int)reader.GetValue(0);
        //                Type = "repairdetail";

        //                temp = new Payment(ID, Type);
        //            }
        //        }
        //        reader.Close();
        //        _dbOp.DBClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return temp;
        //}
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
                    StatementID = (int)reader.GetValue(1);
                    DatePaid = (string)reader.GetValue(2);
                    AmountPaid = (string)reader.GetValue(3);
                    PaidBy = (string)reader.GetValue(4);

                    temp = new Payment(PaymentID, StatementID, DatePaid, AmountPaid, PaidBy);
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
        //public List<Payment> RetireveSupplierIDList(string type)
        //{
        //    List<Payment> supplierIDList = new List<Payment>();
        //    try
        //    {
        //        _dbOp.DBConnect();

        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

        //        cmd.CommandText = @"SELECT SupplierID FROM @Type GROUP BY SupplierID";
        //        cmd.Parameters.AddWithValue("@Type", type);


        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        Payment temp = new Payment();

        //        while (reader.Read())
        //        {
        //            SupplierID = (int)reader.GetValue(0);

        //            temp = new Payment(SupplierID);
        //            supplierIDList.Add(temp);
        //        }
        //        reader.Close();

        //        _dbOp.DBClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return supplierIDList;
        //}
        //public List<Payment> RetrievePaymentInvoiceNumber(int supplierID)
        //{
        //    List<Payment> paymentList = new List<Payment>();
        //    try
        //    {
        //        _dbOp.DBConnect();

        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

        //        cmd.CommandText = "SELECT InvoiceNumber FROM fuel " + "WHERE paid = false " + "UNION SELECT InvoiceNumber FROM repair " + "WHERE paid = false " + "UNION SELECT InvoiceNumber FROM repairdetail " + "WHERE paid = false AND SupplierID = @SupplierID ";
        //        cmd.Parameters.AddWithValue("@SupplierID", supplierID);

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        Payment temp = new Payment();

        //        while (reader.Read())
        //        {
        //           InvoiceNumber = (string)reader.GetValue(0);

        //            temp = new Payment(InvoiceNumber);
        //            paymentList.Add(temp);
        //        }
        //        reader.Close();

        //        _dbOp.DBClose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return paymentList;
        //}
        public void UpdatePaymentInfo(Payment Payment)
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

                cmd.Parameters.AddWithValue("@PaymentID", Payment.PaymentID);
                cmd.Parameters.AddWithValue("@StatementID", Payment.StatementID);
                cmd.Parameters.AddWithValue("@DatePaid", Payment.DatePaid);
                cmd.Parameters.AddWithValue("@AmountPaid", Payment.AmountPaid);
                cmd.Parameters.AddWithValue("@PaidBy", Payment.PaidBy);

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
