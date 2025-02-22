using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class RepairDetail
    {
        #region Variable
        public int RepairID, PartID, SupplierID;
        public DateTime PurchasedDate;
        public string InvoiceNumber;
        public double Amount;
        public bool Paid;
        
        List<RepairDetail> _repairdetails = new List<RepairDetail>();

        DBOperation _dbOp = new DBOperation();
        #endregion

        #region Constructors
        public RepairDetail() { }

        public RepairDetail(int repairID,
                      int partID,
                      DateTime purchasedDate,
                      double amount,
                      string invoiceNumber,
                      int supplierID)
        {
            RepairID = repairID;
            PartID = partID;
            PurchasedDate = purchasedDate;
            Amount = amount;
            SupplierID = supplierID;
            InvoiceNumber = invoiceNumber;
        }
        #endregion

        #region Repair Methods
        public void InsertRepairDetail(RepairDetail repairDetail)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO RepairDetail(RepairID,PartID,PurchasedDate,Amount,InvoiceNumber,SupplierID)
                            VALUES(@RepairID,@PartID,@PurchasedDate,@Amount,@InvoiceNumber,@SupplierID)";

                cmd.Parameters.AddWithValue("@RepairID", repairDetail.RepairID);
                cmd.Parameters.AddWithValue("@PartID", repairDetail.PartID);
                cmd.Parameters.AddWithValue("@PurchasedDate", repairDetail.PurchasedDate);
                cmd.Parameters.AddWithValue("@Amount", repairDetail.Amount);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repairDetail.InvoiceNumber);
                cmd.Parameters.AddWithValue("@SupplierID", repairDetail.SupplierID);

                cmd.ExecuteNonQuery();
                _dbOp.DBClose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public RepairDetail RetrieveDetailInfo(int repairID)
        {
            RepairDetail temp = new RepairDetail();
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"SELECT * FROM RepairDetail " + "WHERE RepairID = @RepairID";
                cmd.Parameters.AddWithValue("@RepairID", repairID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    PartID = (int)reader.GetValue(1);
                    PurchasedDate = (DateTime)reader.GetValue(2);
                    Amount = (double)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);

                    temp = new RepairDetail(RepairID,PartID,PurchasedDate,Amount,InvoiceNumber, SupplierID);
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
        public List<RepairDetail> RetrieveStatementRepair(int partID, string invoiceNumber)
        {
            List<RepairDetail> repairDetailList = new List<RepairDetail>();
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM RepairDetail " + "WHERE PartID = @PartID AND InvoiceNumber = @InvoiceNumber";
                cmd.Parameters.AddWithValue("@PartID", partID);
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

                RepairDetail temp = new RepairDetail();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    PartID = (int)reader.GetValue(1);
                    PurchasedDate = (DateTime)reader.GetValue(2);
                    Amount = (double)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);

                    temp = new RepairDetail(RepairID, PartID, PurchasedDate, Amount, InvoiceNumber, SupplierID);

                    repairDetailList.Add(temp);

                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairDetailList;
        }
        public List<RepairDetail> RetrieveRepairDetailList()
        {
            List<RepairDetail> repairDetailList = new List<RepairDetail>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM RepairDetail";

                MySqlDataReader reader = cmd.ExecuteReader();

                RepairDetail temp = new RepairDetail();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    PartID = (int)reader.GetValue(1);
                    PurchasedDate = (DateTime)reader.GetValue(2);
                    Amount = (double)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5); 

                    temp = new RepairDetail(RepairID, PartID, PurchasedDate, Amount, InvoiceNumber, SupplierID);

                    repairDetailList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairDetailList;
        }
        public List<RepairDetail> RetrieveRepairDetailList(int repairID)
        {
            List<RepairDetail> repairDetailList = new List<RepairDetail>();

            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM RepairDetail " + "WHERE RepairID = @RepairID";
                cmd.Parameters.AddWithValue("@RepairID", repairID);

                MySqlDataReader reader = cmd.ExecuteReader();

                RepairDetail temp = new RepairDetail();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    PartID = (int)reader.GetValue(1);
                    PurchasedDate = (DateTime)reader.GetValue(2);
                    Amount = (double)reader.GetValue(3);
                    InvoiceNumber = (string)reader.GetValue(4);
                    SupplierID = (int)reader.GetValue(5);

                    temp = new RepairDetail(RepairID, PartID, PurchasedDate, Amount, InvoiceNumber, SupplierID);

                    repairDetailList.Add(temp);
                }
                reader.Close();

                _dbOp.DBClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return repairDetailList;
        }

        public void UpdateRepairDetailInfo(RepairDetail repairDetail)
        {
            try
            {
                _dbOp.DBConnect();

                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"UPDATE RepairDetail SET RepairID = @RepairID, PartID = @PartID,Amount = @Amount,InvoiceNumber = @InvoiceNumber,SupplierID = @SupplierID " + "WHERE RepairID = @RepairID AND PartID = @PartID";

                cmd.Parameters.AddWithValue("@RepairID", repairDetail.RepairID);
                cmd.Parameters.AddWithValue("@PartID", repairDetail.PartID);
                cmd.Parameters.AddWithValue("@Amount", repairDetail.Amount);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repairDetail.InvoiceNumber);
                cmd.Parameters.AddWithValue("@SupplierID", repairDetail.SupplierID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated Repair Detail has been saved!");

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
