namespace QuanLyNhanVienQuanCaffe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkShowPassord = new System.Windows.Forms.CheckBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.MaxMinSize = new System.Windows.Forms.Label();
            this.Minisize = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.checkShowPassord);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.bttnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(247, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 373);
            this.panel1.TabIndex = 0;
            // 
            // checkShowPassord
            // 
            this.checkShowPassord.AutoSize = true;
            this.checkShowPassord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkShowPassord.Location = new System.Drawing.Point(413, 239);
            this.checkShowPassord.Name = "checkShowPassord";
            this.checkShowPassord.Size = new System.Drawing.Size(116, 20);
            this.checkShowPassord.TabIndex = 2;
            this.checkShowPassord.Text = "Show Passord";
            this.checkShowPassord.UseVisualStyleBackColor = true;
            this.checkShowPassord.CheckedChanged += new System.EventHandler(this.checkShowPassord_CheckedChanged);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(1)))));
            this.bttnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Location = new System.Drawing.Point(562, 285);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 29);
            this.bttnExit.TabIndex = 4;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.bttnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.bttnLogin.Location = new System.Drawing.Point(481, 285);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(75, 29);
            this.bttnLogin.TabIndex = 3;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(362, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(362, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(458, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(413, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(413, 132);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 34);
            this.txtUserName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 373);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(1117, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 36);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "O";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MaxMinSize
            // 
            this.MaxMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxMinSize.AutoSize = true;
            this.MaxMinSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaxMinSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMinSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaxMinSize.Location = new System.Drawing.Point(1073, 9);
            this.MaxMinSize.Name = "MaxMinSize";
            this.MaxMinSize.Size = new System.Drawing.Size(38, 36);
            this.MaxMinSize.TabIndex = 1;
            this.MaxMinSize.Text = "O";
            this.MaxMinSize.Click += new System.EventHandler(this.MaxMinSize_Click);
            // 
            // Minisize
            // 
            this.Minisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minisize.AutoSize = true;
            this.Minisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Minisize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minisize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minisize.Location = new System.Drawing.Point(1029, 9);
            this.Minisize.Name = "Minisize";
            this.Minisize.Size = new System.Drawing.Size(38, 36);
            this.Minisize.TabIndex = 1;
            this.Minisize.Text = "O";
            this.Minisize.Click += new System.EventHandler(this.Minisize_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Time.ForeColor = System.Drawing.Color.Transparent;
            this.Time.Location = new System.Drawing.Point(12, 567);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(38, 16);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
 
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Date.ForeColor = System.Drawing.Color.Transparent;
            this.Date.Location = new System.Drawing.Point(14, 583);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 16);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 609);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Minisize);
            this.Controls.Add(this.MaxMinSize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox checkShowPassord;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label MaxMinSize;
        private System.Windows.Forms.Label Minisize;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
    }
}