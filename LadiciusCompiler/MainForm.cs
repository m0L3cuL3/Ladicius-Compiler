using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LadiciusCompiler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // when form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();

            set.LoadSettings();
            Gpanel.Refresh();
        }

        /* in order for the window to move */
        int mouseX = 0, mouseY = 0;
        int mouseinX, mouseinY;
        bool mouseDown;

        // when the panel is released
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

        // for movable panel 
        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        // rainbow shit...
        private void timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            lb_title.ForeColor = Color.FromArgb(A, R, G, B);
        }

        // refresh list
        private void b_refresh_Click(object sender, EventArgs e)
        {
            /* File type and path (Desktop) */
            DirectoryInfo desktopPath = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Desktop\");

            // Java file format
            if (rb_java.Checked)
            {
                fileList.Items.Clear();
                FileInfo[] filetype = desktopPath.GetFiles(Globals.JAVA);

                foreach (FileInfo desktopItems in filetype)
                {
                    fileList.Items.Add(desktopPath.ToString() + desktopItems);
                }

            }

            // Python file format
            if (rb_python.Checked)
            {
                fileList.Items.Clear();
                FileInfo[] filetype = desktopPath.GetFiles(Globals.PYTHON);

                foreach (FileInfo desktopItems in filetype)
                {
                    fileList.Items.Add(desktopPath.ToString() + desktopItems);
                }
            }

            // C# file format
            if (rb_csharp.Checked)
            {
                fileList.Items.Clear();
                FileInfo[] filetype = desktopPath.GetFiles(Globals.CSHARP);

                foreach (FileInfo desktopItems in filetype)
                {
                    fileList.Items.Add(desktopPath.ToString() + desktopItems);
                }
            }

            // text file format
            if (rb_textfile.Checked)
            {
                fileList.Items.Clear();
                FileInfo[] filetype = desktopPath.GetFiles(Globals.TEXTFILE);

                foreach (FileInfo desktopItems in filetype)
                {
                    fileList.Items.Add(desktopPath.ToString() + desktopItems);
                }
            }
        }

        // add file to compiler
        private void b_addToCompiler_Click(object sender, EventArgs e)
        {
            try
            {
                tb_filename.Text = fileList.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {

            }

        }

        // remove file from compiler
        private void b_removeToCompiler_Click(object sender, EventArgs e)
        {
            tb_filename.Text = null;
        }

        // remove file from list
        private void b_removeFromList_Click(object sender, EventArgs e)
        {
            fileList.Items.Remove(fileList.SelectedItem);
        }

        // compile 
        private void b_compile_Click(object sender, EventArgs e)
        {
            if(tb_filename.Text == "")
            {
                // do nothing . . .
            }
            else
            {
                Process.Start("cmd.exe", "/k javac " + tb_filename.Text + "& echo off & echo [+] Process Done!");
            }
            
        }

        // browse custom file
        private void b_browse_Click(object sender, EventArgs e)
        {

            // browse java file to list
            if(rb_java.Checked)
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Search Java File";
                fdlg.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                fdlg.Filter = Globals.JAVA_F;
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string path = fdlg.FileName;
                    fileList.Items.Add(path);
                }
            }
            
            // browse python file to list
            if(rb_python.Checked)
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Search Python File";
                fdlg.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                fdlg.Filter = Globals.PYTHON_F;
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string path = fdlg.FileName;
                    fileList.Items.Add(path);
                }
            }

            // browse csharp file to list
            if (rb_csharp.Checked)
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Search Csharp File";
                fdlg.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                fdlg.Filter = Globals.CSHARP_F;
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string path = fdlg.FileName;
                    fileList.Items.Add(path);
                }
            }

            // browse textfile to list
            if (rb_textfile.Checked)
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Search Text File ";
                fdlg.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                fdlg.Filter = Globals.TEXTFILE_F;
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string path = fdlg.FileName;
                    fileList.Items.Add(path);
                }
            }

        }

        // shows settings form
        private void b_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        // start command prompt
        private void b_cmd_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        // set environment tutorials
        private void b_setenvironment_Click(object sender, EventArgs e)
        {
            TutorialForm tf = new TutorialForm();
            tf.Show();
        }

        // download jdk 
        private void b_jdk_Click(object sender, EventArgs e)
        {
            InstallerForm inform = new InstallerForm();
            inform.Show();
        }

        // my github link :)
        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Globals.github1);
        }

        // compiles all java files
        private void b_compileAll_Click(object sender, EventArgs e)
        {
            string folderpath;

            FolderBrowserDialog folderdlg = new FolderBrowserDialog();
            folderdlg.ShowNewFolderButton = true;
            DialogResult result = folderdlg.ShowDialog();


            if(result == DialogResult.OK)
            {
                folderpath = folderdlg.SelectedPath;
                Environment.SpecialFolder root = folderdlg.RootFolder;
                Process.Start("cmd.exe", "/k cd " + folderpath + " & javac " + Globals.JAVA + "& echo off & echo [+] Process Done!");
            }
        }

        // for browsing folder 
        private void b_findfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderdlg = new FolderBrowserDialog();
            folderdlg.ShowNewFolderButton = true;
            DialogResult result = folderdlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_foldername.Text = folderdlg.SelectedPath;
                Environment.SpecialFolder root = folderdlg.RootFolder;
            }
        }

        // starts javadoc
        private void b_javadoc_Click(object sender, EventArgs e)
        {
            if(tb_foldername.Text == "")
            {
                MessageBox.Show("Please select a folder...");
            }
            else
            {
                Process.Start("cmd.exe", "/k cd " + tb_foldername.Text + " & javadoc " + Globals.JAVA + "& echo off & echo [+] Process Done!");
            }
        }

        // for clearing the file list
        private void b_clear_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
        }

        // close button (label)
        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
