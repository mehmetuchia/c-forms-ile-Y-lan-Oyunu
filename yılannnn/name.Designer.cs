namespace yılannnn
{
    partial class name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(name));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            oyuncuad = new Label();
            isimatama = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-60, -81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(663, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // oyuncuad
            // 
            oyuncuad.AutoSize = true;
            oyuncuad.Location = new Point(225, 99);
            oyuncuad.Name = "oyuncuad";
            oyuncuad.Size = new Size(62, 20);
            oyuncuad.TabIndex = 4;
            oyuncuad.Text = "İSMİNİZ";
            // 
            // isimatama
            // 
            isimatama.Location = new Point(162, 155);
            isimatama.Name = "isimatama";
            isimatama.Size = new Size(189, 37);
            isimatama.TabIndex = 5;
            isimatama.Text = "İLERLE";
            isimatama.UseVisualStyleBackColor = true;
            isimatama.Click += isimatama_Click;
            // 
            // name
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 301);
            Controls.Add(isimatama);
            Controls.Add(oyuncuad);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "name";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "name";
            Load += name_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label oyuncuad;
        private Button isimatama;
    }
}