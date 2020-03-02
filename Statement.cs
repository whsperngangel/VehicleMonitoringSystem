
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

        public int SupplierID, ID, StatementID;
        public string InvoiceNumber, Type, Status;
        public Double AmountDue,
                      TotalDue;
        public DateTime DateDue;

        DBOperation _dbOp = new DBOperation();

        #endregion

        #region Constructors

        public Statement() { }

        public Statement(int statementID, int supplierID, String type, string invoiceNumber , string status)
        {
            StatementID = statementID;
            SupplierID = supplierID;
            Type = type;
            InvoiceNumber = invoiceNumber;
            Status = status;
           
        }
        #endregion

        #region Statement Methods
        public void InsertStatement(Statement statement)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmdRepair = _dbOp._dbConn.CreateCommand();

                cmdRepair.CommandText = @"INSERT INTO Statement(StatementID, SupplierID, Type, InvoiceNumber, Status) VALUES(@StatementID, @SupplierID, @Type, @InvoiceNumber,@Status)";

                cmdRepair.Parameters.AddWithValue("@StatementID", statement.StatementID);
                cmdRepair.Parameters.AddWithValue("@StatementID", statement.SupplierID);
                cmdRepair.Parameters.AddWithValue("@Type", statement.Type);
                cmdRepair.Parameters.AddWithValue("@InvoiceNumber", statement.InvoiceNumber);
                cmdRepair.Parameters.AddWithValue("@Status", statement.Status);

                cmdRepair.ExecuteNonQuery();

                MessageBox.Show("New Repair Record has been saved!");
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public List<Statement> RetrieveStatementList(string conditionString1)
        {
            List<Statement> statements = new List<Statement>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * Statement " + conditionString1;

                MySqlDataReader reader = cmd.ExecuteReader();
                Statement temp = new Statement();
                while (reader.Read())
                {
                    StatementID = (int)reader.GetValue(0);
                    SupplierID = (int)reader.GetValue(1);
                    Type = (string)reader.GetValue(2);
                    InvoiceNumber = (string)reader.GetValue(3);
                    Status = (string)reader.GetValue(4);
                    temp = new Statement(SupplierID, SupplierID, Type, InvoiceNumber, Status);
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
        /*public List<Statement> RetrieveRepairStatement(string conditionString1)
        {
            List<Statement> statements = new List<Statement>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT supplier.SupplierID, repair.RepairID, repair.InvoiceNumber, repair.Amount From Supplier INNER JOIN repair on supplier.SupplierID = repair.SupplierID " + conditionString1;

                MySqlDataReader reader = cmd.ExecuteReader();
                Statement temp = new Statement();
                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    ID = (int)reader.GetValue(1);
                    InvoiceNumber = (string)reader.GetValue(2);
                    AmountDue = (Double)reader.GetValue(3);
                    Type = "Repair";
                    temp = new Statement(StatementID, SupplierID, Type, InvoiceNumber, Status);
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
        public List<Statement> RetrieveRepairDetailStatement(string conditionString1)
        {
            List<Statement> statements = new List<Statement>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT supplier.SupplierID, repairdetail.PartID, repairdetail.InvoiceNumber, repairdetail.Amount FROM supplier INNER JOIN repairdetail ON supplier.SupplierID = repairdetail.SupplierID " //+ "WHERE Paid = false "// + conditionString1;

                MySqlDataReader reader = cmd.ExecuteReader();
                Statement temp = new Statement();
                while (reader.Read())
                {
                    SupplierID = (int)reader.GetValue(0);
                    ID = (int)reader.GetValue(1);
                    InvoiceNumber = (string)reader.GetValue(2);
                    AmountDue = (Double)reader.GetValue(3);
                    Type = "Part";
                    temp = new Statement(SupplierID, ID, InvoiceNumber, Type, AmountDue);
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
        } */
        public int CreateStatementID()
        {
            StatementID = CountStatement();

            return StatementID;
        }

        public int CountStatement()
        {
            int count = 1;

            _dbOp.DBConnect();

            MySqlCommand cmd = _dbOp._dbConn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM Statement";

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
