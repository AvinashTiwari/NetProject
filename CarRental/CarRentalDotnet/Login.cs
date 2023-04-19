using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                /*
                SHA256 sha = SHA256.Create();
            
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++) {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                var hashed_password = sBuilder.ToString();
                */
                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == password);
                if (user != null)
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleName = role.Role.shortname;
                    var mainWindow = new MainWindow(this, roleName);
                    mainWindow.Show();

                }
                else {
                    MessageBox.Show("Please provide valid credentials");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong please try again");
            }

        }
    }
}
