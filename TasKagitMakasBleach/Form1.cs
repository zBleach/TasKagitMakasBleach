using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakasBleach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bot = 0;
        int p1 = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tasbtn_Click(object sender, EventArgs e)
        {
            if (tasbtn.Enabled)
            {
                p1secim.Text = "Taş";
                Pc();
                Sonuc();
            }
        }

        private void kagitbtn_Click(object sender, EventArgs e)
        {
            if (kagitbtn.Enabled)
            {
                p1secim.Text = "Kağıt";
                Pc();
                Sonuc();
            }
        }

        private void makasbtn_Click(object sender, EventArgs e)
        {
            if (makasbtn.Enabled)
            {
                p1secim.Text = "Makas";
                Pc();
                Sonuc();
            }
        }


        private void Pc()
        {
            Random pc = new Random();
            int deger = pc.Next(0, 3);

            if (deger == 0)
            {
                botsecim.Text = "Taş";
            }
            else if (deger == 1)
            {
                botsecim.Text = "Kağıt";
            }
            else
            {
                botsecim.Text = "Makas";
            }
        }

        private void Sonuc()
        {
            if (p1secim.Text == botsecim.Text)
            {
                sonuclbl.Text = "Berabere";
            }
            if (p1secim.Text == "Taş" && botsecim.Text == "Kağıt") // Taşa Kağıt
            {
                sonuclbl.Text = "Kaybettin";
                bot++;
                botsonuc.Text = bot.ToString();
            }
            if (p1secim.Text == "Taş" && botsecim.Text == "Makas") // Taşa Makas
            {
                sonuclbl.Text = "Kazandın";
                p1++;
                p1sonuc.Text = p1.ToString();
            }
            if (p1secim.Text == "Makas" && botsecim.Text == "Kağıt") // Makasa Kağıt
            {
                sonuclbl.Text = "Kazandın";
                p1++;
                p1sonuc.Text = p1.ToString();
            }
            if (p1secim.Text == "Makas" && botsecim.Text == "Taş") // Makasa Taş
            {
                sonuclbl.Text = "Kaybettin";
                bot++;
                botsonuc.Text = bot.ToString();
            }
            if (p1secim.Text == "Kağıt" && botsecim.Text == "Makas") // Kağıta Makas
            {
                sonuclbl.Text = "Kaybettin";
                bot++;
                botsonuc.Text = bot.ToString();
            }
            if (p1secim.Text == "Kağıt" && botsecim.Text == "Taş") // Kağıta Taş
            {
                sonuclbl.Text = "Kazandın";
                p1++;
                p1sonuc.Text = p1.ToString();
            }

        }

        private void sonuclbl_Click(object sender, EventArgs e)
        {

        }
    }
}
