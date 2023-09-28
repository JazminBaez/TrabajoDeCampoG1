using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class FormEgresos
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
            panel2 = new Panel();
            btnRegistrarEgreso = new RJButton();
            lbObservaciones = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarUsuario = new RJTextBox();
            lbVisitantesActuales = new Label();
            rjTextBox1 = new RJTextBox();
            panel3 = new Panel();
            dgUsuarios = new DataGridView();
            Cselect = new DataGridViewCheckBoxColumn();
            CResponsable = new DataGridViewTextBoxColumn();
            CVisitante = new DataGridViewTextBoxColumn();
            CDNIvisitante = new DataGridViewTextBoxColumn();
            Cfecha = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 70, 122);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 38, 58);
            panel2.Controls.Add(btnRegistrarEgreso);
            panel2.Controls.Add(lbObservaciones);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(tbBuscarUsuario);
            panel2.Controls.Add(lbVisitantesActuales);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 1;
            // 
            // btnRegistrarEgreso
            // 
            btnRegistrarEgreso.BackColor = Color.White;
            btnRegistrarEgreso.BackgroundColor = Color.White;
            btnRegistrarEgreso.BorderColor = Color.Transparent;
            btnRegistrarEgreso.BorderRadius = 10;
            btnRegistrarEgreso.BorderSize = 0;
            btnRegistrarEgreso.FlatAppearance.BorderSize = 0;
            btnRegistrarEgreso.FlatStyle = FlatStyle.Flat;
            btnRegistrarEgreso.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarEgreso.ForeColor = SystemColors.Desktop;
            btnRegistrarEgreso.Location = new Point(37, 170);
            btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            btnRegistrarEgreso.Size = new Size(151, 40);
            btnRegistrarEgreso.TabIndex = 28;
            btnRegistrarEgreso.Text = "REGISTRAR EGRESO";
            btnRegistrarEgreso.TextColor = SystemColors.Desktop;
            btnRegistrarEgreso.UseVisualStyleBackColor = false;
            // 
            // lbObservaciones
            // 
            lbObservaciones.Anchor = AnchorStyles.None;
            lbObservaciones.AutoSize = true;
            lbObservaciones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbObservaciones.ForeColor = SystemColors.ButtonFace;
            lbObservaciones.Location = new Point(47, 45);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(174, 17);
            lbObservaciones.TabIndex = 27;
            lbObservaciones.Text = "Observaciones (opcional)";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(719, 18);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 26;
            iconPictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = SystemColors.Control;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(668, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 32);
            btnBuscar.TabIndex = 25;
            btnBuscar.TabStop = false;
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
            tbBuscarUsuario.Location = new Point(490, 18);
            tbBuscarUsuario.Margin = new Padding(4);
            tbBuscarUsuario.Multiline = false;
            tbBuscarUsuario.Name = "tbBuscarUsuario";
            tbBuscarUsuario.Padding = new Padding(10, 7, 10, 7);
            tbBuscarUsuario.PasswordChar = false;
            tbBuscarUsuario.PlaceholderColor = Color.Gray;
            tbBuscarUsuario.PlaceholderText = "Buscar usuario";
            tbBuscarUsuario.Size = new Size(171, 31);
            tbBuscarUsuario.TabIndex = 24;
            tbBuscarUsuario.Texts = "";
            tbBuscarUsuario.UnderlinedStyle = false;
            // 
            // lbVisitantesActuales
            // 
            lbVisitantesActuales.Anchor = AnchorStyles.None;
            lbVisitantesActuales.AutoSize = true;
            lbVisitantesActuales.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbVisitantesActuales.ForeColor = SystemColors.ButtonFace;
            lbVisitantesActuales.Location = new Point(258, 27);
            lbVisitantesActuales.Name = "lbVisitantesActuales";
            lbVisitantesActuales.Size = new Size(214, 23);
            lbVisitantesActuales.TabIndex = 23;
            lbVisitantesActuales.Text = "VISITANTES ACTUALES";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.DeepSkyBlue;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(37, 66);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = true;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(200, 97);
            rjTextBox1.TabIndex = 1;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgUsuarios);
            panel3.Location = new Point(258, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 251);
            panel3.TabIndex = 0;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { Cselect, CResponsable, CVisitante, CDNIvisitante, Cfecha });
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
            dgUsuarios.Size = new Size(493, 251);
            dgUsuarios.TabIndex = 13;
            // 
            // Cselect
            // 
            Cselect.HeaderText = "";
            Cselect.Name = "Cselect";
            Cselect.ReadOnly = true;
            Cselect.Resizable = DataGridViewTriState.True;
            Cselect.SortMode = DataGridViewColumnSortMode.Automatic;
            Cselect.Width = 18;
            // 
            // CResponsable
            // 
            CResponsable.HeaderText = "Responsable";
            CResponsable.Name = "CResponsable";
            CResponsable.ReadOnly = true;
            CResponsable.Width = 126;
            // 
            // CVisitante
            // 
            CVisitante.HeaderText = "Visitante";
            CVisitante.Name = "CVisitante";
            CVisitante.ReadOnly = true;
            CVisitante.Width = 94;
            // 
            // CDNIvisitante
            // 
            CDNIvisitante.HeaderText = "DNI visita";
            CDNIvisitante.Name = "CDNIvisitante";
            CDNIvisitante.ReadOnly = true;
            CDNIvisitante.Width = 98;
            // 
            // Cfecha
            // 
            Cfecha.HeaderText = "Fecha";
            Cfecha.Name = "Cfecha";
            Cfecha.ReadOnly = true;
            Cfecha.Width = 78;
            // 
            // FormEgresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEgresos";
            Text = "FormEgresos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Controls.RJTextBox rjTextBox1;
        private Panel panel3;
        private Label lbVisitantesActuales;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private RJTextBox tbBuscarUsuario;
        private RJButton btnRegistrarEgreso;
        private Label lbObservaciones;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dgUsuarios;
        private DataGridViewCheckBoxColumn Cselect;
        private DataGridViewTextBoxColumn CResponsable;
        private DataGridViewTextBoxColumn CVisitante;
        private DataGridViewTextBoxColumn CDNIvisitante;
        private DataGridViewTextBoxColumn Cfecha;
    }
}