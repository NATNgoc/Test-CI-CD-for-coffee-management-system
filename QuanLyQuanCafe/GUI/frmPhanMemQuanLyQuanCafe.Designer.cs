namespace GUI
{
    partial class frmPhanMemQuanLyQuanCafe
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanMemQuanLyQuanCafe));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSwitchTable = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCheckOut = new System.Windows.Forms.ToolStripMenuItem();
			this.tạpBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hùyBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.takeAwayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flpTable_Food = new System.Windows.Forms.FlowLayoutPanel();
			this.fOODCATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyQuanCafeDataSet3 = new GUI.QuanLyQuanCafeDataSet3();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnTaoBill = new System.Windows.Forms.Button();
			this.btnHuyBill = new System.Windows.Forms.Button();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cmbSwitchTable = new System.Windows.Forms.ComboBox();
			this.nudDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tABLEFOODBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.quanLyQuanCafeDataSet4 = new GUI.QuanLyQuanCafeDataSet4();
			this.fOOD_CATEGORYTableAdapter = new GUI.QuanLyQuanCafeDataSet3TableAdapters.FOOD_CATEGORYTableAdapter();
			this.tABLE_FOODTableAdapter = new GUI.QuanLyQuanCafeDataSet4TableAdapters.TABLE_FOODTableAdapter();
			this.panel8 = new System.Windows.Forms.Panel();
			this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtTimMon = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.nudSoLuongMon = new System.Windows.Forms.NumericUpDown();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.cmbFood = new System.Windows.Forms.ComboBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblIdBill = new System.Windows.Forms.Label();
			this.lblNameBan = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dtgHienThiMenu = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fOODCATEGORYBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet3)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tABLEFOODBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet4)).BeginInit();
			this.panel8.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMon)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgHienThiMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.billListToolStripMenuItem,
            this.takeAwayToolStripMenuItem,
            this.deliveryToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1914, 97);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// danhMụcToolStripMenuItem
			// 
			this.danhMụcToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddFood,
            this.mnuSwitchTable,
            this.mnuCheckOut,
            this.tạpBillToolStripMenuItem,
            this.hùyBillToolStripMenuItem});
			this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.danhMụcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.danhMụcToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
			this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(126, 93);
			this.danhMụcToolStripMenuItem.Text = "Chức năng";
			// 
			// mnuAddFood
			// 
			this.mnuAddFood.Name = "mnuAddFood";
			this.mnuAddFood.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.mnuAddFood.Size = new System.Drawing.Size(283, 30);
			this.mnuAddFood.Text = "Thêm món";
			this.mnuAddFood.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
			// 
			// mnuSwitchTable
			// 
			this.mnuSwitchTable.Name = "mnuSwitchTable";
			this.mnuSwitchTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuSwitchTable.Size = new System.Drawing.Size(283, 30);
			this.mnuSwitchTable.Text = "Chuyển bàn";
			this.mnuSwitchTable.Click += new System.EventHandler(this.mnuSwitchTable_Click);
			// 
			// mnuCheckOut
			// 
			this.mnuCheckOut.Name = "mnuCheckOut";
			this.mnuCheckOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.mnuCheckOut.Size = new System.Drawing.Size(283, 30);
			this.mnuCheckOut.Text = "Thanh toán";
			this.mnuCheckOut.Click += new System.EventHandler(this.mnuCheckOut_Click);
			// 
			// tạpBillToolStripMenuItem
			// 
			this.tạpBillToolStripMenuItem.Name = "tạpBillToolStripMenuItem";
			this.tạpBillToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.tạpBillToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
			this.tạpBillToolStripMenuItem.Text = "Tạo bill";
			this.tạpBillToolStripMenuItem.Click += new System.EventHandler(this.tạpBillToolStripMenuItem_Click);
			// 
			// hùyBillToolStripMenuItem
			// 
			this.hùyBillToolStripMenuItem.Name = "hùyBillToolStripMenuItem";
			this.hùyBillToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.hùyBillToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
			this.hùyBillToolStripMenuItem.Text = "Hùy bill";
			this.hùyBillToolStripMenuItem.Click += new System.EventHandler(this.hùyBillToolStripMenuItem_Click);
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
			this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(120, 93);
			this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.adminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(90, 93);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// billListToolStripMenuItem
			// 
			this.billListToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.billListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.billListToolStripMenuItem.Name = "billListToolStripMenuItem";
			this.billListToolStripMenuItem.Size = new System.Drawing.Size(100, 93);
			this.billListToolStripMenuItem.Text = "Bill List";
			// 
			// takeAwayToolStripMenuItem
			// 
			this.takeAwayToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.takeAwayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.takeAwayToolStripMenuItem.Name = "takeAwayToolStripMenuItem";
			this.takeAwayToolStripMenuItem.Size = new System.Drawing.Size(133, 93);
			this.takeAwayToolStripMenuItem.Text = "Take Away";
			// 
			// deliveryToolStripMenuItem
			// 
			this.deliveryToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
			this.deliveryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
			this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(110, 93);
			this.deliveryToolStripMenuItem.Text = "Delivery";
			// 
			// flpTable_Food
			// 
			this.flpTable_Food.AutoScroll = true;
			this.flpTable_Food.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.flpTable_Food.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flpTable_Food.Location = new System.Drawing.Point(1342, 64);
			this.flpTable_Food.Name = "flpTable_Food";
			this.flpTable_Food.Size = new System.Drawing.Size(560, 819);
			this.flpTable_Food.TabIndex = 1;
			this.flpTable_Food.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Food_Paint);
			// 
			// fOODCATEGORYBindingSource
			// 
			this.fOODCATEGORYBindingSource.DataMember = "FOOD_CATEGORY";
			this.fOODCATEGORYBindingSource.DataSource = this.quanLyQuanCafeDataSet3;
			// 
			// quanLyQuanCafeDataSet3
			// 
			this.quanLyQuanCafeDataSet3.DataSetName = "QuanLyQuanCafeDataSet3";
			this.quanLyQuanCafeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(1145, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(182, 880);
			this.panel2.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Transparent;
			this.panel6.Controls.Add(this.btnTaoBill);
			this.panel6.Controls.Add(this.btnHuyBill);
			this.panel6.Controls.Add(this.btnSwitchTable);
			this.panel6.Controls.Add(this.textBox1);
			this.panel6.Controls.Add(this.cmbSwitchTable);
			this.panel6.Controls.Add(this.nudDiscount);
			this.panel6.Controls.Add(this.btnCheckOut);
			this.panel6.Location = new System.Drawing.Point(13, 159);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(164, 443);
			this.panel6.TabIndex = 1;
			// 
			// btnTaoBill
			// 
			this.btnTaoBill.BackColor = System.Drawing.Color.IndianRed;
			this.btnTaoBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaoBill.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnTaoBill.Location = new System.Drawing.Point(13, 21);
			this.btnTaoBill.Name = "btnTaoBill";
			this.btnTaoBill.Size = new System.Drawing.Size(134, 53);
			this.btnTaoBill.TabIndex = 6;
			this.btnTaoBill.Text = "Tạo BILL";
			this.btnTaoBill.UseVisualStyleBackColor = false;
			this.btnTaoBill.Click += new System.EventHandler(this.btnTaoBill_Click);
			// 
			// btnHuyBill
			// 
			this.btnHuyBill.BackColor = System.Drawing.Color.IndianRed;
			this.btnHuyBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuyBill.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnHuyBill.Location = new System.Drawing.Point(13, 89);
			this.btnHuyBill.Name = "btnHuyBill";
			this.btnHuyBill.Size = new System.Drawing.Size(134, 53);
			this.btnHuyBill.TabIndex = 8;
			this.btnHuyBill.Text = "Hủy BILL";
			this.btnHuyBill.UseVisualStyleBackColor = false;
			this.btnHuyBill.Click += new System.EventHandler(this.btnHuyBill_Click);
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.BackColor = System.Drawing.Color.IndianRed;
			this.btnSwitchTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSwitchTable.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnSwitchTable.Location = new System.Drawing.Point(13, 160);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(134, 53);
			this.btnSwitchTable.TabIndex = 0;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = false;
			this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 273);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(134, 27);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "Giảm giá";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// cmbSwitchTable
			// 
			this.cmbSwitchTable.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSwitchTable.FormattingEnabled = true;
			this.cmbSwitchTable.Location = new System.Drawing.Point(13, 219);
			this.cmbSwitchTable.Name = "cmbSwitchTable";
			this.cmbSwitchTable.Size = new System.Drawing.Size(134, 34);
			this.cmbSwitchTable.TabIndex = 1;
			// 
			// nudDiscount
			// 
			this.nudDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudDiscount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudDiscount.Location = new System.Drawing.Point(13, 306);
			this.nudDiscount.Name = "nudDiscount";
			this.nudDiscount.Size = new System.Drawing.Size(134, 34);
			this.nudDiscount.TabIndex = 3;
			this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDiscount.ValueChanged += new System.EventHandler(this.nudDiscount_ValueChanged);
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.BackColor = System.Drawing.Color.IndianRed;
			this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnCheckOut.Location = new System.Drawing.Point(13, 356);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(134, 53);
			this.btnCheckOut.TabIndex = 4;
			this.btnCheckOut.Text = "Thanh toán";
			this.btnCheckOut.UseVisualStyleBackColor = false;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(34, 827);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 44);
			this.label2.TabIndex = 9;
			this.label2.Text = "created by \r\n      ThuyTrinh";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(166, 131);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// tABLEFOODBindingSource
			// 
			this.tABLEFOODBindingSource.DataMember = "TABLE_FOOD";
			this.tABLEFOODBindingSource.DataSource = this.quanLyQuanCafeDataSet4;
			// 
			// quanLyQuanCafeDataSet4
			// 
			this.quanLyQuanCafeDataSet4.DataSetName = "QuanLyQuanCafeDataSet4";
			this.quanLyQuanCafeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fOOD_CATEGORYTableAdapter
			// 
			this.fOOD_CATEGORYTableAdapter.ClearBeforeFill = true;
			// 
			// tABLE_FOODTableAdapter
			// 
			this.tABLE_FOODTableAdapter.ClearBeforeFill = true;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.flpFood);
			this.panel8.Controls.Add(this.textBox2);
			this.panel8.Controls.Add(this.txtTimMon);
			this.panel8.Controls.Add(this.panel3);
			this.panel8.Controls.Add(this.flpTable_Food);
			this.panel8.Controls.Add(this.panel2);
			this.panel8.Controls.Add(this.panel1);
			this.panel8.Location = new System.Drawing.Point(9, 100);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(1905, 895);
			this.panel8.TabIndex = 4;
			// 
			// flpFood
			// 
			this.flpFood.AutoScroll = true;
			this.flpFood.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.flpFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flpFood.Location = new System.Drawing.Point(3, 184);
			this.flpFood.Name = "flpFood";
			this.flpFood.Size = new System.Drawing.Size(491, 699);
			this.flpFood.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(1410, 18);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(390, 30);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Tìm kiếm món ăn...";
			// 
			// txtTimMon
			// 
			this.txtTimMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimMon.Location = new System.Drawing.Point(41, 26);
			this.txtTimMon.Name = "txtTimMon";
			this.txtTimMon.Size = new System.Drawing.Size(390, 30);
			this.txtTimMon.TabIndex = 6;
			this.txtTimMon.TextChanged += new System.EventHandler(this.txtTimL_TextChanged);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.nudSoLuongMon);
			this.panel3.Controls.Add(this.btnAddFood);
			this.panel3.Controls.Add(this.cmbFood);
			this.panel3.Controls.Add(this.cmbCategory);
			this.panel3.Location = new System.Drawing.Point(0, 86);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(494, 92);
			this.panel3.TabIndex = 0;
			// 
			// nudSoLuongMon
			// 
			this.nudSoLuongMon.Location = new System.Drawing.Point(356, 5);
			this.nudSoLuongMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudSoLuongMon.Name = "nudSoLuongMon";
			this.nudSoLuongMon.Size = new System.Drawing.Size(133, 27);
			this.nudSoLuongMon.TabIndex = 3;
			this.nudSoLuongMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudSoLuongMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAddFood
			// 
			this.btnAddFood.BackColor = System.Drawing.Color.IndianRed;
			this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddFood.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAddFood.Location = new System.Drawing.Point(355, 34);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(134, 53);
			this.btnAddFood.TabIndex = 2;
			this.btnAddFood.Text = "Thêm món";
			this.btnAddFood.UseVisualStyleBackColor = false;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// cmbFood
			// 
			this.cmbFood.FormattingEnabled = true;
			this.cmbFood.Location = new System.Drawing.Point(7, 54);
			this.cmbFood.Name = "cmbFood";
			this.cmbFood.Size = new System.Drawing.Size(342, 27);
			this.cmbFood.TabIndex = 1;
			this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(7, 5);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(342, 27);
			this.cmbCategory.TabIndex = 0;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new System.Drawing.Point(503, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(636, 880);
			this.panel1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblIdBill);
			this.panel5.Controls.Add(this.lblNameBan);
			this.panel5.Location = new System.Drawing.Point(6, 13);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(616, 40);
			this.panel5.TabIndex = 1;
			// 
			// lblIdBill
			// 
			this.lblIdBill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdBill.ForeColor = System.Drawing.Color.Black;
			this.lblIdBill.Location = new System.Drawing.Point(314, 8);
			this.lblIdBill.Name = "lblIdBill";
			this.lblIdBill.Size = new System.Drawing.Size(299, 30);
			this.lblIdBill.TabIndex = 7;
			this.lblIdBill.Text = "Mã hóa đơn:";
			// 
			// lblNameBan
			// 
			this.lblNameBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNameBan.ForeColor = System.Drawing.Color.Black;
			this.lblNameBan.Location = new System.Drawing.Point(18, 8);
			this.lblNameBan.Name = "lblNameBan";
			this.lblNameBan.Size = new System.Drawing.Size(122, 30);
			this.lblNameBan.TabIndex = 3;
			this.lblNameBan.Text = "Bàn ....";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label1);
			this.panel7.Controls.Add(this.txtTotalPrice);
			this.panel7.Location = new System.Drawing.Point(6, 59);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(616, 43);
			this.panel7.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(192, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tổng tiền:";
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
			this.txtTotalPrice.Location = new System.Drawing.Point(302, 6);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.Size = new System.Drawing.Size(301, 30);
			this.txtTotalPrice.TabIndex = 1;
			this.txtTotalPrice.Text = "0";
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dtgHienThiMenu);
			this.panel4.Location = new System.Drawing.Point(6, 108);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(616, 765);
			this.panel4.TabIndex = 1;
			// 
			// dtgHienThiMenu
			// 
			this.dtgHienThiMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dtgHienThiMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgHienThiMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgHienThiMenu.Location = new System.Drawing.Point(0, 0);
			this.dtgHienThiMenu.Name = "dtgHienThiMenu";
			this.dtgHienThiMenu.ReadOnly = true;
			this.dtgHienThiMenu.RowHeadersWidth = 51;
			this.dtgHienThiMenu.RowTemplate.Height = 24;
			this.dtgHienThiMenu.Size = new System.Drawing.Size(616, 765);
			this.dtgHienThiMenu.TabIndex = 0;
			this.dtgHienThiMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThiMenu_CellContentClick);
			// 
			// frmPhanMemQuanLyQuanCafe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1914, 998);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel8);
			this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmPhanMemQuanLyQuanCafe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QUẢN LÝ QUÁN CAFE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPhanMemQuanLyQuanCafe_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fOODCATEGORYBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet3)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tABLEFOODBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet4)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgHienThiMenu)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddFood;
        private System.Windows.Forms.ToolStripMenuItem mnuSwitchTable;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable_Food;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.ComboBox cmbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QuanLyQuanCafeDataSet3 quanLyQuanCafeDataSet3;
        private System.Windows.Forms.BindingSource fOODCATEGORYBindingSource;
        private QuanLyQuanCafeDataSet3TableAdapters.FOOD_CATEGORYTableAdapter fOOD_CATEGORYTableAdapter;
        private System.Windows.Forms.Button btnTaoBill;
        private QuanLyQuanCafeDataSet4 quanLyQuanCafeDataSet4;
        private System.Windows.Forms.BindingSource tABLEFOODBindingSource;
        private QuanLyQuanCafeDataSet4TableAdapters.TABLE_FOODTableAdapter tABLE_FOODTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHuyBill;
        private System.Windows.Forms.ToolStripMenuItem tạpBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hùyBillToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem billListToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem takeAwayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblNameBan;
        private System.Windows.Forms.TextBox txtTimMon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudSoLuongMon;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgHienThiMenu;
        private System.Windows.Forms.Label lblIdBill;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.FlowLayoutPanel flpFood;
	}
}
