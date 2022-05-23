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
    public partial class InventoryManagement : Form
    {
        private MainScreen main = null;
        public InventoryManagement(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
            LoadDataByResetButton();
            Color c = Color.FromArgb(0, 189, 69);
            ChangeColor(c);
            dgvTonKho.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvTonKho.RowTemplate.Height = 50;

        }
        private void ChangeColor(Color color)
        {
            
        }
        private Color color = Color.FromArgb(24, 155, 242);
        private void LoadData()
        {
            StorageDAO s = new StorageDAO();
            DBContextSV db = new DBContextSV(Program.connectionString);
            comboBox1.DataSource = db.chinhanhs.Select(x => x.tencn).ToList();
            dgvTonKho.DataSource = s.listCustom().ToList();
            SetEditingMode(false);
        }
        private void LoadbyCN(string key)
        {
            StorageDAO s = new StorageDAO();
            dgvTonKho.DataSource = s.listCustombyCN(key).ToList();
            SetEditingMode(false);
        }
        private void LoadDataByResetButton()
        {
            LoadData();
        }

        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
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
                dgvTonKho.ClearSelection();
            }
        }
        private void dataGridViewListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dgvTonKho.RowCount)
            {
                return;
            }
            SetEditingMode(true);
            DataGridViewRow row = dgvTonKho.Rows[index];
            String masp = Convert.ToString(row.Cells[0].Value);
            String tensp = Convert.ToString(row.Cells[1].Value);
            String nsx = Convert.ToString(row.Cells[2].Value);
            String tenloai = Convert.ToString(row.Cells[3].Value);
            String giaban = Convert.ToString(row.Cells[4].Value);
            String ncc = Convert.ToString(row.Cells[5].Value);

        }
        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        private void labelmoney1_Click(object sender, EventArgs e)
        {

        }

 

       
        private void iconbtnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void dataGridViewListProduct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridViewListProduct_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dgvTonKho.Rows)
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Chi nhánh 1")
            {
                LoadbyCN("CN01");
            }
            else
            {
                LoadbyCN("CN02");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            loadDataByKey(txtName.Text);
        }

        private void loadDataByKey(string text)
        {
            StorageDAO s = new StorageDAO();
            dgvTonKho.DataSource = s.listCustombyName(text).ToList();
        }

        private void iconbtnAdd_Click_1(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            ImportGoods import = new ImportGoods(this);
            main.Show();
            main.openChildForm(import);
        }
    }
}
