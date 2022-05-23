using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.Forms
{
    public partial class PrintInventory : Form
    {
        public PrintInventory()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        WebBrowser myWebBrowser = new WebBrowser();
        private void printBtn_Click(object sender, EventArgs e)
        {
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            string html = Properties.Resources.inventory;
            int month = cbMonth.SelectedIndex + 1;
            int year;
            if (Int32.TryParse(txtYear.Text, out year))
            {
                if (year < 0 || year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ");
                }
                
            } else
            {
                MessageBox.Show("Năm không hợp lệ");
            }

            DBContextSV db = new DBContextSV(Program.connectionString);

            phieunhap[] pnList = db.phieunhaps.Where(pn => pn.ngaynhap.Value.Month == month && pn.ngaynhap.Value.Year == year).ToArray();


            string list = "";
            int tong = 0;
            foreach (phieunhap pn in pnList)
            {
                tong += pn.tong;
                foreach (chitietphieunhap ctpn in pn.chitietphieunhaps)
                {
                string template = $"<tr><td>{ctpn.sanpham.tensp}</td><td>{ctpn.gianhap} vnd</td><td>{ctpn.soluong}</td><td>{pn.ngaynhap}</td></tr> ";
                list += template;
                }
            }
            html = html.Replace("{{list}}", list).Replace("{{month}}", month.ToString()).Replace("{{tong}}", tong.ToString()).Replace("{{year}}", year.ToString());
            myWebBrowser.DocumentText = html;
        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPrintPreviewDialog();
        }
    }
}
