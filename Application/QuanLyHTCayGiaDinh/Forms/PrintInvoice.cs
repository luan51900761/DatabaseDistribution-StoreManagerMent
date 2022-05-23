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
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }
        WebBrowser myWebBrowser = new WebBrowser();
        private void printBtn_Click(object sender, EventArgs e)
        {
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            string html = Properties.Resources.invoicelist;
            int month = cbMonth.SelectedIndex + 1;
            int year;
            if (Int32.TryParse(txtYear.Text, out year))
            {
                if (year < 0 || year > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm không hợp lệ");
                }

            }
            else
            {
                MessageBox.Show("Năm không hợp lệ");
            }

            DBContextSV db = new DBContextSV(Program.connectionString);

            hoadon[] pnList = db.hoadons.Where(hd => hd.ngaylap.Value.Month == month && hd.ngaylap.Value.Year == year).ToArray();


            string list = "";
            int tong = 0;
            foreach (hoadon hd in pnList)
            {
                tong += hd.tong ?? default(int);

                string template = $"<tr><td>{hd.hoten}</td><td>{hd.ngaylap} vnd</td><td>{hd.tong} vnd</td></tr> ";
                list += template;
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
