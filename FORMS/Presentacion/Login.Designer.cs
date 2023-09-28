using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            panel3 = new Panel();
            ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            lbError = new Label();
            tbContrasena = new RJTextBox();
            btIniciarSesion = new RJButton();
            tbCorreo = new RJTextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 250);
            panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(231, 0);
            btnMinimize.Margin = new Padding(3, 10, 3, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 24);
            btnMinimize.TabIndex = 9;
            btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Brands;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(271, 0);
            btnExit.Margin = new Padding(3, 10, 3, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 24);
            btnExit.TabIndex = 7;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(94, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(115, 117);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 34, 50);
            panel3.Controls.Add(ErrorIcon);
            panel3.Controls.Add(lbError);
            panel3.Controls.Add(tbContrasena);
            panel3.Controls.Add(btIniciarSesion);
            panel3.Controls.Add(tbCorreo);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 255);
            panel3.TabIndex = 2;
            // 
            // ErrorIcon
            // 
            ErrorIcon.BackColor = Color.FromArgb(31, 34, 50);
            ErrorIcon.ForeColor = Color.Brown;
            ErrorIcon.IconChar = FontAwesome.Sharp.IconChar.Warning;
            ErrorIcon.IconColor = Color.Brown;
            ErrorIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ErrorIcon.IconSize = 21;
            ErrorIcon.Location = new Point(50, 93);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(21, 27);
            ErrorIcon.TabIndex = 23;
            ErrorIcon.TabStop = false;
            ErrorIcon.Visible = false;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbError.ForeColor = SystemColors.ButtonFace;
            lbError.Location = new Point(77, 93);
            lbError.Name = "lbError";
            lbError.Size = new Size(34, 17);
            lbError.TabIndex = 22;
            lbError.Text = "Error";
            lbError.Visible = false;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = SystemColors.InactiveCaption;
            tbContrasena.BorderColor = Color.Transparent;
            tbContrasena.BorderFocusColor = Color.MidnightBlue;
            tbContrasena.BorderRadius = 11;
            tbContrasena.BorderSize = 2;
            tbContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            tbContrasena.Location = new Point(48, 53);
            tbContrasena.Margin = new Padding(4);
            tbContrasena.Multiline = false;
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Padding = new Padding(10, 7, 10, 7);
            tbContrasena.PasswordChar = true;
            tbContrasena.PlaceholderColor = Color.Gray;
            tbContrasena.PlaceholderText = "Contraseña";
            tbContrasena.Size = new Size(206, 31);
            tbContrasena.TabIndex = 21;
            tbContrasena.Texts = "";
            tbContrasena.UnderlinedStyle = false;
            // 
            // btIniciarSesion
            // 
            btIniciarSesion.BackColor = SystemColors.GradientInactiveCaption;
            btIniciarSesion.BackgroundColor = SystemColors.GradientInactiveCaption;
            btIniciarSesion.BorderColor = SystemColors.InactiveCaption;
            btIniciarSesion.BorderRadius = 20;
            btIniciarSesion.BorderSize = 0;
            btIniciarSesion.FlatAppearance.BorderSize = 0;
            btIniciarSesion.FlatStyle = FlatStyle.Flat;
            btIniciarSesion.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btIniciarSesion.ForeColor = Color.Black;
            btIniciarSesion.Location = new Point(95, 125);
            btIniciarSesion.Name = "btIniciarSesion";
            btIniciarSesion.Size = new Size(114, 40);
            btIniciarSesion.TabIndex = 20;
            btIniciarSesion.Text = "INICIAR SESION";
            btIniciarSesion.TextColor = Color.Black;
            btIniciarSesion.UseVisualStyleBackColor = false;
            btIniciarSesion.Click += btIniciarSesion_Click;
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.InactiveCaption;
            tbCorreo.BorderColor = Color.Transparent;
            tbCorreo.BorderFocusColor = Color.MidnightBlue;
            tbCorreo.BorderRadius = 11;
            tbCorreo.BorderSize = 2;
            tbCorreo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            tbCorreo.Location = new Point(48, 4);
            tbCorreo.Margin = new Padding(4);
            tbCorreo.Multiline = false;
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Padding = new Padding(10, 7, 10, 7);
            tbCorreo.PasswordChar = false;
            tbCorreo.PlaceholderColor = Color.Gray;
            tbCorreo.PlaceholderText = "Correo";
            tbCorreo.Size = new Size(206, 31);
            tbCorreo.TabIndex = 15;
            tbCorreo.Texts = "";
            tbCorreo.UnderlinedStyle = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 50);
            ClientSize = new Size(305, 505);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Controls.RJTextBox tbApellido;
        private Controls.RJTextBox TBDireccion;
        private Controls.RJTextBox tbCorreo;
        private RJButton btIniciarSesion;
        private RJTextBox tbContrasena;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private Label lbError;
    }
}