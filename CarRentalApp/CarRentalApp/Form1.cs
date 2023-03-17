namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            string dateOut = dtRented.Value.ToString();
            string dateIn = dtRented.Value.ToString();
            var car = cbTypeOfCar.SelectedItem.ToString();
            MessageBox.Show($"Customer Name : {customerName} \n\r " +
                $"Date Rented : {dateOut} \n\r " +
                $"Date Returned : {dateIn} \n\r " +
                 $"Car rented  : {car} \n\r ");
        }
    }
}