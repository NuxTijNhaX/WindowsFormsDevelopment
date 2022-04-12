
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsDevelopment.CustomControls;

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form.Router
{
    partial class ManageSubjectClassPanel
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
            components = new System.ComponentModel.Container();

            pnlHeader = new Panel();
            pnlBody = new Panel();
            pnlCancel = new Panel();
            dgvCourseTable = new DataGridView();
            colClassNumber = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colShoolShift = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colStartingDate = new DataGridViewTextBoxColumn();
            colEndingDate = new DataGridViewTextBoxColumn();
            colCampus = new DataGridViewTextBoxColumn();
            colLecture = new DataGridViewTextBoxColumn();
            cbxClass = new ComboBox();
            lblClass = new System.Windows.Forms.Label();
            cbxSubject = new ComboBox();
            lblSubject = new System.Windows.Forms.Label();
            btnEdit = new RoundedButton();
            btnCancel = new RoundedButton();

            pnlHeader.Size = new Size(this.Width, this.Height * 10 / 100);
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.AddRange(new Control[]
            {
                cbxClass,
                cbxSubject,
                lblClass,
                lblSubject,
            });

            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.lblClass.Location = new System.Drawing.Point(498, 93);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 20);
            this.lblClass.TabIndex = 26;
            this.lblClass.Text = "Lớp:";

            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(634, 96);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(277, 28);
            this.cbxClass.TabIndex = 27;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            
            this.cbxSubject.DropDownHeight = 250;
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.IntegralHeight = false;
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

            pnlBody.Size = new Size(this.Width, this.Height * 80 / 100);
            pnlBody.Location = new Point(0, pnlHeader.Height);
            pnlBody.Controls.AddRange(new Control[]
            {
                dgvCourseTable,
            });

            pnlCancel.Size = new Size(this.Width, this.Height * 10 / 100);
            pnlCancel.Location = new Point(0, pnlHeader.Height + pnlBody.Height);
            pnlCancel.BorderStyle = BorderStyle.FixedSingle;
            pnlCancel.Controls.AddRange(new Control[]
            {
                btnEdit,
                btnCancel,
            });

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.Font = fCourseRegistration.font10;
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rowStyle.BackColor = Color.White;
            rowStyle.Font = fCourseRegistration.font10_Regular;
            rowStyle.ForeColor = Color.Black;
            rowStyle.SelectionBackColor = fCourseRegistration.green;
            rowStyle.SelectionForeColor = SystemColors.HighlightText;
            rowStyle.WrapMode = DataGridViewTriState.True;

            dgvCourseTable.Size = new Size(pnlBody.Width, pnlBody.Height);
            dgvCourseTable.RowHeadersVisible = false;
            dgvCourseTable.AllowUserToAddRows = false;
            dgvCourseTable.AllowUserToDeleteRows = false;
            dgvCourseTable.BackgroundColor = Color.White;
            dgvCourseTable.BorderStyle = BorderStyle.None;
            dgvCourseTable.ColumnHeadersHeight = 45;
            dgvCourseTable.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvCourseTable.RowsDefaultCellStyle = rowStyle;
            dgvCourseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourseTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCourseTable_RowsAdded);

            dgvCourseTable.Columns.AddRange(new DataGridViewColumn[] {
                colClassNumber,
                colCourseName,
                colShoolShift,
                colRoom,
                colStartingDate,
                colEndingDate,
                colCampus,
                colLecture
            });

            colClassNumber.HeaderText = "Mã lớp";
            colClassNumber.Name = "colClassNumber";
            colClassNumber.ReadOnly = true;
            colClassNumber.Width = dgvCourseTable.Width * 16 / 100;

            colCourseName.HeaderText = "Tên học phần";
            colCourseName.Name = "colCourseName";
            colCourseName.ReadOnly = true;
            colCourseName.Width = dgvCourseTable.Width * 25 / 100;

            colShoolShift.HeaderText = "Thứ - Giờ";
            colShoolShift.Name = "colShoolShift";
            colShoolShift.ReadOnly = true;
            colShoolShift.Width = dgvCourseTable.Width * 10 / 100;

            colRoom.HeaderText = "Phòng";
            colRoom.Name = "colRoom";
            colRoom.ReadOnly = true;
            colRoom.Width = dgvCourseTable.Width * 8 / 100;

            colStartingDate.HeaderText = "Ngày bắt đầu";
            colStartingDate.Name = "colStartingDate";
            colStartingDate.ReadOnly = true;
            colStartingDate.Width = dgvCourseTable.Width * 10 / 100;

            colEndingDate.HeaderText = "Ngày kết thúc";
            colEndingDate.Name = "colEndingDate";
            colEndingDate.ReadOnly = true;
            colEndingDate.Width = dgvCourseTable.Width * 10 / 100;

            colCampus.HeaderText = "Cơ sở";
            colCampus.Name = "colCampus";
            colCampus.ReadOnly = true;
            colCampus.Width = dgvCourseTable.Width * 5 / 100;

            colLecture.HeaderText = "Giảng viên";
            colLecture.Name = "colLecture";
            colLecture.ReadOnly = true;
            colLecture.Width = dgvCourseTable.Width * 16 / 100;

            btnEdit.Text = "Chỉnh sửa học phần";
            btnEdit.Width = this.Width / 5;
            btnEdit.Location = new Point(55, (pnlCancel.Height - btnEdit.Height) / 2);
            btnEdit.BackColor = fCourseRegistration.green;
            btnEdit.FlatAppearance.BorderColor = fCourseRegistration.green;
            btnEdit.FlatAppearance.CheckedBackColor = fCourseRegistration.green;
            // btnEdit.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnEdit.FlatAppearance.MouseOverBackColor = fCourseRegistration.green;
            btnEdit.Click += btnEdit_Click;

            btnCancel.Text = "Hủy lớp học phần";
            btnCancel.Width = this.Width / 5;
            btnCancel.Location = new Point(pnlCancel.Width - btnCancel.Width - 55, (pnlCancel.Height - btnCancel.Height) / 2);
            btnCancel.BackColor = fCourseRegistration.orange;
            btnCancel.FlatAppearance.BorderColor = fCourseRegistration.green;
            btnCancel.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnCancel.FlatAppearance.MouseOverBackColor = fCourseRegistration.orange;
            btnCancel.Click += btnCancel_Click;

            this.Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlBody,
                pnlCancel,
            });
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlCancel;
        private Panel pnlBody;

        private ComboBox cbxClass;
        private Label lblClass;
        private ComboBox cbxSubject;
        private Label lblSubject;

        private DataGridView dgvCourseTable;
        private DataGridViewTextBoxColumn colClassNumber;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colShoolShift;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colStartingDate;
        private DataGridViewTextBoxColumn colEndingDate;
        private DataGridViewTextBoxColumn colCampus;
        private DataGridViewTextBoxColumn colLecture;

        private RoundedButton btnEdit;
        private RoundedButton btnCancel;
    }
}
