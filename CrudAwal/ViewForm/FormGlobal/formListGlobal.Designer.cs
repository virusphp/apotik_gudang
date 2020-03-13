namespace CrudAwal.ViewForm.FormGlobal
{
    partial class formListGlobal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopSlide = new System.Windows.Forms.Panel();
            this.lblJudulForm = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGList = new System.Windows.Forms.DataGridView();
            this.btnPilihan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelTopSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGList)).BeginInit();
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
            this.panelTopSlide.Size = new System.Drawing.Size(384, 30);
            this.panelTopSlide.TabIndex = 114;
            // 
            // lblJudulForm
            // 
            this.lblJudulForm.AutoSize = true;
            this.lblJudulForm.Font = new System.Drawing.Font("Fira Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblJudulForm.Location = new System.Drawing.Point(13, 7);
            this.lblJudulForm.Name = "lblJudulForm";
            this.lblJudulForm.Size = new System.Drawing.Size(78, 15);
            this.lblJudulForm.TabIndex = 7;
            this.lblJudulForm.Text = "JUDUL FORM";
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = global::CrudAwal.Properties.Resources.max_min_button;
            this.picMin.Location = new System.Drawing.Point(310, 6);
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
            this.picMax.Location = new System.Drawing.Point(334, 6);
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
            this.picClose.Location = new System.Drawing.Point(358, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtCari);
            this.panel1.Controls.Add(this.lblCari);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 33);
            this.panel1.TabIndex = 116;
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Fira Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(43, 6);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(322, 21);
            this.txtCari.TabIndex = 119;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            this.txtCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Fira Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCari.Location = new System.Drawing.Point(10, 10);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(26, 13);
            this.lblCari.TabIndex = 119;
            this.lblCari.Text = "Cari";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 4);
            this.panel2.TabIndex = 117;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 4);
            this.panel4.TabIndex = 116;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.panel5);
            this.pnlFill.Controls.Add(this.DGList);
            this.pnlFill.Location = new System.Drawing.Point(7, 75);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(372, 376);
            this.pnlFill.TabIndex = 117;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(214)))), ((int)(((byte)(145)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 4);
            this.panel5.TabIndex = 118;
            // 
            // DGList
            // 
            this.DGList.AllowUserToDeleteRows = false;
            this.DGList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnPilihan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGList.Location = new System.Drawing.Point(0, 0);
            this.DGList.Name = "DGList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGList.RowHeadersWidth = 5;
            this.DGList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGList.Size = new System.Drawing.Size(372, 376);
            this.DGList.TabIndex = 87;
            this.DGList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGList_CellContentClick);
            this.DGList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGList_KeyPress);
            // 
            // btnPilihan
            // 
            this.btnPilihan.HeaderText = "Pilih";
            this.btnPilihan.Name = "btnPilihan";
            this.btnPilihan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // formListGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 463);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formListGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formList";
            this.Load += new System.EventHandler(this.formListGlobal_Load);
            this.panelTopSlide.ResumeLayout(false);
            this.panelTopSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopSlide;
        private System.Windows.Forms.Label lblJudulForm;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlFill;
        internal System.Windows.Forms.DataGridView DGList;
        private System.Windows.Forms.DataGridViewButtonColumn btnPilihan;
        private System.Windows.Forms.Panel panel5;
    }
}