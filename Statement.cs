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

        public int SupplierID;
        public string InvoiceNumber;
        public Double FuelAmountDue,
            RepairAmountDue,
            TotalDue;
        public DateTime DateDue;

        DBOperation _dbOp = new DBOperation();

        #endregion

        #region Constructors

        public Statement() { }
        public Statement(int supplierID, 
                         string invoiceNumber, 
                         Double fuelAmountDue, 
                         Double repairAmountDue/*, DateTime dateDue*/)
        {
            SupplierID = supplierID;
            InvoiceNumber = invoiceNumber;
            FuelAmountDue = fuelAmountDue;
            RepairAmountDue = repairAmountDue;
            //DateDue = dateDue;
        }
        //public Statement(Double totalDue)
        //{
        //    TotalDue = totalDue;
        //}
        #endregion

        #region Statement Methods

        public List<Statement> RetrieveStatementList(string conditionString1)
        {
            List<Statement> statements = new List<Statement>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT supplier.SupplierID, repair.InvoiceNumber, fuel.Amount, repair.Amount FROM supplier INNER JOIN repair ON supplier.SupplierID=repair.SupplierID JOIN fuel ON fuel.SupplierID=repair.SupplierID " + conditionString1;

                MySqlDataReader reader = cmd.ExecuteReader();

                Statement temp = new Statement();

                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    InvoiceNumber = (string)reader.GetValue(1);
                    FuelAmountDue = (Double)reader.GetValue(2);
                    RepairAmountDue = (Double)reader.GetValue(3);
                    //DateDue = (DateTime)reader.GetValue(3);

                    temp = new Statement(SupplierID, InvoiceNumber, FuelAmountDue, RepairAmountDue/*, DateDue*/);
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
                    SupplierID = (int)reader.GetValue(0);
                    InvoiceNumber = (string)reader.GetValue(1);
                    FuelAmountDue = (Double)reader.GetValue(2);
                    RepairAmountDue = (Double)reader.GetValue(3);
                    //DateDue = (DateTime)reader.GetValue(4);
               
                    temp = new Statement(SupplierID, InvoiceNumber, FuelAmountDue, RepairAmountDue/*, DateDue*/);
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
