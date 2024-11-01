namespace Dangki
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
            if (disposing && (components != null))//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox_TenTaiKhoan = new TextBox();
            textBox_MatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_XNMatKhau = new TextBox();
            textBox_Email = new TextBox();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(202, 282);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Location = new Point(403, 189);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(181, 27);
            textBox_TenTaiKhoan.TabIndex = 4;
            textBox_TenTaiKhoan.TextChanged += textBox_TenTaiKhoan_TextChanged;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(403, 236);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(181, 27);
            textBox_MatKhau.TabIndex = 5;
            textBox_MatKhau.TextChanged += textBox_MatKhau_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(234, 192);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên tài khoản";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(234, 239);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(234, 282);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 8;
            label3.Text = "Xác nhận mật khẩu";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(234, 328);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // textBox_XNMatKhau
            // 
            textBox_XNMatKhau.Location = new Point(403, 282);
            textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            textBox_XNMatKhau.Size = new Size(181, 27);
            textBox_XNMatKhau.TabIndex = 10;
            textBox_XNMatKhau.TextChanged += textBox_XNMatKhau_TextChanged;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(403, 328);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(181, 27);
            textBox_Email.TabIndex = 11;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            // 
            // button_DangKy
            // 
            button_DangKy.BackColor = Color.DodgerBlue;
            button_DangKy.Location = new Point(349, 391);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(119, 30);
            button_DangKy.TabIndex = 12;
            button_DangKy.Text = "Đăng kí";
            button_DangKy.UseVisualStyleBackColor = false;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_DangKy);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_XNMatKhau);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "DangKy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_MatKhau;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_XNMatKhau;
        private TextBox textBox_Email;
        private Button button_DangKy;
    }
}
