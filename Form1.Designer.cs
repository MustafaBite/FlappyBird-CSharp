namespace flappy_bırd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(124, 258);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(100, 50);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(453, 383);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 234);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 3;
            this.BoruAlt.TabStop = false;
            this.BoruAlt.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(472, -1);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 147);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 5;
            this.BoruUst.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-9, 614);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(804, 96);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 6;
            this.Zemin.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(42, 29);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(86, 29);
            this.scoreText.TabIndex = 7;
            this.scoreText.Text = "puan:0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(791, 674);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.flappyBird);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

