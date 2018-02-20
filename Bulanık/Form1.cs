using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulanık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //degerler alındıı
            GirisDeger gd = new GirisDeger() { Hassaslik = (double)numericUpDown_hassaslik.Value, Miktar = (double)numericUpDown_kirlilik.Value, Kirlilik = (double)numericUpDown_kirlilik.Value };
            
            //kurallara göre bulanıklaştırılma yapıldı
            var liste = KuralTabani.Kurallar(gd);

            //ağırlıklı ortalama durulama yapıldı sonuc bulundu
            double sonuc = KuralTabani.AgirlikliOrtalama(liste);

            lbl_sayisal.Text = "Sayısal Sonuc= " + sonuc.ToString();

            foreach (var item in liste)
            {
                lbl_durum.Text += "Dönüş Hızı : "+item.DonusTuru.ToString()+" Sure : "+item.SureTuru.ToString() +" Deterjan : "+item.DeterjanTuru.ToString()+"\n";
            }
         
        }

        
    }
}
