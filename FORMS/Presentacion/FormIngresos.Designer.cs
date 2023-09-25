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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            cbFiltrarMovimientos = new ComboBox();
            lbFiltrarUsuarios = new Label();
            lbRegistrarIngreso = new Label();
            btRegistrar = new RJButton();
            tbApellido = new RJTextBox();
            TBDireccion = new RJTextBox();
            tbNombre = new RJTextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            dgUsuarios = new DataGridView();
            CNombre = new DataGridViewTextBoxColumn();
            CResponsable = new DataGridViewButtonColumn();
            CApellido = new DataGridViewTextBoxColumn();
            CDNI = new DataGridViewTextBoxColumn();
            CEliminar = new DataGridViewTextBoxColumn();
            CAceptar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbFiltrarMovimientos);
            panel1.Controls.Add(lbFiltrarUsuarios);
            panel1.Controls.Add(lbRegistrarIngreso);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(TBDireccion);
            panel1.Controls.Add(tbNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 482);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 282);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 29;
            label1.Text = "Propietario responsable";
            // 
            // cbFiltrarMovimientos
            // 
            cbFiltrarMovimientos.Anchor = AnchorStyles.None;
            cbFiltrarMovimientos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltrarMovimientos.FormattingEnabled = true;
            cbFiltrarMovimientos.Items.AddRange(new object[] { "Ingresos", "Egresos" });
            cbFiltrarMovimientos.Location = new Point(27, 302);
            cbFiltrarMovimientos.Name = "cbFiltrarMovimientos";
            cbFiltrarMovimientos.Size = new Size(225, 28);
            cbFiltrarMovimientos.TabIndex = 28;
            cbFiltrarMovimientos.Text = "Tipo";
            // 
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.None;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(27, 135);
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
            lbRegistrarIngreso.Location = new Point(38, 86);
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
            btRegistrar.Location = new Point(80, 359);
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
            tbApellido.Location = new Point(27, 195);
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
            TBDireccion.Location = new Point(27, 234);
            TBDireccion.Margin = new Padding(4);
            TBDireccion.Multiline = false;
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Padding = new Padding(10, 7, 10, 7);
            TBDireccion.PasswordChar = false;
            TBDireccion.PlaceholderColor = Color.Gray;
            TBDireccion.PlaceholderText = "DNI";
            TBDireccion.Size = new Size(225, 31);
            TBDireccion.TabIndex = 25;
            TBDireccion.Texts = "";
            TBDireccion.UnderlinedStyle = false;
            TBDireccion._TextChanged += TBDireccion__TextChanged;
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
            tbNombre.Location = new Point(27, 156);
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
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(278, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 482);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(54, 68);
            label2.Name = "label2";
            label2.Size = new Size(244, 23);
            label2.TabIndex = 23;
            label2.Text = "SOLICITUDES PENDIENTES";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(dgUsuarios);
            panel4.Location = new Point(54, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 296);
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
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { CNombre, CResponsable, CApellido, CDNI, CEliminar, CAceptar });
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
            dgUsuarios.Size = new Size(472, 296);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lbFiltrarUsuarios;
        private Label lbRegistrarIngreso;
        private RJButton btRegistrar;
        private RJTextBox tbApellido;
        private RJTextBox TBDireccion;
        private RJTextBox tbNombre;
        private Label label1;
        private ComboBox cbFiltrarMovimientos;
        private Panel panel4;
        private Label label2;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewButtonColumn CResponsable;
        private DataGridViewTextBoxColumn CApellido;
        private DataGridViewTextBoxColumn CDNI;
        private DataGridViewTextBoxColumn CEliminar;
        private DataGridViewButtonColumn CAceptar;
    }
}