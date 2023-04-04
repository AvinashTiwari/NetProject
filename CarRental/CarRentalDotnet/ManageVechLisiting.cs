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
    public partial class ManageVechLisiting : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVechLisiting()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVechLisiting_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars.Select(q => new {ID = q.id, Make = q.Make,
                Model = q.Model, 
                VIN = q.VIN,
                Year = q.Year , 
                LicensePlateNumber = q.LicensePlateNumber,
                q.id}).ToList();
            gvVechicleList.DataSource = cars;
            gvVechicleList.Columns[5].Visible = false;


        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
          
           AddEditForm addEditForm = new AddEditForm();
            addEditForm.MdiParent = this.MdiParent;
            addEditForm.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVechicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
            AddEditForm addEditForm = new AddEditForm(car);
            addEditForm.MdiParent = this.MdiParent;
            addEditForm.Show();
        }

        private void btnDelteCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVechicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();
            gvVechicleList.Refresh();

        }
    }
}
