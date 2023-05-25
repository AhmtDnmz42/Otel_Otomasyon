using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using System.Net.NetworkInformation;
using System.Net;
using FireSharp;

namespace Otel_Otomasyon
{
    public partial class Anasayfa : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "f71g7wBGjDomllOT3ClC9taTMoZTOFVitj09aAz9",
            BasePath = "https://console.firebase.google.com/project/otel-otomasyonu/database/otel-otomasyonu-default-rtdb/data/~2F"
        };

        IFirebaseClient client;
        public Anasayfa()
        {
            InitializeComponent();
        }

        static bool baglantiKontrol()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com",1000).Status==System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baglantiKontrol() == false)
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz!");
                this.Close();
            }
            else
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    MessageBox.Show("Bağlantı Başarılı");
                }
                else
                {
                    MessageBox.Show("Bağlantı Başarısız");
                }
            }


        }
        int intImgNum = 0;
        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[intImgNum];
            if(intImgNum == imageList1.Images.Count - 1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Galeri galeriSayfasi = new Galeri();
            galeriSayfasi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bize_ulasin iletisim = new Bize_ulasin();
            iletisim.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kurumsal kurumsalSayfa = new kurumsal();
            kurumsalSayfa.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void OtelSecim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            rezervasyonYap rezerv = new rezervasyonYap();
            rezerv.Show();
            this.Hide();
        }
    }
}
