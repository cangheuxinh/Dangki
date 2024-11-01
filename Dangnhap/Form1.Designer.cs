namespace Dangnhap
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hello_2488_256;
            pictureBox1.Location = new Point(330, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1727545;
            pictureBox2.Location = new Point(210, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(239, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(469, 348);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng kí";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pngtree_key_vector_icon_png_image_470666;
            pictureBox4.Location = new Point(210, 267);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(362, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox4;
        private Button button1;
    }
}
