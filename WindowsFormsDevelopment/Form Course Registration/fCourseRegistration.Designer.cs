
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCourseRegistration));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.flpSideBarBody = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInProgram = new System.Windows.Forms.Button();
            this.btnOutProgram = new System.Windows.Forms.Button();
            this.pnlSideBarBottom = new System.Windows.Forms.Panel();
            this.pnlSideBarHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnStudentInfor = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.btnRegistrationResult = new System.Windows.Forms.Button();
            this.btnPayTuition = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlSideBar.SuspendLayout();
            this.flpSideBarBody.SuspendLayout();
            this.pnlSideBarBottom.SuspendLayout();
            this.pnlSideBarHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.flpSideBarBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSideBarBody.Location = new System.Drawing.Point(0, 118);
            this.flpSideBarBody.Name = "flpSideBarBody";
            this.flpSideBarBody.Size = new System.Drawing.Size(240, 448);
            this.flpSideBarBody.TabIndex = 2;
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
            this.btnOutProgram.Click += new System.EventHandler(this.btnOutProgram_Click);
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
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dataGridView1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(240, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(944, 636);
            this.pnlBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 636);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã học phần";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên học phần";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nhóm tự chọn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Học phần trước";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số tín chỉ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}

