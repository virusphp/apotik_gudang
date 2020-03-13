namespace CrudAwal
{
    partial class formPegawai
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
            this.groupFarmasi = new System.Windows.Forms.GroupBox();
            this.txtHAKAKSES = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.txtKDKASIR = new System.Windows.Forms.TextBox();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGPegawai = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCARI = new System.Windows.Forms.Button();
            this.txtCARIPEGAWAI = new System.Windows.Forms.TextBox();
            this.DGFarmasi = new System.Windows.Forms.DataGridView();
            this.txtCARIFARMASI = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupFarmasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFarmasi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFarmasi
            // 
            this.groupFarmasi.Controls.Add(this.txtHAKAKSES);
            this.groupFarmasi.Controls.Add(this.label7);
            this.groupFarmasi.Controls.Add(this.btnHapus);
            this.groupFarmasi.Controls.Add(this.btnBatal);
            this.groupFarmasi.Controls.Add(this.btnUpdate);
            this.groupFarmasi.Controls.Add(this.button1);
            this.groupFarmasi.Controls.Add(this.txtPASS);
            this.groupFarmasi.Controls.Add(this.txtKDKASIR);
            this.groupFarmasi.Controls.Add(this.txtNAMA);
            this.groupFarmasi.Controls.Add(this.txtUID);
            this.groupFarmasi.Controls.Add(this.label4);
            this.groupFarmasi.Controls.Add(this.label3);
            this.groupFarmasi.Controls.Add(this.label2);
            this.groupFarmasi.Controls.Add(this.label1);
            this.groupFarmasi.Location = new System.Drawing.Point(15, 20);
            this.groupFarmasi.Name = "groupFarmasi";
            this.groupFarmasi.Size = new System.Drawing.Size(247, 238);
            this.groupFarmasi.TabIndex = 0;
            this.groupFarmasi.TabStop = false;
            this.groupFarmasi.Text = "Data Pegawai";
            // 
            // txtHAKAKSES
            // 
            this.txtHAKAKSES.Location = new System.Drawing.Point(89, 173);
            this.txtHAKAKSES.Name = "txtHAKAKSES";
            this.txtHAKAKSES.Size = new System.Drawing.Size(152, 20);
            this.txtHAKAKSES.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hak Akses";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(125, 209);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(55, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(186, 209);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(55, 23);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(64, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(7, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSimpan);
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(89, 140);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(152, 20);
            this.txtPASS.TabIndex = 7;
            // 
            // txtKDKASIR
            // 
            this.txtKDKASIR.Location = new System.Drawing.Point(89, 107);
            this.txtKDKASIR.Name = "txtKDKASIR";
            this.txtKDKASIR.Size = new System.Drawing.Size(152, 20);
            this.txtKDKASIR.TabIndex = 6;
            this.txtKDKASIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKDKASIR_KeyPress);
            // 
            // txtNAMA
            // 
            this.txtNAMA.Location = new System.Drawing.Point(89, 76);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(152, 20);
            this.txtNAMA.TabIndex = 5;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(89, 39);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(152, 20);
            this.txtUID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Kasir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // DGPegawai
            // 
            this.DGPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPegawai.Location = new System.Drawing.Point(278, 48);
            this.DGPegawai.Name = "DGPegawai";
            this.DGPegawai.Size = new System.Drawing.Size(311, 210);
            this.DGPegawai.TabIndex = 1;
            this.DGPegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridPegawai_CellClick);
            this.DGPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPegawai_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "DATA PEGAWAI";
            // 
            // btnCARI
            // 
            this.btnCARI.Location = new System.Drawing.Point(555, 22);
            this.btnCARI.Name = "btnCARI";
            this.btnCARI.Size = new System.Drawing.Size(35, 23);
            this.btnCARI.TabIndex = 3;
            this.btnCARI.Text = "Cari";
            this.btnCARI.UseVisualStyleBackColor = true;
            this.btnCARI.Click += new System.EventHandler(this.btnCARI_Click);
            // 
            // txtCARIPEGAWAI
            // 
            this.txtCARIPEGAWAI.Location = new System.Drawing.Point(418, 22);
            this.txtCARIPEGAWAI.Name = "txtCARIPEGAWAI";
            this.txtCARIPEGAWAI.Size = new System.Drawing.Size(131, 20);
            this.txtCARIPEGAWAI.TabIndex = 4;
            this.txtCARIPEGAWAI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            this.txtCARIPEGAWAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCARI_KeyPress);
            // 
            // DGFarmasi
            // 
            this.DGFarmasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFarmasi.Location = new System.Drawing.Point(609, 48);
            this.DGFarmasi.Name = "DGFarmasi";
            this.DGFarmasi.Size = new System.Drawing.Size(320, 210);
            this.DGFarmasi.TabIndex = 5;
            // 
            // txtCARIFARMASI
            // 
            this.txtCARIFARMASI.Location = new System.Drawing.Point(756, 22);
            this.txtCARIFARMASI.Name = "txtCARIFARMASI";
            this.txtCARIFARMASI.Size = new System.Drawing.Size(131, 20);
            this.txtCARIFARMASI.TabIndex = 7;
            this.txtCARIFARMASI.TextChanged += new System.EventHandler(this.txtCARIFARMASI_TextChanged);
            this.txtCARIFARMASI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCARIFARMASI_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(893, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "DATA LOGIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(819, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Operator";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(866, 264);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(10, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "-";
            // 
            // formPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 283);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCARIFARMASI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGFarmasi);
            this.Controls.Add(this.txtCARIPEGAWAI);
            this.Controls.Add(this.btnCARI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGPegawai);
            this.Controls.Add(this.groupFarmasi);
            this.Name = "formPegawai";
            this.Text = "Data Pegawai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPegawai_FormClosed);
            this.Load += new System.EventHandler(this.FormCRUD_Load);
            this.groupFarmasi.ResumeLayout(false);
            this.groupFarmasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFarmasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFarmasi;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.TextBox txtKDKASIR;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGPegawai;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCARI;
        private System.Windows.Forms.TextBox txtCARIPEGAWAI;
        private System.Windows.Forms.DataGridView DGFarmasi;
        private System.Windows.Forms.TextBox txtCARIFARMASI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHAKAKSES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUser;
    }
}

