using System;
using System.Windows.Forms;

namespace HelloWorldform
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            lblTitel.Text = "와~~~";
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout1 = new FormAbout();
            Form formAbout2 = new FormAbout();

            formAbout1.Text = "모달창";
            formAbout1.ShowDialog();

            formAbout2.Text = "모달리스 창";
            formAbout2.Show();
        }
    }
}
