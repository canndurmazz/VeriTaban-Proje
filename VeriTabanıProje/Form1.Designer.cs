
namespace VeriTabanıProje
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
            this.ceogiris = new System.Windows.Forms.Button();
            this.yöneticigiris = new System.Windows.Forms.Button();
            this.müsterigiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ceogiris
            // 
            this.ceogiris.Location = new System.Drawing.Point(576, 42);
            this.ceogiris.Name = "ceogiris";
            this.ceogiris.Size = new System.Drawing.Size(212, 226);
            this.ceogiris.TabIndex = 0;
            this.ceogiris.Text = "C E O";
            this.ceogiris.UseVisualStyleBackColor = true;
            this.ceogiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // yöneticigiris
            // 
            this.yöneticigiris.Location = new System.Drawing.Point(291, 42);
            this.yöneticigiris.Name = "yöneticigiris";
            this.yöneticigiris.Size = new System.Drawing.Size(212, 226);
            this.yöneticigiris.TabIndex = 1;
            this.yöneticigiris.Text = "Y Ö N E T İ C İ";
            this.yöneticigiris.UseVisualStyleBackColor = true;
            this.yöneticigiris.Click += new System.EventHandler(this.yöneticigiris_Click);
            // 
            // müsterigiris
            // 
            this.müsterigiris.Location = new System.Drawing.Point(12, 42);
            this.müsterigiris.Name = "müsterigiris";
            this.müsterigiris.Size = new System.Drawing.Size(212, 226);
            this.müsterigiris.TabIndex = 2;
            this.müsterigiris.Text = "M Ü Ş T E R İ";
            this.müsterigiris.UseVisualStyleBackColor = true;
            this.müsterigiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "KMC YATIRIM A.Ş";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 287);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 45);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buraya Tıklamayın";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Durdur !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.müsterigiris);
            this.Controls.Add(this.yöneticigiris);
            this.Controls.Add(this.ceogiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ceogiris;
        private System.Windows.Forms.Button yöneticigiris;
        private System.Windows.Forms.Button müsterigiris;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

