namespace LadiciusCompiler
{
    partial class Settings
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
            this.b_forecolor = new System.Windows.Forms.Button();
            this.b_backcolor = new System.Windows.Forms.Button();
            this.b_gtc = new System.Windows.Forms.Button();
            this.b_gbc = new System.Windows.Forms.Button();
            this.p_gtc = new System.Windows.Forms.Panel();
            this.p_gbc = new System.Windows.Forms.Panel();
            this.p_bbc = new System.Windows.Forms.Panel();
            this.p_bfc = new System.Windows.Forms.Panel();
            this.b_bg = new System.Windows.Forms.Button();
            this.p_fbc = new System.Windows.Forms.Panel();
            this.timer_r = new System.Windows.Forms.Timer(this.components);
            this.timer_g = new System.Windows.Forms.Timer(this.components);
            this.timer_b = new System.Windows.Forms.Timer(this.components);
            this.rb_sfade = new System.Windows.Forms.RadioButton();
            this.rb_efade = new System.Windows.Forms.RadioButton();
            this.gb_titletext = new System.Windows.Forms.GroupBox();
            this.cb_gef = new System.Windows.Forms.CheckBox();
            this.tmr_gtc = new System.Windows.Forms.Timer(this.components);
            this.tmr_gtc_2 = new System.Windows.Forms.Timer(this.components);
            this.b_save = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.gradientPanel1 = new LadiciusCompiler.GradientPanel();
            this.lb_close = new System.Windows.Forms.Label();
            this.tt_info = new System.Windows.Forms.ToolTip(this.components);
            this.gb_titletext.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_forecolor
            // 
            this.b_forecolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_forecolor.FlatAppearance.BorderSize = 0;
            this.b_forecolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_forecolor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_forecolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_forecolor.Location = new System.Drawing.Point(12, 33);
            this.b_forecolor.Name = "b_forecolor";
            this.b_forecolor.Size = new System.Drawing.Size(145, 23);
            this.b_forecolor.TabIndex = 18;
            this.b_forecolor.Text = "Button Font Color";
            this.tt_info.SetToolTip(this.b_forecolor, "Changes the font color.");
            this.b_forecolor.UseVisualStyleBackColor = false;
            this.b_forecolor.Click += new System.EventHandler(this.b_forecolor_Click);
            // 
            // b_backcolor
            // 
            this.b_backcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_backcolor.FlatAppearance.BorderSize = 0;
            this.b_backcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_backcolor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_backcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_backcolor.Location = new System.Drawing.Point(12, 62);
            this.b_backcolor.Name = "b_backcolor";
            this.b_backcolor.Size = new System.Drawing.Size(145, 23);
            this.b_backcolor.TabIndex = 19;
            this.b_backcolor.Text = "Button Back Color";
            this.tt_info.SetToolTip(this.b_backcolor, "Changes the background color.");
            this.b_backcolor.UseVisualStyleBackColor = false;
            this.b_backcolor.Click += new System.EventHandler(this.b_backcolor_Click);
            // 
            // b_gtc
            // 
            this.b_gtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_gtc.FlatAppearance.BorderSize = 0;
            this.b_gtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gtc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gtc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_gtc.Location = new System.Drawing.Point(12, 91);
            this.b_gtc.Name = "b_gtc";
            this.b_gtc.Size = new System.Drawing.Size(145, 23);
            this.b_gtc.TabIndex = 20;
            this.b_gtc.Text = "Gradient Top Color";
            this.tt_info.SetToolTip(this.b_gtc, "Changes the gradient color (TOP).");
            this.b_gtc.UseVisualStyleBackColor = false;
            this.b_gtc.Click += new System.EventHandler(this.b_gtc_Click);
            // 
            // b_gbc
            // 
            this.b_gbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_gbc.FlatAppearance.BorderSize = 0;
            this.b_gbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gbc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gbc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_gbc.Location = new System.Drawing.Point(12, 120);
            this.b_gbc.Name = "b_gbc";
            this.b_gbc.Size = new System.Drawing.Size(145, 23);
            this.b_gbc.TabIndex = 21;
            this.b_gbc.Text = "Gradient Bottom Color";
            this.tt_info.SetToolTip(this.b_gbc, "Changes the gradient color (BOTTOM).");
            this.b_gbc.UseVisualStyleBackColor = false;
            this.b_gbc.Click += new System.EventHandler(this.b_gbc_Click);
            // 
            // p_gtc
            // 
            this.p_gtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.p_gtc.Location = new System.Drawing.Point(163, 91);
            this.p_gtc.Name = "p_gtc";
            this.p_gtc.Size = new System.Drawing.Size(24, 23);
            this.p_gtc.TabIndex = 22;
            // 
            // p_gbc
            // 
            this.p_gbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.p_gbc.Location = new System.Drawing.Point(163, 120);
            this.p_gbc.Name = "p_gbc";
            this.p_gbc.Size = new System.Drawing.Size(24, 23);
            this.p_gbc.TabIndex = 23;
            // 
            // p_bbc
            // 
            this.p_bbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.p_bbc.Location = new System.Drawing.Point(163, 62);
            this.p_bbc.Name = "p_bbc";
            this.p_bbc.Size = new System.Drawing.Size(24, 23);
            this.p_bbc.TabIndex = 23;
            // 
            // p_bfc
            // 
            this.p_bfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.p_bfc.Location = new System.Drawing.Point(163, 33);
            this.p_bfc.Name = "p_bfc";
            this.p_bfc.Size = new System.Drawing.Size(24, 23);
            this.p_bfc.TabIndex = 23;
            // 
            // b_bg
            // 
            this.b_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_bg.FlatAppearance.BorderSize = 0;
            this.b_bg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_bg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_bg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_bg.Location = new System.Drawing.Point(12, 149);
            this.b_bg.Name = "b_bg";
            this.b_bg.Size = new System.Drawing.Size(145, 23);
            this.b_bg.TabIndex = 24;
            this.b_bg.Text = "Form Back Color";
            this.tt_info.SetToolTip(this.b_bg, "Changes the background color of main form.");
            this.b_bg.UseVisualStyleBackColor = false;
            this.b_bg.Click += new System.EventHandler(this.b_bg_Click);
            // 
            // p_fbc
            // 
            this.p_fbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.p_fbc.Location = new System.Drawing.Point(163, 149);
            this.p_fbc.Name = "p_fbc";
            this.p_fbc.Size = new System.Drawing.Size(24, 23);
            this.p_fbc.TabIndex = 24;
            // 
            // timer_r
            // 
            this.timer_r.Tick += new System.EventHandler(this.timer_r_Tick);
            // 
            // timer_g
            // 
            this.timer_g.Tick += new System.EventHandler(this.timer_g_Tick);
            // 
            // timer_b
            // 
            this.timer_b.Tick += new System.EventHandler(this.timer_b_Tick);
            // 
            // rb_sfade
            // 
            this.rb_sfade.AutoSize = true;
            this.rb_sfade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sfade.ForeColor = System.Drawing.Color.White;
            this.rb_sfade.Location = new System.Drawing.Point(14, 20);
            this.rb_sfade.Name = "rb_sfade";
            this.rb_sfade.Size = new System.Drawing.Size(99, 17);
            this.rb_sfade.TabIndex = 26;
            this.rb_sfade.TabStop = true;
            this.rb_sfade.Text = "Smooth Fade";
            this.rb_sfade.UseVisualStyleBackColor = true;
            this.rb_sfade.CheckedChanged += new System.EventHandler(this.rb_sfade_CheckedChanged);
            // 
            // rb_efade
            // 
            this.rb_efade.AutoSize = true;
            this.rb_efade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_efade.ForeColor = System.Drawing.Color.White;
            this.rb_efade.Location = new System.Drawing.Point(14, 43);
            this.rb_efade.Name = "rb_efade";
            this.rb_efade.Size = new System.Drawing.Size(83, 17);
            this.rb_efade.TabIndex = 27;
            this.rb_efade.TabStop = true;
            this.rb_efade.Text = "Edgy Fade";
            this.rb_efade.UseVisualStyleBackColor = true;
            this.rb_efade.CheckedChanged += new System.EventHandler(this.rb_efade_CheckedChanged);
            // 
            // gb_titletext
            // 
            this.gb_titletext.Controls.Add(this.b_load);
            this.gb_titletext.Controls.Add(this.b_save);
            this.gb_titletext.Controls.Add(this.rb_sfade);
            this.gb_titletext.Controls.Add(this.cb_gef);
            this.gb_titletext.Controls.Add(this.rb_efade);
            this.gb_titletext.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_titletext.ForeColor = System.Drawing.Color.White;
            this.gb_titletext.Location = new System.Drawing.Point(193, 33);
            this.gb_titletext.Name = "gb_titletext";
            this.gb_titletext.Size = new System.Drawing.Size(284, 99);
            this.gb_titletext.TabIndex = 28;
            this.gb_titletext.TabStop = false;
            this.gb_titletext.Text = "Rainbow";
            // 
            // cb_gef
            // 
            this.cb_gef.AutoSize = true;
            this.cb_gef.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gef.ForeColor = System.Drawing.Color.White;
            this.cb_gef.Location = new System.Drawing.Point(141, 21);
            this.cb_gef.Name = "cb_gef";
            this.cb_gef.Size = new System.Drawing.Size(137, 17);
            this.cb_gef.TabIndex = 29;
            this.cb_gef.Text = "Gradient Edgy Fade";
            this.cb_gef.UseVisualStyleBackColor = true;
            this.cb_gef.CheckedChanged += new System.EventHandler(this.cb_gef_CheckedChanged);
            // 
            // tmr_gtc
            // 
            this.tmr_gtc.Tick += new System.EventHandler(this.tmr_gtc_Tick);
            // 
            // tmr_gtc_2
            // 
            this.tmr_gtc_2.Tick += new System.EventHandler(this.tmr_gtc_2_Tick);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_save.FlatAppearance.BorderSize = 0;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_save.Location = new System.Drawing.Point(14, 70);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 23);
            this.b_save.TabIndex = 30;
            this.b_save.Text = "Save Settings";
            this.tt_info.SetToolTip(this.b_save, "Saves settings (buggy).");
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_load
            // 
            this.b_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_load.FlatAppearance.BorderSize = 0;
            this.b_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_load.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_load.Location = new System.Drawing.Point(167, 70);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(111, 23);
            this.b_load.TabIndex = 31;
            this.b_load.Text = "Load Settings";
            this.tt_info.SetToolTip(this.b_load, "Loads previous setting (buggy).");
            this.b_load.UseVisualStyleBackColor = false;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.lb_close);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(488, 18);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Crimson;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown_1);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseMove_1);
            this.gradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseUp_1);
            // 
            // lb_close
            // 
            this.lb_close.AutoSize = true;
            this.lb_close.BackColor = System.Drawing.Color.Transparent;
            this.lb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_close.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_close.ForeColor = System.Drawing.Color.White;
            this.lb_close.Location = new System.Drawing.Point(471, 1);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(17, 16);
            this.lb_close.TabIndex = 29;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(488, 188);
            this.Controls.Add(this.gb_titletext);
            this.Controls.Add(this.p_fbc);
            this.Controls.Add(this.b_bg);
            this.Controls.Add(this.p_bfc);
            this.Controls.Add(this.p_bbc);
            this.Controls.Add(this.p_gbc);
            this.Controls.Add(this.p_gtc);
            this.Controls.Add(this.b_gbc);
            this.Controls.Add(this.b_gtc);
            this.Controls.Add(this.b_backcolor);
            this.Controls.Add(this.b_forecolor);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gb_titletext.ResumeLayout(false);
            this.gb_titletext.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button b_forecolor;
        private System.Windows.Forms.Button b_backcolor;
        private System.Windows.Forms.Button b_gtc;
        private System.Windows.Forms.Button b_gbc;
        private System.Windows.Forms.Panel p_gtc;
        private System.Windows.Forms.Panel p_gbc;
        private System.Windows.Forms.Panel p_bbc;
        private System.Windows.Forms.Panel p_bfc;
        private System.Windows.Forms.Button b_bg;
        private System.Windows.Forms.Panel p_fbc;
        private System.Windows.Forms.Timer timer_r;
        private System.Windows.Forms.Timer timer_g;
        private System.Windows.Forms.Timer timer_b;
        private System.Windows.Forms.RadioButton rb_sfade;
        private System.Windows.Forms.RadioButton rb_efade;
        private System.Windows.Forms.GroupBox gb_titletext;
        private System.Windows.Forms.Timer tmr_gtc;
        private System.Windows.Forms.Timer tmr_gtc_2;
        private System.Windows.Forms.CheckBox cb_gef;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_load;
        public System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.ToolTip tt_info;
    }
}