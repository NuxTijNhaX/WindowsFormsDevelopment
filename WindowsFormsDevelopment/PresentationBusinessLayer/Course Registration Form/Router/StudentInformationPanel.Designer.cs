
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.CustomControls
{
    partial class StudentInformationPanel
    {
        private const float fontSize = 11.25F;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            string studentNumber = studentInfor.Id;
            string studentName = studentInfor.Name;
            string studentStatus = "Còn học";
            string studentSchoolYear = studentInfor.Year.ToString() + 
                " - " + (studentInfor.Year + 4).ToString();
            string studentEmail = studentInfor.Email;

            string courseName = "K" + (studentInfor.Year - 1974).ToString();
            string modeOfStudy = studentInfor.MajorProgramName.Substring(0,
                studentInfor.MajorProgramName.LastIndexOf(" - "));
            string studentMajor = studentInfor.Major + " - " + studentInfor.ClassId;

            string studentPhoneNumber = studentInfor.PhoneNumber;
            string studentAddress = studentInfor.Address;

            fCourseRegistration.majorProgramId = studentInfor.MajorProgramId;

            #region Header
            pnlHeader = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
            };

            #region Header Avatar
            pnlHeader_Avatar = new Panel()
            {
                Width = pnlHeader.Width / 3,
                Height = pnlHeader.Height,
            };

            pbxAvatar = new PictureBox()
            {
                Size = new Size((pnlHeader_Avatar.Height * 80 / 100) * 3 / 4, pnlHeader_Avatar.Height * 80 / 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            pbxAvatar.Location = new Point((pnlHeader_Avatar.Width - pbxAvatar.Width) / 2, (pnlHeader_Avatar.Height - pbxAvatar.Height) / 2);
            pbxAvatar.Load($"https://student.ueh.edu.vn/HinhSV/{studentInfor.Id}.jpg");

            pnlHeader_Avatar.Controls.AddRange(new Control[]
            {
                    pbxAvatar
            });
            #endregion

            #region Header Student Information
            pnlHeader_StudentInfor = new Panel()
            {
                Width = pnlHeader.Width * 2 / 3,
                Height = pnlHeader.Height,
                Location = new Point(pnlHeader_Avatar.Width, 0),
            };

            btnTitleStudentInfor = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = fCourseRegistration.font12,
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.user_green,
                ImageAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Text = "    Thông Tin Sinh Viên",
                TextAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                UseVisualStyleBackColor = false,
                Location = new Point(pnlHeader_StudentInfor.Width * 10 / 100, pnlHeader_StudentInfor.Height * 15 / 100),
            };
            btnTitleStudentInfor.FlatAppearance.BorderColor = this.BackColor;
            btnTitleStudentInfor.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnTitleStudentInfor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTitleStudentInfor.FlatAppearance.MouseOverBackColor = Color.Transparent;

            int labelDiaphragm = btnTitleStudentInfor.Location.X + btnTitleStudentInfor.Width * 50 / 100;
            int labelMarginTop = pnlHeader_StudentInfor.Height * 5 / 100;

            lblStudentNumber = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleStudentInfor.Height + btnTitleStudentInfor.Location.Y + labelMarginTop + 10),
            };
            lblStudentNumber.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentNumber.Location.X, btnTitleStudentInfor.Height);
            lblStudentNumber.SelectionColor = fCourseRegistration.orange;
            lblStudentNumber.SelectedText = "MSSV:  ";
            lblStudentNumber.SelectionColor = Color.Black;
            lblStudentNumber.SelectedText = studentNumber;

            lblStudentName = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentNumber.Height + lblStudentNumber.Location.Y + labelMarginTop),
            };
            lblStudentName.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentName.Location.X, btnTitleStudentInfor.Height);
            lblStudentName.SelectionColor = fCourseRegistration.orange;
            lblStudentName.SelectedText = "Họ và tên:  ";
            lblStudentName.SelectionColor = Color.Black;
            lblStudentName.SelectedText = studentName;

            lblStudentStatus = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentName.Height + lblStudentName.Location.Y + labelMarginTop),
            };
            lblStudentStatus.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentStatus.Location.X, btnTitleStudentInfor.Height);
            lblStudentStatus.SelectionColor = fCourseRegistration.orange;
            lblStudentStatus.SelectedText = "Tình trạng học:  ";
            lblStudentStatus.SelectionColor = Color.Black;
            lblStudentStatus.SelectedText = studentStatus;

            lblStudentSchoolYear = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentStatus.Height + lblStudentStatus.Location.Y + labelMarginTop),
            };
            lblStudentSchoolYear.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentSchoolYear.Location.X, btnTitleStudentInfor.Height);
            lblStudentSchoolYear.SelectionColor = fCourseRegistration.orange;
            lblStudentSchoolYear.SelectedText = "Niên khóa:  ";
            lblStudentSchoolYear.SelectionColor = Color.Black;
            lblStudentSchoolYear.SelectedText = studentSchoolYear;

            lblStudentEmail = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentSchoolYear.Height + lblStudentSchoolYear.Location.Y + labelMarginTop),
            };
            lblStudentEmail.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentEmail.Location.X, btnTitleStudentInfor.Height);
            lblStudentEmail.SelectionColor = fCourseRegistration.orange;
            lblStudentEmail.SelectedText = "Email UEH:  ";
            lblStudentEmail.SelectionColor = Color.Black;
            lblStudentEmail.SelectedText = studentEmail;

            pnlHeader_StudentInfor.Controls.AddRange(new Control[]
            {
                    btnTitleStudentInfor,
                    lblStudentNumber,
                    lblStudentName,
                    lblStudentStatus,
                    lblStudentSchoolYear,
                    lblStudentEmail,
            });
            #endregion

            pnlHeader.Controls.AddRange(new Control[]
            {
                    pnlHeader_Avatar,
                    pnlHeader_StudentInfor,
            });
            #endregion

            #region Left Side
            pnlLeftSide = new Panel()
            {
                Size = new Size(this.Width / 2, this.Height / 2),
                Location = new Point(0, this.Height / 2),
            };

            btnTitleCourseInfor = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = fCourseRegistration.font12,
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.course_green,
                ImageAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Text = "    Thông Tin Khóa Học",
                TextAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                UseVisualStyleBackColor = false,
                Location = new Point(pnlLeftSide.Width * 5 / 100, pnlLeftSide.Height * 15 / 100),
            };
            btnTitleCourseInfor.FlatAppearance.BorderColor = this.BackColor;
            btnTitleCourseInfor.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnTitleCourseInfor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTitleCourseInfor.FlatAppearance.MouseOverBackColor = Color.Transparent;

            labelDiaphragm = btnTitleCourseInfor.Location.X + btnTitleCourseInfor.Width * 50 / 100;
            labelMarginTop = pnlLeftSide.Height * 5 / 100;

            lblCourseName = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleCourseInfor.Height + btnTitleCourseInfor.Location.Y + labelMarginTop + 10),
            };
            lblCourseName.Size = new Size(pnlLeftSide.Width - lblCourseName.Location.X, btnTitleCourseInfor.Height);
            lblCourseName.SelectionColor = fCourseRegistration.orange;
            lblCourseName.SelectedText = "Khóa học:  ";
            lblCourseName.SelectionColor = Color.Black;
            lblCourseName.SelectedText = courseName;

            lblModeOfStudy = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblCourseName.Height + lblCourseName.Location.Y + labelMarginTop),
            };
            lblModeOfStudy.Size = new Size(pnlLeftSide.Width - lblModeOfStudy.Location.X, btnTitleCourseInfor.Height);
            lblModeOfStudy.SelectionColor = fCourseRegistration.orange;
            lblModeOfStudy.SelectedText = "Loại hình đào tạo:  ";
            lblModeOfStudy.SelectionColor = Color.Black;
            lblModeOfStudy.SelectedText = modeOfStudy;

            lblStudentMajor = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblModeOfStudy.Height + lblModeOfStudy.Location.Y + labelMarginTop),
            };
            lblStudentMajor.Size = new Size(pnlLeftSide.Width - lblStudentMajor.Location.X, btnTitleCourseInfor.Height * 2);
            lblStudentMajor.SelectionColor = fCourseRegistration.orange;
            lblStudentMajor.SelectedText = "Lớp sinh viên:  ";
            lblStudentMajor.SelectionColor = Color.Black;
            lblStudentMajor.SelectedText = studentMajor;

            pnlLeftSide.Controls.AddRange(new Control[]
            {
                btnTitleCourseInfor,
                lblCourseName,
                lblModeOfStudy,
                lblStudentMajor,
            });
            #endregion

            #region Right Side
            pnlRightSide = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
                Location = new Point(this.Width / 2, this.Height / 2),
            };

            btnTitleContact = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = fCourseRegistration.font12,
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.address_green,
                ImageAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Text = "    Thông Tin Liên Lạc",
                TextAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                UseVisualStyleBackColor = false,
                Location = new Point(pnlRightSide.Width * 5 / 100, pnlRightSide.Height * 15 / 100),
            };
            btnTitleContact.FlatAppearance.BorderColor = this.BackColor;
            btnTitleContact.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnTitleContact.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTitleContact.FlatAppearance.MouseOverBackColor = Color.Transparent;

            labelDiaphragm = btnTitleContact.Location.X + btnTitleContact.Width * 50 / 100;
            labelMarginTop = pnlRightSide.Height * 5 / 100;

            lblStudentPhoneNumber = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleContact.Height + btnTitleContact.Location.Y + labelMarginTop + 10),
            };
            lblStudentPhoneNumber.Size = new Size(pnlLeftSide.Width - lblStudentPhoneNumber.Location.X, btnTitleContact.Height);
            lblStudentPhoneNumber.SelectionColor = fCourseRegistration.orange;
            lblStudentPhoneNumber.SelectedText = "Số điện thoại:  ";
            lblStudentPhoneNumber.SelectionColor = Color.Black;
            lblStudentPhoneNumber.SelectedText = studentPhoneNumber;

            lblStudentAddress = new DisabledRichTextBox()
            {
                Font = fCourseRegistration.font11,
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentPhoneNumber.Height + lblStudentPhoneNumber.Location.Y + labelMarginTop),
            };
            lblStudentAddress.Size = new Size(pnlLeftSide.Width - lblStudentAddress.Location.X, btnTitleContact.Height);
            lblStudentAddress.SelectionColor = fCourseRegistration.orange;
            lblStudentAddress.SelectedText = "Địa chỉ:  ";
            lblStudentAddress.SelectionColor = Color.Black;
            lblStudentAddress.SelectedText = studentAddress;

            pnlRightSide.Controls.AddRange(new Control[]
            {
                btnTitleContact,
                lblStudentPhoneNumber,
                lblStudentAddress,
            });

            #endregion

            this.Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlLeftSide,
                pnlRightSide
            });
        }

        #endregion

        private Panel pnlHeader;

        private Panel pnlHeader_Avatar;
        private PictureBox pbxAvatar;

        private Panel pnlHeader_StudentInfor;
        private Button btnTitleStudentInfor;
        private DisabledRichTextBox lblStudentNumber;
        private DisabledRichTextBox lblStudentName;
        private DisabledRichTextBox lblStudentStatus;
        private DisabledRichTextBox lblStudentSchoolYear;
        private DisabledRichTextBox lblStudentEmail;

        private Panel pnlRightSide;
        private Button btnTitleCourseInfor;
        private DisabledRichTextBox lblCourseName;
        private DisabledRichTextBox lblModeOfStudy;
        private DisabledRichTextBox lblStudentMajor;

        private Panel pnlLeftSide;
        private Button btnTitleContact;
        private DisabledRichTextBox lblStudentPhoneNumber;
        private DisabledRichTextBox lblStudentAddress;
    }
}
