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
using WindowsFormsDevelopment.Form_Course_Registration.Router;

namespace WindowsFormsDevelopment.CustomControls
{
    public partial class CourseRegistrationPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private List<dynamic> subjects { get; set; }
        private string subClassId { get; set; }
        private bool IsInProgram { get; set; }

        public CourseRegistrationPanel(Panel pnlBody, List<dynamic> subjects, bool isInprogram)
        {

            pnlParent = pnlBody;
            this.subjects = subjects;
            this.IsInProgram = isInprogram;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();

            LoadSubjectsData(this.subjects);
        }

        private void LoadSubjectsData(List<dynamic> subjects)
        {
            foreach (dynamic subject in subjects)
            {
                var row = new DataGridViewRow();
                var cellId = new DataGridViewTextBoxCell()
                {
                    Value = subject.Id,
                };
                var cellName = new DataGridViewTextBoxCell()
                {
                    Value = subject.Name,
                };
                var cellOption = new DataGridViewTextBoxCell()
                {
                    Value = HandleOptionGroup(subject.OptionGroup),
                };
                var cellPre = new DataGridViewTextBoxCell()
                {
                    Value = subject.PrerequisiteSubject,
                };
                var cellCredit = new DataGridViewTextBoxCell()
                {
                    Value = subject.Credit.ToString(),
                };

                this.subClassId = GradeSubjectClassDAL.CheckExistenceSubjectClass(subject.Id,
                    fCourseRegistration.studentId);

                var cellButton = new DataGridViewButtonCell()
                {
                    Value = subClassId != String.Empty ? "Đăng ký lại" : "Đăng ký"
                };

                row.Cells.AddRange(new DataGridViewCell[]
                {
                    cellId,
                    cellName,
                    cellOption,
                    cellPre,
                    cellCredit,
                    cellButton,
                });

                dgvCourseTable.Rows.Add(row);
            }
        }

        private string HandleOptionGroup(string opt)
        {
            string result = "";

            if(opt != null)
            {
                result = "Nhóm 0" + opt;
            }

            return result;
        }

        private bool CheckPrerequisiteSubjects(string[] prerequisiteSubjectIds)
        {
            bool result = true;

            foreach (var preSubId in prerequisiteSubjectIds)
            {
                if(!GradeSubjectClassDAL.CheckPrerequisiteSubject(preSubId, fCourseRegistration.studentId))
                    return false;
            }

            return result;
        }

        private void dgvCourseTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvCourseTable.Rows[e.RowIndex].Height = 35;
        }

        private void dgvCourseTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var preCourse = dgvCourseTable.Rows[e.RowIndex].Cells["colPrerequisiteCourse"].Value.ToString().Split(',');
                var courseNum = dgvCourseTable.Rows[e.RowIndex].Cells["colCourseNumber"].Value.ToString();
                this.subClassId = GradeSubjectClassDAL.CheckExistenceSubjectClass(courseNum,
                    fCourseRegistration.studentId);

                if (CheckPrerequisiteSubjects(preCourse))
                {
                    fCourseRegistration.pnlBody.Controls.Clear();
                    CourseSelectionPanel courseSelection = new CourseSelectionPanel(this, 
                        SubjectClassDAL.GetSubjectClasses(courseNum, fCourseRegistration.year, fCourseRegistration.phase), subClassId, IsInProgram);
                    fCourseRegistration.pnlBody.Controls.Add(courseSelection);

                } else
                {
                    MessageBox.Show("Bạn Không Đủ Điều Kiện Để Đăng Ký Học Phần Này.\nDo Không Đủ Điểm Ở Học Phần Trước.", "Thông Báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
