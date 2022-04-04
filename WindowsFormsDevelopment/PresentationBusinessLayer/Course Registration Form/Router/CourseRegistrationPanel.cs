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
    public partial class CourseRegistrationPanel : Panel
    {
        public Panel pnlParent { get; set; }

        public CourseRegistrationPanel(Panel pnlBody)
        {

            pnlParent = pnlBody;

            this.Width = pnlBody.Width;
            this.Height = pnlBody.Height;
            this.BackColor = Color.White;

            CreateLayout();

            InitializeComponent();
        }

        public void CreateLayout()
        {
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
