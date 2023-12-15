
namespace PROGRA3_CAJR
{
    partial class FRMCONFIG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCONFIG));
            this.lblSelecciona = new System.Windows.Forms.Label();
            this.lblPrevisualizacion = new System.Windows.Forms.Label();
            this.CboTemas = new System.Windows.Forms.ComboBox();
            this.lblTemas = new System.Windows.Forms.Label();
            this.ApliTema = new System.Windows.Forms.Button();
            this.picPrimera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPrimera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecciona
            // 
            this.lblSelecciona.AutoSize = true;
            this.lblSelecciona.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecciona.Location = new System.Drawing.Point(39, 82);
            this.lblSelecciona.Name = "lblSelecciona";
            this.lblSelecciona.Size = new System.Drawing.Size(119, 22);
            this.lblSelecciona.TabIndex = 0;
            this.lblSelecciona.Text = "Selecciona:";
            // 
            // lblPrevisualizacion
            // 
            this.lblPrevisualizacion.AutoSize = true;
            this.lblPrevisualizacion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisualizacion.Location = new System.Drawing.Point(309, 60);
            this.lblPrevisualizacion.Name = "lblPrevisualizacion";
            this.lblPrevisualizacion.Size = new System.Drawing.Size(170, 22);
            this.lblPrevisualizacion.TabIndex = 1;
            this.lblPrevisualizacion.Text = "Previsualizacion:";
            // 
            // CboTemas
            // 
            this.CboTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTemas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTemas.FormattingEnabled = true;
            this.CboTemas.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.CboTemas.Location = new System.Drawing.Point(43, 116);
            this.CboTemas.Name = "CboTemas";
            this.CboTemas.Size = new System.Drawing.Size(159, 27);
            this.CboTemas.TabIndex = 2;
            this.CboTemas.SelectedIndexChanged += new System.EventHandler(this.CboTemas_SelectedIndexChanged_1);
            // 
            // lblTemas
            // 
            this.lblTemas.AutoSize = true;
            this.lblTemas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemas.Location = new System.Drawing.Point(39, 26);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(72, 22);
            this.lblTemas.TabIndex = 4;
            this.lblTemas.Text = "Temas";
            this.lblTemas.Click += new System.EventHandler(this.lblTemas_Click);
            // 
            // ApliTema
            // 
            this.ApliTema.Location = new System.Drawing.Point(43, 183);
            this.ApliTema.Name = "ApliTema";
            this.ApliTema.Size = new System.Drawing.Size(122, 52);
            this.ApliTema.TabIndex = 7;
            this.ApliTema.Text = "Aplicar Tema";
            this.ApliTema.UseVisualStyleBackColor = true;
            this.ApliTema.Click += new System.EventHandler(this.ApliTema_Click);
            // 
            // picPrimera
            // 
            this.picPrimera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPrimera.Image = ((System.Drawing.Image)(resources.GetObject("picPrimera.Image")));
            this.picPrimera.Location = new System.Drawing.Point(247, 97);
            this.picPrimera.Name = "picPrimera";
            this.picPrimera.Size = new System.Drawing.Size(291, 138);
            this.picPrimera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrimera.TabIndex = 6;
            this.picPrimera.TabStop = false;
            this.picPrimera.Click += new System.EventHandler(this.picPrimera_Click);
            // 
            // FRMCONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 288);
            this.Controls.Add(this.ApliTema);
            this.Controls.Add(this.picPrimera);
            this.Controls.Add(this.lblTemas);
            this.Controls.Add(this.CboTemas);
            this.Controls.Add(this.lblPrevisualizacion);
            this.Controls.Add(this.lblSelecciona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMCONFIG";
            this.Text = "Configuracion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMCONFIG_FormClosed);
            this.Load += new System.EventHandler(this.FRMCONFIG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrimera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecciona;
        private System.Windows.Forms.Label lblPrevisualizacion;
        private System.Windows.Forms.ComboBox CboTemas;
        private System.Windows.Forms.Label lblTemas;
        private System.Windows.Forms.PictureBox picPrimera;
        private System.Windows.Forms.Button ApliTema;
    }
}