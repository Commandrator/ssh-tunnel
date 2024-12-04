namespace ssh_local_proxy
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
            this.adress = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.icPortLabel = new System.Windows.Forms.Label();
            this.icPort = new System.Windows.Forms.TextBox();
            this.disPort = new System.Windows.Forms.TextBox();
            this.disPortLabel = new System.Windows.Forms.Label();
            this.kullaniciLabel = new System.Windows.Forms.Label();
            this.kullaniciParola = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.sslKullanımı = new System.Windows.Forms.CheckBox();
            this.sslGroup = new System.Windows.Forms.GroupBox();
            this.chainLabel = new System.Windows.Forms.Label();
            this.PrivateKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chainButton = new System.Windows.Forms.Button();
            this.privKeyButton = new System.Windows.Forms.Button();
            this.sshGroup = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sslGroup.SuspendLayout();
            this.sshGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // adress
            // 
            this.adress.AccessibleDescription = "Alanadı veya ip adresi";
            this.adress.Location = new System.Drawing.Point(84, 19);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(152, 20);
            this.adress.TabIndex = 0;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(33, 22);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(45, 13);
            this.adressLabel.TabIndex = 1;
            this.adressLabel.Text = "Adress :";
            // 
            // icPortLabel
            // 
            this.icPortLabel.AccessibleDescription = "Sunucu Portu";
            this.icPortLabel.AutoSize = true;
            this.icPortLabel.Location = new System.Drawing.Point(0, 49);
            this.icPortLabel.Name = "icPortLabel";
            this.icPortLabel.Size = new System.Drawing.Size(78, 13);
            this.icPortLabel.TabIndex = 2;
            this.icPortLabel.Text = "Sunucu Portu :";
            // 
            // icPort
            // 
            this.icPort.AccessibleDescription = "Sunucu Portu";
            this.icPort.Location = new System.Drawing.Point(84, 49);
            this.icPort.Name = "icPort";
            this.icPort.Size = new System.Drawing.Size(79, 20);
            this.icPort.TabIndex = 3;
            // 
            // disPort
            // 
            this.disPort.AccessibleDescription = "Sunucu Portu";
            this.disPort.Location = new System.Drawing.Point(84, 75);
            this.disPort.Name = "disPort";
            this.disPort.Size = new System.Drawing.Size(79, 20);
            this.disPort.TabIndex = 5;
            // 
            // disPortLabel
            // 
            this.disPortLabel.AccessibleDescription = "Sunucu Portu";
            this.disPortLabel.AutoSize = true;
            this.disPortLabel.Location = new System.Drawing.Point(28, 75);
            this.disPortLabel.Name = "disPortLabel";
            this.disPortLabel.Size = new System.Drawing.Size(50, 13);
            this.disPortLabel.TabIndex = 4;
            this.disPortLabel.Text = "Dış Port :";
            // 
            // kullaniciLabel
            // 
            this.kullaniciLabel.AutoSize = true;
            this.kullaniciLabel.Location = new System.Drawing.Point(242, 22);
            this.kullaniciLabel.Name = "kullaniciLabel";
            this.kullaniciLabel.Size = new System.Drawing.Size(67, 13);
            this.kullaniciLabel.TabIndex = 6;
            this.kullaniciLabel.Text = "Kullanıcı Adı:";
            // 
            // kullaniciParola
            // 
            this.kullaniciParola.AutoSize = true;
            this.kullaniciParola.Location = new System.Drawing.Point(266, 48);
            this.kullaniciParola.Name = "kullaniciParola";
            this.kullaniciParola.Size = new System.Drawing.Size(43, 13);
            this.kullaniciParola.TabIndex = 7;
            this.kullaniciParola.Text = "Parola :";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(315, 22);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(138, 20);
            this.kullaniciAdi.TabIndex = 8;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(315, 48);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(138, 20);
            this.parola.TabIndex = 9;
            // 
            // sslKullanımı
            // 
            this.sslKullanımı.AutoSize = true;
            this.sslKullanımı.Location = new System.Drawing.Point(382, 75);
            this.sslKullanımı.Name = "sslKullanımı";
            this.sslKullanımı.Size = new System.Drawing.Size(71, 17);
            this.sslKullanımı.TabIndex = 10;
            this.sslKullanımı.Text = "SSL/TSL";
            this.sslKullanımı.UseVisualStyleBackColor = true;
            // 
            // sslGroup
            // 
            this.sslGroup.Controls.Add(this.sslKullanımı);
            this.sslGroup.Controls.Add(this.privKeyButton);
            this.sslGroup.Controls.Add(this.chainButton);
            this.sslGroup.Controls.Add(this.textBox2);
            this.sslGroup.Controls.Add(this.textBox1);
            this.sslGroup.Controls.Add(this.PrivateKey);
            this.sslGroup.Controls.Add(this.chainLabel);
            this.sslGroup.Location = new System.Drawing.Point(19, 143);
            this.sslGroup.Name = "sslGroup";
            this.sslGroup.Size = new System.Drawing.Size(463, 104);
            this.sslGroup.TabIndex = 11;
            this.sslGroup.TabStop = false;
            this.sslGroup.Text = "SSL/TCL Bilgisi";
            // 
            // chainLabel
            // 
            this.chainLabel.AutoSize = true;
            this.chainLabel.Location = new System.Drawing.Point(38, 22);
            this.chainLabel.Name = "chainLabel";
            this.chainLabel.Size = new System.Drawing.Size(40, 13);
            this.chainLabel.TabIndex = 0;
            this.chainLabel.Text = "Chain :";
            // 
            // PrivateKey
            // 
            this.PrivateKey.AutoSize = true;
            this.PrivateKey.Location = new System.Drawing.Point(11, 51);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(67, 13);
            this.PrivateKey.TabIndex = 1;
            this.PrivateKey.Text = "Private Key :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 3;
            // 
            // chainButton
            // 
            this.chainButton.Location = new System.Drawing.Point(382, 18);
            this.chainButton.Name = "chainButton";
            this.chainButton.Size = new System.Drawing.Size(75, 23);
            this.chainButton.TabIndex = 4;
            this.chainButton.Text = "button1";
            this.chainButton.UseVisualStyleBackColor = true;
            // 
            // privKeyButton
            // 
            this.privKeyButton.Location = new System.Drawing.Point(382, 46);
            this.privKeyButton.Name = "privKeyButton";
            this.privKeyButton.Size = new System.Drawing.Size(75, 23);
            this.privKeyButton.TabIndex = 5;
            this.privKeyButton.Text = "Gözat";
            this.privKeyButton.UseVisualStyleBackColor = true;
            // 
            // sshGroup
            // 
            this.sshGroup.Controls.Add(this.connectButton);
            this.sshGroup.Controls.Add(this.adress);
            this.sshGroup.Controls.Add(this.adressLabel);
            this.sshGroup.Controls.Add(this.parola);
            this.sshGroup.Controls.Add(this.icPortLabel);
            this.sshGroup.Controls.Add(this.kullaniciAdi);
            this.sshGroup.Controls.Add(this.icPort);
            this.sshGroup.Controls.Add(this.kullaniciParola);
            this.sshGroup.Controls.Add(this.disPortLabel);
            this.sshGroup.Controls.Add(this.kullaniciLabel);
            this.sshGroup.Controls.Add(this.disPort);
            this.sshGroup.Location = new System.Drawing.Point(19, 12);
            this.sshGroup.Name = "sshGroup";
            this.sshGroup.Size = new System.Drawing.Size(463, 115);
            this.sshGroup.TabIndex = 12;
            this.sshGroup.TabStop = false;
            this.sshGroup.Text = "SSH";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(315, 75);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(138, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Bağlan";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.sshGroup);
            this.Controls.Add(this.sslGroup);
            this.Name = "Form1";
            this.Text = "SSH Tunnel";
            this.sslGroup.ResumeLayout(false);
            this.sslGroup.PerformLayout();
            this.sshGroup.ResumeLayout(false);
            this.sshGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label icPortLabel;
        private System.Windows.Forms.TextBox icPort;
        private System.Windows.Forms.TextBox disPort;
        private System.Windows.Forms.Label disPortLabel;
        private System.Windows.Forms.Label kullaniciLabel;
        private System.Windows.Forms.Label kullaniciParola;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.CheckBox sslKullanımı;
        private System.Windows.Forms.GroupBox sslGroup;
        private System.Windows.Forms.Label PrivateKey;
        private System.Windows.Forms.Label chainLabel;
        private System.Windows.Forms.Button privKeyButton;
        private System.Windows.Forms.Button chainButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox sshGroup;
        private System.Windows.Forms.Button connectButton;
    }
}

