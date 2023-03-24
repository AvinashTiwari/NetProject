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
                    MessageBox.Show($"Customer Name : {customerName} \n\r " +
                        $"Date Rented : {dateOut} \n\r " +
                        $"Date Returned : {dateIn} \n\r " +
                         $"Car rented  : {car} \n\r " +
                           $"Cost for rented  : {cost} \n\r ");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}