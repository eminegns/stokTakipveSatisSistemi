namespace PROJE1
{
    partial class kullaniciEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciEkrani));
            this.dgvUrunTablo = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorselProgDataSet1 = new PROJE1.gorselProgDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnSepeteYukle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSepetiSil = new System.Windows.Forms.Button();
            this.urunlerTablosuTableAdapter = new PROJE1.gorselProgDataSet1TableAdapters.urunlerTablosuTableAdapter();
            this.bttnSepetiSatinAl = new System.Windows.Forms.Button();
            this.bttnGeriDön2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunTablo
            // 
            this.dgvUrunTablo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUrunTablo.AutoGenerateColumns = false;
            this.dgvUrunTablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.dgvUrunTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dgvUrunTablo.DataSource = this.urunlerTablosuBindingSource;
            this.dgvUrunTablo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.dgvUrunTablo.Location = new System.Drawing.Point(46, 245);
            this.dgvUrunTablo.Name = "dgvUrunTablo";
            this.dgvUrunTablo.RowHeadersWidth = 51;
            this.dgvUrunTablo.RowTemplate.Height = 24;
            this.dgvUrunTablo.Size = new System.Drawing.Size(895, 379);
            this.dgvUrunTablo.TabIndex = 0;
            this.dgvUrunTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunTablo_CellClick);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urun_id";
            this.urunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunidDataGridViewTextBoxColumn.Width = 125;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            this.renkDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunlerTablosuBindingSource
            // 
            this.urunlerTablosuBindingSource.DataMember = "urunlerTablosu";
            this.urunlerTablosuBindingSource.DataSource = this.gorselProgDataSet1;
            // 
            // gorselProgDataSet1
            // 
            this.gorselProgDataSet1.DataSetName = "gorselProgDataSet1";
            this.gorselProgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(46, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttnSepeteYukle
            // 
            this.bttnSepeteYukle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnSepeteYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.bttnSepeteYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSepeteYukle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSepeteYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSepeteYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSepeteYukle.ImageIndex = 3;
            this.bttnSepeteYukle.ImageList = this.ımageList1;
            this.bttnSepeteYukle.Location = new System.Drawing.Point(303, 171);
            this.bttnSepeteYukle.Name = "bttnSepeteYukle";
            this.bttnSepeteYukle.Size = new System.Drawing.Size(171, 45);
            this.bttnSepeteYukle.TabIndex = 2;
            this.bttnSepeteYukle.Text = "Sepete Yükle";
            this.bttnSepeteYukle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSepeteYukle.UseVisualStyleBackColor = false;
            this.bttnSepeteYukle.Click += new System.EventHandler(this.bttnSepeteYukle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "database_folder_file_icon_219517.png");
            this.ımageList1.Images.SetKeyName(1, "download_folder_file_icon_219533.png");
            this.ımageList1.Images.SetKeyName(2, "garbage_trash_bin_delete_icon_219529.png");
            this.ımageList1.Images.SetKeyName(3, "shopping-cart-add-button_icon-icons.com_56132.png");
            this.ımageList1.Images.SetKeyName(4, "clouddownload_106462.png");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(522, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 234);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(763, 112);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(154, 32);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(798, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sepet Tutarı";
            // 
            // bttnSepetiSil
            // 
            this.bttnSepetiSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnSepetiSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.bttnSepetiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSepetiSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSepetiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSepetiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSepetiSil.ImageIndex = 2;
            this.bttnSepetiSil.ImageList = this.ımageList1;
            this.bttnSepetiSil.Location = new System.Drawing.Point(303, 44);
            this.bttnSepetiSil.Name = "bttnSepetiSil";
            this.bttnSepetiSil.Size = new System.Drawing.Size(171, 45);
            this.bttnSepetiSil.TabIndex = 6;
            this.bttnSepetiSil.Text = "Sepeti Boşalt";
            this.bttnSepetiSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSepetiSil.UseVisualStyleBackColor = false;
            this.bttnSepetiSil.Click += new System.EventHandler(this.bttnSepetiSil_Click);
            // 
            // urunlerTablosuTableAdapter
            // 
            this.urunlerTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // bttnSepetiSatinAl
            // 
            this.bttnSepetiSatinAl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnSepetiSatinAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.bttnSepetiSatinAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSepetiSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSepetiSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSepetiSatinAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSepetiSatinAl.ImageIndex = 2;
            this.bttnSepetiSatinAl.Location = new System.Drawing.Point(746, 183);
            this.bttnSepetiSatinAl.Name = "bttnSepetiSatinAl";
            this.bttnSepetiSatinAl.Size = new System.Drawing.Size(186, 45);
            this.bttnSepetiSatinAl.TabIndex = 7;
            this.bttnSepetiSatinAl.Text = "Alışverişi Tamamla";
            this.bttnSepetiSatinAl.UseVisualStyleBackColor = false;
            this.bttnSepetiSatinAl.Click += new System.EventHandler(this.bttnSepetiSatinAl_Click);
            // 
            // bttnGeriDön2
            // 
            this.bttnGeriDön2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnGeriDön2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.bttnGeriDön2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnGeriDön2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnGeriDön2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGeriDön2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnGeriDön2.ImageIndex = 4;
            this.bttnGeriDön2.Location = new System.Drawing.Point(646, 630);
            this.bttnGeriDön2.Name = "bttnGeriDön2";
            this.bttnGeriDön2.Size = new System.Drawing.Size(333, 72);
            this.bttnGeriDön2.TabIndex = 8;
            this.bttnGeriDön2.Text = "Giriş Ekranına Geri Dön";
            this.bttnGeriDön2.UseVisualStyleBackColor = false;
            this.bttnGeriDön2.Click += new System.EventHandler(this.bttnGeriDön2_Click);
            // 
            // kullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(991, 705);
            this.Controls.Add(this.bttnGeriDön2);
            this.Controls.Add(this.bttnSepetiSatinAl);
            this.Controls.Add(this.bttnSepetiSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttnSepeteYukle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUrunTablo);
            this.Name = "kullaniciEkrani";
            this.Text = "kullaniciEkrani";
            this.Load += new System.EventHandler(this.kullaniciEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunTablo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnSepeteYukle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSepetiSil;
        private gorselProgDataSet1 gorselProgDataSet1;
        private System.Windows.Forms.BindingSource urunlerTablosuBindingSource;
        private gorselProgDataSet1TableAdapters.urunlerTablosuTableAdapter urunlerTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button bttnSepetiSatinAl;
        private System.Windows.Forms.Button bttnGeriDön2;
    }
}