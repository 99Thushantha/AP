namespace Application_Development_Project
{
    partial class View_Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Job));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Viewjob = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_HOME = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viewjob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1119, 100);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(299, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "View Jobs States Report";
            // 
            // dgv_Viewjob
            // 
            this.dgv_Viewjob.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Viewjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Viewjob.Location = new System.Drawing.Point(105, 146);
            this.dgv_Viewjob.Name = "dgv_Viewjob";
            this.dgv_Viewjob.RowTemplate.Height = 24;
            this.dgv_Viewjob.Size = new System.Drawing.Size(947, 332);
            this.dgv_Viewjob.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.BackColor = System.Drawing.Color.HotPink;
            this.btn_SEARCH.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEARCH.Location = new System.Drawing.Point(290, 522);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(158, 56);
            this.btn_SEARCH.TabIndex = 45;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(721, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // btn_HOME
            // 
            this.btn_HOME.BackColor = System.Drawing.Color.HotPink;
            this.btn_HOME.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HOME.Location = new System.Drawing.Point(786, 525);
            this.btn_HOME.Name = "btn_HOME";
            this.btn_HOME.Size = new System.Drawing.Size(151, 50);
            this.btn_HOME.TabIndex = 47;
            this.btn_HOME.Text = "HOME";
            this.btn_HOME.UseVisualStyleBackColor = false;
            // 
            // View_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1119, 620);
            this.Controls.Add(this.btn_HOME);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Viewjob);
            this.Controls.Add(this.panel1);
            this.Name = "View_Job";
            this.Text = "View_Jobs States Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viewjob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Viewjob;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_HOME;
    }
}