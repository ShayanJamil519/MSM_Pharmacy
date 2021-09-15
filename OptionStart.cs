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
    public partial class OptionStart : Form
    {
        public OptionStart()
        {
            InitializeComponent();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Administrator am = new Administrator();
            am.Show();
        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            Pharmacist pharm = new Pharmacist();
            pharm.Show();
        }
    }
}
