namespace QuanLyBanHoa.Forms
{
    partial class AddProduct
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
            this.labelName = new System.Windows.Forms.Label();
            this.lblTypeProduct = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(36, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Mã sản phẩm";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeProduct.Location = new System.Drawing.Point(37, 166);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(133, 24);
            this.lblTypeProduct.TabIndex = 3;
            this.lblTypeProduct.Text = "Loại sản phẩm";
            this.lblTypeProduct.Click += new System.EventHandler(this.lblTypeProduct_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(39, 364);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(75, 24);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "Giá bán";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(38, 422);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 24);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Số lượng";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "VNĐ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_masp.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_masp.Location = new System.Drawing.Point(41, 70);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(409, 30);
            this.txt_masp.TabIndex = 24;
            this.txt_masp.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Location = new System.Drawing.Point(43, 391);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(412, 28);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Text = "1000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.Location = new System.Drawing.Point(43, 451);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(410, 28);
            this.txtAmount.TabIndex = 28;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTypeProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTypeProduct.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Items.AddRange(new object[] {
            "Laptop",
            "Bàn Phím",
            "Tai Nghe",
            "Chuột"});
            this.cbTypeProduct.Location = new System.Drawing.Point(42, 195);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(409, 33);
            this.cbTypeProduct.TabIndex = 29;
            this.cbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cbTypeProduct_SelectedIndexChanged);
            this.cbTypeProduct.TextChanged += new System.EventHandler(this.cbTypeProduct_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(43, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 10);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClose.ForeColor = System.Drawing.Color.MintCream;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClose.IconColor = System.Drawing.Color.Red;
            this.iconBtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClose.IconSize = 45;
            this.iconBtnClose.Location = new System.Drawing.Point(495, 12);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(48, 35);
            this.iconBtnClose.TabIndex = 21;
            this.iconBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClose.UseVisualStyleBackColor = false;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSupplier.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(42, 264);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(409, 33);
            this.cbSupplier.TabIndex = 31;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(37, 235);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(129, 24);
            this.lblSupplier.TabIndex = 30;
            this.lblSupplier.Text = "Nhà cung cấp";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // iconBtnClear
            // 
            this.iconBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnClear.IconColor = System.Drawing.Color.ForestGreen;
            this.iconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClear.IconSize = 40;
            this.iconBtnClear.Location = new System.Drawing.Point(45, 501);
            this.iconBtnClear.Name = "iconBtnClear";
            this.iconBtnClear.Rotation = 0D;
            this.iconBtnClear.Size = new System.Drawing.Size(169, 42);
            this.iconBtnClear.TabIndex = 32;
            this.iconBtnClear.Text = "Reset";
            this.iconBtnClear.UseVisualStyleBackColor = true;
            this.iconBtnClear.Click += new System.EventHandler(this.iconBtnClear_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.ForestGreen;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 40;
            this.iconbtnAdd.Location = new System.Drawing.Point(259, 501);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(202, 42);
            this.iconbtnAdd.TabIndex = 33;
            this.iconbtnAdd.Text = "Thêm sản phẩm";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenSP.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_tenSP.Location = new System.Drawing.Point(40, 133);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(409, 30);
            this.txt_tenSP.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên sản phẩm";
            // 
            // cbNSX
            // 
            this.cbNSX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNSX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNSX.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Items.AddRange(new object[] {
            "APPLE",
            "HP",
            "DELL",
            "ASUS",
            "MSI",
            "RAZOR",
            "LOGITECH",
            "COOLER MASTER",
            "CORSAIR"});
            this.cbNSX.Location = new System.Drawing.Point(41, 331);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(409, 33);
            this.cbNSX.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nhà sản xuất";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 575);
            this.ControlBox = false;
            this.Controls.Add(this.cbNSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTypeProduct);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.iconBtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblTypeProduct);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProduct";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.Label label4;
    }
}