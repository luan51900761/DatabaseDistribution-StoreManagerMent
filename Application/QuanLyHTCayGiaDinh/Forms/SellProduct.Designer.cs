namespace QuanLyBanHoa.Forms
{
    partial class SellProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dtbTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcImportGoods = new System.Windows.Forms.TabControl();
            this.tabSellProduct = new System.Windows.Forms.TabPage();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add10 = new System.Windows.Forms.Button();
            this.dgv_sellProduct = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub10 = new System.Windows.Forms.Button();
            this.iconbtnSell = new FontAwesome.Sharp.IconButton();
            this.add100 = new System.Windows.Forms.Button();
            this.sub100 = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.iconbtnAddProduct = new FontAwesome.Sharp.IconButton();
            this.printInvoiceReportBtn = new System.Windows.Forms.Button();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.tcImportGoods.SuspendLayout();
            this.tabSellProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(18, 120);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.MaximumSize = new System.Drawing.Size(399, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(359, 30);
            this.txtProductName.TabIndex = 17;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(18, 43);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.MaximumSize = new System.Drawing.Size(399, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(359, 30);
            this.txtProductID.TabIndex = 21;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabHistory.Controls.Add(this.printInvoiceReportBtn);
            this.tabHistory.Controls.Add(this.lblTotalPay);
            this.tabHistory.Controls.Add(this.lbl13);
            this.tabHistory.Controls.Add(this.labelTime);
            this.tabHistory.Controls.Add(this.dtbTime);
            this.tabHistory.Controls.Add(this.dataGridViewHistory);
            this.tabHistory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabHistory.Location = new System.Drawing.Point(4, 49);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabHistory.Size = new System.Drawing.Size(1716, 806);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "Lịch sử bán hàng";
            this.tabHistory.Click += new System.EventHandler(this.tabHistory_Click);
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPay.ForeColor = System.Drawing.Color.White;
            this.lblTotalPay.Location = new System.Drawing.Point(622, 36);
            this.lblTotalPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(32, 22);
            this.lblTotalPay.TabIndex = 8;
            this.lblTotalPay.Text = "0đ";
            this.lblTotalPay.Visible = false;
            this.lblTotalPay.Click += new System.EventHandler(this.lblTotalPay_Click);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl13.ForeColor = System.Drawing.Color.White;
            this.lbl13.Location = new System.Drawing.Point(524, 36);
            this.lbl13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(47, 22);
            this.lbl13.TabIndex = 7;
            this.lbl13.Text = "Thu:";
            this.lbl13.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(29, 39);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(78, 19);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Thời gian";
            // 
            // dtbTime
            // 
            this.dtbTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbTime.Location = new System.Drawing.Point(161, 33);
            this.dtbTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtbTime.Name = "dtbTime";
            this.dtbTime.Size = new System.Drawing.Size(296, 30);
            this.dtbTime.TabIndex = 1;
            this.dtbTime.ValueChanged += new System.EventHandler(this.dtbTime_ValueChanged);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.hoten,
            this.SDT,
            this.Tong,
            this.Column1,
            this.Column2});
            this.dataGridViewHistory.Location = new System.Drawing.Point(1, 97);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 62;
            this.dataGridViewHistory.RowTemplate.Height = 30;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(1711, 705);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellClick);
            this.dataGridViewHistory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHistory_ColumnHeaderMouseClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "mahd";
            this.MaHD.FillWeight = 60F;
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.FillWeight = 140F;
            this.hoten.HeaderText = "Tên khách hàng";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "sdt";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "tong";
            this.Tong.FillWeight = 140F;
            this.Tong.HeaderText = "Tổng tiền";
            this.Tong.MinimumWidth = 8;
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ngaylap";
            this.Column1.HeaderText = "Ngày Lập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "macn";
            this.Column2.HeaderText = "Chi Nhánh";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tcImportGoods
            // 
            this.tcImportGoods.Controls.Add(this.tabSellProduct);
            this.tcImportGoods.Controls.Add(this.tabHistory);
            this.tcImportGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImportGoods.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcImportGoods.ItemSize = new System.Drawing.Size(120, 45);
            this.tcImportGoods.Location = new System.Drawing.Point(0, 0);
            this.tcImportGoods.Margin = new System.Windows.Forms.Padding(4);
            this.tcImportGoods.Name = "tcImportGoods";
            this.tcImportGoods.Padding = new System.Drawing.Point(20, 7);
            this.tcImportGoods.SelectedIndex = 0;
            this.tcImportGoods.Size = new System.Drawing.Size(1724, 859);
            this.tcImportGoods.TabIndex = 1;
            this.tcImportGoods.SelectedIndexChanged += new System.EventHandler(this.tcImportGoods_SelectedIndexChanged);
            // 
            // tabSellProduct
            // 
            this.tabSellProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabSellProduct.Controls.Add(this.txtProductID);
            this.tabSellProduct.Controls.Add(this.label2);
            this.tabSellProduct.Controls.Add(this.label3);
            this.tabSellProduct.Controls.Add(this.txtProductName);
            this.tabSellProduct.Controls.Add(this.iconbtnReset);
            this.tabSellProduct.Controls.Add(this.txtCustomerPhoneNumber);
            this.tabSellProduct.Controls.Add(this.label10);
            this.tabSellProduct.Controls.Add(this.txtID);
            this.tabSellProduct.Controls.Add(this.txtCustomerName);
            this.tabSellProduct.Controls.Add(this.txtTotalMoney);
            this.tabSellProduct.Controls.Add(this.lbl);
            this.tabSellProduct.Controls.Add(this.dgvListProduct);
            this.tabSellProduct.Controls.Add(this.label9);
            this.tabSellProduct.Controls.Add(this.txtPrice);
            this.tabSellProduct.Controls.Add(this.label5);
            this.tabSellProduct.Controls.Add(this.add10);
            this.tabSellProduct.Controls.Add(this.dgv_sellProduct);
            this.tabSellProduct.Controls.Add(this.sub10);
            this.tabSellProduct.Controls.Add(this.iconbtnSell);
            this.tabSellProduct.Controls.Add(this.add100);
            this.tabSellProduct.Controls.Add(this.sub100);
            this.tabSellProduct.Controls.Add(this.nudAmount);
            this.tabSellProduct.Controls.Add(this.txtName);
            this.tabSellProduct.Controls.Add(this.iconbtnAddProduct);
            this.tabSellProduct.Location = new System.Drawing.Point(4, 49);
            this.tabSellProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.tabSellProduct.Name = "tabSellProduct";
            this.tabSellProduct.Padding = new System.Windows.Forms.Padding(4);
            this.tabSellProduct.Size = new System.Drawing.Size(1716, 806);
            this.tabSellProduct.TabIndex = 0;
            this.tabSellProduct.Text = "Bán hàng";
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconbtnReset.FlatAppearance.BorderSize = 0;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnReset.ForeColor = System.Drawing.Color.White;
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 40;
            this.iconbtnReset.Location = new System.Drawing.Point(18, 163);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(267, 59);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(112, 38);
            this.iconbtnReset.TabIndex = 15;
            this.iconbtnReset.Text = "Làm mới";
            this.iconbtnReset.UseVisualStyleBackColor = false;
            this.iconbtnReset.Click += new System.EventHandler(this.iconbtnReset_Click);
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(1395, 67);
            this.txtCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(312, 34);
            this.txtCustomerPhoneNumber.TabIndex = 16;
            this.txtCustomerPhoneNumber.TextChanged += new System.EventHandler(this.txtCustomerPhoneNumber_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1391, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sđt";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(941, 117);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(52, 30);
            this.txtID.TabIndex = 19;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCustomerName.Location = new System.Drawing.Point(941, 67);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(345, 34);
            this.txtCustomerName.TabIndex = 14;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMoney.BackColor = System.Drawing.Color.White;
            this.txtTotalMoney.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMoney.Location = new System.Drawing.Point(944, 720);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(319, 45);
            this.txtTotalMoney.TabIndex = 21;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(937, 43);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 19);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Tên";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AllowDrop = true;
            this.dgvListProduct.AllowUserToAddRows = false;
            this.dgvListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvListProduct.ColumnHeadersHeight = 70;
            this.dgvListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Colum2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListProduct.GridColor = System.Drawing.Color.Green;
            this.dgvListProduct.Location = new System.Drawing.Point(941, 219);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.RowHeadersWidth = 62;
            this.dgvListProduct.RowTemplate.Height = 30;
            this.dgvListProduct.Size = new System.Drawing.Size(766, 447);
            this.dgvListProduct.TabIndex = 9;
            this.dgvListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProduct_CellClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.FillWeight = 35.32738F;
            this.Number.HeaderText = "STT";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Colum2
            // 
            this.Colum2.FillWeight = 140.1742F;
            this.Colum2.HeaderText = "Tên sản phẩm";
            this.Colum2.MinimumWidth = 8;
            this.Colum2.Name = "Colum2";
            this.Colum2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 45.1742F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 58.1742F;
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 100.1742F;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(937, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thông tin khách hàng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.Location = new System.Drawing.Point(1296, 117);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 30);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.Text = "Đơn giá";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(940, 691);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tổng tiền";
            // 
            // add10
            // 
            this.add10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add10.BackColor = System.Drawing.SystemColors.Control;
            this.add10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add10.FlatAppearance.BorderSize = 0;
            this.add10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add10.Location = new System.Drawing.Point(1312, 163);
            this.add10.Margin = new System.Windows.Forms.Padding(0);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(96, 30);
            this.add10.TabIndex = 16;
            this.add10.Text = "+10";
            this.add10.UseVisualStyleBackColor = false;
            this.add10.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_sellProduct
            // 
            this.dgv_sellProduct.AllowDrop = true;
            this.dgv_sellProduct.AllowUserToAddRows = false;
            this.dgv_sellProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sellProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sellProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_sellProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_sellProduct.ColumnHeadersHeight = 60;
            this.dgv_sellProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.dataGridViewTextBoxColumn4,
            this.nhasx,
            this.loai,
            this.GiaBan,
            this.tonkho});
            this.dgv_sellProduct.Location = new System.Drawing.Point(18, 219);
            this.dgv_sellProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sellProduct.Name = "dgv_sellProduct";
            this.dgv_sellProduct.ReadOnly = true;
            this.dgv_sellProduct.RowHeadersWidth = 51;
            this.dgv_sellProduct.RowTemplate.Height = 70;
            this.dgv_sellProduct.RowTemplate.ReadOnly = true;
            this.dgv_sellProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sellProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sellProduct.Size = new System.Drawing.Size(907, 583);
            this.dgv_sellProduct.TabIndex = 25;
            this.dgv_sellProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sellProduct_CellClick);
            this.dgv_sellProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sellProduct_CellContentClick);
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masp.DataPropertyName = "masp";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masp.DefaultCellStyle = dataGridViewCellStyle1;
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tensp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nhasx
            // 
            this.nhasx.DataPropertyName = "nhasx";
            this.nhasx.HeaderText = "Nhà sản xuất";
            this.nhasx.MinimumWidth = 6;
            this.nhasx.Name = "nhasx";
            this.nhasx.ReadOnly = true;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "giaban";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // tonkho
            // 
            this.tonkho.DataPropertyName = "soluong";
            this.tonkho.HeaderText = "Trong kho";
            this.tonkho.MinimumWidth = 6;
            this.tonkho.Name = "tonkho";
            this.tonkho.ReadOnly = true;
            // 
            // sub10
            // 
            this.sub10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sub10.BackColor = System.Drawing.SystemColors.Control;
            this.sub10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub10.FlatAppearance.BorderSize = 0;
            this.sub10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub10.Location = new System.Drawing.Point(1035, 162);
            this.sub10.Margin = new System.Windows.Forms.Padding(0);
            this.sub10.Name = "sub10";
            this.sub10.Size = new System.Drawing.Size(92, 31);
            this.sub10.TabIndex = 15;
            this.sub10.Text = "-10";
            this.sub10.UseVisualStyleBackColor = false;
            this.sub10.Click += new System.EventHandler(this.button2_Click);
            // 
            // iconbtnSell
            // 
            this.iconbtnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnSell.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnSell.FlatAppearance.BorderSize = 2;
            this.iconbtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnSell.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnSell.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnSell.ForeColor = System.Drawing.Color.White;
            this.iconbtnSell.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnSell.IconColor = System.Drawing.Color.White;
            this.iconbtnSell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnSell.IconSize = 40;
            this.iconbtnSell.Location = new System.Drawing.Point(1285, 720);
            this.iconbtnSell.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnSell.Name = "iconbtnSell";
            this.iconbtnSell.Rotation = 0D;
            this.iconbtnSell.Size = new System.Drawing.Size(224, 45);
            this.iconbtnSell.TabIndex = 20;
            this.iconbtnSell.Text = "Thanh toán";
            this.iconbtnSell.UseCompatibleTextRendering = true;
            this.iconbtnSell.UseVisualStyleBackColor = true;
            this.iconbtnSell.Click += new System.EventHandler(this.iconbtnImport_Click);
            // 
            // add100
            // 
            this.add100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add100.BackColor = System.Drawing.SystemColors.Control;
            this.add100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add100.FlatAppearance.BorderSize = 0;
            this.add100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add100.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add100.Location = new System.Drawing.Point(1413, 163);
            this.add100.Margin = new System.Windows.Forms.Padding(0);
            this.add100.Name = "add100";
            this.add100.Size = new System.Drawing.Size(96, 30);
            this.add100.TabIndex = 14;
            this.add100.Text = "+100";
            this.add100.UseVisualStyleBackColor = false;
            this.add100.Click += new System.EventHandler(this.button1_Click);
            // 
            // sub100
            // 
            this.sub100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sub100.BackColor = System.Drawing.SystemColors.Control;
            this.sub100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub100.FlatAppearance.BorderSize = 0;
            this.sub100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub100.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub100.Location = new System.Drawing.Point(940, 162);
            this.sub100.Margin = new System.Windows.Forms.Padding(0);
            this.sub100.Name = "sub100";
            this.sub100.Size = new System.Drawing.Size(91, 31);
            this.sub100.TabIndex = 13;
            this.sub100.Text = "-100";
            this.sub100.UseVisualStyleBackColor = false;
            this.sub100.Click += new System.EventHandler(this.btnS100_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmount.BackColor = System.Drawing.Color.White;
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudAmount.Location = new System.Drawing.Point(1131, 163);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(177, 30);
            this.nudAmount.TabIndex = 11;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtName.Location = new System.Drawing.Point(1002, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(284, 30);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Tên sản phẩm";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // iconbtnAddProduct
            // 
            this.iconbtnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.FlatAppearance.BorderSize = 2;
            this.iconbtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnAddProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAddProduct.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAddProduct.IconColor = System.Drawing.Color.Black;
            this.iconbtnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnAddProduct.IconSize = 40;
            this.iconbtnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnAddProduct.Location = new System.Drawing.Point(1517, 117);
            this.iconbtnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAddProduct.Name = "iconbtnAddProduct";
            this.iconbtnAddProduct.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconbtnAddProduct.Rotation = 0D;
            this.iconbtnAddProduct.Size = new System.Drawing.Size(190, 76);
            this.iconbtnAddProduct.TabIndex = 0;
            this.iconbtnAddProduct.Text = "Thêm";
            this.iconbtnAddProduct.UseCompatibleTextRendering = true;
            this.iconbtnAddProduct.UseVisualStyleBackColor = true;
            this.iconbtnAddProduct.Click += new System.EventHandler(this.iconbtnAddProduct_Click);
            // 
            // printInvoiceReportBtn
            // 
            this.printInvoiceReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printInvoiceReportBtn.AutoSize = true;
            this.printInvoiceReportBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.printInvoiceReportBtn.Location = new System.Drawing.Point(1580, 28);
            this.printInvoiceReportBtn.Name = "printInvoiceReportBtn";
            this.printInvoiceReportBtn.Size = new System.Drawing.Size(128, 36);
            this.printInvoiceReportBtn.TabIndex = 9;
            this.printInvoiceReportBtn.Text = "In báo cáo";
            this.printInvoiceReportBtn.UseVisualStyleBackColor = true;
            this.printInvoiceReportBtn.Click += new System.EventHandler(this.printInvoiceReportBtn_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 859);
            this.Controls.Add(this.tcImportGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellProduct";
            this.Text = "SellProduct";
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.tcImportGoods.ResumeLayout(false);
            this.tabSellProduct.ResumeLayout(false);
            this.tabSellProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dtbTime;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.TabControl tcImportGoods;
        private System.Windows.Forms.TabPage tabSellProduct;
        private FontAwesome.Sharp.IconButton iconbtnSell;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.Button sub10;
        private System.Windows.Forms.Button add100;
        private System.Windows.Forms.Button sub100;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconbtnAddProduct;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.DataGridView dgv_sellProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button printInvoiceReportBtn;
    }
}