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
    public partial class UC_C_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_C_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_C_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medicc";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicc where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        String medicineID;

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            { }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_ViewMedicine_Load(this, null);
        }

        private void btnSync_Click_1(object sender, EventArgs e)
        {
            UC_C_ViewMedicine_Load(this, null);
        }
    }
}
