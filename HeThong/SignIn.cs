using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopPet
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            toolTip2.SetToolTip(txtName, "Tên đăng nhập phải có từ 3 đến 20 ký tự, bao gồm chữ cái, số, và các ký tự đặc biệt như _ và -.");
            toolTip1.SetToolTip(txtPass, "Mật khẩu phải có ít nhất 8 ký tự, bao gồm ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt (@, #, $, %).");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private bool IsValidPassword(string password)
        {
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%])\\S{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        private bool IsValidName(string name)
        {
            string pattern = "^[a-zA-Z0-9_-]{3,20}$";
            return Regex.IsMatch(name, pattern);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValidName(txtName.Text) && IsValidPassword(txtPass.Text)) {
                Manager form2 = new Manager();
                this.Close();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                if(!IsValidName(txtName.Text))
                {
                    errorProvider1.SetError(txtName,"Bạn nhập sai rồi !");
                }
                if (!IsValidPassword(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Bạn nhập sai rồi !");
                }
                MessageBox.Show("Bạn hãy kiểm tra lại tên đăng nhập hoặc mật khẩu .", "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            //this.Close();
            signUp.ShowDialog();
            this.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_ResizeBegin(object sender, EventArgs e)
        {
            panel1.Size = this.ClientSize;
        }
    }
}
