namespace PROJE1
{
    partial class kullaniciAyarlari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciSilme = new System.Windows.Forms.TextBox();
            this.txtKayıtSilme = new System.Windows.Forms.Label();
            this.bttnKullaniciSilme = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bttnKaydet);
            this.panel1.Controls.Add(this.txtKullaniciSilme);
            this.panel1.Controls.Add(this.txtKayıtSilme);
            this.panel1.Controls.Add(this.bttnKullaniciSilme);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(31, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 168);
            this.panel1.TabIndex = 16;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.bttnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKaydet.Location = new System.Drawing.Point(481, 76);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(149, 47);
            this.bttnKaydet.TabIndex = 18;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = false;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // txtKullaniciSilme
            // 
            this.txtKullaniciSilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.txtKullaniciSilme.Location = new System.Drawing.Point(143, 92);
            this.txtKullaniciSilme.Multiline = true;
            this.txtKullaniciSilme.Name = "txtKullaniciSilme";
            this.txtKullaniciSilme.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciSilme.TabIndex = 17;
            // 
            // txtKayıtSilme
            // 
            this.txtKayıtSilme.AutoSize = true;
            this.txtKayıtSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtSilme.Location = new System.Drawing.Point(20, 92);
            this.txtKayıtSilme.Name = "txtKayıtSilme";
            this.txtKayıtSilme.Size = new System.Drawing.Size(109, 25);
            this.txtKayıtSilme.TabIndex = 16;
            this.txtKayıtSilme.Text = "Kullanıcı ID";
            // 
            // bttnKullaniciSilme
            // 
            this.bttnKullaniciSilme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnKullaniciSilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.bttnKullaniciSilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnKullaniciSilme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnKullaniciSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullaniciSilme.Location = new System.Drawing.Point(326, 76);
            this.bttnKullaniciSilme.Name = "bttnKullaniciSilme";
            this.bttnKullaniciSilme.Size = new System.Drawing.Size(149, 47);
            this.bttnKullaniciSilme.TabIndex = 13;
            this.bttnKullaniciSilme.Text = "Kullanıcı Sil";
            this.bttnKullaniciSilme.UseVisualStyleBackColor = false;
            this.bttnKullaniciSilme.Click += new System.EventHandler(this.bttnKullaniciSilme_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(137, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kullanıcı Kayıt Ayarları";
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Location = new System.Drawing.Point(31, 188);
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.RowHeadersWidth = 51;
            this.dgvKullanici.RowTemplate.Height = 24;
            this.dgvKullanici.Size = new System.Drawing.Size(637, 311);
            this.dgvKullanici.TabIndex = 17;
            this.dgvKullanici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellContentClick);
            this.dgvKullanici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "datagridview üzerinden direkt tabloyu düzeltip ekleme yapabiliyoruz";
            // 
            // kullaniciAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(744, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKullanici);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(275, 85);
            this.Name = "kullaniciAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "kullaniciSil";
            this.Load += new System.EventHandler(this.kullaniciAyarlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnKullaniciSilme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKullaniciSilme;
        private System.Windows.Forms.Label txtKayıtSilme;
        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Label label1;
    }
}