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
   

    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong please try again");
            }

        }
    }
}
