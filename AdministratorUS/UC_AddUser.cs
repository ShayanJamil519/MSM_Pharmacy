using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUS
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        string query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtName.Text;
            string dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string username = txtUserName.Text;
            string pass = txtPassword.Text;

            try
            {
                query = "insert into users (userRole, name, dob, mobile, email, username, pass) values('"+ role + "', '"+name+"', '"+dob+"', '"+mobile+"', '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData(query, "SignUp Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("User Name already exixts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtEmail.Clear();
            txtPassword.Clear();
            txtMobile.Clear();
            txtUserName.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"F:\PharmacyManagementSystem\Assets\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"F:\PharmacyManagementSystem\Assets\no.png";
            }

        }
    }
}
