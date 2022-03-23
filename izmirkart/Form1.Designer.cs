namespace izmirkart
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btntam = new System.Windows.Forms.Button();
            this.btnogrenci = new System.Windows.Forms.Button();
            this.btnogretmen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblcontrol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(215, 27);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(245, 22);
            this.txtBakiye.TabIndex = 1;
            // 
            // btntam
            // 
            this.btntam.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntam.Location = new System.Drawing.Point(26, 152);
            this.btntam.Name = "btntam";
            this.btntam.Size = new System.Drawing.Size(130, 71);
            this.btntam.TabIndex = 2;
            this.btntam.Text = "Tam";
            this.btntam.UseVisualStyleBackColor = true;
            this.btntam.Click += new System.EventHandler(this.btntam_Click);
            // 
            // btnogrenci
            // 
            this.btnogrenci.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnogrenci.Location = new System.Drawing.Point(26, 239);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(130, 70);
            this.btnogrenci.TabIndex = 3;
            this.btnogrenci.Text = "Ogrenci";
            this.btnogrenci.UseVisualStyleBackColor = true;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // btnogretmen
            // 
            this.btnogretmen.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnogretmen.Location = new System.Drawing.Point(26, 326);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(130, 76);
            this.btnogretmen.TabIndex = 4;
            this.btnogretmen.Text = "Ogretmen";
            this.btnogretmen.UseVisualStyleBackColor = true;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "KALAN";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(487, 232);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(45, 32);
            this.lblKalan.TabIndex = 6;
            this.lblKalan.Text = "0.0";
            // 
            // btnBakiye
            // 
            this.btnBakiye.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBakiye.Location = new System.Drawing.Point(587, 25);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(202, 66);
            this.btnBakiye.TabIndex = 7;
            this.btnBakiye.Text = "BakiyeYükle";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblcontrol
            // 
            this.lblcontrol.AutoSize = true;
            this.lblcontrol.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontrol.Location = new System.Drawing.Point(1063, 373);
            this.lblcontrol.Name = "lblcontrol";
            this.lblcontrol.Size = new System.Drawing.Size(28, 29);
            this.lblcontrol.TabIndex = 8;
            this.lblcontrol.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 477);
            this.Controls.Add(this.lblcontrol);
            this.Controls.Add(this.btnBakiye);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.btnogrenci);
            this.Controls.Add(this.btntam);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btntam;
        private System.Windows.Forms.Button btnogrenci;
        private System.Windows.Forms.Button btnogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblcontrol;
    }
}

