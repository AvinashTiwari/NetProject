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

    public partial class ManageUser : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUser()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.MdiParent = this.MdiParent;
            addUser.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
            var user = _db.Users.FirstOrDefault(q => q.id == id);
            var new_password = "Password!123";
            user.password = new_password;
            _db.SaveChanges();
            MessageBox.Show("Password Changed");

        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
            var user = _db.Users.FirstOrDefault(q => q.id == id);
           
            user.isActive = user.isActive == true ? false : true;
            _db.SaveChanges();
            MessageBox.Show("Password Changed");
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            var users = _db.Users.Select(q => new
            {
                q.id,
                q.username,
                q.UserRoles.FirstOrDefault().Role.Name,
                q.isActive
            }).ToList();
            gvUserList.DataSource = users;  

            
        }


    }
}
