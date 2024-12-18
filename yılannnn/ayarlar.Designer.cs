namespace yılannnn
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            chkMusic = new CheckBox();
            lblVolume = new Label();
            btnSave = new Button();
            trackVolume = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, -146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(857, 726);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(23, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "GERİ";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkMusic
            // 
            chkMusic.AutoSize = true;
            chkMusic.Location = new Point(271, 59);
            chkMusic.Name = "chkMusic";
            chkMusic.Size = new Size(130, 24);
            chkMusic.TabIndex = 2;
            chkMusic.Text = "müzik: aç/kapa";
            chkMusic.UseVisualStyleBackColor = true;
            chkMusic.CheckedChanged += chkMusic_CheckedChanged;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(271, 100);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(110, 20);
            lblVolume.TabIndex = 3;
            lblVolume.Text = "Ses Seviyesi: 50";
            lblVolume.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(271, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // trackVolume
            // 
            trackVolume.Location = new Point(271, 193);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Size = new Size(240, 56);
            trackVolume.TabIndex = 5;
            trackVolume.Value = 50;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // ayarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackVolume);
            Controls.Add(btnSave);
            Controls.Add(lblVolume);
            Controls.Add(chkMusic);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "ayarlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ayarlar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private CheckBox chkMusic;
        private Label lblVolume;
        private Button btnSave;
        private TrackBar trackVolume;
    }
}