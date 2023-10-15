namespace HastaneRandevu
{

    public partial class Form1 : Form
    {
        List<Hasta> _hastalar = new List<Hasta>();
        List<Randevu> _randevular = new List<Randevu>();

        Form frm3;
        Form frm2;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            randevuOlusturToolStripMenuItem.PerformClick();
        }
      
        private void randevuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(i != 0)
            {
                frm3.Hide();
            }
            frm2 = new Form2(this);
            frm2.MdiParent = this;
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(0, 0);
            this.Size = frm2.ClientSize;
            frm2.Show();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            frm2.Hide();
            frm3 = new Form3(this, _hastalar, _randevular);
            frm3.MdiParent = this;
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(0, 0);
            this.Size = frm3.ClientSize;
            frm3.Show();
        }
     
        public void VerileriGonder(List<Hasta> hastalar, List<Randevu> randevular)
        {
            foreach (Hasta h in hastalar)
            {
                _hastalar.Add(h);
            }
           
            foreach (Randevu r in randevular)
            {
                _randevular.Add(r);
            }
        }
    }
}