using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace QuanLyBanHoa
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Green;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.LightGray;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Green;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rd_Admin.Checked == true)
            {
                try
                {
                    string password = Script.MD5Hash(txtPassword.Text);
                    string connect = "data source=DESKTOP-BELSK30\\HOST;initial catalog=cuahanglinhkienmaytinh;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework";
                    DBContextSV db = new DBContextSV(connect);

                    var result = db.taikhoans.SingleOrDefault(x=>x.tentaikhoan == txtUsername.Text && x.matkhau == password);

                    if (result != null)
                    {
                        if (result.nhanvien.chucvu != "ADMIN")
                        {
                            MessageBox.Show("Bạn không có quyền truy cập");
                        }
                        else
                        {

                            Program.connectionString = connect;
                            if(cb_cn.Text == "Chi Nhánh 1")
                            {
                                Program.station = "CN01";

                            }
                            else if(cb_cn.Text == "Chi Nhánh 2")
                            {
                                Program.station = "CN02";

                            }
                            else
                            {
                                Program.station = "CN01";

                            }
                            Program.idLoged = txtUsername.Text;
                            MainScreen ms = new MainScreen();
                            ms.Show();
                            this.Hide();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");

                    }

                }
                catch
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else
            {
                if (cb_cn.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
                {
                    if (cb_cn.Text == "Chi Nhánh 1")
                    {
                        try
                        {
                            string password = Script.MD5Hash(txtPassword.Text);
                            string connect = "data source=DESKTOP-BELSK30\\STORE1;initial catalog=cuahanglinhkienmaytinh;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework";
                            DBContextSV db = new DBContextSV(connect);
                            var result = db.taikhoans.SingleOrDefault(x => x.tentaikhoan == txtUsername.Text && x.matkhau == password);
                            if (result != null)
                            {
                                Program.connectionString = connect;
                                Program.station = "CN01";
                                Program.idLoged = txtUsername.Text;
                                MainScreen ms = new MainScreen();
                                ms.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");

                            }

                        }
                        catch
                        {
                            MessageBox.Show("Đăng nhập thất bại");
                        }
                    }
                    else
                    {
                        try
                        {
                            string password = Script.MD5Hash(txtPassword.Text);
                            string connect = "data source=DESKTOP-BELSK30\\STORE2;initial catalog=cuahanglinhkienmaytinh;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework";
                            DBContextSV db = new DBContextSV(connect);
                            var result = db.taikhoans.SingleOrDefault(x => x.tentaikhoan == txtUsername.Text && x.matkhau == password);
                            if (result != null)
                            {
                                Program.connectionString = connect;
                                Program.station = "CN02";
                                Program.idLoged = txtUsername.Text;
                                MainScreen ms = new MainScreen();
                                ms.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");

                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đăng nhập thất bại");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

                }
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool isChecked = false;

        private void rd_Admin_Click(object sender, EventArgs e)
        {
            if (rd_Admin.Checked && !isChecked)
            {
                rd_Admin.Checked = false;
                cb_cn.Enabled = true;
            }
            else
            {
                cb_cn.Enabled = false;
                rd_Admin.Checked = true;
                isChecked = false;
            }
        }

        private void rd_Admin_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rd_Admin.Checked;


        }
    }
}
