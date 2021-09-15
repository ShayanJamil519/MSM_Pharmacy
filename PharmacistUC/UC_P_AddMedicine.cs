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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        string query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "" && txtMediName.Text != "" && txtMedicineNo.Text != "" && txtMediQuantity.Text != "" && txtMediPricePerUnit.Text != "")
            {
                string mid = txtMediID.Text;
                string mname = txtMediName.Text;
                string mnumber = txtMedicineNo.Text;
                string mdate = txtMediManufacturingDate.Text;
                string edate = txtMediExpireDate.Text;
                Int64 quantity = Int64.Parse(txtMediQuantity.Text);
                Int64 perunit = Int64.Parse(txtMediPricePerUnit.Text);

                string query = "insert into medicc (mid, mname, mnumber, mDate, eDate, quantity, perUnit) values ('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "', '" + quantity + "', '" + perunit + "') ";
                fn.setData(query, "Medicine Added To DataBase");


            }
            else
            {
                MessageBox.Show("Please Enter All Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        public void ClearAll()
        {
            txtMediID.Clear();
            txtMedicineNo.Clear();
            txtMediName.Clear();
            txtMediManufacturingDate.ResetText();
            txtMediExpireDate.ResetText();
            txtMediPricePerUnit.Clear();
            txtMediQuantity.Clear();
        }

       
    }
}
