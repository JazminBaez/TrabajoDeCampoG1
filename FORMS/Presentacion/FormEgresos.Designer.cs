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
            panel2 = new Panel();
            lbObservaciones = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            tbBuscarUsuario = new RJTextBox();
            lbVisitantesActuales = new Label();
            rjTextBox1 = new RJTextBox();
            panel3 = new Panel();
            dgSolicitudes = new DataGridView();
            CID_soli = new DataGridViewTextBoxColumn();
            CPropietario = new DataGridViewTextBoxColumn();
            CVisitante_soli = new DataGridViewTextBoxColumn();
            CVisitante_Dni = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CAceptar_soli = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 38, 58);
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
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbObservaciones.ForeColor = SystemColors.ButtonFace;
            lbObservaciones.Location = new Point(29, 66);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(174, 17);
            lbObservaciones.TabIndex = 27;
            lbObservaciones.Text = "Observaciones (opcional)";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.Control;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.Control;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(693, 28);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 26;
            iconPictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = SystemColors.Control;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(642, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 32);
            btnBuscar.TabIndex = 25;
            btnBuscar.TabStop = false;
            // 
            // tbBuscarUsuario
            // 
            tbBuscarUsuario.Anchor = AnchorStyles.Top;
            tbBuscarUsuario.BackColor = SystemColors.Window;
            tbBuscarUsuario.BorderColor = SystemColors.Window;
            tbBuscarUsuario.BorderFocusColor = Color.MidnightBlue;
            tbBuscarUsuario.BorderRadius = 11;
            tbBuscarUsuario.BorderSize = 2;
            tbBuscarUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscarUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            tbBuscarUsuario.Location = new Point(464, 28);
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
            lbVisitantesActuales.Anchor = AnchorStyles.Top;
            lbVisitantesActuales.AutoSize = true;
            lbVisitantesActuales.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbVisitantesActuales.ForeColor = SystemColors.ButtonFace;
            lbVisitantesActuales.Location = new Point(233, 32);
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
            rjTextBox1.Location = new Point(19, 87);
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
            panel3.Controls.Add(dgSolicitudes);
            panel3.Location = new Point(233, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 372);
            panel3.TabIndex = 0;
            // 
            // dgSolicitudes
            // 
            dgSolicitudes.AllowUserToAddRows = false;
            dgSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            dgSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgSolicitudes.Columns.AddRange(new DataGridViewColumn[] { CID_soli, CPropietario, CVisitante_soli, CVisitante_Dni, dataGridViewTextBoxColumn1, CAceptar_soli });
            dgSolicitudes.Dock = DockStyle.Fill;
            dgSolicitudes.EnableHeadersVisualStyles = false;
            dgSolicitudes.GridColor = Color.MediumAquamarine;
            dgSolicitudes.Location = new Point(0, 0);
            dgSolicitudes.Margin = new Padding(3, 15, 3, 3);
            dgSolicitudes.Name = "dgSolicitudes";
            dgSolicitudes.ReadOnly = true;
            dgSolicitudes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgSolicitudes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgSolicitudes.RowTemplate.Height = 25;
            dgSolicitudes.Size = new Size(537, 372);
            dgSolicitudes.TabIndex = 15;
            // 
            // CID_soli
            // 
            CID_soli.HeaderText = "ID";
            CID_soli.Name = "CID_soli";
            CID_soli.ReadOnly = true;
            CID_soli.Width = 47;
            // 
            // CPropietario
            // 
            CPropietario.HeaderText = "Propietario";
            CPropietario.Name = "CPropietario";
            CPropietario.ReadOnly = true;
            CPropietario.Width = 112;
            // 
            // CVisitante_soli
            // 
            CVisitante_soli.HeaderText = "Visitante";
            CVisitante_soli.Name = "CVisitante_soli";
            CVisitante_soli.ReadOnly = true;
            CVisitante_soli.Width = 94;
            // 
            // CVisitante_Dni
            // 
            CVisitante_Dni.HeaderText = "DNI";
            CVisitante_Dni.Name = "CVisitante_Dni";
            CVisitante_Dni.ReadOnly = true;
            CVisitante_Dni.Width = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 78;
            // 
            // CAceptar_soli
            // 
            CAceptar_soli.HeaderText = "Egreso";
            CAceptar_soli.Name = "CAceptar_soli";
            CAceptar_soli.ReadOnly = true;
            CAceptar_soli.Width = 62;
            // 
            // FormEgresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "FormEgresos";
            Text = "Egresos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Controls.RJTextBox rjTextBox1;
        private Panel panel3;
        private Label lbVisitantesActuales;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private RJTextBox tbBuscarUsuario;
        private Label lbObservaciones;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dgSolicitudes;
        private DataGridViewTextBoxColumn CID_soli;
        private DataGridViewTextBoxColumn CPropietario;
        private DataGridViewTextBoxColumn CVisitante_soli;
        private DataGridViewTextBoxColumn CVisitante_Dni;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn CAceptar_soli;
    }
}