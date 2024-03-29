﻿using System;
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
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental";
            this.Text = "Add New Rental";
            isEditMode = false;
            _db = new CarRentalEntities();
        }
        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            

            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else {
                isEditMode = false;
                _db = new CarRentalEntities();
                PopulateFileds(recordToEdit);
            }


          
        }

        private void PopulateFileds(CarRentalRecord recordToEdit)
        {
             tbCustomerName.Text = recordToEdit.CustomerName;
             dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            //cbTypeOfCar.SelectedItem.ToString();
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
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
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        var rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateOut;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = Convert.ToDecimal(cost);
                        rentalRecord.TypeOfCarId = Convert.ToInt32(cbTypeOfCar.SelectedValue);
                        _db.SaveChanges();
                        MessageBox.Show($"Customer Name : {customerName} \n\r " +
                  $"Date Rented : {dateOut} \n\r " +
                  $"Date Returned : {dateIn} \n\r " +
                   $"Car rented  : {car} \n\r " +
                     $"Cost for rented  : {cost} \n\r ");
                        Close();

                    }
                    else {
                        var rentalRecord = new CarRentalRecord();
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dateOut;
                        rentalRecord.DateReturned = dateIn;
                        rentalRecord.Cost = Convert.ToDecimal(cost);
                        rentalRecord.TypeOfCarId = Convert.ToInt32(cbTypeOfCar.SelectedValue);
                        _db.CarRentalRecords.Add(rentalRecord);
                        _db.SaveChanges();

                        MessageBox.Show($"Customer Name : {customerName} \n\r " +
                            $"Date Rented : {dateOut} \n\r " +
                            $"Date Returned : {dateIn} \n\r " +
                             $"Car rented  : {car} \n\r " +
                               $"Cost for rented  : {cost} \n\r ");
                        Close();
                    }


                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars.Select(q => new
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
