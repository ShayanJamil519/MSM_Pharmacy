
namespace PharmacyManagementSystem
{
    partial class OptionStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionStart));
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnPharmacist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrator.FlatAppearance.BorderSize = 2;
            this.btnAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrator.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.ForeColor = System.Drawing.Color.White;
            this.btnAdministrator.Location = new System.Drawing.Point(181, 197);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(197, 107);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnPharmacist
            // 
            this.btnPharmacist.BackColor = System.Drawing.Color.Transparent;
            this.btnPharmacist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPharmacist.FlatAppearance.BorderSize = 2;
            this.btnPharmacist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharmacist.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacist.ForeColor = System.Drawing.Color.White;
            this.btnPharmacist.Location = new System.Drawing.Point(425, 197);
            this.btnPharmacist.Name = "btnPharmacist";
            this.btnPharmacist.Size = new System.Drawing.Size(197, 107);
            this.btnPharmacist.TabIndex = 1;
            this.btnPharmacist.Text = "Pharmacist";
            this.btnPharmacist.UseVisualStyleBackColor = false;
            this.btnPharmacist.Click += new System.EventHandler(this.btnPharmacist_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter as : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(297, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 7);
            this.panel1.TabIndex = 7;
            // 
            // OptionStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPharmacist);
            this.Controls.Add(this.btnAdministrator);
            this.DoubleBuffered = true;
            this.Name = "OptionStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionStart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnPharmacist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}