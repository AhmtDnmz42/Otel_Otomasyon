using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Otel_Otomasyon
{
    public partial class rezervasyonYap : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        
        {
            AuthSecret = "f71g7wBGjDomllOT3ClC9taTMoZTOFVitj09aAz9",
            BasePath = "https://console.firebase.google.com/project/otel-otomasyonu/database/otel-otomasyonu-default-rtdb/data/~2F"
        };

        IFirebaseClient client;
        public rezervasyonYap()
        {
            InitializeComponent();
        }

        static bool baglantiKontrol()
        {
            try
            {
                return new System.Net.NetworkInformation.Ping().Send("www.google.com", 1000).Status == System.Net.NetworkInformation.IPStatus.Success;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void rezervasyonYap_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

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
                    MessageBox.Show("Rezervasyon için bilgilerinizi eksiksiz doldurunuz");
                }
                else
                {
                    MessageBox.Show("Bağlantı Başarısız! İnternetinizi Kontrol Ediniz");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bize_ulasin iletisim = new Bize_ulasin();
            iletisim.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Galeri galeriSayfasi = new Galeri();
            galeriSayfasi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kurumsal kurumsalSayfa = new kurumsal();
            kurumsalSayfa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rezNo=0;
            for (int i = 0; i < 1; i++)
            {
                rezNo = rnd.Next();
            }
            var data = new Data
            {
                rezervasyonNo = rezNo,
                musteriAdi = textBox1.Text,
                musteriSoyadi = textBox2.Text,
                musteriTelefon = textBox3.Text,
                musteriMail = textBox4.Text,
                konukSayisi = int.Parse(textBox5.Text),
                girisTarihi = dateTimePicker1.Value.ToString(),
                cikisTarihi = dateTimePicker2.Value.ToString()
            };
            SetResponse set = client.Set(@"Rezervasyonlar/"+rezNo,data);
            MessageBox.Show("Rezervasyon Oluşturuldu");
        }
    }
}
