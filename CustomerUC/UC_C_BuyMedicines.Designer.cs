namespace PharmacyManagementSystem.CustomerUC
{
    partial class UC_C_BuyMedicines
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_C_BuyMedicines));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.listBoxMedicines = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediID = new Guna.UI.WinForms.GunaTextBox();
            this.txtMediName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoOfUnits = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpireDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new Guna.UI.WinForms.GunaButton();
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
            this.btnPurchase = new Guna.UI.WinForms.GunaButton();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy Medicines";
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(34, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(228, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listBoxMedicines
            // 
            this.listBoxMedicines.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicines.FormattingEnabled = true;
            this.listBoxMedicines.ItemHeight = 26;
            this.listBoxMedicines.Location = new System.Drawing.Point(34, 152);
            this.listBoxMedicines.Name = "listBoxMedicines";
            this.listBoxMedicines.Size = new System.Drawing.Size(228, 550);
            this.listBoxMedicines.TabIndex = 2;
            this.listBoxMedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicines_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine ID";
            // 
            // txtMediID
            // 
            this.txtMediID.BaseColor = System.Drawing.Color.White;
            this.txtMediID.BorderColor = System.Drawing.Color.Black;
            this.txtMediID.BorderSize = 1;
            this.txtMediID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMediID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMediID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMediID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediID.Location = new System.Drawing.Point(327, 113);
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.PasswordChar = '\0';
            this.txtMediID.ReadOnly = true;
            this.txtMediID.SelectedText = "";
            this.txtMediID.Size = new System.Drawing.Size(317, 32);
            this.txtMediID.TabIndex = 5;
            // 
            // txtMediName
            // 
            this.txtMediName.BaseColor = System.Drawing.Color.White;
            this.txtMediName.BorderColor = System.Drawing.Color.Black;
            this.txtMediName.BorderSize = 1;
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMediName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMediName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMediName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.Location = new System.Drawing.Point(327, 194);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.ReadOnly = true;
            this.txtMediName.SelectedText = "";
            this.txtMediName.Size = new System.Drawing.Size(317, 32);
            this.txtMediName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medicine Name";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.BaseColor = System.Drawing.Color.White;
            this.txtPricePerUnit.BorderColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.BorderSize = 1;
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPricePerUnit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.Location = new System.Drawing.Point(724, 113);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.ReadOnly = true;
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.Size = new System.Drawing.Size(317, 32);
            this.txtPricePerUnit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price Per Unit";
            // 
            // txtNoOfUnits
            // 
            this.txtNoOfUnits.BaseColor = System.Drawing.Color.White;
            this.txtNoOfUnits.BorderColor = System.Drawing.Color.Black;
            this.txtNoOfUnits.BorderSize = 1;
            this.txtNoOfUnits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfUnits.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNoOfUnits.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNoOfUnits.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoOfUnits.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfUnits.Location = new System.Drawing.Point(724, 194);
            this.txtNoOfUnits.Name = "txtNoOfUnits";
            this.txtNoOfUnits.PasswordChar = '\0';
            this.txtNoOfUnits.SelectedText = "";
            this.txtNoOfUnits.Size = new System.Drawing.Size(317, 32);
            this.txtNoOfUnits.TabIndex = 11;
            this.txtNoOfUnits.TextChanged += new System.EventHandler(this.txtNoOfUnits_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(720, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "No of Units";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Black;
            this.txtTotalPrice.BorderSize = 1;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(724, 272);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(317, 32);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expiry Date";
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.BaseColor = System.Drawing.Color.White;
            this.txtExpireDate.BorderColor = System.Drawing.Color.Black;
            this.txtExpireDate.BorderSize = 1;
            this.txtExpireDate.CustomFormat = null;
            this.txtExpireDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtExpireDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpireDate.ForeColor = System.Drawing.Color.Black;
            this.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpireDate.Location = new System.Drawing.Point(327, 274);
            this.txtExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtExpireDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExpireDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExpireDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtExpireDate.Size = new System.Drawing.Size(317, 30);
            this.txtExpireDate.TabIndex = 15;
            this.txtExpireDate.Text = "9/10/2021";
            this.txtExpireDate.Value = new System.DateTime(2021, 9, 10, 20, 50, 57, 408);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 21;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(327, 375);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(714, 288);
            this.gunaDataGridView1.TabIndex = 16;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expiry Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AnimationHoverSpeed = 0.07F;
            this.btnAddToCart.AnimationSpeed = 0.03F;
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BaseColor = System.Drawing.Color.Blue;
            this.btnAddToCart.BorderColor = System.Drawing.Color.Black;
            this.btnAddToCart.BorderSize = 1;
            this.btnAddToCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddToCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddToCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddToCart.Location = new System.Drawing.Point(872, 319);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddToCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddToCart.OnHoverForeColor = System.Drawing.Color.Blue;
            this.btnAddToCart.OnHoverImage = null;
            this.btnAddToCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddToCart.Radius = 19;
            this.btnAddToCart.Size = new System.Drawing.Size(169, 42);
            this.btnAddToCart.TabIndex = 17;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BaseColor = System.Drawing.Color.Blue;
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.BorderSize = 1;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRemove.Location = new System.Drawing.Point(327, 679);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.Blue;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Radius = 19;
            this.btnRemove.Size = new System.Drawing.Size(169, 42);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.AnimationHoverSpeed = 0.07F;
            this.btnPurchase.AnimationSpeed = 0.03F;
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.BaseColor = System.Drawing.Color.Blue;
            this.btnPurchase.BorderColor = System.Drawing.Color.Black;
            this.btnPurchase.BorderSize = 1;
            this.btnPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPurchase.FocusedColor = System.Drawing.Color.Empty;
            this.btnPurchase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPurchase.ImageSize = new System.Drawing.Size(60, 60);
            this.btnPurchase.Location = new System.Drawing.Point(872, 679);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPurchase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPurchase.OnHoverForeColor = System.Drawing.Color.Blue;
            this.btnPurchase.OnHoverImage = null;
            this.btnPurchase.OnPressedColor = System.Drawing.Color.Black;
            this.btnPurchase.Radius = 19;
            this.btnPurchase.Size = new System.Drawing.Size(169, 42);
            this.btnPurchase.TabIndex = 19;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TotalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(610, 679);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(152, 42);
            this.TotalLabel.TabIndex = 20;
            this.TotalLabel.Text = "Total: Rs.00";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSync
            // 
            this.btnSync.CheckedState.Parent = this.btnSync;
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.CustomImages.Parent = this.btnSync;
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSync.HoverState.Parent = this.btnSync;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSync.Location = new System.Drawing.Point(624, 40);
            this.btnSync.Name = "btnSync";
            this.btnSync.PressedColor = System.Drawing.Color.White;
            this.btnSync.ShadowDecoration.Parent = this.btnSync;
            this.btnSync.Size = new System.Drawing.Size(34, 35);
            this.btnSync.TabIndex = 22;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(610, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Reload";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UC_C_BuyMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoOfUnits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMedicines);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "UC_C_BuyMedicines";
            this.Size = new System.Drawing.Size(1089, 733);
            this.Load += new System.EventHandler(this.UC_C_BuyMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.ListBox listBoxMedicines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtMediID;
        private Guna.UI.WinForms.GunaTextBox txtMediName;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtPricePerUnit;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtNoOfUnits;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDateTimePicker txtExpireDate;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI.WinForms.GunaButton btnAddToCart;
        private Guna.UI.WinForms.GunaButton btnRemove;
        private Guna.UI.WinForms.GunaButton btnPurchase;
        private System.Windows.Forms.Label TotalLabel;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
