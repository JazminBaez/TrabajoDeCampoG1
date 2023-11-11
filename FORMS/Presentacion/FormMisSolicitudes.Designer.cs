namespace seguridad_barrios_privados.Presentacion
{
    partial class FormMisSolicitudes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tbBuscarUsuario = new Controls.RJTextBox();
            dtFechaHasta = new DateTimePicker();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            dtFechaDesde = new DateTimePicker();
            lbFiltrarMoviminetos = new Label();
            lbFiltrarMovimientos = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            cbFiltraSolicitudes = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            dgSolicitudes = new DataGridView();
            CIDSolicitud = new DataGridViewTextBoxColumn();
            CEstado = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CDNI = new DataGridViewTextBoxColumn();
            CFecha_soli = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(tbBuscarUsuario);
            panel1.Controls.Add(dtFechaHasta);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(dtFechaDesde);
            panel1.Controls.Add(lbFiltrarMoviminetos);
            panel1.Controls.Add(lbFiltrarMovimientos);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(cbFiltraSolicitudes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 76);
            panel1.TabIndex = 0;
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
            tbBuscarUsuario.Location = new Point(28, 26);
            tbBuscarUsuario.Margin = new Padding(4);
            tbBuscarUsuario.Multiline = false;
            tbBuscarUsuario.Name = "tbBuscarUsuario";
            tbBuscarUsuario.Padding = new Padding(10, 7, 10, 7);
            tbBuscarUsuario.PasswordChar = false;
            tbBuscarUsuario.PlaceholderColor = Color.Gray;
            tbBuscarUsuario.PlaceholderText = "Buscar visitante";
            tbBuscarUsuario.Size = new Size(182, 31);
            tbBuscarUsuario.TabIndex = 24;
            tbBuscarUsuario.Texts = "";
            tbBuscarUsuario.UnderlinedStyle = false;
            tbBuscarUsuario._TextChanged += tbBuscarUsuario__TextChanged;
            // 
            // dtFechaHasta
            // 
            dtFechaHasta.Anchor = AnchorStyles.None;
            dtFechaHasta.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaHasta.Format = DateTimePickerFormat.Custom;
            dtFechaHasta.Location = new Point(609, 34);
            dtFechaHasta.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dtFechaHasta.Name = "dtFechaHasta";
            dtFechaHasta.Size = new Size(125, 26);
            dtFechaHasta.TabIndex = 23;
            dtFechaHasta.ValueChanged += dtFechaHasta_ValueChanged;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpShortWide;
            iconPictureBox2.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(760, 26);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 44);
            iconPictureBox2.TabIndex = 16;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Anchor = AnchorStyles.None;
            dtFechaDesde.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaDesde.Format = DateTimePickerFormat.Custom;
            dtFechaDesde.Location = new Point(462, 34);
            dtFechaDesde.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(131, 26);
            dtFechaDesde.TabIndex = 22;
            dtFechaDesde.ValueChanged += dtFechaDesde_ValueChanged;
            // 
            // lbFiltrarMoviminetos
            // 
            lbFiltrarMoviminetos.AutoSize = true;
            lbFiltrarMoviminetos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarMoviminetos.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarMoviminetos.Location = new Point(273, 14);
            lbFiltrarMoviminetos.Name = "lbFiltrarMoviminetos";
            lbFiltrarMoviminetos.Size = new Size(68, 17);
            lbFiltrarMoviminetos.TabIndex = 15;
            lbFiltrarMoviminetos.Text = "Filtrar por";
            // 
            // lbFiltrarMovimientos
            // 
            lbFiltrarMovimientos.Anchor = AnchorStyles.None;
            lbFiltrarMovimientos.AutoSize = true;
            lbFiltrarMovimientos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarMovimientos.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarMovimientos.Location = new Point(462, 14);
            lbFiltrarMovimientos.Name = "lbFiltrarMovimientos";
            lbFiltrarMovimientos.Size = new Size(147, 17);
            lbFiltrarMovimientos.TabIndex = 21;
            lbFiltrarMovimientos.Text = "Seleccione una fecha";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(806, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 44);
            iconPictureBox1.TabIndex = 14;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // cbFiltraSolicitudes
            // 
            cbFiltraSolicitudes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltraSolicitudes.FormattingEnabled = true;
            cbFiltraSolicitudes.Items.AddRange(new object[] { "pendiente", "aceptado", "rechazado" });
            cbFiltraSolicitudes.Location = new Point(273, 34);
            cbFiltraSolicitudes.Name = "cbFiltraSolicitudes";
            cbFiltraSolicitudes.Size = new Size(123, 28);
            cbFiltraSolicitudes.TabIndex = 0;
            cbFiltraSolicitudes.Text = "Estado";
            cbFiltraSolicitudes.SelectedIndexChanged += cbFiltrarSolicitudes_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 406);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 403);
            panel4.Name = "panel4";
            panel4.Size = new Size(858, 3);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(dgSolicitudes);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 403);
            panel3.TabIndex = 4;
            // 
            // dgSolicitudes
            // 
            dgSolicitudes.AllowUserToAddRows = false;
            dgSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSolicitudes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgSolicitudes.BorderStyle = BorderStyle.None;
            dgSolicitudes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitudes.Columns.AddRange(new DataGridViewColumn[] { CIDSolicitud, CEstado, CNombre, CApellido, CDNI, CFecha_soli });
            dgSolicitudes.Dock = DockStyle.Fill;
            dgSolicitudes.EnableHeadersVisualStyles = false;
            dgSolicitudes.GridColor = Color.MediumAquamarine;
            dgSolicitudes.Location = new Point(0, 0);
            dgSolicitudes.Margin = new Padding(3, 15, 3, 3);
            dgSolicitudes.Name = "dgSolicitudes";
            dgSolicitudes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgSolicitudes.RowTemplate.Height = 25;
            dgSolicitudes.Size = new Size(858, 403);
            dgSolicitudes.TabIndex = 14;
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
            // FormMisSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMisSolicitudes";
            Text = "Informe Movimientos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox cbFiltraSolicitudes;
        private Panel panel3;
        private Label lbFiltrarMoviminetos;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private DataGridView dgSolicitudes;
        private DataGridViewTextBoxColumn CIDSolicitud;
        private DataGridViewTextBoxColumn CEstado;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CFecha_soli;
        private DateTimePicker dtFechaHasta;
        private DateTimePicker dtFechaDesde;
        private Label lbFiltrarMovimientos;
        private Controls.RJTextBox tbBuscarUsuario;
    }
}