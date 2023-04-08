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
   
    public partial class AddEditRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtRented.Value;
                var car = cbTypeOfCar.SelectedItem.ToString();
                double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(car))
                {
                    isValid = false;
                    MessageBox.Show("please enter missing data.");
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    MessageBox.Show("illegal date selection");
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = Convert.ToDecimal(cost);
                    rentalRecord.TypeOfCarId = Convert.ToInt32(cbTypeOfCar.SelectedValue);
                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show($"Customer Name : {customerName} \n\r " +
                        $"Date Rented : {dateOut} \n\r " +
                        $"Date Returned : {dateIn} \n\r " +
                         $"Car rented  : {car} \n\r " +
                           $"Cost for rented  : {cost} \n\r ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypesOfCars.Select(q => new
            {
                ID = q.id,
                Name = q.Make + " " +  q.Model
            }).ToList();
             
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }
    }
}
