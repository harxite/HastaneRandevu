using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class Form3 : Form
    {
        private Form1 frm1;
        private List<Hasta> _hastalar;
        private List<Randevu> _randevuler;

        public Form3(Form1 form1, List<Hasta> hastalarx, List<Randevu> randevularx)
        {
            InitializeComponent();
            this._hastalar = hastalarx;
            this._randevuler = randevularx;
            frm1 = form1;
            Listele();
        }
        
        List<string> bilgiler = new List<string>();
        public void Listele()
        {
            string bilgi;
            for (int i = 0; i < _hastalar.Count; i++)
            {
                bilgi = $"{_hastalar[i].AdSoyad} - {_randevuler[i].Poliklinik} - {_randevuler[i].Tarih} - {_randevuler[i].Saat}";
                bilgiler.Add(bilgi);
            }
            lstRandevuBilgileri.Items.AddRange(bilgiler.ToArray());
        }

        private void lstRandevuBilgileri_DoubleClick(object sender, EventArgs e)
        {
            int indeks = lstRandevuBilgileri.SelectedIndex;
            string info = $"Adi Soyadi : {_hastalar[indeks].AdSoyad}\n" +
               $"TC : {_hastalar[indeks].TcNo}\n" +
               $"Cinsiyet: {_hastalar[indeks].Cinsiyet}";
            MessageBox.Show(info, "Hasta Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
