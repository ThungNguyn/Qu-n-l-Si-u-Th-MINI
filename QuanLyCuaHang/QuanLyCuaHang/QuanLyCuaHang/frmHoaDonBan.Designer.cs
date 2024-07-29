namespace QuanLyCuaHang
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tiemkiem = new System.Windows.Forms.Button();
            this.cbo_mahoadon = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mask_dienthoai = new System.Windows.Forms.MaskedTextBox();
            this.cbo_manhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_makhachhang = new System.Windows.Forms.ComboBox();
            this.dtp_ngayban = new System.Windows.Forms.DateTimePicker();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenkhach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_bangchu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_thanhtien = new System.Windows.Forms.Label();
            this.cbo_mahang = new System.Windows.Forms.ComboBox();
            this.lblgiamgia = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_tiemkiem);
            this.panel1.Controls.Add(this.cbo_mahoadon);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 60);
            this.panel1.TabIndex = 0;
            // 
            // btn_tiemkiem
            // 
            this.btn_tiemkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tiemkiem.ForeColor = System.Drawing.Color.Blue;
            this.btn_tiemkiem.Image = global::QuanLyCuaHang.Properties.Resources.timkiem;
            this.btn_tiemkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tiemkiem.Location = new System.Drawing.Point(390, 22);
            this.btn_tiemkiem.Name = "btn_tiemkiem";
            this.btn_tiemkiem.Size = new System.Drawing.Size(117, 23);
            this.btn_tiemkiem.TabIndex = 2;
            this.btn_tiemkiem.Text = "&Tiềm kiếm";
            this.btn_tiemkiem.UseVisualStyleBackColor = true;
            this.btn_tiemkiem.Click += new System.EventHandler(this.btn_tiemkiem_Click);
            // 
            // cbo_mahoadon
            // 
            this.cbo_mahoadon.FormattingEnabled = true;
            this.cbo_mahoadon.Location = new System.Drawing.Point(122, 22);
            this.cbo_mahoadon.Name = "cbo_mahoadon";
            this.cbo_mahoadon.Size = new System.Drawing.Size(249, 21);
            this.cbo_mahoadon.TabIndex = 1;
            this.cbo_mahoadon.DropDown += new System.EventHandler(this.cbo_mahoadon_DropDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(26, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 208);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mask_dienthoai);
            this.groupBox1.Controls.Add(this.cbo_manhanvien);
            this.groupBox1.Controls.Add(this.cbo_makhachhang);
            this.groupBox1.Controls.Add(this.dtp_ngayban);
            this.groupBox1.Controls.Add(this.txt_tennhanvien);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_tenkhach);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_mahoadon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // mask_dienthoai
            // 
            this.mask_dienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mask_dienthoai.Location = new System.Drawing.Point(547, 127);
            this.mask_dienthoai.Mask = "(999) 000-0000";
            this.mask_dienthoai.Name = "mask_dienthoai";
            this.mask_dienthoai.ReadOnly = true;
            this.mask_dienthoai.Size = new System.Drawing.Size(183, 21);
            this.mask_dienthoai.TabIndex = 4;
            // 
            // cbo_manhanvien
            // 
            this.cbo_manhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbo_manhanvien.FormattingEnabled = true;
            this.cbo_manhanvien.Location = new System.Drawing.Point(129, 92);
            this.cbo_manhanvien.Name = "cbo_manhanvien";
            this.cbo_manhanvien.Size = new System.Drawing.Size(183, 23);
            this.cbo_manhanvien.TabIndex = 3;
            this.cbo_manhanvien.SelectedIndexChanged += new System.EventHandler(this.cbo_manhanvien_SelectedIndexChanged);
            // 
            // cbo_makhachhang
            // 
            this.cbo_makhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbo_makhachhang.FormattingEnabled = true;
            this.cbo_makhachhang.Location = new System.Drawing.Point(547, 32);
            this.cbo_makhachhang.Name = "cbo_makhachhang";
            this.cbo_makhachhang.Size = new System.Drawing.Size(183, 23);
            this.cbo_makhachhang.TabIndex = 3;
            this.cbo_makhachhang.SelectedIndexChanged += new System.EventHandler(this.cbo_makhachhang_SelectedIndexChanged);
            // 
            // dtp_ngayban
            // 
            this.dtp_ngayban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtp_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayban.Location = new System.Drawing.Point(129, 61);
            this.dtp_ngayban.Name = "dtp_ngayban";
            this.dtp_ngayban.Size = new System.Drawing.Size(183, 21);
            this.dtp_ngayban.TabIndex = 2;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_tennhanvien.Location = new System.Drawing.Point(129, 125);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.ReadOnly = true;
            this.txt_tennhanvien.Size = new System.Drawing.Size(183, 21);
            this.txt_tennhanvien.TabIndex = 1;
            this.txt_tennhanvien.TextChanged += new System.EventHandler(this.txt_tennhanvien_TextChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_diachi.Location = new System.Drawing.Point(547, 93);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(183, 21);
            this.txt_diachi.TabIndex = 1;
            // 
            // txt_tenkhach
            // 
            this.txt_tenkhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_tenkhach.Location = new System.Drawing.Point(547, 61);
            this.txt_tenkhach.Name = "txt_tenkhach";
            this.txt_tenkhach.ReadOnly = true;
            this.txt_tenkhach.Size = new System.Drawing.Size(183, 21);
            this.txt_tenkhach.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(429, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điện thoại";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_mahoadon.Location = new System.Drawing.Point(129, 32);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(183, 21);
            this.txt_mahoadon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(429, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(25, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(429, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(429, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 277);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(3, 143);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBanHang.Size = new System.Drawing.Size(813, 30);
            this.dgvHDBanHang.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_tongtien);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.lbl_bangchu);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 173);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(813, 50);
            this.panel6.TabIndex = 14;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_tongtien.Location = new System.Drawing.Point(619, 14);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(108, 21);
            this.txt_tongtien.TabIndex = 2;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(563, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tổng tiền: ";
            // 
            // lbl_bangchu
            // 
            this.lbl_bangchu.AutoSize = true;
            this.lbl_bangchu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bangchu.Location = new System.Drawing.Point(17, 30);
            this.lbl_bangchu.Name = "lbl_bangchu";
            this.lbl_bangchu.Size = new System.Drawing.Size(58, 15);
            this.lbl_bangchu.TabIndex = 1;
            this.lbl_bangchu.Text = "Bằng chữ: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_dong);
            this.panel5.Controls.Add(this.btn_in);
            this.panel5.Controls.Add(this.btn_xoa);
            this.panel5.Controls.Add(this.btn_luu);
            this.panel5.Controls.Add(this.btn_them);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(813, 51);
            this.panel5.TabIndex = 13;
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.Blue;
            this.btn_dong.Image = global::QuanLyCuaHang.Properties.Resources.close;
            this.btn_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dong.Location = new System.Drawing.Point(619, 6);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(93, 36);
            this.btn_dong.TabIndex = 12;
            this.btn_dong.Text = "&Đóng\r\n";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_in
            // 
            this.btn_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.Blue;
            this.btn_in.Image = global::QuanLyCuaHang.Properties.Resources._in;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(472, 6);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(95, 36);
            this.btn_in.TabIndex = 13;
            this.btn_in.Text = "&In hóa đơn\r\n";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Blue;
            this.btn_xoa.Image = global::QuanLyCuaHang.Properties.Resources.x;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(323, 6);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 36);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "&Hủy hóa đơn\r\n";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Blue;
            this.btn_luu.Image = global::QuanLyCuaHang.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(182, 6);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 36);
            this.btn_luu.TabIndex = 15;
            this.btn_luu.Text = "&Lưu hóa đơn\r\n";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Blue;
            this.btn_them.Image = global::QuanLyCuaHang.Properties.Resources._;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(40, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(102, 36);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "&Thêm hóa đơn\r\n";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_thanhtien);
            this.panel4.Controls.Add(this.cbo_mahang);
            this.panel4.Controls.Add(this.lblgiamgia);
            this.panel4.Controls.Add(this.txt_soluong);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txt_giamgia);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_tenhang);
            this.panel4.Controls.Add(this.txt_thanhtien);
            this.panel4.Controls.Add(this.txt_dongia);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(813, 127);
            this.panel4.TabIndex = 12;
            // 
            // lbl_thanhtien
            // 
            this.lbl_thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_thanhtien.AutoSize = true;
            this.lbl_thanhtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_thanhtien.Location = new System.Drawing.Point(513, 63);
            this.lbl_thanhtien.Name = "lbl_thanhtien";
            this.lbl_thanhtien.Size = new System.Drawing.Size(63, 15);
            this.lbl_thanhtien.TabIndex = 13;
            this.lbl_thanhtien.Text = "Thành Tiền";
            // 
            // cbo_mahang
            // 
            this.cbo_mahang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbo_mahang.FormattingEnabled = true;
            this.cbo_mahang.Location = new System.Drawing.Point(72, 20);
            this.cbo_mahang.Name = "cbo_mahang";
            this.cbo_mahang.Size = new System.Drawing.Size(133, 23);
            this.cbo_mahang.TabIndex = 19;
            this.cbo_mahang.SelectedIndexChanged += new System.EventHandler(this.cbo_mahang_SelectedIndexChanged);
            // 
            // lblgiamgia
            // 
            this.lblgiamgia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblgiamgia.AutoSize = true;
            this.lblgiamgia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgiamgia.ForeColor = System.Drawing.Color.Blue;
            this.lblgiamgia.Location = new System.Drawing.Point(271, 63);
            this.lblgiamgia.Name = "lblgiamgia";
            this.lblgiamgia.Size = new System.Drawing.Size(53, 15);
            this.lblgiamgia.TabIndex = 14;
            this.lblgiamgia.Text = "Giả giá %";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_soluong.Location = new System.Drawing.Point(72, 60);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(133, 21);
            this.txt_soluong.TabIndex = 24;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(513, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(3, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã hàng";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_giamgia.Location = new System.Drawing.Point(340, 60);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(133, 21);
            this.txt_giamgia.TabIndex = 23;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(271, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tên hàng";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_tenhang.Location = new System.Drawing.Point(340, 20);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.ReadOnly = true;
            this.txt_tenhang.Size = new System.Drawing.Size(133, 21);
            this.txt_tenhang.TabIndex = 22;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_thanhtien.Location = new System.Drawing.Point(594, 60);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(133, 21);
            this.txt_thanhtien.TabIndex = 20;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_dongia.Location = new System.Drawing.Point(594, 20);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(133, 21);
            this.txt_dongia.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(3, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Số lượng";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonBanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mask_dienthoai;
        private System.Windows.Forms.ComboBox cbo_makhachhang;
        private System.Windows.Forms.DateTimePicker dtp_ngayban;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenkhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tiemkiem;
        private System.Windows.Forms.ComboBox cbo_mahoadon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_bangchu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_thanhtien;
        private System.Windows.Forms.ComboBox cbo_mahang;
        private System.Windows.Forms.Label lblgiamgia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_manhanvien;
    }
}