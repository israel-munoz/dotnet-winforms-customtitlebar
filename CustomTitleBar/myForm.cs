using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomTitleBar
{
    public partial class myForm : Form
    {
        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        public myForm()
        {
            InitializeComponent();

            this.Title = "Aplicación con título personalizado";
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState =
                (this.WindowState == FormWindowState.Maximized ?
                    FormWindowState.Normal :
                    FormWindowState.Maximized);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point pos = Point.Empty;
        private bool move = false;

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
