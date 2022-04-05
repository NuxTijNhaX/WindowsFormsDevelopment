using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.DataTransferObject;
using WindowsFormsDevelopment.Form_Course_Registration.Router;

namespace WindowsFormsDevelopment.CustomControls
{
    public partial class CourseRegistrationPanel : Panel
    {
        public Panel pnlParent { get; set; }
        private List<dynamic> subjects { get; set; }

        public CourseRegistrationPanel(Panel pnlBody, List<dynamic> subjects)
        {

            pnlParent = pnlBody;
            this.subjects = subjects;

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
                    Value = handleOptionGroup(subject.OptionGroup),
                };
                var cellPre = new DataGridViewTextBoxCell()
                {
                    Value = subject.PrerequisiteSubject,
                };
                var cellCredit = new DataGridViewTextBoxCell()
                {
                    Value = subject.Credit.ToString(),
                };
                var cellButton = new DataGridViewButtonCell()
                {
                    Value = "Đăng ký",
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

        private string handleOptionGroup(string opt)
        {
            string result = "";

            if(opt != null)
            {
                result = "Nhóm 0" + opt;
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
                var courseNum = dgvCourseTable.Rows[e.RowIndex].Cells["colCourseNumber"].Value;
                
                fCourseRegistration.pnlBody.Controls.Clear();
                CourseSelectionPanel courseSelection = new CourseSelectionPanel(this);
                fCourseRegistration.pnlBody.Controls.Add(courseSelection);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
