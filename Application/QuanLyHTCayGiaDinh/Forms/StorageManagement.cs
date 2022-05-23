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
    public partial class StorageManagement : Form
    {
        private MainScreen main = null;
        public StorageManagement(Form callingForm)
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
            dataGridViewListProduct.DataSource = db.khoes.ToList();


            SetEditingMode(false);
        }
        private void LoadDataByResetButton()
        {
            LoadData();
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


        private void Clear()
        {
            
            LoadData();
            SetEditingMode(false);
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
            txtMakho.Text = Convert.ToString(row.Cells[0].Value);
            txtTenKho.Text = Convert.ToString(row.Cells[1].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells[2].Value);
            txtChiNhanh.Text = Convert.ToString(row.Cells[3].Value);

        }
 

        private void iconbtnDelete_Click(object sender, EventArgs e)
        {

            KhoDAO kho = new KhoDAO();
            if (kho.Delete(txtMakho.Text) == 1)
            {
                MessageBox.Show("Xoá thành công");
                Clear();
                LoadData();

            }
            else
            {
                MessageBox.Show("Xoá thất bại");    
            }

        }

        private void iconbtnUpdate_Click(object sender, EventArgs e)
        {
            kho k = new kho();
            k.makho = txtMakho.Text;
            k.tenkho = txtTenKho.Text;
            k.diachi = txtDiaChi.Text;
            k.macn = txtChiNhanh.Text;

            //try
            //{
            KhoDAO kho = new KhoDAO();
            if (kho.Edit(k) == 1)
            {
                MessageBox.Show("Cập nhập thành công");
                Clear();
                LoadData();

            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");


            }
        }

            private void iconbtnReset_Click(object sender, EventArgs e)
        {
            txtMakho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
            txtChiNhanh.Text = "";
            Clear();

        }


        private void dataGridViewListProduct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            AddKho addKho = new AddKho();
            addKho.Show(); 
        }

        private void panelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
     

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}
