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
    public partial class InstallerForm : Form
    {
        public InstallerForm()
        {
            InitializeComponent();
        }

        /* in order for the window to move */
        int mouseX = 0, mouseY = 0;
        int mouseinX, mouseinY;
        bool mouseDown;

        // when the panel is released...
        private void gradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

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

        // closes the form...
        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // download jdk version 11
        private void b_version11_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.version_11);
        }

        // download jdk version 12
        private void b_version12_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.version_12);
        }
  
    }
}
