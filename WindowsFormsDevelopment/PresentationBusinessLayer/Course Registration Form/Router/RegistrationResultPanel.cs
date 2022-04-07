using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.CustomControls
{
    public partial class RegistrationResultPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private List<dynamic> subClasses { get; set; }

        public RegistrationResultPanel(Panel pnlBody, List<dynamic> subClasses)
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            
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
