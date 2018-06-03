using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme_BinaryGrayHistogram
{
    public partial class ImageConverter : Form
    {
        public ImageConverter()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> imgGiris;
        Image<Gray, byte> imgBinary;        
        Image<Gray, byte> imgGri;

        void Temizle()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            imgGiris = null;
            imgBinary = null;
            imgGri = null;
            hisBox1.ClearHistogram();
            hisBox2.ClearHistogram();
            hisBox3.ClearHistogram();
            hisBox1.Refresh();
            hisBox2.Refresh();
            hisBox3.Refresh();
            btnBinaryYap.Enabled = false;
            btnGriYap.Enabled = false;
        }

        void Ekle()
        {
            Temizle(); //Önce temizle
            OpenFileDialog dosyaekle = new OpenFileDialog(); //Dosya eklemek için OpenFileDialog sınıfından nesne oluşturduk
            dosyaekle.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files(*.*) | *.* "; //Sadece fotoğraf formatındaki dosyalara erişebilmek için
            if (dosyaekle.ShowDialog() == DialogResult.OK) //Dosya seçilip OK'a basılırsa aşağıya geç
            {
                imgGiris = new Image<Bgr, byte>(dosyaekle.FileName); //imgGiris'e oluşan nesnenin adını Image parametreleriyle ata
                pictureBox1.Image = imgGiris.Bitmap; //pictureBox1'e imgGiris'in Bitmap'ini ata

                //Orjinal resmin histogramını oluşturma
                hisBox1.ClearHistogram();
                hisBox1.GenerateHistograms(imgGiris, 256);
                hisBox1.Refresh();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) //Form ilk açıldığında (picturebox1'e henüz resim eklenmediğinde) Gri ve Binary'ye çevirme butonları aktif olmasın
            {
                btnGriYap.Enabled = false;
                btnBinaryYap.Enabled = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //picturebox1 doluysa
            {
                DialogResult ekle = new DialogResult();
                ekle = MessageBox.Show("Yeni fotoğraf eklerseniz şimdiki fotoğraflar silinecek.\nEmin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //emin misiniz sorusunu sor
                if (ekle == DialogResult.Yes) //Yes'e basılırsa Ekle fonksiyonunu çağır ve griyap butonunu aktifleştir. Yoksa bir şey yapma
                {
                    Ekle();
                    btnGriYap.Enabled = true;
                }
            }
            else //picturebox1 boşsa Ekle fonksiyonunu çağır ve butonu aktifleştir
            {
                Ekle();
                btnGriYap.Enabled = true;
            }
        }

        private void btnGriYap_Click(object sender, EventArgs e)
        {
            imgGri = imgGiris.Convert<Gray, byte>();
            pictureBox2.Image = imgGri.Bitmap;

            //Gri resmin histogramını oluşturma
            hisBox2.ClearHistogram();
            hisBox2.GenerateHistograms(imgGri, 256);
            hisBox2.Refresh();

            if (pictureBox2.Image != null) //picturebox2'ye resim geldiyse Binary Yap butonunu göster
            {
                btnBinaryYap.Enabled = true;
            }
        }

        private void btnBinaryYap_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null || pictureBox2.Image != null)
            {
                imgBinary = new Image<Gray, byte>(imgGri.Width, imgGri.Height, new Gray(0));
                CvInvoke.Threshold(imgGri, imgBinary, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                pictureBox3.Image = imgBinary.Bitmap;

                //Binary resmin histogramını oluşturma
                hisBox3.ClearHistogram();
                hisBox3.GenerateHistograms(imgBinary, 256);
                hisBox3.Refresh();
            }
            else
            {
                MessageBox.Show("Binary resim elde etmek için önce gri resmi elde ediniz", "Eksik resim", MessageBoxButtons.OK);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                DialogResult temizle = new DialogResult();
                temizle = MessageBox.Show("Temizlemek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (temizle == DialogResult.Yes)
                {
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Temizlenecek resim yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
