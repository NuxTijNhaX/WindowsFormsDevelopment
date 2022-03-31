using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDevelopment.CustomControls
{
    public partial class StudentInformationPanel : Panel
    {
        private float fontSize = 11.25F;

        public Panel pnlParent { get; set; }

        public StudentInformationPanel(Panel pnlBody)
        {
            InitializeComponent();

            pnlParent = pnlBody;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            CreateLayout();
        }

        public void CreateLayout()
        {
            #region Header
            Panel pnlHeader = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
            };

            #region Header Avatar
            Panel pnlHeader_Avatar = new Panel()
            {
                Width = pnlHeader.Width / 3,
                Height = pnlHeader.Height,
                // BorderStyle = BorderStyle.FixedSingle,
            };

            PictureBox pbxAvatar = new PictureBox()
            {
                Size = new Size((pnlHeader_Avatar.Height * 80 / 100) * 3 / 4, pnlHeader_Avatar.Height * 80 / 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            pbxAvatar.Location = new Point((pnlHeader_Avatar.Width - pbxAvatar.Width) / 2, (pnlHeader_Avatar.Height - pbxAvatar.Height) / 2);
            pbxAvatar.Load("https://student.ueh.edu.vn/HinhSV/31191025698.jpg");

            pnlHeader_Avatar.Controls.AddRange(new Control[]
            {
                pbxAvatar
            });
            #endregion

            #region Header Student Information
            Panel pnlHeader_StudentInfor = new Panel()
            {
                Width = pnlHeader.Width * 2 / 3,
                Height = pnlHeader.Height,
                Location = new Point(pnlHeader_Avatar.Width, 0),
            };

            Button btnTitleStudentInfor = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.student_infor,
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

            DisabledRichTextBox lblStudentNumber = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleStudentInfor.Height + btnTitleStudentInfor.Location.Y + labelMarginTop + 10),
            };
            lblStudentNumber.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentNumber.Location.X, btnTitleStudentInfor.Height);
            lblStudentNumber.SelectionColor = fCourseRegistration.orange;
            lblStudentNumber.SelectedText = "MSSV:  ";
            lblStudentNumber.SelectionColor = Color.Black;
            lblStudentNumber.SelectedText = "None"; // studentNumber

            DisabledRichTextBox lblStudentName = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentNumber.Height + lblStudentNumber.Location.Y + labelMarginTop),
            };
            lblStudentName.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentName.Location.X, btnTitleStudentInfor.Height);
            lblStudentName.SelectionColor = fCourseRegistration.orange;
            lblStudentName.SelectedText = "Họ và tên:  ";
            lblStudentName.SelectionColor = Color.Black;
            lblStudentName.SelectedText = "None"; // studentName

            DisabledRichTextBox lblStudentStatus = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentName.Height + lblStudentName.Location.Y + labelMarginTop),
            };
            lblStudentStatus.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentStatus.Location.X, btnTitleStudentInfor.Height);
            lblStudentStatus.SelectionColor = fCourseRegistration.orange;
            lblStudentStatus.SelectedText = "Tình trạng học:  ";
            lblStudentStatus.SelectionColor = Color.Black;
            lblStudentStatus.SelectedText = "None"; // studentStatus

            DisabledRichTextBox lblStudentSchoolYear = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None, // TODO: Change
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentStatus.Height + lblStudentStatus.Location.Y + labelMarginTop),
            };
            lblStudentSchoolYear.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentSchoolYear.Location.X, btnTitleStudentInfor.Height);
            lblStudentSchoolYear.SelectionColor = fCourseRegistration.orange;
            lblStudentSchoolYear.SelectedText = "Niên khóa:  ";
            lblStudentSchoolYear.SelectionColor = Color.Black;
            lblStudentSchoolYear.SelectedText = "None"; // studentSchoolYear

            DisabledRichTextBox lblStudentEmail = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None, 
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblStudentSchoolYear.Height + lblStudentSchoolYear.Location.Y + labelMarginTop),
            };
            lblStudentEmail.Size = new Size(pnlHeader_StudentInfor.Width - lblStudentEmail.Location.X, btnTitleStudentInfor.Height);
            lblStudentEmail.SelectionColor = fCourseRegistration.orange;
            lblStudentEmail.SelectedText = "Email UEH:  ";
            lblStudentEmail.SelectionColor = Color.Black;
            lblStudentEmail.SelectedText = "None"; // studentEmail

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
            Panel pnlLeftSide = new Panel()
            {
                Size = new Size(this.Width / 2, this.Height / 2),
                Location = new Point(0, this.Height / 2),
            };

            Button btnTitleCourseInfor = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.course,
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

            DisabledRichTextBox lblCourseName = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleCourseInfor.Height + btnTitleCourseInfor.Location.Y + labelMarginTop + 10),
            };
            lblCourseName.Size = new Size(pnlLeftSide.Width - lblCourseName.Location.X, btnTitleCourseInfor.Height);
            lblCourseName.SelectionColor = fCourseRegistration.orange;
            lblCourseName.SelectedText = "Khóa học:  ";
            lblCourseName.SelectionColor = Color.Black;
            lblCourseName.SelectedText = "None"; // courseName

            DisabledRichTextBox lblModeOfStudy = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblCourseName.Height + lblCourseName.Location.Y + labelMarginTop),
            };
            lblModeOfStudy.Size = new Size(pnlLeftSide.Width - lblModeOfStudy.Location.X, btnTitleCourseInfor.Height);
            lblModeOfStudy.SelectionColor = fCourseRegistration.orange;
            lblModeOfStudy.SelectedText = "Loại hình đào tạo:  ";
            lblModeOfStudy.SelectionColor = Color.Black;
            lblModeOfStudy.SelectedText = "None"; // modeOfStudy

            DisabledRichTextBox lblStudentMajor = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, lblModeOfStudy.Height + lblModeOfStudy.Location.Y + labelMarginTop),
            };
            lblStudentMajor.Size = new Size(pnlLeftSide.Width - lblStudentMajor.Location.X, btnTitleCourseInfor.Height);
            lblStudentMajor.SelectionColor = fCourseRegistration.orange;
            lblStudentMajor.SelectedText = "Lớp sinh viên:  ";
            lblStudentMajor.SelectionColor = Color.Black;
            lblStudentMajor.SelectedText = "None"; // studentMajor

            pnlLeftSide.Controls.AddRange(new Control[]
            {
                btnTitleCourseInfor,
                lblCourseName,
                lblModeOfStudy,
                lblStudentMajor,
            });
            #endregion

            #region Right Side
            Panel pnlRightSide = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
                Location = new Point(this.Width/2, this.Height / 2),
            };

            Button btnTitleContact = new Button()
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Arrow,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = fCourseRegistration.green,
                Image = Properties.Resources.address,
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

            DisabledRichTextBox lblStudentContact = new DisabledRichTextBox()
            {
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor,
                Location = new Point(labelDiaphragm, btnTitleContact.Height + btnTitleContact.Location.Y + labelMarginTop + 10),
            };
            lblStudentContact.Size = new Size(pnlLeftSide.Width - lblStudentContact.Location.X, btnTitleContact.Height);
            lblStudentContact.SelectionColor = fCourseRegistration.orange;
            lblStudentContact.SelectedText = "Địa chỉ:  ";
            lblStudentContact.SelectionColor = Color.Black;
            lblStudentContact.SelectedText = "None"; // studentContact

            pnlRightSide.Controls.AddRange(new Control[]
            {
                btnTitleContact,
                lblStudentContact,
            });

            #endregion

            this.Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlLeftSide,
                pnlRightSide
            });
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
