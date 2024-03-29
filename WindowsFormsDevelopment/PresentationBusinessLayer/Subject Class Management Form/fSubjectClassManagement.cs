﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form.Router;

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form
{
    public partial class fSubjectClassManagement : Form
    {
        public static string lecturerId;
        private Control pnlContent;
        Form fLogin;

        public fSubjectClassManagement(string lecId, Form fLogin)
        {
            lecturerId = lecId;
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
                if (btn.BackColor == orange)
                {
                    btn.PerformClick();
                }
            }
        }

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContent = new CreateSubjectClassPanel(pnlBody);
            pnlBody.Controls.Add(pnlContent);
        }

        private void btnSubjectClassManagement_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            ChangeFocusColorButton((Button)sender, flpSideBarBody);

            pnlContent = new ManageSubjectClassPanel(pnlBody, btnSubjectClassManagement);
            pnlBody.Controls.Add(pnlContent);
        }

        private void fSubjectClassManagement_Load(object sender, EventArgs e)
        {
            btnCreateSubjectClass.PerformClick();
        }

        private void fSubjectClassManagement_SizeChanged(object sender, EventArgs e)
        {
            ConfigUI();
            RerenderSideBarBody(flpSideBarBody);
        }
    }
}
