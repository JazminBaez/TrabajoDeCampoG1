﻿using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class FormGestionarUsuarios
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tbDNI = new RJTextBox();
            btCancelar = new RJButton();
            ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            lbError = new Label();
            tbRepetirContrasena = new RJTextBox();
            LRegistrarUsuario = new Label();
            btRegistrar = new RJButton();
            tbContrasena = new RJTextBox();
            tbApellido = new RJTextBox();
            tbCorreo = new RJTextBox();
            cbRol = new ComboBox();
            tbCalle = new RJTextBox();
            tbTelefono = new RJTextBox();
            tbNombre = new RJTextBox();
            rolesRepositorioBindingSource1 = new BindingSource(components);
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            panel2 = new Panel();
            cbFiltrarUsuarios = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarUsuario = new RJTextBox();
            lbFiltrarUsuarios = new Label();
            panel3 = new Panel();
            dgUsuarios = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Crol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Cdni = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            CDarBaja = new DataGridViewButtonColumn();
            CModificar = new DataGridViewButtonColumn();
            rolesRepositorioBindingSource = new BindingSource(components);
            tbAltura = new RJTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(tbAltura);
            panel1.Controls.Add(tbDNI);
            panel1.Controls.Add(btCancelar);
            panel1.Controls.Add(ErrorIcon);
            panel1.Controls.Add(lbError);
            panel1.Controls.Add(tbRepetirContrasena);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbContrasena);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbCorreo);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(tbCalle);
            panel1.Controls.Add(tbTelefono);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 482);
            panel1.TabIndex = 0;
            // 
            // tbDNI
            // 
            tbDNI.BackColor = SystemColors.Window;
            tbDNI.BorderColor = SystemColors.Window;
            tbDNI.BorderFocusColor = Color.MidnightBlue;
            tbDNI.BorderRadius = 11;
            tbDNI.BorderSize = 2;
            tbDNI.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbDNI.ForeColor = Color.FromArgb(64, 64, 64);
            tbDNI.Location = new Point(41, 226);
            tbDNI.Margin = new Padding(4);
            tbDNI.Multiline = false;
            tbDNI.Name = "tbDNI";
            tbDNI.Padding = new Padding(10, 7, 10, 7);
            tbDNI.PasswordChar = false;
            tbDNI.PlaceholderColor = Color.Gray;
            tbDNI.PlaceholderText = "DNI";
            tbDNI.Size = new Size(225, 31);
            tbDNI.TabIndex = 27;
            tbDNI.Texts = "";
            tbDNI.UnderlinedStyle = false;
            tbDNI._TextChanged += iS;
            tbDNI.KeyPress += number_KeyPress;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.GhostWhite;
            btCancelar.BackgroundColor = Color.GhostWhite;
            btCancelar.BorderColor = Color.LavenderBlush;
            btCancelar.BorderRadius = 20;
            btCancelar.BorderSize = 0;
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelar.ForeColor = Color.Black;
            btCancelar.Location = new Point(175, 456);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(91, 40);
            btCancelar.TabIndex = 26;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextColor = Color.Black;
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Visible = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // ErrorIcon
            // 
            ErrorIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ErrorIcon.BackColor = Color.Transparent;
            ErrorIcon.ForeColor = Color.DarkRed;
            ErrorIcon.IconChar = FontAwesome.Sharp.IconChar.Warning;
            ErrorIcon.IconColor = Color.DarkRed;
            ErrorIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ErrorIcon.IconSize = 30;
            ErrorIcon.Location = new Point(53, 64);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(30, 39);
            ErrorIcon.TabIndex = 25;
            ErrorIcon.TabStop = false;
            ErrorIcon.Visible = false;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbError.AutoSize = true;
            lbError.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.DarkRed;
            lbError.Location = new Point(79, 64);
            lbError.Name = "lbError";
            lbError.Size = new Size(41, 16);
            lbError.TabIndex = 24;
            lbError.Text = "Error";
            lbError.Visible = false;
            // 
            // tbRepetirContrasena
            // 
            tbRepetirContrasena.BackColor = SystemColors.Window;
            tbRepetirContrasena.BorderColor = SystemColors.Window;
            tbRepetirContrasena.BorderFocusColor = Color.MidnightBlue;
            tbRepetirContrasena.BorderRadius = 11;
            tbRepetirContrasena.BorderSize = 2;
            tbRepetirContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbRepetirContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            tbRepetirContrasena.Location = new Point(41, 382);
            tbRepetirContrasena.Margin = new Padding(4);
            tbRepetirContrasena.Multiline = false;
            tbRepetirContrasena.Name = "tbRepetirContrasena";
            tbRepetirContrasena.Padding = new Padding(10, 7, 10, 7);
            tbRepetirContrasena.PasswordChar = true;
            tbRepetirContrasena.PlaceholderColor = Color.Gray;
            tbRepetirContrasena.PlaceholderText = "Repetir contraseña";
            tbRepetirContrasena.Size = new Size(225, 31);
            tbRepetirContrasena.TabIndex = 10;
            tbRepetirContrasena.Texts = "";
            tbRepetirContrasena.UnderlinedStyle = false;
            // 
            // LRegistrarUsuario
            // 
            LRegistrarUsuario.AutoSize = true;
            LRegistrarUsuario.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LRegistrarUsuario.ForeColor = SystemColors.Control;
            LRegistrarUsuario.Location = new Point(53, 35);
            LRegistrarUsuario.Name = "LRegistrarUsuario";
            LRegistrarUsuario.Size = new Size(237, 25);
            LRegistrarUsuario.TabIndex = 0;
            LRegistrarUsuario.Text = "REGISTRAR USUARIO";
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = Color.GhostWhite;
            btRegistrar.BackgroundColor = Color.GhostWhite;
            btRegistrar.BorderColor = Color.LavenderBlush;
            btRegistrar.BorderRadius = 20;
            btRegistrar.BorderSize = 0;
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrar.ForeColor = Color.Black;
            btRegistrar.Location = new Point(41, 456);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(91, 40);
            btRegistrar.TabIndex = 9;
            btRegistrar.Text = "REGISTRAR";
            btRegistrar.TextColor = Color.Black;
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = SystemColors.Window;
            tbContrasena.BorderColor = SystemColors.Window;
            tbContrasena.BorderFocusColor = Color.MidnightBlue;
            tbContrasena.BorderRadius = 11;
            tbContrasena.BorderSize = 2;
            tbContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            tbContrasena.Location = new Point(41, 343);
            tbContrasena.Margin = new Padding(4);
            tbContrasena.Multiline = false;
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Padding = new Padding(10, 7, 10, 7);
            tbContrasena.PasswordChar = true;
            tbContrasena.PlaceholderColor = Color.Gray;
            tbContrasena.PlaceholderText = "Contraseña";
            tbContrasena.Size = new Size(225, 31);
            tbContrasena.TabIndex = 7;
            tbContrasena.Texts = "";
            tbContrasena.UnderlinedStyle = false;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = SystemColors.Window;
            tbApellido.BorderColor = SystemColors.Window;
            tbApellido.BorderFocusColor = Color.MidnightBlue;
            tbApellido.BorderRadius = 11;
            tbApellido.BorderSize = 2;
            tbApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellido.ForeColor = Color.FromArgb(64, 64, 64);
            tbApellido.Location = new Point(41, 146);
            tbApellido.Margin = new Padding(4);
            tbApellido.Multiline = false;
            tbApellido.Name = "tbApellido";
            tbApellido.Padding = new Padding(10, 7, 10, 7);
            tbApellido.PasswordChar = false;
            tbApellido.PlaceholderColor = Color.Gray;
            tbApellido.PlaceholderText = "Apellido";
            tbApellido.Size = new Size(225, 31);
            tbApellido.TabIndex = 2;
            tbApellido.Texts = "";
            tbApellido.UnderlinedStyle = false;
            tbApellido.KeyPress += string_KeyPress;
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.Window;
            tbCorreo.BorderColor = SystemColors.Window;
            tbCorreo.BorderFocusColor = Color.MidnightBlue;
            tbCorreo.BorderRadius = 11;
            tbCorreo.BorderSize = 2;
            tbCorreo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            tbCorreo.Location = new Point(41, 304);
            tbCorreo.Margin = new Padding(4);
            tbCorreo.Multiline = false;
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Padding = new Padding(10, 7, 10, 7);
            tbCorreo.PasswordChar = false;
            tbCorreo.PlaceholderColor = Color.Gray;
            tbCorreo.PlaceholderText = "Correo";
            tbCorreo.Size = new Size(225, 31);
            tbCorreo.TabIndex = 6;
            tbCorreo.Texts = "";
            tbCorreo.UnderlinedStyle = false;
            // 
            // cbRol
            // 
            cbRol.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            cbRol.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(41, 422);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(225, 26);
            cbRol.TabIndex = 5;
            cbRol.Text = "Rol";
            cbRol.SelectedIndexChanged += cbRol_SelectedIndexChanged;
            // 
            // tbCalle
            // 
            tbCalle.BackColor = SystemColors.Window;
            tbCalle.BorderColor = SystemColors.Window;
            tbCalle.BorderFocusColor = Color.MidnightBlue;
            tbCalle.BorderRadius = 11;
            tbCalle.BorderSize = 2;
            tbCalle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbCalle.ForeColor = Color.FromArgb(64, 64, 64);
            tbCalle.Location = new Point(41, 265);
            tbCalle.Margin = new Padding(4);
            tbCalle.Multiline = false;
            tbCalle.Name = "tbCalle";
            tbCalle.Padding = new Padding(10, 7, 10, 7);
            tbCalle.PasswordChar = false;
            tbCalle.PlaceholderColor = Color.Gray;
            tbCalle.PlaceholderText = "Direccion";
            tbCalle.Size = new Size(135, 31);
            tbCalle.TabIndex = 4;
            tbCalle.Texts = "";
            tbCalle.UnderlinedStyle = false;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.Window;
            tbTelefono.BorderColor = SystemColors.Window;
            tbTelefono.BorderFocusColor = Color.MidnightBlue;
            tbTelefono.BorderRadius = 11;
            tbTelefono.BorderSize = 2;
            tbTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            tbTelefono.Location = new Point(41, 185);
            tbTelefono.Margin = new Padding(4);
            tbTelefono.Multiline = false;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Padding = new Padding(10, 7, 10, 7);
            tbTelefono.PasswordChar = false;
            tbTelefono.PlaceholderColor = Color.Gray;
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(225, 31);
            tbTelefono.TabIndex = 3;
            tbTelefono.Texts = "";
            tbTelefono.UnderlinedStyle = false;
            tbTelefono.KeyPress += number_KeyPress;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.Window;
            tbNombre.BorderColor = SystemColors.Window;
            tbNombre.BorderFocusColor = Color.MidnightBlue;
            tbNombre.BorderRadius = 11;
            tbNombre.BorderSize = 2;
            tbNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.FromArgb(64, 64, 64);
            tbNombre.Location = new Point(41, 107);
            tbNombre.Margin = new Padding(4);
            tbNombre.Multiline = false;
            tbNombre.Name = "tbNombre";
            tbNombre.Padding = new Padding(10, 7, 10, 7);
            tbNombre.PasswordChar = false;
            tbNombre.PlaceholderColor = Color.Gray;
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(225, 31);
            tbNombre.TabIndex = 1;
            tbNombre.Texts = "";
            tbNombre.UnderlinedStyle = false;
            tbNombre.KeyPress += string_KeyPress;
            // 
            // rolesRepositorioBindingSource1
            // 
            rolesRepositorioBindingSource1.DataSource = typeof(Repositorio.RolesRepositorio);
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(cbFiltrarUsuarios);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(tbBuscarUsuario);
            panel2.Controls.Add(lbFiltrarUsuarios);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(306, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 75);
            panel2.TabIndex = 1;
            // 
            // cbFiltrarUsuarios
            // 
            cbFiltrarUsuarios.Anchor = AnchorStyles.None;
            cbFiltrarUsuarios.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            cbFiltrarUsuarios.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltrarUsuarios.FormattingEnabled = true;
            cbFiltrarUsuarios.Location = new Point(283, 35);
            cbFiltrarUsuarios.Name = "cbFiltrarUsuarios";
            cbFiltrarUsuarios.Size = new Size(123, 26);
            cbFiltrarUsuarios.TabIndex = 16;
            cbFiltrarUsuarios.Text = "Rol";
            cbFiltrarUsuarios.SelectedIndexChanged += cbFiltrarUsuarios_SelectedIndexChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = SystemColors.Desktop;
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(498, 29);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 15;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // tbBuscarUsuario
            // 
            tbBuscarUsuario.BackColor = SystemColors.Window;
            tbBuscarUsuario.BorderColor = SystemColors.Window;
            tbBuscarUsuario.BorderFocusColor = Color.MidnightBlue;
            tbBuscarUsuario.BorderRadius = 11;
            tbBuscarUsuario.BorderSize = 2;
            tbBuscarUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            tbBuscarUsuario.Location = new Point(36, 29);
            tbBuscarUsuario.Margin = new Padding(4);
            tbBuscarUsuario.Multiline = false;
            tbBuscarUsuario.Name = "tbBuscarUsuario";
            tbBuscarUsuario.Padding = new Padding(10, 7, 10, 7);
            tbBuscarUsuario.PasswordChar = false;
            tbBuscarUsuario.PlaceholderColor = Color.Gray;
            tbBuscarUsuario.PlaceholderText = "Buscar usuario";
            tbBuscarUsuario.Size = new Size(171, 31);
            tbBuscarUsuario.TabIndex = 11;
            tbBuscarUsuario.Texts = "";
            tbBuscarUsuario.UnderlinedStyle = false;
            tbBuscarUsuario._TextChanged += tbBuscarUsuario__TextChanged;
            // 
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.None;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(283, 15);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(63, 16);
            lbFiltrarUsuarios.TabIndex = 12;
            lbFiltrarUsuarios.Text = "Filtrar por";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(dgUsuarios);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(306, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 407);
            panel3.TabIndex = 2;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Crol, dataGridViewTextBoxColumn2, Cdni, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, CDarBaja, CModificar });
            dgUsuarios.Dock = DockStyle.Fill;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.MediumAquamarine;
            dgUsuarios.Location = new Point(0, 0);
            dgUsuarios.Margin = new Padding(3, 15, 3, 3);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(552, 407);
            dgUsuarios.TabIndex = 12;
            dgUsuarios.CellContentClick += dgUsuarios_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Crol
            // 
            Crol.HeaderText = "Rol";
            Crol.Name = "Crol";
            Crol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Cdni
            // 
            Cdni.HeaderText = "DNI";
            Cdni.Name = "Cdni";
            Cdni.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Direccion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Correo";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // CDarBaja
            // 
            CDarBaja.HeaderText = "Dar Baja";
            CDarBaja.Name = "CDarBaja";
            CDarBaja.ReadOnly = true;
            // 
            // CModificar
            // 
            CModificar.HeaderText = "Modificar";
            CModificar.Name = "CModificar";
            CModificar.ReadOnly = true;
            CModificar.Resizable = DataGridViewTriState.True;
            CModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // rolesRepositorioBindingSource
            // 
            rolesRepositorioBindingSource.DataSource = typeof(Repositorio.RolesRepositorio);
            // 
            // tbAltura
            // 
            tbAltura.BackColor = SystemColors.Window;
            tbAltura.BorderColor = SystemColors.Window;
            tbAltura.BorderFocusColor = Color.MidnightBlue;
            tbAltura.BorderRadius = 11;
            tbAltura.BorderSize = 2;
            tbAltura.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbAltura.ForeColor = Color.FromArgb(64, 64, 64);
            tbAltura.Location = new Point(184, 265);
            tbAltura.Margin = new Padding(4);
            tbAltura.Multiline = false;
            tbAltura.Name = "tbAltura";
            tbAltura.Padding = new Padding(10, 7, 10, 7);
            tbAltura.PasswordChar = false;
            tbAltura.PlaceholderColor = Color.Gray;
            tbAltura.PlaceholderText = "Direccion";
            tbAltura.Size = new Size(82, 31);
            tbAltura.TabIndex = 28;
            tbAltura.Texts = "";
            tbAltura.UnderlinedStyle = false;
            tbAltura._TextChanged += rjTextBox1__TextChanged;
            // 
            // FormGestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 101, 114);
            ClientSize = new Size(858, 482);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormGestionarUsuarios";
            Text = "Gestionar Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LRegistrarUsuario;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private RJTextBox tbNombre;
        private RJTextBox tbCalle;
        private RJTextBox tbTelefono;
        private RJTextBox tbApellido;
        private ComboBox cbRol;
        private RJTextBox tbCorreo;
        private RJButton btRegistrar;
        private RJTextBox tbContrasena;
        private Panel panel2;
        private Label lbFiltrarUsuarios;
        private Panel panel3;
        private RJTextBox tbBuscarUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJTextBox tbRepetirContrasena;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private Label lbError;
        private BindingSource rolesRepositorioBindingSource1;
        private BindingSource rolesRepositorioBindingSource;
        private RJButton btCancelar;
        private ComboBox cbFiltrarUsuarios;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Crol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Cdni;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn CDarBaja;
        private DataGridViewButtonColumn CModificar;
        private RJTextBox tbDNI;
        private RJTextBox tbAltura;
    }
}