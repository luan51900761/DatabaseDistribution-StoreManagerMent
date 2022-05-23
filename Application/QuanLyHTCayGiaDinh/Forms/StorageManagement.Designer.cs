namespace QuanLyBanHoa
{
    partial class StorageManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.iconbtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.lblNSX = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMakho = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridViewListProduct = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListProduct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.txtChiNhanh);
            this.panelLeft.Controls.Add(this.iconbtnAdd);
            this.panelLeft.Controls.Add(this.lblBid);
            this.panelLeft.Controls.Add(this.iconbtnReset);
            this.panelLeft.Controls.Add(this.txtTenKho);
            this.panelLeft.Controls.Add(this.iconbtnDelete);
            this.panelLeft.Controls.Add(this.lblNSX);
            this.panelLeft.Controls.Add(this.lblprice);
            this.panelLeft.Controls.Add(this.iconbtnUpdate);
            this.panelLeft.Controls.Add(this.txtDiaChi);
            this.panelLeft.Controls.Add(this.txtMakho);
            this.panelLeft.Controls.Add(this.dataGridViewListProduct);
            this.panelLeft.Controls.Add(this.lblName);
            this.panelLeft.Controls.Add(this.labelListProduct);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1493, 788);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint_1);
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnReset.AutoSize = true;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 48;
            this.iconbtnReset.Location = new System.Drawing.Point(927, 344);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(227, 69);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(140, 58);
            this.iconbtnReset.TabIndex = 11;
            this.iconbtnReset.Text = "Clear";
            this.iconbtnReset.UseVisualStyleBackColor = true;
            this.iconbtnReset.Click += new System.EventHandler(this.iconbtnReset_Click);
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
            this.iconbtnUpdate.Location = new System.Drawing.Point(1249, 344);
            this.iconbtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnUpdate.MaximumSize = new System.Drawing.Size(233, 69);
            this.iconbtnUpdate.Name = "iconbtnUpdate";
            this.iconbtnUpdate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnUpdate.Rotation = 0D;
            this.iconbtnUpdate.Size = new System.Drawing.Size(191, 56);
            this.iconbtnUpdate.TabIndex = 12;
            this.iconbtnUpdate.Text = "Cập nhật";
            this.iconbtnUpdate.UseVisualStyleBackColor = true;
            this.iconbtnUpdate.Click += new System.EventHandler(this.iconbtnUpdate_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.Black;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 48;
            this.iconbtnAdd.Location = new System.Drawing.Point(927, 423);
            this.iconbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(513, 63);
            this.iconbtnAdd.TabIndex = 14;
            this.iconbtnAdd.Text = "Thêm Kho";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
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
            this.iconbtnDelete.Location = new System.Drawing.Point(1075, 344);
            this.iconbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnDelete.MaximumSize = new System.Drawing.Size(227, 69);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnDelete.Rotation = 0D;
            this.iconbtnDelete.Size = new System.Drawing.Size(166, 58);
            this.iconbtnDelete.TabIndex = 13;
            this.iconbtnDelete.Text = "Xóa kho";
            this.iconbtnDelete.UseVisualStyleBackColor = true;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanh.FormattingEnabled = true;
            this.txtChiNhanh.Location = new System.Drawing.Point(927, 282);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(513, 33);
            this.txtChiNhanh.TabIndex = 14;
            // 
            // lblBid
            // 
            this.lblBid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.ForeColor = System.Drawing.Color.White;
            this.lblBid.Location = new System.Drawing.Point(923, 133);
            this.lblBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(78, 22);
            this.lblBid.TabIndex = 11;
            this.lblBid.Text = "Tên kho";
            // 
            // txtTenKho
            // 
            this.txtTenKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKho.Location = new System.Drawing.Point(927, 159);
            this.txtTenKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKho.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(513, 32);
            this.txtTenKho.TabIndex = 8;
            // 
            // lblNSX
            // 
            this.lblNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNSX.AutoSize = true;
            this.lblNSX.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSX.ForeColor = System.Drawing.Color.White;
            this.lblNSX.Location = new System.Drawing.Point(923, 195);
            this.lblNSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNSX.Name = "lblNSX";
            this.lblNSX.Size = new System.Drawing.Size(67, 22);
            this.lblNSX.TabIndex = 13;
            this.lblNSX.Text = "Địa chỉ";
            // 
            // lblprice
            // 
            this.lblprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.White;
            this.lblprice.Location = new System.Drawing.Point(923, 257);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(93, 22);
            this.lblprice.TabIndex = 9;
            this.lblprice.Text = "Chi nhánh";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(927, 221);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MaximumSize = new System.Drawing.Size(532, 35);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(513, 32);
            this.txtDiaChi.TabIndex = 10;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtMakho
            // 
            this.txtMakho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMakho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakho.Location = new System.Drawing.Point(927, 97);
            this.txtMakho.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakho.MaximumSize = new System.Drawing.Size(839, 35);
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(513, 32);
            this.txtMakho.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(923, 71);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Mã kho";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListProduct.ColumnHeadersHeight = 60;
            this.dataGridViewListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loai,
            this.nhasx});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListProduct.Location = new System.Drawing.Point(16, 70);
            this.dataGridViewListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListProduct.Name = "dataGridViewListProduct";
            this.dataGridViewListProduct.ReadOnly = true;
            this.dataGridViewListProduct.RowHeadersWidth = 51;
            this.dataGridViewListProduct.RowTemplate.Height = 70;
            this.dataGridViewListProduct.RowTemplate.ReadOnly = true;
            this.dataGridViewListProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListProduct.Size = new System.Drawing.Size(866, 708);
            this.dataGridViewListProduct.TabIndex = 24;
            this.dataGridViewListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellClick);
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masp.DataPropertyName = "makho";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masp.DefaultCellStyle = dataGridViewCellStyle2;
            this.masp.HeaderText = "Mã kho";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 85;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tenkho";
            this.tensp.HeaderText = "Tên kho";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "diachi";
            this.loai.HeaderText = "Địa chỉ";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            // 
            // nhasx
            // 
            this.nhasx.DataPropertyName = "macn";
            this.nhasx.HeaderText = "Chi nhánh";
            this.nhasx.MinimumWidth = 6;
            this.nhasx.Name = "nhasx";
            this.nhasx.ReadOnly = true;
            // 
            // labelListProduct
            // 
            this.labelListProduct.AutoSize = true;
            this.labelListProduct.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProduct.ForeColor = System.Drawing.Color.White;
            this.labelListProduct.Location = new System.Drawing.Point(13, 9);
            this.labelListProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProduct.Name = "labelListProduct";
            this.labelListProduct.Size = new System.Drawing.Size(210, 30);
            this.labelListProduct.TabIndex = 23;
            this.labelListProduct.Text = "DANH MỤC KHO";
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
            // StorageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorageManagement";
            this.Text = "StoreManagement";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblprice;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private FontAwesome.Sharp.IconButton iconbtnUpdate;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.DataGridView dataGridViewListProduct;
        private System.Windows.Forms.Label labelListProduct;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtTenKho;
        private System.Windows.Forms.Label lblNSX;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMakho;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox txtChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
    }
}