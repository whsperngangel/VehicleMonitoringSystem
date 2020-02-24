using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleMonitoringSystem
{
    public partial class NewPartForm : Form
    {
        #region Variable
        private int _partID;
        private string _description, partID;

        private Part _part = new Part();
        private List<Part> _parts = new List<Part>();
        private MainForm _mainForm;
        #endregion

        #region  Constructors
        public NewPartForm()
        {
            InitializeComponent();
            ListViewLoad();

        }

        public NewPartForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            ListViewLoad();
        }
        #endregion

        #region Gas Methods
        #endregion
        private void addPartB_Click(object sender, EventArgs e)
        {
            if (addPartB.Text == "Add")
            {
                _partID = _part.CreatePartID();
                _description = partDescriptionTB.Text.Trim();

                _part = new Part(_partID, _description);
                _part.InsertPart(_part);

                partDescriptionTB.Text = "";
            }
            else if (addPartB.Text == "Update")
            {
                if (partID != partIDTB.Text ||
                   _description != partDescriptionTB.Text)
                {
                    _partID = int.Parse(partIDTB.Text);
                    _description = partDescriptionTB.Text;
                    
                    _part = new Part(_partID, _description);
                }

                _part.UpdatePartInfo(_part);
                partDescriptionTB.Text = "";
                
            }
            ListViewLoad();


        }
        private void ListViewLoad()
        {
            _parts = _part.RetrievePartList();
            foreach (Part p in _parts)
            {
                _partID = p.PartID;
                _description = p.Description;

                ListViewItem partList = new ListViewItem();
                partList.SubItems.Add(_partID.ToString());
                partList.SubItems.Add(_description);
               
                partListLV.Items.Add(partList);
            }
        }

        private void partListLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            addPartB.Text = "Update";
            if (partListLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedPart = partListLV.SelectedItems[0];
                partDescriptionTB.Text = selectedPart.SubItems[2].Text;
                partIDTB.Text = selectedPart.SubItems[1].Text;
            }
        }
    }
}
