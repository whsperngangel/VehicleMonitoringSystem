using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class Statement
    {
        #region Variables
        public int StatementID,
                   SupplierID,
                   PaymentID;

        DBOperation _dbOp = new DBOperation();

        #endregion

        #region Constructors

        public Statement() { }

        public Statement(int statementID,
                         int supplierID, 
                         int paymentID)
        {
            StatementID = statementID;
            SupplierID = supplierID;
            PaymentID = paymentID;
        }

        #endregion

        #region Statement Methods

        public List<Statement> RetrieveStatementList()
        {
            List<Statement> statements = new List<Statement>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Statement";

                MySqlDataReader reader = cmd.ExecuteReader();

                Statement temp = new Statement();

                while (reader.Read())
                {
                    StatementID = (int)reader.GetValue(0);
                    SupplierID = (int)reader.GetValue(1);
                    PaymentID = (int)reader.GetValue(2);

                    temp = new Statement(StatementID, SupplierID, PaymentID);
                    statements.Add(temp);
                }
                reader.Close();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return statements;
        }

        public Statement RetrieveStatementInfo(int statementID)
        {
            Statement temp = new Statement();

            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Statement " + "WHERE StatementID = @StatementID";
                cmd.Parameters.AddWithValue("@StatementID", statementID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    StatementID = (int)reader.GetValue(0);
                    SupplierID = (int)reader.GetValue(1);
                    PaymentID = (int)reader.GetValue(2);

                    temp = new Statement(StatementID, SupplierID, PaymentID);
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





        //public Statement GetTotal()
        //{
        //    Statement temp = new Statement(int statementID);

        //    try
        //    {
        //        _dbOp.DBConnect();

        //        MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

        //        cmd.CommandText = @"SELECT(SELECT(SUM(Amount)) FROM fuel) + (SELECT(SUM(Amount)) FROM repair) FROM DUAL";
        //        cmd.Parameters.AddWithValue("@StatementID", statementID);

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            SupplierID = (int)reader.GetValue(0);
        //            InvoiceNumber = (string)reader.GetValue(1);
        //            FuelAmountDue = (Double)reader.GetValue(0);
        //            RepairAmountDue = (Double)reader.GetValue(1);
        //            DateDue = (DateTime)reader.GetValue(4);

        //            temp = new Statement(SupplierID, InvoiceNumber, FuelAmountDue, RepairAmountDue/*, DateDue*/);
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

        #endregion
    }
}
