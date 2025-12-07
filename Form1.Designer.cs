namespace PROJE1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnKayitOlusturma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnKullaniciGiris = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bttnYoneticiGiris = new System.Windows.Forms.Button();
            this.txtYoneticiSİFRE = new System.Windows.Forms.TextBox();
            this.txtYoneticiİsim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(110, 45);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 638);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ilk ekran";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen giriş yapınız. Kaydınız yoksa kaydınızı oluşturunuz.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "GÜNEŞLİ MAĞAZAYA HOŞGELDİNİZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı Girişi";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.bttnKayitOlusturma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bttnKullaniciGiris);
            this.panel1.Controls.Add(this.txtKullaniciSifre);
            this.panel1.Controls.Add(this.txtKullaniciEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(159, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 456);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttnKayitOlusturma
            // 
            this.bttnKayitOlusturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bttnKayitOlusturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnKayitOlusturma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnKayitOlusturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKayitOlusturma.Location = new System.Drawing.Point(63, 365);
            this.bttnKayitOlusturma.Name = "bttnKayitOlusturma";
            this.bttnKayitOlusturma.Size = new System.Drawing.Size(289, 45);
            this.bttnKayitOlusturma.TabIndex = 6;
            this.bttnKayitOlusturma.Text = "Kayıtlı Kullanıcı Değilim";
            this.bttnKayitOlusturma.UseVisualStyleBackColor = false;
            this.bttnKayitOlusturma.Click += new System.EventHandler(this.bttnKayitOlusturma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı Girişi";
            // 
            // bttnKullaniciGiris
            // 
            this.bttnKullaniciGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bttnKullaniciGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnKullaniciGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bttnKullaniciGiris.FlatAppearance.BorderSize = 0;
            this.bttnKullaniciGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bttnKullaniciGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bttnKullaniciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnKullaniciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullaniciGiris.Location = new System.Drawing.Point(101, 292);
            this.bttnKullaniciGiris.Name = "bttnKullaniciGiris";
            this.bttnKullaniciGiris.Size = new System.Drawing.Size(199, 53);
            this.bttnKullaniciGiris.TabIndex = 4;
            this.bttnKullaniciGiris.Text = "Giriş";
            this.bttnKullaniciGiris.UseVisualStyleBackColor = false;
            this.bttnKullaniciGiris.Click += new System.EventHandler(this.bttnKullaniciGiris_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtKullaniciSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKullaniciSifre.Location = new System.Drawing.Point(136, 178);
            this.txtKullaniciSifre.MaxLength = 4;
            this.txtKullaniciSifre.Multiline = true;
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(228, 32);
            this.txtKullaniciSifre.TabIndex = 3;
            // 
            // txtKullaniciEmail
            // 
            this.txtKullaniciEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtKullaniciEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciEmail.Location = new System.Drawing.Point(136, 107);
            this.txtKullaniciEmail.Multiline = true;
            this.txtKullaniciEmail.Name = "txtKullaniciEmail";
            this.txtKullaniciEmail.Size = new System.Drawing.Size(228, 31);
            this.txtKullaniciEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(105)))));
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 49);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(728, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yönetici Girişi";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bttnYoneticiGiris);
            this.panel2.Controls.Add(this.txtYoneticiSİFRE);
            this.panel2.Controls.Add(this.txtYoneticiİsim);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(158, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 457);
            this.panel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "//1221";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "//agah";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(11)))), ((int)(((byte)(105)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(107, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 38);
            this.label9.TabIndex = 7;
            this.label9.Text = "Yönetici Girişi";
            // 
            // bttnYoneticiGiris
            // 
            this.bttnYoneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.bttnYoneticiGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnYoneticiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnYoneticiGiris.Location = new System.Drawing.Point(115, 311);
            this.bttnYoneticiGiris.Name = "bttnYoneticiGiris";
            this.bttnYoneticiGiris.Size = new System.Drawing.Size(193, 53);
            this.bttnYoneticiGiris.TabIndex = 6;
            this.bttnYoneticiGiris.Text = "Giriş";
            this.bttnYoneticiGiris.UseVisualStyleBackColor = false;
            this.bttnYoneticiGiris.Click += new System.EventHandler(this.bttnYoneticiGiris_Click);
            // 
            // txtYoneticiSİFRE
            // 
            this.txtYoneticiSİFRE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.txtYoneticiSİFRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYoneticiSİFRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSİFRE.Location = new System.Drawing.Point(201, 196);
            this.txtYoneticiSİFRE.MaxLength = 4;
            this.txtYoneticiSİFRE.Multiline = true;
            this.txtYoneticiSİFRE.Name = "txtYoneticiSİFRE";
            this.txtYoneticiSİFRE.PasswordChar = '*';
            this.txtYoneticiSİFRE.Size = new System.Drawing.Size(167, 32);
            this.txtYoneticiSİFRE.TabIndex = 5;
            // 
            // txtYoneticiİsim
            // 
            this.txtYoneticiİsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.txtYoneticiİsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYoneticiİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiİsim.Location = new System.Drawing.Point(201, 140);
            this.txtYoneticiİsim.Multiline = true;
            this.txtYoneticiİsim.Name = "txtYoneticiİsim";
            this.txtYoneticiİsim.Size = new System.Drawing.Size(167, 32);
            this.txtYoneticiİsim.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "İsim";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(556, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "agah@gmail.com";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(561, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "1234";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 638);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciEmail;
        private System.Windows.Forms.Button bttnKullaniciGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnKayitOlusturma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtYoneticiSİFRE;
        private System.Windows.Forms.TextBox txtYoneticiİsim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttnYoneticiGiris;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

