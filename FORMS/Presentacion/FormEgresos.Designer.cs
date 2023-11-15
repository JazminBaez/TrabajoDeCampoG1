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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btRegistrarEgreso = new RJButton();
            lbObservaciones = new Label();
            tbObservaciones = new RJTextBox();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarUsuario = new RJTextBox();
            lbVisitantesActuales = new Label();
            panel3 = new Panel();
            dgSolicitudes = new DataGridView();
            CIdSolicitud = new DataGridViewTextBoxColumn();
            CPropietario = new DataGridViewTextBoxColumn();
            CVisitante_soli = new DataGridViewTextBoxColumn();
            CVisitante_Dni = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel5 = new Panel();
            ckbFiltrarVisitas = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 38, 58);
            panel1.Controls.Add(btRegistrarEgreso);
            panel1.Controls.Add(lbObservaciones);
            panel1.Controls.Add(tbObservaciones);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 450);
            panel1.TabIndex = 0;
            // 
            // btRegistrarEgreso
            // 
            btRegistrarEgreso.BackColor = Color.GhostWhite;
            btRegistrarEgreso.BackgroundColor = Color.GhostWhite;
            btRegistrarEgreso.BorderColor = Color.LavenderBlush;
            btRegistrarEgreso.BorderRadius = 20;
            btRegistrarEgreso.BorderSize = 0;
            btRegistrarEgreso.FlatAppearance.BorderSize = 0;
            btRegistrarEgreso.FlatStyle = FlatStyle.Flat;
            btRegistrarEgreso.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrarEgreso.ForeColor = Color.Black;
            btRegistrarEgreso.Location = new Point(14, 236);
            btRegistrarEgreso.Name = "btRegistrarEgreso";
            btRegistrarEgreso.Size = new Size(107, 40);
            btRegistrarEgreso.TabIndex = 47;
            btRegistrarEgreso.Text = "REGISTRAR EGRESO";
            btRegistrarEgreso.TextColor = Color.Black;
            btRegistrarEgreso.UseVisualStyleBackColor = false;
            btRegistrarEgreso.Click += btRegistrarEgreso_Click;
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbObservaciones.ForeColor = SystemColors.ButtonFace;
            lbObservaciones.Location = new Point(24, 100);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(174, 17);
            lbObservaciones.TabIndex = 46;
            lbObservaciones.Text = "Observaciones (opcional)";
            // 
            // tbObservaciones
            // 
            tbObservaciones.BackColor = SystemColors.Window;
            tbObservaciones.BorderColor = Color.Transparent;
            tbObservaciones.BorderFocusColor = Color.DeepSkyBlue;
            tbObservaciones.BorderRadius = 15;
            tbObservaciones.BorderSize = 2;
            tbObservaciones.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbObservaciones.ForeColor = Color.FromArgb(64, 64, 64);
            tbObservaciones.Location = new Point(14, 121);
            tbObservaciones.Margin = new Padding(4);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Padding = new Padding(10, 7, 10, 7);
            tbObservaciones.PasswordChar = false;
            tbObservaciones.PlaceholderColor = Color.DarkGray;
            tbObservaciones.PlaceholderText = "";
            tbObservaciones.Size = new Size(200, 97);
            tbObservaciones.TabIndex = 45;
            tbObservaciones.Texts = "";
            tbObservaciones.UnderlinedStyle = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 38, 58);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(tbBuscarUsuario);
            panel2.Controls.Add(lbVisitantesActuales);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(221, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 94);
            panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(535, 48);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 46;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // tbBuscarUsuario
            // 
            tbBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbBuscarUsuario.BackColor = SystemColors.Window;
            tbBuscarUsuario.BorderColor = SystemColors.Window;
            tbBuscarUsuario.BorderFocusColor = Color.MidnightBlue;
            tbBuscarUsuario.BorderRadius = 11;
            tbBuscarUsuario.BorderSize = 2;
            tbBuscarUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            tbBuscarUsuario.Location = new Point(357, 49);
            tbBuscarUsuario.Margin = new Padding(4);
            tbBuscarUsuario.Multiline = false;
            tbBuscarUsuario.Name = "tbBuscarUsuario";
            tbBuscarUsuario.Padding = new Padding(10, 7, 10, 7);
            tbBuscarUsuario.PasswordChar = false;
            tbBuscarUsuario.PlaceholderColor = Color.Gray;
            tbBuscarUsuario.PlaceholderText = "Buscar visitante";
            tbBuscarUsuario.Size = new Size(171, 31);
            tbBuscarUsuario.TabIndex = 44;
            tbBuscarUsuario.Texts = "";
            tbBuscarUsuario.UnderlinedStyle = false;
            tbBuscarUsuario._TextChanged += tbBuscarUsuario__TextChanged;
            // 
            // lbVisitantesActuales
            // 
            lbVisitantesActuales.AutoSize = true;
            lbVisitantesActuales.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbVisitantesActuales.ForeColor = SystemColors.ButtonFace;
            lbVisitantesActuales.Location = new Point(0, 57);
            lbVisitantesActuales.Name = "lbVisitantesActuales";
            lbVisitantesActuales.Size = new Size(214, 23);
            lbVisitantesActuales.TabIndex = 43;
            lbVisitantesActuales.Text = "VISITANTES ACTUALES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(dgSolicitudes);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(221, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 251);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
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
            dgSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgSolicitudes.Columns.AddRange(new DataGridViewColumn[] { CIdSolicitud, CPropietario, CVisitante_soli, CVisitante_Dni, dataGridViewTextBoxColumn1 });
            dgSolicitudes.Dock = DockStyle.Fill;
            dgSolicitudes.EnableHeadersVisualStyles = false;
            dgSolicitudes.GridColor = Color.MediumAquamarine;
            dgSolicitudes.Location = new Point(0, 0);
            dgSolicitudes.Margin = new Padding(3, 15, 3, 3);
            dgSolicitudes.Name = "dgSolicitudes";
            dgSolicitudes.ReadOnly = true;
            dgSolicitudes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgSolicitudes.RowTemplate.Height = 25;
            dgSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSolicitudes.Size = new Size(579, 251);
            dgSolicitudes.TabIndex = 47;
            dgSolicitudes.CellContentClick += dgSolicitudes_CellContentClick;
            dgSolicitudes.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // CIdSolicitud
            // 
            CIdSolicitud.HeaderText = "ID";
            CIdSolicitud.Name = "CIdSolicitud";
            CIdSolicitud.ReadOnly = true;
            CIdSolicitud.Visible = false;
            // 
            // CPropietario
            // 
            CPropietario.HeaderText = "Propietario";
            CPropietario.Name = "CPropietario";
            CPropietario.ReadOnly = true;
            // 
            // CVisitante_soli
            // 
            CVisitante_soli.HeaderText = "Visitante";
            CVisitante_soli.Name = "CVisitante_soli";
            CVisitante_soli.ReadOnly = true;
            // 
            // CVisitante_Dni
            // 
            CVisitante_Dni.HeaderText = "DNI";
            CVisitante_Dni.Name = "CVisitante_Dni";
            CVisitante_Dni.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(18, 38, 58);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(221, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(579, 105);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(ckbFiltrarVisitas);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(579, 37);
            panel5.TabIndex = 0;
            // 
            // ckbFiltrarVisitas
            // 
            ckbFiltrarVisitas.AutoSize = true;
            ckbFiltrarVisitas.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ckbFiltrarVisitas.ForeColor = SystemColors.ButtonFace;
            ckbFiltrarVisitas.Location = new Point(6, 6);
            ckbFiltrarVisitas.Name = "ckbFiltrarVisitas";
            ckbFiltrarVisitas.Size = new Size(190, 20);
            ckbFiltrarVisitas.TabIndex = 0;
            ckbFiltrarVisitas.Text = "Visitas que superan 72 hs";
            ckbFiltrarVisitas.UseVisualStyleBackColor = true;
            ckbFiltrarVisitas.CheckedChanged += ckbFiltrarVisitas_CheckedChanged;
            // 
            // FormEgresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEgresos";
            Text = "Egresos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private RJButton btRegistrarEgreso;
        private Label lbObservaciones;
        private RJTextBox tbObservaciones;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJTextBox tbBuscarUsuario;
        private Label lbVisitantesActuales;
        private DataGridView dgSolicitudes;
        private DataGridViewTextBoxColumn CIdSolicitud;
        private DataGridViewTextBoxColumn CPropietario;
        private DataGridViewTextBoxColumn CVisitante_soli;
        private DataGridViewTextBoxColumn CVisitante_Dni;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Panel panel4;
        private Panel panel5;
        private CheckBox ckbFiltrarVisitas;
    }
}