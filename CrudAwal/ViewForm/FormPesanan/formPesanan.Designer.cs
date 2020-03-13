namespace CrudAwal.ViewForm.FormPesanan
{
    partial class formPesanan
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
            this.panelTopSlide = new System.Windows.Forms.Panel();
            this.lblJudulForm = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.bfCardFormGudang = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtJmlHargaBeliPPN = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJmlHargaBeli = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJmlPotongan = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalHarga = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJenisObat = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.DGPesanan = new System.Windows.Forms.DataGridView();
            this.btnBarangEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCariPesanan = new System.Windows.Forms.TextBox();
            this.btnTambahPesanan = new System.Windows.Forms.Button();
            this.panelTopSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.bfCardFormGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlHargaBeliPPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlHargaBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlPotongan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSlide
            // 
            this.panelTopSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panelTopSlide.Controls.Add(this.lblJudulForm);
            this.panelTopSlide.Controls.Add(this.picMin);
            this.panelTopSlide.Controls.Add(this.picMax);
            this.panelTopSlide.Controls.Add(this.picClose);
            this.panelTopSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSlide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSlide.Name = "panelTopSlide";
            this.panelTopSlide.Size = new System.Drawing.Size(1219, 30);
            this.panelTopSlide.TabIndex = 7;
            // 
            // lblJudulForm
            // 
            this.lblJudulForm.AutoSize = true;
            this.lblJudulForm.Font = new System.Drawing.Font("Fira Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblJudulForm.Location = new System.Drawing.Point(538, 6);
            this.lblJudulForm.Name = "lblJudulForm";
            this.lblJudulForm.Size = new System.Drawing.Size(78, 15);
            this.lblJudulForm.TabIndex = 7;
            this.lblJudulForm.Text = "JUDUL FORM";
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = global::CrudAwal.Properties.Resources.max_min_button;
            this.picMin.Location = new System.Drawing.Point(1145, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(18, 18);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 6;
            this.picMin.TabStop = false;
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Image = global::CrudAwal.Properties.Resources.button_yellow;
            this.picMax.Location = new System.Drawing.Point(1169, 6);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(18, 18);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMax.TabIndex = 5;
            this.picMax.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::CrudAwal.Properties.Resources.button_red;
            this.picClose.Location = new System.Drawing.Point(1193, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // bfCardFormGudang
            // 
            this.bfCardFormGudang.BackColor = System.Drawing.Color.White;
            this.bfCardFormGudang.BorderRadius = 5;
            this.bfCardFormGudang.BottomSahddow = true;
            this.bfCardFormGudang.color = System.Drawing.Color.White;
            this.bfCardFormGudang.Controls.Add(this.panel2);
            this.bfCardFormGudang.Controls.Add(this.txtJmlHargaBeliPPN);
            this.bfCardFormGudang.Controls.Add(this.label8);
            this.bfCardFormGudang.Controls.Add(this.txtJmlHargaBeli);
            this.bfCardFormGudang.Controls.Add(this.label7);
            this.bfCardFormGudang.Controls.Add(this.txtJmlPotongan);
            this.bfCardFormGudang.Controls.Add(this.label6);
            this.bfCardFormGudang.Controls.Add(this.txtTotalHarga);
            this.bfCardFormGudang.Controls.Add(this.label4);
            this.bfCardFormGudang.Controls.Add(this.txtQty);
            this.bfCardFormGudang.Controls.Add(this.Label5);
            this.bfCardFormGudang.Controls.Add(this.label3);
            this.bfCardFormGudang.Controls.Add(this.cmbJenisObat);
            this.bfCardFormGudang.Controls.Add(this.btnExportExcel);
            this.bfCardFormGudang.Controls.Add(this.label2);
            this.bfCardFormGudang.Controls.Add(this.dtTanggalAkhir);
            this.bfCardFormGudang.Controls.Add(this.label1);
            this.bfCardFormGudang.Controls.Add(this.dtTanggalAwal);
            this.bfCardFormGudang.Controls.Add(this.DGPesanan);
            this.bfCardFormGudang.Controls.Add(this.panel1);
            this.bfCardFormGudang.Controls.Add(this.label30);
            this.bfCardFormGudang.Controls.Add(this.txtCariPesanan);
            this.bfCardFormGudang.Controls.Add(this.btnTambahPesanan);
            this.bfCardFormGudang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfCardFormGudang.LeftSahddow = false;
            this.bfCardFormGudang.Location = new System.Drawing.Point(0, 30);
            this.bfCardFormGudang.Name = "bfCardFormGudang";
            this.bfCardFormGudang.RightSahddow = true;
            this.bfCardFormGudang.ShadowDepth = 20;
            this.bfCardFormGudang.Size = new System.Drawing.Size(1219, 663);
            this.bfCardFormGudang.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel2.Location = new System.Drawing.Point(3, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 5);
            this.panel2.TabIndex = 5;
            // 
            // txtJmlHargaBeliPPN
            // 
            this.txtJmlHargaBeliPPN.BackGroundColor = System.Drawing.SystemColors.Info;
            this.txtJmlHargaBeliPPN.BeforeTouchSize = new System.Drawing.Size(220, 33);
            this.txtJmlHargaBeliPPN.BorderColor = System.Drawing.Color.DimGray;
            this.txtJmlHargaBeliPPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJmlHargaBeliPPN.CurrencySymbol = "";
            this.txtJmlHargaBeliPPN.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtJmlHargaBeliPPN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlHargaBeliPPN.Location = new System.Drawing.Point(1050, 629);
            this.txtJmlHargaBeliPPN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJmlHargaBeliPPN.Name = "txtJmlHargaBeliPPN";
            this.txtJmlHargaBeliPPN.NullString = "";
            this.txtJmlHargaBeliPPN.Size = new System.Drawing.Size(140, 25);
            this.txtJmlHargaBeliPPN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJmlHargaBeliPPN.TabIndex = 125;
            this.txtJmlHargaBeliPPN.Text = "0,00";
            this.txtJmlHargaBeliPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(903, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 124;
            this.label8.Text = "JML HARGA BELI + PPN";
            // 
            // txtJmlHargaBeli
            // 
            this.txtJmlHargaBeli.BackGroundColor = System.Drawing.SystemColors.Info;
            this.txtJmlHargaBeli.BeforeTouchSize = new System.Drawing.Size(220, 33);
            this.txtJmlHargaBeli.BorderColor = System.Drawing.Color.DimGray;
            this.txtJmlHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJmlHargaBeli.CurrencySymbol = "";
            this.txtJmlHargaBeli.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtJmlHargaBeli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlHargaBeli.Location = new System.Drawing.Point(748, 629);
            this.txtJmlHargaBeli.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJmlHargaBeli.Name = "txtJmlHargaBeli";
            this.txtJmlHargaBeli.NullString = "";
            this.txtJmlHargaBeli.Size = new System.Drawing.Size(140, 25);
            this.txtJmlHargaBeli.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJmlHargaBeli.TabIndex = 123;
            this.txtJmlHargaBeli.Text = "0,00";
            this.txtJmlHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(642, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 122;
            this.label7.Text = "JML HARGA BELI";
            // 
            // txtJmlPotongan
            // 
            this.txtJmlPotongan.BackGroundColor = System.Drawing.SystemColors.Info;
            this.txtJmlPotongan.BeforeTouchSize = new System.Drawing.Size(220, 33);
            this.txtJmlPotongan.BorderColor = System.Drawing.Color.DimGray;
            this.txtJmlPotongan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJmlPotongan.CurrencySymbol = "";
            this.txtJmlPotongan.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtJmlPotongan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlPotongan.Location = new System.Drawing.Point(488, 629);
            this.txtJmlPotongan.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJmlPotongan.Name = "txtJmlPotongan";
            this.txtJmlPotongan.NullString = "";
            this.txtJmlPotongan.Size = new System.Drawing.Size(140, 25);
            this.txtJmlPotongan.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJmlPotongan.TabIndex = 121;
            this.txtJmlPotongan.Text = "0,00";
            this.txtJmlPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(383, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "JML POTONGAN";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.BackGroundColor = System.Drawing.SystemColors.Info;
            this.txtTotalHarga.BeforeTouchSize = new System.Drawing.Size(220, 33);
            this.txtTotalHarga.BorderColor = System.Drawing.Color.DimGray;
            this.txtTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalHarga.CurrencySymbol = "";
            this.txtTotalHarga.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtTotalHarga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHarga.Location = new System.Drawing.Point(232, 629);
            this.txtTotalHarga.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.NullString = "";
            this.txtTotalHarga.Size = new System.Drawing.Size(140, 25);
            this.txtTotalHarga.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTotalHarga.TabIndex = 119;
            this.txtTotalHarga.Text = "0,00";
            this.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(153, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 118;
            this.label4.Text = "Total Harga";
            // 
            // txtQty
            // 
            this.txtQty.BackGroundColor = System.Drawing.SystemColors.Info;
            this.txtQty.BeforeTouchSize = new System.Drawing.Size(220, 33);
            this.txtQty.BorderColor = System.Drawing.Color.DimGray;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.CurrencySymbol = "";
            this.txtQty.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(60, 629);
            this.txtQty.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQty.Name = "txtQty";
            this.txtQty.NullString = "";
            this.txtQty.Size = new System.Drawing.Size(82, 25);
            this.txtQty.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQty.TabIndex = 117;
            this.txtQty.Text = "0,00";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(22, 629);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 25);
            this.Label5.TabIndex = 116;
            this.Label5.Text = "QTY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Jenis Obat";
            // 
            // cmbJenisObat
            // 
            this.cmbJenisObat.FormattingEnabled = true;
            this.cmbJenisObat.Location = new System.Drawing.Point(431, 6);
            this.cmbJenisObat.Name = "cmbJenisObat";
            this.cmbJenisObat.Size = new System.Drawing.Size(185, 21);
            this.cmbJenisObat.TabIndex = 13;
            this.cmbJenisObat.SelectedIndexChanged += new System.EventHandler(this.cmbJenisObat_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExportExcel.Location = new System.Drawing.Point(1110, 6);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(101, 48);
            this.btnExportExcel.TabIndex = 12;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sampai Tanggal";
            // 
            // dtTanggalAkhir
            // 
            this.dtTanggalAkhir.CustomFormat = "dd MMMM yyyy";
            this.dtTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggalAkhir.Location = new System.Drawing.Point(205, 32);
            this.dtTanggalAkhir.Name = "dtTanggalAkhir";
            this.dtTanggalAkhir.Size = new System.Drawing.Size(140, 22);
            this.dtTanggalAkhir.TabIndex = 10;
            this.dtTanggalAkhir.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtTanggalAkhir.ValueChanged += new System.EventHandler(this.dtTanggalAkhir_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dari Tanggal";
            // 
            // dtTanggalAwal
            // 
            this.dtTanggalAwal.CustomFormat = "dd MMMM yyyy";
            this.dtTanggalAwal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggalAwal.Location = new System.Drawing.Point(205, 6);
            this.dtTanggalAwal.Name = "dtTanggalAwal";
            this.dtTanggalAwal.Size = new System.Drawing.Size(140, 22);
            this.dtTanggalAwal.TabIndex = 8;
            this.dtTanggalAwal.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtTanggalAwal.ValueChanged += new System.EventHandler(this.dtTanggal_ValueChanged);
            // 
            // DGPesanan
            // 
            this.DGPesanan.AllowUserToAddRows = false;
            this.DGPesanan.AllowUserToDeleteRows = false;
            this.DGPesanan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBarangEdit});
            this.DGPesanan.Location = new System.Drawing.Point(4, 60);
            this.DGPesanan.Name = "DGPesanan";
            this.DGPesanan.ReadOnly = true;
            this.DGPesanan.Size = new System.Drawing.Size(1204, 559);
            this.DGPesanan.TabIndex = 7;
            // 
            // btnBarangEdit
            // 
            this.btnBarangEdit.HeaderText = "Aksi";
            this.btnBarangEdit.Name = "btnBarangEdit";
            this.btnBarangEdit.ReadOnly = true;
            this.btnBarangEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBarangEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBarangEdit.Width = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(4, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 5);
            this.panel1.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(355, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Cari Pesanan";
            // 
            // txtCariPesanan
            // 
            this.txtCariPesanan.BackColor = System.Drawing.SystemColors.Info;
            this.txtCariPesanan.Location = new System.Drawing.Point(431, 32);
            this.txtCariPesanan.Name = "txtCariPesanan";
            this.txtCariPesanan.Size = new System.Drawing.Size(185, 20);
            this.txtCariPesanan.TabIndex = 2;
            this.txtCariPesanan.TextChanged += new System.EventHandler(this.txtCariPesanan_TextChanged);
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.btnTambahPesanan.FlatAppearance.BorderSize = 0;
            this.btnTambahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahPesanan.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTambahPesanan.Location = new System.Drawing.Point(6, 4);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.Size = new System.Drawing.Size(101, 48);
            this.btnTambahPesanan.TabIndex = 1;
            this.btnTambahPesanan.Text = "Entry Pesanan";
            this.btnTambahPesanan.UseVisualStyleBackColor = false;
            this.btnTambahPesanan.Click += new System.EventHandler(this.btnTambahPesanan_Click);
            // 
            // formPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 693);
            this.Controls.Add(this.bfCardFormGudang);
            this.Controls.Add(this.panelTopSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPesanan";
            this.Load += new System.EventHandler(this.formPesanan_Load);
            this.panelTopSlide.ResumeLayout(false);
            this.panelTopSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.bfCardFormGudang.ResumeLayout(false);
            this.bfCardFormGudang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlHargaBeliPPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlHargaBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJmlPotongan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSlide;
        private System.Windows.Forms.Label lblJudulForm;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuCards bfCardFormGudang;
        private System.Windows.Forms.DataGridView DGPesanan;
        private System.Windows.Forms.DataGridViewButtonColumn btnBarangEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCariPesanan;
        private System.Windows.Forms.Button btnTambahPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTanggalAwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTanggalAkhir;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbJenisObat;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtTotalHarga;
        internal System.Windows.Forms.Label label4;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtQty;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel2;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtJmlHargaBeliPPN;
        internal System.Windows.Forms.Label label8;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtJmlHargaBeli;
        internal System.Windows.Forms.Label label7;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtJmlPotongan;
        internal System.Windows.Forms.Label label6;
    }
}