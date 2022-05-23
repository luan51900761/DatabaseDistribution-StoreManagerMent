using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.Forms;
using System.IO;
using QuanLyBanHoa.DTO;
//using QuanLyBanHoa.DTO;

namespace QuanLyBanHoa
{
    public partial class ProvidersManagement : Form
    {
        private MainScreen main = null;
        public ProvidersManagement(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
            LoadDataByResetButton();
            Color c = Color.FromArgb(0, 189, 69);
            ChangeColor(c);
            dataGridViewListProduct.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewListProduct.RowTemplate.Height = 50;

        }
        private void ChangeColor(Color color)
        {
            iconbtnReset.IconColor = color;
            iconbtnAdd.IconColor = color;
            iconbtnUpdate.IconColor = color;
            iconbtnDelete.IconColor = color;
        }
        private Color color = Color.FromArgb(24, 155, 242);
        private void LoadData()
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewListProduct.DataSource = db.nhaccs.ToList();
            dataGridViewListProduct.Columns[5].Visible = false;
            dataGridViewListProduct.Columns[6].Visible = false;
            dataGridViewListProduct.Columns[7].Visible = false;
            //dataGridViewListProduct.Columns[9].Visible = false;
            //dataGridViewListProduct.Columns[10].Visible = false;


            SetEditingMode(false);
        }
        private void LoadDataByResetButton()
        {
            LoadData();
        }

        private void ProvidersManagement_Load(object sender, EventArgs e)
        {
            
            //SetEditingMode(false);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        int idproduct = 0;
        string name = "";
        private void FindProduct()
        {
            DataTable data = ProductDAO.Instance.FindProduct(idproduct, name);
            LoadData();

        }
        private bool CheckCondition(string a)
        {
            int x = 0;

            if (Int32.TryParse(a, out x))
            {
                return true;
            }
            return false;
        }
        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProduct_Enter(object sender, EventArgs e)
        {
   
        }

        private void txtNameProduct_Enter(object sender, EventArgs e)
        {
           
        }

  

 
        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }
        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dataGridViewListProduct.ClearSelection();
            }
            iconbtnDelete.Enabled = enable;
            iconbtnUpdate.Enabled = enable;
            iconbtnReset.Enabled = enable;
        }
        private void dataGridViewListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewListProduct.RowCount)
            {
                return;
            }
            SetEditingMode(true);
            DataGridViewRow row = dataGridViewListProduct.Rows[index];
            txtMaNCC.Text= Convert.ToString(row.Cells[0].Value);
            txtTenNCC.Text = Convert.ToString(row.Cells[1].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells[2].Value);
            txtSDT.Text = Convert.ToString(row.Cells[3].Value);
            txtEmail.Text = Convert.ToString(row.Cells[4].Value);

        }
        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        private void labelmoney1_Click(object sender, EventArgs e)
        {

        }

        private void iconbtnDelete_Click(object sender, EventArgs e)
        {

            string ID = txtMaNCC.Text;
            NhaCCDAO nhancc = new NhaCCDAO();
            int result = nhancc.Delete(ID);
            if (result==1)
            {
                MessageBox.Show("Xóa nhà cung cấp thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại");
            }
            if ((idproduct == 0) && (name == ""))
            {
                LoadDataByResetButton();
            }
            else
            {
                FindProduct();
            }

        }


        private void iconbtnReset_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

  
        
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            AddNCC addncc = new AddNCC();
            addncc.Show(); 
        }

        private void panelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void iconbtnUpdate_Click(object sender, EventArgs e)
        {
            nhacc ncc = new nhacc();
           ncc.mancc =  txtMaNCC.Text;
            ncc.tenncc =  txtTenNCC.Text;
            ncc.diachi = txtDiaChi.Text;
            ncc.sdt = txtSDT.Text;
            ncc.email  = txtEmail.Text;

            //try
            //{
            NhaCCDAO nhaCCDAO = new NhaCCDAO();
            if (nhaCCDAO.Edit(ncc) == 1)
            {
                MessageBox.Show("Cập nhập thành công");
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
                LoadData();

            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");


            }
        }

        private void lblMaNCC_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeProviderName_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
