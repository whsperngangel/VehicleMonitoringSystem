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
        public int RepairID, 
                   PartID,
                   SupplierID;
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
                            int supplierID,
                            DateTime purchasedDate,
                            double amount,
                            string invoiceNumber,
                            bool paid)
        {
            RepairID = repairID;
            PartID = partID;
            SupplierID = supplierID;
            PurchasedDate = purchasedDate;
            Amount = amount;
            InvoiceNumber = invoiceNumber;
            Paid = paid;
        }
        #endregion

        #region Repair Methods
        public void InsertRepairDetail(RepairDetail repairDetail)
        {
            try
            {
                _dbOp.DBConnect();
                MySqlCommand cmd = _dbOp._dbConn.CreateCommand();

                cmd.CommandText = @"INSERT INTO RepairDetail(RepairID,
                                                             PartID,
                                                             SupplierID
                                                             PurchasedDate,
                                                             Amount,
                                                             InvoiceNumber,
                                                             Paid)

                                                      VALUES(@RepairID,
                                                             @PartID,
                                                             @SupplierID
                                                             @PurchasedDate,
                                                             @Amount,
                                                             @InvoiceNumber,
                                                             @Paid)";

                cmd.Parameters.AddWithValue("@RepairID", repairDetail.RepairID);
                cmd.Parameters.AddWithValue("@PartID", repairDetail.PartID);
                cmd.Parameters.AddWithValue("@SupplierID", repairDetail.SupplierID);
                cmd.Parameters.AddWithValue("@PurchasedDate", repairDetail.PurchasedDate);
                cmd.Parameters.AddWithValue("@Amount", repairDetail.Amount);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repairDetail.InvoiceNumber);
                cmd.Parameters.AddWithValue("@Paid", repairDetail.Paid);

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
                    SupplierID = (int)reader.GetValue(2);
                    PurchasedDate = (DateTime)reader.GetValue(3);
                    Amount = (double)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Paid = (bool)reader.GetValue(6);

                    temp = new RepairDetail(RepairID,
                                            PartID, 
                                            SupplierID,
                                            PurchasedDate,
                                            Amount,
                                            InvoiceNumber,
                                            Paid);
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
                    SupplierID = (int)reader.GetValue(2);
                    PurchasedDate = (DateTime)reader.GetValue(3);
                    Amount = (double)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Paid = (bool)reader.GetValue(6);

                    temp = new RepairDetail(RepairID,
                                            PartID,
                                            SupplierID,
                                            PurchasedDate,
                                            Amount,
                                            InvoiceNumber,
                                            Paid);

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
                cmd.CommandText = "SELECT * FROM RepairDetails " + "WHERE RepairID = @RepairID";
                cmd.Parameters.AddWithValue("@RepairID", repairID);
                MySqlDataReader reader = cmd.ExecuteReader();
                RepairDetail temp = new RepairDetail();

                while (reader.Read())
                {
                    RepairID = (int)reader.GetValue(0);
                    PartID = (int)reader.GetValue(1);
                    SupplierID = (int)reader.GetValue(2);
                    PurchasedDate = (DateTime)reader.GetValue(3);
                    Amount = (double)reader.GetValue(4);
                    InvoiceNumber = (string)reader.GetValue(5);
                    Paid = (bool)reader.GetValue(6);

                    temp = new RepairDetail(RepairID,
                                            PartID,
                                            SupplierID,
                                            PurchasedDate,
                                            Amount,
                                            InvoiceNumber,
                                            Paid);

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

                cmd.CommandText = @"UPDATE RepairDetail SET RepairID = @RepairID, 
                                                            PartID = @PartID,  
                                                            SupplierID = @SupplierID,
                                                            Amount = @Amount, 
                                                            InvoiceNumber = @InvoiceNumber,  
                                                            Paid = @Paid " + "WHERE RepairID = @RepairID";

                cmd.Parameters.AddWithValue("@RepairID", repairDetail.RepairID);
                cmd.Parameters.AddWithValue("@PartID", repairDetail.PartID);
                cmd.Parameters.AddWithValue("@SupplierID", repairDetail.SupplierID);
                cmd.Parameters.AddWithValue("@PurchasedDate", repairDetail.PurchasedDate);
                cmd.Parameters.AddWithValue("@Amount", repairDetail.Amount);
                cmd.Parameters.AddWithValue("@InvoiceNumber", repairDetail.InvoiceNumber);
                cmd.Parameters.AddWithValue("@Paid", repairDetail.Paid);

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
