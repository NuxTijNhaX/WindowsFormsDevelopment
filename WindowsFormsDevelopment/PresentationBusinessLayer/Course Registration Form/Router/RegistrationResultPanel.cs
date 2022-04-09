using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.DataAccessLayer;

namespace WindowsFormsDevelopment.CustomControls
{
    public partial class RegistrationResultPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private List<dynamic> subClasses { get; set; }
        private Button btnReRender { get; set; }
        private Button btnPaymentPage { get; set; }

        private int tuitionTotal;

        public RegistrationResultPanel(Panel pnlBody, List<dynamic> subClasses, Button btnRender, Button btnPaymentPage)
        {
            pnlParent = pnlBody;
            this.subClasses = subClasses;
            this.btnPaymentPage = btnPaymentPage;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();

            LoadSubjectsData(this.subClasses);

            LoadTuitionTotal();
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

        private void LoadTuitionTotal()
        {
            tuitionTotal = GradeSubjectClassDAL.GetTotalTuition(fCourseRegistration.studentId, fCourseRegistration.year,
                fCourseRegistration.phase, fCourseRegistration.fee);

            string money = "Không có khoản cần thanh toán";

            if (tuitionTotal != 0)
            {
                money = tuitionTotal.ToString("c", CultureInfo.CreateSpecificCulture("vi-VN"));
            }

            lblTuiTionTotal.SelectedText = money;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string classNumber;

            if (dgvCourseTable.RowCount > 0)
            {
                classNumber = dgvCourseTable.SelectedRows[0].Cells["colClassNumber"].Value.ToString();

                try
                {
                    if (GradeSubjectClassDAL.DeleteSubjectClass(classNumber, fCourseRegistration.studentId))
                    {
                        MessageBox.Show("Xóa học phần thành công", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnReRender.PerformClick();
                    }
                    else
                        MessageBox.Show("Xóa học phần không thành công.\nVui lòng thử lại.", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            btnPaymentPage.PerformClick();
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
