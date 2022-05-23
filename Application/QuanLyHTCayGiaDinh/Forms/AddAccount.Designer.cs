namespace QuanLyBanHoa.Forms
{
    partial class AddAccount
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
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.lblTypeProduct = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_mk
            // 
            this.txt_mk.AccessibleDescription = "";
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_mk.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_mk.Location = new System.Drawing.Point(20, 288);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(409, 30);
            this.txt_mk.TabIndex = 49;
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tk.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_tk.Location = new System.Drawing.Point(20, 217);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(409, 30);
            this.txt_tk.TabIndex = 48;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tennv.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_tennv.Location = new System.Drawing.Point(20, 148);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(409, 30);
            this.txt_tennv.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.ForestGreen;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 40;
            this.iconbtnAdd.Location = new System.Drawing.Point(228, 362);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(202, 42);
            this.iconbtnAdd.TabIndex = 45;
            this.iconbtnAdd.Text = "Thêm tài khoản";
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // iconBtnClear
            // 
            this.iconBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnClear.IconColor = System.Drawing.Color.ForestGreen;
            this.iconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClear.IconSize = 40;
            this.iconBtnClear.Location = new System.Drawing.Point(23, 362);
            this.iconBtnClear.Name = "iconBtnClear";
            this.iconBtnClear.Rotation = 0D;
            this.iconBtnClear.Size = new System.Drawing.Size(169, 42);
            this.iconBtnClear.TabIndex = 44;
            this.iconBtnClear.Text = "Reset";
            this.iconBtnClear.UseVisualStyleBackColor = true;
            this.iconBtnClear.Click += new System.EventHandler(this.iconBtnClear_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(19, 261);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(86, 24);
            this.lblSupplier.TabIndex = 43;
            this.lblSupplier.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 10);
            this.panel1.TabIndex = 41;
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_manv.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_manv.Location = new System.Drawing.Point(21, 85);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(409, 30);
            this.txt_manv.TabIndex = 42;
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
            this.iconBtnClose.Location = new System.Drawing.Point(444, 2);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(48, 35);
            this.iconBtnClose.TabIndex = 40;
            this.iconBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClose.UseVisualStyleBackColor = false;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeProduct.Location = new System.Drawing.Point(19, 190);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(93, 24);
            this.lblTypeProduct.TabIndex = 39;
            this.lblTypeProduct.Text = "Tài khoản";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 24);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "Mã NV";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.iconBtnClose);
            this.Controls.Add(this.lblTypeProduct);
            this.Controls.Add(this.labelName);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_manv;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label labelName;
    }
}