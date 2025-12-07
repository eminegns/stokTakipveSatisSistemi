namespace PROJE1
{
    partial class urunDuzenle
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
            this.bttnFotoDuzenSecme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrunIdDuzen = new System.Windows.Forms.TextBox();
            this.txtUrunDuzenID = new System.Windows.Forms.Label();
            this.bttnUrunDuzen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureUrunDuzen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunDuzenStok = new System.Windows.Forms.TextBox();
            this.txtUrunDuzenKat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunDuzenFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunDuzenMarka = new System.Windows.Forms.TextBox();
            this.txtUrunDuzenRengi = new System.Windows.Forms.TextBox();
            this.dgvUrunDuzenleme = new System.Windows.Forms.DataGridView();
            this.gorselProgDataSet5 = new PROJE1.gorselProgDataSet5();
            this.urunlerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTablosuTableAdapter = new PROJE1.gorselProgDataSet5TableAdapters.urunlerTablosuTableAdapter();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrunDuzen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDuzenleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnFotoDuzenSecme
            // 
            this.bttnFotoDuzenSecme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnFotoDuzenSecme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.bttnFotoDuzenSecme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFotoDuzenSecme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnFotoDuzenSecme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnFotoDuzenSecme.Location = new System.Drawing.Point(409, 311);
            this.bttnFotoDuzenSecme.Name = "bttnFotoDuzenSecme";
            this.bttnFotoDuzenSecme.Size = new System.Drawing.Size(127, 39);
            this.bttnFotoDuzenSecme.TabIndex = 15;
            this.bttnFotoDuzenSecme.Text = "Fotoğraf seçin";
            this.bttnFotoDuzenSecme.UseVisualStyleBackColor = false;
            this.bttnFotoDuzenSecme.Click += new System.EventHandler(this.bttnFotoDuzenSecme_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtUrunIdDuzen);
            this.panel1.Controls.Add(this.txtUrunDuzenID);
            this.panel1.Controls.Add(this.bttnFotoDuzenSecme);
            this.panel1.Controls.Add(this.bttnUrunDuzen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureUrunDuzen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUrunDuzenStok);
            this.panel1.Controls.Add(this.txtUrunDuzenKat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUrunDuzenFiyat);
            this.panel1.Controls.Add(this.txtUrunDuzenMarka);
            this.panel1.Controls.Add(this.txtUrunDuzenRengi);
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 464);
            this.panel1.TabIndex = 16;
            // 
            // txtUrunIdDuzen
            // 
            this.txtUrunIdDuzen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunIdDuzen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunIdDuzen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunIdDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunIdDuzen.Location = new System.Drawing.Point(174, 378);
            this.txtUrunIdDuzen.Multiline = true;
            this.txtUrunIdDuzen.Name = "txtUrunIdDuzen";
            this.txtUrunIdDuzen.Size = new System.Drawing.Size(162, 33);
            this.txtUrunIdDuzen.TabIndex = 17;
            // 
            // txtUrunDuzenID
            // 
            this.txtUrunDuzenID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenID.AutoSize = true;
            this.txtUrunDuzenID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenID.Location = new System.Drawing.Point(12, 378);
            this.txtUrunDuzenID.Name = "txtUrunDuzenID";
            this.txtUrunDuzenID.Size = new System.Drawing.Size(78, 25);
            this.txtUrunDuzenID.TabIndex = 16;
            this.txtUrunDuzenID.Text = "Ürün ID";
            // 
            // bttnUrunDuzen
            // 
            this.bttnUrunDuzen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnUrunDuzen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.bttnUrunDuzen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUrunDuzen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnUrunDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnUrunDuzen.Location = new System.Drawing.Point(382, 378);
            this.bttnUrunDuzen.Name = "bttnUrunDuzen";
            this.bttnUrunDuzen.Size = new System.Drawing.Size(176, 59);
            this.bttnUrunDuzen.TabIndex = 13;
            this.bttnUrunDuzen.Text = "Ürünü Düzenleyin";
            this.bttnUrunDuzen.UseVisualStyleBackColor = false;
            this.bttnUrunDuzen.Click += new System.EventHandler(this.bttnUrunDuzen_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün rengi";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(191, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = " Ürün Düzenleme";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok sayısı";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(353, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün fotoğrafı yükleyiniz";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün fiyatı";
            // 
            // pictureUrunDuzen
            // 
            this.pictureUrunDuzen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureUrunDuzen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pictureUrunDuzen.Location = new System.Drawing.Point(382, 124);
            this.pictureUrunDuzen.Name = "pictureUrunDuzen";
            this.pictureUrunDuzen.Size = new System.Drawing.Size(189, 169);
            this.pictureUrunDuzen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUrunDuzen.TabIndex = 6;
            this.pictureUrunDuzen.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün kategorisi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUrunDuzenStok
            // 
            this.txtUrunDuzenStok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunDuzenStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenStok.Location = new System.Drawing.Point(174, 281);
            this.txtUrunDuzenStok.Multiline = true;
            this.txtUrunDuzenStok.Name = "txtUrunDuzenStok";
            this.txtUrunDuzenStok.Size = new System.Drawing.Size(162, 33);
            this.txtUrunDuzenStok.TabIndex = 11;
            // 
            // txtUrunDuzenKat
            // 
            this.txtUrunDuzenKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenKat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunDuzenKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenKat.Location = new System.Drawing.Point(174, 164);
            this.txtUrunDuzenKat.Multiline = true;
            this.txtUrunDuzenKat.Name = "txtUrunDuzenKat";
            this.txtUrunDuzenKat.Size = new System.Drawing.Size(162, 33);
            this.txtUrunDuzenKat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Markası";
            // 
            // txtUrunDuzenFiyat
            // 
            this.txtUrunDuzenFiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunDuzenFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenFiyat.Location = new System.Drawing.Point(174, 242);
            this.txtUrunDuzenFiyat.Multiline = true;
            this.txtUrunDuzenFiyat.Name = "txtUrunDuzenFiyat";
            this.txtUrunDuzenFiyat.Size = new System.Drawing.Size(162, 33);
            this.txtUrunDuzenFiyat.TabIndex = 10;
            // 
            // txtUrunDuzenMarka
            // 
            this.txtUrunDuzenMarka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunDuzenMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenMarka.Location = new System.Drawing.Point(174, 203);
            this.txtUrunDuzenMarka.Multiline = true;
            this.txtUrunDuzenMarka.Name = "txtUrunDuzenMarka";
            this.txtUrunDuzenMarka.Size = new System.Drawing.Size(162, 33);
            this.txtUrunDuzenMarka.TabIndex = 8;
            // 
            // txtUrunDuzenRengi
            // 
            this.txtUrunDuzenRengi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunDuzenRengi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtUrunDuzenRengi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunDuzenRengi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunDuzenRengi.Location = new System.Drawing.Point(174, 124);
            this.txtUrunDuzenRengi.Multiline = true;
            this.txtUrunDuzenRengi.Name = "txtUrunDuzenRengi";
            this.txtUrunDuzenRengi.Size = new System.Drawing.Size(162, 33);
            this.txtUrunDuzenRengi.TabIndex = 9;
            // 
            // dgvUrunDuzenleme
            // 
            this.dgvUrunDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUrunDuzenleme.AutoGenerateColumns = false;
            this.dgvUrunDuzenleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunDuzenleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunDuzenleme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dgvUrunDuzenleme.DataSource = this.urunlerTablosuBindingSource;
            this.dgvUrunDuzenleme.Location = new System.Drawing.Point(76, 455);
            this.dgvUrunDuzenleme.Name = "dgvUrunDuzenleme";
            this.dgvUrunDuzenleme.RowHeadersWidth = 51;
            this.dgvUrunDuzenleme.RowTemplate.Height = 24;
            this.dgvUrunDuzenleme.Size = new System.Drawing.Size(707, 288);
            this.dgvUrunDuzenleme.TabIndex = 17;
            this.dgvUrunDuzenleme.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunDuzenleme_CellEnter);
            // 
            // gorselProgDataSet5
            // 
            this.gorselProgDataSet5.DataSetName = "gorselProgDataSet5";
            this.gorselProgDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTablosuBindingSource
            // 
            this.urunlerTablosuBindingSource.DataMember = "urunlerTablosu";
            this.urunlerTablosuBindingSource.DataSource = this.gorselProgDataSet5;
            // 
            // urunlerTablosuTableAdapter
            // 
            this.urunlerTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urun_id";
            this.urunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // urunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(859, 775);
            this.Controls.Add(this.dgvUrunDuzenleme);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(275, 85);
            this.Name = "urunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "urunDuzenle";
            this.Load += new System.EventHandler(this.urunDuzenle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrunDuzen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDuzenleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnFotoDuzenSecme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnUrunDuzen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureUrunDuzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunDuzenStok;
        private System.Windows.Forms.TextBox txtUrunDuzenKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunDuzenFiyat;
        private System.Windows.Forms.TextBox txtUrunDuzenMarka;
        private System.Windows.Forms.TextBox txtUrunDuzenRengi;
        private System.Windows.Forms.Label txtUrunDuzenID;
        private System.Windows.Forms.TextBox txtUrunIdDuzen;
        private System.Windows.Forms.DataGridView dgvUrunDuzenleme;
        private gorselProgDataSet5 gorselProgDataSet5;
        private System.Windows.Forms.BindingSource urunlerTablosuBindingSource;
        private gorselProgDataSet5TableAdapters.urunlerTablosuTableAdapter urunlerTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
    }
}