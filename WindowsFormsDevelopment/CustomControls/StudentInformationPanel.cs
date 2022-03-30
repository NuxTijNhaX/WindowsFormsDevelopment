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
                // BorderStyle = BorderStyle.FixedSingle,
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
            Label studentNumber = new Label()
            {
                Text = "MSSV:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, btnTitleStudentInfor.Height + btnTitleStudentInfor.Location.Y + labelMarginTop + 10),
            };

            Label studentName = new Label()
            {
                Text = "Họ và tên:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, studentNumber.Height + studentNumber.Location.Y + labelMarginTop),
            };

            Label studentStatus = new Label()
            {
                Text = "Tình trạng học:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, studentName.Height + studentName.Location.Y + labelMarginTop),
            };

            Label studentSchoolYear = new Label()
            {
                Text = "Niên khóa:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, studentStatus.Height + studentStatus.Location.Y + labelMarginTop),

            };

            Label studentEmail = new Label()
            {
                Text = "Email UEH:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, studentSchoolYear.Height + studentSchoolYear.Location.Y + labelMarginTop),

            };



            pnlHeader_StudentInfor.Controls.AddRange(new Control[]
            {
                btnTitleStudentInfor,
                studentNumber,
                studentName,
                studentStatus,
                studentSchoolYear,
                studentEmail,
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
            Label courseName = new Label()
            {
                Text = "Khóa học:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, btnTitleCourseInfor.Height + btnTitleCourseInfor.Location.Y + labelMarginTop + 10),
            };

            Label modeOfStudy = new Label()
            {
                Text = "Loại hình đào tạo:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, courseName.Height + courseName.Location.Y + labelMarginTop),
            };

            Label studentMajor = new Label()
            {
                Text = "Lớp sinh viên:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, modeOfStudy.Height + modeOfStudy.Location.Y + labelMarginTop),
            };

            pnlLeftSide.Controls.AddRange(new Control[]
            {
                btnTitleCourseInfor,
                courseName,
                modeOfStudy,
                studentMajor,
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
            Label studentContact = new Label()
            {
                Text = "Địa chỉ:",
                ForeColor = fCourseRegistration.orange,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", fontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(labelDiaphragm, btnTitleContact.Height + btnTitleContact.Location.Y + labelMarginTop + 10),
            };


            pnlRightSide.Controls.AddRange(new Control[]
            {
                btnTitleContact,
                studentContact,
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
