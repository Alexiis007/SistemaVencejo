
namespace PROGRA3_CAJR
{
    partial class FRMCLIENTES
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
            this.GB_FiltrarAutos = new System.Windows.Forms.GroupBox();
            this.lbl_FiltrarMatricula = new System.Windows.Forms.Label();
            this.txt_FiltrarMatricula = new System.Windows.Forms.TextBox();
            this.btn_FiltrarAuto = new System.Windows.Forms.Button();
            this.lbl_FiltrarModelo = new System.Windows.Forms.Label();
            this.txt_FiltrarModelo = new System.Windows.Forms.TextBox();
            this.GB_FiltrarClientes = new System.Windows.Forms.GroupBox();
            this.lbl_FiltrarVencejoPIN = new System.Windows.Forms.Label();
            this.txt_FiltrarVencejoPIN = new System.Windows.Forms.TextBox();
            this.btn_FiltrarCliente = new System.Windows.Forms.Button();
            this.lbl_FiltrarPrimerNom = new System.Windows.Forms.Label();
            this.lbl_FiltrarApPaterno = new System.Windows.Forms.Label();
            this.txt_FiltrarPrimerNombre = new System.Windows.Forms.TextBox();
            this.txt_FiltrarPrimerApellido = new System.Windows.Forms.TextBox();
            this.lbl_TituloClientes = new System.Windows.Forms.Label();
            this.dgv_Autos = new System.Windows.Forms.DataGridView();
            this.GB_IngresoAutos = new System.Windows.Forms.GroupBox();
            this.btn_IngresarAuto = new System.Windows.Forms.Button();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_AutosVencejoPIN = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.txt_IDMatricula = new System.Windows.Forms.TextBox();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.GB_IngresoClientes = new System.Windows.Forms.GroupBox();
            this.lbl_NumeroTelefonico = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_ingresarCliente = new System.Windows.Forms.Button();
            this.lbl_PrimerNom = new System.Windows.Forms.Label();
            this.lbl_SegundoNom = new System.Windows.Forms.Label();
            this.txt_PrimerNombre = new System.Windows.Forms.TextBox();
            this.txt_SegundoNombre = new System.Windows.Forms.TextBox();
            this.lbl_ApPaterno = new System.Windows.Forms.Label();
            this.lbl_ApMaterno = new System.Windows.Forms.Label();
            this.txt_PrimerApellido = new System.Windows.Forms.TextBox();
            this.txt_SegundoApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GB_FiltrarAutos.SuspendLayout();
            this.GB_FiltrarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autos)).BeginInit();
            this.GB_IngresoAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.GB_IngresoClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_FiltrarAutos
            // 
            this.GB_FiltrarAutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_FiltrarAutos.Controls.Add(this.lbl_FiltrarMatricula);
            this.GB_FiltrarAutos.Controls.Add(this.txt_FiltrarMatricula);
            this.GB_FiltrarAutos.Controls.Add(this.btn_FiltrarAuto);
            this.GB_FiltrarAutos.Controls.Add(this.lbl_FiltrarModelo);
            this.GB_FiltrarAutos.Controls.Add(this.txt_FiltrarModelo);
            this.GB_FiltrarAutos.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FiltrarAutos.Location = new System.Drawing.Point(486, 7);
            this.GB_FiltrarAutos.Name = "GB_FiltrarAutos";
            this.GB_FiltrarAutos.Size = new System.Drawing.Size(680, 82);
            this.GB_FiltrarAutos.TabIndex = 50;
            this.GB_FiltrarAutos.TabStop = false;
            this.GB_FiltrarAutos.Text = "Filtrar Clientes Por:";
            // 
            // lbl_FiltrarMatricula
            // 
            this.lbl_FiltrarMatricula.AutoSize = true;
            this.lbl_FiltrarMatricula.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarMatricula.Location = new System.Drawing.Point(19, 33);
            this.lbl_FiltrarMatricula.Name = "lbl_FiltrarMatricula";
            this.lbl_FiltrarMatricula.Size = new System.Drawing.Size(66, 17);
            this.lbl_FiltrarMatricula.TabIndex = 40;
            this.lbl_FiltrarMatricula.Text = "Matricula";
            // 
            // txt_FiltrarMatricula
            // 
            this.txt_FiltrarMatricula.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_FiltrarMatricula.Location = new System.Drawing.Point(22, 53);
            this.txt_FiltrarMatricula.Multiline = true;
            this.txt_FiltrarMatricula.Name = "txt_FiltrarMatricula";
            this.txt_FiltrarMatricula.Size = new System.Drawing.Size(182, 20);
            this.txt_FiltrarMatricula.TabIndex = 0;
            // 
            // btn_FiltrarAuto
            // 
            this.btn_FiltrarAuto.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FiltrarAuto.Location = new System.Drawing.Point(436, 40);
            this.btn_FiltrarAuto.Name = "btn_FiltrarAuto";
            this.btn_FiltrarAuto.Size = new System.Drawing.Size(182, 31);
            this.btn_FiltrarAuto.TabIndex = 2;
            this.btn_FiltrarAuto.Text = "Filtrar";
            this.btn_FiltrarAuto.UseVisualStyleBackColor = true;
            this.btn_FiltrarAuto.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_FiltrarModelo
            // 
            this.lbl_FiltrarModelo.AutoSize = true;
            this.lbl_FiltrarModelo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarModelo.Location = new System.Drawing.Point(227, 33);
            this.lbl_FiltrarModelo.Name = "lbl_FiltrarModelo";
            this.lbl_FiltrarModelo.Size = new System.Drawing.Size(54, 17);
            this.lbl_FiltrarModelo.TabIndex = 8;
            this.lbl_FiltrarModelo.Text = "Modelo";
            // 
            // txt_FiltrarModelo
            // 
            this.txt_FiltrarModelo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_FiltrarModelo.Location = new System.Drawing.Point(230, 53);
            this.txt_FiltrarModelo.Multiline = true;
            this.txt_FiltrarModelo.Name = "txt_FiltrarModelo";
            this.txt_FiltrarModelo.Size = new System.Drawing.Size(182, 20);
            this.txt_FiltrarModelo.TabIndex = 1;
            this.txt_FiltrarModelo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // GB_FiltrarClientes
            // 
            this.GB_FiltrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_FiltrarClientes.Controls.Add(this.lbl_FiltrarVencejoPIN);
            this.GB_FiltrarClientes.Controls.Add(this.txt_FiltrarVencejoPIN);
            this.GB_FiltrarClientes.Controls.Add(this.btn_FiltrarCliente);
            this.GB_FiltrarClientes.Controls.Add(this.lbl_FiltrarPrimerNom);
            this.GB_FiltrarClientes.Controls.Add(this.lbl_FiltrarApPaterno);
            this.GB_FiltrarClientes.Controls.Add(this.txt_FiltrarPrimerNombre);
            this.GB_FiltrarClientes.Controls.Add(this.txt_FiltrarPrimerApellido);
            this.GB_FiltrarClientes.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FiltrarClientes.Location = new System.Drawing.Point(684, 71);
            this.GB_FiltrarClientes.Name = "GB_FiltrarClientes";
            this.GB_FiltrarClientes.Size = new System.Drawing.Size(486, 174);
            this.GB_FiltrarClientes.TabIndex = 47;
            this.GB_FiltrarClientes.TabStop = false;
            this.GB_FiltrarClientes.Text = "Filtrar Clientes Por:";
            // 
            // lbl_FiltrarVencejoPIN
            // 
            this.lbl_FiltrarVencejoPIN.AutoSize = true;
            this.lbl_FiltrarVencejoPIN.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarVencejoPIN.Location = new System.Drawing.Point(19, 46);
            this.lbl_FiltrarVencejoPIN.Name = "lbl_FiltrarVencejoPIN";
            this.lbl_FiltrarVencejoPIN.Size = new System.Drawing.Size(83, 17);
            this.lbl_FiltrarVencejoPIN.TabIndex = 40;
            this.lbl_FiltrarVencejoPIN.Text = "Vencejo PIN";
            // 
            // txt_FiltrarVencejoPIN
            // 
            this.txt_FiltrarVencejoPIN.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_FiltrarVencejoPIN.Location = new System.Drawing.Point(22, 66);
            this.txt_FiltrarVencejoPIN.Multiline = true;
            this.txt_FiltrarVencejoPIN.Name = "txt_FiltrarVencejoPIN";
            this.txt_FiltrarVencejoPIN.Size = new System.Drawing.Size(182, 20);
            this.txt_FiltrarVencejoPIN.TabIndex = 0;
            // 
            // btn_FiltrarCliente
            // 
            this.btn_FiltrarCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FiltrarCliente.Location = new System.Drawing.Point(230, 109);
            this.btn_FiltrarCliente.Name = "btn_FiltrarCliente";
            this.btn_FiltrarCliente.Size = new System.Drawing.Size(182, 31);
            this.btn_FiltrarCliente.TabIndex = 3;
            this.btn_FiltrarCliente.Text = "Filtrar";
            this.btn_FiltrarCliente.UseVisualStyleBackColor = true;
            this.btn_FiltrarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_FiltrarPrimerNom
            // 
            this.lbl_FiltrarPrimerNom.AutoSize = true;
            this.lbl_FiltrarPrimerNom.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarPrimerNom.Location = new System.Drawing.Point(19, 98);
            this.lbl_FiltrarPrimerNom.Name = "lbl_FiltrarPrimerNom";
            this.lbl_FiltrarPrimerNom.Size = new System.Drawing.Size(106, 17);
            this.lbl_FiltrarPrimerNom.TabIndex = 13;
            this.lbl_FiltrarPrimerNom.Text = "Primer Nombre";
            // 
            // lbl_FiltrarApPaterno
            // 
            this.lbl_FiltrarApPaterno.AutoSize = true;
            this.lbl_FiltrarApPaterno.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarApPaterno.Location = new System.Drawing.Point(227, 46);
            this.lbl_FiltrarApPaterno.Name = "lbl_FiltrarApPaterno";
            this.lbl_FiltrarApPaterno.Size = new System.Drawing.Size(104, 17);
            this.lbl_FiltrarApPaterno.TabIndex = 8;
            this.lbl_FiltrarApPaterno.Text = "Primer Apellido";
            // 
            // txt_FiltrarPrimerNombre
            // 
            this.txt_FiltrarPrimerNombre.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_FiltrarPrimerNombre.Location = new System.Drawing.Point(22, 120);
            this.txt_FiltrarPrimerNombre.Multiline = true;
            this.txt_FiltrarPrimerNombre.Name = "txt_FiltrarPrimerNombre";
            this.txt_FiltrarPrimerNombre.Size = new System.Drawing.Size(182, 20);
            this.txt_FiltrarPrimerNombre.TabIndex = 1;
            // 
            // txt_FiltrarPrimerApellido
            // 
            this.txt_FiltrarPrimerApellido.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_FiltrarPrimerApellido.Location = new System.Drawing.Point(230, 66);
            this.txt_FiltrarPrimerApellido.Multiline = true;
            this.txt_FiltrarPrimerApellido.Name = "txt_FiltrarPrimerApellido";
            this.txt_FiltrarPrimerApellido.Size = new System.Drawing.Size(182, 20);
            this.txt_FiltrarPrimerApellido.TabIndex = 2;
            // 
            // lbl_TituloClientes
            // 
            this.lbl_TituloClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TituloClientes.AutoSize = true;
            this.lbl_TituloClientes.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloClientes.Location = new System.Drawing.Point(12, 9);
            this.lbl_TituloClientes.Name = "lbl_TituloClientes";
            this.lbl_TituloClientes.Size = new System.Drawing.Size(143, 41);
            this.lbl_TituloClientes.TabIndex = 51;
            this.lbl_TituloClientes.Text = "Clientes.";
            // 
            // dgv_Autos
            // 
            this.dgv_Autos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Autos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Autos.Location = new System.Drawing.Point(0, 0);
            this.dgv_Autos.Name = "dgv_Autos";
            this.dgv_Autos.ReadOnly = true;
            this.dgv_Autos.Size = new System.Drawing.Size(680, 110);
            this.dgv_Autos.TabIndex = 48;
            // 
            // GB_IngresoAutos
            // 
            this.GB_IngresoAutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_IngresoAutos.Controls.Add(this.btn_IngresarAuto);
            this.GB_IngresoAutos.Controls.Add(this.lbl_Modelo);
            this.GB_IngresoAutos.Controls.Add(this.lbl_Marca);
            this.GB_IngresoAutos.Controls.Add(this.txt_Modelo);
            this.GB_IngresoAutos.Controls.Add(this.txt_Marca);
            this.GB_IngresoAutos.Controls.Add(this.lbl_AutosVencejoPIN);
            this.GB_IngresoAutos.Controls.Add(this.lbl_Matricula);
            this.GB_IngresoAutos.Controls.Add(this.txt_IDCliente);
            this.GB_IngresoAutos.Controls.Add(this.txt_IDMatricula);
            this.GB_IngresoAutos.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.GB_IngresoAutos.Location = new System.Drawing.Point(4, 7);
            this.GB_IngresoAutos.Name = "GB_IngresoAutos";
            this.GB_IngresoAutos.Size = new System.Drawing.Size(462, 205);
            this.GB_IngresoAutos.TabIndex = 49;
            this.GB_IngresoAutos.TabStop = false;
            this.GB_IngresoAutos.Text = "Ingresar Un Nuevo Auto Al Cliente";
            // 
            // btn_IngresarAuto
            // 
            this.btn_IngresarAuto.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresarAuto.Location = new System.Drawing.Point(122, 130);
            this.btn_IngresarAuto.Name = "btn_IngresarAuto";
            this.btn_IngresarAuto.Size = new System.Drawing.Size(182, 31);
            this.btn_IngresarAuto.TabIndex = 4;
            this.btn_IngresarAuto.Text = "Ingresar Auto";
            this.btn_IngresarAuto.UseVisualStyleBackColor = true;
            this.btn_IngresarAuto.Click += new System.EventHandler(this.btn_IngresarAuto_Click);
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modelo.Location = new System.Drawing.Point(219, 33);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(113, 17);
            this.lbl_Modelo.TabIndex = 13;
            this.lbl_Modelo.Text = "Modelo Del Auto";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(219, 75);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(106, 17);
            this.lbl_Marca.TabIndex = 12;
            this.lbl_Marca.Text = "Marca Del Auto";
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_Modelo.Location = new System.Drawing.Point(222, 55);
            this.txt_Modelo.Multiline = true;
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(182, 20);
            this.txt_Modelo.TabIndex = 2;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_Marca.Location = new System.Drawing.Point(222, 95);
            this.txt_Marca.Multiline = true;
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(182, 20);
            this.txt_Marca.TabIndex = 3;
            // 
            // lbl_AutosVencejoPIN
            // 
            this.lbl_AutosVencejoPIN.AutoSize = true;
            this.lbl_AutosVencejoPIN.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AutosVencejoPIN.Location = new System.Drawing.Point(21, 33);
            this.lbl_AutosVencejoPIN.Name = "lbl_AutosVencejoPIN";
            this.lbl_AutosVencejoPIN.Size = new System.Drawing.Size(67, 17);
            this.lbl_AutosVencejoPIN.TabIndex = 8;
            this.lbl_AutosVencejoPIN.Text = "ID Cliente";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricula.Location = new System.Drawing.Point(21, 75);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(125, 17);
            this.lbl_Matricula.TabIndex = 7;
            this.lbl_Matricula.Text = "Matricula Del Auto";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_IDCliente.Location = new System.Drawing.Point(24, 53);
            this.txt_IDCliente.Multiline = true;
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(182, 20);
            this.txt_IDCliente.TabIndex = 0;
            // 
            // txt_IDMatricula
            // 
            this.txt_IDMatricula.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_IDMatricula.Location = new System.Drawing.Point(24, 95);
            this.txt_IDMatricula.Multiline = true;
            this.txt_IDMatricula.Name = "txt_IDMatricula";
            this.txt_IDMatricula.Size = new System.Drawing.Size(182, 20);
            this.txt_IDMatricula.TabIndex = 1;
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Clientes.Location = new System.Drawing.Point(0, 0);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.Size = new System.Drawing.Size(1162, 144);
            this.dgv_Clientes.TabIndex = 45;
            // 
            // GB_IngresoClientes
            // 
            this.GB_IngresoClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_IngresoClientes.Controls.Add(this.lbl_NumeroTelefonico);
            this.GB_IngresoClientes.Controls.Add(this.lbl_Correo);
            this.GB_IngresoClientes.Controls.Add(this.lbl_Edad);
            this.GB_IngresoClientes.Controls.Add(this.txt_telefono);
            this.GB_IngresoClientes.Controls.Add(this.txt_correo);
            this.GB_IngresoClientes.Controls.Add(this.txt_edad);
            this.GB_IngresoClientes.Controls.Add(this.btn_ingresarCliente);
            this.GB_IngresoClientes.Controls.Add(this.lbl_PrimerNom);
            this.GB_IngresoClientes.Controls.Add(this.lbl_SegundoNom);
            this.GB_IngresoClientes.Controls.Add(this.txt_PrimerNombre);
            this.GB_IngresoClientes.Controls.Add(this.txt_SegundoNombre);
            this.GB_IngresoClientes.Controls.Add(this.lbl_ApPaterno);
            this.GB_IngresoClientes.Controls.Add(this.lbl_ApMaterno);
            this.GB_IngresoClientes.Controls.Add(this.txt_PrimerApellido);
            this.GB_IngresoClientes.Controls.Add(this.txt_SegundoApellido);
            this.GB_IngresoClientes.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_IngresoClientes.Location = new System.Drawing.Point(8, 69);
            this.GB_IngresoClientes.Name = "GB_IngresoClientes";
            this.GB_IngresoClientes.Size = new System.Drawing.Size(643, 176);
            this.GB_IngresoClientes.TabIndex = 46;
            this.GB_IngresoClientes.TabStop = false;
            this.GB_IngresoClientes.Text = "Ingresar Un Nuevo Cliente";
            // 
            // lbl_NumeroTelefonico
            // 
            this.lbl_NumeroTelefonico.AutoSize = true;
            this.lbl_NumeroTelefonico.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroTelefonico.Location = new System.Drawing.Point(219, 124);
            this.lbl_NumeroTelefonico.Name = "lbl_NumeroTelefonico";
            this.lbl_NumeroTelefonico.Size = new System.Drawing.Size(126, 17);
            this.lbl_NumeroTelefonico.TabIndex = 40;
            this.lbl_NumeroTelefonico.Text = "Numero Telefonico";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(419, 37);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(121, 17);
            this.lbl_Correo.TabIndex = 39;
            this.lbl_Correo.Text = "Correo Electronico";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.Location = new System.Drawing.Point(219, 82);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(40, 17);
            this.lbl_Edad.TabIndex = 38;
            this.lbl_Edad.Text = "Edad";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_telefono.Location = new System.Drawing.Point(222, 144);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(182, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_correo.Location = new System.Drawing.Point(422, 57);
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(182, 20);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_edad.Location = new System.Drawing.Point(222, 102);
            this.txt_edad.Multiline = true;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(182, 20);
            this.txt_edad.TabIndex = 4;
            // 
            // btn_ingresarCliente
            // 
            this.btn_ingresarCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresarCliente.Location = new System.Drawing.Point(422, 113);
            this.btn_ingresarCliente.Name = "btn_ingresarCliente";
            this.btn_ingresarCliente.Size = new System.Drawing.Size(182, 31);
            this.btn_ingresarCliente.TabIndex = 7;
            this.btn_ingresarCliente.Text = "Ingresar Cliente";
            this.btn_ingresarCliente.UseVisualStyleBackColor = true;
            this.btn_ingresarCliente.Click += new System.EventHandler(this.btn_ingresarCliente_Click);
            // 
            // lbl_PrimerNom
            // 
            this.lbl_PrimerNom.AutoSize = true;
            this.lbl_PrimerNom.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrimerNom.Location = new System.Drawing.Point(21, 122);
            this.lbl_PrimerNom.Name = "lbl_PrimerNom";
            this.lbl_PrimerNom.Size = new System.Drawing.Size(106, 17);
            this.lbl_PrimerNom.TabIndex = 13;
            this.lbl_PrimerNom.Text = "Primer Nombre";
            // 
            // lbl_SegundoNom
            // 
            this.lbl_SegundoNom.AutoSize = true;
            this.lbl_SegundoNom.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SegundoNom.Location = new System.Drawing.Point(219, 37);
            this.lbl_SegundoNom.Name = "lbl_SegundoNom";
            this.lbl_SegundoNom.Size = new System.Drawing.Size(118, 17);
            this.lbl_SegundoNom.TabIndex = 12;
            this.lbl_SegundoNom.Text = "Segundo Nombre";
            // 
            // txt_PrimerNombre
            // 
            this.txt_PrimerNombre.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_PrimerNombre.Location = new System.Drawing.Point(24, 144);
            this.txt_PrimerNombre.Multiline = true;
            this.txt_PrimerNombre.Name = "txt_PrimerNombre";
            this.txt_PrimerNombre.Size = new System.Drawing.Size(182, 20);
            this.txt_PrimerNombre.TabIndex = 2;
            // 
            // txt_SegundoNombre
            // 
            this.txt_SegundoNombre.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_SegundoNombre.Location = new System.Drawing.Point(222, 57);
            this.txt_SegundoNombre.Multiline = true;
            this.txt_SegundoNombre.Name = "txt_SegundoNombre";
            this.txt_SegundoNombre.Size = new System.Drawing.Size(182, 20);
            this.txt_SegundoNombre.TabIndex = 3;
            // 
            // lbl_ApPaterno
            // 
            this.lbl_ApPaterno.AutoSize = true;
            this.lbl_ApPaterno.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApPaterno.Location = new System.Drawing.Point(21, 37);
            this.lbl_ApPaterno.Name = "lbl_ApPaterno";
            this.lbl_ApPaterno.Size = new System.Drawing.Size(104, 17);
            this.lbl_ApPaterno.TabIndex = 8;
            this.lbl_ApPaterno.Text = "Primer Apellido";
            // 
            // lbl_ApMaterno
            // 
            this.lbl_ApMaterno.AutoSize = true;
            this.lbl_ApMaterno.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApMaterno.Location = new System.Drawing.Point(21, 79);
            this.lbl_ApMaterno.Name = "lbl_ApMaterno";
            this.lbl_ApMaterno.Size = new System.Drawing.Size(116, 17);
            this.lbl_ApMaterno.TabIndex = 7;
            this.lbl_ApMaterno.Text = "Segundo Apellido";
            // 
            // txt_PrimerApellido
            // 
            this.txt_PrimerApellido.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_PrimerApellido.Location = new System.Drawing.Point(24, 57);
            this.txt_PrimerApellido.Multiline = true;
            this.txt_PrimerApellido.Name = "txt_PrimerApellido";
            this.txt_PrimerApellido.Size = new System.Drawing.Size(182, 20);
            this.txt_PrimerApellido.TabIndex = 0;
            // 
            // txt_SegundoApellido
            // 
            this.txt_SegundoApellido.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_SegundoApellido.Location = new System.Drawing.Point(24, 99);
            this.txt_SegundoApellido.Multiline = true;
            this.txt_SegundoApellido.Name = "txt_SegundoApellido";
            this.txt_SegundoApellido.Size = new System.Drawing.Size(182, 20);
            this.txt_SegundoApellido.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Clientes);
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.panel1.Location = new System.Drawing.Point(8, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 144);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Autos);
            this.panel2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.panel2.Location = new System.Drawing.Point(486, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 110);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.GB_FiltrarAutos);
            this.panel3.Controls.Add(this.GB_IngresoAutos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 226);
            this.panel3.TabIndex = 54;
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GB_FiltrarClientes);
            this.Controls.Add(this.lbl_TituloClientes);
            this.Controls.Add(this.GB_IngresoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMCLIENTES";
            this.Text = "FRMCLIENTES";
            this.Load += new System.EventHandler(this.FRMCLIENTES_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FRMCLIENTES_HelpRequested);
            this.GB_FiltrarAutos.ResumeLayout(false);
            this.GB_FiltrarAutos.PerformLayout();
            this.GB_FiltrarClientes.ResumeLayout(false);
            this.GB_FiltrarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autos)).EndInit();
            this.GB_IngresoAutos.ResumeLayout(false);
            this.GB_IngresoAutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.GB_IngresoClientes.ResumeLayout(false);
            this.GB_IngresoClientes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_FiltrarAutos;
        private System.Windows.Forms.Label lbl_FiltrarMatricula;
        private System.Windows.Forms.TextBox txt_FiltrarMatricula;
        private System.Windows.Forms.Button btn_FiltrarAuto;
        private System.Windows.Forms.Label lbl_FiltrarModelo;
        private System.Windows.Forms.TextBox txt_FiltrarModelo;
        private System.Windows.Forms.GroupBox GB_FiltrarClientes;
        private System.Windows.Forms.Label lbl_FiltrarVencejoPIN;
        private System.Windows.Forms.TextBox txt_FiltrarVencejoPIN;
        private System.Windows.Forms.Button btn_FiltrarCliente;
        private System.Windows.Forms.Label lbl_FiltrarPrimerNom;
        private System.Windows.Forms.Label lbl_FiltrarApPaterno;
        private System.Windows.Forms.TextBox txt_FiltrarPrimerNombre;
        private System.Windows.Forms.TextBox txt_FiltrarPrimerApellido;
        private System.Windows.Forms.Label lbl_TituloClientes;
        private System.Windows.Forms.DataGridView dgv_Autos;
        private System.Windows.Forms.GroupBox GB_IngresoAutos;
        private System.Windows.Forms.Button btn_IngresarAuto;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label lbl_AutosVencejoPIN;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.TextBox txt_IDMatricula;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.GroupBox GB_IngresoClientes;
        private System.Windows.Forms.Label lbl_NumeroTelefonico;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Button btn_ingresarCliente;
        private System.Windows.Forms.Label lbl_PrimerNom;
        private System.Windows.Forms.Label lbl_SegundoNom;
        private System.Windows.Forms.TextBox txt_PrimerNombre;
        private System.Windows.Forms.TextBox txt_SegundoNombre;
        private System.Windows.Forms.Label lbl_ApPaterno;
        private System.Windows.Forms.Label lbl_ApMaterno;
        private System.Windows.Forms.TextBox txt_PrimerApellido;
        private System.Windows.Forms.TextBox txt_SegundoApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}