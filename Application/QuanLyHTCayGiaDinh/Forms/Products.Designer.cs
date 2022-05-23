namespace QuanLyBanHoa
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelTypeProductName = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.iconbtnClear = new FontAwesome.Sharp.IconButton();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewListProduct = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListProduct = new System.Windows.Forms.Label();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNSX = new System.Windows.Forms.Label();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.iconbtnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtTypeProductName = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.txtTypeProductName);
            this.panelLeft.Controls.Add(this.iconbtnAdd);
            this.panelLeft.Controls.Add(this.lblMaHH);
            this.panelLeft.Controls.Add(this.picture);
            this.panelLeft.Controls.Add(this.iconbtnDelete);
            this.panelLeft.Controls.Add(this.txtID);
            this.panelLeft.Controls.Add(this.txtNCC);
            this.panelLeft.Controls.Add(this.labelTypeProductName);
            this.panelLeft.Controls.Add(this.lblBid);
            this.panelLeft.Controls.Add(this.lblName);
            this.panelLeft.Controls.Add(this.iconbtnClear);
            this.panelLeft.Controls.Add(this.txtName);
            this.panelLeft.Controls.Add(this.txtIDProduct);
            this.panelLeft.Controls.Add(this.iconbtnUpdate);
            this.panelLeft.Controls.Add(this.dataGridViewListProduct);
            this.panelLeft.Controls.Add(this.txtNSX);
            this.panelLeft.Controls.Add(this.txtPrice);
            this.panelLeft.Controls.Add(this.labelListProduct);
            this.panelLeft.Controls.Add(this.lblprice);
            this.panelLeft.Controls.Add(this.iconBtnSearch);
            this.panelLeft.Controls.Add(this.iconbtnReset);
            this.panelLeft.Controls.Add(this.txtNameProduct);
            this.panelLeft.Controls.Add(this.lblNSX);
            this.panelLeft.Controls.Add(this.labelSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1920, 1080);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint_1);
            // 
            // lblMaHH
            // 
            this.lblMaHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHH.ForeColor = System.Drawing.Color.White;
            this.lblMaHH.Location = new System.Drawing.Point(1662, 63);
            this.lblMaHH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(122, 22);
            this.lblMaHH.TabIndex = 1;
            this.lblMaHH.Text = "Mã sản phẩm";
            this.lblMaHH.Click += new System.EventHandler(this.lblMaHH_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(1666, 89);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(214, 32);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // labelTypeProductName
            // 
            this.labelTypeProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeProductName.AutoSize = true;
            this.labelTypeProductName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeProductName.ForeColor = System.Drawing.Color.White;
            this.labelTypeProductName.Location = new System.Drawing.Point(1662, 164);
            this.labelTypeProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeProductName.Name = "labelTypeProductName";
            this.labelTypeProductName.Size = new System.Drawing.Size(164, 22);
            this.labelTypeProductName.TabIndex = 7;
            this.labelTypeProductName.Text = "Tên loại sản phẩm";
            this.labelTypeProductName.Click += new System.EventHandler(this.labelTypeProductName_Click);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.ErrorImage = global::QuanLyBanHoa.Properties.Resources.laptop_screen;
            this.picture.InitialImage = global::QuanLyBanHoa.Properties.Resources.laptop;
            this.picture.Location = new System.Drawing.Point(1362, 28);
            this.picture.Margin = new System.Windows.Forms.Padding(4);
            this.picture.MaximumSize = new System.Drawing.Size(400, 332);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(253, 242);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconbtnClear
            // 
            this.iconbtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconbtnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconbtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnClear.IconColor = System.Drawing.Color.Black;
            this.iconbtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnClear.IconSize = 30;
            this.iconbtnClear.Location = new System.Drawing.Point(620, 67);
            this.iconbtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnClear.MaximumSize = new System.Drawing.Size(206, 92);
            this.iconbtnClear.Name = "iconbtnClear";
            this.iconbtnClear.Rotation = 0D;
            this.iconbtnClear.Size = new System.Drawing.Size(158, 81);
            this.iconbtnClear.TabIndex = 19;
            this.iconbtnClear.Text = "Làm Mới";
            this.iconbtnClear.UseVisualStyleBackColor = true;
            this.iconbtnClear.Click += new System.EventHandler(this.iconbtnClear_Click_1);
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.AllowDrop = true;
            this.txtIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProduct.ForeColor = System.Drawing.Color.LightGray;
            this.txtIDProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtIDProduct.Location = new System.Drawing.Point(9, 67);
            this.txtIDProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProduct.MaximumSize = new System.Drawing.Size(732, 30);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(397, 30);
            this.txtIDProduct.TabIndex = 16;
            this.txtIDProduct.Text = "Mã sản phẩm";
            this.txtIDProduct.WordWrap = false;
            this.txtIDProduct.TextChanged += new System.EventHandler(this.txtIDProduct_TextChanged_1);
            this.txtIDProduct.Enter += new System.EventHandler(this.txtIDProduct_Enter);
            // 
            // dataGridViewListProduct
            // 
            this.dataGridViewListProduct.AllowDrop = true;
            this.dataGridViewListProduct.AllowUserToAddRows = false;
            this.dataGridViewListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListProduct.ColumnHeadersHeight = 60;
            this.dataGridViewListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.nhasx,
            this.loai,
            this.GiaBan,
            this.nhacc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewListProduct.Location = new System.Drawing.Point(9, 218);
            this.dataGridViewListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListProduct.Name = "dataGridViewListProduct";
            this.dataGridViewListProduct.ReadOnly = true;
            this.dataGridViewListProduct.RowHeadersWidth = 51;
            this.dataGridViewListProduct.RowTemplate.Height = 70;
            this.dataGridViewListProduct.RowTemplate.ReadOnly = true;
            this.dataGridViewListProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListProduct.Size = new System.Drawing.Size(1326, 859);
            this.dataGridViewListProduct.TabIndex = 24;
            this.dataGridViewListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellClick);
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masp.DataPropertyName = "masp";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masp.DefaultCellStyle = dataGridViewCellStyle5;
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 62;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên SP";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
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
            // nhacc
            // 
            this.nhacc.DataPropertyName = "nhacc";
            this.nhacc.HeaderText = "Nhà cung cấp";
            this.nhacc.MinimumWidth = 6;
            this.nhacc.Name = "nhacc";
            this.nhacc.ReadOnly = true;
            // 
            // labelListProduct
            // 
            this.labelListProduct.AutoSize = true;
            this.labelListProduct.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProduct.ForeColor = System.Drawing.Color.White;
            this.labelListProduct.Location = new System.Drawing.Point(4, 184);
            this.labelListProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProduct.Name = "labelListProduct";
            this.labelListProduct.Size = new System.Drawing.Size(287, 30);
            this.labelListProduct.TabIndex = 23;
            this.labelListProduct.Text = "DANH MỤC SẢN PHẨM";
            // 
            // iconBtnSearch
            // 
            this.iconBtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconBtnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconBtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconBtnSearch.ForeColor = System.Drawing.Color.Black;
            this.iconBtnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnSearch.IconColor = System.Drawing.Color.Black;
            this.iconBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearch.IconSize = 30;
            this.iconBtnSearch.Location = new System.Drawing.Point(434, 67);
            this.iconBtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnSearch.MaximumSize = new System.Drawing.Size(206, 92);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(159, 81);
            this.iconBtnSearch.TabIndex = 18;
            this.iconBtnSearch.Text = "Tìm Kiếm";
            this.iconBtnSearch.UseVisualStyleBackColor = true;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.AllowDrop = true;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNameProduct.Location = new System.Drawing.Point(9, 118);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameProduct.MaximumSize = new System.Drawing.Size(732, 30);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(397, 30);
            this.txtNameProduct.TabIndex = 17;
            this.txtNameProduct.Text = "Tên sản phẩm";
            this.txtNameProduct.TextChanged += new System.EventHandler(this.txtNameProduct_TextChanged_1);
            this.txtNameProduct.Enter += new System.EventHandler(this.txtNameProduct_Enter);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(4, 14);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(265, 30);
            this.labelSearch.TabIndex = 22;
            this.labelSearch.Text = "TRA CỨU SẢN PHẨM";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1910, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MaximumSize = new System.Drawing.Size(1213, 1477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 1080);
            this.panel3.TabIndex = 11;
            // 
            // lblNSX
            // 
            this.lblNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNSX.AutoSize = true;
            this.lblNSX.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSX.ForeColor = System.Drawing.Color.White;
            this.lblNSX.Location = new System.Drawing.Point(1358, 435);
            this.lblNSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNSX.Name = "lblNSX";
            this.lblNSX.Size = new System.Drawing.Size(117, 22);
            this.lblNSX.TabIndex = 13;
            this.lblNSX.Text = "Nhà sản xuất";
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnReset.AutoSize = true;
            this.iconbtnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 48;
            this.iconbtnReset.Location = new System.Drawing.Point(1785, 274);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(227, 69);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(95, 41);
            this.iconbtnReset.TabIndex = 11;
            this.iconbtnReset.Text = "Clear";
            this.iconbtnReset.UseVisualStyleBackColor = true;
            this.iconbtnReset.Click += new System.EventHandler(this.iconbtnReset_Click);
            // 
            // lblprice
            // 
            this.lblprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.White;
            this.lblprice.Location = new System.Drawing.Point(1358, 497);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(75, 22);
            this.lblprice.TabIndex = 9;
            this.lblprice.Text = "Giá bán";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1362, 523);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaximumSize = new System.Drawing.Size(839, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(518, 32);
            this.txtPrice.TabIndex = 9;
            // 
            // txtNSX
            // 
            this.txtNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSX.Location = new System.Drawing.Point(1362, 461);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNSX.MaximumSize = new System.Drawing.Size(839, 35);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(518, 32);
            this.txtNSX.TabIndex = 10;
            this.txtNSX.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // iconbtnUpdate
            // 
            this.iconbtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnUpdate.AutoSize = true;
            this.iconbtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnUpdate.IconColor = System.Drawing.Color.Black;
            this.iconbtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnUpdate.IconSize = 48;
            this.iconbtnUpdate.Location = new System.Drawing.Point(1518, 574);
            this.iconbtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnUpdate.MaximumSize = new System.Drawing.Size(233, 69);
            this.iconbtnUpdate.Name = "iconbtnUpdate";
            this.iconbtnUpdate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnUpdate.Rotation = 0D;
            this.iconbtnUpdate.Size = new System.Drawing.Size(169, 56);
            this.iconbtnUpdate.TabIndex = 12;
            this.iconbtnUpdate.Text = "Cập nhật";
            this.iconbtnUpdate.UseVisualStyleBackColor = true;
            this.iconbtnUpdate.Click += new System.EventHandler(this.iconbtnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1362, 338);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaximumSize = new System.Drawing.Size(839, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(518, 32);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1358, 312);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên mặt hàng";
            // 
            // lblBid
            // 
            this.lblBid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.ForeColor = System.Drawing.Color.White;
            this.lblBid.Location = new System.Drawing.Point(1358, 373);
            this.lblBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(125, 22);
            this.lblBid.TabIndex = 11;
            this.lblBid.Text = "Nhà cung cấp";
            this.lblBid.Click += new System.EventHandler(this.lblBid_Click);
            // 
            // txtNCC
            // 
            this.txtNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCC.Location = new System.Drawing.Point(1362, 399);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNCC.MaximumSize = new System.Drawing.Size(839, 35);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(518, 32);
            this.txtNCC.TabIndex = 8;
            // 
            // iconbtnDelete
            // 
            this.iconbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnDelete.AutoSize = true;
            this.iconbtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnDelete.IconColor = System.Drawing.Color.Black;
            this.iconbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnDelete.IconSize = 48;
            this.iconbtnDelete.Location = new System.Drawing.Point(1362, 574);
            this.iconbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnDelete.MaximumSize = new System.Drawing.Size(227, 69);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnDelete.Rotation = 0D;
            this.iconbtnDelete.Size = new System.Drawing.Size(148, 56);
            this.iconbtnDelete.TabIndex = 13;
            this.iconbtnDelete.Text = "Xóa";
            this.iconbtnDelete.UseVisualStyleBackColor = true;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnAdd.AutoSize = true;
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.Black;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 48;
            this.iconbtnAdd.Location = new System.Drawing.Point(1695, 574);
            this.iconbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(185, 56);
            this.iconbtnAdd.TabIndex = 14;
            this.iconbtnAdd.Text = "Thêm";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // txtTypeProductName
            // 
            this.txtTypeProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeProductName.Location = new System.Drawing.Point(1666, 190);
            this.txtTypeProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeProductName.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtTypeProductName.Name = "txtTypeProductName";
            this.txtTypeProductName.Size = new System.Drawing.Size(214, 32);
            this.txtTypeProductName.TabIndex = 6;
            this.txtTypeProductName.TextChanged += new System.EventHandler(this.txtTypeProductName_TextChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.Text = "Products";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTypeProductName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.PictureBox picture;
        private FontAwesome.Sharp.IconButton iconbtnClear;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.DataGridView dataGridViewListProduct;
        private System.Windows.Forms.Label labelListProduct;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacc;
        private System.Windows.Forms.TextBox txtTypeProductName;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconbtnUpdate;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblprice;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.Label lblNSX;
    }
}