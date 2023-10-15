namespace HastaneRandevu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTC = new TextBox();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            mtxtTelefon = new MaskedTextBox();
            groupBox1 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            cbPoliklinik = new ComboBox();
            label6 = new Label();
            dtpTarih = new DateTimePicker();
            rb12 = new RadioButton();
            rb13 = new RadioButton();
            rb14 = new RadioButton();
            rb15 = new RadioButton();
            btnRandevuOlustur = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 70);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(195, 63);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(218, 27);
            txtTC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 129);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(195, 122);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(218, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 190);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(195, 183);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(218, 27);
            mtxtTelefon.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(rbKadin);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(76, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(220, 46);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 0;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Checked = true;
            rbKadin.Location = new Point(59, 46);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 0;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadin";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 380);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 0;
            label4.Text = "Randevu Bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 434);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 0;
            label5.Text = "Poliklinik";
            // 
            // cbPoliklinik
            // 
            cbPoliklinik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPoliklinik.FormattingEnabled = true;
            cbPoliklinik.Items.AddRange(new object[] { "Dahiliye", "Goz", "Ic Hastaliklari", "Cocuk Hastaliklari", "Fizik Tedavi", "Noroloji", "Kardiyoloji" });
            cbPoliklinik.Location = new Point(195, 426);
            cbPoliklinik.Name = "cbPoliklinik";
            cbPoliklinik.Size = new Size(218, 28);
            cbPoliklinik.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 498);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 0;
            label6.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(195, 491);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(218, 27);
            dtpTarih.TabIndex = 5;
            // 
            // rb12
            // 
            rb12.AutoSize = true;
            rb12.Checked = true;
            rb12.Location = new Point(97, 543);
            rb12.Name = "rb12";
            rb12.Size = new Size(65, 24);
            rb12.TabIndex = 6;
            rb12.TabStop = true;
            rb12.Text = "12:00";
            rb12.UseVisualStyleBackColor = true;
            // 
            // rb13
            // 
            rb13.AutoSize = true;
            rb13.Location = new Point(317, 543);
            rb13.Name = "rb13";
            rb13.Size = new Size(65, 24);
            rb13.TabIndex = 6;
            rb13.Text = "13:00";
            rb13.UseVisualStyleBackColor = true;
            // 
            // rb14
            // 
            rb14.AutoSize = true;
            rb14.Location = new Point(97, 586);
            rb14.Name = "rb14";
            rb14.Size = new Size(65, 24);
            rb14.TabIndex = 6;
            rb14.Text = "14:00";
            rb14.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            rb15.AutoSize = true;
            rb15.Location = new Point(317, 586);
            rb15.Name = "rb15";
            rb15.Size = new Size(65, 24);
            rb15.TabIndex = 6;
            rb15.Text = "15:00";
            rb15.UseVisualStyleBackColor = true;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(76, 637);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(337, 47);
            btnRandevuOlustur.TabIndex = 7;
            btnRandevuOlustur.Text = "Randevu Olustur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(76, 24);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 0;
            label7.Text = "Hasta Bilgileri";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 716);
            ControlBox = false;
            Controls.Add(btnRandevuOlustur);
            Controls.Add(rb15);
            Controls.Add(rb14);
            Controls.Add(rb13);
            Controls.Add(rb12);
            Controls.Add(dtpTarih);
            Controls.Add(cbPoliklinik);
            Controls.Add(groupBox1);
            Controls.Add(mtxtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTC);
            Controls.Add(label7);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTC;
        private Label label2;
        private TextBox txtAdSoyad;
        private Label label3;
        private MaskedTextBox mtxtTelefon;
        private GroupBox groupBox1;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private Label label4;
        private Label label5;
        private ComboBox cbPoliklinik;
        private Label label6;
        private DateTimePicker dtpTarih;
        private RadioButton rb12;
        private RadioButton rb13;
        private RadioButton rb14;
        private RadioButton rb15;
        private Button btnRandevuOlustur;
        private Label label7;
    }
}