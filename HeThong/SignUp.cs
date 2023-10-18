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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLShopPet
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtName, "Tên đăng nhập phải có từ 3 đến 20 ký tự, bao gồm chữ cái, số, và các ký tự đặc biệt như _ và -.");
            toolTip2.SetToolTip(txtPass, "Mật khẩu phải có ít nhất 8 ký tự, bao gồm ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt (@, #, $, %).");
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
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (IsValidName(txtName.Text) && IsValidPassword(txtPass.Text) && IsValidPassword(txtPass2.Text))
            {
                this.Close();
            }
            else
            {
                if (!IsValidName(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Bạn nhập sai rồi !");
                }
                if (!IsValidPassword(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Bạn nhập sai rồi !");
                }
                if (txtPass.Text!=txtPass2.Text)
                {
                    errorProvider1.SetError(txtPass2, "Không trùng mật khẩu !");
                }
                MessageBox.Show("Bạn hãy kiểm tra lại tên đăng nhập hoặc mật khẩu .", "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
