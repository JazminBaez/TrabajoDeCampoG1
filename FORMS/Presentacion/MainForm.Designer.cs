using seguridad_barrios_privados.Controls;

namespace seguridad_barrios_privados.Presentacion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnEgresos = new FontAwesome.Sharp.IconButton();
            btnIngresos = new FontAwesome.Sharp.IconButton();
            btnSolicitudes = new FontAwesome.Sharp.IconButton();
            btnMovimientos = new FontAwesome.Sharp.IconButton();
            btnGestionUsuarios = new FontAwesome.Sharp.IconButton();
            logo = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panelTitlleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lbNombreUsuario = new Label();
            lbBienvenido = new Label();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panel2 = new Panel();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            panelMenu.SuspendLayout();
            logo.SuspendLayout();
            panel1.SuspendLayout();
            panelTitlleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 25, 70);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnEgresos);
            panelMenu.Controls.Add(btnIngresos);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnMovimientos);
            panelMenu.Controls.Add(btnGestionUsuarios);
            panelMenu.Controls.Add(logo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(216, 605);
            panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.IconSize = 40;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 443);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(9);
            btnCerrarSesion.Size = new Size(216, 58);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnEgresos
            // 
            btnEgresos.Dock = DockStyle.Top;
            btnEgresos.FlatAppearance.BorderSize = 0;
            btnEgresos.FlatStyle = FlatStyle.Flat;
            btnEgresos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEgresos.ForeColor = SystemColors.ButtonHighlight;
            btnEgresos.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btnEgresos.IconColor = Color.White;
            btnEgresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEgresos.IconSize = 40;
            btnEgresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEgresos.Location = new Point(0, 385);
            btnEgresos.Name = "btnEgresos";
            btnEgresos.Padding = new Padding(9);
            btnEgresos.Rotation = 180D;
            btnEgresos.Size = new Size(216, 58);
            btnEgresos.TabIndex = 6;
            btnEgresos.Text = "Egresos";
            btnEgresos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEgresos.UseVisualStyleBackColor = true;
            btnEgresos.Click += btnEgresos_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.Dock = DockStyle.Top;
            btnIngresos.FlatAppearance.BorderSize = 0;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresos.ForeColor = SystemColors.ButtonHighlight;
            btnIngresos.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btnIngresos.IconColor = Color.White;
            btnIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresos.IconSize = 40;
            btnIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresos.Location = new Point(0, 327);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Padding = new Padding(9);
            btnIngresos.Size = new Size(216, 58);
            btnIngresos.TabIndex = 5;
            btnIngresos.Text = "Ingresos";
            btnIngresos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.Dock = DockStyle.Top;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolicitudes.ForeColor = SystemColors.ButtonHighlight;
            btnSolicitudes.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnSolicitudes.IconColor = Color.White;
            btnSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSolicitudes.IconSize = 40;
            btnSolicitudes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.Location = new Point(0, 269);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Padding = new Padding(9);
            btnSolicitudes.Size = new Size(216, 58);
            btnSolicitudes.TabIndex = 4;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSolicitudes.UseVisualStyleBackColor = true;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Dock = DockStyle.Top;
            btnMovimientos.FlatAppearance.BorderSize = 0;
            btnMovimientos.FlatStyle = FlatStyle.Flat;
            btnMovimientos.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMovimientos.ForeColor = SystemColors.ButtonHighlight;
            btnMovimientos.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnMovimientos.IconColor = Color.White;
            btnMovimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMovimientos.IconSize = 40;
            btnMovimientos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimientos.Location = new Point(0, 211);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Padding = new Padding(9);
            btnMovimientos.Size = new Size(216, 58);
            btnMovimientos.TabIndex = 2;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Dock = DockStyle.Top;
            btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            btnGestionUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionUsuarios.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionUsuarios.ForeColor = SystemColors.ButtonHighlight;
            btnGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnGestionUsuarios.IconColor = Color.White;
            btnGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionUsuarios.IconSize = 40;
            btnGestionUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuarios.Location = new Point(0, 153);
            btnGestionUsuarios.Margin = new Padding(3, 10, 3, 3);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Padding = new Padding(9);
            btnGestionUsuarios.Size = new Size(216, 58);
            btnGestionUsuarios.TabIndex = 1;
            btnGestionUsuarios.Text = "Gestionar usuarios";
            btnGestionUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Controls.Add(panel1);
            logo.Dock = DockStyle.Top;
            logo.ImeMode = ImeMode.Off;
            logo.Location = new Point(0, 0);
            logo.Margin = new Padding(0, 0, 0, 10);
            logo.Name = "logo";
            logo.Padding = new Padding(0, 0, 0, 20);
            logo.Size = new Size(216, 153);
            logo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 20);
            panel1.Size = new Size(216, 153);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackgroundImage = Properties.Resources.logo;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(26, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(168, 110);
            panel3.TabIndex = 0;
            // 
            // panelTitlleBar
            // 
            panelTitlleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitlleBar.Controls.Add(btnMinimize);
            panelTitlleBar.Controls.Add(btnMaximize);
            panelTitlleBar.Controls.Add(btnExit);
            panelTitlleBar.Controls.Add(lbNombreUsuario);
            panelTitlleBar.Controls.Add(lbBienvenido);
            panelTitlleBar.Controls.Add(lblTitleChildForm);
            panelTitlleBar.Controls.Add(iconCurrentChildForm);
            panelTitlleBar.Dock = DockStyle.Top;
            panelTitlleBar.Location = new Point(216, 0);
            panelTitlleBar.Name = "panelTitlleBar";
            panelTitlleBar.Size = new Size(878, 50);
            panelTitlleBar.TabIndex = 1;
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
            btnMinimize.Location = new Point(764, 0);
            btnMinimize.Margin = new Padding(3, 10, 3, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 24);
            btnMinimize.TabIndex = 6;
            btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = SystemColors.ButtonHighlight;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(804, 0);
            btnMaximize.Margin = new Padding(3, 10, 3, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 24);
            btnMaximize.TabIndex = 5;
            btnMaximize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaximize.UseVisualStyleBackColor = true;
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
            btnExit.Location = new Point(844, 0);
            btnExit.Margin = new Padding(3, 10, 3, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 24);
            btnExit.TabIndex = 4;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.AutoSize = true;
            lbNombreUsuario.BackColor = Color.Transparent;
            lbNombreUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreUsuario.ForeColor = SystemColors.ButtonFace;
            lbNombreUsuario.Location = new Point(455, 20);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(13, 19);
            lbNombreUsuario.TabIndex = 3;
            lbNombreUsuario.Text = "!";
            // 
            // lbBienvenido
            // 
            lbBienvenido.AutoSize = true;
            lbBienvenido.BackColor = Color.Transparent;
            lbBienvenido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbBienvenido.ForeColor = SystemColors.ButtonFace;
            lbBienvenido.Location = new Point(349, 20);
            lbBienvenido.Name = "lbBienvenido";
            lbBienvenido.Size = new Size(100, 19);
            lbBienvenido.TabIndex = 2;
            lbBienvenido.Text = "Bienvenido ";
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = SystemColors.ButtonFace;
            lblTitleChildForm.Location = new Point(69, 20);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(44, 16);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += lblTitleChildForm_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = SystemColors.Control;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = SystemColors.Control;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 43;
            iconCurrentChildForm.Location = new Point(20, 5);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(43, 48);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            iconCurrentChildForm.Click += iconCurrentChildForm_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(216, 50);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(878, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 64);
            panelDesktop.Controls.Add(panel2);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(216, 59);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(878, 546);
            panelDesktop.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(304, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 186);
            panel2.TabIndex = 1;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 605);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitlleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1110, 637);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainAdmin";
            panelMenu.ResumeLayout(false);
            logo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelTitlleBar.ResumeLayout(false);
            panelTitlleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnGestionUsuarios;
        private FontAwesome.Sharp.IconButton btnMovimientos;
        private Panel panelTitlleBar;
        private NotifyIcon notifyIcon1;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Label lbNombreUsuario;
        private Label lbBienvenido;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Panel logo;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnEgresos;
        private FontAwesome.Sharp.IconButton btnIngresos;
        private FontAwesome.Sharp.IconButton btnSolicitudes;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}
