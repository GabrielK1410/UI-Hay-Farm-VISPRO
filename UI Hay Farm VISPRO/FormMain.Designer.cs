namespace UI_Hay_Farm_VISPRO
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPupukdanPenyiraman = new System.Windows.Forms.Button();
            this.buttonJadwalPanen = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnPengaturanAkun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 1231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonPupukdanPenyiraman
            // 
            this.buttonPupukdanPenyiraman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPupukdanPenyiraman.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonPupukdanPenyiraman.Image = ((System.Drawing.Image)(resources.GetObject("buttonPupukdanPenyiraman.Image")));
            this.buttonPupukdanPenyiraman.Location = new System.Drawing.Point(493, 177);
            this.buttonPupukdanPenyiraman.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonPupukdanPenyiraman.Name = "buttonPupukdanPenyiraman";
            this.buttonPupukdanPenyiraman.Size = new System.Drawing.Size(511, 365);
            this.buttonPupukdanPenyiraman.TabIndex = 3;
            this.buttonPupukdanPenyiraman.Text = "Pupuk dan Penyiraman";
            this.buttonPupukdanPenyiraman.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPupukdanPenyiraman.UseVisualStyleBackColor = true;
            this.buttonPupukdanPenyiraman.Click += new System.EventHandler(this.buttonPupukdanPenyiraman_Click);
            // 
            // buttonJadwalPanen
            // 
            this.buttonJadwalPanen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonJadwalPanen.ForeColor = System.Drawing.Color.YellowGreen;
            this.buttonJadwalPanen.Image = ((System.Drawing.Image)(resources.GetObject("buttonJadwalPanen.Image")));
            this.buttonJadwalPanen.Location = new System.Drawing.Point(1225, 168);
            this.buttonJadwalPanen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonJadwalPanen.Name = "buttonJadwalPanen";
            this.buttonJadwalPanen.Size = new System.Drawing.Size(511, 365);
            this.buttonJadwalPanen.TabIndex = 4;
            this.buttonJadwalPanen.Text = "Jadwal Panen";
            this.buttonJadwalPanen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonJadwalPanen.UseVisualStyleBackColor = true;
            this.buttonJadwalPanen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(30, 49);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 185);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // btnPengaturanAkun
            // 
            this.btnPengaturanAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPengaturanAkun.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnPengaturanAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnPengaturanAkun.Image")));
            this.btnPengaturanAkun.Location = new System.Drawing.Point(1225, 606);
            this.btnPengaturanAkun.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPengaturanAkun.Name = "btnPengaturanAkun";
            this.btnPengaturanAkun.Size = new System.Drawing.Size(511, 365);
            this.btnPengaturanAkun.TabIndex = 6;
            this.btnPengaturanAkun.Text = "Pengaturan Akun";
            this.btnPengaturanAkun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPengaturanAkun.UseVisualStyleBackColor = false;
            this.btnPengaturanAkun.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 35F);
            this.label1.Location = new System.Drawing.Point(629, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 105);
            this.label1.TabIndex = 7;
            this.label1.Text = "WElCOME FARMERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(493, 606);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 365);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inventaris";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPengaturanAkun);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonJadwalPanen);
            this.Controls.Add(this.buttonPupukdanPenyiraman);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.YellowGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPupukdanPenyiraman;
        private System.Windows.Forms.Button buttonJadwalPanen;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button btnPengaturanAkun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}