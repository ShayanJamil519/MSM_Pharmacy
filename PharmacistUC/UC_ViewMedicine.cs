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
    public partial class UC_ViewMedicine : UserControl
    {
        function fn = new function();
        string query;

        public UC_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medicc";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicc where mname like '"+txtSearch.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        string medicineId;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch(Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query="delete from medicc where mid='"+medicineId+"' ";
                fn.setData(query, "Medicine record has been deleeted");
                UC_ViewMedicine_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewMedicine_Load(this, null);
        }
    }
}
