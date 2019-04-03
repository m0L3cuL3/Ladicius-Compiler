namespace LadiciusCompiler
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_compile = new System.Windows.Forms.GroupBox();
            this.gb_functions = new System.Windows.Forms.GroupBox();
            this.b_removeToCompiler = new System.Windows.Forms.Button();
            this.b_addToCompiler = new System.Windows.Forms.Button();
            this.gb_fileformat = new System.Windows.Forms.GroupBox();
            this.b_removeFromList = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.rb_java = new System.Windows.Forms.RadioButton();
            this.rb_python = new System.Windows.Forms.RadioButton();
            this.rb_textfile = new System.Windows.Forms.RadioButton();
            this.rb_csharp = new System.Windows.Forms.RadioButton();
            this.b_cmd = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.b_compile = new System.Windows.Forms.Button();
            this.b_browse = new System.Windows.Forms.Button();
            this.gb_javadoc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_settings = new System.Windows.Forms.Button();
            this.ll_github = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_requirements = new System.Windows.Forms.Label();
            this.gb_requirements = new System.Windows.Forms.GroupBox();
            this.gb_guides = new System.Windows.Forms.GroupBox();
            this.b_jdk = new System.Windows.Forms.Button();
            this.b_setenvironment = new System.Windows.Forms.Button();
            this.b_compileAll = new System.Windows.Forms.Button();
            this.gradientPanel1 = new LadiciusCompiler.GradientPanel();
            this.lb_close = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.b_findfolder = new System.Windows.Forms.Button();
            this.tb_foldername = new System.Windows.Forms.TextBox();
            this.b_javadoc = new System.Windows.Forms.Button();
            this.gb_compile.SuspendLayout();
            this.gb_functions.SuspendLayout();
            this.gb_fileformat.SuspendLayout();
            this.gb_javadoc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_requirements.SuspendLayout();
            this.gb_guides.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_compile
            // 
            this.gb_compile.Controls.Add(this.b_compileAll);
            this.gb_compile.Controls.Add(this.gb_functions);
            this.gb_compile.Controls.Add(this.gb_fileformat);
            this.gb_compile.Controls.Add(this.fileList);
            this.gb_compile.Controls.Add(this.tb_filename);
            this.gb_compile.Controls.Add(this.b_compile);
            this.gb_compile.Controls.Add(this.b_browse);
            this.gb_compile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_compile.ForeColor = System.Drawing.Color.White;
            this.gb_compile.Location = new System.Drawing.Point(7, 79);
            this.gb_compile.Name = "gb_compile";
            this.gb_compile.Size = new System.Drawing.Size(487, 299);
            this.gb_compile.TabIndex = 1;
            this.gb_compile.TabStop = false;
            this.gb_compile.Text = "compile";
            // 
            // gb_functions
            // 
            this.gb_functions.Controls.Add(this.b_removeToCompiler);
            this.gb_functions.Controls.Add(this.b_addToCompiler);
            this.gb_functions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_functions.ForeColor = System.Drawing.Color.White;
            this.gb_functions.Location = new System.Drawing.Point(367, 20);
            this.gb_functions.Name = "gb_functions";
            this.gb_functions.Size = new System.Drawing.Size(114, 79);
            this.gb_functions.TabIndex = 3;
            this.gb_functions.TabStop = false;
            this.gb_functions.Text = "file functions";
            // 
            // b_removeToCompiler
            // 
            this.b_removeToCompiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_removeToCompiler.FlatAppearance.BorderSize = 0;
            this.b_removeToCompiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removeToCompiler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_removeToCompiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_removeToCompiler.Location = new System.Drawing.Point(6, 47);
            this.b_removeToCompiler.Name = "b_removeToCompiler";
            this.b_removeToCompiler.Size = new System.Drawing.Size(101, 23);
            this.b_removeToCompiler.TabIndex = 18;
            this.b_removeToCompiler.Text = "remove";
            this.b_removeToCompiler.UseVisualStyleBackColor = false;
            this.b_removeToCompiler.Click += new System.EventHandler(this.b_removeToCompiler_Click);
            // 
            // b_addToCompiler
            // 
            this.b_addToCompiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_addToCompiler.FlatAppearance.BorderSize = 0;
            this.b_addToCompiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addToCompiler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addToCompiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_addToCompiler.Location = new System.Drawing.Point(6, 19);
            this.b_addToCompiler.Name = "b_addToCompiler";
            this.b_addToCompiler.Size = new System.Drawing.Size(101, 23);
            this.b_addToCompiler.TabIndex = 17;
            this.b_addToCompiler.Text = "add";
            this.b_addToCompiler.UseVisualStyleBackColor = false;
            this.b_addToCompiler.Click += new System.EventHandler(this.b_addToCompiler_Click);
            // 
            // gb_fileformat
            // 
            this.gb_fileformat.Controls.Add(this.b_removeFromList);
            this.gb_fileformat.Controls.Add(this.b_clear);
            this.gb_fileformat.Controls.Add(this.b_refresh);
            this.gb_fileformat.Controls.Add(this.rb_java);
            this.gb_fileformat.Controls.Add(this.rb_python);
            this.gb_fileformat.Controls.Add(this.rb_textfile);
            this.gb_fileformat.Controls.Add(this.rb_csharp);
            this.gb_fileformat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_fileformat.ForeColor = System.Drawing.Color.White;
            this.gb_fileformat.Location = new System.Drawing.Point(367, 105);
            this.gb_fileformat.Name = "gb_fileformat";
            this.gb_fileformat.Size = new System.Drawing.Size(114, 165);
            this.gb_fileformat.TabIndex = 3;
            this.gb_fileformat.TabStop = false;
            this.gb_fileformat.Text = "file format";
            // 
            // b_removeFromList
            // 
            this.b_removeFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_removeFromList.FlatAppearance.BorderSize = 0;
            this.b_removeFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_removeFromList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_removeFromList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_removeFromList.Location = new System.Drawing.Point(6, 124);
            this.b_removeFromList.Name = "b_removeFromList";
            this.b_removeFromList.Size = new System.Drawing.Size(101, 34);
            this.b_removeFromList.TabIndex = 17;
            this.b_removeFromList.Text = "remove from list";
            this.b_removeFromList.UseVisualStyleBackColor = false;
            this.b_removeFromList.Click += new System.EventHandler(this.b_removeFromList_Click);
            // 
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_clear.FlatAppearance.BorderSize = 0;
            this.b_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_clear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_clear.Location = new System.Drawing.Point(6, 95);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(101, 23);
            this.b_clear.TabIndex = 16;
            this.b_clear.Text = "clear list";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_refresh.FlatAppearance.BorderSize = 0;
            this.b_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_refresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_refresh.Location = new System.Drawing.Point(6, 66);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(101, 23);
            this.b_refresh.TabIndex = 15;
            this.b_refresh.Text = "refresh list";
            this.b_refresh.UseVisualStyleBackColor = false;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // rb_java
            // 
            this.rb_java.AutoSize = true;
            this.rb_java.Location = new System.Drawing.Point(6, 20);
            this.rb_java.Name = "rb_java";
            this.rb_java.Size = new System.Drawing.Size(54, 17);
            this.rb_java.TabIndex = 10;
            this.rb_java.TabStop = true;
            this.rb_java.Text = ".java";
            this.rb_java.UseVisualStyleBackColor = true;
            // 
            // rb_python
            // 
            this.rb_python.AutoSize = true;
            this.rb_python.Location = new System.Drawing.Point(6, 43);
            this.rb_python.Name = "rb_python";
            this.rb_python.Size = new System.Drawing.Size(43, 17);
            this.rb_python.TabIndex = 11;
            this.rb_python.TabStop = true;
            this.rb_python.Text = ".py";
            this.rb_python.UseVisualStyleBackColor = true;
            // 
            // rb_textfile
            // 
            this.rb_textfile.AutoSize = true;
            this.rb_textfile.Location = new System.Drawing.Point(66, 43);
            this.rb_textfile.Name = "rb_textfile";
            this.rb_textfile.Size = new System.Drawing.Size(44, 17);
            this.rb_textfile.TabIndex = 13;
            this.rb_textfile.TabStop = true;
            this.rb_textfile.Text = ".txt";
            this.rb_textfile.UseVisualStyleBackColor = true;
            // 
            // rb_csharp
            // 
            this.rb_csharp.AutoSize = true;
            this.rb_csharp.Location = new System.Drawing.Point(66, 20);
            this.rb_csharp.Name = "rb_csharp";
            this.rb_csharp.Size = new System.Drawing.Size(41, 17);
            this.rb_csharp.TabIndex = 12;
            this.rb_csharp.TabStop = true;
            this.rb_csharp.Text = ".cs";
            this.rb_csharp.UseVisualStyleBackColor = true;
            // 
            // b_cmd
            // 
            this.b_cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_cmd.FlatAppearance.BorderSize = 0;
            this.b_cmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cmd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_cmd.Location = new System.Drawing.Point(88, 6);
            this.b_cmd.Name = "b_cmd";
            this.b_cmd.Size = new System.Drawing.Size(116, 23);
            this.b_cmd.TabIndex = 14;
            this.b_cmd.Text = "command prompt";
            this.b_cmd.UseVisualStyleBackColor = false;
            this.b_cmd.Click += new System.EventHandler(this.b_cmd_Click);
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.Location = new System.Drawing.Point(6, 20);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(355, 221);
            this.fileList.TabIndex = 9;
            // 
            // tb_filename
            // 
            this.tb_filename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_filename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_filename.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_filename.Location = new System.Drawing.Point(6, 244);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.ReadOnly = true;
            this.tb_filename.Size = new System.Drawing.Size(355, 14);
            this.tb_filename.TabIndex = 8;
            // 
            // b_compile
            // 
            this.b_compile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_compile.FlatAppearance.BorderSize = 0;
            this.b_compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_compile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_compile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_compile.Location = new System.Drawing.Point(6, 263);
            this.b_compile.Name = "b_compile";
            this.b_compile.Size = new System.Drawing.Size(81, 25);
            this.b_compile.TabIndex = 7;
            this.b_compile.Text = "compile file";
            this.b_compile.UseVisualStyleBackColor = false;
            this.b_compile.Click += new System.EventHandler(this.b_compile_Click);
            // 
            // b_browse
            // 
            this.b_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_browse.FlatAppearance.BorderSize = 0;
            this.b_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_browse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_browse.Location = new System.Drawing.Point(233, 263);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(80, 25);
            this.b_browse.TabIndex = 6;
            this.b_browse.Text = "browse file";
            this.b_browse.UseVisualStyleBackColor = false;
            this.b_browse.Click += new System.EventHandler(this.b_browse_Click);
            // 
            // gb_javadoc
            // 
            this.gb_javadoc.Controls.Add(this.b_javadoc);
            this.gb_javadoc.Controls.Add(this.tb_foldername);
            this.gb_javadoc.Controls.Add(this.b_findfolder);
            this.gb_javadoc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_javadoc.ForeColor = System.Drawing.Color.White;
            this.gb_javadoc.Location = new System.Drawing.Point(500, 79);
            this.gb_javadoc.Name = "gb_javadoc";
            this.gb_javadoc.Size = new System.Drawing.Size(191, 148);
            this.gb_javadoc.TabIndex = 2;
            this.gb_javadoc.TabStop = false;
            this.gb_javadoc.Text = "javadoc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.b_settings);
            this.panel1.Controls.Add(this.ll_github);
            this.panel1.Controls.Add(this.b_cmd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 34);
            this.panel1.TabIndex = 4;
            // 
            // b_settings
            // 
            this.b_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_settings.FlatAppearance.BorderSize = 0;
            this.b_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_settings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_settings.Location = new System.Drawing.Point(7, 6);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(75, 23);
            this.b_settings.TabIndex = 5;
            this.b_settings.Text = "settings";
            this.b_settings.UseVisualStyleBackColor = false;
            // 
            // ll_github
            // 
            this.ll_github.AutoSize = true;
            this.ll_github.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_github.Location = new System.Drawing.Point(641, 9);
            this.ll_github.Name = "ll_github";
            this.ll_github.Size = new System.Drawing.Size(50, 16);
            this.ll_github.TabIndex = 0;
            this.ll_github.TabStop = true;
            this.ll_github.Text = "Github";
            this.ll_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_github_LinkClicked);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lb_requirements
            // 
            this.lb_requirements.AutoSize = true;
            this.lb_requirements.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_requirements.ForeColor = System.Drawing.Color.White;
            this.lb_requirements.Location = new System.Drawing.Point(6, 16);
            this.lb_requirements.Name = "lb_requirements";
            this.lb_requirements.Size = new System.Drawing.Size(177, 39);
            this.lb_requirements.TabIndex = 6;
            this.lb_requirements.Text = "> Environment is already set.\r\n> Java Development Kit\r\n> Any Java version will do" +
    "\r\n";
            // 
            // gb_requirements
            // 
            this.gb_requirements.Controls.Add(this.lb_requirements);
            this.gb_requirements.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_requirements.ForeColor = System.Drawing.Color.White;
            this.gb_requirements.Location = new System.Drawing.Point(500, 233);
            this.gb_requirements.Name = "gb_requirements";
            this.gb_requirements.Size = new System.Drawing.Size(191, 60);
            this.gb_requirements.TabIndex = 3;
            this.gb_requirements.TabStop = false;
            this.gb_requirements.Text = "requirements";
            // 
            // gb_guides
            // 
            this.gb_guides.Controls.Add(this.b_jdk);
            this.gb_guides.Controls.Add(this.b_setenvironment);
            this.gb_guides.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_guides.ForeColor = System.Drawing.Color.White;
            this.gb_guides.Location = new System.Drawing.Point(500, 299);
            this.gb_guides.Name = "gb_guides";
            this.gb_guides.Size = new System.Drawing.Size(191, 79);
            this.gb_guides.TabIndex = 7;
            this.gb_guides.TabStop = false;
            this.gb_guides.Text = "installers / guides";
            // 
            // b_jdk
            // 
            this.b_jdk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_jdk.FlatAppearance.BorderSize = 0;
            this.b_jdk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_jdk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_jdk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_jdk.Location = new System.Drawing.Point(6, 48);
            this.b_jdk.Name = "b_jdk";
            this.b_jdk.Size = new System.Drawing.Size(177, 23);
            this.b_jdk.TabIndex = 11;
            this.b_jdk.Text = "Java Development Kit";
            this.b_jdk.UseVisualStyleBackColor = false;
            this.b_jdk.Click += new System.EventHandler(this.b_jdk_Click);
            // 
            // b_setenvironment
            // 
            this.b_setenvironment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_setenvironment.FlatAppearance.BorderSize = 0;
            this.b_setenvironment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_setenvironment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_setenvironment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_setenvironment.Location = new System.Drawing.Point(6, 19);
            this.b_setenvironment.Name = "b_setenvironment";
            this.b_setenvironment.Size = new System.Drawing.Size(177, 23);
            this.b_setenvironment.TabIndex = 10;
            this.b_setenvironment.Text = "set environment";
            this.b_setenvironment.UseVisualStyleBackColor = false;
            this.b_setenvironment.Click += new System.EventHandler(this.b_setenvironment_Click);
            // 
            // b_compileAll
            // 
            this.b_compileAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_compileAll.FlatAppearance.BorderSize = 0;
            this.b_compileAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_compileAll.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_compileAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_compileAll.Location = new System.Drawing.Point(93, 263);
            this.b_compileAll.Name = "b_compileAll";
            this.b_compileAll.Size = new System.Drawing.Size(134, 25);
            this.b_compileAll.TabIndex = 10;
            this.b_compileAll.Text = "compile all java files";
            this.b_compileAll.UseVisualStyleBackColor = false;
            this.b_compileAll.Click += new System.EventHandler(this.b_compileAll_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.lb_close);
            this.gradientPanel1.Controls.Add(this.lb_title);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(698, 39);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Crimson;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseMove);
            this.gradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseUp);
            // 
            // lb_close
            // 
            this.lb_close.AutoSize = true;
            this.lb_close.BackColor = System.Drawing.Color.Transparent;
            this.lb_close.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_close.ForeColor = System.Drawing.Color.White;
            this.lb_close.Location = new System.Drawing.Point(665, 5);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(29, 29);
            this.lb_close.TabIndex = 1;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_title.Location = new System.Drawing.Point(223, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(231, 23);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Ladicius Compiler";
            // 
            // b_findfolder
            // 
            this.b_findfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_findfolder.FlatAppearance.BorderSize = 0;
            this.b_findfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_findfolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_findfolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_findfolder.Location = new System.Drawing.Point(6, 41);
            this.b_findfolder.Name = "b_findfolder";
            this.b_findfolder.Size = new System.Drawing.Size(179, 21);
            this.b_findfolder.TabIndex = 18;
            this.b_findfolder.Text = "browse folder";
            this.b_findfolder.UseVisualStyleBackColor = false;
            this.b_findfolder.Click += new System.EventHandler(this.b_findfolder_Click);
            // 
            // tb_foldername
            // 
            this.tb_foldername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_foldername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_foldername.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_foldername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_foldername.Location = new System.Drawing.Point(6, 20);
            this.tb_foldername.Name = "tb_foldername";
            this.tb_foldername.ReadOnly = true;
            this.tb_foldername.Size = new System.Drawing.Size(179, 14);
            this.tb_foldername.TabIndex = 11;
            // 
            // b_javadoc
            // 
            this.b_javadoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_javadoc.FlatAppearance.BorderSize = 0;
            this.b_javadoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_javadoc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_javadoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_javadoc.Location = new System.Drawing.Point(6, 68);
            this.b_javadoc.Name = "b_javadoc";
            this.b_javadoc.Size = new System.Drawing.Size(179, 21);
            this.b_javadoc.TabIndex = 19;
            this.b_javadoc.Text = "start";
            this.b_javadoc.UseVisualStyleBackColor = false;
            this.b_javadoc.Click += new System.EventHandler(this.b_javadoc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(698, 390);
            this.Controls.Add(this.gb_guides);
            this.Controls.Add(this.gb_requirements);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_javadoc);
            this.Controls.Add(this.gb_compile);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_compile.ResumeLayout(false);
            this.gb_compile.PerformLayout();
            this.gb_functions.ResumeLayout(false);
            this.gb_fileformat.ResumeLayout(false);
            this.gb_fileformat.PerformLayout();
            this.gb_javadoc.ResumeLayout(false);
            this.gb_javadoc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_requirements.ResumeLayout(false);
            this.gb_requirements.PerformLayout();
            this.gb_guides.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.GroupBox gb_compile;
        private System.Windows.Forms.GroupBox gb_javadoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.LinkLabel ll_github;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Button b_compile;
        private System.Windows.Forms.Button b_browse;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_requirements;
        private System.Windows.Forms.GroupBox gb_requirements;
        private System.Windows.Forms.GroupBox gb_guides;
        private System.Windows.Forms.Button b_jdk;
        private System.Windows.Forms.Button b_setenvironment;
        private System.Windows.Forms.GroupBox gb_fileformat;
        private System.Windows.Forms.RadioButton rb_java;
        private System.Windows.Forms.RadioButton rb_python;
        private System.Windows.Forms.RadioButton rb_textfile;
        private System.Windows.Forms.RadioButton rb_csharp;
        private System.Windows.Forms.Button b_cmd;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.GroupBox gb_functions;
        private System.Windows.Forms.Button b_removeToCompiler;
        private System.Windows.Forms.Button b_addToCompiler;
        private System.Windows.Forms.Button b_removeFromList;
        private System.Windows.Forms.Button b_compileAll;
        private System.Windows.Forms.Button b_javadoc;
        private System.Windows.Forms.TextBox tb_foldername;
        private System.Windows.Forms.Button b_findfolder;
    }
}

