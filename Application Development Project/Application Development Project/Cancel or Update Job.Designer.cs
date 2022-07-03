namespace Application_Development_Project
{
    partial class Cancel_or_Update_Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancel_or_Update_Job));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductCategorey = new System.Windows.Forms.Label();
            this.lbl_Quentity = new System.Windows.Forms.Label();
            this.lbl_ProductImage = new System.Windows.Forms.Label();
            this.lbl_StartLocation = new System.Windows.Forms.Label();
            this.lbl_EndLocation = new System.Windows.Forms.Label();
            this.lbl_JobID = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.cmb_ProductCategory = new System.Windows.Forms.ComboBox();
            this.txt_Quentity = new System.Windows.Forms.TextBox();
            this.pcb_Productimage = new System.Windows.Forms.PictureBox();
            this.txt_StartLocation = new System.Windows.Forms.TextBox();
            this.txt_EndLocation = new System.Windows.Forms.TextBox();
            this.txt_JobID = new System.Windows.Forms.TextBox();
            this.dgv_CancelorUpdatejob = new System.Windows.Forms.DataGridView();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_HOME = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Productimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CancelorUpdatejob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 88);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(287, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(465, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cancel or Update Job";
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerID.Location = new System.Drawing.Point(80, 168);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(115, 20);
            this.lbl_CustomerID.TabIndex = 13;
            this.lbl_CustomerID.Text = "Customer ID";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(80, 209);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(144, 20);
            this.lbl_CustomerName.TabIndex = 19;
            this.lbl_CustomerName.Text = "Customer Nmae";
            this.lbl_CustomerName.Click += new System.EventHandler(this.lbl_CustomerName_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductName.Location = new System.Drawing.Point(80, 252);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(128, 20);
            this.lbl_ProductName.TabIndex = 20;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // lbl_ProductCategorey
            // 
            this.lbl_ProductCategorey.AutoSize = true;
            this.lbl_ProductCategorey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductCategorey.Location = new System.Drawing.Point(80, 302);
            this.lbl_ProductCategorey.Name = "lbl_ProductCategorey";
            this.lbl_ProductCategorey.Size = new System.Drawing.Size(165, 20);
            this.lbl_ProductCategorey.TabIndex = 21;
            this.lbl_ProductCategorey.Text = "Product Categorey";
            // 
            // lbl_Quentity
            // 
            this.lbl_Quentity.AutoSize = true;
            this.lbl_Quentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Quentity.Location = new System.Drawing.Point(80, 345);
            this.lbl_Quentity.Name = "lbl_Quentity";
            this.lbl_Quentity.Size = new System.Drawing.Size(79, 20);
            this.lbl_Quentity.TabIndex = 22;
            this.lbl_Quentity.Text = "Quentity";
            // 
            // lbl_ProductImage
            // 
            this.lbl_ProductImage.AutoSize = true;
            this.lbl_ProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductImage.Location = new System.Drawing.Point(82, 389);
            this.lbl_ProductImage.Name = "lbl_ProductImage";
            this.lbl_ProductImage.Size = new System.Drawing.Size(130, 20);
            this.lbl_ProductImage.TabIndex = 23;
            this.lbl_ProductImage.Text = "Product Image";
            // 
            // lbl_StartLocation
            // 
            this.lbl_StartLocation.AutoSize = true;
            this.lbl_StartLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_StartLocation.Location = new System.Drawing.Point(82, 431);
            this.lbl_StartLocation.Name = "lbl_StartLocation";
            this.lbl_StartLocation.Size = new System.Drawing.Size(128, 20);
            this.lbl_StartLocation.TabIndex = 24;
            this.lbl_StartLocation.Text = "Start Location";
            // 
            // lbl_EndLocation
            // 
            this.lbl_EndLocation.AutoSize = true;
            this.lbl_EndLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_EndLocation.Location = new System.Drawing.Point(82, 483);
            this.lbl_EndLocation.Name = "lbl_EndLocation";
            this.lbl_EndLocation.Size = new System.Drawing.Size(119, 20);
            this.lbl_EndLocation.TabIndex = 25;
            this.lbl_EndLocation.Text = "End Location";
            // 
            // lbl_JobID
            // 
            this.lbl_JobID.AutoSize = true;
            this.lbl_JobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JobID.Location = new System.Drawing.Point(84, 123);
            this.lbl_JobID.Name = "lbl_JobID";
            this.lbl_JobID.Size = new System.Drawing.Size(64, 20);
            this.lbl_JobID.TabIndex = 26;
            this.lbl_JobID.Text = "Job ID";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BackColor = System.Drawing.Color.Silver;
            this.txt_CustomerID.Location = new System.Drawing.Point(302, 166);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(165, 22);
            this.txt_CustomerID.TabIndex = 27;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BackColor = System.Drawing.Color.Silver;
            this.txt_CustomerName.Location = new System.Drawing.Point(302, 209);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(165, 22);
            this.txt_CustomerName.TabIndex = 28;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BackColor = System.Drawing.Color.Silver;
            this.txt_ProductName.Location = new System.Drawing.Point(302, 250);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(165, 22);
            this.txt_ProductName.TabIndex = 29;
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
            this.cmb_ProductCategory.Location = new System.Drawing.Point(302, 302);
            this.cmb_ProductCategory.Name = "cmb_ProductCategory";
            this.cmb_ProductCategory.Size = new System.Drawing.Size(170, 24);
            this.cmb_ProductCategory.TabIndex = 30;
            // 
            // txt_Quentity
            // 
            this.txt_Quentity.BackColor = System.Drawing.Color.Silver;
            this.txt_Quentity.Location = new System.Drawing.Point(302, 345);
            this.txt_Quentity.Name = "txt_Quentity";
            this.txt_Quentity.Size = new System.Drawing.Size(165, 22);
            this.txt_Quentity.TabIndex = 31;
            // 
            // pcb_Productimage
            // 
            this.pcb_Productimage.BackColor = System.Drawing.Color.Silver;
            this.pcb_Productimage.Location = new System.Drawing.Point(302, 389);
            this.pcb_Productimage.Name = "pcb_Productimage";
            this.pcb_Productimage.Size = new System.Drawing.Size(165, 33);
            this.pcb_Productimage.TabIndex = 32;
            this.pcb_Productimage.TabStop = false;
            // 
            // txt_StartLocation
            // 
            this.txt_StartLocation.BackColor = System.Drawing.Color.Silver;
            this.txt_StartLocation.Location = new System.Drawing.Point(302, 440);
            this.txt_StartLocation.Name = "txt_StartLocation";
            this.txt_StartLocation.Size = new System.Drawing.Size(165, 22);
            this.txt_StartLocation.TabIndex = 33;
            // 
            // txt_EndLocation
            // 
            this.txt_EndLocation.BackColor = System.Drawing.Color.Silver;
            this.txt_EndLocation.Location = new System.Drawing.Point(302, 483);
            this.txt_EndLocation.Name = "txt_EndLocation";
            this.txt_EndLocation.Size = new System.Drawing.Size(165, 22);
            this.txt_EndLocation.TabIndex = 34;
            // 
            // txt_JobID
            // 
            this.txt_JobID.BackColor = System.Drawing.Color.Silver;
            this.txt_JobID.Location = new System.Drawing.Point(302, 121);
            this.txt_JobID.Name = "txt_JobID";
            this.txt_JobID.Size = new System.Drawing.Size(165, 22);
            this.txt_JobID.TabIndex = 35;
            // 
            // dgv_CancelorUpdatejob
            // 
            this.dgv_CancelorUpdatejob.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CancelorUpdatejob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CancelorUpdatejob.GridColor = System.Drawing.Color.Silver;
            this.dgv_CancelorUpdatejob.Location = new System.Drawing.Point(519, 143);
            this.dgv_CancelorUpdatejob.Name = "dgv_CancelorUpdatejob";
            this.dgv_CancelorUpdatejob.RowTemplate.Height = 24;
            this.dgv_CancelorUpdatejob.Size = new System.Drawing.Size(557, 362);
            this.dgv_CancelorUpdatejob.TabIndex = 36;
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.BackColor = System.Drawing.Color.HotPink;
            this.btn_UPDATE.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UPDATE.Location = new System.Drawing.Point(207, 574);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(150, 50);
            this.btn_UPDATE.TabIndex = 37;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = false;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.BackColor = System.Drawing.Color.HotPink;
            this.btn_CANCEL.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CANCEL.Location = new System.Drawing.Point(560, 574);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(158, 51);
            this.btn_CANCEL.TabIndex = 38;
            this.btn_CANCEL.Text = "CANCEL";
            this.btn_CANCEL.UseVisualStyleBackColor = false;
            this.btn_CANCEL.Click += new System.EventHandler(this.btn_CANCEL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(492, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(819, 569);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_HOME
            // 
            this.btn_HOME.BackColor = System.Drawing.Color.HotPink;
            this.btn_HOME.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HOME.Location = new System.Drawing.Point(884, 574);
            this.btn_HOME.Name = "btn_HOME";
            this.btn_HOME.Size = new System.Drawing.Size(158, 51);
            this.btn_HOME.TabIndex = 42;
            this.btn_HOME.Text = "HOME";
            this.btn_HOME.UseVisualStyleBackColor = false;
            this.btn_HOME.Click += new System.EventHandler(this.btn_HOME_Click);
            // 
            // Cancel_or_Update_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1105, 664);
            this.Controls.Add(this.btn_HOME);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.dgv_CancelorUpdatejob);
            this.Controls.Add(this.txt_JobID);
            this.Controls.Add(this.txt_EndLocation);
            this.Controls.Add(this.txt_StartLocation);
            this.Controls.Add(this.pcb_Productimage);
            this.Controls.Add(this.txt_Quentity);
            this.Controls.Add(this.cmb_ProductCategory);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.lbl_JobID);
            this.Controls.Add(this.lbl_EndLocation);
            this.Controls.Add(this.lbl_StartLocation);
            this.Controls.Add(this.lbl_ProductImage);
            this.Controls.Add(this.lbl_Quentity);
            this.Controls.Add(this.lbl_ProductCategorey);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_CustomerID);
            this.Controls.Add(this.panel1);
            this.Name = "Cancel_or_Update_Job";
            this.Text = "Cancel_or_Update_Job";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Productimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CancelorUpdatejob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CustomerID;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductCategorey;
        private System.Windows.Forms.Label lbl_Quentity;
        private System.Windows.Forms.Label lbl_ProductImage;
        private System.Windows.Forms.Label lbl_StartLocation;
        private System.Windows.Forms.Label lbl_EndLocation;
        private System.Windows.Forms.Label lbl_JobID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.ComboBox cmb_ProductCategory;
        private System.Windows.Forms.TextBox txt_Quentity;
        private System.Windows.Forms.PictureBox pcb_Productimage;
        private System.Windows.Forms.TextBox txt_StartLocation;
        private System.Windows.Forms.TextBox txt_EndLocation;
        private System.Windows.Forms.TextBox txt_JobID;
        private System.Windows.Forms.DataGridView dgv_CancelorUpdatejob;
        private System.Windows.Forms.Button btn_UPDATE;
        private System.Windows.Forms.Button btn_CANCEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_HOME;
    }
}