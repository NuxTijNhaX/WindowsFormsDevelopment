using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.CustomControls;
using WindowsFormsDevelopment.DataAccessLayer;
using WindowsFormsDevelopment.Form_Course_Registration.Router;
using WindowsFormsDevelopment.PresentationBusinessLayer.Login_Form;

namespace WindowsFormsDevelopment
{
    public partial class fCourseRegistration : Form
    {
        private string studentId;
        Form fLogin;
        Panel pnlContentBody;
        //StudentInformationPanel pnlStudentInformation;
        //CourseRegistrationPanel pnlCourseRegistration;
        //RegistrationResultPanel pnlRegistrationResult;
        //CourseSelectionPanel pnlCourseSelection;
        //TuitionPaymentPanel pnlTuitionPayment;

        public fCourseRegistration(string studentId, Form fLogin)
        {
            this.studentId = studentId;
            this.fLogin = fLogin;

            InitializeComponent();

            ConfigUI();
        }

        private void ConfigUI()
        {
            pnlSideBar.Width = this.Width / 5;
            pnlSideBarHeader.Height = this.Height / 5;
            pbxLogo.Size = new Size((pnlSideBarHeader.Height * 70 / 100) * 800 / 484, pnlSideBarHeader.Height * 70 / 100);
            pbxLogo.Location = new Point((pnlSideBarHeader.Width - pbxLogo.Width) / 2, (pnlSideBarHeader.Height - pbxLogo.Height) / 2);

            foreach (Button btn in flpSideBarBody.Controls)
            {
                btn.Padding = new Padding(flpSideBarBody.Width * 15 / 100, 0, 0, 0);
                btn.Width = flpSideBarBody.Width - btn.Margin.Right - 2;
            }
            btnExit.Padding = new Padding(flpSideBarBody.Width * 15 / 100, 0, 0, 0);
            btnExit.Width = flpSideBarBody.Width - btnExit.Margin.Right - 2;
        }

        private void ShowSubMenu()
        {
            if(btnInProgram.Visible)
                btnInProgram.Visible = btnOutProgram.Visible = false;
            else
                btnInProgram.Visible = btnOutProgram.Visible = true;
        }

        private void ChangeFocusColorButton(Button button, FlowLayoutPanel panel)
        {
            foreach (Button btn in panel.Controls)
            {
                btn.BackColor = green;
            }

            button.BackColor = orange;
        }

        private void RerenderSideBarBody(FlowLayoutPanel panel)
        {
            foreach (Button btn in panel.Controls)
            {
                if(btn.BackColor == orange)
                {
                    btn.PerformClick();
                }
            }
        }

        #region Event Handler
        private void fCourseRegistration_SizeChanged(object sender, EventArgs e)
        {
            ConfigUI();
            RerenderSideBarBody(flpSideBarBody);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fLogin.Show();
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContentBody = new StudentInformationPanel(pnlBody, 
                StudentDAL.GetStudentInfor(studentId));
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void btnInProgram_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContentBody = new CourseRegistrationPanel(pnlBody);
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void btnOutProgram_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContentBody = new CourseRegistrationPanel(pnlBody);
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void btnRegistrationResult_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContentBody = new RegistrationResultPanel(pnlBody);
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void btnCourseSelection_Click(object sender, EventArgs e) 
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);// TODO: change

            pnlContentBody = new CourseSelectionPanel(pnlBody);
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void btnPayTuition_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            //pnlStudentInformation = new StudentInformationPanel(pnlBody);
            //pnlBody.Controls.Add(pnlStudentInformation);


            pnlContentBody = new TuitionPaymentPanel(pnlBody);
            pnlBody.Controls.Add(pnlContentBody);
        }

        private void fCourseRegistration_Load(object sender, EventArgs e)
        {
            btnStudentInfor.PerformClick();
        }
        #endregion

    }
}
