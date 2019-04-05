namespace LadiciusCompiler
{
    partial class TutorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialForm));
            this.gradientPanel1 = new LadiciusCompiler.GradientPanel();
            this.lb_close = new System.Windows.Forms.Label();
            this.b_videotut = new System.Windows.Forms.Button();
            this.b_simpletut = new System.Windows.Forms.Button();
            this.b_puretexttut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.lb_close);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(289, 20);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Crimson;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseMove);
            this.gradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseUp);
            // 
            // lb_close
            // 
            this.lb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_close.AutoSize = true;
            this.lb_close.BackColor = System.Drawing.Color.Transparent;
            this.lb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_close.ForeColor = System.Drawing.Color.White;
            this.lb_close.Location = new System.Drawing.Point(271, 1);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(19, 18);
            this.lb_close.TabIndex = 2;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // b_videotut
            // 
            this.b_videotut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_videotut.FlatAppearance.BorderSize = 0;
            this.b_videotut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_videotut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_videotut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_videotut.Location = new System.Drawing.Point(53, 126);
            this.b_videotut.Name = "b_videotut";
            this.b_videotut.Size = new System.Drawing.Size(184, 23);
            this.b_videotut.TabIndex = 18;
            this.b_videotut.Text = "Video Tutorial";
            this.b_videotut.UseVisualStyleBackColor = false;
            this.b_videotut.Click += new System.EventHandler(this.b_videotut_Click);
            // 
            // b_simpletut
            // 
            this.b_simpletut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_simpletut.FlatAppearance.BorderSize = 0;
            this.b_simpletut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_simpletut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_simpletut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_simpletut.Location = new System.Drawing.Point(53, 68);
            this.b_simpletut.Name = "b_simpletut";
            this.b_simpletut.Size = new System.Drawing.Size(184, 23);
            this.b_simpletut.TabIndex = 19;
            this.b_simpletut.Text = "Simple Tutorial";
            this.b_simpletut.UseVisualStyleBackColor = false;
            this.b_simpletut.Click += new System.EventHandler(this.b_simpletut_Click);
            // 
            // b_puretexttut
            // 
            this.b_puretexttut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_puretexttut.FlatAppearance.BorderSize = 0;
            this.b_puretexttut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_puretexttut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_puretexttut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_puretexttut.Location = new System.Drawing.Point(53, 97);
            this.b_puretexttut.Name = "b_puretexttut";
            this.b_puretexttut.Size = new System.Drawing.Size(184, 23);
            this.b_puretexttut.TabIndex = 20;
            this.b_puretexttut.Text = "Text Tutorial";
            this.b_puretexttut.UseVisualStyleBackColor = false;
            this.b_puretexttut.Click += new System.EventHandler(this.b_puretexttut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Setup environment tutorials\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Internet connection is required.";
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(289, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_puretexttut);
            this.Controls.Add(this.b_simpletut);
            this.Controls.Add(this.b_videotut);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorials";
            this.Load += new System.EventHandler(this.TutorialForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.Button b_videotut;
        private System.Windows.Forms.Button b_simpletut;
        private System.Windows.Forms.Button b_puretexttut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}