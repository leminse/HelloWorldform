using System;
using System.Windows.Forms;

namespace HelloWorldform
{
    public partial class lblTitel: Form
    {
        public lblTitel()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            lblTitel2.Text = "와~~~";
        }
    }
}
