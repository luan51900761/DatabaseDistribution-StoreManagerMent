namespace QuanLyBanHoa.Forms
{
    partial class AddKho
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
            this.txt_makho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.txt_chinhanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenkho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(36, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Mã kho";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeProduct.Location = new System.Drawing.Point(37, 166);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(67, 24);
            this.lblTypeProduct.TabIndex = 3;
            this.lblTypeProduct.Text = "Địa chỉ";
            this.lblTypeProduct.Click += new System.EventHandler(this.lblTypeProduct_Click);
            // 
            // txt_makho
            // 
            this.txt_makho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_makho.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_makho.Location = new System.Drawing.Point(41, 70);
            this.txt_makho.Name = "txt_makho";
            this.txt_makho.Size = new System.Drawing.Size(409, 30);
            this.txt_makho.TabIndex = 24;
            this.txt_makho.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            this.iconBtnClose.Location = new System.Drawing.Point(473, 12);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(48, 35);
            this.iconBtnClose.TabIndex = 21;
            this.iconBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClose.UseVisualStyleBackColor = false;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(37, 235);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(83, 24);
            this.lblSupplier.TabIndex = 30;
            this.lblSupplier.Text = "Tên Kho";
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
            this.iconBtnClear.Location = new System.Drawing.Point(53, 364);
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
            this.iconbtnAdd.Location = new System.Drawing.Point(259, 363);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(202, 42);
            this.iconbtnAdd.TabIndex = 33;
            this.iconbtnAdd.Text = "Thêm Kho";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // txt_chinhanh
            // 
            this.txt_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_chinhanh.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_chinhanh.Location = new System.Drawing.Point(40, 133);
            this.txt_chinhanh.Name = "txt_chinhanh";
            this.txt_chinhanh.Size = new System.Drawing.Size(409, 30);
            this.txt_chinhanh.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Chi nhánh";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diachi.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_diachi.Location = new System.Drawing.Point(40, 202);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(409, 30);
            this.txt_diachi.TabIndex = 36;
            // 
            // txt_tenkho
            // 
            this.txt_tenkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenkho.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_tenkho.Location = new System.Drawing.Point(40, 273);
            this.txt_tenkho.Name = "txt_tenkho";
            this.txt_tenkho.Size = new System.Drawing.Size(409, 30);
            this.txt_tenkho.TabIndex = 37;
            // 
            // AddKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 453);
            this.ControlBox = false;
            this.Controls.Add(this.txt_tenkho);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_chinhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_makho);
            this.Controls.Add(this.iconBtnClose);
            this.Controls.Add(this.lblTypeProduct);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddKho";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.TextBox txt_makho;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.Label lblSupplier;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private System.Windows.Forms.TextBox txt_chinhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenkho;
    }
}