namespace Gorsel1_Proje_Gazete_Sistemi
{
    partial class GazeteSayisiIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sayiNo = new System.Windows.Forms.TextBox();
            this.txt_sayfaSayisi = new System.Windows.Forms.TextBox();
            this.txt_manset = new System.Windows.Forms.TextBox();
            this.dgv_gazeteSayisi = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.mtx_yayinTarihi = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gazeteSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Numarası : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yayın Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manşet : ";
            // 
            // txt_sayiNo
            // 
            this.txt_sayiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayiNo.Location = new System.Drawing.Point(234, 48);
            this.txt_sayiNo.Name = "txt_sayiNo";
            this.txt_sayiNo.Size = new System.Drawing.Size(238, 30);
            this.txt_sayiNo.TabIndex = 4;
            // 
            // txt_sayfaSayisi
            // 
            this.txt_sayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayfaSayisi.Location = new System.Drawing.Point(234, 159);
            this.txt_sayfaSayisi.Name = "txt_sayfaSayisi";
            this.txt_sayfaSayisi.Size = new System.Drawing.Size(238, 30);
            this.txt_sayfaSayisi.TabIndex = 6;
            // 
            // txt_manset
            // 
            this.txt_manset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_manset.Location = new System.Drawing.Point(234, 212);
            this.txt_manset.Name = "txt_manset";
            this.txt_manset.Size = new System.Drawing.Size(238, 30);
            this.txt_manset.TabIndex = 7;
            // 
            // dgv_gazeteSayisi
            // 
            this.dgv_gazeteSayisi.AllowUserToAddRows = false;
            this.dgv_gazeteSayisi.AllowUserToDeleteRows = false;
            this.dgv_gazeteSayisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gazeteSayisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gazeteSayisi.Location = new System.Drawing.Point(47, 305);
            this.dgv_gazeteSayisi.MultiSelect = false;
            this.dgv_gazeteSayisi.Name = "dgv_gazeteSayisi";
            this.dgv_gazeteSayisi.ReadOnly = true;
            this.dgv_gazeteSayisi.RowHeadersWidth = 62;
            this.dgv_gazeteSayisi.RowTemplate.Height = 28;
            this.dgv_gazeteSayisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gazeteSayisi.Size = new System.Drawing.Size(655, 340);
            this.dgv_gazeteSayisi.TabIndex = 8;
            this.dgv_gazeteSayisi.SelectionChanged += new System.EventHandler(this.dgv_gazeteSayisi_SelectionChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.Location = new System.Drawing.Point(529, 23);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(127, 47);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_sil.Location = new System.Drawing.Point(529, 87);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(127, 47);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_guncelle.Location = new System.Drawing.Point(529, 152);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(127, 47);
            this.btn_guncelle.TabIndex = 11;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(529, 215);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(127, 47);
            this.btn_temizle.TabIndex = 12;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // mtx_yayinTarihi
            // 
            this.mtx_yayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_yayinTarihi.Location = new System.Drawing.Point(234, 107);
            this.mtx_yayinTarihi.Mask = "00/00/0000";
            this.mtx_yayinTarihi.Name = "mtx_yayinTarihi";
            this.mtx_yayinTarihi.Size = new System.Drawing.Size(238, 30);
            this.mtx_yayinTarihi.TabIndex = 13;
            this.mtx_yayinTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // GazeteSayisiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 696);
            this.Controls.Add(this.mtx_yayinTarihi);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_manset);
            this.Controls.Add(this.txt_sayfaSayisi);
            this.Controls.Add(this.txt_sayiNo);
            this.Controls.Add(this.dgv_gazeteSayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "GazeteSayisiIslemleri";
            this.Text = "Gazete Sayısı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GazeteSayisiIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.GazeteSayisiIslemleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GazeteSayisiIslemleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gazeteSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sayiNo;
        private System.Windows.Forms.TextBox txt_sayfaSayisi;
        private System.Windows.Forms.TextBox txt_manset;
        private System.Windows.Forms.DataGridView dgv_gazeteSayisi;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.MaskedTextBox mtx_yayinTarihi;
    }
}