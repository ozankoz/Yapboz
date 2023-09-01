using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Yapboz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int farex, farey = 0;
        int seviye = 100;
        int parca = 16;
        int[] seviyeler = { 100, 80, 50, 40 };
        string dosyaKonum = string.Empty;
        private void ResimleriDiz()
        {
            panelBoard.Controls.Clear();
            int iks = 0;
            int ye = 0;
            for (int i = 1; i < parca + 1; i++)
            {
                Label lbl = new Label();
                lbl.Name = i.ToString();
                lbl.Tag = i.ToString();
                lbl.BackgroundImage = Image.FromFile(Application.StartupPath + @"\photo\" + cbSeviye.SelectedItem.ToString() + " " + i + ".jpg");
                lbl.Size = new System.Drawing.Size(seviye, seviye);
                lbl.Margin = new System.Windows.Forms.Padding(1);
                lbl.Location = new Point(iks, ye);
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.MouseUp += lbl_MouseUp;
                iks += seviye;
                if (iks >= 400)
                {
                    iks = 0;
                }
                ye = (i / Convert.ToInt32(Math.Sqrt(parca))) * seviye;
                panelBoard.Controls.Add(lbl);
            }
            pictureBox1.Image = Image.FromFile(dosyaKonum);
            btnKaristir.Enabled = true;
        }

        void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            ArrayList labelcevresi = new ArrayList();
            int boslabel = 0;
            int satir = Convert.ToInt32(lbl.Tag) / Convert.ToInt32(Math.Sqrt(parca));
            int sutun = Convert.ToInt32(lbl.Tag) - (Convert.ToInt32(Math.Sqrt(parca)) * satir);
            if (sutun == 0)
            {
                sutun = Convert.ToInt32(Math.Sqrt(parca));
                satir = satir - 1;
            }
            for (int i = sutun - 1; i > 0; i--)
            {
                labelcevresi.Add(i + (Convert.ToInt32(Math.Sqrt(parca)) * satir));
            }
            for (int i = sutun + 1; i < Convert.ToInt32(Math.Sqrt(parca)) + 1; i++)
            {
                labelcevresi.Add(i + (Convert.ToInt32(Math.Sqrt(parca)) * satir));
            }
            for (int i = satir - 1; i > -1; i--)
            {
                labelcevresi.Add((i * Convert.ToInt32(Math.Sqrt(parca))) + sutun);
            }
            for (int i = satir + 1; i < Convert.ToInt32(Math.Sqrt(parca)); i++)
            {
                labelcevresi.Add((i * Convert.ToInt32(Math.Sqrt(parca))) + sutun);
            }
            foreach (Label item in panelBoard.Controls)
            {
                if (item.BackgroundImage == null)
                {
                    boslabel = Convert.ToInt32(item.Tag);
                    int gidilecekkareadedi = (Convert.ToInt32(lbl.Tag) - boslabel) * -1;
                }
            }
            foreach (int cevrelabel in labelcevresi)
            {
                if (cevrelabel == boslabel)
                {
                    int gidilecekkareadedi = (Convert.ToInt32(lbl.Tag) - boslabel) * -1;
                    if (gidilecekkareadedi > 0 && gidilecekkareadedi < Convert.ToInt32(Math.Sqrt(parca)))
                    {
                        for (int i = gidilecekkareadedi; i > -1; i--)
                        {
                            foreach (Label item in panelBoard.Controls)
                            {
                                if (Convert.ToInt32(item.Tag) == Convert.ToInt32(lbl.Tag) + i)
                                {
                                    foreach (Label mitem in panelBoard.Controls)
                                    {
                                        if (mitem.BackgroundImage == null)
                                        {
                                            mitem.Location = new Point(mitem.Location.X - (gidilecekkareadedi * mitem.Height), mitem.Location.Y);
                                            mitem.Tag = boslabel - gidilecekkareadedi;
                                        }
                                    }
                                    item.Location = new Point(item.Location.X + item.Height, item.Location.Y);
                                    item.Tag = Convert.ToInt32(item.Tag) + 1;
                                }
                            }
                        }
                    }
                    if (gidilecekkareadedi < 0 && gidilecekkareadedi > Convert.ToInt32(Math.Sqrt(parca) * -1))
                    {
                        for (int i = gidilecekkareadedi; i < 1; i++)
                        {
                            foreach (Label item in panelBoard.Controls)
                            {
                                if (Convert.ToInt32(item.Tag) == Convert.ToInt32(lbl.Tag) + i)
                                {
                                    foreach (Label mitem in panelBoard.Controls)
                                    {
                                        if (mitem.BackgroundImage == null)
                                        {
                                            mitem.Location = new Point(mitem.Location.X + (gidilecekkareadedi * mitem.Height * -1), mitem.Location.Y);
                                            mitem.Tag = boslabel - gidilecekkareadedi;
                                        }
                                    }
                                    item.Location = new Point(item.Location.X - item.Height, item.Location.Y);
                                    item.Tag = Convert.ToInt32(item.Tag) - 1;
                                }
                            }
                        }
                    }
                    if (gidilecekkareadedi <= Convert.ToInt32(Math.Sqrt(parca) * -1))
                    {
                        for (int i = -1; i > gidilecekkareadedi / Convert.ToInt32(Math.Sqrt(parca)) - 1; i--)
                        {
                            foreach (Label item in panelBoard.Controls)
                            {
                                if (Convert.ToInt32(item.Tag) == Convert.ToInt32(lbl.Tag) + gidilecekkareadedi + (Convert.ToInt32(Math.Sqrt(parca)) * i * -1))
                                {
                                    foreach (Label mitem in panelBoard.Controls)
                                    {
                                        if (mitem.BackgroundImage == null)
                                        {
                                            mitem.Location = new Point(mitem.Location.X, mitem.Location.Y + mitem.Height * -1);
                                            mitem.Tag = boslabel - gidilecekkareadedi;
                                        }
                                    }
                                    item.Location = new Point(item.Location.X, item.Location.Y - item.Height);
                                    item.Tag = Convert.ToInt32(item.Tag) - Convert.ToInt32(Math.Sqrt(parca));
                                }
                            }
                        }
                    }
                    if (gidilecekkareadedi >= Convert.ToInt32(Math.Sqrt(parca)))
                    {
                        for (int i = 1; i < gidilecekkareadedi / Convert.ToInt32(Math.Sqrt(parca)) + 1; i++)
                        {
                            foreach (Label item in panelBoard.Controls)
                            {
                                if (Convert.ToInt32(item.Tag) == Convert.ToInt32(lbl.Tag) + gidilecekkareadedi + (Convert.ToInt32(Math.Sqrt(parca)) * i * -1))
                                {
                                    foreach (Label mitem in panelBoard.Controls)
                                    {
                                        if (mitem.BackgroundImage == null)
                                        {
                                            mitem.Location = new Point(mitem.Location.X, mitem.Location.Y - mitem.Height);
                                            mitem.Tag = boslabel - gidilecekkareadedi;
                                        }
                                    }
                                    item.Location = new Point(item.Location.X, item.Location.Y + item.Height);
                                    item.Tag = Convert.ToInt32(item.Tag) + Convert.ToInt32(Math.Sqrt(parca));
                                }
                            }
                        }
                    }
                }
            }
        }
        private Image Crop(Image img, Rectangle rect)
        {
            Bitmap bmpOrj = new Bitmap(img);
            Bitmap bmpCrop = bmpOrj.Clone(rect, bmpOrj.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            panelBoard.Enabled = true;
            ArrayList siralama = new ArrayList();
            foreach (var label in panelBoard.Controls)
            {
                if (label is Label)
                {
                    Label lbl = label as Label;
                    if (Convert.ToInt32(lbl.Name) == parca)
                    {
                        lbl.BackgroundImage = null;
                        lbl.BorderStyle = BorderStyle.None;
                    }
                }
            }
            for (int i = 1; i < parca + 1; i++)
            {
                siralama.Add(i);
            }
            shuffle(siralama);
            int iks = 0;
            int ye = 0;
            int kacinci = 0;
            foreach (int item in siralama)
            {
                foreach (Label lbl in panelBoard.Controls)
                {
                    if (item == Convert.ToInt32(lbl.Name))
                    {
                        kacinci++;
                        lbl.Tag = kacinci;
                        lbl.Location = new Point(iks, ye);
                        iks += seviye;
                        if (iks >= 400)
                        {
                            iks = 0;
                        }
                        ye = (kacinci / Convert.ToInt32(Math.Sqrt(parca))) * seviye;
                    }
                }

            }
        }
        public static void shuffle(ArrayList array)
        {
            Random rng = new Random(); // i.e., java.util.Random.
            int n = array.Count; // The number of items left to shuffle (loop invariant).
            while (n > 1)
            {
                int k = rng.Next(n); // 0 <= k < n.
                n--; // n is now the last pertinent index;
                int temp = Convert.ToInt32(array[n]); // swap array[n] with array[k] (does nothing if k == n).
                array[n] = array[k];
                array[k] = temp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbSeviye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeviye.SelectedIndex == 0)
            {
                seviye = 100;
                parca = 16;
            }
            else if (cbSeviye.SelectedIndex == 1)
            {
                seviye = 80;
                parca = 25;
            }
            else if (cbSeviye.SelectedIndex == 2)
            {
                seviye = 50;
                parca = 64;
            }
            else
            {
                seviye = 40;
                parca = 100;
            }
            ResimleriDiz();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ofdResimSec.Filter = "*.jpeg, *.jpg)|*.jpeg;*.jpg";
            ofdResimSec.ShowDialog();
            dosyaKonum = ofdResimSec.FileName;
            if (dosyaKonum == "")
            {
                return;
            }
            btnResimSec.Enabled = false;
            //if (File.Exists(Application.StartupPath + @"\photo.jpg"))
            //{
            //    dosyaKonum = Application.StartupPath + @"\photo.jpg";
            //}
            //else if (File.Exists(Application.StartupPath + @"\photo.jpeg"))
            //{
            //    dosyaKonum = Application.StartupPath + @"\photo.jpeg";
            //}
            //else
            //{
            //    ofdResimSec.Filter = "*.jpeg, *.jpg)|*.jpeg;*.jpg";
            //    ofdResimSec.ShowDialog();
            //    dosyaKonum = ofdResimSec.FileName;
            //    this.BringToFront();
            //}
            //try
            //{
            //    File.Copy(dosyaKonum, Application.StartupPath + "\\photothump.jpg", true);
            //}
            //catch
            //{
            //    MessageBox.Show("Bu resim başka bir işlemde kullanılıyor.");
            //    return;
            //}
            //File.Delete(dosyaKonum);
            //dosyaKonum = Application.StartupPath + "\\photothump.jpg";
            Image anaResim = Image.FromFile(dosyaKonum);
            int kare = seviye;
            if (anaResim.Height % kare != 0 || anaResim.Width % kare != 0)
            {
                MessageBox.Show("Resim bu ölçülerde boyutlandırılmaz.");
                Application.Exit();
            }
            else if (anaResim.Height > 400)
            {
                Bitmap yeniresim = new Bitmap(anaResim, 400, 400);
                anaResim = yeniresim;
            }
            else if (anaResim.Height < 400)
            {
                MessageBox.Show("Resim boyutları çok küçük, lütfen başka bir resim seçiniz.");
                Application.Exit();
            }
            int parcanumarasi = 0;
            int seviyesirasi = 0;
            foreach (var item in cbSeviye.Items)
            {
                kare = seviyeler[seviyesirasi];
                int dikeyParca = anaResim.Height / kare;
                int yatayParca = anaResim.Width / kare;
                Rectangle cropAlani = new Rectangle(0, 0, kare, kare);
                for (int i = 0; i < dikeyParca; i++)
                {
                    for (int y = 0; y < yatayParca; y++)
                    {
                        cropAlani.Y = i * kare;
                        cropAlani.X = y * kare;
                        Image parcaResim = Crop(anaResim, cropAlani);
                        if (Directory.Exists(Application.StartupPath + @"\photo\") == false)
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\photo\");
                        }
                        parcanumarasi++;
                        parcaResim.Save(Application.StartupPath + @"\photo\" + item.ToString() + " " + parcanumarasi + ".jpg", ImageFormat.Jpeg);
                    }
                }
                parcanumarasi = 0;
                seviyesirasi++;
            }
            cbSeviye.SelectedIndex = 0;
        }
    }
}
