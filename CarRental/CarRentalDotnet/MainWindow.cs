using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDotnet
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRendtalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecord();
            addRentalRecord.MdiParent = this;
            
            addRentalRecord.Show();
        }

        private void manageVechicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vechicleListing = new ManageVechLisiting();
            vechicleListing.MdiParent = this;
            vechicleListing.Show();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
    
            manageRentalRecords.Show();

        }
    }
}
