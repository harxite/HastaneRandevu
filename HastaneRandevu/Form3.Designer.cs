namespace HastaneRandevu
{
    partial class Form3
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
            lstRandevuBilgileri = new ListBox();
            SuspendLayout();
            // 
            // lstRandevuBilgileri
            // 
            lstRandevuBilgileri.FormattingEnabled = true;
            lstRandevuBilgileri.ItemHeight = 20;
            lstRandevuBilgileri.Location = new Point(68, 63);
            lstRandevuBilgileri.Name = "lstRandevuBilgileri";
            lstRandevuBilgileri.Size = new Size(589, 324);
            lstRandevuBilgileri.TabIndex = 0;
            lstRandevuBilgileri.DoubleClick += lstRandevuBilgileri_DoubleClick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 461);
            ControlBox = false;
            Controls.Add(lstRandevuBilgileri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRandevuBilgileri;
    }
}