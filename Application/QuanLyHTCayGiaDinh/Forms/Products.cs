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
    public partial class Products : Form
    {
        private MainScreen main = null;
        public Products(Form callingForm)
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
            iconBtnSearch.IconColor = color;
            iconbtnReset.IconColor = color;
            iconbtnClear.IconColor = color;
            iconbtnAdd.IconColor = color;
            iconbtnUpdate.IconColor = color;
            iconbtnDelete.IconColor = color;
        }
        private Color color = Color.FromArgb(24, 155, 242);
        private void LoadData()
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewListProduct.DataSource = db.sanphams.ToList();
            dataGridViewListProduct.Columns[6].Visible = false;
            dataGridViewListProduct.Columns[7].Visible = false;
            dataGridViewListProduct.Columns[8].Visible = false;
            dataGridViewListProduct.Columns[9].Visible = false;
            dataGridViewListProduct.Columns[10].Visible = false;


            SetEditingMode(false);
        }
        private void LoadDataByResetButton()
        {
            LoadData();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            
            //SetEditingMode(false);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            ProductDAO1 p = new ProductDAO1();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewListProduct.DataSource = db.sanphams.Where(x => x.masp.Contains(txtIDProduct.Text)).ToList();
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
            if(txtIDProduct.Text == "Mã sản phẩm")
            {
                txtIDProduct.Clear();
                txtIDProduct.ForeColor = color;
            }
        }

        private void txtNameProduct_Enter(object sender, EventArgs e)
        {
            if (txtNameProduct.Text == "Tên sản phẩm")
            {
                txtNameProduct.Clear();
                txtNameProduct.ForeColor = color;
            }
        }

        private void txtIDProduct_Leave(object sender, EventArgs e)
        {
            if(txtIDProduct.TextLength == 0)
            {
                txtIDProduct.Text = "Mã sản phẩm";
                txtIDProduct.ForeColor = Color.LightGray;
                
            }
        }

        private void txtNameProduct_Leave(object sender, EventArgs e)
        {
            if (txtNameProduct.TextLength == 0)
            {
                txtNameProduct.Text = "Tên sản phẩm";
                txtNameProduct.ForeColor = Color.LightGray;
            }
        }

        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtID.Text = "";
            txtNSX.Text = "";
            txtName.Text = "";
            txtTypeProductName.Text = "";
            txtPrice.Text = "";
            txtNCC.Text = "";
            picture.Image = picture.InitialImage;
            LoadData();
            SetEditingMode(false);
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
            String masp = Convert.ToString(row.Cells[0].Value);
            String tensp = Convert.ToString(row.Cells[1].Value);
            String nsx = Convert.ToString(row.Cells[2].Value);
            String tenloai = Convert.ToString(row.Cells[3].Value);
            String giaban = Convert.ToString(row.Cells[4].Value);
            String ncc = Convert.ToString(row.Cells[5].Value);

            // update UI
            txtID.Text = masp;
            txtNSX.Text = nsx;
            txtName.Text = tensp;
            txtTypeProductName.Text = tenloai;
            txtPrice.Text = giaban;
            txtNCC.Text = ncc;

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

            string ID = txtID.Text;
            ProductDAO1 p = new ProductDAO1();
            int result = p.Delete(ID);
            if (result==1)
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
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

        private void iconbtnUpdate_Click(object sender, EventArgs e)
        {

            sanpham s = new sanpham();
            s.masp = txtID.Text;
            s.nhasx = txtNSX.Text;
            s.tensp =  txtName.Text;
            s.loai = txtTypeProductName.Text;
            s.giaban = Int32.Parse(txtPrice.Text);
            s.nhacc = txtNCC.Text;
            ProductDAO1 p = new ProductDAO1();
            int result = p.Edit(s);
           if (result == 1)
          {
                MessageBox.Show("Cập nhật sản phẩm thành công");
              LoadData();
              Clear();
           }
           else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");
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
            Clear();
        }

        private void iconbtnClear_Click_1(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtNameProduct.Clear();
            txtIDProduct.Text = "Mã sản phẩm";
            txtIDProduct.ForeColor = Color.LightGray;
            txtNameProduct.Text = "Tên sản phẩm";
            txtNameProduct.ForeColor = Color.LightGray;
            idproduct = 0;
            name = "";
            LoadDataByResetButton();
            Clear();
        }

        private void dataGridViewListProduct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridViewListProduct_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridViewListProduct.Rows)
            {
                x.MinimumHeight = 50;
            }
        }
        
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show(); 
        }

        private void panelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    //picIMGProduct.ImageLocation = imageLocation;
                    picture.Image = new Bitmap(imageLocation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelmoney2_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProduct_TextChanged_1(object sender, EventArgs e)
        {
            ProductDAO1 p = new ProductDAO1();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewListProduct.DataSource = db.sanphams.Where(x => x.masp.Contains(txtIDProduct.Text)).ToList();
        }

        private void txtNameProduct_TextChanged_1(object sender, EventArgs e)
        {
            ProductDAO1 p = new ProductDAO1();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewListProduct.DataSource = db.sanphams.Where(x => x.tensp.Contains(txtNameProduct.Text)).ToList();
        }

        private void lblBid_Click(object sender, EventArgs e)
        {

        }

        private void lblMaHH_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeProductName_Click(object sender, EventArgs e)
        {

        }

        private void txtTypeProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
