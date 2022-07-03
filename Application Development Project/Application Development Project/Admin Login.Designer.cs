namespace Application_Development_Project
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Paasword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_UN_error = new System.Windows.Forms.Label();
            this.lbl_UN_errorPw = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_UserName.Location = new System.Drawing.Point(311, 160);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(98, 20);
            this.lbl_UserName.TabIndex = 14;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Password.Location = new System.Drawing.Point(311, 202);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(86, 20);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.LightCyan;
            this.label_1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.ForeColor = System.Drawing.Color.Black;
            this.label_1.Location = new System.Drawing.Point(347, 29);
            this.label_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(230, 38);
            this.label_1.TabIndex = 18;
            this.label_1.Text = "Admin Login";
            this.label_1.Click += new System.EventHandler(this.label_1_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(460, 156);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(139, 20);
            this.txt_UserName.TabIndex = 19;
            // 
            // txt_Paasword
            // 
            this.txt_Paasword.Location = new System.Drawing.Point(460, 201);
            this.txt_Paasword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Paasword.Name = "txt_Paasword";
            this.txt_Paasword.PasswordChar = '*';
            this.txt_Paasword.Size = new System.Drawing.Size(139, 20);
            this.txt_Paasword.TabIndex = 20;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(260, 291);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(83, 43);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(401, 291);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(87, 43);
            this.btn_Register.TabIndex = 22;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(542, 291);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 43);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_UN_error
            // 
            this.lbl_UN_error.AutoSize = true;
            this.lbl_UN_error.Location = new System.Drawing.Point(437, 160);
            this.lbl_UN_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UN_error.Name = "lbl_UN_error";
            this.lbl_UN_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_UN_error.TabIndex = 24;
            // 
            // lbl_UN_errorPw
            // 
            this.lbl_UN_errorPw.AutoSize = true;
            this.lbl_UN_errorPw.Location = new System.Drawing.Point(437, 213);
            this.lbl_UN_errorPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UN_errorPw.Name = "lbl_UN_errorPw";
            this.lbl_UN_errorPw.Size = new System.Drawing.Size(0, 13);
            this.lbl_UN_errorPw.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 399);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 102);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(651, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_UN_errorPw);
            this.Controls.Add(this.lbl_UN_error);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Paasword);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.Load += new System.EventHandler(this.Admin_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Paasword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_UN_error;
        private System.Windows.Forms.Label lbl_UN_errorPw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}