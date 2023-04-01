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
            var cars = _db.TypesOfCars.Select(q => new {ID = q.id, Name = q.Make}).ToList();
            gvVechicleList.DataSource = cars;
 
            gvVechicleList.Columns[0].HeaderText = "ID";
            gvVechicleList.Columns[0].HeaderText = "Name";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
          
           

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelteCar_Click(object sender, EventArgs e)
        {

        }
    }
}
