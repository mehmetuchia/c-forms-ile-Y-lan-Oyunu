namespace yılannnn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblSkor = new Label();
            pnlOyun = new Panel();
            tmrOyun = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Font = new Font("Courier New", 16F);
            lblSkor.Location = new Point(597, 18);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(61, 30);
            lblSkor.TabIndex = 0;
            lblSkor.Text = "000";
            lblSkor.Click += label1_Click;
            // 
            // pnlOyun
            // 
            pnlOyun.BackColor = Color.Black;
            pnlOyun.Location = new Point(12, 52);
            pnlOyun.Margin = new Padding(3, 4, 3, 4);
            pnlOyun.Name = "pnlOyun";
            pnlOyun.Size = new Size(646, 601);
            pnlOyun.TabIndex = 1;
            pnlOyun.Paint += pnlOyun_Paint;
            // 
            // tmrOyun
            // 
            tmrOyun.Interval = 200;
            tmrOyun.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 660);
            button1.Name = "button1";
            button1.Size = new Size(646, 45);
            button1.TabIndex = 2;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 21);
            button2.Name = "button2";
            button2.Size = new Size(91, 29);
            button2.TabIndex = 4;
            button2.Text = "GERİ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 717);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblSkor);
            Controls.Add(pnlOyun);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YILAN OYUNU";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSkor;
        private Panel pnlOyun;
        private Button button1;
        public System.Windows.Forms.Timer tmrOyun;
        private Label label1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
