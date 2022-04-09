
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsDevelopment.CustomControls;

namespace WindowsFormsDevelopment.Form_Course_Registration.Router
{
    partial class UnpaidTuitionPanel
    {
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
            string studentNumber = studentInfor.Id;
            string studentName = studentInfor.Name;
            string studentClass = studentInfor.ClassId;
            string studentMajor = studentInfor.Major;
            
            description = "HK" + (fCourseRegistration.phase == 0 ? "Đ" : fCourseRegistration.phase == 1 ? "G" : "C") + " - " + fCourseRegistration.year.ToString();

            components = new System.ComponentModel.Container();

            lblTuitionTotal = new Button();
            lblPaymentInformation = new Button();
            lblPaymentMethod = new Button();
            lblStudentNumber = new DisabledRichTextBox();
            lblStudentName = new DisabledRichTextBox();
            lblSutentClass = new DisabledRichTextBox();
            lblStudentMajor = new DisabledRichTextBox();
            lblPaymentInfor = new DisabledRichTextBox();
            lblTuitionAmount = new Label();
            rbnMomo = new RadioButton();
            rbnOcb = new RadioButton();
            rbnPaypal = new RadioButton();
            btnPay = new RoundedButton();

            lblTuitionTotal.BackColor = Color.Transparent;
            lblTuitionTotal.Cursor = Cursors.Arrow;
            lblTuitionTotal.FlatStyle = FlatStyle.Flat;
            lblTuitionTotal.Font = fCourseRegistration.font12;
            lblTuitionTotal.ForeColor = fCourseRegistration.green;
            lblTuitionTotal.Image = Properties.Resources.money_green;
            lblTuitionTotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTuitionTotal.AutoSize = true;
            lblTuitionTotal.Text = "    Tổng tiền cần thanh toán";
            lblTuitionTotal.TextAlign = ContentAlignment.MiddleLeft;
            lblTuitionTotal.TextImageRelation = TextImageRelation.ImageBeforeText;
            lblTuitionTotal.UseVisualStyleBackColor = false;
            lblTuitionTotal.Location = new Point(this.Width * 5 / 100, this.Height * 5 / 100);
            lblTuitionTotal.FlatAppearance.BorderColor = this.BackColor;
            lblTuitionTotal.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            lblTuitionTotal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lblTuitionTotal.FlatAppearance.MouseOverBackColor = Color.Transparent;

            int labelDiaphragm = lblTuitionTotal.Location.X + lblTuitionTotal.Width * 50 / 100;
            int labelMarginTop = 10;

            lblTuitionAmount.Text = "None";
            lblTuitionAmount.Font = fCourseRegistration.font11;
            lblTuitionAmount.AutoSize = true;
            lblTuitionAmount.Location = new Point(labelDiaphragm, lblTuitionTotal.Height + lblTuitionTotal.Location.Y + labelMarginTop + 5);
            lblTuitionAmount.ForeColor = fCourseRegistration.orange;

            lblPaymentInformation.BackColor = Color.Transparent;
            lblPaymentInformation.Cursor = Cursors.Arrow;
            lblPaymentInformation.FlatStyle = FlatStyle.Flat;
            lblPaymentInformation.Font = fCourseRegistration.font12;
            lblPaymentInformation.ForeColor = fCourseRegistration.green;
            lblPaymentInformation.Image = Properties.Resources.payment_information_green;
            lblPaymentInformation.ImageAlign = ContentAlignment.MiddleLeft;
            lblPaymentInformation.AutoSize = true;
            lblPaymentInformation.Text = "    Thông tin thanh toán";
            lblPaymentInformation.TextAlign = ContentAlignment.MiddleLeft;
            lblPaymentInformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            lblPaymentInformation.UseVisualStyleBackColor = false;
            lblPaymentInformation.Location = new Point(lblTuitionTotal.Location.X, lblTuitionAmount.Location.Y + lblTuitionAmount.Height + labelMarginTop);
            lblPaymentInformation.FlatAppearance.BorderColor = this.BackColor;
            lblPaymentInformation.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            lblPaymentInformation.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lblPaymentInformation.FlatAppearance.MouseOverBackColor = Color.Transparent;

            lblStudentNumber.Font = fCourseRegistration.font11;
            lblStudentNumber.BorderStyle = BorderStyle.None;
            lblStudentNumber.BackColor = this.BackColor;
            lblStudentNumber.Location = new Point(labelDiaphragm, lblPaymentInformation.Height + lblPaymentInformation.Location.Y + labelMarginTop + 10);
            lblStudentNumber.Size = new Size(this.Width - lblStudentNumber.Location.X, lblPaymentInformation.Height);
            lblStudentNumber.SelectionColor = fCourseRegistration.orange;
            lblStudentNumber.SelectedText = "MSSV:  ";
            lblStudentNumber.SelectionColor = Color.Black;
            lblStudentNumber.SelectedText = studentNumber; 
            lblStudentNumber.Invalidate();

            lblStudentName.Font = fCourseRegistration.font11;
            lblStudentName.BorderStyle = BorderStyle.None;
            lblStudentName.BackColor = this.BackColor;
            lblStudentName.Location = new Point(labelDiaphragm, lblStudentNumber.Height + lblStudentNumber.Location.Y + labelMarginTop);
            lblStudentName.Size = new Size(this.Width - lblStudentName.Location.X, lblTuitionTotal.Height);
            lblStudentName.SelectionColor = fCourseRegistration.orange;
            lblStudentName.SelectedText = "Họ và tên:  ";
            lblStudentName.SelectionColor = Color.Black;
            lblStudentName.SelectedText = studentName;

            lblSutentClass.Font = fCourseRegistration.font11;
            lblSutentClass.BorderStyle = BorderStyle.None;
            lblSutentClass.BackColor = this.BackColor;
            lblSutentClass.Location = new Point(labelDiaphragm, lblStudentName.Height + lblStudentName.Location.Y + labelMarginTop);
            lblSutentClass.Size = new Size(this.Width - lblSutentClass.Location.X, lblTuitionTotal.Height);
            lblSutentClass.SelectionColor = fCourseRegistration.orange;
            lblSutentClass.SelectedText = "Lớp:  ";
            lblSutentClass.SelectionColor = Color.Black;
            lblSutentClass.SelectedText = studentClass;

            lblStudentMajor.Font = fCourseRegistration.font11;
            lblStudentMajor.BorderStyle = BorderStyle.None;
            lblStudentMajor.BackColor = this.BackColor;
            lblStudentMajor.Location = new Point(labelDiaphragm, lblSutentClass.Height + lblSutentClass.Location.Y + labelMarginTop);
            lblStudentMajor.Size = new Size(this.Width - lblStudentMajor.Location.X, lblTuitionTotal.Height);
            lblStudentMajor.SelectionColor = fCourseRegistration.orange;
            lblStudentMajor.SelectedText = "Chuyên ngành:  ";
            lblStudentMajor.SelectionColor = Color.Black;
            lblStudentMajor.SelectedText = studentMajor;

            lblPaymentInfor.Font = fCourseRegistration.font11;
            lblPaymentInfor.BorderStyle = BorderStyle.None;
            lblPaymentInfor.BackColor = this.BackColor;
            lblPaymentInfor.Location = new Point(labelDiaphragm, lblStudentMajor.Height + lblStudentMajor.Location.Y + labelMarginTop);
            lblPaymentInfor.Size = new Size(this.Width - lblPaymentInfor.Location.X, lblTuitionTotal.Height);
            lblPaymentInfor.SelectionColor = fCourseRegistration.orange;
            lblPaymentInfor.SelectedText = "Thanh toán học phí:  ";
            lblPaymentInfor.SelectionColor = Color.Black;
            lblPaymentInfor.SelectedText = description;

            lblPaymentMethod.BackColor = Color.Transparent;
            lblPaymentMethod.Cursor = Cursors.Arrow;
            lblPaymentMethod.FlatStyle = FlatStyle.Flat;
            lblPaymentMethod.Font = fCourseRegistration.font12;
            lblPaymentMethod.ForeColor = fCourseRegistration.green;
            lblPaymentMethod.Image = Properties.Resources.payment_method_green;
            lblPaymentMethod.ImageAlign = ContentAlignment.MiddleLeft;
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Text = "    Phương thức thanh toán";
            lblPaymentMethod.TextAlign = ContentAlignment.MiddleLeft;
            lblPaymentMethod.TextImageRelation = TextImageRelation.ImageBeforeText;
            lblPaymentMethod.UseVisualStyleBackColor = false;
            lblPaymentMethod.Location = new Point(lblTuitionTotal.Location.X, lblPaymentInfor.Location.Y + lblPaymentInfor.Height + labelMarginTop);
            lblPaymentMethod.FlatAppearance.BorderColor = this.BackColor;
            lblPaymentMethod.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            lblPaymentMethod.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lblPaymentMethod.FlatAppearance.MouseOverBackColor = Color.Transparent;

            rbnMomo.Font = fCourseRegistration.font11;
            rbnMomo.Text = "MoMo";
            rbnMomo.BackColor = this.BackColor;
            rbnMomo.ForeColor = fCourseRegistration.orange;
            rbnMomo.Image = Properties.Resources.momo64px;
            rbnMomo.ImageAlign = ContentAlignment.MiddleCenter;
            rbnMomo.TextAlign = ContentAlignment.MiddleCenter;
            rbnMomo.TextImageRelation = TextImageRelation.TextAboveImage;
            rbnMomo.Location = new Point(labelDiaphragm, lblPaymentMethod.Height + lblPaymentMethod.Location.Y + labelMarginTop + 10);
            rbnMomo.Size = new Size(90, 90);
            rbnMomo.Checked = true;

            rbnOcb.Font = fCourseRegistration.font11;
            rbnOcb.Text = "OCB";
            rbnOcb.BackColor = this.BackColor;
            rbnOcb.ForeColor = fCourseRegistration.orange;
            rbnOcb.Image = Properties.Resources.ocb_icon_64px;
            rbnOcb.ImageAlign = ContentAlignment.MiddleCenter;
            rbnOcb.TextAlign = ContentAlignment.MiddleCenter;
            rbnOcb.TextImageRelation = TextImageRelation.TextAboveImage;
            rbnOcb.Location = new Point(labelDiaphragm + rbnMomo.Location.X + 40, rbnMomo.Location.Y);
            rbnOcb.Size = new Size(90, 90);

            rbnPaypal.Font = fCourseRegistration.font11;
            rbnPaypal.Text = "PayPal";
            rbnPaypal.BackColor = this.BackColor;
            rbnPaypal.ForeColor = fCourseRegistration.orange;
            rbnPaypal.Image = Properties.Resources.paypal_64px;
            rbnPaypal.ImageAlign = ContentAlignment.MiddleCenter;
            rbnPaypal.TextAlign = ContentAlignment.MiddleCenter;
            rbnPaypal.TextImageRelation = TextImageRelation.TextAboveImage;
            rbnPaypal.Location = new Point(labelDiaphragm + rbnOcb.Location.X + 40, rbnMomo.Location.Y);
            rbnPaypal.Size = new Size(90, 90);

            btnPay.Text = "Thanh Toán";
            btnPay.Location = new Point(labelDiaphragm, this.Height - btnPay.Height - 30);
            btnPay.Font = fCourseRegistration.font12;
            btnPay.Width = 200;
            btnPay.Click += btnPay_Click;

            this.Controls.AddRange(new Control[]
            {
                lblTuitionTotal,
                lblPaymentInformation,
                lblPaymentMethod,
                lblStudentNumber,
                lblStudentName,
                lblSutentClass,
                lblStudentMajor,
                lblPaymentInfor,
                lblTuitionAmount,
                rbnMomo,
                rbnOcb,
                rbnPaypal,
                btnPay,
            });
        }

        #endregion

        private Button lblTuitionTotal;
        private Button lblPaymentInformation;
        private Button lblPaymentMethod;
        private DisabledRichTextBox lblStudentNumber;
        private DisabledRichTextBox lblStudentName;
        private DisabledRichTextBox lblSutentClass;
        private DisabledRichTextBox lblStudentMajor;
        private DisabledRichTextBox lblPaymentInfor;
        private Label lblTuitionAmount;
        private RadioButton rbnMomo;
        private RadioButton rbnOcb;
        private RadioButton rbnPaypal;
        private RoundedButton btnPay;

        private string description;
    }
}
