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
    public partial class Customer : Form
    {

        String user = "";

        public Customer()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Customer(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_C_ViewProfile1.ID = ID;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            uC_C_DashBoard1.Visible = false;
            uC_C_ViewProfile1.Visible = false;
            uC_C_ViewMedicine1.Visible = false;
            uC_C_BuyMedicines1.Visible = false;
            btnDasboard.PerformClick();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            uC_C_DashBoard1.Visible = true;
            uC_C_DashBoard1.BringToFront();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            uC_C_ViewProfile1.Visible = true;
            uC_C_ViewProfile1.BringToFront();
        }

        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_C_ViewMedicine1.Visible = true;
            uC_C_ViewMedicine1.BringToFront();
        }

        private void btnBuyMedicines_Click(object sender, EventArgs e)
        {
            uC_C_BuyMedicines1.Visible = true;
            uC_C_BuyMedicines1.BringToFront();
        }
    }
}
