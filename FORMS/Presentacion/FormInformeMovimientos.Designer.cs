namespace seguridad_barrios_privados.Presentacion
{
    partial class FormInformeMovimientos
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
            lbFiltrarMoviminetos = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lbFiltrarMovimientos = new Label();
            dtFechaMovimeintos = new DateTimePicker();
            cbFiltrarMovimientos = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            dgUsuarios = new DataGridView();
            CIDmovimientp = new DataGridViewTextBoxColumn();
            Ctipo = new DataGridViewTextBoxColumn();
            CResponsable = new DataGridViewTextBoxColumn();
            CVisitante = new DataGridViewTextBoxColumn();
            CDNIvisitante = new DataGridViewTextBoxColumn();
            Cfecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 25, 62);
            panel1.Controls.Add(lbFiltrarMoviminetos);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(lbFiltrarMovimientos);
            panel1.Controls.Add(dtFechaMovimeintos);
            panel1.Controls.Add(cbFiltrarMovimientos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 76);
            panel1.TabIndex = 0;
            // 
            // lbFiltrarMoviminetos
            // 
            lbFiltrarMoviminetos.Anchor = AnchorStyles.None;
            lbFiltrarMoviminetos.AutoSize = true;
            lbFiltrarMoviminetos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarMoviminetos.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarMoviminetos.Location = new Point(40, 12);
            lbFiltrarMoviminetos.Name = "lbFiltrarMoviminetos";
            lbFiltrarMoviminetos.Size = new Size(68, 17);
            lbFiltrarMoviminetos.TabIndex = 15;
            lbFiltrarMoviminetos.Text = "Filtrar por";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.FromArgb(0, 38, 66);
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(806, 32);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 44);
            iconPictureBox1.TabIndex = 14;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // lbFiltrarMovimientos
            // 
            lbFiltrarMovimientos.Anchor = AnchorStyles.None;
            lbFiltrarMovimientos.AutoSize = true;
            lbFiltrarMovimientos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarMovimientos.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarMovimientos.Location = new Point(493, 14);
            lbFiltrarMovimientos.Name = "lbFiltrarMovimientos";
            lbFiltrarMovimientos.Size = new Size(147, 17);
            lbFiltrarMovimientos.TabIndex = 13;
            lbFiltrarMovimientos.Text = "Seleccione una fecha";
            // 
            // dtFechaMovimeintos
            // 
            dtFechaMovimeintos.Anchor = AnchorStyles.None;
            dtFechaMovimeintos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaMovimeintos.Format = DateTimePickerFormat.Custom;
            dtFechaMovimeintos.Location = new Point(493, 34);
            dtFechaMovimeintos.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dtFechaMovimeintos.Name = "dtFechaMovimeintos";
            dtFechaMovimeintos.Size = new Size(200, 26);
            dtFechaMovimeintos.TabIndex = 1;
            dtFechaMovimeintos.ValueChanged += dtFechaMovimeintos_ValueChanged;
            // 
            // cbFiltrarMovimientos
            // 
            cbFiltrarMovimientos.Anchor = AnchorStyles.None;
            cbFiltrarMovimientos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFiltrarMovimientos.FormattingEnabled = true;
            cbFiltrarMovimientos.Items.AddRange(new object[] { "Ingresos", "Egresos" });
            cbFiltrarMovimientos.Location = new Point(40, 32);
            cbFiltrarMovimientos.Name = "cbFiltrarMovimientos";
            cbFiltrarMovimientos.Size = new Size(176, 28);
            cbFiltrarMovimientos.TabIndex = 0;
            cbFiltrarMovimientos.Text = "Tipo";
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
            panel4.BackColor = Color.FromArgb(26, 25, 62);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 305);
            panel4.Name = "panel4";
            panel4.Size = new Size(858, 101);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 38, 58);
            panel3.Controls.Add(dgUsuarios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 305);
            panel3.TabIndex = 4;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.Anchor = AnchorStyles.None;
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
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { CIDmovimientp, Ctipo, CResponsable, CVisitante, CDNIvisitante, Cfecha });
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.MediumAquamarine;
            dgUsuarios.Location = new Point(34, 18);
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
            dgUsuarios.Size = new Size(794, 262);
            dgUsuarios.TabIndex = 12;
            // 
            // CIDmovimientp
            // 
            CIDmovimientp.HeaderText = "ID";
            CIDmovimientp.Name = "CIDmovimientp";
            CIDmovimientp.ReadOnly = true;
            // 
            // Ctipo
            // 
            Ctipo.HeaderText = "Tipo";
            Ctipo.Name = "Ctipo";
            // 
            // CResponsable
            // 
            CResponsable.HeaderText = "Responsable";
            CResponsable.Name = "CResponsable";
            CResponsable.ReadOnly = true;
            // 
            // CVisitante
            // 
            CVisitante.HeaderText = "Visitante";
            CVisitante.Name = "CVisitante";
            CVisitante.ReadOnly = true;
            // 
            // CDNIvisitante
            // 
            CDNIvisitante.HeaderText = "DNI visita";
            CDNIvisitante.Name = "CDNIvisitante";
            CDNIvisitante.ReadOnly = true;
            // 
            // Cfecha
            // 
            Cfecha.HeaderText = "Fecha";
            Cfecha.Name = "Cfecha";
            Cfecha.ReadOnly = true;
            // 
            // FormInformeMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormInformeMovimientos";
            Text = "FormInformeMovimientos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtFechaMovimeintos;
        private ComboBox cbFiltrarMovimientos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbFiltrarMovimientos;
        private Panel panel3;
        private DataGridView dgUsuarios;
        private Label lbFiltrarMoviminetos;
        private DataGridViewTextBoxColumn CIDmovimientp;
        private DataGridViewTextBoxColumn Ctipo;
        private DataGridViewTextBoxColumn CResponsable;
        private DataGridViewTextBoxColumn CVisitante;
        private DataGridViewTextBoxColumn CDNIvisitante;
        private DataGridViewTextBoxColumn Cfecha;
        private Panel panel4;
    }
}