using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyBanHoa.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
namespace QuanLyBanHoa
{
    public partial class MainScreen : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        
        public MainScreen()
        {
            InitializeComponent();
            CustomizeDesing();
            leftBorderBtn = new Panel();
            panelMenu.Controls.Add(leftBorderBtn);
            panelline.BackColor = hightlightColor;
            //iconbtnUser.Text = AccountDAO.Instance.AccountInfor().DisplayName;
         
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            phanquyen();
            //if(AccountDAO.Instance.AccountInfor().Permission.Trim() != "Admin")
            //{
            //    iconbtnadmin.Visible = false;
            //    iconbtnProducts.Visible = false;
            //    panelsubmenuProduct.Height = 70;
            //    iconbtnCustomers.Visible = false;
            //}
        }
        public void phanquyen()
        {
            StaffDAO1 staff = new StaffDAO1();
            if (staff.getStaffLogedin().chucvu == "quản lý")
            {
                iconTaiKhoan.Visible = false;
                iconbtnadmin.Visible = false;
                iconNCC.Visible = false;

            }
            else if (staff.getStaffLogedin().chucvu == "nhân viên")
            {
                iconTaiKhoan.Visible = false;
                iconbtnadmin.Visible = false;
                iconKho.Visible = false;
                iconbtnImportGoods.Visible = false;
                iconNCC.Visible = false;


            }
            else if (staff.getStaffLogedin().chucvu == "thủ kho")
            {
                iconTaiKhoan.Visible = false;
                iconbtnadmin.Visible = false;
                iconKho.Visible = false;
                iconbtnImportGoods.Visible = false;
                iconNCC.Visible = false;
                iconbtnSelling.Visible = false;
                iconbtnMenuProducts.Visible = false;

            }
        }
        public void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblHome.Text = childForm.Text;
        }
        //Structs
        private struct RGB
        {
            //green
            public static Color color1 = Color.FromArgb(255, 255, 255);
            //red
            public static Color color2 = Color.FromArgb(247, 22, 52);
            //pink
            public static Color color3 = Color.FromArgb(242, 0, 242);
            //lightblue
            public static Color color4 = Color.FromArgb(5, 255, 251);
            //yellow
            public static Color color5 = Color.FromArgb(238, 255, 5);
        }
        public Color hightlightColor = RGB.color1;
        private void activateButton(object senderBtn, Color color)
        {
            //if(senderBtn != null)
            //{
            //    disableButton();
            //    //Button
            //    currentButton = (IconButton)senderBtn;
            //    currentButton.BackColor = Color.FromArgb(5, 225, 90);
            //    currentButton.ForeColor = color;
            //    currentButton.IconColor = color;
            //    currentButton.TextAlign = ContentAlignment.MiddleRight;
            //    currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            //    currentButton.ImageAlign = ContentAlignment.MiddleCenter;
            //    leftBorderBtn.BackColor = color;
            //    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
            //    leftBorderBtn.Visible = true;
            //    leftBorderBtn.BringToFront();
            //    //Top icon
            //    iconbtnHome.IconChar = currentButton.IconChar;
            //    iconbtnHome.IconColor = color;
            //    lblHome.Text = currentButton.Text;
            //    lblHome.ForeColor = color;
            //    panelShadow.BackColor = color;
            //    panelline.BackColor = color;
            //}
        }
        private void disableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(5, 225, 90);
                //currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                //currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                //reset Top icon
                iconbtnHome.IconChar = IconChar.Home;
                //iconbtnHome.IconColor = Color.White;
                lblHome.Text = "Home";
                //lblHome.ForeColor = Color.White;
                panelShadow.BackColor = Color.FromArgb(10, 120, 90);
                panelline.BackColor = Color.Black;
            }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void iconbtnSelling_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new SellProduct());
            
        }

        private void iconbtnProducts_Click(object sender, EventArgs e)
        {
            //activateButton(sender, hightlightColor);
            //ChangeSubMenuButtonColor(sender, Color.FromArgb(239, 240, 235), panelline1);
            openChildForm(new Products(this));

        }
        private void CustomizeDesing()
        {
            panelsubmenuProduct.Visible = false;
            //............
        }
        private void HideSubMenu()
        {
            if(panelsubmenuProduct.Visible == true)
                panelsubmenuProduct.Visible = false;

        }
        private bool ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                disableSubMenuButton();
                HideSubMenu();
                subMenu.Visible = true;
                return true;
            }
            else
                subMenu.Visible = false;
            return false;

        }
        private void iconbtnCustomers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new Customers());
            
        }

        private void iconbtnadmin_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new Forms.StorageManagement());
        }

        private void iconbtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
           
        private void iconbtnSetting_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            Setting setting = new Setting(this);
            openChildForm(setting);
            setting.passControl = new Setting.PassControl(changeColor);
        }
        public void changePanelColor(Color color)
        {
            panelline.BackColor = color;
            panelShadow.BackColor = color;
            iconbtnSetting.IconColor = color;
            iconbtnSetting.ForeColor = color;
            leftBorderBtn.BackColor = color;
            iconbtnHome.IconColor = color;
            lblHome.ForeColor = color;
        }
        private void changeColor(object sender)
        {
            hightlightColor = (Color)sender;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            disableButton();
            leftBorderBtn.Visible = false;
            //currentChildForm.Close();
        }

        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconbtnMenuProducts_Click(object sender, EventArgs e)
        {
            activateButton(sender, hightlightColor);
            bool show = ShowSubMenu(panelsubmenuProduct);
            if (!show)
            {
                if (currentChildForm != null)
                    currentChildForm.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ChangeSubMenuButtonColor(object senderBtn, Color color, Panel panel)
        {
            if (senderBtn != null)
            {
                disableSubMenuButton();
                //Button
                currentSubMenuButton = (IconButton)senderBtn;
                currentSubMenuButton.BackColor = Color.FromArgb(10, 120, 90);
                currentSubMenuButton.ForeColor = color;
                currentSubMenuButton.IconColor = color;
   
                //Top icon
                iconbtnHome.IconChar = currentSubMenuButton.IconChar;
                iconbtnHome.IconColor = color;
                lblHome.Text = currentSubMenuButton.Text;
                currentPanelline = panel;
                lblHome.ForeColor = hightlightColor;
                currentPanelline.BackColor = color;
            }
        }
        private IconButton currentSubMenuButton;
        private Panel currentPanelline;
        private void disableSubMenuButton()
        {
            if (currentSubMenuButton != null)
            {
                currentSubMenuButton.BackColor = Color.FromArgb(29, 98, 78);
                currentSubMenuButton.ForeColor = Color.White;
                currentSubMenuButton.IconColor = Color.White;
                currentPanelline.BackColor = Color.FromArgb(29, 98, 78);
                //reset Top icon
            }
        }

        private void iconbtnImportGoods_Click(object sender, EventArgs e)
        {
            //ChangeSubMenuButtonColor(sender, Color.FromArgb(239, 240, 235), panelline2);
            openChildForm(new ImportGoods(this));
        }

        private void iconbtnUser_MouseHover(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = hightlightColor;
            iconbtnUser.IconColor = hightlightColor;
        }

        private void iconbtnUser_MouseLeave(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = Color.White;
            iconbtnUser.IconColor = Color.White;
        }

        private void iconbtnUser_Click(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = hightlightColor;
            iconbtnUser.IconColor = hightlightColor;
            Form userIfor = new UserInformation();
            userIfor.ShowDialog();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconTaiKhoan_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new CreateAccount());
        }

        private void iconKho_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new StorageManagement(this));
        }

        private void iconNCC_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new ProvidersManagement(this));
        }

        private void iconTonKho_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new InventoryManagement(this));
        }

        private void iconbtnImportGoods_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ImportGoods(this));
        }

        private void iconThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistics());
        }
    }
}
