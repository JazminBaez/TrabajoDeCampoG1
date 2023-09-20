using FORMS.Controls;
namespace FORMS.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            LRegistrarUsuario = new Label();
            btRegistrar = new RJButton();
            tbRepeatPassword = new RJTextBox();
            tbPassword = new RJTextBox();
            tbApellido = new RJTextBox();
            tbCorreo = new RJTextBox();
            cbRol = new ComboBox();
            TBDireccion = new RJTextBox();
            tbTelefono = new RJTextBox();
            tbNombre = new RJTextBox();
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
            btnEliminar = new RJButton();
            panel4 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 101, 114);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbRepeatPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbCorreo);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(TBDireccion);
            panel1.Controls.Add(tbTelefono);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 482);
            panel1.TabIndex = 0;
            // 
            // LRegistrarUsuario
            // 
            LRegistrarUsuario.AutoSize = true;
            LRegistrarUsuario.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LRegistrarUsuario.ForeColor = SystemColors.Control;
            LRegistrarUsuario.Location = new Point(51, 52);
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
            btRegistrar.Location = new Point(100, 419);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(107, 40);
            btRegistrar.TabIndex = 9;
            btRegistrar.Text = "REGISTRAR";
            btRegistrar.TextColor = Color.Black;
            btRegistrar.UseVisualStyleBackColor = false;
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.BackColor = SystemColors.Window;
            tbRepeatPassword.BorderColor = SystemColors.Window;
            tbRepeatPassword.BorderFocusColor = Color.MidnightBlue;
            tbRepeatPassword.BorderRadius = 11;
            tbRepeatPassword.BorderSize = 2;
            tbRepeatPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbRepeatPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbRepeatPassword.Location = new Point(41, 341);
            tbRepeatPassword.Margin = new Padding(4);
            tbRepeatPassword.Multiline = false;
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.Padding = new Padding(10, 7, 10, 7);
            tbRepeatPassword.PasswordChar = false;
            tbRepeatPassword.PlaceholderColor = Color.Gray;
            tbRepeatPassword.PlaceholderText = "Repetir contraseña";
            tbRepeatPassword.Size = new Size(225, 31);
            tbRepeatPassword.TabIndex = 8;
            tbRepeatPassword.Texts = "";
            tbRepeatPassword.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.BorderColor = SystemColors.Window;
            tbPassword.BorderFocusColor = Color.MidnightBlue;
            tbPassword.BorderRadius = 11;
            tbPassword.BorderSize = 2;
            tbPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(41, 302);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = false;
            tbPassword.PlaceholderColor = Color.Gray;
            tbPassword.PlaceholderText = "Contraseña";
            tbPassword.Size = new Size(225, 31);
            tbPassword.TabIndex = 7;
            tbPassword.Texts = "";
            tbPassword.UnderlinedStyle = false;
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
            tbApellido._TextChanged += tbApellido__TextChanged;
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
            cbRol.Location = new Point(41, 379);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(225, 28);
            cbRol.TabIndex = 5;
            cbRol.Text = "Rol";
            // 
            // TBDireccion
            // 
            TBDireccion.BackColor = SystemColors.Window;
            TBDireccion.BorderColor = SystemColors.Window;
            TBDireccion.BorderFocusColor = Color.MidnightBlue;
            TBDireccion.BorderRadius = 11;
            TBDireccion.BorderSize = 2;
            TBDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            TBDireccion.Location = new Point(41, 224);
            TBDireccion.Margin = new Padding(4);
            TBDireccion.Multiline = false;
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Padding = new Padding(10, 7, 10, 7);
            TBDireccion.PasswordChar = false;
            TBDireccion.PlaceholderColor = Color.Gray;
            TBDireccion.PlaceholderText = "Direccion";
            TBDireccion.Size = new Size(225, 31);
            TBDireccion.TabIndex = 4;
            TBDireccion.Texts = "";
            TBDireccion.UnderlinedStyle = false;
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
            cbFiltrarUsuarios.Location = new Point(321, 34);
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
            lbFiltrarUsuarios.Location = new Point(321, 14);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(68, 17);
            lbFiltrarUsuarios.TabIndex = 12;
            lbFiltrarUsuarios.Text = "Filtrar por";
            lbFiltrarUsuarios.Click += lbFiltrarUsuarios_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Controls.Add(dgUsuarios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(306, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 289);
            panel3.TabIndex = 2;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dgUsuarios.Dock = DockStyle.Fill;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.MediumAquamarine;
            dgUsuarios.Location = new Point(0, 0);
            dgUsuarios.Margin = new Padding(3, 15, 3, 3);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(552, 289);
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
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.GhostWhite;
            btnEliminar.BackgroundColor = Color.GhostWhite;
            btnEliminar.BorderColor = Color.LavenderBlush;
            btnEliminar.BorderRadius = 20;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(423, 42);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 40);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextColor = Color.Black;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(iconPictureBox2);
            panel4.Controls.Add(btnEliminar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(306, 364);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 118);
            panel4.TabIndex = 11;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.None;
            iconPictureBox2.BackColor = SystemColors.Desktop;
            iconPictureBox2.ForeColor = SystemColors.Control;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox2.IconColor = SystemColors.Control;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(620, 52);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 15;
            iconPictureBox2.TabStop = false;
            // 
            // FormGestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 101, 114);
            ClientSize = new Size(858, 482);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormGestionarUsuarios";
            Text = "Gestionar Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LRegistrarUsuario;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private Controls.RJTextBox tbNombre;
        private RJTextBox TBDireccion;
        private RJTextBox tbTelefono;
        private RJTextBox tbApellido;
        private ComboBox cbRol;
        private RJTextBox tbCorreo;
        private RJButton btRegistrar;
        private RJTextBox tbRepeatPassword;
        private RJTextBox tbPassword;
        private Panel panel2;
        private Label lbFiltrarUsuarios;
        private ComboBox cbFiltrarUsuarios;
        private Panel panel3;
        private RJTextBox tbBuscarUsuario;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJButton btnEliminar;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
    }
}