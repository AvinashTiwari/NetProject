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

namespace DataEntryProject
{
    public partial class Books : Form
    {
        OleDbConnection conn;
        OleDbCommand titlesCommand;
        OleDbDataAdapter titlesAdapter;
        DataTable titlesTable;
        CurrencyManager titlesManager;
        public Books()
        {
            InitializeComponent();
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\NetProject\DataEntry\DataEntryProject\DataEntryProject\Books.accdb; Persist Security Info = False;";

            conn = new OleDbConnection(connString);
            conn.Open();
            txtTitle.Text = conn.State.ToString();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}
