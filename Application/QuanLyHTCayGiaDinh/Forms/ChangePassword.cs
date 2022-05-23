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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void iconbtnAccept_Click(object sender, EventArgs e)
        {
            
            if(txtOldPass.TextLength == 0 || txtConfirmPass.TextLength == 0 || txtNewpass.TextLength == 0)
            {
                MessageBox.Show("Vẫn còn thông tin bị bỏ sót");
            }
            else if(txtNewpass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với nhau");
            }
            else if (txtNewpass.TextLength < 6)
            {
                MessageBox.Show("Mật khẩu quá ngắn");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    AccountDAO1 accountDAO1 = new AccountDAO1();
                    if (accountDAO1.getAccountLogedin().matkhau != Script.MD5Hash(txtOldPass.Text))
                    {
                        MessageBox.Show("mật khẩu cũ không đúng");

                    }
                    else
                    {
                        try
                        {

                            StaffDAO1 staff = new StaffDAO1();
                            taikhoan tk = new taikhoan();
                            tk.manv = staff.getIDbyUsername(Program.idLoged);
                            tk.tentaikhoan = Program.idLoged;
                            tk.matkhau = Script.MD5Hash(txtNewpass.Text);
                            if (accountDAO1.Edit(tk) == 1)
                            {
                                MessageBox.Show("Thêm thành công");

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
            }
            
        }

        private void iconbtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
