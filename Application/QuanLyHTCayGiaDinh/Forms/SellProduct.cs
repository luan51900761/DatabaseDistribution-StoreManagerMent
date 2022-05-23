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
using FontAwesome.Sharp;

namespace QuanLyBanHoa.Forms
{
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
            loaddata();
            //LoadProductToFlowPanel(0, "All", "", 0, 0);
            iconbtnSell.Enabled = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Xóa";
            btn.Name = "btn";
            
            btn.UseColumnTextForButtonValue = true;
            int columnIndex = 5;
            if (dgvListProduct.Columns[""] == null)
            {
                dgvListProduct.Columns.Insert(columnIndex, btn);
                dgvListProduct.Columns[5].Width = 70;
            }
            //LoadTypeProduct();
            //if(AccountDAO.Instance.AccountInfor().Permission != "Admin")
            //{
            //    dtbTime.Enabled = false;
            //    dtp_DetailHis.Enabled = false;
            //}
        }
        public string SID = "";
        public void loaddata() {

            StorageDAO s = new StorageDAO();
            dgv_sellProduct.DataSource = s.listCustom().ToList();

        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadProductToFlowPanel(int ID, string name, string type, int price1, int price2)
        {

            DataTable data = ProductDAO.Instance.ListProductWithIMG(ID, name, type, price1, price2);
            foreach (DataRow item in data.Rows)
            {
                Image img = null;
                int MaHH = (int)item["Mahh"];
                string TenHH = (string)item["Ten"];
                int GiaBan = (int)item["GiaBan"];
                if (item["IMG"] != System.DBNull.Value)
                    //MessageBox.Show("Ko co hinh");
                    img = ByteArrToImage((byte[])item["IMG"]);
                AddProductToFLowPanel(MaHH, TenHH, img, GiaBan);
            }

        }
        // Chuyển  dữ liệu Byte sang IMG

        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        private void AddProductToFLowPanel(int ID, string name, Image img,int GiaBan)
        {

            Panel panel = new Panel();
            panel.Width = 150;
            panel.Height = 190;
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
            ProductWithIMG product = new ProductWithIMG(ID, name, img , GiaBan);
            //MessageBox.Show(product.ID.ToString());
            btn.Tag = product;
            btn.Click += btn_Click;
            btn.Leave += btn_Leave;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(btn);
            btn.Dock = DockStyle.Bottom;
            btn.Height = 140;
            Label lbPrice = new Label();
            lbPrice.Text = GiaBan.ToString()+"đ";
            lbPrice.Font = new Font(FontFamily.GenericSansSerif, 9);
            lbPrice.ForeColor = Color.White;
            panel.Controls.Add(lbPrice);
            lbPrice.Dock = DockStyle.Top;
            Label lb = new Label();
            lb.Text = name;
            lb.Font = new Font(FontFamily.GenericSansSerif, 9);
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
            int price = (btn.Tag as ProductWithIMG).Price;
            txtName.Text = productName.ToString();
            txtID.Text = productID.ToString();
            txtPrice.Text = price.ToString();

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
            iconbtnAddProduct.Enabled = true;
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            txtPrice.ForeColor = Color.Black;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ForeColor = Color.Black;
        }
        
        private void iconbtnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtID.Text!="" && txtName.Text != "" && txtPrice.Text != "")
            {
                string ID = txtID.Text;
                string Name = txtName.Text;
                int Amount = (int)nudAmount.Value;
                int Price = Int32.Parse(txtPrice.Text);
                AddItemToListView(ID, Name, Amount, Price, SID);
                Reset();
                iconbtnAddProduct.Enabled = false;
            }
        }
        private void Reset()
        {
            txtPrice.Text = "Đơn giá";
            txtPrice.ForeColor = Color.Gainsboro;
            txtName.Text = "Tên sản phẩm";
            txtName.ForeColor = Color.Gainsboro;
            nudAmount.Value = 1;

        }
        private int No = 0;
        private int TotalValue = 0;
        private int Pay = 0;
        List<SellItemInfor> ListSellItem = new List<SellItemInfor>();
        private void AddItemToListView(string ID, string Name, int Amount, int Price, string SID)
        {
            bool exist = false;
            int money = Amount * Price;
            foreach (SellItemInfor ItemInfor in ListSellItem)
            {
                string IDProduct = ItemInfor.ProductID;
                if(IDProduct == ID)
                {
                    ItemInfor.Amount = Amount + ItemInfor.Amount;
                    int Money = ItemInfor.Amount * Price;
                    ItemInfor.Money = Money;
                    exist = true;
                    break;

                }
            }
            if (!exist)
            {
                SellItemInfor Item = new SellItemInfor(ID, Name, Amount, Price, money, SID);
                ListSellItem.Add(Item);
            }
            TotalValue = TotalValue + money;
            txtTotalMoney.Text = TotalValue.ToString();
            LoadListView();
        }
        private void LoadListView()
        {
            dgvListProduct.Rows.Clear();
            No = 0;
            foreach(SellItemInfor ItemInfor in ListSellItem)
            {
                No += 1;
                string Name = ItemInfor.Name;
                int Amount = ItemInfor.Amount;
                int money = ItemInfor.Money;
                int Price = ItemInfor.Price;
                dgvListProduct.Rows.Add(No, Name, Amount, Price, money);
                //dgvListProduct.Rows.Add(No, Name, Amount, money, Price, btn);
            }

        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 5)
            {
                SellItemInfor item = ListSellItem[e.RowIndex];
                TotalValue = TotalValue - item.Money;
                Pay = TotalValue - TotalValue;
                txtTotalMoney.Text = TotalValue.ToString();
                ListSellItem.RemoveAt(e.RowIndex);
                LoadListView();
            }
        }
        private void ProceedPayment()
        {
            if (txtTotalMoney.Text != "0")
            {
                StaffDAO1 staff = new StaffDAO1();
                BillDAO1 bill = new BillDAO1();
                hoadon h = new hoadon();
                h.mahd = bill.getnewID();
                h.hoten = txtCustomerName.Text;
                h.sdt = txtCustomerPhoneNumber.Text;
                h.ngaylap = DateTime.Now;
                h.macn = Program.station;
                h.tong = TotalValue;
                h.manv = staff.getIDbyUsername(Program.idLoged);
                if (bill.create(h) == 1)
                {
                    //MessageBox.Show("Thêm thành công");
                    ProceedPayment_Detail(h.mahd);

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
                //int totalValue = TotalValue;
                //int DiscountMoney = totalValue - Pay;
                //string CustomerName = txtCustomerName.Text;
                //string CustomerPhone = txtCustomerPhoneNumber.Text;
                //int IDCustomer = BillDAO.Instance.AddCustomerInfor(CustomerName, CustomerPhone);
                //int IDBill = BillDAO.Instance.AddBillInfor(IDCustomer, StaffID, totalValue, DiscountMoney,Pay);
                
            }
        }
        private void ProceedPayment_Detail(string IDBill)
        {
            foreach(SellItemInfor item in ListSellItem)
            {
                BillDAO1 bill = new BillDAO1();
                chitiethoadon cthd = new chitiethoadon();
                cthd.mahd = IDBill;
                cthd.masp = item.ProductID;
                cthd.soluong = item.Amount;
                if (bill.createDetailbill(cthd) == 1)
                {
                    updateInventory(item.SID, item.ProductID, item.Amount);                                                     

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
                //int money = item.Money;
                //BillDAO.Instance.DetailBill(IDBill, idProduct, amount, money);
            }
        }
        private void updateInventory(string SID, string productID,int amount)
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            try
            {
                var result = db.tonkhoes.Where(x => x.makho == SID && x.masp == productID).FirstOrDefault();
;                if (result != null && result.soluong > amount)
                {
                    //code update db
                    result.makho = SID;
                    result.masp = productID;
                    result.soluong = result.soluong - amount;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Không đủ số lượng!");

                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");


            }
        }


        private void iconbtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if(ListSellItem.Count > 0){
                    ProceedPayment();
                    dgvListProduct.Rows.Clear();
                    Reset();
                    ListSellItem.Clear();
                    txtTotalMoney.Text = "0";
                    TotalValue = 0;
                    Pay = 0;
                    No = 0;
                    MessageBox.Show("Thanh toán thành công");
                    loaddata();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có một sản phẩm đã hết hàng");
            }
        }

        private void iconbtnReset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(txtCustomerName.TextLength == 0 || txtCustomerPhoneNumber.TextLength == 0)
            {
                iconbtnSell.Enabled = false;
            }
            else
            {
                iconbtnSell.Enabled = true;
            }
        }

        private void iconbtnFilter_Click(object sender, EventArgs e)
        {
            FindProduct();
        }
        private void FindProduct()
        {
            int idProduct;
            if (CheckCondition(txtProductID.Text))
            {
                idProduct = int.Parse(txtProductID.Text);
            }
            else
                idProduct = 0;
            string name = txtProductName.Text;
            string typeproductID = "";

            LoadProductToFlowPanel(idProduct, name, typeproductID, 0, 0);
        }
       
        List<TypeProduct> listP = new List<TypeProduct>();
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

        private void txtCustomerPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.TextLength == 0 || txtCustomerPhoneNumber.TextLength == 0)
            {
                iconbtnSell.Enabled = false;
            }
            else
            {
                iconbtnSell.Enabled = true;
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

        private void sub10_Click(object sender, EventArgs e)
        {

        }

        

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            Pay = TotalValue - TotalValue ;
        }

     

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.Text = "";
        }

        private void tabHistory_Click(object sender, EventArgs e)
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            dataGridViewHistory.DataSource = db.hoadons.ToList();        }
        DataTable data = new DataTable();
        private void LoadHistory()
        {
            DBContextSV db = new DBContextSV(Program.connectionString);
            DateTime time = dtbTime.Value.Date;
            //data = BillDAO.Instance.History(time);
            //int n = data.Rows.Count;
            dataGridViewHistory.DataSource = db.hoadons.Where(x=>x.ngaylap.Value== time).ToList();
            int TotalValueMoney = 0;
            int TotalDiscountMoney = 0;
            int TotalPay = 0;
            //for (int i = 1; i <= db.hoadons.ToList().Count; i++)
            //{
            //    dataGridViewHistory.Rows[i].Cells[0].Value = i.ToString();
            ////    TotalValueMoney = TotalValueMoney + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[5].Value.ToString());
            ////    TotalDiscountMoney = TotalDiscountMoney + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[6].Value.ToString());
            //    TotalPay = TotalPay + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[4].Value.ToString());

            //}
            //lblTotalPay.Text = TotalPay.ToString() + "đ";
        }
        DataTable data_detail = new DataTable();
       

        private void dtbTime_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void tcImportGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
            //Load_DetailHistory();
        }

        private void dataGridViewHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 1; i <= data.Rows.Count; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();

            }
        }


        private void lblTotalPay_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            StorageDAO storage = new StorageDAO();
            List<SellGridView> list = storage.listCustombyName(txtProductName.Text).ToList();
            dgv_sellProduct.DataSource = list;
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            StorageDAO storage = new StorageDAO();

            List<SellGridView> list = storage.listCustombyID(txtProductID.Text).ToList();
            dgv_sellProduct.DataSource = list;
        }

        private void flpListProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
            txtPrice.Text = Convert.ToString(row.Cells[5].Value);
            SID = Convert.ToString(row.Cells[0].Value); 

        }

        private void tabPageDetailHistory_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_sellProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        WebBrowser myWebBrowser = new WebBrowser();
        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            string s = Properties.Resources.invoice;
            //string html = System.IO.File.ReadAllText(s);

            DataGridViewRow row = this.dataGridViewHistory.Rows[e.RowIndex];

            
            string mahd = row.Cells["mahd"].Value.ToString();
            Console.WriteLine(mahd);
            DBContextSV db = new DBContextSV(Program.connectionString);

            hoadon hd = db.hoadons.Find(mahd);

            s = s.Replace("{{customerName}}", hd.hoten);
            s = s.Replace("{{customerPhone}}", hd.sdt);
            s = s.Replace("{{tong}}", hd.tong.ToString());
            s = s.Replace("{{mahd}}", hd.mahd);
            s = s.Replace("{{ngay}}", hd.ngaylap.ToString());

            chitiethoadon[] cthd = hd.chitiethoadons.ToArray();

            string list = "";

            foreach (chitiethoadon chitiethoadon in cthd)
            {
                string template = $"<tr><td>{chitiethoadon.sanpham.tensp}</td><td>{chitiethoadon.sanpham.giaban} vnd</td><td>{chitiethoadon.soluong}</td></tr> ";
                list += template;
            }
            s = s.Replace("{{list}}", list);
            myWebBrowser.DocumentText = s;

        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPrintPreviewDialog();
        }

        private void printInvoiceReportBtn_Click(object sender, EventArgs e)
        {
            PrintInvoice   printInvoice = new PrintInvoice();
            printInvoice.ShowDialog();
        }
    }
}
