namespace LadiciusCompiler
{
    partial class InstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm));
            this.gradientPanel1 = new LadiciusCompiler.GradientPanel();
            this.lb_close = new System.Windows.Forms.Label();
            this.b_version12 = new System.Windows.Forms.Button();
            this.b_version11 = new System.Windows.Forms.Button();
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
            this.gradientPanel1.Size = new System.Drawing.Size(321, 18);
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
            this.lb_close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_close.ForeColor = System.Drawing.Color.White;
            this.lb_close.Location = new System.Drawing.Point(303, 0);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(19, 18);
            this.lb_close.TabIndex = 3;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // b_version12
            // 
            this.b_version12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_version12.FlatAppearance.BorderSize = 0;
            this.b_version12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_version12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_version12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_version12.Location = new System.Drawing.Point(59, 55);
            this.b_version12.Name = "b_version12";
            this.b_version12.Size = new System.Drawing.Size(202, 23);
            this.b_version12.TabIndex = 20;
            this.b_version12.Text = "Java SE Development Kit 12";
            this.b_version12.UseVisualStyleBackColor = false;
            this.b_version12.Click += new System.EventHandler(this.b_version12_Click);
            // 
            // b_version11
            // 
            this.b_version11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(93)))));
            this.b_version11.FlatAppearance.BorderSize = 0;
            this.b_version11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_version11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_version11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_version11.Location = new System.Drawing.Point(59, 84);
            this.b_version11.Name = "b_version11";
            this.b_version11.Size = new System.Drawing.Size(202, 23);
            this.b_version11.TabIndex = 21;
            this.b_version11.Text = "Java SE Development Kit 11.0.2\r\n\r\n";
            this.b_version11.UseVisualStyleBackColor = false;
            this.b_version11.Click += new System.EventHandler(this.b_version11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Java SE Development Kit Installers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Internet connection is required.";
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(321, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_version11);
            this.Controls.Add(this.b_version12);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installers";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.Button b_version12;
        private System.Windows.Forms.Button b_version11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}