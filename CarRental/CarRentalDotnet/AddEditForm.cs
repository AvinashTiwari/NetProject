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
        public AddEditForm()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vechicle";
        }

        public AddEditForm(TypesOfCar carToEdit) {
            lblTitle.Text = "Edit Vechicle";
            PopulateFileds(carToEdit);
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

        }
    }
}
