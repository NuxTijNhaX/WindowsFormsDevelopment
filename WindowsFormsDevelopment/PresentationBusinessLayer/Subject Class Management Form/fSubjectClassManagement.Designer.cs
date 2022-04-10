
using System.Drawing;

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form
{
    partial class fSubjectClassManagement
    {
        public static Color green = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
        public static Color orange = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));

        public static Font font10 = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font11 = new Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font12 = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font font10_Regular = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSubjectClassManagement));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.flpSideBarBody = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateSubjectClass = new System.Windows.Forms.Button();
            this.btnSubjectClassManagement = new System.Windows.Forms.Button();
            this.pnlSideBarBottom = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSideBarHeader = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.flpSideBarBody.SuspendLayout();
            this.pnlSideBarBottom.SuspendLayout();
            this.pnlSideBarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pnlSideBar.Controls.Add(this.flpSideBarBody);
            this.pnlSideBar.Controls.Add(this.pnlSideBarBottom);
            this.pnlSideBar.Controls.Add(this.pnlSideBarHeader);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(240, 636);
            this.pnlSideBar.TabIndex = 0;
            // 
            // flpSideBarBody
            // 
            this.flpSideBarBody.Controls.Add(this.btnCreateSubjectClass);
            this.flpSideBarBody.Controls.Add(this.btnSubjectClassManagement);
            this.flpSideBarBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSideBarBody.Location = new System.Drawing.Point(0, 118);
            this.flpSideBarBody.Name = "flpSideBarBody";
            this.flpSideBarBody.Size = new System.Drawing.Size(240, 448);
            this.flpSideBarBody.TabIndex = 2;
            // 
            // btnCreateSubjectClass
            // 
            this.btnCreateSubjectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateSubjectClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSubjectClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreateSubjectClass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateSubjectClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateSubjectClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreateSubjectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSubjectClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubjectClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateSubjectClass.Image = global::WindowsFormsDevelopment.Properties.Resources.folder_white;
            this.btnCreateSubjectClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSubjectClass.Location = new System.Drawing.Point(3, 3);
            this.btnCreateSubjectClass.Name = "btnCreateSubjectClass";
            this.btnCreateSubjectClass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCreateSubjectClass.Size = new System.Drawing.Size(237, 48);
            this.btnCreateSubjectClass.TabIndex = 1;
            this.btnCreateSubjectClass.Text = "    Tạo Lớp Học Phần";
            this.btnCreateSubjectClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSubjectClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateSubjectClass.UseVisualStyleBackColor = false;
            this.btnCreateSubjectClass.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSubjectClassManagement
            // 
            this.btnSubjectClassManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSubjectClassManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectClassManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnSubjectClassManagement.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnSubjectClassManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSubjectClassManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnSubjectClassManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectClassManagement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectClassManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubjectClassManagement.Image = global::WindowsFormsDevelopment.Properties.Resources.desktop_white;
            this.btnSubjectClassManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectClassManagement.Location = new System.Drawing.Point(3, 57);
            this.btnSubjectClassManagement.Name = "btnSubjectClassManagement";
            this.btnSubjectClassManagement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSubjectClassManagement.Size = new System.Drawing.Size(237, 48);
            this.btnSubjectClassManagement.TabIndex = 2;
            this.btnSubjectClassManagement.Text = "    Quản Lý Lớp Học Phần";
            this.btnSubjectClassManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectClassManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubjectClassManagement.UseVisualStyleBackColor = false;
            this.btnSubjectClassManagement.Click += new System.EventHandler(this.btnSubjectClassManagement_Click);
            // 
            // pnlSideBarBottom
            // 
            this.pnlSideBarBottom.Controls.Add(this.btnExit);
            this.pnlSideBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSideBarBottom.Location = new System.Drawing.Point(0, 566);
            this.pnlSideBarBottom.Name = "pnlSideBarBottom";
            this.pnlSideBarBottom.Size = new System.Drawing.Size(240, 70);
            this.pnlSideBarBottom.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = global::WindowsFormsDevelopment.Properties.Resources.log_out_white;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(240, 70);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "    Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSideBarHeader
            // 
            this.pnlSideBarHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBarHeader.Controls.Add(this.pbxLogo);
            this.pnlSideBarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBarHeader.Name = "pnlSideBarHeader";
            this.pnlSideBarHeader.Size = new System.Drawing.Size(240, 118);
            this.pnlSideBarHeader.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsDevelopment.Properties.Resources.logo_ueh_deparment;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(86, 55);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(240, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(944, 636);
            this.pnlBody.TabIndex = 1;
            // 
            // fSubjectClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSubjectClassManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học Phần";
            this.Load += new System.EventHandler(this.fSubjectClassManagement_Load);
            this.SizeChanged += new System.EventHandler(this.fSubjectClassManagement_SizeChanged);
            this.pnlSideBar.ResumeLayout(false);
            this.flpSideBarBody.ResumeLayout(false);
            this.pnlSideBarBottom.ResumeLayout(false);
            this.pnlSideBarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSideBarHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.FlowLayoutPanel flpSideBarBody;
        private System.Windows.Forms.Panel pnlSideBarBottom;

        private System.Windows.Forms.Button btnCreateSubjectClass;
        private System.Windows.Forms.Button btnSubjectClassManagement;
        private System.Windows.Forms.Button btnExit;
    }
}