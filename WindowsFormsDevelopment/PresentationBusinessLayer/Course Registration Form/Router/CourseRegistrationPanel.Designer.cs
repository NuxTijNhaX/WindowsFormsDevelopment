
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.CustomControls
{
    partial class CourseRegistrationPanel
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
            this.SuspendLayout();
            pnlHeader = new Panel();
            pnlBody = new Panel();
            dgvCourseTable = new DataGridView();
            colCourseNumber = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colOption = new DataGridViewTextBoxColumn();
            colCredit = new DataGridViewTextBoxColumn();
            colPrerequisiteCourse = new DataGridViewTextBoxColumn();
            colBtnStatus = new DataGridViewButtonColumn();

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
            dgvCourseTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseTable_CellClick);
                
            dgvCourseTable.Columns.AddRange(new DataGridViewColumn[] {
                colCourseNumber,
                colCourseName,
                colOption,
                colCredit,
                colPrerequisiteCourse,
                colBtnStatus,
            });

            colCourseNumber.HeaderText = "Mã học phần";
            colCourseNumber.Name = "colCourseNumber";
            colCourseNumber.ReadOnly = true;
            colCourseNumber.Width = dgvCourseTable.Width * 15 / 100;

            colCourseName.HeaderText = "Tên học phần";
            colCourseName.Name = "colCourseName";
            colCourseName.ReadOnly = true;
            colCourseName.Width = dgvCourseTable.Width * 30 / 100;

            colOption.HeaderText = "Nhóm tự chọn";
            colOption.Name = "colOption";
            colOption.ReadOnly = true;
            colOption.Width = dgvCourseTable.Width * 18 / 100;

            colCredit.HeaderText = "Học phần trước";
            colCredit.Name = "colCredit";
            colCredit.ReadOnly = true;
            colCredit.Width = dgvCourseTable.Width * 15 / 100;

            colPrerequisiteCourse.HeaderText = "Số tín chỉ";
            colPrerequisiteCourse.Name = "colPrerequisiteCourse";
            colPrerequisiteCourse.ReadOnly = true;
            colPrerequisiteCourse.Width = dgvCourseTable.Width * 10 / 100;

            colBtnStatus.HeaderText = "Trạng thái";
            colBtnStatus.Name = "colBtnStatus";
            colBtnStatus.ReadOnly = true;
            colBtnStatus.Width = dgvCourseTable.Width * 10 / 100;
            colBtnStatus.Text = "Đăng ký";

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
        private DataGridViewTextBoxColumn colCourseNumber;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colOption;
        private DataGridViewTextBoxColumn colCredit;
        private DataGridViewTextBoxColumn colPrerequisiteCourse;
        private DataGridViewButtonColumn colBtnStatus;
    }
}
