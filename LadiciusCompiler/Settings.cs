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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        // smooth rainbow
        int r = 244;
        int g = 65;
        int b = 65;

        /* in order for the window to move */
        int mouseX = 0, mouseY = 0;
        int mouseinX, mouseinY;
        bool mouseDown;

        // when the panel is released
        private void gradientPanel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // when the panel is clicked
        private void gradientPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        // for movable panel 
        private void gradientPanel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        // rainbow shit (R)
        private void timer_r_Tick(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            if (b >= 244)
            {
                r -= 1;

                mf.lb_title.ForeColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    timer_r.Stop();
                    timer_g.Start();
                }
            }
        }

        // rainbow shit (G)
        private void timer_g_Tick(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            if (r <= 65)
            {
                g += 1;
                mf.lb_title.ForeColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    timer_g.Stop();
                    timer_b.Start();
                }
            }

            if (r >= 244)
            {
                g -= 1;
               
                mf.lb_title.ForeColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    timer_g.Stop();
                    timer_b.Start();
                }
            }
        }

        // rainbow shit (B)
        private void timer_b_Tick(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];

            if (g <= 65)
            {
                b += 1;
                mf.lb_title.ForeColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    timer_b.Stop();
                    timer_r.Start();
                }
            }

            if (g >= 244)
            {
                b -= 1;
               
                mf.lb_title.ForeColor = Color.FromArgb(r, g, b);
                if (b <= 65)
                {
                    timer_b.Stop();
                    timer_r.Start();
                }
            }
        }

        // changes the Top color of gradient panel in mainform.
        private void b_gtc_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            ColorDialog clrdlg = new ColorDialog();
            clrdlg.ShowDialog();

            mf.Gpanel.TopColor = clrdlg.Color;
            p_gtc.BackColor = clrdlg.Color;

            mf.Gpanel.Refresh();
        }

        // changes the Bottom color gradient panel in mainform.
        private void b_gbc_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            ColorDialog clrdlg = new ColorDialog();
            clrdlg.ShowDialog();

            mf.Gpanel.BottomColor = clrdlg.Color;
            p_gbc.BackColor = clrdlg.Color;

            mf.Gpanel.Refresh();
        }

        // changes the backcolor of mainform.
        private void b_bg_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            ColorDialog clrdlg = new ColorDialog();
            clrdlg.ShowDialog();

            mf.BackColor = clrdlg.Color;
            p_fbc.BackColor = clrdlg.Color;
        }

        // activates smooth rainbow shit.
        private void rb_sfade_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sfade.Checked)
            {
                timer_b.Start();
            }
            else
            {
                timer_b.Stop();
                timer_r.Stop();
                timer_g.Stop();
                r = 244;
                g = 65;
                b = 65;
            }
        }

        // activates edgy rainbow shit.
        private void rb_efade_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            if(rb_efade.Checked)
            {
                mf.timer.Start();
                mf.timer.Interval = 250;
            }
            else
            {
                mf.timer.Stop();
            }
        }

        // timer for gradient rainbow fade (1)
        private void tmr_gtc_Tick(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            mf.Gpanel.TopColor = Color.FromArgb(A, R, G, B);
            mf.Gpanel.Refresh();
        }

        // timer for gradient rainbow fade (2)
        private void tmr_gtc_2_Tick(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            mf.Gpanel.BottomColor = Color.FromArgb(A, R, G, B);
            mf.Gpanel.Refresh();
        }

        // Gradient rainbow fade
        private void cb_gef_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cb_gef.Checked)
            {
                tmr_gtc.Start();
                tmr_gtc_2.Start();
                tmr_gtc.Interval = 250; // TopColor
                tmr_gtc_2.Interval = 1000; // BottomColor
            }
            else
            {
                tmr_gtc.Stop();
                tmr_gtc_2.Stop();
                
            }
        }

        // changes the button forecolor in mainform.
        private void b_forecolor_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            ColorDialog clrdlg = new ColorDialog();
            clrdlg.ShowDialog();

            // change forecolor in all buttons in mainform.
            mf.b_addToCompiler.ForeColor = clrdlg.Color;
            mf.b_compile.ForeColor = clrdlg.Color;
            mf.b_browse.ForeColor = clrdlg.Color;
            mf.b_clear.ForeColor = clrdlg.Color;
            mf.b_cmd.ForeColor = clrdlg.Color;
            mf.b_compileAll.ForeColor = clrdlg.Color;
            mf.b_findfolder.ForeColor = clrdlg.Color;
            mf.b_javadoc.ForeColor = clrdlg.Color;
            mf.b_jdk.ForeColor = clrdlg.Color;
            mf.b_refresh.ForeColor = clrdlg.Color;
            mf.b_removeFromList.ForeColor = clrdlg.Color;
            mf.b_removeToCompiler.ForeColor = clrdlg.Color;
            mf.b_setenvironment.ForeColor = clrdlg.Color;
            mf.b_settings.ForeColor = clrdlg.Color;

            p_bfc.BackColor = clrdlg.Color;
        }

        // changes the button backcolor in mainform.
        private void b_backcolor_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            ColorDialog clrdlg = new ColorDialog();
            clrdlg.ShowDialog();

            // change backcolor in all buttons in mainform.
            mf.b_addToCompiler.BackColor = clrdlg.Color;
            mf.b_compile.BackColor = clrdlg.Color;
            mf.b_browse.BackColor = clrdlg.Color;
            mf.b_clear.BackColor = clrdlg.Color;
            mf.b_cmd.BackColor = clrdlg.Color;
            mf.b_compileAll.BackColor = clrdlg.Color;
            mf.b_findfolder.BackColor = clrdlg.Color;
            mf.b_javadoc.BackColor = clrdlg.Color;
            mf.b_jdk.BackColor = clrdlg.Color;
            mf.b_refresh.BackColor = clrdlg.Color;
            mf.b_removeFromList.BackColor = clrdlg.Color;
            mf.b_removeToCompiler.BackColor = clrdlg.Color;
            mf.b_setenvironment.BackColor = clrdlg.Color;
            mf.b_settings.BackColor = clrdlg.Color;

            p_bbc.BackColor = clrdlg.Color;
        }

        // saves settings -> only supports rainbow settings for now :)
        private void b_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info: Only saves rainbow fade settings.");
            MainForm mf = (MainForm)Application.OpenForms["MainForm"];
            SaveSettings();
            mf.Gpanel.Refresh();
        }

        // loads the previous settings
        private void b_load_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        // close button
        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // saves settings
        public void SaveSettings()
        {
            Properties.Settings.Default.checkbox = cb_gef.Checked;
            Properties.Settings.Default.rb_1 = rb_sfade.Checked;
            Properties.Settings.Default.rb_2 = rb_efade.Checked;
            Properties.Settings.Default.Save();
        }

        // loads settings
        public void LoadSettings()
        {
            cb_gef.Checked = Properties.Settings.Default.checkbox;
            rb_sfade.Checked = Properties.Settings.Default.rb_1;
            rb_efade.Checked = Properties.Settings.Default.rb_2;
        }
    }
}
