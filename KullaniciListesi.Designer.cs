namespace PROJE1
{
    partial class KullaniciListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorselProgDataSet = new PROJE1.gorselProgDataSet();
            this.bttnKullanıcıGtr = new System.Windows.Forms.Button();
            this.bttnTabloTemizle = new System.Windows.Forms.Button();
            this.kullaniciTablosuTableAdapter = new PROJE1.gorselProgDataSetTableAdapters.kullaniciTablosuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciidDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            this.kullaniciidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // kullaniciTablosuBindingSource
            // 
            this.kullaniciTablosuBindingSource.DataMember = "kullaniciTablosu";
            this.kullaniciTablosuBindingSource.DataSource = this.gorselProgDataSet;
            // 
            // gorselProgDataSet
            // 
            this.gorselProgDataSet.DataSetName = "gorselProgDataSet";
            this.gorselProgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttnKullanıcıGtr
            // 
            this.bttnKullanıcıGtr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnKullanıcıGtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(34)))), ((int)(((byte)(166)))));
            this.bttnKullanıcıGtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnKullanıcıGtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnKullanıcıGtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullanıcıGtr.Location = new System.Drawing.Point(97, 50);
            this.bttnKullanıcıGtr.Name = "bttnKullanıcıGtr";
            this.bttnKullanıcıGtr.Size = new System.Drawing.Size(174, 76);
            this.bttnKullanıcıGtr.TabIndex = 1;
            this.bttnKullanıcıGtr.Text = "Kullanıcıları Listele";
            this.bttnKullanıcıGtr.UseVisualStyleBackColor = false;
            this.bttnKullanıcıGtr.Click += new System.EventHandler(this.bttnKullanıcıGtr_Click);
            // 
            // bttnTabloTemizle
            // 
            this.bttnTabloTemizle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnTabloTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(34)))), ((int)(((byte)(166)))));
            this.bttnTabloTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnTabloTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnTabloTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnTabloTemizle.Location = new System.Drawing.Point(375, 50);
            this.bttnTabloTemizle.Name = "bttnTabloTemizle";
            this.bttnTabloTemizle.Size = new System.Drawing.Size(181, 76);
            this.bttnTabloTemizle.TabIndex = 2;
            this.bttnTabloTemizle.Text = "Tabloyu Temizle";
            this.bttnTabloTemizle.UseVisualStyleBackColor = false;
            this.bttnTabloTemizle.Click += new System.EventHandler(this.bttnTabloTemizle_Click);
            // 
            // kullaniciTablosuTableAdapter
            // 
            this.kullaniciTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(654, 523);
            this.Controls.Add(this.bttnTabloTemizle);
            this.Controls.Add(this.bttnKullanıcıGtr);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(275, 85);
            this.Name = "KullaniciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KullaniciListesi";
            this.Load += new System.EventHandler(this.KullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnKullanıcıGtr;
        private System.Windows.Forms.Button bttnTabloTemizle;
        private gorselProgDataSet gorselProgDataSet;
        private System.Windows.Forms.BindingSource kullaniciTablosuBindingSource;
        private gorselProgDataSetTableAdapters.kullaniciTablosuTableAdapter kullaniciTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
    }
}