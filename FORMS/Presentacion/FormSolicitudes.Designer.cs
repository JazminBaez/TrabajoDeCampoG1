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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dtFechaMovimeintos = new DateTimePicker();
            lbFiltrarUsuarios = new Label();
            LRegistrarUsuario = new Label();
            btRegistrar = new RJButton();
            tbApellido = new RJTextBox();
            TBDireccion = new RJTextBox();
            tbNombre = new RJTextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgUsuarios = new DataGridView();
            CEstado = new DataGridViewTextBoxColumn();
            CNombre = new DataGridViewTextBoxColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CDNI = new DataGridViewTextBoxColumn();
            CEliminar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dtFechaMovimeintos);
            panel1.Controls.Add(lbFiltrarUsuarios);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(TBDireccion);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 450);
            panel1.TabIndex = 0;
            // 
            // dtFechaMovimeintos
            // 
            dtFechaMovimeintos.Anchor = AnchorStyles.None;
            dtFechaMovimeintos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaMovimeintos.Format = DateTimePickerFormat.Custom;
            dtFechaMovimeintos.Location = new Point(26, 235);
            dtFechaMovimeintos.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dtFechaMovimeintos.Name = "dtFechaMovimeintos";
            dtFechaMovimeintos.Size = new Size(225, 26);
            dtFechaMovimeintos.TabIndex = 21;
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
            LRegistrarUsuario.Location = new Point(26, 55);
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
            // TBDireccion
            // 
            TBDireccion.Anchor = AnchorStyles.None;
            TBDireccion.BackColor = SystemColors.Window;
            TBDireccion.BorderColor = SystemColors.Window;
            TBDireccion.BorderFocusColor = Color.MidnightBlue;
            TBDireccion.BorderRadius = 11;
            TBDireccion.BorderSize = 2;
            TBDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            TBDireccion.Location = new Point(26, 185);
            TBDireccion.Margin = new Padding(4);
            TBDireccion.Multiline = false;
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Padding = new Padding(10, 7, 10, 7);
            TBDireccion.PasswordChar = false;
            TBDireccion.PlaceholderColor = Color.Gray;
            TBDireccion.PlaceholderText = "DNI";
            TBDireccion.Size = new Size(225, 31);
            TBDireccion.TabIndex = 14;
            TBDireccion.Texts = "";
            TBDireccion.UnderlinedStyle = false;
            TBDireccion.KeyPress += TBDireccion_KeyPress;
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
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(279, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 78);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(279, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(521, 372);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgUsuarios);
            panel4.Location = new Point(42, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(456, 265);
            panel4.TabIndex = 0;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { CEstado, CNombre, CApellido, CDNI, CEliminar });
            dgUsuarios.Dock = DockStyle.Fill;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.MediumAquamarine;
            dgUsuarios.Location = new Point(0, 0);
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
            dgUsuarios.Size = new Size(456, 265);
            dgUsuarios.TabIndex = 13;
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
            // CEliminar
            // 
            CEliminar.HeaderText = "Eliminar";
            CEliminar.Name = "CEliminar";
            CEliminar.ReadOnly = true;
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
            Text = "FormMovimientos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LRegistrarUsuario;
        private RJButton btRegistrar;
        private RJTextBox tbApellido;
        private RJTextBox TBDireccion;
        private RJTextBox tbNombre;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbFiltrarUsuarios;
        private DateTimePicker dtFechaMovimeintos;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn CEstado;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CEliminar;
    }
}