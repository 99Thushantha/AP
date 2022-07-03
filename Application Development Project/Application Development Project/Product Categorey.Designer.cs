namespace Application_Development_Project
{
    partial class Product_Categorey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Categorey));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CategoreyID = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_CategoreyName = new System.Windows.Forms.Label();
            this.txt_CategoreyID = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.cmb_CategoryName = new System.Windows.Forms.ComboBox();
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
            this.dgv_ProductCategorey = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductCategorey)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(468, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Categorey";
            // 
            // lbl_CategoreyID
            // 
            this.lbl_CategoreyID.AutoSize = true;
            this.lbl_CategoreyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoreyID.Location = new System.Drawing.Point(102, 190);
            this.lbl_CategoreyID.Name = "lbl_CategoreyID";
            this.lbl_CategoreyID.Size = new System.Drawing.Size(119, 20);
            this.lbl_CategoreyID.TabIndex = 8;
            this.lbl_CategoreyID.Text = "Categorey ID";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(102, 327);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(106, 20);
            this.lbl_Description.TabIndex = 9;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_CategoreyName
            // 
            this.lbl_CategoreyName.AutoSize = true;
            this.lbl_CategoreyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoreyName.Location = new System.Drawing.Point(99, 264);
            this.lbl_CategoreyName.Name = "lbl_CategoreyName";
            this.lbl_CategoreyName.Size = new System.Drawing.Size(154, 20);
            this.lbl_CategoreyName.TabIndex = 18;
            this.lbl_CategoreyName.Text = " Categorey Name";
            // 
            // txt_CategoreyID
            // 
            this.txt_CategoreyID.BackColor = System.Drawing.Color.Silver;
            this.txt_CategoreyID.Location = new System.Drawing.Point(371, 190);
            this.txt_CategoreyID.Name = "txt_CategoreyID";
            this.txt_CategoreyID.Size = new System.Drawing.Size(145, 22);
            this.txt_CategoreyID.TabIndex = 19;
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.Silver;
            this.txt_Description.Location = new System.Drawing.Point(371, 327);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(145, 22);
            this.txt_Description.TabIndex = 20;
            // 
            // cmb_CategoryName
            // 
            this.cmb_CategoryName.BackColor = System.Drawing.Color.Silver;
            this.cmb_CategoryName.FormattingEnabled = true;
            this.cmb_CategoryName.Items.AddRange(new object[] {
            "Appliances",
            "Furniture",
            "Electronic Equipment",
            "Carpets"});
            this.cmb_CategoryName.Location = new System.Drawing.Point(371, 264);
            this.cmb_CategoryName.Name = "cmb_CategoryName";
            this.cmb_CategoryName.Size = new System.Drawing.Size(156, 24);
            this.cmb_CategoryName.TabIndex = 21;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 507);
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
            this.btn_ADD.Location = new System.Drawing.Point(103, 512);
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
            this.pictureBox4.Location = new System.Drawing.Point(319, 507);
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
            this.btn_UPDATE.Location = new System.Drawing.Point(387, 512);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(111, 48);
            this.btn_UPDATE.TabIndex = 53;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(594, 504);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.BackColor = System.Drawing.Color.HotPink;
            this.btn_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELETE.Location = new System.Drawing.Point(659, 507);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(109, 48);
            this.btn_DELETE.TabIndex = 55;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = false;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(827, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.BackColor = System.Drawing.Color.HotPink;
            this.btn_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEARCH.Location = new System.Drawing.Point(892, 502);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(116, 53);
            this.btn_SEARCH.TabIndex = 57;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = false;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.HotPink;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1139, 499);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(145, 56);
            this.btn_Home.TabIndex = 59;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // dgv_ProductCategorey
            // 
            this.dgv_ProductCategorey.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProductCategorey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductCategorey.GridColor = System.Drawing.Color.White;
            this.dgv_ProductCategorey.Location = new System.Drawing.Point(613, 150);
            this.dgv_ProductCategorey.Name = "dgv_ProductCategorey";
            this.dgv_ProductCategorey.RowTemplate.Height = 24;
            this.dgv_ProductCategorey.Size = new System.Drawing.Size(647, 301);
            this.dgv_ProductCategorey.TabIndex = 60;
            // 
            // Product_Categorey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1317, 629);
            this.Controls.Add(this.dgv_ProductCategorey);
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
            this.Controls.Add(this.cmb_CategoryName);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_CategoreyID);
            this.Controls.Add(this.lbl_CategoreyName);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_CategoreyID);
            this.Controls.Add(this.panel1);
            this.Name = "Product_Categorey";
            this.Text = "Product_Categorey";
            this.Load += new System.EventHandler(this.Product_Categorey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductCategorey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CategoreyID;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_CategoreyName;
        private System.Windows.Forms.TextBox txt_CategoreyID;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.ComboBox cmb_CategoryName;
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
        private System.Windows.Forms.DataGridView dgv_ProductCategorey;
    }
}