namespace QuanLyBanHoa
{
    partial class ProvidersManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelListProduct = new System.Windows.Forms.Label();
            this.dataGridViewListProduct = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelTypeProviderName = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconbtnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1480, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MaximumSize = new System.Drawing.Size(1213, 1477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 788);
            this.panel3.TabIndex = 11;
            // 
            // labelListProduct
            // 
            this.labelListProduct.AutoSize = true;
            this.labelListProduct.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProduct.ForeColor = System.Drawing.Color.White;
            this.labelListProduct.Location = new System.Drawing.Point(13, 19);
            this.labelListProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProduct.Name = "labelListProduct";
            this.labelListProduct.Size = new System.Drawing.Size(348, 30);
            this.labelListProduct.TabIndex = 23;
            this.labelListProduct.Text = "DANH MỤC NHÀ CUNG CẤP";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewListProduct.ColumnHeadersHeight = 60;
            this.dataGridViewListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.nhasx,
            this.loai,
            this.GiaBan});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListProduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewListProduct.Location = new System.Drawing.Point(16, 61);
            this.dataGridViewListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListProduct.Name = "dataGridViewListProduct";
            this.dataGridViewListProduct.ReadOnly = true;
            this.dataGridViewListProduct.RowHeadersWidth = 51;
            this.dataGridViewListProduct.RowTemplate.Height = 70;
            this.dataGridViewListProduct.RowTemplate.ReadOnly = true;
            this.dataGridViewListProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListProduct.Size = new System.Drawing.Size(892, 717);
            this.dataGridViewListProduct.TabIndex = 24;
            this.dataGridViewListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellClick);
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masp.DataPropertyName = "mancc";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masp.DefaultCellStyle = dataGridViewCellStyle8;
            this.masp.HeaderText = "Mã nhà cung cấp";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 128;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tenncc";
            this.tensp.HeaderText = "Tên nhà cung cấp";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // nhasx
            // 
            this.nhasx.DataPropertyName = "diachi";
            this.nhasx.HeaderText = "Địa chỉ";
            this.nhasx.MinimumWidth = 6;
            this.nhasx.Name = "nhasx";
            this.nhasx.ReadOnly = true;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "sdt";
            this.loai.HeaderText = "SĐT";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "email";
            this.GiaBan.HeaderText = "Email";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnAdd.AutoSize = true;
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.Black;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 48;
            this.iconbtnAdd.Location = new System.Drawing.Point(940, 514);
            this.iconbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAdd.MaximumSize = new System.Drawing.Size(539, 56);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(532, 56);
            this.iconbtnAdd.TabIndex = 14;
            this.iconbtnAdd.Text = "Thêm sản nhà cung cấp";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.txtEmail);
            this.panelLeft.Controls.Add(this.iconbtnUpdate);
            this.panelLeft.Controls.Add(this.iconbtnAdd);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.dataGridViewListProduct);
            this.panelLeft.Controls.Add(this.iconbtnReset);
            this.panelLeft.Controls.Add(this.labelListProduct);
            this.panelLeft.Controls.Add(this.txtSDT);
            this.panelLeft.Controls.Add(this.txtMaNCC);
            this.panelLeft.Controls.Add(this.iconbtnDelete);
            this.panelLeft.Controls.Add(this.labelTypeProviderName);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.lblMaNCC);
            this.panelLeft.Controls.Add(this.txtDiaChi);
            this.panelLeft.Controls.Add(this.txtTenNCC);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1493, 788);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint_1);
            // 
            // labelTypeProviderName
            // 
            this.labelTypeProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeProviderName.AutoSize = true;
            this.labelTypeProviderName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeProviderName.ForeColor = System.Drawing.Color.White;
            this.labelTypeProviderName.Location = new System.Drawing.Point(936, 135);
            this.labelTypeProviderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeProviderName.Name = "labelTypeProviderName";
            this.labelTypeProviderName.Size = new System.Drawing.Size(160, 22);
            this.labelTypeProviderName.TabIndex = 7;
            this.labelTypeProviderName.Text = "Tên nhà cung cấp";
            this.labelTypeProviderName.Click += new System.EventHandler(this.labelTypeProviderName_Click);
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.Color.White;
            this.lblMaNCC.Location = new System.Drawing.Point(936, 62);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(152, 22);
            this.lblMaNCC.TabIndex = 1;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            this.lblMaNCC.Click += new System.EventHandler(this.lblMaNCC_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(940, 163);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(532, 32);
            this.txtTenNCC.TabIndex = 6;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.txtTenNCC_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(936, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Địa chỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(940, 90);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(532, 32);
            this.txtMaNCC.TabIndex = 4;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(940, 234);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(532, 32);
            this.txtDiaChi.TabIndex = 10;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(936, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "SĐT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconbtnDelete
            // 
            this.iconbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnDelete.AutoSize = true;
            this.iconbtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnDelete.IconColor = System.Drawing.Color.Black;
            this.iconbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnDelete.IconSize = 48;
            this.iconbtnDelete.Location = new System.Drawing.Point(1276, 450);
            this.iconbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnDelete.MaximumSize = new System.Drawing.Size(202, 56);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnDelete.Rotation = 0D;
            this.iconbtnDelete.Size = new System.Drawing.Size(196, 56);
            this.iconbtnDelete.TabIndex = 13;
            this.iconbtnDelete.Text = "Xóa mặt hàng";
            this.iconbtnDelete.UseVisualStyleBackColor = true;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(940, 305);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(532, 32);
            this.txtSDT.TabIndex = 12;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnReset.AutoSize = true;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 48;
            this.iconbtnReset.Location = new System.Drawing.Point(940, 450);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(148, 56);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(148, 56);
            this.iconbtnReset.TabIndex = 11;
            this.iconbtnReset.Text = "Clear";
            this.iconbtnReset.UseVisualStyleBackColor = true;
            this.iconbtnReset.Click += new System.EventHandler(this.iconbtnReset_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(936, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iconbtnUpdate
            // 
            this.iconbtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnUpdate.AutoSize = true;
            this.iconbtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnUpdate.IconColor = System.Drawing.Color.Black;
            this.iconbtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnUpdate.IconSize = 48;
            this.iconbtnUpdate.Location = new System.Drawing.Point(1096, 450);
            this.iconbtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnUpdate.MaximumSize = new System.Drawing.Size(172, 56);
            this.iconbtnUpdate.Name = "iconbtnUpdate";
            this.iconbtnUpdate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnUpdate.Rotation = 0D;
            this.iconbtnUpdate.Size = new System.Drawing.Size(172, 56);
            this.iconbtnUpdate.TabIndex = 12;
            this.iconbtnUpdate.Text = "Cập nhật";
            this.iconbtnUpdate.UseVisualStyleBackColor = true;
            this.iconbtnUpdate.Click += new System.EventHandler(this.iconbtnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(940, 377);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(532, 32);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // ProvidersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProvidersManagement";
            this.Text = "ProvidersManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelListProduct;
        private System.Windows.Forms.DataGridView dataGridViewListProduct;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton iconbtnUpdate;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaNCC;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private System.Windows.Forms.Label labelTypeProviderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label1;
    }
}