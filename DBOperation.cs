using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    class DBOperation
    {
        
        public MySqlConnection _dbConn;
        public string Server,
                      Port,
                      Database,
                      Uid,
                      Password;
        private string _connectionString;

        public DBOperation()
        {
            Server = "localhost";
            Port = "3306";
            Database = "vehicle";
            Uid = "root";
            Password = "";

            _connectionString = String.Format("server={0}; port={1};user id={2}; password={3}; database={4}", 
                                               Server, Port, Uid, Password, Database);
            _dbConn = new MySqlConnection(_connectionString);
        }

        #region Connection
        public void DBConnect()
        {
            try
            {
                _dbConn.Open();
            }
            catch
            {
                _dbConn.Close();
            }
        }

        public void DBClose()
        {
            try
            {
                _dbConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion




    }
}
