namespace CrudAwal.ViewForm.FormLogin
{
    partial class formLogin
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
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnMsk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circlePicture1 = new CrudAwal.Modul.CirclePicture();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MLnip = new MaterialSkin.Controls.MaterialLabel();
            this.MLnama = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "Username";
            this.txtUsername.Location = new System.Drawing.Point(17, 20);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(225, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TabStop = false;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(17, 55);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(225, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(13, 124);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(229, 3);
            this.materialDivider1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "@Copyright 2019";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.pnlLogin.Controls.Add(this.btnMsk);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.materialDivider1);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Location = new System.Drawing.Point(0, 156);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(258, 155);
            this.pnlLogin.TabIndex = 19;
            // 
            // btnMsk
            // 
            this.btnMsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.btnMsk.FlatAppearance.BorderSize = 0;
            this.btnMsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsk.Font = new System.Drawing.Font("Fira Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsk.Location = new System.Drawing.Point(167, 85);
            this.btnMsk.Name = "btnMsk";
            this.btnMsk.Size = new System.Drawing.Size(76, 30);
            this.btnMsk.TabIndex = 3;
            this.btnMsk.Text = "Masuk";
            this.btnMsk.UseVisualStyleBackColor = false;
            this.btnMsk.Click += new System.EventHandler(this.btnMsk_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CrudAwal.Properties.Resources.warna;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.circlePicture1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MLnip);
            this.panel1.Controls.Add(this.MLnama);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 274);
            this.panel1.TabIndex = 21;
            // 
            // circlePicture1
            // 
            this.circlePicture1.BackColor = System.Drawing.Color.Transparent;
            this.circlePicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circlePicture1.Image = global::CrudAwal.Properties.Resources.user1;
            this.circlePicture1.Location = new System.Drawing.Point(7, 40);
            this.circlePicture1.Name = "circlePicture1";
            this.circlePicture1.Size = new System.Drawing.Size(104, 106);
            this.circlePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePicture1.TabIndex = 21;
            this.circlePicture1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(232, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "LOGIN";
            // 
            // MLnip
            // 
            this.MLnip.AutoSize = true;
            this.MLnip.BackColor = System.Drawing.Color.Transparent;
            this.MLnip.Depth = 0;
            this.MLnip.Font = new System.Drawing.Font("Roboto", 11F);
            this.MLnip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MLnip.Location = new System.Drawing.Point(137, 112);
            this.MLnip.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLnip.Name = "MLnip";
            this.MLnip.Size = new System.Drawing.Size(13, 19);
            this.MLnip.TabIndex = 16;
            this.MLnip.Text = "-";
            // 
            // MLnama
            // 
            this.MLnama.AutoSize = true;
            this.MLnama.BackColor = System.Drawing.Color.Transparent;
            this.MLnama.Depth = 0;
            this.MLnama.Font = new System.Drawing.Font("Roboto", 11F);
            this.MLnama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MLnama.Location = new System.Drawing.Point(137, 81);
            this.MLnama.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLnama.Name = "MLnama";
            this.MLnama.Size = new System.Drawing.Size(13, 19);
            this.MLnama.TabIndex = 15;
            this.MLnama.Text = "-";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btnMsk;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(258, 310);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel MLnama;
        private MaterialSkin.Controls.MaterialLabel MLnip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Modul.CirclePicture circlePicture1;
        private System.Windows.Forms.Button btnMsk;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}