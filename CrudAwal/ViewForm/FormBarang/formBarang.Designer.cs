namespace CrudAwal.ViewForm.FormBarang
{
    partial class formBarang
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
            this.panelTopSlide = new System.Windows.Forms.Panel();
            this.lblJudulForm = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifunBtnEnterBarang = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bfCardFormBarang = new Bunifu.Framework.UI.BunifuCards();
            this.btnTambahBarang = new System.Windows.Forms.Button();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbStatusBarang = new System.Windows.Forms.ComboBox();
            this.DGMasterBarang = new System.Windows.Forms.DataGridView();
            this.btnBarangEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlFormBarang = new System.Windows.Forms.Panel();
            this.panelTopSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.bfCardFormBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMasterBarang)).BeginInit();
            this.pnlFormBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSlide
            // 
            this.panelTopSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panelTopSlide.Controls.Add(this.lblJudulForm);
            this.panelTopSlide.Controls.Add(this.picMin);
            this.panelTopSlide.Controls.Add(this.picMax);
            this.panelTopSlide.Controls.Add(this.picClose);
            this.panelTopSlide.Controls.Add(this.panel6);
            this.panelTopSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSlide.Location = new System.Drawing.Point(0, 0);
            this.panelTopSlide.Name = "panelTopSlide";
            this.panelTopSlide.Size = new System.Drawing.Size(883, 30);
            this.panelTopSlide.TabIndex = 2;
            // 
            // lblJudulForm
            // 
            this.lblJudulForm.AutoSize = true;
            this.lblJudulForm.Font = new System.Drawing.Font("Fira Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulForm.Location = new System.Drawing.Point(381, 6);
            this.lblJudulForm.Name = "lblJudulForm";
            this.lblJudulForm.Size = new System.Drawing.Size(70, 15);
            this.lblJudulForm.TabIndex = 7;
            this.lblJudulForm.Text = "Judul Form";
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = global::CrudAwal.Properties.Resources.max_min_button;
            this.picMin.Location = new System.Drawing.Point(809, 6);
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
            this.picMax.Location = new System.Drawing.Point(833, 6);
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
            this.picClose.Location = new System.Drawing.Point(857, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(680, 468);
            this.panel6.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTopSlide;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifunBtnEnterBarang
            // 
            this.bunifunBtnEnterBarang.ElipseRadius = 10;
            this.bunifunBtnEnterBarang.TargetControl = this.btnTambahBarang;
            // 
            // bfCardFormBarang
            // 
            this.bfCardFormBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bfCardFormBarang.BackColor = System.Drawing.Color.White;
            this.bfCardFormBarang.BorderRadius = 5;
            this.bfCardFormBarang.BottomSahddow = true;
            this.bfCardFormBarang.color = System.Drawing.Color.White;
            this.bfCardFormBarang.Controls.Add(this.DGMasterBarang);
            this.bfCardFormBarang.Controls.Add(this.cmbStatusBarang);
            this.bfCardFormBarang.Controls.Add(this.label31);
            this.bfCardFormBarang.Controls.Add(this.panel1);
            this.bfCardFormBarang.Controls.Add(this.label30);
            this.bfCardFormBarang.Controls.Add(this.txtCariBarang);
            this.bfCardFormBarang.Controls.Add(this.btnTambahBarang);
            this.bfCardFormBarang.LeftSahddow = false;
            this.bfCardFormBarang.Location = new System.Drawing.Point(11, 8);
            this.bfCardFormBarang.Name = "bfCardFormBarang";
            this.bfCardFormBarang.RightSahddow = true;
            this.bfCardFormBarang.ShadowDepth = 20;
            this.bfCardFormBarang.Size = new System.Drawing.Size(865, 439);
            this.bfCardFormBarang.TabIndex = 0;
            // 
            // btnTambahBarang
            // 
            this.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.btnTambahBarang.FlatAppearance.BorderSize = 0;
            this.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBarang.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBarang.Location = new System.Drawing.Point(6, 4);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(101, 23);
            this.btnTambahBarang.TabIndex = 1;
            this.btnTambahBarang.Text = "Entry Barang";
            this.btnTambahBarang.UseVisualStyleBackColor = false;
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.BackColor = System.Drawing.SystemColors.Info;
            this.txtCariBarang.Location = new System.Drawing.Point(435, 6);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(229, 20);
            this.txtCariBarang.TabIndex = 2;
            this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(367, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Cari Barang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(-1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 5);
            this.panel1.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(686, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 5;
            this.label31.Text = "Filter Status";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // cmbStatusBarang
            // 
            this.cmbStatusBarang.FormattingEnabled = true;
            this.cmbStatusBarang.Items.AddRange(new object[] {
            "Aktif",
            "Non Aktif"});
            this.cmbStatusBarang.Location = new System.Drawing.Point(754, 5);
            this.cmbStatusBarang.Name = "cmbStatusBarang";
            this.cmbStatusBarang.Size = new System.Drawing.Size(100, 21);
            this.cmbStatusBarang.TabIndex = 6;
            this.cmbStatusBarang.SelectedIndexChanged += new System.EventHandler(this.cmbStatusBarang_SelectedIndexChanged);
            // 
            // DGMasterBarang
            // 
            this.DGMasterBarang.AllowUserToAddRows = false;
            this.DGMasterBarang.AllowUserToDeleteRows = false;
            this.DGMasterBarang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGMasterBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGMasterBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMasterBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBarangEdit});
            this.DGMasterBarang.Location = new System.Drawing.Point(-1, 38);
            this.DGMasterBarang.Name = "DGMasterBarang";
            this.DGMasterBarang.ReadOnly = true;
            this.DGMasterBarang.Size = new System.Drawing.Size(862, 403);
            this.DGMasterBarang.TabIndex = 7;
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
            // pnlFormBarang
            // 
            this.pnlFormBarang.Controls.Add(this.bfCardFormBarang);
            this.pnlFormBarang.Location = new System.Drawing.Point(3, 30);
            this.pnlFormBarang.Name = "pnlFormBarang";
            this.pnlFormBarang.Size = new System.Drawing.Size(880, 465);
            this.pnlFormBarang.TabIndex = 9;
            // 
            // formBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 498);
            this.Controls.Add(this.pnlFormBarang);
            this.Controls.Add(this.panelTopSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formBarang";
            this.Load += new System.EventHandler(this.formBarang_Load);
            this.panelTopSlide.ResumeLayout(false);
            this.panelTopSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.bfCardFormBarang.ResumeLayout(false);
            this.bfCardFormBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMasterBarang)).EndInit();
            this.pnlFormBarang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSlide;
        private System.Windows.Forms.Label lblJudulForm;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifunBtnEnterBarang;
        private System.Windows.Forms.Panel pnlFormBarang;
        private Bunifu.Framework.UI.BunifuCards bfCardFormBarang;
        private System.Windows.Forms.DataGridView DGMasterBarang;
        private System.Windows.Forms.DataGridViewButtonColumn btnBarangEdit;
        private System.Windows.Forms.ComboBox cmbStatusBarang;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCariBarang;
        private System.Windows.Forms.Button btnTambahBarang;
    }
}