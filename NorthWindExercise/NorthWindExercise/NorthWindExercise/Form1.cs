using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindExercise
{
    public partial class frmTraders : Form
    {
        OleDbConnection custConn;
        OleDbCommand custCommand;
        OleDbDataAdapter custAdapter;
        DataTable custDataTable;
        CurrencyManager custManager;

        public frmTraders()
        {
            InitializeComponent();
        }

        private void frmTraders_Load(object sender, EventArgs e)
        {
            var stringConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DB\NorthWind.accdb;
                                     Persist Security Info = False;";
            custConn = new OleDbConnection(stringConnection);
            custConn.Open();

            custCommand = new OleDbCommand("Select * from Customers", custConn);
            custAdapter = new OleDbDataAdapter();
            custAdapter.SelectCommand = custCommand;
            custDataTable = new DataTable();
            custAdapter.Fill(custDataTable);

            txtCustomerID.DataBindings.Add("Text", custDataTable, "CustomerID");
            txtCompanyName.DataBindings.Add("Text", custDataTable, "CompanyName");
            txtContactName.DataBindings.Add("Text", custDataTable, "ContactName");
            txtContactTitle.DataBindings.Add("Text", custDataTable, "ContactTitle");

            custManager = (CurrencyManager) BindingContext[custDataTable];

            custConn.Close();
            custConn.Dispose();
            custAdapter.Dispose();
            custCommand.Dispose();
            custDataTable.Dispose();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            custManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            custManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            custManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            custManager.Position = custManager.Count - 1;
        }
    }
}
