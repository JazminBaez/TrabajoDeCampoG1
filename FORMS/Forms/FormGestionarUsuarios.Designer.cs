using FORMS.Controls;
namespace FORMS.Forms
{
    partial class FormGestionarUsuarios
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
            btRegistrar = new RJButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tbRepeatPassword = new RJTextBox();
            tbPassword = new RJTextBox();
            tbCorreo = new RJTextBox();
            cbRol = new ComboBox();
            TBDireccion = new RJTextBox();
            tbTelefono = new RJTextBox();
            tbApellido = new RJTextBox();
            tbNombre = new RJTextBox();
            LRegistrarUsuario = new Label();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            panel2 = new Panel();
            cbFiltrarUsuarios = new ComboBox();
        
            lbFiltrarUsuarios = new Label();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 101, 114);
            panel1.Controls.Add(btRegistrar);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(tbRepeatPassword);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbCorreo);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(TBDireccion);
            panel1.Controls.Add(tbTelefono);
            panel1.Controls.Add(tbApellido);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(LRegistrarUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 598);
            panel1.TabIndex = 0;
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = Color.GhostWhite;
            btRegistrar.BackgroundColor = Color.GhostWhite;
            btRegistrar.BorderColor = Color.LavenderBlush;
            btRegistrar.BorderRadius = 20;
            btRegistrar.BorderSize = 0;
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegistrar.ForeColor = Color.Black;
            btRegistrar.Location = new Point(51, 537);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(150, 40);
            btRegistrar.TabIndex = 9;
            btRegistrar.Text = "REGISTRAR";
            btRegistrar.TextColor = Color.Black;
            btRegistrar.UseVisualStyleBackColor = false;
     
            // tbRepeatPassword
            // 
            tbRepeatPassword.BackColor = SystemColors.Window;
            tbRepeatPassword.BorderColor = SystemColors.Window;
            tbRepeatPassword.BorderFocusColor = Color.MidnightBlue;
            tbRepeatPassword.BorderRadius = 11;
            tbRepeatPassword.BorderSize = 2;
            tbRepeatPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbRepeatPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbRepeatPassword.Location = new Point(51, 431);
            tbRepeatPassword.Margin = new Padding(4);
            tbRepeatPassword.Multiline = false;
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.Padding = new Padding(10, 7, 10, 7);
            tbRepeatPassword.PasswordChar = false;
            tbRepeatPassword.PlaceholderColor = Color.Gray;
            tbRepeatPassword.PlaceholderText = "Repetir contraseña";
            tbRepeatPassword.Size = new Size(250, 31);
            tbRepeatPassword.TabIndex = 8;
            tbRepeatPassword.Texts = "";
            tbRepeatPassword.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.BorderColor = SystemColors.Window;
            tbPassword.BorderFocusColor = Color.MidnightBlue;
            tbPassword.BorderRadius = 11;
            tbPassword.BorderSize = 2;
            tbPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tbPassword.Location = new Point(51, 382);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = false;
            tbPassword.PlaceholderColor = Color.Gray;
            tbPassword.PlaceholderText = "Contraseña";
            tbPassword.Size = new Size(250, 31);
            tbPassword.TabIndex = 7;
            tbPassword.Texts = "";
            tbPassword.UnderlinedStyle = false;
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.Window;
            tbCorreo.BorderColor = SystemColors.Window;
            tbCorreo.BorderFocusColor = Color.MidnightBlue;
            tbCorreo.BorderRadius = 11;
            tbCorreo.BorderSize = 2;
            tbCorreo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            tbCorreo.Location = new Point(51, 326);
            tbCorreo.Margin = new Padding(4);
            tbCorreo.Multiline = false;
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Padding = new Padding(10, 7, 10, 7);
            tbCorreo.PasswordChar = false;
            tbCorreo.PlaceholderColor = Color.Gray;
            tbCorreo.PlaceholderText = "Correo";
            tbCorreo.Size = new Size(250, 31);
            tbCorreo.TabIndex = 6;
            tbCorreo.Texts = "";
            tbCorreo.UnderlinedStyle = false;
            // 
            // cbRol
            // 
            cbRol.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(51, 484);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(250, 23);
            cbRol.TabIndex = 5;
            // 
            // TBDireccion
            // 
            TBDireccion.BackColor = SystemColors.Window;
            TBDireccion.BorderColor = SystemColors.Window;
            TBDireccion.BorderFocusColor = Color.MidnightBlue;
            TBDireccion.BorderRadius = 11;
            TBDireccion.BorderSize = 2;
            TBDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            TBDireccion.Location = new Point(51, 272);
            TBDireccion.Margin = new Padding(4);
            TBDireccion.Multiline = false;
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Padding = new Padding(10, 7, 10, 7);
            TBDireccion.PasswordChar = false;
            TBDireccion.PlaceholderColor = Color.Gray;
            TBDireccion.PlaceholderText = "Direccion";
            TBDireccion.Size = new Size(250, 31);
            TBDireccion.TabIndex = 4;
            TBDireccion.Texts = "";
            TBDireccion.UnderlinedStyle = false;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.Window;
            tbTelefono.BorderColor = SystemColors.Window;
            tbTelefono.BorderFocusColor = Color.MidnightBlue;
            tbTelefono.BorderRadius = 11;
            tbTelefono.BorderSize = 2;
            tbTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            tbTelefono.Location = new Point(51, 217);
            tbTelefono.Margin = new Padding(4);
            tbTelefono.Multiline = false;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Padding = new Padding(10, 7, 10, 7);
            tbTelefono.PasswordChar = false;
            tbTelefono.PlaceholderColor = Color.Gray;
            tbTelefono.PlaceholderText = "Telefono";
            tbTelefono.Size = new Size(250, 31);
            tbTelefono.TabIndex = 3;
            tbTelefono.Texts = "";
            tbTelefono.UnderlinedStyle = false;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = SystemColors.Window;
            tbApellido.BorderColor = SystemColors.Window;
            tbApellido.BorderFocusColor = Color.MidnightBlue;
            tbApellido.BorderRadius = 11;
            tbApellido.BorderSize = 2;
            tbApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellido.ForeColor = Color.FromArgb(64, 64, 64);
            tbApellido.Location = new Point(51, 167);
            tbApellido.Margin = new Padding(4);
            tbApellido.Multiline = false;
            tbApellido.Name = "tbApellido";
            tbApellido.Padding = new Padding(10, 7, 10, 7);
            tbApellido.PasswordChar = false;
            tbApellido.PlaceholderColor = Color.Gray;
            tbApellido.PlaceholderText = "Apellido";
            tbApellido.Size = new Size(250, 31);
            tbApellido.TabIndex = 2;
            tbApellido.Texts = "";
            tbApellido.UnderlinedStyle = false;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.Window;
            tbNombre.BorderColor = SystemColors.Window;
            tbNombre.BorderFocusColor = Color.MidnightBlue;
            tbNombre.BorderRadius = 11;
            tbNombre.BorderSize = 2;
            tbNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.FromArgb(64, 64, 64);
            tbNombre.Location = new Point(51, 115);
            tbNombre.Margin = new Padding(4);
            tbNombre.Multiline = false;
            tbNombre.Name = "tbNombre";
            tbNombre.Padding = new Padding(10, 7, 10, 7);
            tbNombre.PasswordChar = false;
            tbNombre.PlaceholderColor = Color.Gray;
            tbNombre.PlaceholderText = "Nombre";
            tbNombre.Size = new Size(250, 31);
            tbNombre.TabIndex = 1;
            tbNombre.Texts = "";
            tbNombre.UnderlinedStyle = false;
            // 
            // LRegistrarUsuario
            // 
            LRegistrarUsuario.AutoSize = true;
            LRegistrarUsuario.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LRegistrarUsuario.ForeColor = SystemColors.Control;
            LRegistrarUsuario.Location = new Point(69, 63);
            LRegistrarUsuario.Name = "LRegistrarUsuario";
            LRegistrarUsuario.Size = new Size(204, 23);
            LRegistrarUsuario.TabIndex = 0;
            LRegistrarUsuario.Text = "REGISTRAR USUARIO";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(cbFiltrarUsuarios);
      
            panel2.Controls.Add(lbFiltrarUsuarios);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(356, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 102);
            panel2.TabIndex = 1;
            // 
            // cbFiltrarUsuarios
            // 
            cbFiltrarUsuarios.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            cbFiltrarUsuarios.FormattingEnabled = true;
            cbFiltrarUsuarios.Items.AddRange(new object[] { "Administradores", "Guardias", "Propietarios" });
            cbFiltrarUsuarios.Location = new Point(422, 67);
            cbFiltrarUsuarios.Name = "cbFiltrarUsuarios";
            cbFiltrarUsuarios.Size = new Size(250, 23);
            cbFiltrarUsuarios.TabIndex = 13;
         
            // lbFiltrarUsuarios
            // 
            lbFiltrarUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbFiltrarUsuarios.AutoSize = true;
            lbFiltrarUsuarios.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFiltrarUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lbFiltrarUsuarios.Location = new Point(427, 37);
            lbFiltrarUsuarios.Name = "lbFiltrarUsuarios";
            lbFiltrarUsuarios.Size = new Size(68, 17);
            lbFiltrarUsuarios.TabIndex = 12;
            lbFiltrarUsuarios.Text = "Filtrar por";
            lbFiltrarUsuarios.Click += lbFiltrarUsuarios_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Propietario", "Guardia" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(907, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(58, 23);
            comboBox1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(356, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 496);
            panel3.TabIndex = 2;
            // 
            // FormGestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 101, 114);
            ClientSize = new Size(1040, 598);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormGestionarUsuarios";
            Text = "Gestionar Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LRegistrarUsuario;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private Controls.RJTextBox tbNombre;
        private RJTextBox TBDireccion;
        private RJTextBox tbTelefono;
        private RJTextBox tbApellido;
        private ComboBox cbRol;
        private RJTextBox tbCorreo;
        private RJButton btRegistrar;
        private RJTextBox tbRepeatPassword;
        private RJTextBox tbPassword;
        private Panel panel2;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbFiltrarUsuarios;
        private ComboBox comboBox1;
        private ComboBox cbFiltrarUsuarios;
        private Panel panel3;
    }
}