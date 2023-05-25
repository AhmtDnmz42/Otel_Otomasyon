using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyon
{
    public partial class kurumsal : Form
    {
        public kurumsal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void formGetir(Form frm)
        {
            panel3.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(frm);
            frm.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hakkimizda hak = new hakkimizda();
            formGetir(hak);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vizyon viz = new vizyon();
            formGetir(viz);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deger dgr = new deger();
            formGetir(dgr);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rakam rak = new rakam();
            formGetir(rak);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            stratejik strj = new stratejik();
            formGetir(strj);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            yonetim yonet = new yonetim();
            formGetir(yonet);
        }
    }
}
