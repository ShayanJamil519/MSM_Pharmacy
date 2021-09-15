using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.CustomerUC
{
    public partial class UC_C_ViewProfile : UserControl
    {
        function fn = new function();
        String query;
        

        public UC_C_ViewProfile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { UsernameLabel.Text = value; }
        }

        

        private void UC_C_ViewProfile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + UsernameLabel.Text + "'";
            DataSet ds = fn.getData(query);
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = UsernameLabel.Text;
            String pass = txtPassword.Text;

            query = "update users set name = '" + name + "', dob = '" + dob + "',mobile='" + mobile + "', email='" + email + "',pass = '" + pass + "' where username='" + username + "'";
            fn.setData(query, "Profile Updation Successful.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_C_ViewProfile_Enter(this, null);
        }
    }
}
