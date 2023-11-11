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
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 127, 215);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 215);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 36);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 127, 215);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(443, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 215);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(107, 127, 215);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(443, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 235);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(107, 127, 215);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 235);
            panel4.TabIndex = 3;
            // 
            // FormReportesAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormReportesAdmin";
            Text = "Egresos";
            Load += FormReportesAdmin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresosPorVisitante;
    }
}