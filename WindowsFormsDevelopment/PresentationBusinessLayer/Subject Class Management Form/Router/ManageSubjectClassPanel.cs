using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.DataAccessLayer;
using WindowsFormsDevelopment.DataTransferObject;

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form.Router
{
    public partial class ManageSubjectClassPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private Button btnReRender { get; set; }

        public ManageSubjectClassPanel(Panel pnlBody, Button btnRender)
        {
            this.pnlParent = pnlBody;
            this.btnReRender = btnRender;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();
            ConfigUI();
        }

        private void ConfigUI()
        {
            int marginLeft = this.Width * 2 / 100;

            lblClass.Location = new Point(marginLeft, 
                (pnlHeader.Height - lblClass.Height) / 2);
            cbxClass.Location = new Point(lblClass.Location.X + lblClass.Width, lblClass.Location.Y);
            cbxClass.Width = pnlHeader.Width / 2 - cbxClass.Location.X - marginLeft;

            lblSubject.Location = new Point(marginLeft + pnlHeader.Width / 2,
                (pnlHeader.Height - lblClass.Height) / 2);
            cbxSubject.Location = new Point(lblSubject.Location.X + lblSubject.Width, lblSubject.Location.Y);
            cbxSubject.Width = pnlHeader.Width - cbxSubject.Location.X - marginLeft;

            LoadClass();
        }

        private void LoadClass()
        {
            var classes = ClassDAL.GetClasses();
            cbxClass.DataSource = classes;
            cbxClass.ValueMember = "Id";
            cbxClass.DisplayMember = "Id";

            cbxClass.SelectedItem = 0;
        }

        private void LoadSubject(string classId)
        {
            var subjects = SubjectDAL.GetSubjects(classId);
            cbxSubject.DataSource = subjects;
            cbxSubject.ValueMember = "Id";
            cbxSubject.DisplayMember = "Name";
        }

        private void LoadSubjectsData(List<dynamic> subClasses)
        {
            dgvCourseTable.Rows.Clear();

            foreach (dynamic subClass in subClasses)
            {
                var row = new DataGridViewRow();
                var cellId = new DataGridViewTextBoxCell()
                {
                    Value = subClass.Id,
                };
                var cellName = new DataGridViewTextBoxCell()
                {
                    Value = subClass.Name,
                };
                var cellRoom = new DataGridViewTextBoxCell()
                {
                    Value = subClass.Room,
                };
                var cellBeginDate = new DataGridViewTextBoxCell()
                {
                    Value = subClass.BeginDate.ToString("dd/MM/yyyy"),
                };
                var cellEndDate = new DataGridViewTextBoxCell()
                {
                    Value = subClass.EndDate.ToString("dd/MM/yyyy"),
                };
                var cellShift = new DataGridViewTextBoxCell()
                {
                    Value = GetWeekdayFromDate(subClass.BeginDate) + "\n" + subClass.Shift,
                };
                var cellCampus = new DataGridViewTextBoxCell()
                {
                    Value = GetCampusFromRoomName(subClass.Room),
                };
                var cellLecturer = new DataGridViewTextBoxCell()
                {
                    Value = subClass.LecturerName,
                };

                row.Cells.AddRange(new DataGridViewCell[]
                {
                    cellId,
                    cellName,
                    cellShift,
                    cellRoom,
                    cellBeginDate,
                    cellEndDate,
                    cellCampus,
                    cellLecturer,
                });

                dgvCourseTable.Rows.Add(row);
            }
        }

        private string GetCampusFromRoomName(string roomName)
        {
            string campus;

            campus = roomName.Split('-')[0];

            return campus;
        }

        private string GetWeekdayFromDate(DateTime dateTime)
        {
            string weekday = "Thứ ";
            int indexEnumDateTime = (int)dateTime.DayOfWeek;

            if (indexEnumDateTime == 0) return "Chủ nhật";

            weekday += (indexEnumDateTime + 1).ToString();

            return weekday;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string classNumber;

            if (dgvCourseTable.RowCount > 0)
            {
                classNumber = dgvCourseTable.SelectedRows[0].Cells["colClassNumber"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa học phần này?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        if(!SubjectClassDAL.IsHavingStudentAttended(classNumber))
                        {
                            if (SubjectClassDAL.DeleteSubjectClass(classNumber))
                            {
                                MessageBox.Show("Xóa học phần thành công", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnReRender.PerformClick();
                            }
                            else
                                MessageBox.Show("Xóa học phần không thành công.\nVui lòng thử lại.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Học phần đã có người đăng ký.\nKhông xóa được.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được bảo trì", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classId = (cbxClass.SelectedItem as Class).Id;
            LoadSubject(classId);
        }

        private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classId = (cbxClass.SelectedItem as Class).Id;
            string subjectId = (cbxSubject.SelectedItem as Subject).Id;
            LoadSubjectsData(SubjectClassDAL.GetSubjectClasses(classId, subjectId));
        }

        private void dgvCourseTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCourseTable.Rows[e.RowIndex].Height = 40;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
