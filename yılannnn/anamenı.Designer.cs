namespace yılannnn
{
    partial class anamenı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anamenı));
            oynBasla = new Button();
            ayarlar = new Button();
            nasılOYN = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // oynBasla
            // 
            oynBasla.Location = new Point(244, 87);
            oynBasla.Name = "oynBasla";
            oynBasla.Size = new Size(221, 70);
            oynBasla.TabIndex = 0;
            oynBasla.Text = "OYNA";
            oynBasla.UseVisualStyleBackColor = true;
            oynBasla.Click += oynBasla_Click;
            // 
            // ayarlar
            // 
            ayarlar.Location = new Point(244, 163);
            ayarlar.Name = "ayarlar";
            ayarlar.Size = new Size(221, 70);
            ayarlar.TabIndex = 1;
            ayarlar.Text = "AYARLAR";
            ayarlar.UseVisualStyleBackColor = true;
            ayarlar.Click += ayarlar_Click;
            // 
            // nasılOYN
            // 
            nasılOYN.Location = new Point(244, 239);
            nasılOYN.Name = "nasılOYN";
            nasılOYN.Size = new Size(221, 70);
            nasılOYN.TabIndex = 3;
            nasılOYN.Text = "NASIL OYNANIR?";
            nasılOYN.UseVisualStyleBackColor = true;
            nasılOYN.Click += nasılOYN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(244, 315);
            button1.Name = "button1";
            button1.Size = new Size(221, 70);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // anamenı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(721, 450);
            Controls.Add(button1);
            Controls.Add(nasılOYN);
            Controls.Add(ayarlar);
            Controls.Add(oynBasla);
            Name = "anamenı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "anamenı";
            ResumeLayout(false);
        }

        #endregion

        private Button oynBasla;
        private Button ayarlar;
        private Button nasılOYN;
        private Button button1;
    }
}