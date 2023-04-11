using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDotnet
{
    public partial class AddEditForm : Form
    {
        private bool isEditMode;
        private ManageVechLisiting _manageVechLisiting;
        private readonly CarRentalEntities _db;
        public AddEditForm(ManageVechLisiting manageVechLisiting = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vechicle";
            isEditMode = false;
            _manageVechLisiting = manageVechLisiting;
            _db = new CarRentalEntities();
        }

        public AddEditForm(TypesOfCar carToEdit, ManageVechLisiting manageVechLisiting = null) {
            InitializeComponent();
       
            lblTitle.Text = "Edit Vechicle";
            PopulateFileds(carToEdit);
            isEditMode = true;
            _manageVechLisiting = manageVechLisiting;
            _db = new CarRentalEntities();
        }

        private void PopulateFileds(TypesOfCar carToEdit)
        {
            lblId.Text = carToEdit.id.ToString();
            tbMake.Text = carToEdit.Make;
            tbModel.Text = carToEdit.Model;
            tbVin.Text = carToEdit.VIN;
            tbYear.Text = Convert.ToString(carToEdit.Year);
            tbLicensePlateNumber.Text = carToEdit.LicensePlateNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var id = int.Parse(lblId.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
                car.Model = tbModel.Text;
                car.Make = tbMake.Text;
                car.VIN = tbVin.Text;
                car.Year = int.Parse(tbYear.Text);
                car.LicensePlateNumber = tbLicensePlateNumber.Text;
                _db.SaveChanges();

                
            }
            else {
                var newCar = new TypesOfCar
                {
                    Model = tbModel.Text,
                Make = tbMake.Text,
                VIN = tbVin.Text,
                Year = int.Parse(tbYear.Text),
                LicensePlateNumber = tbLicensePlateNumber.Text
            };
                _db.TypesOfCars.Add(newCar);
                _db.SaveChanges();
                _manageVechLisiting.PopulateGrid();
                Close();
                
            }
        }
    }
}
