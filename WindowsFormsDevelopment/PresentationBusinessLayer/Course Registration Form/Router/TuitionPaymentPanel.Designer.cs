
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsDevelopment.Form_Course_Registration.Router;

namespace WindowsFormsDevelopment.CustomControls
{
    partial class TuitionPaymentPanel
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
            components = new System.ComponentModel.Container();

            flpTab = new FlowLayoutPanel();
            pnlBody = new Panel();
            btnUnpaid = new RoundedButton();
            btnPaymentHistory = new RoundedButton();
            pnlUnpaid = new UnpaidTuitionPanel(pnlBody);
            pnlHistory = new PaymentHistoryPanel(pnlBody);

            flpTab.Size = new Size(this.Width, this.Height / 12);
            flpTab.Controls.AddRange(new Control[]
            {
                btnUnpaid,
                btnPaymentHistory,
            });

            pnlBody.Size = new Size(this.Width, this.Height * 11 / 12);
            pnlBody.Location = new Point(0, flpTab.Height);
            pnlBody.BorderStyle = BorderStyle.FixedSingle;

            btnUnpaid.Text = "Chưa Thanh Toán";
            btnUnpaid.BorderRadius = 7;
            btnUnpaid.Margin = new Padding(0);
            btnUnpaid.Height = flpTab.Height;
            btnUnpaid.Width += flpTab.Width * 5 / 100;
            btnUnpaid.BackColor = fCourseRegistration.orange;
            btnUnpaid.Font = fCourseRegistration.font11;
            btnUnpaid.ForeColor = Color.White;
            btnUnpaid.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnUnpaid.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnUnpaid.FlatAppearance.MouseOverBackColor = fCourseRegistration.orange;
            btnUnpaid.Click += btnTab_Click;
            OpenPaymentPanel(btnUnpaid.Text);

            btnPaymentHistory.Text = "Lịch Sử Thanh Toán";
            btnPaymentHistory.BorderRadius = 7;
            btnPaymentHistory.Margin = new Padding(0);
            btnPaymentHistory.Height = flpTab.Height;
            btnPaymentHistory.Width += flpTab.Width * 5 / 100;
            btnPaymentHistory.Font = fCourseRegistration.font11;
            btnPaymentHistory.BackColor = Color.White;
            btnPaymentHistory.ForeColor = fCourseRegistration.green;
            btnPaymentHistory.FlatAppearance.CheckedBackColor = fCourseRegistration.orange;
            btnPaymentHistory.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnPaymentHistory.FlatAppearance.MouseOverBackColor = fCourseRegistration.orange;
            btnPaymentHistory.Click += btnTab_Click;

            this.Controls.AddRange(new Control[]
            {
                flpTab,
                pnlBody,
            });
        }

        #endregion

        private void ResetButtonsColor(FlowLayoutPanel flp)
        {
            foreach (Control btn in flp.Controls)
            {
                if (btn is RoundedButton)
                {
                    btn.ForeColor = fCourseRegistration.green;
                    btn.BackColor = Color.White;
                }
            }
        }

        private void OpenPaymentPanel(string type)
        {
            if(type == btnUnpaid.Text)
            {
                pnlBody.Controls.Clear();
                pnlUnpaid = new UnpaidTuitionPanel(pnlBody);
                pnlBody.Controls.Add(pnlUnpaid);
            } 
            else if(type == btnPaymentHistory.Text)
            {
                pnlBody.Controls.Clear();
                pnlHistory = new PaymentHistoryPanel(pnlBody);
                pnlBody.Controls.Add(pnlHistory);
            }
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            ResetButtonsColor(flpTab);

            var btn = (RoundedButton)sender;
            btn.ForeColor = Color.White;
            btn.BackColor = fCourseRegistration.orange;

            OpenPaymentPanel(btn.Text);
        }

        private FlowLayoutPanel flpTab;
        private Panel pnlBody;
        private RoundedButton btnUnpaid;
        private RoundedButton btnPaymentHistory;
        private UnpaidTuitionPanel pnlUnpaid;
        private PaymentHistoryPanel pnlHistory;
    }
}
