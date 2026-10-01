namespace Gorsel1_Proje_Gazete_Sistemi
{
    partial class kullaniciGiris
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
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.tx_Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Giris.Location = new System.Drawing.Point(212, 414);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(242, 60);
            this.btn_Giris.TabIndex = 6;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = " Şifre : ";
            // 
            // tx_kullaniciAdi
            // 
            this.tx_kullaniciAdi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kullaniciAdi.Location = new System.Drawing.Point(177, 223);
            this.tx_kullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_kullaniciAdi.Name = "tx_kullaniciAdi";
            this.tx_kullaniciAdi.Size = new System.Drawing.Size(312, 33);
            this.tx_kullaniciAdi.TabIndex = 3;
            this.tx_kullaniciAdi.Text = "sseyman";
            // 
            // tx_Sifre
            // 
            this.tx_Sifre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Sifre.Location = new System.Drawing.Point(177, 334);
            this.tx_Sifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_Sifre.Name = "tx_Sifre";
            this.tx_Sifre.PasswordChar = '✱';
            this.tx_Sifre.Size = new System.Drawing.Size(312, 33);
            this.tx_Sifre.TabIndex = 5;
            this.tx_Sifre.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(235, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "GAZETE SİSTEMİ \r\n";
            // 
            // kullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(706, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_Sifre);
            this.Controls.Add(this.tx_kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kullaniciAdi;
        private System.Windows.Forms.TextBox tx_Sifre;
        private System.Windows.Forms.Label label3;
    }
}

