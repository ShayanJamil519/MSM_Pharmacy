using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PharmacyManagementSystem.CustomerUC
{
    public partial class UC_C_BuyMedicines : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_C_BuyMedicines()
        {
            InitializeComponent();
        }

        private void UC_C_BuyMedicines_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();

            query = "select mname from medicc where eDate >= getDate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
//             ---------------------------------
// -----------------------------
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicc where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > 0";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();

            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            txtMediName.Text = name;
            query = "select mid,eDate,perUnit from medicc where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = "select quantity from medicc where mid = '" + txtMediID.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOfUnits.Text);

                if (newQuantity >= 0)
                {
                    n = gunaDataGridView1.Rows.Add();
                    gunaDataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                    gunaDataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    gunaDataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    gunaDataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    gunaDataGridView1.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                    gunaDataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    TotalLabel.Text = "Total: Rs. " + totalAmount.ToString();

                    query = "update medicc set quantity = '" + newQuantity + "' where mid = '" + txtMediID.Text + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                clearAll();
                UC_C_BuyMedicines_Load(this, null);

            }
            else
            {
                MessageBox.Show("Select Medicine First,", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;

        

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medicc where mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    query = "update medicc set quantity = '" + newQuantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine Removed from Cart.");
                    totalAmount = totalAmount - valueAmount;
                    TotalLabel.Text = "Rs. " + totalAmount.ToString();
                }
                UC_C_BuyMedicines_Load(this, null);
            }
        }

        

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + TotalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(gunaDataGridView1);

            totalAmount = 0;
            TotalLabel.Text = "Total: Rs. 00";
            gunaDataGridView1.DataSource = 0;
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Clear();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_BuyMedicines_Load(this, null);
        }
    }
}
