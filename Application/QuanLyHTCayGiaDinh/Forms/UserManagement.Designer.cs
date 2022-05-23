namespace QuanLyBanHoa.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconbtnCreateAccount = new FontAwesome.Sharp.IconButton();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.iconbtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.chinhanh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvListStaff);
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 418);
            this.panel1.TabIndex = 0;
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.AllowUserToAddRows = false;
            this.dgvListStaff.AllowUserToOrderColumns = true;
            this.dgvListStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStaff.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListStaff.ColumnHeadersHeight = 35;
            this.dgvListStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.cnmd,
            this.ngaylamviec,
            this.chucvu,
            this.macn});
            this.dgvListStaff.Location = new System.Drawing.Point(0, 6);
            this.dgvListStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListStaff.Name = "dgvListStaff";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListStaff.RowHeadersWidth = 62;
            this.dgvListStaff.RowTemplate.Height = 30;
            this.dgvListStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListStaff.Size = new System.Drawing.Size(1490, 356);
            this.dgvListStaff.TabIndex = 0;
            this.dgvListStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellClick);
            this.dgvListStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellContentClick);
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "manv";
            this.manv.FillWeight = 50F;
            this.manv.HeaderText = "Mã NV";
            this.manv.MinimumWidth = 8;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Tên nhân viên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.FillWeight = 70F;
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.FillWeight = 50F;
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.FillWeight = 80F;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // cnmd
            // 
            this.cnmd.DataPropertyName = "cnmd";
            this.cnmd.HeaderText = "CMND";
            this.cnmd.MinimumWidth = 6;
            this.cnmd.Name = "cnmd";
            // 
            // ngaylamviec
            // 
            this.ngaylamviec.DataPropertyName = "ngaylamviec";
            this.ngaylamviec.FillWeight = 80F;
            this.ngaylamviec.HeaderText = "Ngày vào làm";
            this.ngaylamviec.MinimumWidth = 8;
            this.ngaylamviec.Name = "ngaylamviec";
            this.ngaylamviec.ReadOnly = true;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.MinimumWidth = 8;
            this.chucvu.Name = "chucvu";
            // 
            // macn
            // 
            this.macn.DataPropertyName = "macn";
            this.macn.HeaderText = "Chi nhánh";
            this.macn.MinimumWidth = 6;
            this.macn.Name = "macn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.iconbtnCreateAccount);
            this.panel2.Controls.Add(this.iconbtnDelete);
            this.panel2.Controls.Add(this.iconbtnUpdate);
            this.panel2.Controls.Add(this.iconbtnAdd);
            this.panel2.Location = new System.Drawing.Point(1136, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 404);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 404);
            this.panel3.TabIndex = 4;
            // 
            // iconbtnCreateAccount
            // 
            this.iconbtnCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnCreateAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnCreateAccount.FlatAppearance.BorderSize = 0;
            this.iconbtnCreateAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.iconbtnCreateAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnCreateAccount.IconColor = System.Drawing.Color.Aquamarine;
            this.iconbtnCreateAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnCreateAccount.IconSize = 40;
            this.iconbtnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconbtnCreateAccount.Location = new System.Drawing.Point(33, 289);
            this.iconbtnCreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnCreateAccount.Name = "iconbtnCreateAccount";
            this.iconbtnCreateAccount.Rotation = 0D;
            this.iconbtnCreateAccount.Size = new System.Drawing.Size(261, 62);
            this.iconbtnCreateAccount.TabIndex = 3;
            this.iconbtnCreateAccount.Text = "Cấp tài khoản";
            this.iconbtnCreateAccount.UseVisualStyleBackColor = false;
            this.iconbtnCreateAccount.Click += new System.EventHandler(this.iconbtnCreateAccount_Click);
            // 
            // iconbtnDelete
            // 
            this.iconbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnDelete.FlatAppearance.BorderSize = 0;
            this.iconbtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnDelete.ForeColor = System.Drawing.Color.White;
            this.iconbtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnDelete.IconColor = System.Drawing.Color.Aquamarine;
            this.iconbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnDelete.IconSize = 40;
            this.iconbtnDelete.Location = new System.Drawing.Point(33, 204);
            this.iconbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Rotation = 0D;
            this.iconbtnDelete.Size = new System.Drawing.Size(261, 62);
            this.iconbtnDelete.TabIndex = 2;
            this.iconbtnDelete.Text = "Xóa nhân viên";
            this.iconbtnDelete.UseVisualStyleBackColor = false;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // iconbtnUpdate
            // 
            this.iconbtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnUpdate.FlatAppearance.BorderSize = 0;
            this.iconbtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnUpdate.ForeColor = System.Drawing.Color.White;
            this.iconbtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnUpdate.IconColor = System.Drawing.Color.Aquamarine;
            this.iconbtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnUpdate.IconSize = 40;
            this.iconbtnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconbtnUpdate.Location = new System.Drawing.Point(33, 116);
            this.iconbtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnUpdate.Name = "iconbtnUpdate";
            this.iconbtnUpdate.Rotation = 0D;
            this.iconbtnUpdate.Size = new System.Drawing.Size(261, 62);
            this.iconbtnUpdate.TabIndex = 1;
            this.iconbtnUpdate.Text = "Cập nhật thông tin";
            this.iconbtnUpdate.UseVisualStyleBackColor = false;
            this.iconbtnUpdate.Click += new System.EventHandler(this.iconbtnUpdate_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconbtnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconbtnAdd.FlatAppearance.BorderSize = 0;
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.ForeColor = System.Drawing.Color.White;
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAdd.IconColor = System.Drawing.Color.Aquamarine;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 40;
            this.iconbtnAdd.Location = new System.Drawing.Point(33, 30);
            this.iconbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(261, 62);
            this.iconbtnAdd.TabIndex = 0;
            this.iconbtnAdd.Text = "Thêm nhân viên";
            this.iconbtnAdd.UseVisualStyleBackColor = false;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhân viên :";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(165, 67);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(289, 30);
            this.txtStaffName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính :";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(165, 303);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(289, 30);
            this.txtCMND.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CMND :";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(165, 155);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(289, 30);
            this.dtpBirth.TabIndex = 10;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMale.Location = new System.Drawing.Point(165, 232);
            this.cbMale.Margin = new System.Windows.Forms.Padding(4);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(66, 24);
            this.cbMale.TabIndex = 11;
            this.cbMale.Text = "Nam";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFemale.Location = new System.Drawing.Point(271, 232);
            this.cbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(52, 24);
            this.cbFemale.TabIndex = 12;
            this.cbFemale.Text = "Nữ";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(679, 303);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(300, 30);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số điện thoại :";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(679, 69);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(300, 30);
            this.dtpDateStart.TabIndex = 18;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày vào làm :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chinhanh
            // 
            this.chinhanh.AutoSize = true;
            this.chinhanh.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhanh.Location = new System.Drawing.Point(494, 161);
            this.chinhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chinhanh.Name = "chinhanh";
            this.chinhanh.Size = new System.Drawing.Size(81, 16);
            this.chinhanh.TabIndex = 19;
            this.chinhanh.Text = "Chi Nhánh :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(494, 240);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Chức vụ :";
            // 
            // cbbPosition
            // 
            this.cbbPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Items.AddRange(new object[] {
            "ADMIN",
            "nhân viên",
            "thủ kho",
            "quản lý"});
            this.cbbPosition.Location = new System.Drawing.Point(679, 233);
            this.cbbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(300, 31);
            this.cbbPosition.TabIndex = 26;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Firebrick;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.Location = new System.Drawing.Point(1004, 57);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(106, 40);
            this.iconButton4.TabIndex = 27;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 20;
            this.iconButton5.Location = new System.Drawing.Point(1004, 143);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(106, 40);
            this.iconButton5.TabIndex = 28;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // cbStation
            // 
            this.cbStation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Items.AddRange(new object[] {
            "Chi Nhánh 1",
            "Chi Nhánh 2"});
            this.cbStation.Location = new System.Drawing.Point(679, 152);
            this.cbStation.Margin = new System.Windows.Forms.Padding(4);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(300, 31);
            this.cbStation.TabIndex = 29;
            // 
            // StorageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 821);
            this.ControlBox = false;
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.cbbPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chinhanh);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorageManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconbtnCreateAccount;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private FontAwesome.Sharp.IconButton iconbtnUpdate;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label chinhanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbPosition;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylamviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn macn;
        private System.Windows.Forms.ComboBox cbStation;
    }
}