namespace QuanLyBanHoa.Forms
{
    partial class AddNCC
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
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(36, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(157, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Mã nhà cung cấp";
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
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(39, 326);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(57, 24);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "Email";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txt_mancc
            // 
            this.txt_mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_mancc.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_mancc.Location = new System.Drawing.Point(41, 70);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(409, 30);
            this.txt_mancc.TabIndex = 24;
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
            // iconBtnClear
            // 
            this.iconBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnClear.IconColor = System.Drawing.Color.ForestGreen;
            this.iconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClear.IconSize = 40;
            this.iconBtnClear.Location = new System.Drawing.Point(43, 461);
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
            this.iconbtnAdd.Location = new System.Drawing.Point(259, 460);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(202, 42);
            this.iconbtnAdd.TabIndex = 33;
            this.iconbtnAdd.Text = "Thêm nhà cung cấp";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "SĐT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenncc.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_tenncc.Location = new System.Drawing.Point(41, 133);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(409, 30);
            this.txt_tenncc.TabIndex = 37;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diachi.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_diachi.Location = new System.Drawing.Point(41, 202);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(409, 30);
            this.txt_diachi.TabIndex = 38;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sdt.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_sdt.Location = new System.Drawing.Point(43, 279);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(409, 30);
            this.txt_sdt.TabIndex = 40;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_email.Location = new System.Drawing.Point(43, 366);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(409, 30);
            this.txt_email.TabIndex = 41;
            // 
            // AddNCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 575);
            this.ControlBox = false;
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.iconBtnClose);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblTypeProduct);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNCC";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_email;
    }
}