
namespace PROGRA3_CAJR
{
    partial class FRMRECUPERAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRECUPERAR));
            this.lbl_CorreoUsuario = new System.Windows.Forms.Label();
            this.txt_CorreoUsuario = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibtn_Close = new FontAwesome.Sharp.IconButton();
            this.ibtn_Minimizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CorreoUsuario
            // 
            this.lbl_CorreoUsuario.AutoSize = true;
            this.lbl_CorreoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_CorreoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_CorreoUsuario.Location = new System.Drawing.Point(26, 38);
            this.lbl_CorreoUsuario.Name = "lbl_CorreoUsuario";
            this.lbl_CorreoUsuario.Size = new System.Drawing.Size(317, 19);
            this.lbl_CorreoUsuario.TabIndex = 0;
            this.lbl_CorreoUsuario.Text = "Nombre de usuario o correo electronico";
            this.lbl_CorreoUsuario.Click += new System.EventHandler(this.lbl_CorreoUsuario_Click);
            // 
            // txt_CorreoUsuario
            // 
            this.txt_CorreoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CorreoUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_CorreoUsuario.Location = new System.Drawing.Point(52, 115);
            this.txt_CorreoUsuario.Name = "txt_CorreoUsuario";
            this.txt_CorreoUsuario.Size = new System.Drawing.Size(265, 27);
            this.txt_CorreoUsuario.TabIndex = 3;
            this.txt_CorreoUsuario.Text = "Correo";
            this.txt_CorreoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Enviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Enviar.FlatAppearance.BorderSize = 0;
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Enviar.ForeColor = System.Drawing.Color.White;
            this.btn_Enviar.Location = new System.Drawing.Point(0, 0);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(365, 47);
            this.btn_Enviar.TabIndex = 4;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 90;
            this.iconPictureBox1.Location = new System.Drawing.Point(140, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 90);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.ibtn_Close);
            this.panel1.Controls.Add(this.ibtn_Minimizar);
            this.panel1.Controls.Add(this.lbl_CorreoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 77);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btn_Enviar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 47);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.txt_CorreoUsuario);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 168);
            this.panel3.TabIndex = 8;
            // 
            // ibtn_Close
            // 
            this.ibtn_Close.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_Close.FlatAppearance.BorderSize = 0;
            this.ibtn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ibtn_Close.IconColor = System.Drawing.Color.White;
            this.ibtn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Close.IconSize = 30;
            this.ibtn_Close.Location = new System.Drawing.Point(331, 3);
            this.ibtn_Close.Name = "ibtn_Close";
            this.ibtn_Close.Size = new System.Drawing.Size(31, 23);
            this.ibtn_Close.TabIndex = 7;
            this.ibtn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Close.UseVisualStyleBackColor = false;
            this.ibtn_Close.Click += new System.EventHandler(this.ibtn_Close_Click_1);
            // 
            // ibtn_Minimizar
            // 
            this.ibtn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_Minimizar.FlatAppearance.BorderSize = 0;
            this.ibtn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Minimizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibtn_Minimizar.IconColor = System.Drawing.Color.White;
            this.ibtn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Minimizar.IconSize = 30;
            this.ibtn_Minimizar.Location = new System.Drawing.Point(292, -3);
            this.ibtn_Minimizar.Name = "ibtn_Minimizar";
            this.ibtn_Minimizar.Size = new System.Drawing.Size(35, 23);
            this.ibtn_Minimizar.TabIndex = 6;
            this.ibtn_Minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Minimizar.UseVisualStyleBackColor = false;
            this.ibtn_Minimizar.Click += new System.EventHandler(this.ibtn_Minimizar_Click_1);
            // 
            // FRMRECUPERAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 292);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMRECUPERAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMRECUPERAR";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CorreoUsuario;
        private System.Windows.Forms.TextBox txt_CorreoUsuario;
        private System.Windows.Forms.Button btn_Enviar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibtn_Close;
        private FontAwesome.Sharp.IconButton ibtn_Minimizar;
    }
}