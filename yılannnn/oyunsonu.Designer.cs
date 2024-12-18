namespace yılannnn
{
    partial class oyunsonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyunsonu));
            pictureBox1 = new PictureBox();
            don = new Button();
            yenıoyun = new Button();
            isimci = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-87, -79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // don
            // 
            don.Location = new Point(85, 153);
            don.Name = "don";
            don.Size = new Size(153, 88);
            don.TabIndex = 1;
            don.Text = "Ana Menu";
            don.UseVisualStyleBackColor = true;
            don.Click += don_Click;
            // 
            // yenıoyun
            // 
            yenıoyun.Location = new Point(291, 153);
            yenıoyun.Name = "yenıoyun";
            yenıoyun.Size = new Size(153, 88);
            yenıoyun.TabIndex = 2;
            yenıoyun.Text = "Yeniden Oyna";
            yenıoyun.UseVisualStyleBackColor = true;
            yenıoyun.Click += yenıoyun_Click;
            // 
            // isimci
            // 
            isimci.AutoSize = true;
            isimci.Location = new Point(238, 86);
            isimci.Name = "isimci";
            isimci.Size = new Size(50, 20);
            isimci.TabIndex = 3;
            isimci.Text = "label1";
            isimci.Click += label1_Click;
            // 
            // oyunsonu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 347);
            Controls.Add(isimci);
            Controls.Add(yenıoyun);
            Controls.Add(don);
            Controls.Add(pictureBox1);
            Name = "oyunsonu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "oyunsonu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button don;
        private Button yenıoyun;
        private Label isimci;
    }
}