using System.Text.RegularExpressions;

namespace Dangki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public bool CheckAccount(string ac) //Check m?t kh?u và tên tài kho?n
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) // Check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn)?$");
        }
        Modify modify = new Modify();
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text; 
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text; 
            string email = textBox_Email.Text;
            if(!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nh?p tên tài kho?n dài 6-24 ký t?, v?i các ký t? ch? và s?, ch? hoa và ch? th??ng"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nh?p tên m?t kh?u dài 6-24 ký t?, v?i các ký t? ch? và s?, ch? hoa và ch? th??ng"); return; }
            if(xnmatkhau!=matkhau) { MessageBox.Show("Vui lòng xác nh?n m?t kh?u chính xác!"); return; }
            if(!CheckEmail(email)) { MessageBox.Show("Vui lòng nh?p ?úng ??nh d?ng email!"); return; }
            if(modify.Taikhoans("Select*from where Email =' " +email+"'").Count !=0) { MessageBox.Show("Email này ?ã ???c ??ng kí, vui lòng ??ng kí email khác!"); return; }
            try
            {

            }
            catch
        }

        private void textBox_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_XNMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
