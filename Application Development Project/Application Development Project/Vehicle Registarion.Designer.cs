namespace Application_Development_Project
{
    partial class Vehicle_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_VehicleRegistration = new System.Windows.Forms.DataGridView();
            this.lbl_VehicleID = new System.Windows.Forms.Label();
            this.lbl_VehicleNumber = new System.Windows.Forms.Label();
            this.txt_VehicleID = new System.Windows.Forms.TextBox();
            this.txt_VehicleNumber = new System.Windows.Forms.TextBox();
            this.lbl_VehicleOwnerName = new System.Windows.Forms.Label();
            this.txt_VehicleOwnerName = new System.Windows.Forms.TextBox();
            this.lbl_VehicleOwnerContc = new System.Windows.Forms.Label();
            this.txt_VehicleOwnerContac = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VehicleRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 81);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 47);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehicle Registration";
            // 
            // dgv_VehicleRegistration
            // 
            this.dgv_VehicleRegistration.BackgroundColor = System.Drawing.Color.White;
            this.dgv_VehicleRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VehicleRegistration.Location = new System.Drawing.Point(449, 97);
            this.dgv_VehicleRegistration.Name = "dgv_VehicleRegistration";
            this.dgv_VehicleRegistration.RowTemplate.Height = 24;
            this.dgv_VehicleRegistration.Size = new System.Drawing.Size(772, 405);
            this.dgv_VehicleRegistration.TabIndex = 18;
            // 
            // lbl_VehicleID
            // 
            this.lbl_VehicleID.AutoSize = true;
            this.lbl_VehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleID.Location = new System.Drawing.Point(42, 165);
            this.lbl_VehicleID.Name = "lbl_VehicleID";
            this.lbl_VehicleID.Size = new System.Drawing.Size(96, 20);
            this.lbl_VehicleID.TabIndex = 19;
            this.lbl_VehicleID.Text = "Vehicle ID";
            // 
            // lbl_VehicleNumber
            // 
            this.lbl_VehicleNumber.AutoSize = true;
            this.lbl_VehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleNumber.Location = new System.Drawing.Point(42, 227);
            this.lbl_VehicleNumber.Name = "lbl_VehicleNumber";
            this.lbl_VehicleNumber.Size = new System.Drawing.Size(142, 20);
            this.lbl_VehicleNumber.TabIndex = 21;
            this.lbl_VehicleNumber.Text = "Vehicle Number";
            // 
            // txt_VehicleID
            // 
            this.txt_VehicleID.BackColor = System.Drawing.Color.Silver;
            this.txt_VehicleID.Location = new System.Drawing.Point(287, 165);
            this.txt_VehicleID.Name = "txt_VehicleID";
            this.txt_VehicleID.Size = new System.Drawing.Size(121, 22);
            this.txt_VehicleID.TabIndex = 24;
            // 
            // txt_VehicleNumber
            // 
            this.txt_VehicleNumber.BackColor = System.Drawing.Color.Silver;
            this.txt_VehicleNumber.Location = new System.Drawing.Point(287, 227);
            this.txt_VehicleNumber.Name = "txt_VehicleNumber";
            this.txt_VehicleNumber.Size = new System.Drawing.Size(121, 22);
            this.txt_VehicleNumber.TabIndex = 26;
            this.txt_VehicleNumber.TextChanged += new System.EventHandler(this.txt_VehicleDriverName_TextChanged);
            // 
            // lbl_VehicleOwnerName
            // 
            this.lbl_VehicleOwnerName.AutoSize = true;
            this.lbl_VehicleOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleOwnerName.Location = new System.Drawing.Point(42, 292);
            this.lbl_VehicleOwnerName.Name = "lbl_VehicleOwnerName";
            this.lbl_VehicleOwnerName.Size = new System.Drawing.Size(185, 20);
            this.lbl_VehicleOwnerName.TabIndex = 27;
            this.lbl_VehicleOwnerName.Text = "Vehicle Owner Name";
            // 
            // txt_VehicleOwnerName
            // 
            this.txt_VehicleOwnerName.BackColor = System.Drawing.Color.Silver;
            this.txt_VehicleOwnerName.Location = new System.Drawing.Point(287, 292);
            this.txt_VehicleOwnerName.Name = "txt_VehicleOwnerName";
            this.txt_VehicleOwnerName.Size = new System.Drawing.Size(121, 22);
            this.txt_VehicleOwnerName.TabIndex = 28;
            // 
            // lbl_VehicleOwnerContc
            // 
            this.lbl_VehicleOwnerContc.AutoSize = true;
            this.lbl_VehicleOwnerContc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VehicleOwnerContc.Location = new System.Drawing.Point(42, 359);
            this.lbl_VehicleOwnerContc.Name = "lbl_VehicleOwnerContc";
            this.lbl_VehicleOwnerContc.Size = new System.Drawing.Size(225, 20);
            this.lbl_VehicleOwnerContc.TabIndex = 29;
            this.lbl_VehicleOwnerContc.Text = "Vehicle Owner Contac No";
            // 
            // txt_VehicleOwnerContac
            // 
            this.txt_VehicleOwnerContac.BackColor = System.Drawing.Color.Silver;
            this.txt_VehicleOwnerContac.Location = new System.Drawing.Point(287, 359);
            this.txt_VehicleOwnerContac.Name = "txt_VehicleOwnerContac";
            this.txt_VehicleOwnerContac.Size = new System.Drawing.Size(121, 22);
            this.txt_VehicleOwnerContac.TabIndex = 30;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 550);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.HotPink;
            this.btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.Location = new System.Drawing.Point(78, 554);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(118, 48);
            this.btn_ADD.TabIndex = 49;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = false;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(299, 549);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.BackColor = System.Drawing.Color.HotPink;
            this.btn_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UPDATE.Location = new System.Drawing.Point(367, 550);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(111, 48);
            this.btn_UPDATE.TabIndex = 51;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(556, 550);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.BackColor = System.Drawing.Color.HotPink;
            this.btn_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELETE.Location = new System.Drawing.Point(621, 550);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(109, 48);
            this.btn_DELETE.TabIndex = 53;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = false;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 546);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.BackColor = System.Drawing.Color.HotPink;
            this.btn_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEARCH.Location = new System.Drawing.Point(838, 550);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(112, 48);
            this.btn_SEARCH.TabIndex = 55;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = false;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1040, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.HotPink;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1105, 546);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(145, 56);
            this.btn_Home.TabIndex = 57;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Vehicle_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1262, 654);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txt_VehicleOwnerContac);
            this.Controls.Add(this.lbl_VehicleOwnerContc);
            this.Controls.Add(this.txt_VehicleOwnerName);
            this.Controls.Add(this.lbl_VehicleOwnerName);
            this.Controls.Add(this.txt_VehicleNumber);
            this.Controls.Add(this.txt_VehicleID);
            this.Controls.Add(this.lbl_VehicleNumber);
            this.Controls.Add(this.lbl_VehicleID);
            this.Controls.Add(this.dgv_VehicleRegistration);
            this.Controls.Add(this.panel1);
            this.Name = "Vehicle_Registration";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Manage_Transport_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VehicleRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_VehicleRegistration;
        private System.Windows.Forms.Label lbl_VehicleID;
        private System.Windows.Forms.Label lbl_VehicleNumber;
        private System.Windows.Forms.TextBox txt_VehicleID;
        private System.Windows.Forms.TextBox txt_VehicleNumber;
        private System.Windows.Forms.Label lbl_VehicleOwnerName;
        private System.Windows.Forms.TextBox txt_VehicleOwnerName;
        private System.Windows.Forms.Label lbl_VehicleOwnerContc;
        private System.Windows.Forms.TextBox txt_VehicleOwnerContac;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_UPDATE;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Home;
    }
}