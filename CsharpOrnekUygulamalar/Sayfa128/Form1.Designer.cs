
namespace Sayfa128
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
            this.txt_babaadi = new System.Windows.Forms.TextBox();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.txt_adısoyadı = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.lstbabaad = new System.Windows.Forms.ListBox();
            this.lstbolum = new System.Windows.Forms.ListBox();
            this.lstadsayad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_babaadi
            // 
            this.txt_babaadi.Location = new System.Drawing.Point(307, 7);
            this.txt_babaadi.Name = "txt_babaadi";
            this.txt_babaadi.Size = new System.Drawing.Size(120, 20);
            this.txt_babaadi.TabIndex = 8;
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(159, 7);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(120, 20);
            this.txt_bolum.TabIndex = 9;
            // 
            // txt_adısoyadı
            // 
            this.txt_adısoyadı.Location = new System.Drawing.Point(12, 7);
            this.txt_adısoyadı.Name = "txt_adısoyadı";
            this.txt_adısoyadı.Size = new System.Drawing.Size(120, 20);
            this.txt_adısoyadı.TabIndex = 10;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(250, 221);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(91, 32);
            this.sil.TabIndex = 6;
            this.sil.Text = "button1";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(61, 221);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(89, 32);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "button1";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // lstbabaad
            // 
            this.lstbabaad.FormattingEnabled = true;
            this.lstbabaad.Location = new System.Drawing.Point(307, 51);
            this.lstbabaad.Name = "lstbabaad";
            this.lstbabaad.Size = new System.Drawing.Size(120, 160);
            this.lstbabaad.TabIndex = 3;
            this.lstbabaad.SelectedIndexChanged += new System.EventHandler(this.tiklanirsa);
            // 
            // lstbolum
            // 
            this.lstbolum.FormattingEnabled = true;
            this.lstbolum.Location = new System.Drawing.Point(159, 51);
            this.lstbolum.Name = "lstbolum";
            this.lstbolum.Size = new System.Drawing.Size(120, 160);
            this.lstbolum.TabIndex = 4;
            this.lstbolum.SelectedIndexChanged += new System.EventHandler(this.tiklanirsa);
            // 
            // lstadsayad
            // 
            this.lstadsayad.FormattingEnabled = true;
            this.lstadsayad.Location = new System.Drawing.Point(12, 51);
            this.lstadsayad.Name = "lstadsayad";
            this.lstadsayad.Size = new System.Drawing.Size(120, 160);
            this.lstadsayad.TabIndex = 5;
            this.lstadsayad.SelectedIndexChanged += new System.EventHandler(this.tiklanirsa);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 268);
            this.Controls.Add(this.txt_babaadi);
            this.Controls.Add(this.txt_bolum);
            this.Controls.Add(this.txt_adısoyadı);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.lstbabaad);
            this.Controls.Add(this.lstbolum);
            this.Controls.Add(this.lstadsayad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_babaadi;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.TextBox txt_adısoyadı;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.ListBox lstbabaad;
        private System.Windows.Forms.ListBox lstbolum;
        private System.Windows.Forms.ListBox lstadsayad;
    }
}

