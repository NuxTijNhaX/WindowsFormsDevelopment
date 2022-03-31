
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    partial class CourseSelectionPanel
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

            this.SuspendLayout();
            pnlHeader = new Panel();
            pnlBody = new Panel();
            dgvCourseTable = new DataGridView();
            colClassNumber = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colShoolShift = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colStartingDate = new DataGridViewTextBoxColumn();
            colEndingDate = new DataGridViewTextBoxColumn();
            colCampus = new DataGridViewTextBoxColumn();
            colLecture = new DataGridViewTextBoxColumn();

            pnlHeader.Size = new Size(this.Width, this.Height / 12);

            pnlBody.Size = new Size(this.Width, this.Height * 11 / 12);
            pnlBody.Location = new Point(0, pnlHeader.Height);
            pnlBody.Controls.AddRange(new Control[]
            {
                dgvCourseTable,
            });

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.Font = fCourseRegistration.font10;
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;

            dgvCourseTable.Size = new Size(pnlBody.Width, pnlBody.Height);
            dgvCourseTable.RowHeadersVisible = false;
            dgvCourseTable.AllowUserToAddRows = false;
            dgvCourseTable.AllowUserToDeleteRows = false;
            dgvCourseTable.BackgroundColor = Color.White;
            dgvCourseTable.BorderStyle = BorderStyle.None;
            dgvCourseTable.ColumnHeadersHeight = 45;
            dgvCourseTable.ColumnHeadersDefaultCellStyle = headerStyle;

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
            colClassNumber.Width = dgvCourseTable.Width * 12 / 100;

            colCourseName.HeaderText = "Tên học phần";
            colCourseName.Name = "colCourseName";
            colCourseName.ReadOnly = true;
            colCourseName.Width = dgvCourseTable.Width * 25 / 100;

            colShoolShift.HeaderText = "Thứ - Giờ";
            colShoolShift.Name = "colShoolShift";
            colShoolShift.ReadOnly = true;
            colShoolShift.Width = dgvCourseTable.Width * 11 / 100;

            colRoom.HeaderText = "Phòng";
            colRoom.Name = "colRoom";
            colRoom.ReadOnly = true;
            colRoom.Width = dgvCourseTable.Width * 8 / 100;

            colStartingDate.HeaderText = "Ngày bắt đầu";
            colStartingDate.Name = "colStartingDate";
            colStartingDate.ReadOnly = true;
            colStartingDate.Width = dgvCourseTable.Width * 12 / 100;

            colEndingDate.HeaderText = "Ngày kết thúc";
            colEndingDate.Name = "colEndingDate";
            colEndingDate.ReadOnly = true;
            colEndingDate.Width = dgvCourseTable.Width * 12 / 100;

            colCampus.HeaderText = "Cơ sở";
            colCampus.Name = "colCampus";
            colCampus.ReadOnly = true;
            colCampus.Width = dgvCourseTable.Width * 5 / 100;

            colLecture.HeaderText = "Giảng viên";
            colLecture.Name = "colLecture";
            colLecture.ReadOnly = true;
            colLecture.Width = dgvCourseTable.Width * 15 / 100;

            this.Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlBody,
            });
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlBody;
        private DataGridView dgvCourseTable;
        private DataGridViewTextBoxColumn colClassNumber;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colShoolShift;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colStartingDate;
        private DataGridViewTextBoxColumn colEndingDate;
        private DataGridViewTextBoxColumn colCampus;
        private DataGridViewTextBoxColumn colLecture;
    }
}
