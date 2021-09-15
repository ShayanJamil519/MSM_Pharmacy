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
    public partial class UC_UpdateMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text != "")
            {
                query = "select * from medicc where mid='"+txtMediID.Text+"'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtManufacturingDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpiryDate.Text= ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text= ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text= ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No medicine with ID: " + txtMediID.Text + " is found", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMediName.Clear();
            txtMedicineNo.Clear();
            txtManufacturingDate.ResetText();
            txtExpiryDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mname = txtMediName.Text;
            string mnumber = txtMedicineNo.Text;
            string mdate = txtManufacturingDate.Text;
            string edate = txtExpiryDate.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medicc set mname='"+mname+"', mnumber='"+mnumber+"', mDate='"+mdate+"', eDate= '"+edate+"', quantity='"+totalQuantity+"', perUnit='"+unitprice+"' where mid='"+txtMediID.Text+"' ";
            fn.setData(query, "Medicine details updated");

        }
    }
}
