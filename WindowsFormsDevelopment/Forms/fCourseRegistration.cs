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

namespace WindowsFormsDevelopment
{
    public partial class fCourseRegistration : Form
    {
        Color darkGreen = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
        Color orange = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));

        StudentInformation pnlStudentInformation;

        public fCourseRegistration()
        {
            InitializeComponent();

            ConfigUI();
        }

        // In-Contructor, PerformClick can't be consumed.

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

            btnInProgram.Visible = btnOutProgram.Visible = false;
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
                btn.BackColor = darkGreen;
            }

            button.BackColor = orange;
        }

        
        
        private void fCourseRegistration_SizeChanged(object sender, EventArgs e)
        {
            ConfigUI();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlStudentInformation = new StudentInformation(pnlBody);
            pnlBody.Controls.Add(pnlStudentInformation);
        }

        private void btnInProgram_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

        }

        private void btnOutProgram_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

        }

        private void btnRegistrationResult_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);

        }

        private void btnPayTuition_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            ChangeFocusColorButton((Button)sender, flpSideBarBody);
        }
    }
}
