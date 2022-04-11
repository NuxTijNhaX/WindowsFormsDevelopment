
namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form.Router
{
    partial class CreateSubjectClass
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
            this.lblShoolLevel = new System.Windows.Forms.Label();
            this.cbxSchoolLevel = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.cbxFaculty = new System.Windows.Forms.ComboBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cbxMajor = new System.Windows.Forms.ComboBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxPhase = new System.Windows.Forms.ComboBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbxLecturer = new System.Windows.Forms.ComboBox();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.pnlClassInformation = new System.Windows.Forms.Panel();
            this.lblClassInformation = new System.Windows.Forms.Label();
            this.pnlSubjectInformation = new System.Windows.Forms.Panel();
            this.lblSubjectInformation = new System.Windows.Forms.Label();
            this.pnlSubClass = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.cbxCampus = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.lblSubClass = new System.Windows.Forms.Label();
            this.btnCreate = new WindowsFormsDevelopment.CustomControls.RoundedButton();
            this.pnlFooter.SuspendLayout();
            this.pnlClassInformation.SuspendLayout();
            this.pnlSubjectInformation.SuspendLayout();
            this.pnlSubClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShoolLevel
            // 
            this.lblShoolLevel.AutoSize = true;
            this.lblShoolLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoolLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblShoolLevel.Location = new System.Drawing.Point(16, 34);
            this.lblShoolLevel.Name = "lblShoolLevel";
            this.lblShoolLevel.Size = new System.Drawing.Size(67, 20);
            this.lblShoolLevel.TabIndex = 0;
            this.lblShoolLevel.Text = "Bậc học:";
            // 
            // cbxSchoolLevel
            // 
            this.cbxSchoolLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchoolLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSchoolLevel.FormattingEnabled = true;
            this.cbxSchoolLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxSchoolLevel.Location = new System.Drawing.Point(99, 34);
            this.cbxSchoolLevel.Name = "cbxSchoolLevel";
            this.cbxSchoolLevel.Size = new System.Drawing.Size(350, 28);
            this.cbxSchoolLevel.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnCreate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 565);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(944, 71);
            this.pnlFooter.TabIndex = 21;
            // 
            // cbxFaculty
            // 
            this.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFaculty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFaculty.FormattingEnabled = true;
            this.cbxFaculty.Location = new System.Drawing.Point(99, 93);
            this.cbxFaculty.Name = "cbxFaculty";
            this.cbxFaculty.Size = new System.Drawing.Size(350, 28);
            this.cbxFaculty.TabIndex = 23;
            this.cbxFaculty.SelectedIndexChanged += new System.EventHandler(this.cbxFaculty_SelectedIndexChanged);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblFaculty.Location = new System.Drawing.Point(22, 96);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(49, 20);
            this.lblFaculty.TabIndex = 22;
            this.lblFaculty.Text = "Khoa:";
            // 
            // cbxMajor
            // 
            this.cbxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMajor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMajor.FormattingEnabled = true;
            this.cbxMajor.Location = new System.Drawing.Point(634, 50);
            this.cbxMajor.Name = "cbxMajor";
            this.cbxMajor.Size = new System.Drawing.Size(277, 28);
            this.cbxMajor.TabIndex = 25;
            this.cbxMajor.SelectedIndexChanged += new System.EventHandler(this.cbxMajor_SelectedIndexChanged);
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblMajor.Location = new System.Drawing.Point(498, 34);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(113, 20);
            this.lblMajor.TabIndex = 24;
            this.lblMajor.Text = "Chuyên ngành:";
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(634, 96);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(277, 28);
            this.cbxClass.TabIndex = 27;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblClass.Location = new System.Drawing.Point(498, 93);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 20);
            this.lblClass.TabIndex = 26;
            this.lblClass.Text = "Lớp:";
            // 
            // cbxPhase
            // 
            this.cbxPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhase.FormattingEnabled = true;
            this.cbxPhase.Location = new System.Drawing.Point(99, 70);
            this.cbxPhase.Name = "cbxPhase";
            this.cbxPhase.Size = new System.Drawing.Size(185, 28);
            this.cbxPhase.TabIndex = 35;
            this.cbxPhase.SelectedIndexChanged += new System.EventHandler(this.cbxPhase_SelectedIndexChanged);
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblPhase.Location = new System.Drawing.Point(16, 70);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(60, 20);
            this.lblPhase.TabIndex = 34;
            this.lblPhase.Text = "Học kỳ:";
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(99, 25);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(185, 28);
            this.cbxYear.TabIndex = 33;
            this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblYear.Location = new System.Drawing.Point(16, 25);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 20);
            this.lblYear.TabIndex = 32;
            this.lblYear.Text = "Năm học:";
            // 
            // cbxLecturer
            // 
            this.cbxLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLecturer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLecturer.FormattingEnabled = true;
            this.cbxLecturer.Location = new System.Drawing.Point(106, 41);
            this.cbxLecturer.Name = "cbxLecturer";
            this.cbxLecturer.Size = new System.Drawing.Size(185, 28);
            this.cbxLecturer.TabIndex = 31;
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblLecturer.Location = new System.Drawing.Point(16, 29);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(87, 20);
            this.lblLecturer.TabIndex = 30;
            this.lblLecturer.Text = "Giảng viên:";
            // 
            // cbxSubject
            // 
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(590, 26);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(185, 28);
            this.cbxSubject.TabIndex = 29;
            this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblSubject.Location = new System.Drawing.Point(510, 23);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(74, 20);
            this.lblSubject.TabIndex = 28;
            this.lblSubject.Text = "Môn học:";
            // 
            // pnlClassInformation
            // 
            this.pnlClassInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClassInformation.Controls.Add(this.lblShoolLevel);
            this.pnlClassInformation.Controls.Add(this.cbxSchoolLevel);
            this.pnlClassInformation.Controls.Add(this.lblFaculty);
            this.pnlClassInformation.Controls.Add(this.cbxFaculty);
            this.pnlClassInformation.Controls.Add(this.lblMajor);
            this.pnlClassInformation.Controls.Add(this.cbxMajor);
            this.pnlClassInformation.Controls.Add(this.lblClass);
            this.pnlClassInformation.Controls.Add(this.cbxClass);
            this.pnlClassInformation.Location = new System.Drawing.Point(3, 45);
            this.pnlClassInformation.Name = "pnlClassInformation";
            this.pnlClassInformation.Size = new System.Drawing.Size(938, 158);
            this.pnlClassInformation.TabIndex = 36;
            // 
            // lblClassInformation
            // 
            this.lblClassInformation.AutoSize = true;
            this.lblClassInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lblClassInformation.Location = new System.Drawing.Point(26, 32);
            this.lblClassInformation.Name = "lblClassInformation";
            this.lblClassInformation.Size = new System.Drawing.Size(123, 21);
            this.lblClassInformation.TabIndex = 28;
            this.lblClassInformation.Text = "Thông Tin Lớp:";
            // 
            // pnlSubjectInformation
            // 
            this.pnlSubjectInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSubjectInformation.Controls.Add(this.lblYear);
            this.pnlSubjectInformation.Controls.Add(this.lblSubject);
            this.pnlSubjectInformation.Controls.Add(this.cbxSubject);
            this.pnlSubjectInformation.Controls.Add(this.cbxYear);
            this.pnlSubjectInformation.Controls.Add(this.lblPhase);
            this.pnlSubjectInformation.Controls.Add(this.cbxPhase);
            this.pnlSubjectInformation.Location = new System.Drawing.Point(3, 215);
            this.pnlSubjectInformation.Name = "pnlSubjectInformation";
            this.pnlSubjectInformation.Size = new System.Drawing.Size(938, 127);
            this.pnlSubjectInformation.TabIndex = 37;
            // 
            // lblSubjectInformation
            // 
            this.lblSubjectInformation.AutoSize = true;
            this.lblSubjectInformation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lblSubjectInformation.Location = new System.Drawing.Point(7, 206);
            this.lblSubjectInformation.Name = "lblSubjectInformation";
            this.lblSubjectInformation.Size = new System.Drawing.Size(151, 20);
            this.lblSubjectInformation.TabIndex = 39;
            this.lblSubjectInformation.Text = "Thông Tin Môn Học:";
            // 
            // pnlSubClass
            // 
            this.pnlSubClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSubClass.Controls.Add(this.dtpEndDate);
            this.pnlSubClass.Controls.Add(this.dtpStartDate);
            this.pnlSubClass.Controls.Add(this.lblRoom);
            this.pnlSubClass.Controls.Add(this.cbxRoom);
            this.pnlSubClass.Controls.Add(this.lblCampus);
            this.pnlSubClass.Controls.Add(this.cbxCampus);
            this.pnlSubClass.Controls.Add(this.lblEndDate);
            this.pnlSubClass.Controls.Add(this.lblStartDate);
            this.pnlSubClass.Controls.Add(this.lblShift);
            this.pnlSubClass.Controls.Add(this.cbxShift);
            this.pnlSubClass.Controls.Add(this.lblLecturer);
            this.pnlSubClass.Controls.Add(this.cbxLecturer);
            this.pnlSubClass.Location = new System.Drawing.Point(3, 382);
            this.pnlSubClass.Name = "pnlSubClass";
            this.pnlSubClass.Size = new System.Drawing.Size(938, 177);
            this.pnlSubClass.TabIndex = 38;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(634, 129);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(277, 27);
            this.dtpEndDate.TabIndex = 43;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(634, 77);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(277, 27);
            this.dtpStartDate.TabIndex = 42;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblRoom.Location = new System.Drawing.Point(22, 127);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(58, 20);
            this.lblRoom.TabIndex = 40;
            this.lblRoom.Text = "Phòng:";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(106, 127);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(185, 28);
            this.cbxRoom.TabIndex = 41;
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblCampus.Location = new System.Drawing.Point(20, 74);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(51, 20);
            this.lblCampus.TabIndex = 38;
            this.lblCampus.Text = "Cơ sở:";
            // 
            // cbxCampus
            // 
            this.cbxCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampus.FormattingEnabled = true;
            this.cbxCampus.Location = new System.Drawing.Point(106, 82);
            this.cbxCampus.Name = "cbxCampus";
            this.cbxCampus.Size = new System.Drawing.Size(185, 28);
            this.cbxCampus.TabIndex = 39;
            this.cbxCampus.SelectedIndexChanged += new System.EventHandler(this.cbxCampus_SelectedIndexChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblEndDate.Location = new System.Drawing.Point(510, 122);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(111, 20);
            this.lblEndDate.TabIndex = 36;
            this.lblEndDate.Text = "Ngày kết thúc:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblStartDate.Location = new System.Drawing.Point(510, 77);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(107, 20);
            this.lblStartDate.TabIndex = 34;
            this.lblStartDate.Text = "Ngày bắt đầu:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblShift.Location = new System.Drawing.Point(510, 32);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(66, 20);
            this.lblShift.TabIndex = 32;
            this.lblShift.Text = "Giờ học:";
            // 
            // cbxShift
            // 
            this.cbxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShift.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(666, 29);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(185, 28);
            this.cbxShift.TabIndex = 33;
            // 
            // lblSubClass
            // 
            this.lblSubClass.AutoSize = true;
            this.lblSubClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lblSubClass.Location = new System.Drawing.Point(19, 366);
            this.lblSubClass.Name = "lblSubClass";
            this.lblSubClass.Size = new System.Drawing.Size(184, 20);
            this.lblSubClass.TabIndex = 40;
            this.lblSubClass.Text = "Thông Tin Lớp Học Phần:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(102, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(250, 40);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Tạo lớp học phần";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // CreateSubjectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblSubClass);
            this.Controls.Add(this.lblSubjectInformation);
            this.Controls.Add(this.pnlSubClass);
            this.Controls.Add(this.pnlSubjectInformation);
            this.Controls.Add(this.lblClassInformation);
            this.Controls.Add(this.pnlClassInformation);
            this.Controls.Add(this.pnlFooter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CreateSubjectClass";
            this.Size = new System.Drawing.Size(944, 636);
            this.pnlFooter.ResumeLayout(false);
            this.pnlClassInformation.ResumeLayout(false);
            this.pnlClassInformation.PerformLayout();
            this.pnlSubjectInformation.ResumeLayout(false);
            this.pnlSubjectInformation.PerformLayout();
            this.pnlSubClass.ResumeLayout(false);
            this.pnlSubClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShoolLevel;
        private System.Windows.Forms.ComboBox cbxSchoolLevel;
        private CustomControls.RoundedButton btnCreate;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ComboBox cbxFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cbxMajor;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxPhase;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbxLecturer;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Panel pnlClassInformation;
        private System.Windows.Forms.Label lblClassInformation;
        private System.Windows.Forms.Panel pnlSubjectInformation;
        private System.Windows.Forms.Panel pnlSubClass;
        private System.Windows.Forms.Label lblSubjectInformation;
        private System.Windows.Forms.Label lblSubClass;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.ComboBox cbxCampus;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cbxShift;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}
