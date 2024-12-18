namespace yılannnn
{
    partial class zorluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zorluk));
            pictureBox1 = new PictureBox();
            kolay = new Button();
            orta = new Button();
            zor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-114, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1061, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // kolay
            // 
            kolay.Location = new Point(264, 104);
            kolay.Name = "kolay";
            kolay.Size = new Size(279, 63);
            kolay.TabIndex = 1;
            kolay.Text = "KOLAY";
            kolay.UseVisualStyleBackColor = true;
            kolay.Click += kolay_Click;
            // 
            // orta
            // 
            orta.Location = new Point(264, 185);
            orta.Name = "orta";
            orta.Size = new Size(279, 63);
            orta.TabIndex = 2;
            orta.Text = "ORTA";
            orta.UseVisualStyleBackColor = true;
            orta.Click += orta_Click;
            // 
            // zor
            // 
            zor.Location = new Point(264, 267);
            zor.Name = "zor";
            zor.Size = new Size(279, 63);
            zor.TabIndex = 3;
            zor.Text = "ZOR";
            zor.UseVisualStyleBackColor = true;
            zor.Click += zor_Click;
            // 
            // zorluk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zor);
            Controls.Add(orta);
            Controls.Add(kolay);
            Controls.Add(pictureBox1);
            Name = "zorluk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zorluk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button kolay;
        private Button orta;
        private Button zor;
    }
}