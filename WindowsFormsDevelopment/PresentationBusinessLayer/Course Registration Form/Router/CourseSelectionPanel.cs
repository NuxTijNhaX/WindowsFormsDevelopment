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
        private string subClassId { get; set; }
        private bool IsInProgram { get; set; }

        public CourseSelectionPanel(Panel pnlBody, List<dynamic> subClasses, 
            string subClassId, bool isInprogram)
        {
            pnlParent = pnlBody;
            this.subClasses = subClasses;
            this.subClassId = subClassId;
            this.IsInProgram = isInprogram;

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

        private void Back()
        {
            fCourseRegistration.pnlBody.Controls.Clear();

            CourseRegistrationPanel courseRegistration;

            if (IsInProgram)
                courseRegistration = new CourseRegistrationPanel(this,
                SubjectDAL.GetSubjectsInforByMajorProgram(fCourseRegistration.majorProgramId,
                fCourseRegistration.semester), true);
            else
                courseRegistration = new CourseRegistrationPanel(this,
                    SubjectDAL.GetSubjectsInforByUnPassList(
                        GradeSubjectClassDAL.GetUnPassSubjects(fCourseRegistration.studentId),
                        fCourseRegistration.majorProgramId), false);

            fCourseRegistration.pnlBody.Controls.Add(courseRegistration);
        }
        
        private void pbxBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string classNumber = dgvCourseTable.SelectedRows[0].Cells["colClassNumber"].Value.ToString();
            string messageResult = "";

            if(this.subClassId == String.Empty)
            {
                try
                {
                    if (GradeSubjectClassDAL.RegisterSubjectClass(classNumber, fCourseRegistration.studentId))
                    {
                        messageResult = "Đăng ký thành công.";
                        Back();
                    }
                    else
                    {
                        messageResult = "Đã có lỗi xảy ra!\n";
                    }
                }
                catch (Exception ex)
                {
                    messageResult += ex.Message;
                }
                finally
                {
                    MessageBox.Show(messageResult, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (classNumber == this.subClassId)
                {
                    MessageBox.Show("Bạn đã đăng ký học phần này rồi!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc đăng ký lại học phần này?", "Thông báo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        if (GradeSubjectClassDAL.ReRegisterSubjectClass(this.subClassId, classNumber, fCourseRegistration.studentId))
                        {
                            messageResult = "Đăng ký thành công.";
                            MessageBox.Show(messageResult, "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Back();
                        }
                        else
                        {
                            messageResult = "Đã có lỗi xảy ra!\nVui lòng thử lại.";
                            MessageBox.Show(messageResult, "Thông Báo Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                }
                catch (Exception ex)
                {
                    messageResult += ex.Message;

                    MessageBox.Show(messageResult, "Thông Báo Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
