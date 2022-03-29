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
    public partial class StudentInformation : Panel
    {
        public Panel pnlParent { get; set; }

        public Panel pnlHeader { get; set; }
        public Panel pnlHeader_Avatar { get; set; }
        public Panel pnlHeader_StudentInfor { get; set; }
        public Panel pnlLeftSide { get; set; }
        public Panel pnlRightSide { get; set; }

        public StudentInformation(Panel pnlBody)
        {
            InitializeComponent();

            pnlParent = pnlBody;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;

            CreateLayout();
        }

        public void CreateLayout()
        {
            pnlHeader = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Aqua,
            };

            pnlLeftSide = new Panel()
            {
                Size = new Size(this.Width / 2, this.Height / 2),
                Location = new Point(0, this.Height / 2),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Red,
            };

            pnlRightSide = new Panel()
            {
                Size = new Size(this.Width, this.Height / 2),
                Location = new Point(this.Width/2, this.Height / 2),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Black,
            };

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
