using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class FormSolicitudes
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
            ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            lbError = new Label();
            dtFechaMovimeintos = new DateTimePicker();
            lbFiltrarUsuarios = new Label();
            LRegistrarUsuario = new Label();
            btRegistrar = new RJButton();
            tbApellido = new RJTextBox();
            tbDni = new RJTextBox();
            tbNombre = new RJTextBox();
            panel2 = new Panel();
            lbSolicitudes = new Label();
            panel3 = new Panel();
            dgSolicitudes = new DataGridView();
            CIDSolicitud = new DataGridViewTextBoxColumn();
            CEstado = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CDNI = new DataGridViewTextBoxColumn();
            CFecha_soli = new DataGridViewTextBoxColumn();
            CCancelar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(ErrorIcon);
            panel1.Controls.Add(lbError);
            panel1.Controls.Add(dtFechaMovimeintos);
            panel1.Controls.Add(lbFiltrarUsuarios);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbDni);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 450);
            panel1.TabIndex = 0;
            // 
            // ErrorIcon
            // 
            ErrorIcon.Anchor = AnchorStyles.None;
            ErrorIcon.BackColor = Color.Transparent;
            ErrorIcon.ForeColor = Color.DarkRed;
            ErrorIcon.IconChar = FontAwesome.Sharp.IconChar.Warning;
            ErrorIcon.IconColor = Color.DarkRed;
            ErrorIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ErrorIcon.IconSize = 30;
            ErrorIcon.Location = new Point(29, 35);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(30, 36);
            ErrorIcon.TabIndex = 27;
            ErrorIcon.TabStop = false;
            ErrorIcon.Visible = false;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.None;
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.DarkRed;
            lbError.Location = new Point(56, 36);
            lbError.Name = "lbError";
            lbError.Size = new Size(37, 16);
            lbError.TabIndex = 26;
            lbError.Text = "Error";
            lbError.Visible = false;
            lbError.Click += lbError_Click;
            // 
            // dtFechaMovimeintos
            // 
            dtFechaMovimeintos.Anchor = AnchorStyles.None;
            dtFechaMovimeintos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaMovimeintos.Format = DateTimePickerFormat.Custom;
            dtFechaMovimeintos.Location = new Point(26, 235);
            dtFechaMovimeintos.MinDate = new DateTime(2023, 10, 27, 19, 24, 43, 0);
            dtFechaMovimeintos.Name = "dtFechaMovimeintos";
            dtFechaMovimeintos.Size = new Size(225, 26);
            dtFechaMovimeintos.TabIndex = 21;
            dtFechaMovimeintos.Value = new DateTime(2023, 10, 27, 19, 24, 43, 0);
            // 
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.None;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(26, 86);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(128, 17);
            lbFiltrarUsuarios.TabIndex = 20;
            lbFiltrarUsuarios.Text = "Datos del visitante";
            // 
            // LRegistrarUsuario
            // 
            LRegistrarUsuario.Anchor = AnchorStyles.None;
            LRegistrarUsuario.AutoSize = true;
            LRegistrarUsuario.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LRegistrarUsuario.ForeColor = SystemColors.ButtonFace;
            LRegistrarUsuario.Location = new Point(29, 9);
            LRegistrarUsuario.Name = "LRegistrarUsuario";
            LRegistrarUsuario.Size = new Size(213, 23);
            LRegistrarUsuario.TabIndex = 10;
            LRegistrarUsuario.Text = "AGREGAR SOLICITUD";
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
            btRegistrar.Location = new Point(78, 305);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(107, 40);
            btRegistrar.TabIndex = 19;
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
            tbApellido.Location = new Point(26, 146);
            tbApellido.Margin = new Padding(4);
            tbApellido.Multiline = false;
            tbApellido.Name = "tbApellido";
            tbApellido.Padding = new Padding(10, 7, 10, 7);
            tbApellido.PasswordChar = false;
            tbApellido.PlaceholderColor = Color.Gray;
            tbApellido.PlaceholderText = "Apellido";
            tbApellido.Size = new Size(225, 31);
            tbApellido.TabIndex = 12;
            tbApellido.Texts = "";
            tbApellido.UnderlinedStyle = false;
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
            tbDni.Location = new Point(26, 185);
            tbDni.Margin = new Padding(4);
            tbDni.Multiline = false;
            tbDni.Name = "tbDni";
            tbDni.Padding = new Padding(10, 7, 10, 7);
            tbDni.PasswordChar = false;
            tbDni.PlaceholderColor = Color.Gray;
            tbDni.PlaceholderText = "DNI";
            tbDni.Size = new Size(225, 31);
            tbDni.TabIndex = 14;
            tbDni.Texts = "";
            tbDni.UnderlinedStyle = false;
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
            tbNombre.Location = new Point(26, 107);
            tbNombre.Margin = new Padding(4);
            tbNombre.Multiline = false;
            tbNombre.Name = "tbNombre";
            tbNombre.Padding = new Padding(10, 7, 10, 7);
            tbNombre.PasswordChar = false;
            tbNombre.PlaceholderColor = Color.Gray;
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(225, 31);
            tbNombre.TabIndex = 11;
            tbNombre.Texts = "";
            tbNombre.UnderlinedStyle = false;
            tbNombre.KeyPress += tbNombre_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(lbSolicitudes);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(279, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 78);
            panel2.TabIndex = 1;
            // 
            // lbSolicitudes
            // 
            lbSolicitudes.Anchor = AnchorStyles.Top;
            lbSolicitudes.AutoSize = true;
            lbSolicitudes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSolicitudes.ForeColor = SystemColors.ButtonFace;
            lbSolicitudes.Location = new Point(6, 52);
            lbSolicitudes.Name = "lbSolicitudes";
            lbSolicitudes.Size = new Size(192, 19);
            lbSolicitudes.TabIndex = 11;
            lbSolicitudes.Text = "SOLICITUDES PENDIENTES";
            lbSolicitudes.Click += lbSolicitudes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(dgSolicitudes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(279, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(521, 372);
            panel3.TabIndex = 2;
            // 
            // dgSolicitudes
            // 
            dgSolicitudes.AllowUserToAddRows = false;
            dgSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSolicitudes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgSolicitudes.BorderStyle = BorderStyle.None;
            dgSolicitudes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitudes.Columns.AddRange(new DataGridViewColumn[] { CIDSolicitud, CEstado, CNombre, CApellido, CDNI, CFecha_soli, CCancelar });
            dgSolicitudes.Dock = DockStyle.Fill;
            dgSolicitudes.EnableHeadersVisualStyles = false;
            dgSolicitudes.GridColor = Color.MediumAquamarine;
            dgSolicitudes.Location = new Point(0, 0);
            dgSolicitudes.Margin = new Padding(3, 15, 3, 3);
            dgSolicitudes.Name = "dgSolicitudes";
            dgSolicitudes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgSolicitudes.RowTemplate.Height = 25;
            dgSolicitudes.Size = new Size(521, 372);
            dgSolicitudes.TabIndex = 13;
            dgSolicitudes.CellContentClick += dgSolicitudes_CellContentClick;
            // 
            // CIDSolicitud
            // 
            CIDSolicitud.HeaderText = "ID";
            CIDSolicitud.Name = "CIDSolicitud";
            CIDSolicitud.ReadOnly = true;
            CIDSolicitud.Visible = false;
            // 
            // CEstado
            // 
            CEstado.HeaderText = "Estado";
            CEstado.Name = "CEstado";
            CEstado.ReadOnly = true;
            // 
            // CNombre
            // 
            CNombre.HeaderText = "Nombre";
            CNombre.Name = "CNombre";
            CNombre.ReadOnly = true;
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
            // CFecha_soli
            // 
            CFecha_soli.HeaderText = "Fecha";
            CFecha_soli.Name = "CFecha_soli";
            CFecha_soli.ReadOnly = true;
            // 
            // CCancelar
            // 
            CCancelar.HeaderText = "Cancelar";
            CCancelar.Name = "CCancelar";
            CCancelar.ReadOnly = true;
            // 
            // FormSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormSolicitudes";
            Text = "Movimientos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LRegistrarUsuario;
        private RJButton btRegistrar;
        private RJTextBox tbApellido;
        private RJTextBox tbDni;
        private RJTextBox tbNombre;
        private Panel panel2;
        private Panel panel3;
        private Label lbFiltrarUsuarios;
        private DateTimePicker dtFechaMovimeintos;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private Label lbError;
        private Label lbSolicitudes;
        private DataGridView dgSolicitudes;
        private DataGridViewTextBoxColumn CEstado;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CFecha_soli;
        private DataGridViewButtonColumn CCancelar;
        private DataGridViewTextBoxColumn CIDSolicitud;
    }
}