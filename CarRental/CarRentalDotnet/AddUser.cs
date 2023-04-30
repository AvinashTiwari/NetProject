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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _db;
        public AddUser()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.ValueMember = "id";
            cbRoles.DisplayMember = "name";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = tbUserName.Text;
            var roleId = (int)cbRoles.SelectedValue;
            var password = "P@ssw0rd123";
            var user = new User {
                username = username,
                password = password,
                isActive = true,

            };
            _db.Users.Add(user);
            _db.SaveChanges();

            var userId = user.id;
            var userRole = new UserRole { 
            roleid = roleId,
            userid = userId 
            };

            _db.UserRoles.Add(userRole);
            _db.SaveChanges();
            Close();



        }
    }
}
