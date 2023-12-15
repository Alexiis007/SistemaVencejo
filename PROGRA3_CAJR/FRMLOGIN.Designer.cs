
namespace PROGRA3_CAJR
{
    partial class FRMLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMLOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ibtn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.ibtn_Close = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(201)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 450);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-28, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Usuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Usuario.Location = new System.Drawing.Point(428, 207);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(250, 27);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.Text = "USUARIO";
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Contraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Contraseña.Location = new System.Drawing.Point(428, 277);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(250, 27);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.Text = "CONTRASEÑA";
            this.txt_Contraseña.TextChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Usuario_Enter);
            this.txt_Contraseña.Leave += new System.EventHandler(this.txt_Usuario_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Location = new System.Drawing.Point(474, 335);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(156, 43);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Iniciar Sesion";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(453, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "A olvidado su contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(473, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ibtn_Minimizar
            // 
            this.ibtn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_Minimizar.FlatAppearance.BorderSize = 0;
            this.ibtn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Minimizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibtn_Minimizar.IconColor = System.Drawing.Color.Black;
            this.ibtn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Minimizar.IconSize = 30;
            this.ibtn_Minimizar.Location = new System.Drawing.Point(728, -4);
            this.ibtn_Minimizar.Name = "ibtn_Minimizar";
            this.ibtn_Minimizar.Size = new System.Drawing.Size(35, 23);
            this.ibtn_Minimizar.TabIndex = 4;
            this.ibtn_Minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Minimizar.UseVisualStyleBackColor = false;
            this.ibtn_Minimizar.Click += new System.EventHandler(this.ibtn_Minimizar_Click);
            // 
            // ibtn_Close
            // 
            this.ibtn_Close.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_Close.FlatAppearance.BorderSize = 0;
            this.ibtn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ibtn_Close.IconColor = System.Drawing.Color.Black;
            this.ibtn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Close.IconSize = 30;
            this.ibtn_Close.Location = new System.Drawing.Point(767, 2);
            this.ibtn_Close.Name = "ibtn_Close";
            this.ibtn_Close.Size = new System.Drawing.Size(31, 23);
            this.ibtn_Close.TabIndex = 5;
            this.ibtn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Close.UseVisualStyleBackColor = false;
            this.ibtn_Close.Click += new System.EventHandler(this.ibtn_Close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMLOGIN
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ibtn_Close);
            this.Controls.Add(this.ibtn_Minimizar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMLOGIN";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMLOGIN";
            this.Load += new System.EventHandler(this.FRMLOGIN_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRMLOGIN_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton ibtn_Minimizar;
        private FontAwesome.Sharp.IconButton ibtn_Close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}