
using System.Drawing;

namespace WindowsFormsDevelopment
{
    partial class fCourseRegistration
    {
        public static Color green = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
        public static Color orange = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));

        public static Font font10 = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font11 = new Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font font12 = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCourseRegistration));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.flpSideBarBody = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentInfor = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.btnInProgram = new System.Windows.Forms.Button();
            this.btnOutProgram = new System.Windows.Forms.Button();
            this.btnRegistrationResult = new System.Windows.Forms.Button();
            this.btnPayTuition = new System.Windows.Forms.Button();
            this.pnlSideBarBottom = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSideBarHeader = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.flpSideBarBody.Controls.Add(this.btnStudentInfor);
            this.flpSideBarBody.Controls.Add(this.btnRegisterCourse);
            this.flpSideBarBody.Controls.Add(this.btnInProgram);
            this.flpSideBarBody.Controls.Add(this.btnOutProgram);
            this.flpSideBarBody.Controls.Add(this.btnRegistrationResult);
            this.flpSideBarBody.Controls.Add(this.btnPayTuition);
            this.flpSideBarBody.Controls.Add(this.button1);
            this.flpSideBarBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSideBarBody.Location = new System.Drawing.Point(0, 118);
            this.flpSideBarBody.Name = "flpSideBarBody";
            this.flpSideBarBody.Size = new System.Drawing.Size(240, 448);
            this.flpSideBarBody.TabIndex = 2;
            // 
            // btnStudentInfor
            // 
            this.btnStudentInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnStudentInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentInfor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnStudentInfor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnStudentInfor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnStudentInfor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnStudentInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInfor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStudentInfor.Image = global::WindowsFormsDevelopment.Properties.Resources.user_white;
            this.btnStudentInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentInfor.Location = new System.Drawing.Point(3, 3);
            this.btnStudentInfor.Name = "btnStudentInfor";
            this.btnStudentInfor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStudentInfor.Size = new System.Drawing.Size(237, 48);
            this.btnStudentInfor.TabIndex = 0;
            this.btnStudentInfor.Text = "    Thông Tin Sinh Viên";
            this.btnStudentInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentInfor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentInfor.UseVisualStyleBackColor = false;
            this.btnStudentInfor.Click += new System.EventHandler(this.btnStudentInfor_Click);
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegisterCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegisterCourse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnRegisterCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnRegisterCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnRegisterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegisterCourse.Image = global::WindowsFormsDevelopment.Properties.Resources.registration_white;
            this.btnRegisterCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCourse.Location = new System.Drawing.Point(3, 57);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRegisterCourse.Size = new System.Drawing.Size(237, 48);
            this.btnRegisterCourse.TabIndex = 1;
            this.btnRegisterCourse.Text = "    Đăng Ký Học Phần";
            this.btnRegisterCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterCourse.UseVisualStyleBackColor = false;
            this.btnRegisterCourse.Click += new System.EventHandler(this.btnRegisterCourse_Click);
            // 
            // btnInProgram
            // 
            this.btnInProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnInProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnInProgram.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnInProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnInProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnInProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInProgram.Location = new System.Drawing.Point(3, 111);
            this.btnInProgram.Name = "btnInProgram";
            this.btnInProgram.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInProgram.Size = new System.Drawing.Size(237, 48);
            this.btnInProgram.TabIndex = 4;
            this.btnInProgram.Text = "    Thuộc Chương Trình";
            this.btnInProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInProgram.UseVisualStyleBackColor = false;
            this.btnInProgram.Visible = false;
            this.btnInProgram.Click += new System.EventHandler(this.btnInProgram_Click);
            // 
            // btnOutProgram
            // 
            this.btnOutProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnOutProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnOutProgram.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnOutProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnOutProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnOutProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutProgram.Location = new System.Drawing.Point(3, 165);
            this.btnOutProgram.Name = "btnOutProgram";
            this.btnOutProgram.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOutProgram.Size = new System.Drawing.Size(237, 48);
            this.btnOutProgram.TabIndex = 5;
            this.btnOutProgram.Text = "    Ngoài Chương Trình";
            this.btnOutProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutProgram.UseVisualStyleBackColor = false;
            this.btnOutProgram.Visible = false;
            this.btnOutProgram.Click += new System.EventHandler(this.btnOutProgram_Click);
            // 
            // btnRegistrationResult
            // 
            this.btnRegistrationResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegistrationResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrationResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegistrationResult.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnRegistrationResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnRegistrationResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnRegistrationResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrationResult.Image = global::WindowsFormsDevelopment.Properties.Resources.timetable_white;
            this.btnRegistrationResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrationResult.Location = new System.Drawing.Point(3, 219);
            this.btnRegistrationResult.Name = "btnRegistrationResult";
            this.btnRegistrationResult.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRegistrationResult.Size = new System.Drawing.Size(237, 48);
            this.btnRegistrationResult.TabIndex = 2;
            this.btnRegistrationResult.Text = "    Kết Quả Đăng Ký";
            this.btnRegistrationResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrationResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrationResult.UseVisualStyleBackColor = false;
            this.btnRegistrationResult.Click += new System.EventHandler(this.btnRegistrationResult_Click);
            // 
            // btnPayTuition
            // 
            this.btnPayTuition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPayTuition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayTuition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnPayTuition.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPayTuition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnPayTuition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnPayTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayTuition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayTuition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayTuition.Image = global::WindowsFormsDevelopment.Properties.Resources.payment_white;
            this.btnPayTuition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayTuition.Location = new System.Drawing.Point(3, 273);
            this.btnPayTuition.Name = "btnPayTuition";
            this.btnPayTuition.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPayTuition.Size = new System.Drawing.Size(237, 48);
            this.btnPayTuition.TabIndex = 3;
            this.btnPayTuition.Text = "    Thanh Toán Học Phí";
            this.btnPayTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayTuition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayTuition.UseVisualStyleBackColor = false;
            this.btnPayTuition.Click += new System.EventHandler(this.btnPayTuition_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::WindowsFormsDevelopment.Properties.Resources.payment_white;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 327);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(237, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "    Test";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCourseSelection_Click);
            // 
            // fCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCourseRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Học Phần";
            this.Load += new System.EventHandler(this.fCourseRegistration_Load);
            this.SizeChanged += new System.EventHandler(this.fCourseRegistration_SizeChanged);
            this.pnlSideBar.ResumeLayout(false);
            this.flpSideBarBody.ResumeLayout(false);
            this.pnlSideBarBottom.ResumeLayout(false);
            this.pnlSideBarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSideBarHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.FlowLayoutPanel flpSideBarBody;
        private System.Windows.Forms.Panel pnlSideBarBottom;
        private System.Windows.Forms.Button btnStudentInfor;
        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.Button btnRegistrationResult;
        private System.Windows.Forms.Button btnPayTuition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInProgram;
        private System.Windows.Forms.Button btnOutProgram;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button button1;
    }
}

