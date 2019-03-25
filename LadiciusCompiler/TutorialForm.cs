using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LadiciusCompiler
{
    public partial class TutorialForm : Form
    {
        public TutorialForm()
        {
            InitializeComponent();
        }

        // when form loads
        private void TutorialForm_Load(object sender, EventArgs e)
        {

        }

        /* in order for the window to move */
        int mouseX = 0, mouseY = 0;
        int mouseinX, mouseinY;
        bool mouseDown;
        // when the panel is clicked
        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        // when the panel is moved
        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        // when the panel is released...
        private void gradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // closes the form... duh...
        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Tutorials */
        private void b_simpletut_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.SimpleTutorial);
        }
        private void b_puretexttut_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.PureTutorial);
        }
        private void b_videotut_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.VideoTutorial);
        }
        /* Tutorials */
    }
}
