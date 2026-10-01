namespace Gorsel1_Proje_Gazete_Sistemi
{
    partial class GazeteSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GazeteSistemi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_Haber = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_GazeteSayisi = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Personel1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Abone = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Yorum = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbtn_Haber,
            this.tsbtn_GazeteSayisi,
            this.tsbtn_Personel1,
            this.tsbtn_Abone,
            this.tsbtn_Yorum});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(256, 987);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(249, 32);
            this.toolStripLabel1.Text = "Tablolar";
            // 
            // tsbtn_Haber
            // 
            this.tsbtn_Haber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbtn_Haber.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Haber.Image")));
            this.tsbtn_Haber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Haber.Name = "tsbtn_Haber";
            this.tsbtn_Haber.Size = new System.Drawing.Size(249, 60);
            this.tsbtn_Haber.Text = "Haber İşlemleri";
            this.tsbtn_Haber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Haber.Click += new System.EventHandler(this.tsbtn_Haber_Click);
            // 
            // tsbtn_GazeteSayisi
            // 
            this.tsbtn_GazeteSayisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbtn_GazeteSayisi.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_GazeteSayisi.Image")));
            this.tsbtn_GazeteSayisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_GazeteSayisi.Name = "tsbtn_GazeteSayisi";
            this.tsbtn_GazeteSayisi.Size = new System.Drawing.Size(249, 60);
            this.tsbtn_GazeteSayisi.Text = "Gazete Sayısı İşlemleri";
            this.tsbtn_GazeteSayisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_GazeteSayisi.ToolTipText = "\r\nYazar İşlemleri\r\n";
            this.tsbtn_GazeteSayisi.Click += new System.EventHandler(this.tsbtn_GazeteSayisi_Click);
            // 
            // tsbtn_Personel1
            // 
            this.tsbtn_Personel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtn_Personel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbtn_Personel1.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Personel1.Image")));
            this.tsbtn_Personel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Personel1.Name = "tsbtn_Personel1";
            this.tsbtn_Personel1.Size = new System.Drawing.Size(249, 60);
            this.tsbtn_Personel1.Text = "Personel İşlemleri";
            this.tsbtn_Personel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Personel1.Click += new System.EventHandler(this.tsbtn_Personel1_Click);
            // 
            // tsbtn_Abone
            // 
            this.tsbtn_Abone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbtn_Abone.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Abone.Image")));
            this.tsbtn_Abone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Abone.Name = "tsbtn_Abone";
            this.tsbtn_Abone.Size = new System.Drawing.Size(249, 60);
            this.tsbtn_Abone.Text = "Abone İşlemleri";
            this.tsbtn_Abone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Abone.Click += new System.EventHandler(this.tsbtn_Abone_Click);
            // 
            // tsbtn_Yorum
            // 
            this.tsbtn_Yorum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbtn_Yorum.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Yorum.Image")));
            this.tsbtn_Yorum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Yorum.Name = "tsbtn_Yorum";
            this.tsbtn_Yorum.Size = new System.Drawing.Size(249, 60);
            this.tsbtn_Yorum.Text = "Yorum İşlemleri";
            this.tsbtn_Yorum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_Yorum.ToolTipText = "\r\n\r\nReklam İşlemleri";
            this.tsbtn_Yorum.Click += new System.EventHandler(this.tsbtn_Yorum_Click);
            // 
            // GazeteSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 987);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GazeteSistemi";
            this.Text = "Gazete Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GazeteSistemi_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtn_Haber;
        private System.Windows.Forms.ToolStripButton tsbtn_Abone;
        private System.Windows.Forms.ToolStripButton tsbtn_Yorum;
        private System.Windows.Forms.ToolStripButton tsbtn_GazeteSayisi;
        private System.Windows.Forms.ToolStripButton tsbtn_Personel1;
    }
}