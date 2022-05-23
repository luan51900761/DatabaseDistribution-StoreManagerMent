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
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private int current_gender = 1;
        private void UserInformation_Load(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan();
            nhanvien nv = new nhanvien();
            AccountDAO1 accountDAO = new AccountDAO1();
            StaffDAO1 staffDAO = new StaffDAO1();
            tk = accountDAO.getAccountLogedin();
            nv = staffDAO.getStaffLogedin();
            txtName.Text = nv.hoten;
            txtCMND.Text = nv.cnmd;
            txtPhoneNumber.Text = nv.sdt;
            txtPermission.Text = nv.chucvu;
            current_gender = (int)nv.gioitinh;
            if(nv.gioitinh == 1)
            {
                cbFemale.Checked=true;
            }
            else
            {
                cbMale.Checked = true;
            }
            txtUsername.Text = tk.tentaikhoan;
            txtBirth.Text = nv.ngaysinh.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void iconbtnChangePassword_Click(object sender, EventArgs e)
        {
            Form changepass = new ChangePassword();
            changepass.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
