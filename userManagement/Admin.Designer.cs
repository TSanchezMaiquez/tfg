namespace userManagement
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.cbbSalary = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.FSalary = new System.Windows.Forms.TextBox();
            this.FUserRol = new System.Windows.Forms.TextBox();
            this.FEmail = new System.Windows.Forms.TextBox();
            this.FSecondname = new System.Windows.Forms.TextBox();
            this.FUsername = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarAnadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAnadirCerrar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbUserRol = new System.Windows.Forms.ComboBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSecondname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.txtEditarUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btbCerrarElimnar = new System.Windows.Forms.Button();
            this.btnElimnar = new System.Windows.Forms.Button();
            this.txtUsernameElimnar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cbbSalary);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.FSalary);
            this.groupBox1.Controls.Add(this.FUserRol);
            this.groupBox1.Controls.Add(this.FEmail);
            this.groupBox1.Controls.Add(this.FSecondname);
            this.groupBox1.Controls.Add(this.FUsername);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dgvAllUsers);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 206);
            this.panel1.TabIndex = 16;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToResizeColumns = false;
            this.dgvAllUsers.AllowUserToResizeRows = false;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAllUsers.Location = new System.Drawing.Point(23, 11);
            this.dgvAllUsers.MaximumSize = new System.Drawing.Size(760, 192);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 24;
            this.dgvAllUsers.Size = new System.Drawing.Size(760, 192);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // cbbSalary
            // 
            this.cbbSalary.FormattingEnabled = true;
            this.cbbSalary.ItemHeight = 25;
            this.cbbSalary.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cbbSalary.Location = new System.Drawing.Point(984, 256);
            this.cbbSalary.Name = "cbbSalary";
            this.cbbSalary.Size = new System.Drawing.Size(45, 33);
            this.cbbSalary.TabIndex = 13;
            this.cbbSalary.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Location = new System.Drawing.Point(975, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FSalary
            // 
            this.FSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSalary.Location = new System.Drawing.Point(1044, 257);
            this.FSalary.MinimumSize = new System.Drawing.Size(80, 4);
            this.FSalary.Name = "FSalary";
            this.FSalary.Size = new System.Drawing.Size(80, 28);
            this.FSalary.TabIndex = 14;
            this.FSalary.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // FUserRol
            // 
            this.FUserRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FUserRol.Location = new System.Drawing.Point(984, 215);
            this.FUserRol.MinimumSize = new System.Drawing.Size(140, 4);
            this.FUserRol.Name = "FUserRol";
            this.FUserRol.Size = new System.Drawing.Size(140, 28);
            this.FUserRol.TabIndex = 12;
            this.FUserRol.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // FEmail
            // 
            this.FEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEmail.Location = new System.Drawing.Point(984, 171);
            this.FEmail.MinimumSize = new System.Drawing.Size(140, 4);
            this.FEmail.Name = "FEmail";
            this.FEmail.Size = new System.Drawing.Size(140, 28);
            this.FEmail.TabIndex = 11;
            this.FEmail.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // FSecondname
            // 
            this.FSecondname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSecondname.Location = new System.Drawing.Point(984, 128);
            this.FSecondname.MinimumSize = new System.Drawing.Size(140, 4);
            this.FSecondname.Name = "FSecondname";
            this.FSecondname.Size = new System.Drawing.Size(140, 28);
            this.FSecondname.TabIndex = 10;
            this.FSecondname.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // FUsername
            // 
            this.FUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FUsername.Location = new System.Drawing.Point(984, 83);
            this.FUsername.MinimumSize = new System.Drawing.Size(140, 4);
            this.FUsername.Name = "FUsername";
            this.FUsername.Size = new System.Drawing.Size(140, 28);
            this.FUsername.TabIndex = 9;
            this.FUsername.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(184)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(22, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 37);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(888, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(814, 258);
            this.label6.MaximumSize = new System.Drawing.Size(150, 0);
            this.label6.MinimumSize = new System.Drawing.Size(150, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2);
            this.label6.Size = new System.Drawing.Size(150, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(814, 215);
            this.label5.MaximumSize = new System.Drawing.Size(150, 0);
            this.label5.MinimumSize = new System.Drawing.Size(150, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(150, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "UserRol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(814, 171);
            this.label4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label4.MinimumSize = new System.Drawing.Size(150, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(150, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(814, 128);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.MinimumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secondname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(814, 84);
            this.label3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label3.MinimumSize = new System.Drawing.Size(150, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1470, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(123, 34);
            this.añadirToolStripMenuItem.Text = "Añadir  usuario";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.editarUsuarioToolStripMenuItem.Text = "Editar usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(129, 34);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.Black;
            this.grb2.Controls.Add(this.btnLimpiarAnadir);
            this.grb2.Controls.Add(this.btnEditar);
            this.grb2.Controls.Add(this.btnAnadirCerrar);
            this.grb2.Controls.Add(this.txtPassword);
            this.grb2.Controls.Add(this.label12);
            this.grb2.Controls.Add(this.cbbUserRol);
            this.grb2.Controls.Add(this.btnAnadir);
            this.grb2.Controls.Add(this.txtSalary);
            this.grb2.Controls.Add(this.txtEmail);
            this.grb2.Controls.Add(this.txtSecondname);
            this.grb2.Controls.Add(this.txtUsername);
            this.grb2.Controls.Add(this.label7);
            this.grb2.Controls.Add(this.label8);
            this.grb2.Controls.Add(this.label9);
            this.grb2.Controls.Add(this.label10);
            this.grb2.Controls.Add(this.label11);
            this.grb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2.ForeColor = System.Drawing.Color.White;
            this.grb2.Location = new System.Drawing.Point(12, 409);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(532, 310);
            this.grb2.TabIndex = 3;
            this.grb2.TabStop = false;
            this.grb2.Text = "Añadir usuario";
            this.grb2.Visible = false;
            // 
            // btnLimpiarAnadir
            // 
            this.btnLimpiarAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.btnLimpiarAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAnadir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarAnadir.Location = new System.Drawing.Point(388, 153);
            this.btnLimpiarAnadir.Name = "btnLimpiarAnadir";
            this.btnLimpiarAnadir.Size = new System.Drawing.Size(92, 40);
            this.btnLimpiarAnadir.TabIndex = 30;
            this.btnLimpiarAnadir.Text = "Limpiar";
            this.btnLimpiarAnadir.UseVisualStyleBackColor = false;
            this.btnLimpiarAnadir.Click += new System.EventHandler(this.btnLimpiarAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(388, 96);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 40);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAnadirCerrar
            // 
            this.btnAnadirCerrar.BackColor = System.Drawing.Color.Tan;
            this.btnAnadirCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnadirCerrar.Location = new System.Drawing.Point(388, 213);
            this.btnAnadirCerrar.Name = "btnAnadirCerrar";
            this.btnAnadirCerrar.Size = new System.Drawing.Size(92, 40);
            this.btnAnadirCerrar.TabIndex = 28;
            this.btnAnadirCerrar.Text = "Cerrar";
            this.btnAnadirCerrar.UseVisualStyleBackColor = false;
            this.btnAnadirCerrar.Click += new System.EventHandler(this.btnAnadirCerrar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(209, 96);
            this.txtPassword.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 28);
            this.txtPassword.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 96);
            this.label12.MaximumSize = new System.Drawing.Size(150, 0);
            this.label12.MinimumSize = new System.Drawing.Size(150, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(2);
            this.label12.Size = new System.Drawing.Size(150, 27);
            this.label12.TabIndex = 26;
            this.label12.Text = "Password";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbUserRol
            // 
            this.cbbUserRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserRol.FormattingEnabled = true;
            this.cbbUserRol.Items.AddRange(new object[] {
            "ADMIN",
            "WORKER"});
            this.cbbUserRol.Location = new System.Drawing.Point(209, 213);
            this.cbbUserRol.Name = "cbbUserRol";
            this.cbbUserRol.Size = new System.Drawing.Size(140, 28);
            this.cbbUserRol.TabIndex = 23;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnadir.Location = new System.Drawing.Point(388, 96);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(92, 40);
            this.btnAnadir.TabIndex = 24;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btbAnadir_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(209, 251);
            this.txtSalary.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(140, 28);
            this.txtSalary.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(209, 174);
            this.txtEmail.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 28);
            this.txtEmail.TabIndex = 22;
            // 
            // txtSecondname
            // 
            this.txtSecondname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondname.Location = new System.Drawing.Point(209, 134);
            this.txtSecondname.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.Size = new System.Drawing.Size(140, 28);
            this.txtSecondname.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(209, 56);
            this.txtUsername.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 28);
            this.txtUsername.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 251);
            this.label7.MaximumSize = new System.Drawing.Size(150, 0);
            this.label7.MinimumSize = new System.Drawing.Size(150, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(2);
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Salary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(39, 212);
            this.label8.MaximumSize = new System.Drawing.Size(150, 0);
            this.label8.MinimumSize = new System.Drawing.Size(150, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(150, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "UserRol";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 173);
            this.label9.MaximumSize = new System.Drawing.Size(150, 0);
            this.label9.MinimumSize = new System.Drawing.Size(150, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(2);
            this.label9.Size = new System.Drawing.Size(150, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 134);
            this.label10.MaximumSize = new System.Drawing.Size(150, 0);
            this.label10.MinimumSize = new System.Drawing.Size(150, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(150, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "Secondname";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(39, 57);
            this.label11.MaximumSize = new System.Drawing.Size(150, 0);
            this.label11.MinimumSize = new System.Drawing.Size(150, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(150, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = "Username";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Black;
            this.grbEditar.Controls.Add(this.button1);
            this.grbEditar.Controls.Add(this.buscar);
            this.grbEditar.Controls.Add(this.txtEditarUsername);
            this.grbEditar.Controls.Add(this.label18);
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(10, 407);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(377, 195);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar usuario";
            this.grbEditar.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(81, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buscar.Location = new System.Drawing.Point(228, 119);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(92, 40);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtEditarUsername
            // 
            this.txtEditarUsername.BackColor = System.Drawing.Color.White;
            this.txtEditarUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarUsername.Location = new System.Drawing.Point(209, 56);
            this.txtEditarUsername.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtEditarUsername.Name = "txtEditarUsername";
            this.txtEditarUsername.Size = new System.Drawing.Size(140, 28);
            this.txtEditarUsername.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(39, 57);
            this.label18.MaximumSize = new System.Drawing.Size(150, 0);
            this.label18.MinimumSize = new System.Drawing.Size(150, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(2);
            this.label18.Size = new System.Drawing.Size(150, 27);
            this.label18.TabIndex = 14;
            this.label18.Text = "Username";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbEliminar
            // 
            this.grbEliminar.BackColor = System.Drawing.Color.Black;
            this.grbEliminar.Controls.Add(this.btbCerrarElimnar);
            this.grbEliminar.Controls.Add(this.btnElimnar);
            this.grbEliminar.Controls.Add(this.txtUsernameElimnar);
            this.grbEliminar.Controls.Add(this.label13);
            this.grbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEliminar.ForeColor = System.Drawing.Color.White;
            this.grbEliminar.Location = new System.Drawing.Point(10, 408);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(377, 195);
            this.grbEliminar.TabIndex = 5;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Eliminar usuario";
            this.grbEliminar.Visible = false;
            // 
            // btbCerrarElimnar
            // 
            this.btbCerrarElimnar.BackColor = System.Drawing.Color.Tan;
            this.btbCerrarElimnar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCerrarElimnar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btbCerrarElimnar.Location = new System.Drawing.Point(81, 119);
            this.btbCerrarElimnar.Name = "btbCerrarElimnar";
            this.btbCerrarElimnar.Size = new System.Drawing.Size(92, 40);
            this.btbCerrarElimnar.TabIndex = 28;
            this.btbCerrarElimnar.Text = "Cerrar";
            this.btbCerrarElimnar.UseVisualStyleBackColor = false;
            this.btbCerrarElimnar.Click += new System.EventHandler(this.btbCerrarElimnar_Click);
            // 
            // btnElimnar
            // 
            this.btnElimnar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(163)))), ((int)(((byte)(33)))));
            this.btnElimnar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimnar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnElimnar.Location = new System.Drawing.Point(222, 119);
            this.btnElimnar.Name = "btnElimnar";
            this.btnElimnar.Size = new System.Drawing.Size(103, 40);
            this.btnElimnar.TabIndex = 24;
            this.btnElimnar.Text = "Eliminar";
            this.btnElimnar.UseVisualStyleBackColor = false;
            this.btnElimnar.Click += new System.EventHandler(this.btnElimnar_Click);
            // 
            // txtUsernameElimnar
            // 
            this.txtUsernameElimnar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameElimnar.Location = new System.Drawing.Point(209, 56);
            this.txtUsernameElimnar.MinimumSize = new System.Drawing.Size(140, 4);
            this.txtUsernameElimnar.Name = "txtUsernameElimnar";
            this.txtUsernameElimnar.Size = new System.Drawing.Size(140, 28);
            this.txtUsernameElimnar.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(39, 57);
            this.label13.MaximumSize = new System.Drawing.Size(150, 0);
            this.label13.MinimumSize = new System.Drawing.Size(150, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(2);
            this.label13.Size = new System.Drawing.Size(150, 27);
            this.label13.TabIndex = 14;
            this.label13.Text = "Username";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::userManagement.Properties.Resources.mountain_2143877_1280;
            this.ClientSize = new System.Drawing.Size(1176, 722);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grb2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FUsername;
        private System.Windows.Forms.TextBox FSalary;
        private System.Windows.Forms.TextBox FUserRol;
        private System.Windows.Forms.TextBox FEmail;
        private System.Windows.Forms.TextBox FSecondname;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSecondname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbUserRol;
        private System.Windows.Forms.ComboBox cbbSalary;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAnadirCerrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox txtEditarUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btbCerrarElimnar;
        private System.Windows.Forms.Button btnElimnar;
        private System.Windows.Forms.TextBox txtUsernameElimnar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiarAnadir;
    }
}