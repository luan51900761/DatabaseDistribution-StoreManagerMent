using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;

namespace QuanLyBanHoa.Forms
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            AccountDAO1 account = new AccountDAO1();

            dgvListAccount.DataSource = account.listCustom().ToList();
        }
        private string IDstaff = "";
        private void dgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dgvListAccount.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgvListAccount.Rows[index];
            txtID.Text = Convert.ToString(row.Cells[0].Value);
            txtStaffName.Text = Convert.ToString(row.Cells[1].Value);
            txtChiNhanh.Text = Convert.ToString(row.Cells[5].Value);
            txtChucvu.Text = Convert.ToString(row.Cells[4].Value);
            txtUsername.Text = Convert.ToString(row.Cells[2].Value);
            txtPass.Text = "Nhập mật khẩu mới";
            IDstaff = txtID.Text;
        }
        private bool CheckValid()
        {
            if (txtStaffName.TextLength == 0)
            {
                return false;
            }
            else if (txtUsername.TextLength < 6)
            {
                return false;
            }
            else if (txtPass.TextLength < 6)
            {
                return false;
            }
            return true;
        }
        private void Clear()
        {
            txtPass.Clear();
            txtStaffName.Clear();
            txtUsername.Clear();
            txtID.Clear();
        }
        private void iconbtnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            AccountDAO1 account = new AccountDAO1();
            if (username != Program.idLoged && account.Delete(username) == 1 )
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                AccountDAO1 accountDAO1 = new AccountDAO1();
                    try
                    {

                        StaffDAO1 staff = new StaffDAO1();
                        taikhoan tk = new taikhoan();
                        tk.manv = staff.getIDbyUsername(Program.idLoged);
                        tk.tentaikhoan = Program.idLoged;
                        tk.matkhau = Script.MD5Hash(txtPass.Text);
                        if (accountDAO1.Edit(tk) == 1)
                        {
                            MessageBox.Show("Cập nhập mật khẩu thành công");
                            LoadData();

                    }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại");

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra!!!");

                    }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public static string id = "";
        public static string tennv = "";
        private void iconButton2_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            tennv = txtStaffName.Text;
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }
    }
}
