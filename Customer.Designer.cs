namespace PharmacyManagementSystem
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.btnBuyMedicines = new Guna.UI.WinForms.GunaButton();
            this.btnViewMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnViewProfile = new Guna.UI.WinForms.GunaButton();
            this.btnDasboard = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.uC_C_BuyMedicines1 = new PharmacyManagementSystem.CustomerUC.UC_C_BuyMedicines();
            this.uC_C_ViewMedicine1 = new PharmacyManagementSystem.CustomerUC.UC_C_ViewMedicine();
            this.uC_C_DashBoard1 = new PharmacyManagementSystem.CustomerUC.UC_C_DashBoard();
            this.uC_C_ViewProfile1 = new PharmacyManagementSystem.CustomerUC.UC_C_ViewProfile();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Blue;
            this.gunaPanel1.Controls.Add(this.userNameLabel);
            this.gunaPanel1.Controls.Add(this.btnLogOut);
            this.gunaPanel1.Controls.Add(this.btnBuyMedicines);
            this.gunaPanel1.Controls.Add(this.btnViewMedicine);
            this.gunaPanel1.Controls.Add(this.btnViewProfile);
            this.gunaPanel1.Controls.Add(this.btnDasboard);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(271, 733);
            this.gunaPanel1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Red;
            this.userNameLabel.Location = new System.Drawing.Point(3, 681);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(268, 31);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.Blue;
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderSize = 2;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = null;
            this.btnLogOut.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogOut.Location = new System.Drawing.Point(18, 620);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(233, 46);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBuyMedicines
            // 
            this.btnBuyMedicines.AnimationHoverSpeed = 0.07F;
            this.btnBuyMedicines.AnimationSpeed = 0.03F;
            this.btnBuyMedicines.BaseColor = System.Drawing.Color.Blue;
            this.btnBuyMedicines.BorderColor = System.Drawing.Color.White;
            this.btnBuyMedicines.BorderSize = 2;
            this.btnBuyMedicines.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuyMedicines.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuyMedicines.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMedicines.ForeColor = System.Drawing.Color.White;
            this.btnBuyMedicines.Image = null;
            this.btnBuyMedicines.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuyMedicines.Location = new System.Drawing.Point(18, 549);
            this.btnBuyMedicines.Name = "btnBuyMedicines";
            this.btnBuyMedicines.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBuyMedicines.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuyMedicines.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBuyMedicines.OnHoverImage = null;
            this.btnBuyMedicines.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuyMedicines.Size = new System.Drawing.Size(233, 46);
            this.btnBuyMedicines.TabIndex = 4;
            this.btnBuyMedicines.Text = "Buy Medicines";
            this.btnBuyMedicines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuyMedicines.Click += new System.EventHandler(this.btnBuyMedicines_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.AnimationHoverSpeed = 0.07F;
            this.btnViewMedicine.AnimationSpeed = 0.03F;
            this.btnViewMedicine.BaseColor = System.Drawing.Color.Blue;
            this.btnViewMedicine.BorderColor = System.Drawing.Color.White;
            this.btnViewMedicine.BorderSize = 2;
            this.btnViewMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewMedicine.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = null;
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewMedicine.Location = new System.Drawing.Point(18, 476);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.OnHoverImage = null;
            this.btnViewMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Size = new System.Drawing.Size(233, 46);
            this.btnViewMedicine.TabIndex = 3;
            this.btnViewMedicine.Text = "View Medicines";
            this.btnViewMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.AnimationHoverSpeed = 0.07F;
            this.btnViewProfile.AnimationSpeed = 0.03F;
            this.btnViewProfile.BaseColor = System.Drawing.Color.Blue;
            this.btnViewProfile.BorderColor = System.Drawing.Color.White;
            this.btnViewProfile.BorderSize = 2;
            this.btnViewProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewProfile.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.Color.White;
            this.btnViewProfile.Image = null;
            this.btnViewProfile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewProfile.Location = new System.Drawing.Point(18, 399);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewProfile.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewProfile.OnHoverImage = null;
            this.btnViewProfile.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewProfile.Size = new System.Drawing.Size(233, 46);
            this.btnViewProfile.TabIndex = 2;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnDasboard
            // 
            this.btnDasboard.AnimationHoverSpeed = 0.07F;
            this.btnDasboard.AnimationSpeed = 0.03F;
            this.btnDasboard.BaseColor = System.Drawing.Color.Blue;
            this.btnDasboard.BorderColor = System.Drawing.Color.White;
            this.btnDasboard.BorderSize = 2;
            this.btnDasboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDasboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDasboard.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboard.ForeColor = System.Drawing.Color.White;
            this.btnDasboard.Image = null;
            this.btnDasboard.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDasboard.Location = new System.Drawing.Point(18, 325);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnDasboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDasboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDasboard.OnHoverImage = null;
            this.btnDasboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDasboard.Size = new System.Drawing.Size(233, 46);
            this.btnDasboard.TabIndex = 1;
            this.btnDasboard.Text = "DashBoard";
            this.btnDasboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDasboard.Click += new System.EventHandler(this.btnDasboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(18, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(233, 216);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.uC_C_BuyMedicines1);
            this.gunaPanel2.Controls.Add(this.uC_C_ViewMedicine1);
            this.gunaPanel2.Controls.Add(this.uC_C_DashBoard1);
            this.gunaPanel2.Controls.Add(this.uC_C_ViewProfile1);
            this.gunaPanel2.Location = new System.Drawing.Point(271, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1100, 733);
            this.gunaPanel2.TabIndex = 1;
            // 
            // uC_C_BuyMedicines1
            // 
            this.uC_C_BuyMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_C_BuyMedicines1.Location = new System.Drawing.Point(-1, 0);
            this.uC_C_BuyMedicines1.Name = "uC_C_BuyMedicines1";
            this.uC_C_BuyMedicines1.Size = new System.Drawing.Size(1100, 733);
            this.uC_C_BuyMedicines1.TabIndex = 3;
            // 
            // uC_C_ViewMedicine1
            // 
            this.uC_C_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_C_ViewMedicine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_C_ViewMedicine1.BackgroundImage")));
            this.uC_C_ViewMedicine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_C_ViewMedicine1.Location = new System.Drawing.Point(-3, 0);
            this.uC_C_ViewMedicine1.Name = "uC_C_ViewMedicine1";
            this.uC_C_ViewMedicine1.Size = new System.Drawing.Size(1100, 733);
            this.uC_C_ViewMedicine1.TabIndex = 2;
            // 
            // uC_C_DashBoard1
            // 
            this.uC_C_DashBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uC_C_DashBoard1.Location = new System.Drawing.Point(0, -3);
            this.uC_C_DashBoard1.Name = "uC_C_DashBoard1";
            this.uC_C_DashBoard1.Size = new System.Drawing.Size(1100, 733);
            this.uC_C_DashBoard1.TabIndex = 1;
            // 
            // uC_C_ViewProfile1
            // 
            this.uC_C_ViewProfile1.BackColor = System.Drawing.Color.White;
            this.uC_C_ViewProfile1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_ViewProfile1.Name = "uC_C_ViewProfile1";
            this.uC_C_ViewProfile1.Size = new System.Drawing.Size(1089, 733);
            this.uC_C_ViewProfile1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.gunaPanel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.gunaPanel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.gunaPanel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.gunaPanel2;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 733);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnDasboard;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private Guna.UI.WinForms.GunaButton btnBuyMedicines;
        private Guna.UI.WinForms.GunaButton btnViewMedicine;
        private Guna.UI.WinForms.GunaButton btnViewProfile;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private CustomerUC.UC_C_ViewProfile uC_C_ViewProfile1;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private CustomerUC.UC_C_DashBoard uC_C_DashBoard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private CustomerUC.UC_C_ViewMedicine uC_C_ViewMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private CustomerUC.UC_C_BuyMedicines uC_C_BuyMedicines1;
    }
}