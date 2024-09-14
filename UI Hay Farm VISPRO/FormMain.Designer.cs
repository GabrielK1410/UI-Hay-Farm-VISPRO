namespace UI_Hay_Farm_VISPRO
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonInventaris = new System.Windows.Forms.Button();
            this.buttonPupukdanPenyiraman = new System.Windows.Forms.Button();
            this.buttonJadwalPanen = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(447, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME FARMERS.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonInventaris
            // 
            this.buttonInventaris.Location = new System.Drawing.Point(18, 101);
            this.buttonInventaris.Name = "buttonInventaris";
            this.buttonInventaris.Size = new System.Drawing.Size(188, 42);
            this.buttonInventaris.TabIndex = 2;
            this.buttonInventaris.Text = "Inventaris";
            this.buttonInventaris.UseVisualStyleBackColor = false;
            this.buttonInventaris.Click += new System.EventHandler(this.buttonInventaris_Click);
            // 
            // buttonPupukdanPenyiraman
            // 
            this.buttonPupukdanPenyiraman.Location = new System.Drawing.Point(18, 183);
            this.buttonPupukdanPenyiraman.Name = "buttonPupukdanPenyiraman";
            this.buttonPupukdanPenyiraman.Size = new System.Drawing.Size(188, 42);
            this.buttonPupukdanPenyiraman.TabIndex = 3;
            this.buttonPupukdanPenyiraman.Text = "Pupuk dan Penyiraman";
            this.buttonPupukdanPenyiraman.UseVisualStyleBackColor = true;
            this.buttonPupukdanPenyiraman.Click += new System.EventHandler(this.buttonPupukdanPenyiraman_Click);
            // 
            // buttonJadwalPanen
            // 
            this.buttonJadwalPanen.Location = new System.Drawing.Point(18, 265);
            this.buttonJadwalPanen.Name = "buttonJadwalPanen";
            this.buttonJadwalPanen.Size = new System.Drawing.Size(188, 42);
            this.buttonJadwalPanen.TabIndex = 4;
            this.buttonJadwalPanen.Text = "Jadwal Panen";
            this.buttonJadwalPanen.UseVisualStyleBackColor = true;
            this.buttonJadwalPanen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(18, 547);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(188, 42);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 672);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonJadwalPanen);
            this.Controls.Add(this.buttonPupukdanPenyiraman);
            this.Controls.Add(this.buttonInventaris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInventaris;
        private System.Windows.Forms.Button buttonPupukdanPenyiraman;
        private System.Windows.Forms.Button buttonJadwalPanen;
        private System.Windows.Forms.Button buttonLogout;
    }
}