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
using System.IO;
namespace QuanLyBanHoa.Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadData();
            SetAddingMode();
            iconBtnClear.Enabled = false;
        }
        private void LoadData()
        {
            SupplierDAO SupplierDAO = new SupplierDAO();
            List<string> listNCC = SupplierDAO.ListAll().Select(x => x.mancc).ToList();
            cbSupplier.DataSource = listNCC;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtAmount.Text = "0";
            txtPrice.Text = "1000";
            txt_masp.Text = "";
            txt_tenSP.Text = "";
            cbTypeProduct.SelectedIndex = 0;
            cbSupplier.SelectedIndex = 0;
            cbNSX.SelectedIndex = 0;
            txt_masp.Text = "";
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            SetAddingMode();
            iconBtnClear.Enabled = true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void cbTypeProduct_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
        }
        private bool CheckCondition(string a)
        {
            int x = 0;

            if (Int32.TryParse(a, out x))
            {
                return true;
                // you know that the parsing attempt
                // was successful
            }
            return false;
        }
        private void SetAddingMode()
        {
            if((txtAmount.TextLength == 0) || (txtAmount.TextLength == 0)||(txt_masp.TextLength ==0))
            {
                iconbtnAdd.Enabled = false;
            }
            else
            {
                iconbtnAdd.Enabled = true;
            }
        }
        private void SaveIMG(byte[] b)
        {
            string s = "exec CapNhatIMGHangHoa @id , @hinh";
        }
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
     
                sanpham s = new sanpham();
                s.masp = txt_masp.Text;
                s.tensp = txt_tenSP.Text;
                s.loai = cbTypeProduct.Text;
                s.nhacc= cbSupplier.Text;
                s.nhasx = cbNSX.Text;
                s.giaban = Int32.Parse(txtPrice.Text);
                ProductDAO1 p = new ProductDAO1();
                StorageDAO kho = new StorageDAO();
                if (p.create(s) == 1)
                {
                    MessageBox.Show("Thêm thành công");

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
            
        }
        private bool AddProductToDatabase(int ID, string name, string productTypeID, int bid, int price, int amount, byte[] imgArr)
        {
            return ProductDAO.Instance.AddProduct(ID,name,productTypeID,bid,price,amount,imgArr);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "1000")
            {
                txtPrice.Clear();
                txtPrice.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0")
            {
                txtAmount.Clear();
                txtAmount.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.TextLength == 0)
            {
                txtPrice.Text = "1000";
                txtPrice.ForeColor = Color.DarkGray;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.TextLength == 0)
            {
                txtAmount.Text = "0";
                txtAmount.ForeColor = Color.DarkGray;
            }
        }

        private void picIMGProduct_Click(object sender, EventArgs e)
        {
            SetAddingMode();
        }
        string imageName = "";
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void iconBtnChooseIMG_Click(object sender, EventArgs e)
        {
            
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    imageName = Path.GetFileName(imageLocation);
                    
                    //picIMGProduct.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void lblTypeProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {

        }

        private void lblBID_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
