using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.CustomControls;
using WindowsFormsDevelopment.DataAccessLayer;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    public partial class CourseSelectionPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private List<dynamic> subClasses { get; set; }

        public CourseSelectionPanel(Panel pnlBody, List<dynamic> subClasses)
        {
            pnlParent = pnlBody;
            this.subClasses = subClasses;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();

            LoadSubjectsData(this.subClasses);
        }

        private void LoadSubjectsData(List<dynamic> subClasses)
        {
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

        private void pbxBack_Click(object sender, EventArgs e)
        {
            fCourseRegistration.pnlBody.Controls.Clear();
            //CourseRegistrationPanel courseRegistration = 
            //    new CourseRegistrationPanel(this, 
            //    SubjectDAL.GetSubjectsInforByMajorProgram(fCourseRegistration.majorProgramId));
            fCourseRegistration.pnlBody.Controls.Add(fCourseRegistration.pnlContentBody); // TODO: change
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string classNumber = dgvCourseTable.SelectedRows[0].Cells["colClassNumber"].Value.ToString();
            MessageBox.Show(classNumber);
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
