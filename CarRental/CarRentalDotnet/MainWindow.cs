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
        private Login _login;
        public string _roleName;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login, string roleName)
        {
            InitializeComponent();
            _roleName = roleName;
            _login = login;
        }

        private void addRendtalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this;
            
            addRentalRecord.Show();
        }

        private void manageVechicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForm = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForm.Any(q => q.Name == "ManageVechLisiting");
            
            if (!isOpen) {
                var vechicleListing = new ManageVechLisiting();
                vechicleListing.MdiParent = this;
                vechicleListing.Show();
            }
           
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
    
            manageRentalRecords.Show();

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUser = new ManageUser();
            manageUser.MdiParent = this;
            manageUser.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            tsiLoginText.Text = $"Logged in As : {_roleName}";
            if (_roleName != "Admin") {
                manageUserToolStripMenuItem.Visible = false;
            }
        }
    }
}
