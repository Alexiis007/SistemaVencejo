
namespace PROGRA3_CAJR
{
    partial class FRMTRABAJOS
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
            this.lbl_TituloTrabajos = new System.Windows.Forms.Label();
            this.GB_TerminarTrabajo = new System.Windows.Forms.GroupBox();
            this.txt_IDTrabajo = new System.Windows.Forms.TextBox();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.lbl_CostoDelTrabajo = new System.Windows.Forms.Label();
            this.btn_FinalizarTrabajo = new System.Windows.Forms.Button();
            this.lbl_Idtrabajo = new System.Windows.Forms.Label();
            this.GB_GenerarTrabajo = new System.Windows.Forms.GroupBox();
            this.lbl_AutoDelCliente = new System.Windows.Forms.Label();
            this.lbl_EmpleadoEncargado = new System.Windows.Forms.Label();
            this.lbl_DescripcionDelTrabajo = new System.Windows.Forms.Label();
            this.lbl_VencejoPIN = new System.Windows.Forms.Label();
            this.cbo_EmpleadoEncargado = new System.Windows.Forms.ComboBox();
            this.cbo_AutosClientes = new System.Windows.Forms.ComboBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.btn_GenerarTrabajo = new System.Windows.Forms.Button();
            this.dgv_Trabajos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_TerminarTrabajo.SuspendLayout();
            this.GB_GenerarTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trabajos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TituloTrabajos
            // 
            this.lbl_TituloTrabajos.AutoSize = true;
            this.lbl_TituloTrabajos.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloTrabajos.Location = new System.Drawing.Point(13, 9);
            this.lbl_TituloTrabajos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TituloTrabajos.Name = "lbl_TituloTrabajos";
            this.lbl_TituloTrabajos.Size = new System.Drawing.Size(292, 41);
            this.lbl_TituloTrabajos.TabIndex = 49;
            this.lbl_TituloTrabajos.Text = "Generar Trabajos.";
            // 
            // GB_TerminarTrabajo
            // 
            this.GB_TerminarTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_TerminarTrabajo.Controls.Add(this.txt_IDTrabajo);
            this.GB_TerminarTrabajo.Controls.Add(this.txt_Costo);
            this.GB_TerminarTrabajo.Controls.Add(this.lbl_CostoDelTrabajo);
            this.GB_TerminarTrabajo.Controls.Add(this.btn_FinalizarTrabajo);
            this.GB_TerminarTrabajo.Controls.Add(this.lbl_Idtrabajo);
            this.GB_TerminarTrabajo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_TerminarTrabajo.Location = new System.Drawing.Point(794, 75);
            this.GB_TerminarTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_TerminarTrabajo.Name = "GB_TerminarTrabajo";
            this.GB_TerminarTrabajo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_TerminarTrabajo.Size = new System.Drawing.Size(375, 319);
            this.GB_TerminarTrabajo.TabIndex = 48;
            this.GB_TerminarTrabajo.TabStop = false;
            this.GB_TerminarTrabajo.Text = "Terminar Trabajo";
            // 
            // txt_IDTrabajo
            // 
            this.txt_IDTrabajo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_IDTrabajo.Location = new System.Drawing.Point(25, 88);
            this.txt_IDTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDTrabajo.Name = "txt_IDTrabajo";
            this.txt_IDTrabajo.Size = new System.Drawing.Size(322, 25);
            this.txt_IDTrabajo.TabIndex = 0;
            // 
            // txt_Costo
            // 
            this.txt_Costo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_Costo.Location = new System.Drawing.Point(25, 189);
            this.txt_Costo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(322, 25);
            this.txt_Costo.TabIndex = 1;
            this.txt_Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Costo_KeyPress);
            // 
            // lbl_CostoDelTrabajo
            // 
            this.lbl_CostoDelTrabajo.AutoSize = true;
            this.lbl_CostoDelTrabajo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_CostoDelTrabajo.Location = new System.Drawing.Point(22, 158);
            this.lbl_CostoDelTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CostoDelTrabajo.Name = "lbl_CostoDelTrabajo";
            this.lbl_CostoDelTrabajo.Size = new System.Drawing.Size(118, 17);
            this.lbl_CostoDelTrabajo.TabIndex = 6;
            this.lbl_CostoDelTrabajo.Text = "Costo Del Trabajo";
            // 
            // btn_FinalizarTrabajo
            // 
            this.btn_FinalizarTrabajo.Location = new System.Drawing.Point(105, 240);
            this.btn_FinalizarTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FinalizarTrabajo.Name = "btn_FinalizarTrabajo";
            this.btn_FinalizarTrabajo.Size = new System.Drawing.Size(173, 51);
            this.btn_FinalizarTrabajo.TabIndex = 2;
            this.btn_FinalizarTrabajo.Text = "Terminar Trabajo";
            this.btn_FinalizarTrabajo.UseVisualStyleBackColor = true;
            this.btn_FinalizarTrabajo.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Idtrabajo
            // 
            this.lbl_Idtrabajo.AutoSize = true;
            this.lbl_Idtrabajo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_Idtrabajo.Location = new System.Drawing.Point(22, 57);
            this.lbl_Idtrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Idtrabajo.Name = "lbl_Idtrabajo";
            this.lbl_Idtrabajo.Size = new System.Drawing.Size(73, 17);
            this.lbl_Idtrabajo.TabIndex = 9;
            this.lbl_Idtrabajo.Text = "ID Trabajo";
            // 
            // GB_GenerarTrabajo
            // 
            this.GB_GenerarTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_GenerarTrabajo.Controls.Add(this.lbl_AutoDelCliente);
            this.GB_GenerarTrabajo.Controls.Add(this.lbl_EmpleadoEncargado);
            this.GB_GenerarTrabajo.Controls.Add(this.lbl_DescripcionDelTrabajo);
            this.GB_GenerarTrabajo.Controls.Add(this.lbl_VencejoPIN);
            this.GB_GenerarTrabajo.Controls.Add(this.cbo_EmpleadoEncargado);
            this.GB_GenerarTrabajo.Controls.Add(this.cbo_AutosClientes);
            this.GB_GenerarTrabajo.Controls.Add(this.txt_Descripcion);
            this.GB_GenerarTrabajo.Controls.Add(this.txt_IdCliente);
            this.GB_GenerarTrabajo.Controls.Add(this.btn_GenerarTrabajo);
            this.GB_GenerarTrabajo.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_GenerarTrabajo.Location = new System.Drawing.Point(13, 75);
            this.GB_GenerarTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_GenerarTrabajo.Name = "GB_GenerarTrabajo";
            this.GB_GenerarTrabajo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_GenerarTrabajo.Size = new System.Drawing.Size(755, 319);
            this.GB_GenerarTrabajo.TabIndex = 47;
            this.GB_GenerarTrabajo.TabStop = false;
            this.GB_GenerarTrabajo.Text = "Generar Nuevo Trabajo";
            // 
            // lbl_AutoDelCliente
            // 
            this.lbl_AutoDelCliente.AutoSize = true;
            this.lbl_AutoDelCliente.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_AutoDelCliente.Location = new System.Drawing.Point(489, 39);
            this.lbl_AutoDelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AutoDelCliente.Name = "lbl_AutoDelCliente";
            this.lbl_AutoDelCliente.Size = new System.Drawing.Size(109, 17);
            this.lbl_AutoDelCliente.TabIndex = 10;
            this.lbl_AutoDelCliente.Text = "Auto Del Cliente";
            // 
            // lbl_EmpleadoEncargado
            // 
            this.lbl_EmpleadoEncargado.AutoSize = true;
            this.lbl_EmpleadoEncargado.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_EmpleadoEncargado.Location = new System.Drawing.Point(33, 114);
            this.lbl_EmpleadoEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmpleadoEncargado.Name = "lbl_EmpleadoEncargado";
            this.lbl_EmpleadoEncargado.Size = new System.Drawing.Size(142, 17);
            this.lbl_EmpleadoEncargado.TabIndex = 8;
            this.lbl_EmpleadoEncargado.Text = "Empleado Encargado";
            // 
            // lbl_DescripcionDelTrabajo
            // 
            this.lbl_DescripcionDelTrabajo.AutoSize = true;
            this.lbl_DescripcionDelTrabajo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_DescripcionDelTrabajo.Location = new System.Drawing.Point(31, 198);
            this.lbl_DescripcionDelTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DescripcionDelTrabajo.Name = "lbl_DescripcionDelTrabajo";
            this.lbl_DescripcionDelTrabajo.Size = new System.Drawing.Size(152, 17);
            this.lbl_DescripcionDelTrabajo.TabIndex = 7;
            this.lbl_DescripcionDelTrabajo.Text = "Descripcion Del Trabajo";
            // 
            // lbl_VencejoPIN
            // 
            this.lbl_VencejoPIN.AutoSize = true;
            this.lbl_VencejoPIN.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.lbl_VencejoPIN.Location = new System.Drawing.Point(32, 41);
            this.lbl_VencejoPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VencejoPIN.Name = "lbl_VencejoPIN";
            this.lbl_VencejoPIN.Size = new System.Drawing.Size(79, 17);
            this.lbl_VencejoPIN.TabIndex = 5;
            this.lbl_VencejoPIN.Text = "VencejoNIP";
            // 
            // cbo_EmpleadoEncargado
            // 
            this.cbo_EmpleadoEncargado.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbo_EmpleadoEncargado.FormattingEnabled = true;
            this.cbo_EmpleadoEncargado.Location = new System.Drawing.Point(37, 145);
            this.cbo_EmpleadoEncargado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_EmpleadoEncargado.Name = "cbo_EmpleadoEncargado";
            this.cbo_EmpleadoEncargado.Size = new System.Drawing.Size(193, 25);
            this.cbo_EmpleadoEncargado.TabIndex = 2;
            // 
            // cbo_AutosClientes
            // 
            this.cbo_AutosClientes.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbo_AutosClientes.FormattingEnabled = true;
            this.cbo_AutosClientes.Location = new System.Drawing.Point(492, 70);
            this.cbo_AutosClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_AutosClientes.Name = "cbo_AutosClientes";
            this.cbo_AutosClientes.Size = new System.Drawing.Size(193, 25);
            this.cbo_AutosClientes.TabIndex = 1;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_Descripcion.Location = new System.Drawing.Point(35, 228);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(650, 81);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdCliente.Location = new System.Drawing.Point(36, 72);
            this.txt_IdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(194, 25);
            this.txt_IdCliente.TabIndex = 0;
            this.txt_IdCliente.TextChanged += new System.EventHandler(this.txt_IdCliente_TextChanged);
            // 
            // btn_GenerarTrabajo
            // 
            this.btn_GenerarTrabajo.Location = new System.Drawing.Point(492, 137);
            this.btn_GenerarTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerarTrabajo.Name = "btn_GenerarTrabajo";
            this.btn_GenerarTrabajo.Size = new System.Drawing.Size(193, 36);
            this.btn_GenerarTrabajo.TabIndex = 4;
            this.btn_GenerarTrabajo.Text = "Generar Trabajo";
            this.btn_GenerarTrabajo.UseVisualStyleBackColor = true;
            this.btn_GenerarTrabajo.Click += new System.EventHandler(this.btn_IngresarTrabajo_Click);
            // 
            // dgv_Trabajos
            // 
            this.dgv_Trabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Trabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Trabajos.Location = new System.Drawing.Point(13, 16);
            this.dgv_Trabajos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Trabajos.Name = "dgv_Trabajos";
            this.dgv_Trabajos.ReadOnly = true;
            this.dgv_Trabajos.Size = new System.Drawing.Size(1156, 181);
            this.dgv_Trabajos.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Trabajos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 222);
            this.panel1.TabIndex = 50;
            // 
            // FRMTRABAJOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_TituloTrabajos);
            this.Controls.Add(this.GB_TerminarTrabajo);
            this.Controls.Add(this.GB_GenerarTrabajo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMTRABAJOS";
            this.Text = "FRMVENTAS";
            this.Load += new System.EventHandler(this.FRMVENTAS_Load);
            this.GB_TerminarTrabajo.ResumeLayout(false);
            this.GB_TerminarTrabajo.PerformLayout();
            this.GB_GenerarTrabajo.ResumeLayout(false);
            this.GB_GenerarTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trabajos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TituloTrabajos;
        private System.Windows.Forms.GroupBox GB_TerminarTrabajo;
        private System.Windows.Forms.TextBox txt_IDTrabajo;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.Label lbl_CostoDelTrabajo;
        private System.Windows.Forms.Button btn_FinalizarTrabajo;
        private System.Windows.Forms.Label lbl_Idtrabajo;
        private System.Windows.Forms.GroupBox GB_GenerarTrabajo;
        private System.Windows.Forms.Label lbl_AutoDelCliente;
        private System.Windows.Forms.Label lbl_EmpleadoEncargado;
        private System.Windows.Forms.Label lbl_DescripcionDelTrabajo;
        private System.Windows.Forms.Label lbl_VencejoPIN;
        private System.Windows.Forms.ComboBox cbo_EmpleadoEncargado;
        private System.Windows.Forms.ComboBox cbo_AutosClientes;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Button btn_GenerarTrabajo;
        private System.Windows.Forms.DataGridView dgv_Trabajos;
        private System.Windows.Forms.Panel panel1;
    }
}