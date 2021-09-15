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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        string query;
        string currentUser;

        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { currentUser = value; }
        }
       
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query="select * from users where username like '"+txtUserName.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];


        }

        string userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception)
            {

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete Confirmation!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (currentUser != userName)
                {
                    query="delete from users where username='"+userName+"'";
                    fn.setData(query, "User Record Deleted!");
                    UC_ViewUser_Load(this, null);

                }
                else
                {
                    MessageBox.Show("You are trying to delete you own profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
