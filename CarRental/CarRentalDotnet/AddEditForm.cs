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
    public partial class AddEditForm : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditForm()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vechicle";
            isEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditForm(TypesOfCar carToEdit) {
            lblTitle.Text = "Edit Vechicle";
            PopulateFileds(carToEdit);
            isEditMode = true;
            _db = new CarRentalEntities();
        }

        private void PopulateFileds(TypesOfCar carToEdit)
        {
            tbMake.Text = carToEdit.Make;
            tbModel.Text = carToEdit.Model;
            tbVin.Text = carToEdit.VIN.ToString();
            tbYear.Text = carToEdit.Year.ToString();
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
                
            }
            else { 
            }
        }
    }
}
