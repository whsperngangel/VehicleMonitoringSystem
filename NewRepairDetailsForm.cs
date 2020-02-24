using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleMonitoringSystem
{
    public partial class RepairDetailsForm : Form
    {
        #region Variables
        private RepairDetail _repairdetail = new RepairDetail();
        List<RepairDetail> _repairdetails = new List<RepairDetail>();
        #endregion
        public RepairDetailsForm()
        {
            InitializeComponent();
        }
        internal RepairDetailsForm(int repairID)
        {

        }
        public void LoadDetails()
        {
            _repairdetails = _repairdetail.RetrieveRepairDetailList();
            foreach (RepairDetail r in _repairdetails)
            {
                detailListLV.Items.Add(r.RepairID.ToString());
            }
        }


     
    }
}
