using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyon
{
    public partial class Galeri : Form
    {
        public Galeri()
        {
            InitializeComponent();
        }

        private void Galeri_Load(object sender, EventArgs e)
        {

        }
        int intImgNumParis = 0;
        int intImgNumBerlin = 0;
        int intImgNumAnkara = 0;
        int intImgNumMadrid = 0;
        int intImgNumRoma = 0;

        private void timerGaleri_Tick(object sender, EventArgs e)
        {
            pbxParis.Image = imageListParis.Images[intImgNumParis];
            if (intImgNumParis == imageListParis.Images.Count - 1)
            {
                intImgNumParis = 0;
            }
            else
            {
                intImgNumParis++;
            }

            pbxBerlin.Image = imageListBerlin.Images[intImgNumBerlin];
            if (intImgNumBerlin == imageListBerlin.Images.Count - 1)
            {
                intImgNumBerlin = 0;
            }
            else
            {
                intImgNumBerlin++;
            }

            pbxAnkara.Image = imageListAnkara.Images[intImgNumAnkara];
            if (intImgNumAnkara == imageListAnkara.Images.Count - 1)
            {
                intImgNumAnkara = 0;
            }
            else
            {
                intImgNumAnkara++;
            }

            pbxMadrid.Image = imageListMadrid.Images[intImgNumMadrid];
            if (intImgNumMadrid == imageListMadrid.Images.Count - 1)
            {
                intImgNumMadrid = 0;
            }
            else
            {
                intImgNumMadrid++;
            }

            pbxRoma.Image = imageListRoma.Images[intImgNumRoma];
            if (intImgNumRoma == imageListRoma.Images.Count - 1)
            {
                intImgNumRoma = 0;
            }
            else
            {
                intImgNumRoma++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bize_ulasin iletisim = new Bize_ulasin();
            iletisim.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
