
namespace PharmacyManagementSystem
{
    partial class Pharmacist
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_UpdateMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_UpdateMedicine();
            this.uC_ViewMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_ViewMedicine();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Dashboard();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 773);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogOut.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Purple;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Location = new System.Drawing.Point(15, 666);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(254, 45);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.CheckedState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.CustomBorderColor = System.Drawing.Color.White;
            this.btnSellMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnSellMedicine.CustomImages.Parent = this.btnSellMedicine;
            this.btnSellMedicine.FillColor = System.Drawing.Color.Purple;
            this.btnSellMedicine.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Location = new System.Drawing.Point(12, 603);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.ShadowDecoration.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Size = new System.Drawing.Size(254, 45);
            this.btnSellMedicine.TabIndex = 4;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnMedValidityCheck
            // 
            this.btnMedValidityCheck.CheckedState.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.CustomBorderColor = System.Drawing.Color.White;
            this.btnMedValidityCheck.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnMedValidityCheck.CustomImages.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.FillColor = System.Drawing.Color.Purple;
            this.btnMedValidityCheck.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedValidityCheck.HoverState.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.Location = new System.Drawing.Point(12, 534);
            this.btnMedValidityCheck.Name = "btnMedValidityCheck";
            this.btnMedValidityCheck.ShadowDecoration.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.Size = new System.Drawing.Size(254, 45);
            this.btnMedValidityCheck.TabIndex = 4;
            this.btnMedValidityCheck.Text = "Medicine Validity Check";
            this.btnMedValidityCheck.Click += new System.EventHandler(this.btnMedValidityCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.CheckedState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.CustomBorderColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnModifyMedicine.CustomImages.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.FillColor = System.Drawing.Color.Purple;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.HoverState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Location = new System.Drawing.Point(12, 464);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.ShadowDecoration.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Size = new System.Drawing.Size(254, 45);
            this.btnModifyMedicine.TabIndex = 4;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.CheckedState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.CustomBorderColor = System.Drawing.Color.White;
            this.btnViewMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnViewMedicine.CustomImages.Parent = this.btnViewMedicine;
            this.btnViewMedicine.FillColor = System.Drawing.Color.Purple;
            this.btnViewMedicine.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Location = new System.Drawing.Point(15, 396);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.ShadowDecoration.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Size = new System.Drawing.Size(254, 45);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.CheckedState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.CustomBorderColor = System.Drawing.Color.White;
            this.btnAddMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnAddMedicine.CustomImages.Parent = this.btnAddMedicine;
            this.btnAddMedicine.FillColor = System.Drawing.Color.Purple;
            this.btnAddMedicine.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 328);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.ShadowDecoration.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Size = new System.Drawing.Size(254, 45);
            this.btnAddMedicine.TabIndex = 4;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomBorderColor = System.Drawing.Color.White;
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Purple;
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(12, 262);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(254, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 775);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_P_MedicineValidityCheck1.BackgroundImage")));
            this.uC_P_MedicineValidityCheck1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(272, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_MedicineValidityCheck1.TabIndex = 5;
            // 
            // uC_UpdateMedicine1
            // 
            this.uC_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateMedicine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_UpdateMedicine1.BackgroundImage")));
            this.uC_UpdateMedicine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_UpdateMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uC_UpdateMedicine1.Name = "uC_UpdateMedicine1";
            this.uC_UpdateMedicine1.Size = new System.Drawing.Size(1089, 730);
            this.uC_UpdateMedicine1.TabIndex = 4;
            // 
            // uC_ViewMedicine1
            // 
            this.uC_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_ViewMedicine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_ViewMedicine1.BackgroundImage")));
            this.uC_ViewMedicine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_ViewMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uC_ViewMedicine1.Name = "uC_ViewMedicine1";
            this.uC_ViewMedicine1.Size = new System.Drawing.Size(1089, 730);
            this.uC_ViewMedicine1.TabIndex = 3;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_P_AddMedicine1.BackgroundImage")));
            this.uC_P_AddMedicine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(275, 3);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_AddMedicine1.TabIndex = 2;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(275, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_Dashboard1.TabIndex = 1;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_P_SellMedicine1.BackgroundImage")));
            this.uC_P_SellMedicine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(272, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_SellMedicine1.TabIndex = 6;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.uC_P_SellMedicine1);
            this.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.Controls.Add(this.uC_UpdateMedicine1);
            this.Controls.Add(this.uC_ViewMedicine1);
            this.Controls.Add(this.uC_P_AddMedicine1);
            this.Controls.Add(this.uC_P_Dashboard1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_ViewMedicine uC_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_UpdateMedicine uC_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}