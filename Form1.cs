using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUserName.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUserName.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacists")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                        Customer custom = new Customer(txtUserName.Text);
                        custom.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            //if (txtUserName.Text == "s" && txtPassword.Text == "s")
            //{
            //    OptionStart os = new OptionStart();
            //    os.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {


            //if (txtUserName.Text == "s" && txtPassword.Text == "s")
            //{
            //    OptionStart os = new OptionStart();
            //    os.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUserName.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUserName.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacists")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                        Customer custom = new Customer(txtUserName.Text);
                        custom.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
