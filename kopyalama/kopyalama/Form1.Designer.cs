namespace kopyalama
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
            this.btnKaynakSec = new System.Windows.Forms.Button();
            this.btnHedefSec = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnKaynakSec
            // 
            this.btnKaynakSec.Location = new System.Drawing.Point(88, 12);
            this.btnKaynakSec.Name = "btnKaynakSec";
            this.btnKaynakSec.Size = new System.Drawing.Size(138, 36);
            this.btnKaynakSec.TabIndex = 0;
            this.btnKaynakSec.Text = "Kaynak Seç";
            this.btnKaynakSec.UseVisualStyleBackColor = true;
            this.btnKaynakSec.Click += new System.EventHandler(this.btnKaynakSec_Click);
            // 
            // btnHedefSec
            // 
            this.btnHedefSec.Location = new System.Drawing.Point(79, 82);
            this.btnHedefSec.Name = "btnHedefSec";
            this.btnHedefSec.Size = new System.Drawing.Size(156, 36);
            this.btnHedefSec.TabIndex = 1;
            this.btnHedefSec.Text = "Hedef Seç";
            this.btnHedefSec.UseVisualStyleBackColor = true;
            this.btnHedefSec.Click += new System.EventHandler(this.btnHedefSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 151);
            this.Controls.Add(this.btnHedefSec);
            this.Controls.Add(this.btnKaynakSec);
            this.Name = "Form1";
            this.Text = "Kopya Aracı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaynakSec;
        private System.Windows.Forms.Button btnHedefSec;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

