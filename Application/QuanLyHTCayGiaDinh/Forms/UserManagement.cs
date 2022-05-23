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
    public partial class StorageManagement : Form
    {
        public StorageManagement()
        {
            InitializeComponent();
            SetEditingMode(false);
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadListStaff();

        }
        private void LoadListStaff()
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dgvListStaff.DataSource = db.nhanviens.ToList();
            dgvListStaff.Columns[6].Visible = false;
            dgvListStaff.Columns[10].Visible = false;
            dgvListStaff.Columns[11].Visible = false;
            dgvListStaff.Columns[12].Visible = false;


        }
        private string IDstaff = "";
        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iconbtnAdd.Enabled = false;
            SetEditingMode(true);
            int index = e.RowIndex;
            if (index < 0 || index >= dgvListStaff.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgvListStaff.Rows[index];
            IDstaff = Convert.ToString(row.Cells[0].Value);
            txtStaffName.Text = Convert.ToString(row.Cells[1].Value);
            txtPhoneNumber.Text = Convert.ToString(row.Cells[2].Value);
            dtpBirth.Value  = Convert.ToDateTime(row.Cells[7].Value);
            cbbPosition.Text = Convert.ToString(row.Cells[5].Value);
            dtpDateStart.Value = Convert.ToDateTime(row.Cells[3].Value);
            Boolean gender = Convert.ToBoolean(row.Cells[8].Value);
            DateTime daystart = Convert.ToDateTime(row.Cells[7].Value);
            txtCMND.Text = Convert.ToString(row.Cells[9].Value);
            if (Convert.ToString(row.Cells[4].Value) == "CN01")
            {
                cbStation.Text = "Chi Nhánh 1";
            }
            else
            {
                cbStation.Text = "Chi Nhánh 2";
            }
            // update UI
            if (gender != true)
            {
                cbFemale.Checked = true;
            }
            else
            {
                cbMale.Checked = true;
            }
 
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFemale.Checked == true)
            {
                cbMale.Checked = false;
            }
        }
        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dgvListStaff.ClearSelection();
            }
            iconbtnDelete.Enabled = enable;
            iconbtnUpdate.Enabled = enable;
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMale.Checked== true)
            {
                cbFemale.Checked = false;
            }
        }
        
        private void iconButton4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            iconbtnAdd.Enabled = true;
            SetEditingMode(false);
            txtCMND.Clear();
            txtPhoneNumber.Clear();
            txtStaffName.Clear();
            dtpBirth.Value = DateTime.Now;
            dtpDateStart.Value = DateTime.Now;
            cbbPosition.SelectedItem = null;
            cbFemale.Checked = false;
            cbMale.Checked = false;
            IDstaff = "";
        }
        private bool isNum(string a)
        {
            int x = 0;

            if (Int32.TryParse(a, out x))
            {
                return true;
            }
            return false;
        }
        private bool CheckValid()
        {
            return true;
        }

        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                nhanvien nv = new nhanvien();
                nv.hoten = txtStaffName.Text;
                nv.ngaysinh = dtpBirth.Value;
                if (cbFemale.Checked)
                {
                    nv.gioitinh = 0;
                }
                else
                {
                    nv.gioitinh = 1;
                };
                nv.cnmd = txtCMND.Text;
                nv.sdt = txtPhoneNumber.Text;
                nv.ngaylamviec = dtpDateStart.Value;
                nv.chucvu = cbbPosition.Text;
                string chinhanh = cbStation.Text;
                if(chinhanh == "Chi Nhánh 1")
                {
                    nv.macn = "CN01";
                }
                else
                {
                    nv.macn = "CN02";
                }
                try
                {
                    StaffDAO1 staff = new StaffDAO1();
                    nv.manv = staff.getnewID();
                    if (staff.create(nv) == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                        Clear();
                        LoadListStaff();


                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ hoặc thông tin không hợp lệ");
            }
        }

        private void iconbtnDelete_Click(object sender, EventArgs e)
        {
            StaffDAO1 staff = new StaffDAO1();
            if (staff.Delete(IDstaff) == 1)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                Clear();
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void iconbtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                nhanvien nv = new nhanvien();
                nv.hoten = txtStaffName.Text;
                nv.ngaysinh = dtpBirth.Value;
                if (cbFemale.Checked)
                {
                    nv.gioitinh = 0;
                }
                else
                {
                    nv.gioitinh = 1;
                };
                nv.cnmd = txtCMND.Text;
                nv.sdt = txtPhoneNumber.Text;
                nv.ngaylamviec = dtpDateStart.Value;
                nv.chucvu = cbbPosition.Text;
                string chinhanh = cbStation.Text;
                if (chinhanh == "Chi Nhánh 1")
                {
                    nv.macn = "CN01";
                }
                else
                {
                    nv.macn = "CN02";
                }

                //try
                //{
                    StaffDAO1 staff = new StaffDAO1();
                    nv.manv = IDstaff;
                    if (staff.Edit(nv) == 1)
                    {
                        MessageBox.Show("Cập nhập thành công");
                        Clear();
                         LoadListStaff();

                }
                    else
                    {
                        MessageBox.Show("Cập nhập thất bại");

                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Đã xảy ra lỗi: " + ex.ToString());
                //}

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ hoặc thông tin không hợp lệ");
            }

        }
        public static string id = "";
        public static string tennv = "";
        private void iconbtnCreateAccount_Click(object sender, EventArgs e)
        {
            id = IDstaff;
            tennv = txtStaffName.Text;
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
