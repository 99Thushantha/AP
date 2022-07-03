namespace Application_Development_Project
{
    partial class Manage_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.dgv_ManageProduct = new System.Windows.Forms.DataGridView();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductImage = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.pcb_ProductImage = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_ProductCategory = new System.Windows.Forms.Label();
            this.cmb_ProductCategory = new System.Windows.Forms.ComboBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 67);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(470, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manage Product";
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.HotPink;
            this.btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.Location = new System.Drawing.Point(69, 535);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(118, 48);
            this.btn_ADD.TabIndex = 1;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = false;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.BackColor = System.Drawing.Color.HotPink;
            this.btn_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UPDATE.Location = new System.Drawing.Point(327, 539);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(111, 48);
            this.btn_UPDATE.TabIndex = 2;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.BackColor = System.Drawing.Color.HotPink;
            this.btn_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DELETE.Location = new System.Drawing.Point(586, 539);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(109, 48);
            this.btn_DELETE.TabIndex = 3;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = false;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.BackColor = System.Drawing.Color.HotPink;
            this.btn_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEARCH.Location = new System.Drawing.Point(828, 537);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(112, 48);
            this.btn_SEARCH.TabIndex = 4;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = false;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dgv_ManageProduct
            // 
            this.dgv_ManageProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ManageProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageProduct.Location = new System.Drawing.Point(440, 107);
            this.dgv_ManageProduct.Name = "dgv_ManageProduct";
            this.dgv_ManageProduct.RowTemplate.Height = 24;
            this.dgv_ManageProduct.Size = new System.Drawing.Size(798, 361);
            this.dgv_ManageProduct.TabIndex = 5;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(14, 210);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(128, 20);
            this.lbl_ProductName.TabIndex = 6;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(14, 150);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(99, 20);
            this.lbl_ProductID.TabIndex = 7;
            this.lbl_ProductID.Text = "Product ID";
            // 
            // lbl_ProductImage
            // 
            this.lbl_ProductImage.AutoSize = true;
            this.lbl_ProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductImage.Location = new System.Drawing.Point(14, 336);
            this.lbl_ProductImage.Name = "lbl_ProductImage";
            this.lbl_ProductImage.Size = new System.Drawing.Size(130, 20);
            this.lbl_ProductImage.TabIndex = 8;
            this.lbl_ProductImage.Text = "Product Image";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BackColor = System.Drawing.Color.Silver;
            this.txt_ProductID.Location = new System.Drawing.Point(272, 150);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(145, 22);
            this.txt_ProductID.TabIndex = 11;
            // 
            // pcb_ProductImage
            // 
            this.pcb_ProductImage.BackColor = System.Drawing.Color.Silver;
            this.pcb_ProductImage.Location = new System.Drawing.Point(272, 327);
            this.pcb_ProductImage.Name = "pcb_ProductImage";
            this.pcb_ProductImage.Size = new System.Drawing.Size(145, 29);
            this.pcb_ProductImage.TabIndex = 15;
            this.pcb_ProductImage.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.HotPink;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(1093, 531);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(145, 56);
            this.btn_Home.TabIndex = 16;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_ProductCategory
            // 
            this.lbl_ProductCategory.AutoSize = true;
            this.lbl_ProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductCategory.Location = new System.Drawing.Point(14, 273);
            this.lbl_ProductCategory.Name = "lbl_ProductCategory";
            this.lbl_ProductCategory.Size = new System.Drawing.Size(155, 20);
            this.lbl_ProductCategory.TabIndex = 17;
            this.lbl_ProductCategory.Text = "Product Category";
            // 
            // cmb_ProductCategory
            // 
            this.cmb_ProductCategory.BackColor = System.Drawing.Color.Silver;
            this.cmb_ProductCategory.FormattingEnabled = true;
            this.cmb_ProductCategory.Items.AddRange(new object[] {
            "Appliances",
            "Furniture",
            "Electronic Equipment",
            "Carpets"});
            this.cmb_ProductCategory.Location = new System.Drawing.Point(272, 269);
            this.cmb_ProductCategory.Name = "cmb_ProductCategory";
            this.cmb_ProductCategory.Size = new System.Drawing.Size(145, 24);
            this.cmb_ProductCategory.TabIndex = 18;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BackColor = System.Drawing.Color.Silver;
            this.txt_ProductName.Location = new System.Drawing.Point(272, 210);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(145, 22);
            this.txt_ProductName.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1028, 531);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(763, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(521, 531);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(259, 534);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1, 531);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(14, 393);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(124, 20);
            this.lbl_ProductPrice.TabIndex = 48;
            this.lbl_ProductPrice.Text = "Product Price";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.BackColor = System.Drawing.Color.Silver;
            this.txt_ProductPrice.Location = new System.Drawing.Point(272, 393);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(145, 22);
            this.txt_ProductPrice.TabIndex = 49;
            // 
            // Manage_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1260, 650);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.cmb_ProductCategory);
            this.Controls.Add(this.lbl_ProductCategory);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pcb_ProductImage);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.lbl_ProductImage);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.dgv_ManageProduct);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Product";
            this.Text = "Manage_Product";
            this.Load += new System.EventHandler(this.Admin_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_UPDATE;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dgv_ManageProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_ProductImage;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.PictureBox pcb_ProductImage;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_ProductCategory;
        private System.Windows.Forms.ComboBox cmb_ProductCategory;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.TextBox txt_ProductPrice;
    }
}