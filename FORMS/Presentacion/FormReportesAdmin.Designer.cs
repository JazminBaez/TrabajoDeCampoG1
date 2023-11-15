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
            label1 = new Label();
            tgVisitantes = new FontAwesome.Sharp.IconButton();
            tgIngresosHoy = new FontAwesome.Sharp.IconButton();
            tgPromedioDiario = new FontAwesome.Sharp.IconButton();
            tgUsuarios = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rjTextBox1 = new RJTextBox();
            rjTextBox2 = new RJTextBox();
            btnBackupBuscar = new RJButton();
            btnBackup = new RJButton();
            btnRestoreBuscar = new RJButton();
            btnRestore = new RJButton();
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
            topPropietarios.Size = new Size(461, 247);
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
            DistribucionMovimientos.Size = new Size(461, 285);
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
            cbFiltroMovimientos.Location = new Point(365, 79);
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
            panel1.Location = new Point(496, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 550);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(0, 152);
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
            tgVisitantes.Location = new Point(183, 3);
            tgVisitantes.Name = "tgVisitantes";
            tgVisitantes.Size = new Size(174, 71);
            tgVisitantes.TabIndex = 3;
            tgVisitantes.Text = "iconButton1";
            tgVisitantes.TextAlign = ContentAlignment.MiddleRight;
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
            tgIngresosHoy.Location = new Point(0, 174);
            tgIngresosHoy.Name = "tgIngresosHoy";
            tgIngresosHoy.Size = new Size(356, 55);
            tgIngresosHoy.TabIndex = 2;
            tgIngresosHoy.Text = "iconButton2";
            tgIngresosHoy.TextAlign = ContentAlignment.MiddleRight;
            tgIngresosHoy.UseVisualStyleBackColor = false;
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
            tgPromedioDiario.Location = new Point(3, 80);
            tgPromedioDiario.Name = "tgPromedioDiario";
            tgPromedioDiario.Size = new Size(359, 53);
            tgPromedioDiario.TabIndex = 1;
            tgPromedioDiario.Text = "iconButton1";
            tgPromedioDiario.TextAlign = ContentAlignment.MiddleRight;
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
            tgUsuarios.Location = new Point(3, 3);
            tgUsuarios.Name = "tgUsuarios";
            tgUsuarios.Size = new Size(174, 71);
            tgUsuarios.TabIndex = 0;
            tgUsuarios.Text = "iconButton1";
            tgUsuarios.TextAlign = ContentAlignment.MiddleRight;
            tgUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(btnRestore);
            panel2.Controls.Add(btnRestoreBuscar);
            panel2.Controls.Add(btnBackup);
            panel2.Controls.Add(btnBackupBuscar);
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 297);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 5;
            label2.Text = "BASE DE DATOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(14, 42);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 6;
            label3.Text = "BACKUP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(14, 192);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 7;
            label4.Text = "RESTORE";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.DarkCyan;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(14, 64);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(242, 31);
            rjTextBox1.TabIndex = 8;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.DarkCyan;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(14, 214);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(242, 31);
            rjTextBox2.TabIndex = 9;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
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
            btnBackupBuscar.Location = new Point(263, 64);
            btnBackupBuscar.Name = "btnBackupBuscar";
            btnBackupBuscar.Size = new Size(85, 31);
            btnBackupBuscar.TabIndex = 10;
            btnBackupBuscar.Text = "buscar";
            btnBackupBuscar.TextColor = Color.Teal;
            btnBackupBuscar.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.CadetBlue;
            btnBackup.BackgroundColor = Color.CadetBlue;
            btnBackup.BorderColor = Color.PaleVioletRed;
            btnBackup.BorderRadius = 15;
            btnBackup.BorderSize = 0;
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(169, 102);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(179, 31);
            btnBackup.TabIndex = 12;
            btnBackup.Text = "Backup Database";
            btnBackup.TextColor = Color.White;
            btnBackup.UseVisualStyleBackColor = false;
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
            btnRestoreBuscar.Location = new Point(263, 214);
            btnRestoreBuscar.Name = "btnRestoreBuscar";
            btnRestoreBuscar.Size = new Size(85, 31);
            btnRestoreBuscar.TabIndex = 13;
            btnRestoreBuscar.Text = "buscar";
            btnRestoreBuscar.TextColor = Color.Teal;
            btnRestoreBuscar.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.CadetBlue;
            btnRestore.BackgroundColor = Color.CadetBlue;
            btnRestore.BorderColor = Color.PaleVioletRed;
            btnRestore.BorderRadius = 15;
            btnRestore.BorderSize = 0;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(169, 254);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(179, 31);
            btnRestore.TabIndex = 14;
            btnRestore.Text = "Restore Database";
            btnRestore.TextColor = Color.White;
            btnRestore.UseVisualStyleBackColor = false;
            // 
            // FormReportesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(858, 550);
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
        private Label label3;
        private Label label2;
        private RJTextBox rjTextBox2;
        private RJTextBox rjTextBox1;
        private Label label4;
        private RJButton btnBackupBuscar;
        private RJButton btnRestore;
        private RJButton btnRestoreBuscar;
        private RJButton btnBackup;
    }
}