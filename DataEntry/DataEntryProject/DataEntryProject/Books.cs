﻿using System;
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
          
        }

        private void Books_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\NetProject\DataEntry\DataEntryProject\DataEntryProject\Books.accdb; Persist Security Info = False;";

            conn = new OleDbConnection(connString);
            conn.Open();
            txtTitle.Text = conn.State.ToString();
            titlesCommand = new OleDbCommand("Select * from Titles", conn);
            titlesAdapter = new OleDbDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;
            titlesTable = new DataTable();
            titlesAdapter.Fill(titlesTable);

            //bind controls
            txtTitle.DataBindings.Add("Text", titlesTable, "Title");
            txtYear.DataBindings.Add("Text", titlesTable, "Year_Published");
            txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
            txtPubID.DataBindings.Add("Text", titlesTable, "PubId");

            //establish currency manager
            titlesManager = (CurrencyManager)BindingContext[titlesTable];

            conn.Close();
            conn.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }
    }
}
