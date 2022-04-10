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
using WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form;

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Login_Form
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            ConfigUI();
        }

        private void ConfigUI()
        {
            int marginTop = pnlBody.Height * 15 / 100;
            lblFormName.ForeColor = lblPass.ForeColor = lblUsername.ForeColor = fCourseRegistration.orange;
            // lblPass.Font = lblUsername.Font = tbxUsername.Font = tbxPass.Font = btnLogin.Font = fCourseRegistration.font12;
            tbxUsername.Focus();
            
            pnlHeader.Height = this.Height * 15 / 100;
            pbxLogo.Size = new Size((pnlHeader.Height * 70 / 100) * 800 / 484, pnlHeader.Height * 70 / 100);
            pbxLogo.Location = new Point((pnlHeader.Width - pbxLogo.Width) / 2, (pnlHeader.Height - pbxLogo.Height) / 2);

            lblFormName.Location = new Point((pnlBody.Width - lblFormName.Width) / 2, 
                (pnlBody.Height - lblFormName.Height - 3 * marginTop - lblUsername.Height - lblPass.Height - btnLogin.Height) / 2);
            tbxUsername.Width = tbxPass.Width = pnlBody.Width * 50 / 100;
            int totalWidth = lblUsername.Width + tbxUsername.Width;
            lblUsername.Location = new Point((pnlBody.Width - totalWidth) / 2, lblFormName.Location.Y + marginTop);
            tbxUsername.Location = new Point(lblUsername.Location.X + lblUsername.Width, lblUsername.Location.Y);
            totalWidth = lblPass.Width + tbxPass.Width;
            lblPass.Location = new Point((pnlBody.Width - totalWidth) / 2, lblUsername.Location.Y + marginTop);
            tbxPass.Location = new Point(lblPass.Location.X + lblPass.Width, lblPass.Location.Y);
            btnLogin.Width = this.Width * 30 / 100;
            btnLogin.Location = new Point((pnlBody.Width - btnLogin.Width) / 2, lblPass.Location.Y + marginTop);

            pnlFooter.Height = this.Height * 10 / 100;
        }

        private void fLogin_SizeChanged(object sender, EventArgs e)
        {
            ConfigUI();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbxUsername.Text) 
                || String.IsNullOrWhiteSpace(tbxPass.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] result = AccountDAL.GetAccessInfor(tbxUsername.Text.Trim(), tbxPass.Text);

            if(result[0] == "-1")
                MessageBox.Show("Sai Thông Tin Đăng Nhập\nVui Lòng Thử Lại", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (result[0] == "0")
            {
                this.Hide();
                fSubjectClassManagement f = new fSubjectClassManagement(result[1], this);
                f.ShowDialog();
            }
            else if (result[0] == "1")
            {
                
            }
            else if (result[0] == "2")
            {
                this.Hide();
                fCourseRegistration f = new fCourseRegistration(result[1], this);
                f.ShowDialog();
            }
        }

        private void tbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, null);
        }
    }
}
