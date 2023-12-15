
namespace PROGRA3_CAJR
{
    partial class FRMPRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPRINCIPAL));
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.ibtn_configuraciones = new FontAwesome.Sharp.IconButton();
            this.ibtn_clientes = new FontAwesome.Sharp.IconButton();
            this.ibtn_productos = new FontAwesome.Sharp.IconButton();
            this.ibtn_empleados = new FontAwesome.Sharp.IconButton();
            this.ibtn_ventas = new FontAwesome.Sharp.IconButton();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.ibtn_inicio = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_Idioma = new System.Windows.Forms.ComboBox();
            this.ibtn_ayuda = new FontAwesome.Sharp.IconButton();
            this.ibtn_acerca = new FontAwesome.Sharp.IconButton();
            this.ibtn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.pnl_escritorio = new System.Windows.Forms.Panel();
            this.timer_fecha_hora = new System.Windows.Forms.Timer(this.components);
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(188, 132);
            this.pnl_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(52)))));
            this.pnl_menu.Controls.Add(this.ibtn_configuraciones);
            this.pnl_menu.Controls.Add(this.ibtn_clientes);
            this.pnl_menu.Controls.Add(this.ibtn_productos);
            this.pnl_menu.Controls.Add(this.ibtn_empleados);
            this.pnl_menu.Controls.Add(this.ibtn_ventas);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.ForeColor = System.Drawing.Color.Black;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(188, 749);
            this.pnl_menu.TabIndex = 2;
            // 
            // ibtn_configuraciones
            // 
            this.ibtn_configuraciones.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_configuraciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtn_configuraciones.FlatAppearance.BorderSize = 0;
            this.ibtn_configuraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_configuraciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_configuraciones.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ibtn_configuraciones.IconColor = System.Drawing.Color.Black;
            this.ibtn_configuraciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_configuraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_configuraciones.Location = new System.Drawing.Point(0, 706);
            this.ibtn_configuraciones.Name = "ibtn_configuraciones";
            this.ibtn_configuraciones.Size = new System.Drawing.Size(188, 43);
            this.ibtn_configuraciones.TabIndex = 5;
            this.ibtn_configuraciones.Text = "&Configuracíon";
            this.ibtn_configuraciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_configuraciones.UseVisualStyleBackColor = false;
            this.ibtn_configuraciones.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // ibtn_clientes
            // 
            this.ibtn_clientes.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_clientes.FlatAppearance.BorderSize = 0;
            this.ibtn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_clientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_clientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtn_clientes.IconColor = System.Drawing.Color.Black;
            this.ibtn_clientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_clientes.Location = new System.Drawing.Point(3, 381);
            this.ibtn_clientes.Name = "ibtn_clientes";
            this.ibtn_clientes.Size = new System.Drawing.Size(179, 43);
            this.ibtn_clientes.TabIndex = 4;
            this.ibtn_clientes.Text = "Clientes";
            this.ibtn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_clientes.UseVisualStyleBackColor = false;
            this.ibtn_clientes.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ibtn_productos
            // 
            this.ibtn_productos.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_productos.FlatAppearance.BorderSize = 0;
            this.ibtn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_productos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_productos.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibtn_productos.IconColor = System.Drawing.Color.Black;
            this.ibtn_productos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_productos.Location = new System.Drawing.Point(3, 460);
            this.ibtn_productos.Name = "ibtn_productos";
            this.ibtn_productos.Size = new System.Drawing.Size(179, 43);
            this.ibtn_productos.TabIndex = 3;
            this.ibtn_productos.Text = "Empleados";
            this.ibtn_productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_productos.UseVisualStyleBackColor = false;
            this.ibtn_productos.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ibtn_empleados
            // 
            this.ibtn_empleados.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_empleados.FlatAppearance.BorderSize = 0;
            this.ibtn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_empleados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_empleados.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.ibtn_empleados.IconColor = System.Drawing.Color.Black;
            this.ibtn_empleados.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_empleados.Location = new System.Drawing.Point(3, 533);
            this.ibtn_empleados.Name = "ibtn_empleados";
            this.ibtn_empleados.Size = new System.Drawing.Size(179, 43);
            this.ibtn_empleados.TabIndex = 2;
            this.ibtn_empleados.Text = "Inventario";
            this.ibtn_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_empleados.UseVisualStyleBackColor = false;
            this.ibtn_empleados.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ibtn_ventas
            // 
            this.ibtn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_ventas.FlatAppearance.BorderSize = 0;
            this.ibtn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ventas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_ventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.ibtn_ventas.IconColor = System.Drawing.Color.Black;
            this.ibtn_ventas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_ventas.Location = new System.Drawing.Point(3, 302);
            this.ibtn_ventas.Name = "ibtn_ventas";
            this.ibtn_ventas.Size = new System.Drawing.Size(179, 43);
            this.ibtn_ventas.TabIndex = 1;
            this.ibtn_ventas.Text = "Trabajos";
            this.ibtn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ventas.UseVisualStyleBackColor = false;
            this.ibtn_ventas.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(82)))));
            this.pnl_titulo.Controls.Add(this.panel2);
            this.pnl_titulo.Controls.Add(this.ibtn_inicio);
            this.pnl_titulo.Controls.Add(this.panel1);
            this.pnl_titulo.Controls.Add(this.lbl_hora);
            this.pnl_titulo.Controls.Add(this.lbl_fecha);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_titulo.ForeColor = System.Drawing.Color.White;
            this.pnl_titulo.Location = new System.Drawing.Point(188, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(996, 86);
            this.pnl_titulo.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.lbl_Position);
            this.panel2.Controls.Add(this.lbl_Email);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(380, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 86);
            this.panel2.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(82)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 40);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.Black;
            this.lbl_Position.Location = new System.Drawing.Point(70, 60);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(59, 18);
            this.lbl_Position.TabIndex = 2;
            this.lbl_Position.Text = "Posicion";
            this.lbl_Position.Click += new System.EventHandler(this.lbl_Position_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(70, 34);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 18);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Correo";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(70, 6);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 18);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Nombre";
            // 
            // ibtn_inicio
            // 
            this.ibtn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_inicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtn_inicio.FlatAppearance.BorderSize = 0;
            this.ibtn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_inicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_inicio.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.ibtn_inicio.IconColor = System.Drawing.Color.Black;
            this.ibtn_inicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_inicio.IconSize = 40;
            this.ibtn_inicio.Location = new System.Drawing.Point(0, 0);
            this.ibtn_inicio.Name = "ibtn_inicio";
            this.ibtn_inicio.Size = new System.Drawing.Size(56, 86);
            this.ibtn_inicio.TabIndex = 6;
            this.ibtn_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_inicio.UseVisualStyleBackColor = false;
            this.ibtn_inicio.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_Idioma);
            this.panel1.Controls.Add(this.ibtn_ayuda);
            this.panel1.Controls.Add(this.ibtn_acerca);
            this.panel1.Controls.Add(this.ibtn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(668, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 86);
            this.panel1.TabIndex = 4;
            // 
            // cbo_Idioma
            // 
            this.cbo_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Idioma.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.cbo_Idioma.FormattingEnabled = true;
            this.cbo_Idioma.IntegralHeight = false;
            this.cbo_Idioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cbo_Idioma.Location = new System.Drawing.Point(27, 29);
            this.cbo_Idioma.Name = "cbo_Idioma";
            this.cbo_Idioma.Size = new System.Drawing.Size(141, 26);
            this.cbo_Idioma.TabIndex = 7;
            this.cbo_Idioma.SelectedIndexChanged += new System.EventHandler(this.cbo_Idioma_SelectedIndexChanged);
            // 
            // ibtn_ayuda
            // 
            this.ibtn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_ayuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtn_ayuda.FlatAppearance.BorderSize = 0;
            this.ibtn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ayuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_ayuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.ibtn_ayuda.IconColor = System.Drawing.Color.Black;
            this.ibtn_ayuda.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_ayuda.IconSize = 40;
            this.ibtn_ayuda.Location = new System.Drawing.Point(185, 0);
            this.ibtn_ayuda.Name = "ibtn_ayuda";
            this.ibtn_ayuda.Size = new System.Drawing.Size(48, 86);
            this.ibtn_ayuda.TabIndex = 8;
            this.ibtn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ayuda.UseVisualStyleBackColor = false;
            this.ibtn_ayuda.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // ibtn_acerca
            // 
            this.ibtn_acerca.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_acerca.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtn_acerca.FlatAppearance.BorderSize = 0;
            this.ibtn_acerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_acerca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_acerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ibtn_acerca.IconColor = System.Drawing.Color.Black;
            this.ibtn_acerca.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_acerca.IconSize = 40;
            this.ibtn_acerca.Location = new System.Drawing.Point(233, 0);
            this.ibtn_acerca.Name = "ibtn_acerca";
            this.ibtn_acerca.Size = new System.Drawing.Size(50, 86);
            this.ibtn_acerca.TabIndex = 7;
            this.ibtn_acerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_acerca.UseVisualStyleBackColor = false;
            this.ibtn_acerca.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // ibtn_Cerrar
            // 
            this.ibtn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.ibtn_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtn_Cerrar.FlatAppearance.BorderSize = 0;
            this.ibtn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Cerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtn_Cerrar.IconColor = System.Drawing.Color.Black;
            this.ibtn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtn_Cerrar.IconSize = 40;
            this.ibtn_Cerrar.Location = new System.Drawing.Point(283, 0);
            this.ibtn_Cerrar.Name = "ibtn_Cerrar";
            this.ibtn_Cerrar.Size = new System.Drawing.Size(45, 86);
            this.ibtn_Cerrar.TabIndex = 9;
            this.ibtn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Cerrar.UseVisualStyleBackColor = false;
            this.ibtn_Cerrar.Click += new System.EventHandler(this.ibtn_Cerrar_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(290, 34);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(41, 18);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(74, 34);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(48, 18);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha";
            // 
            // pnl_escritorio
            // 
            this.pnl_escritorio.BackColor = System.Drawing.Color.White;
            this.pnl_escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_escritorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_escritorio.Location = new System.Drawing.Point(188, 86);
            this.pnl_escritorio.Name = "pnl_escritorio";
            this.pnl_escritorio.Size = new System.Drawing.Size(996, 663);
            this.pnl_escritorio.TabIndex = 4;
            this.pnl_escritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_escritorio_Paint);
            // 
            // timer_fecha_hora
            // 
            this.timer_fecha_hora.Enabled = true;
            this.timer_fecha_hora.Tick += new System.EventHandler(this.fecha_hora_Tick);
            // 
            // FRMPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pnl_escritorio);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "FRMPRINCIPAL";
            this.Text = "Vencejo Motors Sistem.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPRINCIPAL_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMPRINCIPAL_FormClosed);
            this.Load += new System.EventHandler(this.FRMPRINCIPAL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMPRINCIPAL_KeyDown);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_escritorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_fecha_hora;
        private FontAwesome.Sharp.IconButton ibtn_configuraciones;
        private FontAwesome.Sharp.IconButton ibtn_clientes;
        private FontAwesome.Sharp.IconButton ibtn_productos;
        private FontAwesome.Sharp.IconButton ibtn_empleados;
        private FontAwesome.Sharp.IconButton ibtn_ventas;
        private FontAwesome.Sharp.IconButton ibtn_inicio;
        private FontAwesome.Sharp.IconButton ibtn_ayuda;
        private FontAwesome.Sharp.IconButton ibtn_acerca;
        private System.Windows.Forms.ComboBox cbo_Idioma;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Name;
        private FontAwesome.Sharp.IconButton ibtn_Cerrar;
    }
}

