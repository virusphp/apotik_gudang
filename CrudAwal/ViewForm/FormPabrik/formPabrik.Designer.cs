namespace CrudAwal.ViewForm.FormPabrik
{
    partial class formPabrik
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.bfCardFormGudang = new Bunifu.Framework.UI.BunifuCards();
            this.DGMasterPabrik = new System.Windows.Forms.DataGridView();
            this.btnBarangEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCariPabrik = new System.Windows.Forms.TextBox();
            this.btnTambahPabrik = new System.Windows.Forms.Button();
            this.panelTopSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel6.SuspendLayout();
            this.bfCardFormGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMasterPabrik)).BeginInit();
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
            this.panelTopSlide.Size = new System.Drawing.Size(883, 30);
            this.panelTopSlide.TabIndex = 6;
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
            this.panel6.Controls.Add(this.bfCardFormGudang);
            this.panel6.Location = new System.Drawing.Point(1, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(880, 445);
            this.panel6.TabIndex = 7;
            // 
            // bfCardFormGudang
            // 
            this.bfCardFormGudang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bfCardFormGudang.BackColor = System.Drawing.Color.White;
            this.bfCardFormGudang.BorderRadius = 5;
            this.bfCardFormGudang.BottomSahddow = true;
            this.bfCardFormGudang.color = System.Drawing.Color.White;
            this.bfCardFormGudang.Controls.Add(this.DGMasterPabrik);
            this.bfCardFormGudang.Controls.Add(this.panel1);
            this.bfCardFormGudang.Controls.Add(this.label30);
            this.bfCardFormGudang.Controls.Add(this.txtCariPabrik);
            this.bfCardFormGudang.Controls.Add(this.btnTambahPabrik);
            this.bfCardFormGudang.LeftSahddow = false;
            this.bfCardFormGudang.Location = new System.Drawing.Point(3, 3);
            this.bfCardFormGudang.Name = "bfCardFormGudang";
            this.bfCardFormGudang.RightSahddow = true;
            this.bfCardFormGudang.ShadowDepth = 20;
            this.bfCardFormGudang.Size = new System.Drawing.Size(877, 439);
            this.bfCardFormGudang.TabIndex = 1;
            // 
            // DGMasterPabrik
            // 
            this.DGMasterPabrik.AllowUserToAddRows = false;
            this.DGMasterPabrik.AllowUserToDeleteRows = false;
            this.DGMasterPabrik.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGMasterPabrik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGMasterPabrik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMasterPabrik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBarangEdit});
            this.DGMasterPabrik.Location = new System.Drawing.Point(6, 45);
            this.DGMasterPabrik.Name = "DGMasterPabrik";
            this.DGMasterPabrik.ReadOnly = true;
            this.DGMasterPabrik.Size = new System.Drawing.Size(866, 391);
            this.DGMasterPabrik.TabIndex = 7;
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
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 10);
            this.panel1.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(367, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Cari Pabrik";
            // 
            // txtCariPabrik
            // 
            this.txtCariPabrik.BackColor = System.Drawing.SystemColors.Info;
            this.txtCariPabrik.Location = new System.Drawing.Point(435, 6);
            this.txtCariPabrik.Name = "txtCariPabrik";
            this.txtCariPabrik.Size = new System.Drawing.Size(439, 20);
            this.txtCariPabrik.TabIndex = 2;
            this.txtCariPabrik.TextChanged += new System.EventHandler(this.txtCariPabrik_TextChanged);
            // 
            // btnTambahPabrik
            // 
            this.btnTambahPabrik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.btnTambahPabrik.FlatAppearance.BorderSize = 0;
            this.btnTambahPabrik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahPabrik.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPabrik.Location = new System.Drawing.Point(6, 4);
            this.btnTambahPabrik.Name = "btnTambahPabrik";
            this.btnTambahPabrik.Size = new System.Drawing.Size(101, 23);
            this.btnTambahPabrik.TabIndex = 1;
            this.btnTambahPabrik.Text = "Entry Pabrik";
            this.btnTambahPabrik.UseVisualStyleBackColor = false;
            // 
            // formPabrik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 498);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelTopSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPabrik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPabrik";
            this.Load += new System.EventHandler(this.formPabrik_Load);
            this.panelTopSlide.ResumeLayout(false);
            this.panelTopSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel6.ResumeLayout(false);
            this.bfCardFormGudang.ResumeLayout(false);
            this.bfCardFormGudang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMasterPabrik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSlide;
        private System.Windows.Forms.Label lblJudulForm;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuCards bfCardFormGudang;
        private System.Windows.Forms.DataGridView DGMasterPabrik;
        private System.Windows.Forms.DataGridViewButtonColumn btnBarangEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCariPabrik;
        private System.Windows.Forms.Button btnTambahPabrik;
    }
}