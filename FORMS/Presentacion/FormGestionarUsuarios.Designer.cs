using seguridad_barrios_privados.Controls;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            lbError = new Label();
            tbRepetirContrasena = new RJTextBox();
            LRegistrarUsuario = new Label();
            btRegistrar = new RJButton();
            tbContrasena = new RJTextBox();
            tbApellido = new RJTextBox();
            tbCorreo = new RJTextBox();
            cbRol = new ComboBox();
            tbDireccion = new RJTextBox();
            tbTelefono = new RJTextBox();
            tbNombre = new RJTextBox();
            rolesRepositorioBindingSource1 = new BindingSource(components);
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarUsuario = new RJTextBox();
            cbFiltrarUsuarios = new ComboBox();
            lbFiltrarUsuarios = new Label();
            panel3 = new Panel();
            dgUsuarios = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            rolesRepositorioBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rolesRepositorioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(ErrorIcon);
            panel1.Controls.Add(lbError);
            panel1.Controls.Add(tbRepetirContrasena);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbContrasena);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbCorreo);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(tbDireccion);
            panel1.Controls.Add(tbTelefono);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 482);
            panel1.TabIndex = 0;
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
            lbError.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.DarkRed;
            lbError.Location = new Point(79, 64);
            lbError.Name = "lbError";
            lbError.Size = new Size(37, 16);
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
            tbRepetirContrasena.Location = new Point(41, 341);
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
            LRegistrarUsuario.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LRegistrarUsuario.ForeColor = SystemColors.Control;
            LRegistrarUsuario.Location = new Point(53, 35);
            LRegistrarUsuario.Name = "LRegistrarUsuario";
            LRegistrarUsuario.Size = new Size(204, 23);
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
            btRegistrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrar.ForeColor = Color.Black;
            btRegistrar.Location = new Point(105, 415);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(107, 40);
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
            tbContrasena.Location = new Point(41, 302);
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
            tbCorreo.Location = new Point(41, 263);
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
            cbRol.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(41, 381);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(225, 28);
            cbRol.TabIndex = 5;
            cbRol.SelectedIndexChanged += cbRol_SelectedIndexChanged;
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = SystemColors.Window;
            tbDireccion.BorderColor = SystemColors.Window;
            tbDireccion.BorderFocusColor = Color.MidnightBlue;
            tbDireccion.BorderRadius = 11;
            tbDireccion.BorderSize = 2;
            tbDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            tbDireccion.Location = new Point(41, 224);
            tbDireccion.Margin = new Padding(4);
            tbDireccion.Multiline = false;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Padding = new Padding(10, 7, 10, 7);
            tbDireccion.PasswordChar = false;
            tbDireccion.PlaceholderColor = Color.Gray;
            tbDireccion.PlaceholderText = "Direccion";
            tbDireccion.Size = new Size(225, 31);
            tbDireccion.TabIndex = 4;
            tbDireccion.Texts = "";
            tbDireccion.UnderlinedStyle = false;
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
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(tbBuscarUsuario);
            panel2.Controls.Add(cbFiltrarUsuarios);
            panel2.Controls.Add(lbFiltrarUsuarios);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(306, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 75);
            panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
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
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = SystemColors.Desktop;
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = SystemColors.Control;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(200, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 32);
            btnBuscar.TabIndex = 14;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscarUsuario
            // 
            tbBuscarUsuario.Anchor = AnchorStyles.None;
            tbBuscarUsuario.BackColor = SystemColors.Window;
            tbBuscarUsuario.BorderColor = SystemColors.Window;
            tbBuscarUsuario.BorderFocusColor = Color.MidnightBlue;
            tbBuscarUsuario.BorderRadius = 11;
            tbBuscarUsuario.BorderSize = 2;
            tbBuscarUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            tbBuscarUsuario.Location = new Point(22, 29);
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
            // 
            // cbFiltrarUsuarios
            // 
            cbFiltrarUsuarios.Anchor = AnchorStyles.None;
            cbFiltrarUsuarios.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            cbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltrarUsuarios.Items.AddRange(new object[] { "Administradores", "Guardias", "Propietarios" });
            cbFiltrarUsuarios.Location = new Point(283, 35);
            cbFiltrarUsuarios.Name = "cbFiltrarUsuarios";
            cbFiltrarUsuarios.Size = new Size(117, 25);
            cbFiltrarUsuarios.TabIndex = 13;
            cbFiltrarUsuarios.Text = "Roles";
            // 
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.None;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(283, 15);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(68, 17);
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
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.MediumAquamarine;
            dgUsuarios.Location = new Point(36, 32);
            dgUsuarios.Margin = new Padding(3, 15, 3, 3);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(494, 375);
            dgUsuarios.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 92;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Direccion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 105;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Correo";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 84;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Eliminiar";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Width = 75;
            // 
            // rolesRepositorioBindingSource
            // 
            rolesRepositorioBindingSource.DataSource = typeof(Repositorio.RolesRepositorio);
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
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
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
        private RJTextBox tbDireccion;
        private RJTextBox tbTelefono;
        private RJTextBox tbApellido;
        private ComboBox cbRol;
        private RJTextBox tbCorreo;
        private RJButton btRegistrar;
        private RJTextBox tbContrasena;
        private Panel panel2;
        private Label lbFiltrarUsuarios;
        private ComboBox cbFiltrarUsuarios;
        private Panel panel3;
        private RJTextBox tbBuscarUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private DataGridView dgUsuarios;
        private RJTextBox tbRepetirContrasena;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private Label lbError;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private BindingSource rolesRepositorioBindingSource1;
        private BindingSource rolesRepositorioBindingSource;
    }
}