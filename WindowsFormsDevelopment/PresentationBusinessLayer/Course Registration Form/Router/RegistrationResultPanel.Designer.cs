
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.CustomControls
{
    partial class RegistrationResultPanel
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
            pnlCancel = new Panel();
            pnlBody = new Panel();
            pnlFooter = new Panel();
            dgvCourseTable = new DataGridView();
            colClassNumber = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colShoolShift = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colStartingDate = new DataGridViewTextBoxColumn();
            colEndingDate = new DataGridViewTextBoxColumn();
            colCampus = new DataGridViewTextBoxColumn();
            colLecture = new DataGridViewTextBoxColumn();
            btnPay = new RoundedButton();
            btnCancel = new RoundedButton();
            lblTuiTionTotal = new DisabledRichTextBox();

            pnlHeader.Size = new Size(0, this.Height / 24);

            pnlBody.Size = new Size(this.Width, this.Height * 17 / 24);
            pnlBody.Location = new Point(0, this.Height / 24);
            pnlBody.Controls.AddRange(new Control[]
            {
                dgvCourseTable,
            });
            
            pnlCancel.Size = new Size(this.Width, this.Height * 2 / 24);
            pnlCancel.Location = new Point(0, pnlHeader.Height + pnlBody.Height);
            pnlCancel.Controls.AddRange(new Control[]
            {
                btnCancel,
            });

            pnlFooter.Size = new Size(this.Width, this.Height * 4 / 24);
            pnlFooter.Location = new Point(0, pnlHeader.Height + pnlCancel.Height + pnlBody.Height);
            pnlFooter.BorderStyle = BorderStyle.FixedSingle;
            pnlFooter.Controls.AddRange(new Control[]
            {
                btnPay,
                lblTuiTionTotal,
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

            btnCancel.Text = "Hủy lớp học phần";
            btnCancel.Width = this.Width / 5;
            btnCancel.Location = new Point(pnlCancel.Width - btnCancel.Width - 55, (pnlCancel.Height - btnCancel.Height) / 2);
            btnCancel.BackColor = fCourseRegistration.orange;
            btnCancel.FlatAppearance.BorderColor = fCourseRegistration.green;
            btnCancel.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnCancel.FlatAppearance.MouseOverBackColor = fCourseRegistration.orange;
            btnCancel.Click += btnCancel_Click;

            btnPay.Text = "Thanh Toán";
            btnPay.Location = new Point(pnlFooter.Width - btnPay.Width - 55, (pnlFooter.Height - btnPay.Height) / 2);
            btnPay.Click += btnPay_Click;

            lblTuiTionTotal.Font = fCourseRegistration.font11;
            lblTuiTionTotal.BorderStyle = BorderStyle.None;
            lblTuiTionTotal.BackColor = this.BackColor;
            lblTuiTionTotal.Location = new Point(pnlFooter.Width * 5 / 100, (pnlFooter.Height - btnPay.Height) / 2);
            lblTuiTionTotal.Size = new Size(pnlFooter.Width - btnPay.Width - lblTuiTionTotal.Location.X, btnPay.Height);
            lblTuiTionTotal.SelectionColor = fCourseRegistration.orange;
            lblTuiTionTotal.SelectedText = "Tổng học phí:  ";
            lblTuiTionTotal.SelectionColor = Color.Black;

            this.Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlBody,
                pnlCancel,
                pnlFooter,
            });
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlCancel;
        private Panel pnlBody;
        private Panel pnlFooter;
        private DataGridView dgvCourseTable;
        private DataGridViewTextBoxColumn colClassNumber;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colShoolShift;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colStartingDate;
        private DataGridViewTextBoxColumn colEndingDate;
        private DataGridViewTextBoxColumn colCampus;
        private DataGridViewTextBoxColumn colLecture;

        private RoundedButton btnPay;
        private RoundedButton btnCancel;
        private DisabledRichTextBox lblTuiTionTotal;
    }
}
