
namespace GymManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnCoaches = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // slidePic
            // 
            this.slidePic.Image = ((System.Drawing.Image)(resources.GetObject("slidePic.Image")));
            this.slidePic.Location = new System.Drawing.Point(295, 111);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(350, 325);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slidePic.TabIndex = 13;
            this.slidePic.TabStop = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(29, 383);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(225, 65);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.Text = "STAFF";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.BackColor = System.Drawing.Color.White;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipment.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipment.Image")));
            this.btnEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.Location = new System.Drawing.Point(29, 312);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(225, 65);
            this.btnEquipment.TabIndex = 11;
            this.btnEquipment.Text = "EQUIPMENT";
            this.btnEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipment.UseVisualStyleBackColor = false;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnCoaches
            // 
            this.btnCoaches.BackColor = System.Drawing.Color.White;
            this.btnCoaches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoaches.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoaches.Image = ((System.Drawing.Image)(resources.GetObject("btnCoaches.Image")));
            this.btnCoaches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoaches.Location = new System.Drawing.Point(29, 241);
            this.btnCoaches.Name = "btnCoaches";
            this.btnCoaches.Size = new System.Drawing.Size(225, 65);
            this.btnCoaches.TabIndex = 10;
            this.btnCoaches.Text = "COACHES";
            this.btnCoaches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoaches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCoaches.UseVisualStyleBackColor = false;
            this.btnCoaches.Click += new System.EventHandler(this.btnCoaches_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.White;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(29, 170);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(225, 65);
            this.btnMembers.TabIndex = 9;
            this.btnMembers.Text = "MEMBERS";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.BackColor = System.Drawing.Color.White;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMember.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMember.Image")));
            this.btnNewMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMember.Location = new System.Drawing.Point(29, 99);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(225, 65);
            this.btnNewMember.TabIndex = 8;
            this.btnNewMember.Text = "NEW MEMBER";
            this.btnNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewMember.UseVisualStyleBackColor = false;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 90);
            this.panel1.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(584, 43);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(29, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(70, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.slidePic);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnEquipment);
            this.Controls.Add(this.btnCoaches);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fit Body Fitness Center";
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnCoaches;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox Logo;
    }
}