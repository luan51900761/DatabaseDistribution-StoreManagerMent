using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.Forms
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iconBtnClear_Click(object sender, EventArgs e)
        {
        }

        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            AccountDAO1 accountDAO1 = new AccountDAO1();
            taikhoan tk = new taikhoan();
            tk.tentaikhoan = txt_tk.Text;
            tk.matkhau = Script.MD5Hash(txt_mk.Text);
            tk.manv = txt_manv.Text;
            if (accountDAO1.create(tk) == 1)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");

            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            if (CreateAccount.id != "")
            {
                txt_manv.Text = CreateAccount.id;
                txt_tennv.Text = CreateAccount.tennv;
            }
            else
            {
                txt_manv.Text = StorageManagement.id;
                txt_tennv.Text = StorageManagement.tennv;
            }
        }
    }
}
