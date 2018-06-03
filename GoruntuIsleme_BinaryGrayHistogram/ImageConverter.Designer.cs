namespace GoruntuIsleme_BinaryGrayHistogram
{
    partial class ImageConverter
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBinaryYap = new System.Windows.Forms.Button();
            this.btnGriYap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.hisBox3 = new Emgu.CV.UI.HistogramBox();
            this.hisBox2 = new Emgu.CV.UI.HistogramBox();
            this.hisBox1 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(670, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(221, 34);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBinaryYap
            // 
            this.btnBinaryYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBinaryYap.Location = new System.Drawing.Point(450, 13);
            this.btnBinaryYap.Name = "btnBinaryYap";
            this.btnBinaryYap.Size = new System.Drawing.Size(221, 34);
            this.btnBinaryYap.TabIndex = 19;
            this.btnBinaryYap.Text = "Binary Yap";
            this.btnBinaryYap.UseVisualStyleBackColor = true;
            this.btnBinaryYap.Click += new System.EventHandler(this.btnBinaryYap_Click);
            // 
            // btnGriYap
            // 
            this.btnGriYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGriYap.Location = new System.Drawing.Point(230, 13);
            this.btnGriYap.Name = "btnGriYap";
            this.btnGriYap.Size = new System.Drawing.Size(221, 34);
            this.btnGriYap.TabIndex = 18;
            this.btnGriYap.Text = "Gri Yap";
            this.btnGriYap.UseVisualStyleBackColor = true;
            this.btnGriYap.Click += new System.EventHandler(this.btnGriYap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(620, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(271, 230);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(317, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(10, 13);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(221, 35);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Fotoğraf Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // hisBox3
            // 
            this.hisBox3.Location = new System.Drawing.Point(620, 320);
            this.hisBox3.Name = "hisBox3";
            this.hisBox3.Size = new System.Drawing.Size(271, 230);
            this.hisBox3.TabIndex = 11;
            // 
            // hisBox2
            // 
            this.hisBox2.Location = new System.Drawing.Point(317, 320);
            this.hisBox2.Name = "hisBox2";
            this.hisBox2.Size = new System.Drawing.Size(271, 230);
            this.hisBox2.TabIndex = 12;
            // 
            // hisBox1
            // 
            this.hisBox1.Location = new System.Drawing.Point(10, 320);
            this.hisBox1.Name = "hisBox1";
            this.hisBox1.Size = new System.Drawing.Size(271, 230);
            this.hisBox1.TabIndex = 13;
            // 
            // ImageConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 563);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBinaryYap);
            this.Controls.Add(this.btnGriYap);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.hisBox3);
            this.Controls.Add(this.hisBox2);
            this.Controls.Add(this.hisBox1);
            this.Name = "ImageConverter";
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBinaryYap;
        private System.Windows.Forms.Button btnGriYap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEkle;
        private Emgu.CV.UI.HistogramBox hisBox3;
        private Emgu.CV.UI.HistogramBox hisBox2;
        private Emgu.CV.UI.HistogramBox hisBox1;
    }
}

