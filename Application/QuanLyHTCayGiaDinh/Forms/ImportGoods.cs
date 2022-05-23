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
    public partial class ImportGoods : Form
    {
        string makho = "";
        private MainScreen main = null;
        public ImportGoods(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
           // ChangeIconColor(main.hightlightColor);
            LoadData();

        }
        private void ChangeIconColor(Color color)
        {
            iconbtnAddProduct.IconColor = color;
            iconbtnImport.IconColor = color;
            iconbtnReset.IconColor = color;
            iconbtnAddProduct.ForeColor = Color.White;
            iconbtnImport.ForeColor = Color.White;
            
        }
        List<TypeProduct> listP = new List<TypeProduct>();
        List<Supplier> listS = new List<Supplier>();
        List<(int, int)> ListPrice = new List<(int, int)>();
        private void FindProduct()
        {
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
        private void LoadData()
        {
            StorageDAO s = new StorageDAO();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dgv_sellProduct.DataSource = s.listCustom().ToList();
            cbSupplier.DataSource = db.nhaccs.Select(x => x.mancc).ToList();

        }
        //Làm mới toàn bộ thông tin
        private void Reset()
        {
            txtBID.Text = "Giá nhập";
            txtBID.ForeColor = Color.Gainsboro;
            txtName.Text = "Tên sản phẩm";
            txtName.ForeColor = Color.Gainsboro;
            nudAmount.Value = 1;
            
        }
        private void Clear()
        {
            txtProductName.Clear();
            cbTypeProduct.SelectedItem = null;
            LoadData();
        }
        private string ChangeValue(int i)
        {
            if(i * 1000 > 1000000)
                return (i/1000)+" triệu";
            return i + "k";

        }
        // Chuyển  dữ liệu Byte sang IMG

        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }

        private void tabHistory_Click(object sender, EventArgs e)
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewHistory.DataSource = db.phieunhaps.ToList();
        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void listViewProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        
        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            if (CheckCondition(txtBID.Text)&&(txtName.Text != "Tên sản phẩm"))
            {
                iconbtnAddProduct.Enabled = true;
            }
            else
            {
                iconbtnAddProduct.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nudAmount.Value = nudAmount.Value + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value - 10 > 0)
                nudAmount.Value = nudAmount.Value - 10;
            else
                nudAmount.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudAmount.Value = nudAmount.Value + 100;
        }

        private void btnS100_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value - 100 > 0)
                nudAmount.Value = nudAmount.Value - 100;
            else
                nudAmount.Value = 1;
        }
        private int No = 0;
        int TotalValue = 0;
        List<ImportGoodsInfor> ListImportGood = new List<ImportGoodsInfor>();
        private void AddItemToListView(string ID, string Name,int Amount, int BID)
        {
            No = No + 1;
            ListViewItem lsvItem = new ListViewItem(No.ToString());
            lsvItem.SubItems.Add(Name.ToString());
            lsvItem.SubItems.Add(Amount.ToString());
            int money = Amount * BID;
            lsvItem.SubItems.Add(money.ToString());
            lsvItem.SubItems.Add(BID.ToString());
            listVProduct.Items.Add(lsvItem);
            TotalValue = TotalValue + money;
            ImportGoodsInfor ItemInfor = new ImportGoodsInfor(ID, Name, Amount, BID, money);
            ListImportGood.Add(ItemInfor);
            txtTotalMoney.Text = TotalValue.ToString();
        }
        private void iconbtnAddProduct_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            int Amount = (int)nudAmount.Value;
            int BID = Int32.Parse(txtBID.Text);
            AddItemToListView(ID, Name, Amount, BID);
            Reset();
            iconbtnAddProduct.Enabled = false;
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbTypeProduct.Text;
            StorageDAO s = new StorageDAO();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dgv_sellProduct.DataSource = s.listCustom().Where(x=>x.loai.Contains(key)).ToList();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            string key = txtProductName.Text;
            StorageDAO s = new StorageDAO();
            DBContextSV db = new DBContextSV(Program.connectionString);
            dgv_sellProduct.DataSource = s.listCustom().Where(x => x.tensp.Contains(key)).ToList();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Clear();
            //LoadProductToFlowPanel(0,"All","",0,0);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FindProduct();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBID_Enter(object sender, EventArgs e)
        {
            if (txtBID.Text == "Giá nhập")
            {
                txtBID.Clear();
                txtBID.ForeColor = Color.Black;
            }
        }

        private void txtBID_Leave(object sender, EventArgs e)
        {
            if (txtBID.Text =="")
            {
                txtBID.Text ="Giá nhập";
                txtBID.ForeColor = Color.Gainsboro;
            }
        }

        private void nudAmount_Enter(object sender, EventArgs e)
        {

        }

        private void flpListProduct_Paint_2(object sender, PaintEventArgs e)
        {

        }
        private void LoadProductToFlowPanel(int ID, string name, string type,int price1, int price2)
        {

            DataTable data = ProductDAO.Instance.ListProductWithIMG(ID, name, type, price1,price2);
            foreach (DataRow item in data.Rows)
            {
                Image img = null;
                int MaHH = (int)item["Mahh"];
                string TenHH = (string)item["Ten"];
                if (item["IMG"] != System.DBNull.Value)
                    //MessageBox.Show("Ko co hinh");
                    img = ByteArrToImage((byte[])item["IMG"]);
                AddProductToFLowPanel(MaHH,TenHH,img);
            }
           
        }
        private void AddProductToFLowPanel(int ID, string name,Image img)
        {
            
            Panel panel = new Panel();
            panel.Width = 170;
            panel.Height = 200;
            panel.Margin = new Padding(6);
            panel.BackColor = Color.FromArgb(10, 120, 90);
            Button btn = new Button();
            if (img != null)
            {
                btn.BackgroundImage = img;

            }
            else
            {
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\HoaSen.jpg");
            }
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(10, 120, 90);
            ProductWithIMG product = new ProductWithIMG(ID, name, img);
            //MessageBox.Show(product.ID.ToString());
            btn.Tag = product;
            btn.Click += btn_Click;
            btn.Leave += btn_Leave;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(btn);
            btn.Dock = DockStyle.Bottom;
            btn.Height = 170;
            Label lb = new Label();
            lb.Text = name;
            lb.Font = new Font(FontFamily.GenericSansSerif, 12);
            lb.ForeColor = Color.White;

            panel.Controls.Add(lb);
            lb.Dock = DockStyle.Top;
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.FromArgb(10, 120, 90);
            btn.FlatAppearance.BorderSize = 4;
            int productID = (btn.Tag as ProductWithIMG).ID;
            string productName = (btn.Tag as ProductWithIMG).Name;
            txtName.Text = productName.ToString();
            txtID.Text = productID.ToString();

        }
        void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.FromArgb(10, 120, 90);
            btn.FlatAppearance.BorderSize = 1;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
        }
        private void ImportGood()
        { 
            if(txtTotalMoney.Text != "0")
            {
                ImportDAO importDAO = new ImportDAO();
                DBContextSV db = new DBContextSV(Program.connectionString);
                phieunhap pn = new phieunhap();
                pn.mapn = importDAO.getnewID();
                pn.ngaynhap = DateTime.Now;
                pn.makho = makho;
                pn.mancc = cbSupplier.Text;
                pn.tong = Int32.Parse(txtTotalMoney.Text);
                if (importDAO.create(pn) == 1)
                {
                    //MessageBox.Show("Thêm thành công");
                    ImportGoodDetail(pn.mapn);

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
               
            }
        }
        private void ImportGoodDetail(string mapn) {
            foreach(ImportGoodsInfor item in ListImportGood)
            {
                ImportDAO import = new ImportDAO();
                chitietphieunhap ctpn = new chitietphieunhap();
                ctpn.mapn = mapn;
                ctpn.masp = item.ProductID;
                ctpn.soluong = item.Amount;
                ctpn.gianhap = item.BID;
                if (import.createDetailImport(ctpn) == 1)
                {
                    MessageBox.Show("Thêm thành công");


                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
            }
        }
        private void iconbtnImport_Click(object sender, EventArgs e)
        {
            ImportGood();
            cbSupplier.SelectedIndex = 0;
            ListImportGood.Clear();
            txtTotalMoney.Text = "0";
            No = 0;
            TotalValue = 0;
            listVProduct.Items.Clear();
        }

        private void listVProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ForeColor = Color.Black;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listVProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
        DataTable data = new DataTable();
        private void LoadHistory()
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewHistory.DataSource = db.phieunhaps.ToList();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            DateTime time = dtbTime.Value.Date;
            dataGridViewHistory.DataSource = db.phieunhaps.Where(x => x.ngaynhap.Value == time).ToList();
        }

        private void tcImportGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void dataGridViewHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 1; i <= data.Rows.Count; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();

            }
        }

        private void tabImportGoods_Click(object sender, EventArgs e)
        {

        }

        private void panelProduct_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPrice_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMoney_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_sellProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dgv_sellProduct.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgv_sellProduct.Rows[index];
            txtID.Text = Convert.ToString(row.Cells[1].Value);
            txtName.Text = Convert.ToString(row.Cells[2].Value);
            txtBID.Text = Convert.ToString(row.Cells[5].Value);
            makho = Convert.ToString(row.Cells[0].Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ImportDAO import = new ImportDAO();
            phieunhap pn = new phieunhap();
            pn.mapn = txtMaPN.Text;
            pn.tinhtrang = 1;
            if (import.Edit(pn) == 1)
            {
                updateInventory(txtMaPN.Text, txtMakho.Text);
                MessageBox.Show("Duyệt thành công");
                LoadHistory();


            }
            else
            {
                MessageBox.Show("Duyệt thất bại");

            }


        }
            private void updateInventory(string maPN, string makho)
            {
                DBContextSV db = new DBContextSV(Program.connectionString);
                
                try
                {
                List<chitietphieunhap> listctpn = db.chitietphieunhaps.Where(x => x.mapn == maPN).ToList();
                foreach (chitietphieunhap item in listctpn)
                {
                    var result = db.tonkhoes.Where(x => x.makho == makho && x.masp == item.masp).FirstOrDefault();
                     if (result != null)
                    {
                        //code update db
                        result.makho = makho;
                        result.masp = item.masp;
                        result.soluong = result.soluong + item.soluong;
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi!");

                    }
                }

                

                }
                catch
                {
                    MessageBox.Show("Duyệt thất bại!");


                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[index];
            txtMaPN.Text = Convert.ToString(row.Cells[0].Value);
            txtMakho.Text = Convert.ToString(row.Cells[2].Value);
            txtTong.Text = Convert.ToString(row.Cells[4].Value);
            //txtNgaylap.Text = Convert.ToString(row.Cells[6].Value);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridView1.DataSource = db.phieunhaps.ToList();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtMakho_TextChanged(object sender, EventArgs e)
        {

        }

        private void printInventoryBtn_Click(object sender, EventArgs e)
        {
            PrintInventory printInventory = new PrintInventory();
            printInventory.ShowDialog();
        }
    }
}
