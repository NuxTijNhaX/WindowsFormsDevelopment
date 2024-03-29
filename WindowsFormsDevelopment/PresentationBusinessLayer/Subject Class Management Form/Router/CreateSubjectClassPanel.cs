﻿using System;
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

namespace WindowsFormsDevelopment.PresentationBusinessLayer.Subject_Class_Management_Form.Router
{
    public partial class CreateSubjectClassPanel : Panel
    {
        public Panel pnlParent { get; set; }

        public CreateSubjectClassPanel(Panel pnlBody)
        {
            this.pnlParent = pnlBody;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            InitializeComponent();

            ConfigUI();
        }

        private void ConfigUI()
        {
            int marginTop = this.Height * 3 / 100;
            int marginLeft = this.Width * 2 / 100;

            pnlClassInformation.Size = new Size(this.Width, this.Height * 25 / 100);
            pnlClassInformation.Location = new Point(0, marginTop);
            lblClassInformation.Location = new Point(pnlClassInformation.Width * 3 / 100, 
                pnlClassInformation.Location.Y - lblClassInformation.Height / 2);

            lblShoolLevel.Location = new Point(marginLeft, 
                (pnlClassInformation.Height / 2 - lblShoolLevel.Height) / 2);
            cbxSchoolLevel.Location = new Point(lblShoolLevel.Location.X + lblShoolLevel.Width, 
                lblShoolLevel.Location.Y);
            cbxSchoolLevel.Width = pnlClassInformation.Width / 2 - cbxSchoolLevel.Location.X - marginLeft;

            lblFaculty.Location = new Point(marginLeft, pnlClassInformation.Height / 2 + 
                (pnlClassInformation.Height / 2 - lblShoolLevel.Height) / 2);
            cbxFaculty.Location = new Point(lblFaculty.Location.X + lblFaculty.Width,
                lblFaculty.Location.Y);
            cbxFaculty.Width = pnlClassInformation.Width / 2 - cbxFaculty.Location.X - marginLeft;

            lblMajor.Location = new Point(marginLeft + pnlClassInformation.Width / 2,
                (pnlClassInformation.Height / 2 - lblMajor.Height) / 2);
            cbxMajor.Location = new Point(lblMajor.Location.X + lblMajor.Width, lblMajor.Location.Y);
            cbxMajor.Width = pnlClassInformation.Width - cbxMajor.Location.X - marginLeft;

            lblClass.Location = new Point(marginLeft + pnlClassInformation.Width / 2, pnlClassInformation.Height / 2 +
                (pnlClassInformation.Height / 2 - lblClass.Height) / 2);
            cbxClass.Location = new Point(lblClass.Location.X + lblClass.Width, lblClass.Location.Y);
            cbxClass.Width = pnlClassInformation.Width - cbxClass.Location.X - marginLeft;


            pnlSubjectInformation.Size = new Size(this.Width, this.Height * 20 / 100);
            pnlSubjectInformation.Location = new Point(0, marginTop * 2 + pnlClassInformation.Height);
            lblSubjectInformation.Location = new Point(pnlSubjectInformation.Width * 3 / 100,
                pnlSubjectInformation.Location.Y - lblSubjectInformation.Height / 2);

            lblYear.Location = new Point(marginLeft,
                (pnlSubjectInformation.Height / 2 - lblYear.Height) / 2);
            cbxYear.Location = new Point(lblYear.Location.X + lblYear.Width,
                lblYear.Location.Y);
            cbxYear.Width = pnlSubjectInformation.Width / 2 - cbxYear.Location.X - marginLeft;

            lblPhase.Location = new Point(marginLeft, pnlSubjectInformation.Height / 2 +
                (pnlSubjectInformation.Height / 2 - lblPhase.Height) / 2);
            cbxPhase.Location = new Point(lblPhase.Location.X + lblPhase.Width,
                lblPhase.Location.Y);
            cbxPhase.Width = pnlSubjectInformation.Width / 2 - cbxPhase.Location.X - marginLeft;

            lblSubject.Location = new Point(marginLeft + pnlSubjectInformation.Width / 2,
                (pnlSubjectInformation.Height - lblSubject.Height) / 2);
            cbxSubject.Location = new Point(lblSubject.Location.X + lblSubject.Width, lblSubject.Location.Y);
            cbxSubject.Width = pnlSubjectInformation.Width - cbxSubject.Location.X - marginLeft;


            pnlSubClass.Size = new Size(this.Width, this.Height * 33 / 100);
            pnlSubClass.Location = new Point(0, marginTop 
                + pnlSubjectInformation.Height + pnlSubjectInformation.Location.Y);
            lblSubClass.Location = new Point(pnlSubClass.Width * 3 / 100,
                pnlSubClass.Location.Y - lblSubClass.Height / 2);

            lblLecturer.Location = new Point(marginLeft,
                (pnlSubClass.Height / 3 - lblLecturer.Height) / 2);
            cbxLecturer.Location = new Point(lblLecturer.Location.X + lblLecturer.Width,
                lblLecturer.Location.Y);
            cbxLecturer.Width = pnlSubClass.Width / 2 - cbxLecturer.Location.X - marginLeft;

            lblCampus.Location = new Point(marginLeft, pnlSubClass.Height / 3 +
                (pnlSubClass.Height / 3 - lblCampus.Height) / 2);
            cbxCampus.Location = new Point(lblCampus.Location.X + lblCampus.Width,
                lblCampus.Location.Y);
            cbxCampus.Width = pnlSubClass.Width / 2 - cbxCampus.Location.X - marginLeft;

            lblRoom.Location = new Point(marginLeft, pnlSubClass.Height * 2 / 3 +
                (pnlSubClass.Height / 3 - lblRoom.Height) / 2);
            cbxRoom.Location = new Point(lblRoom.Location.X + lblRoom.Width,
                lblRoom.Location.Y);
            cbxRoom.Width = pnlSubClass.Width / 2 - cbxRoom.Location.X - marginLeft;

            lblShift.Location = new Point(marginLeft + pnlSubClass.Width / 2,
                (pnlSubClass.Height / 3 - lblShift.Height) / 2);
            cbxShift.Location = new Point(lblShift.Location.X + lblShift.Width,
                lblShift.Location.Y);
            cbxShift.Width = pnlSubClass.Width - cbxShift.Location.X - marginLeft;

            lblStartDate.Location = new Point(marginLeft + pnlSubClass.Width / 2,
                pnlSubClass.Height / 3 + (pnlSubClass.Height / 3 - lblStartDate.Height) / 2);
            dtpStartDate.Location = new Point(lblStartDate.Location.X + lblStartDate.Width,
                lblStartDate.Location.Y);
            dtpStartDate.Width = pnlSubClass.Width - dtpStartDate.Location.X - marginLeft;

            lblEndDate.Location = new Point(marginLeft + pnlSubClass.Width / 2,
                pnlSubClass.Height * 2 / 3 + (pnlSubClass.Height / 3 - lblEndDate.Height) / 2);
            dtpEndDate.Location = new Point(lblEndDate.Location.X + lblEndDate.Width,
                lblEndDate.Location.Y);
            dtpEndDate.Width = pnlSubClass.Width - dtpEndDate.Location.X - marginLeft;

            pnlFooter.Height = this.Height * 10 / 100;
            btnCreate.Location = new Point((pnlFooter.Width - btnCreate.Width) / 2,
                (pnlFooter.Height - btnCreate.Height) / 2);

            LoadShoolLevels();
            LoadFaculty();
            LoadYear();
            LoadSemester();
            LoadCampus();
            LoadShift();
        }

        private void LoadShift()
        {
            var shifts = ShiftDAL.GetShifts();
            cbxShift.DataSource = shifts;
            cbxShift.ValueMember = "Id";
            cbxShift.DisplayMember = "Description";
        }

        private void LoadRoom(string campusId)
        {
            var rooms = RoomDAL.GetRoom(campusId);
            cbxRoom.DataSource = rooms;
            cbxRoom.ValueMember = "Id";
            cbxRoom.DisplayMember = "Id";
        }

        private void LoadCampus()
        {
            var campuses = CampusDAL.GetAllCampuses();
            cbxCampus.DataSource = campuses;
            cbxCampus.ValueMember = "Id";
            cbxCampus.DisplayMember = "Id";

            // cbxCampus.SelectedIndex = 1;
        }
        
        private void LoadYear()
        {
            int curYear = DateTime.Now.Year;
            for (int i = 0; i < 7; i++)
            {
                cbxYear.Items.Add(curYear + i);
            }

            cbxYear.SelectedIndex = 0;
        }

        private void LoadSemester()
        {
            cbxPhase.DisplayMember = "Text";
            cbxPhase.ValueMember = "Value";

            string[] semesterInfor = new string[3] { "HKĐ", "HKG", "HKC" };
            for (int i = 0; i < semesterInfor.Length; i++)
            {
                cbxPhase.Items.Add(new { Text = i.ToString() + ": " + semesterInfor[i], Value = i });
            }

            cbxPhase.SelectedIndex = 0;
        }

        private void LoadShoolLevels()
        {
            var schoolLevels = SchoolLevelDAL.GetAllSchoolLevel();
            cbxSchoolLevel.DataSource = schoolLevels;
            cbxSchoolLevel.DisplayMember = "Name";
        }

        private void LoadFaculty()
        {
            var faculties = FacultyDAL.GetAllFaculty();
            cbxFaculty.DataSource = faculties;
            cbxFaculty.ValueMember = "Id";
            cbxFaculty.DisplayMember = "Name";
        }

        private void LoadMajor(string facultyId)
        {
            var majors = MajorDAL.GetMajors(facultyId);
            cbxMajor.DataSource = majors;
            cbxMajor.ValueMember = "Id";
            cbxMajor.DisplayMember = "Name";
        }

        private void LoadClass(string majorId)
        {
            var classes = ClassDAL.GetClasses(majorId);
            cbxClass.DataSource = classes;
            cbxClass.ValueMember = "Id";
            cbxClass.DisplayMember = "Id";
        }

        private void LoadLecturer(string subjecId)
        {
            try
            {
                var lecturers = LecturerDAL.GetLecturers(subjecId);
                cbxLecturer.DataSource = lecturers;
                cbxLecturer.ValueMember = "Id";
                cbxLecturer.DisplayMember = "FullName";
            }
            catch
            {
            }
            
        }

        private void LoadSubject()
        {
            string classId = (cbxClass.SelectedItem as Class).Id;

            var subjects = SubjectDAL.GetSubjects(classId);
            cbxSubject.DataSource = subjects;
            cbxSubject.ValueMember = "Id";
            cbxSubject.DisplayMember = "Name";
        }

        private void cbxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (cbxFaculty.SelectedItem as Faculty).Id;
            LoadMajor(id);
        }

        private void cbxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (cbxMajor.SelectedItem as Major).Id;
            LoadClass(id);
        }

        private void cbxCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (cbxCampus.SelectedItem as Campus).Id;
            LoadRoom(id);
        }

        private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (cbxSubject.SelectedItem as Subject).Id;
            LoadLecturer(id);
        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxPhase_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbxRoom.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int year = int.Parse(cbxYear.Text);
            int phase = (cbxPhase.SelectedItem as dynamic).Value;
            DateTime beginDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string classId = (cbxClass.SelectedItem as Class).Id;
            string lecturerId = (cbxLecturer.SelectedItem as User).Id;
            string roomId = (cbxRoom.SelectedItem as Room).Id;
            int shiftId = (cbxShift.SelectedItem as Shift).Id;
            string subjectId = (cbxSubject.SelectedItem as Subject).Id;
            int count = SubjectClassDAL.CountSubjectClass(subjectId, year, phase) + 1;
            string id = (year - 2000).ToString() + (phase == 0 ? "D" : phase == 1 ? "G" : "C") + "1" + subjectId + "0" + count.ToString();

            SubjectClass newSubClass = new SubjectClass()
            {
                Id = id,
                Year = year,
                Semester = phase,
                BeginDate = beginDate,
                EndDate = endDate,
                Class_Id = classId,
                LecturerId = lecturerId,
                Room_Id = roomId,
                Shift_Id = shiftId,
                Subject_Id = subjectId,
            };

            if (SubjectClassDAL.AddSubjectClass(newSubClass))
                MessageBox.Show("Thêm lớp học phần thành công", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công\n.Vui lòng thử lại sau", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateSubjectClass_SizeChanged(object sender, EventArgs e)
        {
            ConfigUI();
        }
    }
}
