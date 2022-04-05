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

        public CourseSelectionPanel(Panel pnlBody)
        {
            pnlParent = pnlBody;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            fCourseRegistration.pnlBody.Controls.Clear();
            //CourseRegistrationPanel courseRegistration = 
            //    new CourseRegistrationPanel(this, 
            //    SubjectDAL.GetSubjectsInforByMajorProgram(fCourseRegistration.majorProgramId));
            fCourseRegistration.pnlBody.Controls.Add(fCourseRegistration.pnlContentBody); // TODO: change
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
