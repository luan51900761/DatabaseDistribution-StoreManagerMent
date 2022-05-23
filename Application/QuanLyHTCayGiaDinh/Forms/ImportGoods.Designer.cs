namespace QuanLyBanHoa.Forms
{
    partial class ImportGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcImportGoods = new System.Windows.Forms.TabControl();
            this.tabImportGoods = new System.Windows.Forms.TabPage();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.dgv_sellProduct = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.add10 = new System.Windows.Forms.Button();
            this.sub10 = new System.Windows.Forms.Button();
            this.add100 = new System.Windows.Forms.Button();
            this.sub100 = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.iconbtnAddProduct = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnImport = new FontAwesome.Sharp.IconButton();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listVProduct = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gianhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.labelTime = new System.Windows.Forms.Label();
            this.dtbTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMakho = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.printInventoryBtn = new System.Windows.Forms.Button();
            this.tcImportGoods.SuspendLayout();
            this.tabImportGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellProduct)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcImportGoods
            // 
            this.tcImportGoods.Controls.Add(this.tabImportGoods);
            this.tcImportGoods.Controls.Add(this.tabHistory);
            this.tcImportGoods.Controls.Add(this.tabPage1);
            this.tcImportGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImportGoods.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcImportGoods.ItemSize = new System.Drawing.Size(120, 45);
            this.tcImportGoods.Location = new System.Drawing.Point(0, 0);
            this.tcImportGoods.Margin = new System.Windows.Forms.Padding(4);
            this.tcImportGoods.Name = "tcImportGoods";
            this.tcImportGoods.Padding = new System.Drawing.Point(20, 7);
            this.tcImportGoods.SelectedIndex = 0;
            this.tcImportGoods.Size = new System.Drawing.Size(1490, 821);
            this.tcImportGoods.TabIndex = 0;
            this.tcImportGoods.SelectedIndexChanged += new System.EventHandler(this.tcImportGoods_SelectedIndexChanged);
            // 
            // tabImportGoods
            // 
            this.tabImportGoods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabImportGoods.Controls.Add(this.iconbtnReset);
            this.tabImportGoods.Controls.Add(this.cbTypeProduct);
            this.tabImportGoods.Controls.Add(this.dgv_sellProduct);
            this.tabImportGoods.Controls.Add(this.label1);
            this.tabImportGoods.Controls.Add(this.tableLayoutPanel2);
            this.tabImportGoods.Controls.Add(this.label2);
            this.tabImportGoods.Controls.Add(this.txtProductName);
            this.tabImportGoods.Location = new System.Drawing.Point(4, 49);
            this.tabImportGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.tabImportGoods.Name = "tabImportGoods";
            this.tabImportGoods.Padding = new System.Windows.Forms.Padding(4);
            this.tabImportGoods.Size = new System.Drawing.Size(1482, 768);
            this.tabImportGoods.TabIndex = 0;
            this.tabImportGoods.Text = "Nhập hàng";
            this.tabImportGoods.Click += new System.EventHandler(this.tabImportGoods_Click);
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(179)))));
            this.iconbtnReset.FlatAppearance.BorderSize = 0;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.ForeColor = System.Drawing.Color.White;
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 40;
            this.iconbtnReset.Location = new System.Drawing.Point(8, 145);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(267, 59);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(164, 59);
            this.iconbtnReset.TabIndex = 15;
            this.iconbtnReset.Text = "Làm mới";
            this.iconbtnReset.UseVisualStyleBackColor = false;
            this.iconbtnReset.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.ForeColor = System.Drawing.Color.Black;
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Items.AddRange(new object[] {
            "Laptop",
            "Bàn Phím",
            "Tai Nghe",
            "Chuột"});
            this.cbTypeProduct.Location = new System.Drawing.Point(9, 104);
            this.cbTypeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeProduct.MaximumSize = new System.Drawing.Size(359, 0);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(355, 31);
            this.cbTypeProduct.TabIndex = 20;
            this.cbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cbTypeProduct_SelectedIndexChanged);
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
            this.dgv_sellProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sellProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.dataGridViewTextBoxColumn4,
            this.nhasx,
            this.loai,
            this.GiaBan,
            this.tonkho});
            this.dgv_sellProduct.Location = new System.Drawing.Point(9, 212);
            this.dgv_sellProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sellProduct.Name = "dgv_sellProduct";
            this.dgv_sellProduct.ReadOnly = true;
            this.dgv_sellProduct.RowHeadersWidth = 51;
            this.dgv_sellProduct.RowTemplate.Height = 70;
            this.dgv_sellProduct.RowTemplate.ReadOnly = true;
            this.dgv_sellProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sellProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sellProduct.Size = new System.Drawing.Size(758, 552);
            this.dgv_sellProduct.TabIndex = 26;
            this.dgv_sellProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sellProduct_CellClick);
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masp.DataPropertyName = "masp";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masp.DefaultCellStyle = dataGridViewCellStyle3;
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 99;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(777, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 742);
            this.tableLayoutPanel2.TabIndex = 21;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProduct.Controls.Add(this.txtID);
            this.panelProduct.Controls.Add(this.label7);
            this.panelProduct.Controls.Add(this.txtBID);
            this.panelProduct.Controls.Add(this.add10);
            this.panelProduct.Controls.Add(this.sub10);
            this.panelProduct.Controls.Add(this.add100);
            this.panelProduct.Controls.Add(this.sub100);
            this.panelProduct.Controls.Add(this.nudAmount);
            this.panelProduct.Controls.Add(this.txtName);
            this.panelProduct.Controls.Add(this.iconbtnAddProduct);
            this.panelProduct.Location = new System.Drawing.Point(4, 4);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(691, 96);
            this.panelProduct.TabIndex = 7;
            this.panelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProduct_Paint_1);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(-4, 7);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(65, 30);
            this.txtID.TabIndex = 19;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(508, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 18;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBID
            // 
            this.txtBID.BackColor = System.Drawing.Color.White;
            this.txtBID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBID.ForeColor = System.Drawing.Color.Black;
            this.txtBID.Location = new System.Drawing.Point(357, 7);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(172, 30);
            this.txtBID.TabIndex = 17;
            this.txtBID.Text = "Giá nhập";
            this.txtBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.Enter += new System.EventHandler(this.txtBID_Enter);
            this.txtBID.Leave += new System.EventHandler(this.txtBID_Leave);
            // 
            // add10
            // 
            this.add10.BackColor = System.Drawing.SystemColors.Control;
            this.add10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add10.FlatAppearance.BorderSize = 0;
            this.add10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add10.Location = new System.Drawing.Point(357, 55);
            this.add10.Margin = new System.Windows.Forms.Padding(0);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(72, 32);
            this.add10.TabIndex = 16;
            this.add10.Text = "+10";
            this.add10.UseVisualStyleBackColor = false;
            this.add10.Click += new System.EventHandler(this.button3_Click);
            // 
            // sub10
            // 
            this.sub10.BackColor = System.Drawing.SystemColors.Control;
            this.sub10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub10.FlatAppearance.BorderSize = 0;
            this.sub10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub10.Location = new System.Drawing.Point(99, 55);
            this.sub10.Margin = new System.Windows.Forms.Padding(0);
            this.sub10.Name = "sub10";
            this.sub10.Size = new System.Drawing.Size(66, 32);
            this.sub10.TabIndex = 15;
            this.sub10.Text = "-10";
            this.sub10.UseVisualStyleBackColor = false;
            this.sub10.Click += new System.EventHandler(this.button2_Click);
            // 
            // add100
            // 
            this.add100.BackColor = System.Drawing.SystemColors.Control;
            this.add100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add100.FlatAppearance.BorderSize = 0;
            this.add100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add100.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add100.Location = new System.Drawing.Point(437, 55);
            this.add100.Margin = new System.Windows.Forms.Padding(0);
            this.add100.Name = "add100";
            this.add100.Size = new System.Drawing.Size(94, 32);
            this.add100.TabIndex = 14;
            this.add100.Text = "+100";
            this.add100.UseVisualStyleBackColor = false;
            this.add100.Click += new System.EventHandler(this.button1_Click);
            // 
            // sub100
            // 
            this.sub100.BackColor = System.Drawing.SystemColors.Control;
            this.sub100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub100.FlatAppearance.BorderSize = 0;
            this.sub100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub100.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub100.Location = new System.Drawing.Point(0, 55);
            this.sub100.Margin = new System.Windows.Forms.Padding(0);
            this.sub100.Name = "sub100";
            this.sub100.Size = new System.Drawing.Size(92, 32);
            this.sub100.TabIndex = 13;
            this.sub100.Text = "-100";
            this.sub100.UseVisualStyleBackColor = false;
            this.sub100.Click += new System.EventHandler(this.btnS100_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.White;
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudAmount.Location = new System.Drawing.Point(172, 55);
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
            this.nudAmount.Size = new System.Drawing.Size(178, 32);
            this.nudAmount.TabIndex = 11;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudAmount.Enter += new System.EventHandler(this.nudAmount_Enter);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(68, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(282, 30);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Tên sản phẩm";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // iconbtnAddProduct
            // 
            this.iconbtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.FlatAppearance.BorderSize = 2;
            this.iconbtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnAddProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAddProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAddProduct.IconColor = System.Drawing.Color.Black;
            this.iconbtnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnAddProduct.IconSize = 40;
            this.iconbtnAddProduct.Location = new System.Drawing.Point(539, 7);
            this.iconbtnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAddProduct.Name = "iconbtnAddProduct";
            this.iconbtnAddProduct.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconbtnAddProduct.Rotation = 0D;
            this.iconbtnAddProduct.Size = new System.Drawing.Size(153, 80);
            this.iconbtnAddProduct.TabIndex = 0;
            this.iconbtnAddProduct.Text = "Thêm";
            this.iconbtnAddProduct.UseCompatibleTextRendering = true;
            this.iconbtnAddProduct.UseVisualStyleBackColor = true;
            this.iconbtnAddProduct.Click += new System.EventHandler(this.iconbtnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.iconbtnImport);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalMoney);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 635);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 103);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // iconbtnImport
            // 
            this.iconbtnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnImport.FlatAppearance.BorderSize = 2;
            this.iconbtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnImport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnImport.ForeColor = System.Drawing.Color.White;
            this.iconbtnImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnImport.IconColor = System.Drawing.Color.Black;
            this.iconbtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnImport.IconSize = 40;
            this.iconbtnImport.Location = new System.Drawing.Point(480, 11);
            this.iconbtnImport.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnImport.Name = "iconbtnImport";
            this.iconbtnImport.Rotation = 0D;
            this.iconbtnImport.Size = new System.Drawing.Size(206, 86);
            this.iconbtnImport.TabIndex = 20;
            this.iconbtnImport.Text = "Nhập hàng";
            this.iconbtnImport.UseCompatibleTextRendering = true;
            this.iconbtnImport.UseVisualStyleBackColor = true;
            this.iconbtnImport.Click += new System.EventHandler(this.iconbtnImport_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(190, 66);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(280, 31);
            this.cbSupplier.TabIndex = 10;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhà cung cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.BackColor = System.Drawing.Color.White;
            this.txtTotalMoney.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMoney.Location = new System.Drawing.Point(190, 11);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(280, 35);
            this.txtTotalMoney.TabIndex = 18;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalMoney.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.listVProduct);
            this.panel8.Location = new System.Drawing.Point(4, 111);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(691, 515);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // listVProduct
            // 
            this.listVProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVProduct.BackColor = System.Drawing.Color.White;
            this.listVProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Ten,
            this.SL,
            this.Gianhap,
            this.ThanhTien});
            this.listVProduct.FullRowSelect = true;
            this.listVProduct.GridLines = true;
            this.listVProduct.HideSelection = false;
            this.listVProduct.Location = new System.Drawing.Point(-2, 4);
            this.listVProduct.Margin = new System.Windows.Forms.Padding(4);
            this.listVProduct.Name = "listVProduct";
            this.listVProduct.Size = new System.Drawing.Size(693, 507);
            this.listVProduct.TabIndex = 0;
            this.listVProduct.UseCompatibleStateImageBehavior = false;
            this.listVProduct.View = System.Windows.Forms.View.Details;
            this.listVProduct.SelectedIndexChanged += new System.EventHandler(this.listVProduct_SelectedIndexChanged_1);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 53;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên sản phẩm";
            this.Ten.Width = 188;
            // 
            // SL
            // 
            this.SL.Text = "Số lượng";
            this.SL.Width = 96;
            // 
            // Gianhap
            // 
            this.Gianhap.Text = "Giá nhập";
            this.Gianhap.Width = 101;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(9, 38);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.MaximumSize = new System.Drawing.Size(399, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(355, 30);
            this.txtProductName.TabIndex = 17;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabHistory.Controls.Add(this.printInventoryBtn);
            this.tabHistory.Controls.Add(this.labelTime);
            this.tabHistory.Controls.Add(this.dtbTime);
            this.tabHistory.Controls.Add(this.dataGridViewHistory);
            this.tabHistory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabHistory.Location = new System.Drawing.Point(4, 49);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabHistory.Size = new System.Drawing.Size(1482, 768);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "Lịch sử nhập hàng";
            this.tabHistory.Click += new System.EventHandler(this.tabHistory_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(8, 35);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 22);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Thời gian";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // dtbTime
            // 
            this.dtbTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbTime.Location = new System.Drawing.Point(131, 31);
            this.dtbTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtbTime.Name = "dtbTime";
            this.dtbTime.Size = new System.Drawing.Size(212, 30);
            this.dtbTime.TabIndex = 1;
            this.dtbTime.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewHistory.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 62;
            this.dataGridViewHistory.RowTemplate.Height = 35;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(1482, 672);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellContentClick);
            this.dataGridViewHistory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHistory_ColumnHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mapn";
            this.Column1.HeaderText = "Mã PN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ngaynhap";
            this.Column2.HeaderText = "Ngày Nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "makho";
            this.Column3.HeaderText = "Mã kho";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mancc";
            this.Column4.HeaderText = "Mã NCC";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tong";
            this.Column5.HeaderText = "Tổng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tinhtrang";
            this.Column6.HeaderText = "Tình trạng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.iconButton2);
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Controls.Add(this.txtTong);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtMakho);
            this.tabPage1.Controls.Add(this.txtMaPN);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1482, 768);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Duyệt nhập hàng";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 2;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(673, 68);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(206, 70);
            this.iconButton2.TabIndex = 37;
            this.iconButton2.Text = "Duyệt nhập hàng";
            this.iconButton2.UseCompatibleTextRendering = true;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 48;
            this.iconButton1.Location = new System.Drawing.Point(1002, 108);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(8, 8);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(425, 108);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(153, 30);
            this.txtTong.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(421, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(214, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Mã kho";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã phiếu nhập";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMakho
            // 
            this.txtMakho.Location = new System.Drawing.Point(218, 108);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.ReadOnly = true;
            this.txtMakho.Size = new System.Drawing.Size(168, 30);
            this.txtMakho.TabIndex = 29;
            this.txtMakho.TextChanged += new System.EventHandler(this.txtMakho_TextChanged);
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(9, 108);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(168, 30);
            this.txtMaPN.TabIndex = 28;
            this.txtMaPN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1486, 618);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mapn";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu nhập";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 153;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "makho";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mancc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ngaynhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Nhập";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tinhtrang";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tình Trạng";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // printInventoryBtn
            // 
            this.printInventoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printInventoryBtn.AutoSize = true;
            this.printInventoryBtn.Location = new System.Drawing.Point(1348, 27);
            this.printInventoryBtn.Name = "printInventoryBtn";
            this.printInventoryBtn.Size = new System.Drawing.Size(127, 35);
            this.printInventoryBtn.TabIndex = 3;
            this.printInventoryBtn.Text = "In báo cáo";
            this.printInventoryBtn.UseVisualStyleBackColor = true;
            this.printInventoryBtn.Click += new System.EventHandler(this.printInventoryBtn_Click);
            // 
            // ImportGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 821);
            this.ControlBox = false;
            this.Controls.Add(this.tcImportGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportGoods";
            this.Text = "ImportGoods";
            this.TransparencyKey = System.Drawing.Color.White;
            this.tcImportGoods.ResumeLayout(false);
            this.tabImportGoods.ResumeLayout(false);
            this.tabImportGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellProduct)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcImportGoods;
        private System.Windows.Forms.TabPage tabImportGoods;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconbtnAddProduct;
        private System.Windows.Forms.Button sub10;
        private System.Windows.Forms.Button add100;
        private System.Windows.Forms.Button sub100;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconbtnImport;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListView listVProduct;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.ColumnHeader Gianhap;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dtbTime;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridView dgv_sellProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaPN;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMakho;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button printInventoryBtn;
    }
}