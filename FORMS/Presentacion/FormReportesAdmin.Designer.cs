using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class FormReportesAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            topPropietarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DistribucionMovimientos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cbFiltroMovimientos = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnRestoreBuscar = new RJButton();
            btnRestoreDatabase = new RJButton();
            cbBaseDatos = new ComboBox();
            btnBackupDatabase = new RJButton();
            btnBackupBuscar = new RJButton();
            tbUbicacion = new RJTextBox();
            lBaseDatos = new Label();
            label2 = new Label();
            label1 = new Label();
            tgVisitantes = new FontAwesome.Sharp.IconButton();
            tgIngresosHoy = new FontAwesome.Sharp.IconButton();
            tgPromedioDiario = new FontAwesome.Sharp.IconButton();
            tgUsuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)topPropietarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DistribucionMovimientos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // topPropietarios
            // 
            topPropietarios.Anchor = AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            topPropietarios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            topPropietarios.Legends.Add(legend1);
            topPropietarios.Location = new Point(12, 303);
            topPropietarios.Name = "topPropietarios";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            topPropietarios.Series.Add(series1);
            topPropietarios.Size = new Size(542, 247);
            topPropietarios.TabIndex = 0;
            topPropietarios.Text = "topPropietarios";
            topPropietarios.Click += topPropietarios_Click;
            // 
            // DistribucionMovimientos
            // 
            DistribucionMovimientos.BorderlineColor = Color.Azure;
            chartArea2.AxisX.TitleForeColor = Color.WhiteSmoke;
            chartArea2.AxisY.TitleForeColor = Color.White;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.BorderColor = Color.White;
            chartArea2.Name = "ChartArea1";
            DistribucionMovimientos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            DistribucionMovimientos.Legends.Add(legend2);
            DistribucionMovimientos.Location = new Point(12, 12);
            DistribucionMovimientos.Name = "DistribucionMovimientos";
            DistribucionMovimientos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            DistribucionMovimientos.Series.Add(series2);
            DistribucionMovimientos.Size = new Size(542, 290);
            DistribucionMovimientos.TabIndex = 4;
            DistribucionMovimientos.Text = "chart1";
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.SeaGreen;
            title1.Name = "DISTRIBUCION DE MOVIMIENTOS";
            title1.Text = "DISTRIBUCION DE MOVIMIENTOS";
            DistribucionMovimientos.Titles.Add(title1);
            // 
            // cbFiltroMovimientos
            // 
            cbFiltroMovimientos.BackColor = Color.DarkSeaGreen;
            cbFiltroMovimientos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbFiltroMovimientos.ForeColor = SystemColors.HighlightText;
            cbFiltroMovimientos.FormattingEnabled = true;
            cbFiltroMovimientos.Items.AddRange(new object[] { "Dia", "Mes" });
            cbFiltroMovimientos.Location = new Point(427, 80);
            cbFiltroMovimientos.Name = "cbFiltroMovimientos";
            cbFiltroMovimientos.Size = new Size(97, 24);
            cbFiltroMovimientos.TabIndex = 6;
            cbFiltroMovimientos.Text = "  DIA / MES  ";
            cbFiltroMovimientos.SelectedIndexChanged += cbFiltroMovimientos_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tgVisitantes);
            panel1.Controls.Add(tgIngresosHoy);
            panel1.Controls.Add(tgPromedioDiario);
            panel1.Controls.Add(tgUsuarios);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(560, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 550);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(btnRestoreBuscar);
            panel2.Controls.Add(btnRestoreDatabase);
            panel2.Controls.Add(cbBaseDatos);
            panel2.Controls.Add(btnBackupDatabase);
            panel2.Controls.Add(btnBackupBuscar);
            panel2.Controls.Add(tbUbicacion);
            panel2.Controls.Add(lBaseDatos);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 252);
            panel2.TabIndex = 5;
            // 
            // btnRestoreBuscar
            // 
            btnRestoreBuscar.BackColor = Color.LightCyan;
            btnRestoreBuscar.BackgroundColor = Color.LightCyan;
            btnRestoreBuscar.BorderColor = Color.DarkSlateGray;
            btnRestoreBuscar.BorderRadius = 15;
            btnRestoreBuscar.BorderSize = 1;
            btnRestoreBuscar.FlatAppearance.BorderSize = 0;
            btnRestoreBuscar.FlatStyle = FlatStyle.Flat;
            btnRestoreBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestoreBuscar.ForeColor = Color.Teal;
            btnRestoreBuscar.Location = new Point(327, 104);
            btnRestoreBuscar.Name = "btnRestoreBuscar";
            btnRestoreBuscar.Size = new Size(85, 31);
            btnRestoreBuscar.TabIndex = 17;
            btnRestoreBuscar.Text = "buscar";
            btnRestoreBuscar.TextColor = Color.Teal;
            btnRestoreBuscar.UseVisualStyleBackColor = false;
            btnRestoreBuscar.Click += btnRestoreBuscar_Click;
            // 
            // btnRestoreDatabase
            // 
            btnRestoreDatabase.BackColor = Color.CadetBlue;
            btnRestoreDatabase.BackgroundColor = Color.CadetBlue;
            btnRestoreDatabase.BorderColor = Color.PaleVioletRed;
            btnRestoreDatabase.BorderRadius = 15;
            btnRestoreDatabase.BorderSize = 0;
            btnRestoreDatabase.FlatAppearance.BorderSize = 0;
            btnRestoreDatabase.FlatStyle = FlatStyle.Flat;
            btnRestoreDatabase.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestoreDatabase.ForeColor = Color.White;
            btnRestoreDatabase.Location = new Point(114, 142);
            btnRestoreDatabase.Name = "btnRestoreDatabase";
            btnRestoreDatabase.Size = new Size(179, 41);
            btnRestoreDatabase.TabIndex = 16;
            btnRestoreDatabase.Text = "Restore Database";
            btnRestoreDatabase.TextColor = Color.White;
            btnRestoreDatabase.UseVisualStyleBackColor = false;
            btnRestoreDatabase.Click += btnRestore_Click;
            // 
            // cbBaseDatos
            // 
            cbBaseDatos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbBaseDatos.ForeColor = Color.DarkSlateGray;
            cbBaseDatos.FormattingEnabled = true;
            cbBaseDatos.Items.AddRange(new object[] { "Backup", "Restore" });
            cbBaseDatos.Location = new Point(291, 23);
            cbBaseDatos.Name = "cbBaseDatos";
            cbBaseDatos.Size = new Size(121, 24);
            cbBaseDatos.TabIndex = 15;
            cbBaseDatos.Text = "Seleccionar";
            cbBaseDatos.SelectedIndexChanged += cbBaseDatos_SelectedIndexChanged;
            // 
            // btnBackupDatabase
            // 
            btnBackupDatabase.BackColor = Color.CadetBlue;
            btnBackupDatabase.BackgroundColor = Color.CadetBlue;
            btnBackupDatabase.BorderColor = Color.PaleVioletRed;
            btnBackupDatabase.BorderRadius = 15;
            btnBackupDatabase.BorderSize = 0;
            btnBackupDatabase.FlatAppearance.BorderSize = 0;
            btnBackupDatabase.FlatStyle = FlatStyle.Flat;
            btnBackupDatabase.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackupDatabase.ForeColor = Color.White;
            btnBackupDatabase.Location = new Point(114, 142);
            btnBackupDatabase.Name = "btnBackupDatabase";
            btnBackupDatabase.Size = new Size(179, 41);
            btnBackupDatabase.TabIndex = 12;
            btnBackupDatabase.Text = "Backup Database";
            btnBackupDatabase.TextColor = Color.White;
            btnBackupDatabase.UseVisualStyleBackColor = false;
            btnBackupDatabase.Click += btnBackup_Click;
            // 
            // btnBackupBuscar
            // 
            btnBackupBuscar.BackColor = Color.LightCyan;
            btnBackupBuscar.BackgroundColor = Color.LightCyan;
            btnBackupBuscar.BorderColor = Color.DarkSlateGray;
            btnBackupBuscar.BorderRadius = 15;
            btnBackupBuscar.BorderSize = 1;
            btnBackupBuscar.FlatAppearance.BorderSize = 0;
            btnBackupBuscar.FlatStyle = FlatStyle.Flat;
            btnBackupBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackupBuscar.ForeColor = Color.Teal;
            btnBackupBuscar.Location = new Point(327, 104);
            btnBackupBuscar.Name = "btnBackupBuscar";
            btnBackupBuscar.Size = new Size(85, 31);
            btnBackupBuscar.TabIndex = 10;
            btnBackupBuscar.Text = "buscar";
            btnBackupBuscar.TextColor = Color.Teal;
            btnBackupBuscar.UseVisualStyleBackColor = false;
            btnBackupBuscar.Click += btnBackupBuscar_Click;
            // 
            // tbUbicacion
            // 
            tbUbicacion.BackColor = SystemColors.Window;
            tbUbicacion.BorderColor = Color.DarkCyan;
            tbUbicacion.BorderFocusColor = Color.HotPink;
            tbUbicacion.BorderRadius = 10;
            tbUbicacion.BorderSize = 2;
            tbUbicacion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbUbicacion.ForeColor = Color.FromArgb(64, 64, 64);
            tbUbicacion.Location = new Point(13, 104);
            tbUbicacion.Margin = new Padding(4);
            tbUbicacion.Multiline = false;
            tbUbicacion.Name = "tbUbicacion";
            tbUbicacion.Padding = new Padding(10, 7, 10, 7);
            tbUbicacion.PasswordChar = false;
            tbUbicacion.PlaceholderColor = Color.DarkGray;
            tbUbicacion.PlaceholderText = "";
            tbUbicacion.Size = new Size(307, 31);
            tbUbicacion.TabIndex = 8;
            tbUbicacion.Texts = "";
            tbUbicacion.UnderlinedStyle = false;
            // 
            // lBaseDatos
            // 
            lBaseDatos.AutoSize = true;
            lBaseDatos.BackColor = Color.Transparent;
            lBaseDatos.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lBaseDatos.ForeColor = Color.DarkCyan;
            lBaseDatos.Location = new Point(13, 82);
            lBaseDatos.Name = "lBaseDatos";
            lBaseDatos.Size = new Size(68, 18);
            lBaseDatos.TabIndex = 6;
            lBaseDatos.Text = "BACKUP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 5;
            label2.Text = "BASE DE DATOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(3, 152);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 4;
            label1.Text = "INGRESOS DEL DIA";
            // 
            // tgVisitantes
            // 
            tgVisitantes.BackColor = Color.Azure;
            tgVisitantes.FlatStyle = FlatStyle.Flat;
            tgVisitantes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tgVisitantes.ForeColor = Color.CadetBlue;
            tgVisitantes.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            tgVisitantes.IconColor = Color.CadetBlue;
            tgVisitantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tgVisitantes.ImageAlign = ContentAlignment.MiddleLeft;
            tgVisitantes.Location = new Point(221, 3);
            tgVisitantes.Name = "tgVisitantes";
            tgVisitantes.Size = new Size(204, 71);
            tgVisitantes.TabIndex = 3;
            tgVisitantes.Text = "iconButton1";
            tgVisitantes.UseVisualStyleBackColor = false;
            // 
            // tgIngresosHoy
            // 
            tgIngresosHoy.BackColor = Color.Azure;
            tgIngresosHoy.FlatStyle = FlatStyle.Flat;
            tgIngresosHoy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tgIngresosHoy.ForeColor = Color.CadetBlue;
            tgIngresosHoy.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            tgIngresosHoy.IconColor = Color.CadetBlue;
            tgIngresosHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tgIngresosHoy.ImageAlign = ContentAlignment.MiddleLeft;
            tgIngresosHoy.Location = new Point(1, 174);
            tgIngresosHoy.Name = "tgIngresosHoy";
            tgIngresosHoy.Size = new Size(424, 55);
            tgIngresosHoy.TabIndex = 2;
            tgIngresosHoy.Text = "iconButton2";
            tgIngresosHoy.UseVisualStyleBackColor = false;
            tgIngresosHoy.Click += tgIngresosHoy_Click;
            // 
            // tgPromedioDiario
            // 
            tgPromedioDiario.BackColor = Color.Azure;
            tgPromedioDiario.FlatStyle = FlatStyle.Flat;
            tgPromedioDiario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tgPromedioDiario.ForeColor = Color.CadetBlue;
            tgPromedioDiario.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            tgPromedioDiario.IconColor = Color.CadetBlue;
            tgPromedioDiario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tgPromedioDiario.ImageAlign = ContentAlignment.MiddleLeft;
            tgPromedioDiario.Location = new Point(0, 80);
            tgPromedioDiario.Name = "tgPromedioDiario";
            tgPromedioDiario.Size = new Size(425, 53);
            tgPromedioDiario.TabIndex = 1;
            tgPromedioDiario.Text = "iconButton1";
            tgPromedioDiario.UseVisualStyleBackColor = false;
            // 
            // tgUsuarios
            // 
            tgUsuarios.BackColor = Color.Azure;
            tgUsuarios.FlatStyle = FlatStyle.Flat;
            tgUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tgUsuarios.ForeColor = Color.CadetBlue;
            tgUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            tgUsuarios.IconColor = Color.CadetBlue;
            tgUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tgUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            tgUsuarios.Location = new Point(0, 3);
            tgUsuarios.Name = "tgUsuarios";
            tgUsuarios.Size = new Size(215, 71);
            tgUsuarios.TabIndex = 0;
            tgUsuarios.Text = "iconButton1";
            tgUsuarios.UseVisualStyleBackColor = false;
            // 
            // FormReportesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1037, 550);
            Controls.Add(panel1);
            Controls.Add(cbFiltroMovimientos);
            Controls.Add(topPropietarios);
            Controls.Add(DistribucionMovimientos);
            Name = "FormReportesAdmin";
            Text = "Egresos";
            Load += FormReportesAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)topPropietarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)DistribucionMovimientos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresosPorVisitante;
        private System.Windows.Forms.DataVisualization.Charting.Chart DistribucionMovimientos;
        private System.Windows.Forms.DataVisualization.Charting.Chart topPropietarios;
        private ComboBox cbFiltroMovimientos;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton tgIngresosHoy;
        private FontAwesome.Sharp.IconButton tgPromedioDiario;
        private FontAwesome.Sharp.IconButton tgUsuarios;
        private Label label1;
        private FontAwesome.Sharp.IconButton tgVisitantes;
        private Panel panel2;
        private Label lBaseDatos;
        private Label label2;
        private RJTextBox tbUbicacion;
        private RJButton btnBackupBuscar;
        private RJButton btnBackupDatabase;
        private ComboBox cbBaseDatos;
        private RJButton btnRestoreBuscar;
        private RJButton btnRestoreDatabase;
    }
}