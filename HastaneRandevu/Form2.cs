using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HastaneRandevu
{
    public partial class Form2 : Form
    {
        List<Hasta> hastalar = new List<Hasta>();
        List<Randevu> randevular = new List<Randevu>();
        Form1 frm1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            frm1 = form1;
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            hastalar.Clear();
            randevular.Clear();
            Hasta hasta = new Hasta();
            hasta.TcNo = txtTC.Text;
            hasta.AdSoyad = txtAdSoyad.Text;
            hasta.Telefon = mtxtTelefon.Text;
            hasta.Cinsiyet = rbKadin.Checked ? "Kadin" : "Erkek";

            Randevu randevu = new Randevu();
            randevu.Poliklinik = cbPoliklinik.SelectedItem.ToString();
            randevu.Tarih = dtpTarih.Value;
            string seciliSaat;

            if (rb12.Checked)
            {
                seciliSaat = rb12.Text;
            }
            else if (rb13.Checked)
            {
                seciliSaat = rb13.Text;
            }
            else if (rb14.Checked)
            {
                seciliSaat = rb14.Text;
            }
            else
            {
                seciliSaat = rb15.Text;
            }

            randevu.Saat = seciliSaat;
            hastalar.Add(hasta);
            randevular.Add(randevu);
            frm1.VerileriGonder(hastalar, randevular);
            FormuTemizle();
        }

        public void FormuTemizle()
        {
            txtAdSoyad.Clear();
            txtTC.Clear();
            mtxtTelefon.Clear();
            rbKadin.Checked = true;
            rbErkek.Checked = default;
            rb12.Checked = true;
            rb13.Checked = default;
            rb14.Checked = default;
            rb15.Checked = default;
            dtpTarih.Value = DateTime.Now;
            cbPoliklinik.SelectedItem = default;
        }
    }
}
