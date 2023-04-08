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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
            /*
            AddEditForm addEditForm = new AddEditForm(car);
            addEditForm.MdiParent = this.MdiParent;
            addEditForm.Show();
            */
        }

        private void btnDelteRecord_Click(object sender, EventArgs e)
        {
            var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
            _db.CarRentalRecords.Remove(car);
            _db.SaveChanges();
            gvRecordList.Refresh();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut =  q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateOut"].HeaderText = "Date In";
            gvRecordList.Columns["DateIn"].HeaderText = "Date Out";
            gvRecordList.Columns["id"].Visible = false;
        }
    }
}
