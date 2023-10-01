using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class FormIngresos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            lbError = new Label();
            label1 = new Label();
            cbPropietarios = new ComboBox();
            lbFiltrarUsuarios = new Label();
            lbRegistrarIngreso = new Label();
            btRegistrar = new RJButton();
            tbApellido = new RJTextBox();
            tbDni = new RJTextBox();
            tbNombre = new RJTextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            lbSolicitudesRealizadas = new Label();
            dataGridView1 = new DataGridView();
            CSelect = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            panel5 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarSolicitud = new RJTextBox();
            label2 = new Label();
            panel4 = new Panel();
            dgUsuarios = new DataGridView();
            CNombre = new DataGridViewTextBoxColumn();
            CResponsable = new DataGridViewButtonColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CDNI = new DataGridViewTextBoxColumn();
            CEliminar = new DataGridViewTextBoxColumn();
            CAceptar = new DataGridViewButtonColumn();
            usuariosRepositorioBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuariosRepositorioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(ErrorIcon);
            panel1.Controls.Add(lbError);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbPropietarios);
            panel1.Controls.Add(lbFiltrarUsuarios);
            panel1.Controls.Add(lbRegistrarIngreso);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbDni);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 482);
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
            ErrorIcon.Location = new Point(22, 44);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(30, 36);
            ErrorIcon.TabIndex = 31;
            ErrorIcon.TabStop = false;
            ErrorIcon.Visible = false;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.DarkRed;
            lbError.Location = new Point(49, 45);
            lbError.Name = "lbError";
            lbError.Size = new Size(37, 16);
            lbError.TabIndex = 30;
            lbError.Text = "Error";
            lbError.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 244);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 29;
            label1.Text = "Propietario responsable";
            // 
            // cbPropietarios
            // 
            cbPropietarios.Anchor = AnchorStyles.None;
            cbPropietarios.DataSource = usuariosRepositorioBindingSource;
            cbPropietarios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbPropietarios.FormattingEnabled = true;
            cbPropietarios.Location = new Point(22, 264);
            cbPropietarios.Name = "cbPropietarios";
            cbPropietarios.Size = new Size(225, 28);
            cbPropietarios.TabIndex = 28;
            cbPropietarios.Text = "Propietarios";
            // 
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.None;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(22, 97);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(128, 17);
            lbFiltrarUsuarios.TabIndex = 27;
            lbFiltrarUsuarios.Text = "Datos del visitante";
            lbFiltrarUsuarios.Click += lbFiltrarUsuarios_Click;
            // 
            // lbRegistrarIngreso
            // 
            lbRegistrarIngreso.Anchor = AnchorStyles.None;
            lbRegistrarIngreso.AutoSize = true;
            lbRegistrarIngreso.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegistrarIngreso.ForeColor = SystemColors.ButtonFace;
            lbRegistrarIngreso.Location = new Point(22, 18);
            lbRegistrarIngreso.Name = "lbRegistrarIngreso";
            lbRegistrarIngreso.Size = new Size(205, 23);
            lbRegistrarIngreso.TabIndex = 22;
            lbRegistrarIngreso.Text = "REGISTRAR INGRESO";
            lbRegistrarIngreso.Click += LRegistrarUsuario_Click;
            // 
            // btRegistrar
            // 
            btRegistrar.Anchor = AnchorStyles.None;
            btRegistrar.BackColor = Color.GhostWhite;
            btRegistrar.BackgroundColor = Color.GhostWhite;
            btRegistrar.BorderColor = Color.LavenderBlush;
            btRegistrar.BorderRadius = 20;
            btRegistrar.BorderSize = 0;
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrar.ForeColor = Color.Black;
            btRegistrar.Location = new Point(75, 321);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(107, 40);
            btRegistrar.TabIndex = 26;
            btRegistrar.Text = "AGREGAR";
            btRegistrar.TextColor = Color.Black;
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbApellido
            // 
            tbApellido.Anchor = AnchorStyles.None;
            tbApellido.BackColor = SystemColors.Window;
            tbApellido.BorderColor = SystemColors.Window;
            tbApellido.BorderFocusColor = Color.MidnightBlue;
            tbApellido.BorderRadius = 11;
            tbApellido.BorderSize = 2;
            tbApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellido.ForeColor = Color.FromArgb(64, 64, 64);
            tbApellido.Location = new Point(22, 157);
            tbApellido.Margin = new Padding(4);
            tbApellido.Multiline = false;
            tbApellido.Name = "tbApellido";
            tbApellido.Padding = new Padding(10, 7, 10, 7);
            tbApellido.PasswordChar = false;
            tbApellido.PlaceholderColor = Color.Gray;
            tbApellido.PlaceholderText = "Apellido";
            tbApellido.Size = new Size(225, 31);
            tbApellido.TabIndex = 24;
            tbApellido.Texts = "";
            tbApellido.UnderlinedStyle = false;
            tbApellido._TextChanged += tbApellido__TextChanged;
            tbApellido.KeyPress += tbApellido_KeyPress;
            // 
            // tbDni
            // 
            tbDni.Anchor = AnchorStyles.None;
            tbDni.BackColor = SystemColors.Window;
            tbDni.BorderColor = SystemColors.Window;
            tbDni.BorderFocusColor = Color.MidnightBlue;
            tbDni.BorderRadius = 11;
            tbDni.BorderSize = 2;
            tbDni.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbDni.ForeColor = Color.FromArgb(64, 64, 64);
            tbDni.Location = new Point(22, 196);
            tbDni.Margin = new Padding(4);
            tbDni.Multiline = false;
            tbDni.Name = "tbDni";
            tbDni.Padding = new Padding(10, 7, 10, 7);
            tbDni.PasswordChar = false;
            tbDni.PlaceholderColor = Color.Gray;
            tbDni.PlaceholderText = "DNI";
            tbDni.Size = new Size(225, 31);
            tbDni.TabIndex = 25;
            tbDni.Texts = "";
            tbDni.UnderlinedStyle = false;
            tbDni._TextChanged += TBDireccion__TextChanged;
            tbDni.KeyPress += TBDireccion_KeyPress;
            // 
            // tbNombre
            // 
            tbNombre.Anchor = AnchorStyles.None;
            tbNombre.BackColor = SystemColors.Window;
            tbNombre.BorderColor = SystemColors.Window;
            tbNombre.BorderFocusColor = Color.MidnightBlue;
            tbNombre.BorderRadius = 11;
            tbNombre.BorderSize = 2;
            tbNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.FromArgb(64, 64, 64);
            tbNombre.Location = new Point(22, 118);
            tbNombre.Margin = new Padding(4);
            tbNombre.Multiline = false;
            tbNombre.Name = "tbNombre";
            tbNombre.Padding = new Padding(10, 7, 10, 7);
            tbNombre.PasswordChar = false;
            tbNombre.PlaceholderColor = Color.Gray;
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(225, 31);
            tbNombre.TabIndex = 23;
            tbNombre.Texts = "";
            tbNombre.UnderlinedStyle = false;
            tbNombre._TextChanged += tbNombre__TextChanged;
            tbNombre.KeyPress += tbNombre_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(278, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 482);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 38, 58);
            panel2.Controls.Add(lbSolicitudesRealizadas);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 407);
            panel2.TabIndex = 25;
            // 
            // lbSolicitudesRealizadas
            // 
            lbSolicitudesRealizadas.Anchor = AnchorStyles.None;
            lbSolicitudesRealizadas.AutoSize = true;
            lbSolicitudesRealizadas.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSolicitudesRealizadas.ForeColor = SystemColors.ButtonFace;
            lbSolicitudesRealizadas.Location = new Point(36, 39);
            lbSolicitudesRealizadas.Name = "lbSolicitudesRealizadas";
            lbSolicitudesRealizadas.Size = new Size(196, 19);
            lbSolicitudesRealizadas.TabIndex = 23;
            lbSolicitudesRealizadas.Text = "SOLICITUDES REALIZADAS";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CSelect, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumAquamarine;
            dataGridView1.Location = new Point(36, 61);
            dataGridView1.Margin = new Padding(3, 15, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 311);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CSelect
            // 
            CSelect.HeaderText = "";
            CSelect.Name = "CSelect";
            CSelect.Width = 5;
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
            // panel5
            // 
            panel5.BackColor = SystemColors.Desktop;
            panel5.Controls.Add(iconPictureBox2);
            panel5.Controls.Add(iconPictureBox1);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(tbBuscarSolicitud);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(580, 75);
            panel5.TabIndex = 24;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.None;
            iconPictureBox2.BackColor = SystemColors.Desktop;
            iconPictureBox2.ForeColor = SystemColors.Control;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox2.IconColor = SystemColors.Control;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(498, 21);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 16;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = SystemColors.Desktop;
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(688, 16);
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
            btnBuscar.Location = new Point(202, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 32);
            btnBuscar.TabIndex = 14;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscarSolicitud
            // 
            tbBuscarSolicitud.Anchor = AnchorStyles.None;
            tbBuscarSolicitud.BackColor = SystemColors.Window;
            tbBuscarSolicitud.BorderColor = SystemColors.Window;
            tbBuscarSolicitud.BorderFocusColor = Color.MidnightBlue;
            tbBuscarSolicitud.BorderRadius = 11;
            tbBuscarSolicitud.BorderSize = 2;
            tbBuscarSolicitud.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarSolicitud.ForeColor = Color.FromArgb(64, 64, 64);
            tbBuscarSolicitud.Location = new Point(24, 22);
            tbBuscarSolicitud.Margin = new Padding(4);
            tbBuscarSolicitud.Multiline = false;
            tbBuscarSolicitud.Name = "tbBuscarSolicitud";
            tbBuscarSolicitud.Padding = new Padding(10, 7, 10, 7);
            tbBuscarSolicitud.PasswordChar = false;
            tbBuscarSolicitud.PlaceholderColor = Color.Gray;
            tbBuscarSolicitud.PlaceholderText = "Buscar solicitud";
            tbBuscarSolicitud.Size = new Size(171, 31);
            tbBuscarSolicitud.TabIndex = 11;
            tbBuscarSolicitud.Texts = "";
            tbBuscarSolicitud.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(49, 91);
            label2.Name = "label2";
            label2.Size = new Size(244, 23);
            label2.TabIndex = 23;
            label2.Text = "SOLICITUDES PENDIENTES";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(dgUsuarios);
            panel4.Location = new Point(49, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 332);
            panel4.TabIndex = 0;
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
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { CNombre, CResponsable, CApellido, CDNI, CEliminar, CAceptar });
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
            dgUsuarios.Size = new Size(472, 332);
            dgUsuarios.TabIndex = 14;
            // 
            // CNombre
            // 
            CNombre.HeaderText = "Nombre";
            CNombre.Name = "CNombre";
            CNombre.ReadOnly = true;
            // 
            // CResponsable
            // 
            CResponsable.HeaderText = "Responsable";
            CResponsable.Name = "CResponsable";
            CResponsable.ReadOnly = true;
            // 
            // CApellido
            // 
            CApellido.HeaderText = "Apellido";
            CApellido.Name = "CApellido";
            CApellido.ReadOnly = true;
            // 
            // CDNI
            // 
            CDNI.HeaderText = "DNI";
            CDNI.Name = "CDNI";
            CDNI.ReadOnly = true;
            // 
            // CEliminar
            // 
            CEliminar.HeaderText = "Eliminar";
            CEliminar.Name = "CEliminar";
            CEliminar.ReadOnly = true;
            // 
            // CAceptar
            // 
            CAceptar.HeaderText = "Aceptar";
            CAceptar.Name = "CAceptar";
            CAceptar.ReadOnly = true;
            // 
            // usuariosRepositorioBindingSource
            // 
            usuariosRepositorioBindingSource.DataSource = typeof(Repositorio.UsuariosRepositorio);
            usuariosRepositorioBindingSource.CurrentChanged += usuariosRepositorioBindingSource_CurrentChanged;
            // 
            // FormIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 482);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormIngresos";
            Text = "FormIngresos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuariosRepositorioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lbFiltrarUsuarios;
        private Label lbRegistrarIngreso;
        private RJButton btRegistrar;
        private RJTextBox tbApellido;
        private RJTextBox tbDni;
        private RJTextBox tbNombre;
        private Label label1;
        private ComboBox cbPropietarios;
        private Panel panel4;
        private Label label2;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewButtonColumn CResponsable;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CEliminar;
        private DataGridViewButtonColumn CAceptar;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private Label lbError;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn CSelect;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private RJTextBox tbBuscarSolicitud;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lbSolicitudesRealizadas;
        private BindingSource usuariosRepositorioBindingSource;
    }
}