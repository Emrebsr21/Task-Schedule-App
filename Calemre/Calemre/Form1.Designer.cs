namespace Calemre
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxSecurity = new System.Windows.Forms.PictureBox();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelClear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserLogin = new System.Windows.Forms.TextBox();
            this.textUserPsswd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(59, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(176, 144);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Teal;
            this.labelLogin.Location = new System.Drawing.Point(74, 159);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(141, 45);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "LOG IN";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(24, 210);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(40, 34);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Teal;
            this.panelUser.Location = new System.Drawing.Point(24, 245);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(236, 2);
            this.panelUser.TabIndex = 3;
            // 
            // pictureBoxSecurity
            // 
            this.pictureBoxSecurity.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSecurity.Image")));
            this.pictureBoxSecurity.Location = new System.Drawing.Point(24, 278);
            this.pictureBoxSecurity.Name = "pictureBoxSecurity";
            this.pictureBoxSecurity.Size = new System.Drawing.Size(40, 34);
            this.pictureBoxSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSecurity.TabIndex = 2;
            this.pictureBoxSecurity.TabStop = false;
            // 
            // panelSecurity
            // 
            this.panelSecurity.BackColor = System.Drawing.Color.Teal;
            this.panelSecurity.Location = new System.Drawing.Point(24, 313);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(236, 2);
            this.panelSecurity.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Teal;
            this.buttonLogin.Location = new System.Drawing.Point(24, 359);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(236, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.Teal;
            this.labelClear.Location = new System.Drawing.Point(150, 337);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(110, 19);
            this.labelClear.TabIndex = 5;
            this.labelClear.Text = "Clear Fields";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(112, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUserLogin
            // 
            this.textUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserLogin.ForeColor = System.Drawing.Color.Teal;
            this.textUserLogin.Location = new System.Drawing.Point(70, 215);
            this.textUserLogin.Multiline = true;
            this.textUserLogin.Name = "textUserLogin";
            this.textUserLogin.Size = new System.Drawing.Size(190, 24);
            this.textUserLogin.TabIndex = 7;
            // 
            // textUserPsswd
            // 
            this.textUserPsswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserPsswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserPsswd.ForeColor = System.Drawing.Color.Teal;
            this.textUserPsswd.Location = new System.Drawing.Point(70, 283);
            this.textUserPsswd.Multiline = true;
            this.textUserPsswd.Name = "textUserPsswd";
            this.textUserPsswd.PasswordChar = '*';
            this.textUserPsswd.Size = new System.Drawing.Size(190, 24);
            this.textUserPsswd.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 439);
            this.Controls.Add(this.textUserPsswd);
            this.Controls.Add(this.textUserLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelSecurity);
            this.Controls.Add(this.pictureBoxSecurity);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxSecurity;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserLogin;
        private System.Windows.Forms.TextBox textUserPsswd;
    }
}

