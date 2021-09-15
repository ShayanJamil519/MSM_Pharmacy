using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        string query;

        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from medicc where eDate >= getdate()";
               DataSet ds= fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
                setLabelName.Text = "Valid Medicines";
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from medicc where eDate <= getdate()";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
                setLabelName.Text = "Expired Medicines";
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medicc";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
                setLabelName.Text = "All Medicines";
            }

        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabelName.Text = "";
           
        }
    }
}
