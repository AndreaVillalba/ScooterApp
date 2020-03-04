namespace EcoScooterGUI
{
    partial class formInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicioSesion));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLoginUs = new System.Windows.Forms.TextBox();
            this.cmdIniciarSesionUs = new System.Windows.Forms.Button();
            this.txtPasswordUs = new System.Windows.Forms.TextBox();
            this.MostrarPassUs = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtLoginTrab = new System.Windows.Forms.TextBox();
            this.MostrarPassTrab = new System.Windows.Forms.CheckBox();
            this.cmdIniciarSesionTrab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtPasswordTrab = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodaLaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPoblarBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtLoginUs
            // 
            this.txtLoginUs.BackColor = System.Drawing.Color.White;
            this.txtLoginUs.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUs.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUs.Location = new System.Drawing.Point(93, 60);
            this.txtLoginUs.Name = "txtLoginUs";
            this.txtLoginUs.Size = new System.Drawing.Size(164, 24);
            this.txtLoginUs.TabIndex = 1;
            this.txtLoginUs.Text = "Usuario";
            this.txtLoginUs.Click += new System.EventHandler(this.txtLoginUs_Click);
            this.txtLoginUs.TextChanged += new System.EventHandler(this.txtLoginUs_TextChanged);
            // 
            // cmdIniciarSesionUs
            // 
            this.cmdIniciarSesionUs.BackColor = System.Drawing.Color.White;
            this.cmdIniciarSesionUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdIniciarSesionUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIniciarSesionUs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesionUs.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdIniciarSesionUs.Location = new System.Drawing.Point(113, 253);
            this.cmdIniciarSesionUs.Name = "cmdIniciarSesionUs";
            this.cmdIniciarSesionUs.Size = new System.Drawing.Size(120, 36);
            this.cmdIniciarSesionUs.TabIndex = 4;
            this.cmdIniciarSesionUs.Text = "Iniciar sesión";
            this.cmdIniciarSesionUs.UseVisualStyleBackColor = false;
            this.cmdIniciarSesionUs.Click += new System.EventHandler(this.cmdIniciarSesionUs_Click);
            // 
            // txtPasswordUs
            // 
            this.txtPasswordUs.BackColor = System.Drawing.Color.White;
            this.txtPasswordUs.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUs.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordUs.Location = new System.Drawing.Point(93, 132);
            this.txtPasswordUs.Name = "txtPasswordUs";
            this.txtPasswordUs.Size = new System.Drawing.Size(164, 24);
            this.txtPasswordUs.TabIndex = 2;
            this.txtPasswordUs.Text = "Contraseña";
            this.txtPasswordUs.Click += new System.EventHandler(this.txtPasswordUs_Click);
            this.txtPasswordUs.TextChanged += new System.EventHandler(this.txtPasswordUs_TextChanged);
            // 
            // MostrarPassUs
            // 
            this.MostrarPassUs.AutoSize = true;
            this.MostrarPassUs.BackColor = System.Drawing.Color.Transparent;
            this.MostrarPassUs.ForeColor = System.Drawing.Color.Transparent;
            this.MostrarPassUs.Location = new System.Drawing.Point(239, 175);
            this.MostrarPassUs.Name = "MostrarPassUs";
            this.MostrarPassUs.Size = new System.Drawing.Size(15, 14);
            this.MostrarPassUs.TabIndex = 3;
            this.MostrarPassUs.UseVisualStyleBackColor = false;
            this.MostrarPassUs.CheckedChanged += new System.EventHandler(this.MostrarPassUs_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Location = new System.Drawing.Point(415, 326);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 14);
            this.Label1.TabIndex = 22;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCrearCuenta.Location = new System.Drawing.Point(133, 333);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(83, 17);
            this.lblCrearCuenta.TabIndex = 5;
            this.lblCrearCuenta.Text = "Crear cuenta";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "¿Aún no estás registrado?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLoginUs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCrearCuenta);
            this.panel1.Controls.Add(this.cmdIniciarSesionUs);
            this.panel1.Controls.Add(this.txtPasswordUs);
            this.panel1.Controls.Add(this.MostrarPassUs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(106, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 372);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mostrar contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.friend_human_man_member_person_profile_user_users_icon_1320168707291252637;
            this.pictureBox1.Location = new System.Drawing.Point(49, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Image = global::EcoScooterGUI.Properties.Resources.locked_log_login_padlock_password_private_protection_register_1320168712292066823;
            this.pictureBox2.Location = new System.Drawing.Point(49, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // txtLoginTrab
            // 
            this.txtLoginTrab.BackColor = System.Drawing.Color.White;
            this.txtLoginTrab.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginTrab.ForeColor = System.Drawing.Color.Black;
            this.txtLoginTrab.Location = new System.Drawing.Point(94, 60);
            this.txtLoginTrab.Name = "txtLoginTrab";
            this.txtLoginTrab.Size = new System.Drawing.Size(164, 24);
            this.txtLoginTrab.TabIndex = 6;
            this.txtLoginTrab.Text = "DNI";
            this.txtLoginTrab.Click += new System.EventHandler(this.txtLoginTrab_Click);
            this.txtLoginTrab.TextChanged += new System.EventHandler(this.txtLoginTrab_TextChanged);
            // 
            // MostrarPassTrab
            // 
            this.MostrarPassTrab.AutoSize = true;
            this.MostrarPassTrab.BackColor = System.Drawing.Color.Transparent;
            this.MostrarPassTrab.ForeColor = System.Drawing.Color.Transparent;
            this.MostrarPassTrab.Location = new System.Drawing.Point(236, 180);
            this.MostrarPassTrab.Name = "MostrarPassTrab";
            this.MostrarPassTrab.Size = new System.Drawing.Size(15, 14);
            this.MostrarPassTrab.TabIndex = 8;
            this.MostrarPassTrab.UseVisualStyleBackColor = false;
            this.MostrarPassTrab.CheckedChanged += new System.EventHandler(this.MostrarPassTrab_CheckedChanged);
            // 
            // cmdIniciarSesionTrab
            // 
            this.cmdIniciarSesionTrab.BackColor = System.Drawing.Color.White;
            this.cmdIniciarSesionTrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdIniciarSesionTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIniciarSesionTrab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesionTrab.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdIniciarSesionTrab.Location = new System.Drawing.Point(102, 253);
            this.cmdIniciarSesionTrab.Name = "cmdIniciarSesionTrab";
            this.cmdIniciarSesionTrab.Size = new System.Drawing.Size(120, 36);
            this.cmdIniciarSesionTrab.TabIndex = 9;
            this.cmdIniciarSesionTrab.Text = "Iniciar sesión";
            this.cmdIniciarSesionTrab.UseVisualStyleBackColor = false;
            this.cmdIniciarSesionTrab.Click += new System.EventHandler(this.cmdIniciarSesionTrab_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.txtLoginTrab);
            this.panel2.Controls.Add(this.cmdIniciarSesionTrab);
            this.panel2.Controls.Add(this.MostrarPassTrab);
            this.panel2.Controls.Add(this.txtPasswordTrab);
            this.panel2.Location = new System.Drawing.Point(491, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 372);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mostrar contraseña";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox4.Image = global::EcoScooterGUI.Properties.Resources.friend_human_man_member_person_profile_user_users_icon_1320168707291252637;
            this.pictureBox4.Location = new System.Drawing.Point(49, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox5.Image = global::EcoScooterGUI.Properties.Resources.locked_log_login_padlock_password_private_protection_register_1320168712292066823;
            this.pictureBox5.Location = new System.Drawing.Point(50, 127);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // txtPasswordTrab
            // 
            this.txtPasswordTrab.BackColor = System.Drawing.Color.White;
            this.txtPasswordTrab.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordTrab.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordTrab.Location = new System.Drawing.Point(94, 132);
            this.txtPasswordTrab.MaxLength = 4;
            this.txtPasswordTrab.Name = "txtPasswordTrab";
            this.txtPasswordTrab.Size = new System.Drawing.Size(164, 24);
            this.txtPasswordTrab.TabIndex = 7;
            this.txtPasswordTrab.Text = "PIN";
            this.txtPasswordTrab.Click += new System.EventHandler(this.txtPasswordTrab_Click);
            this.txtPasswordTrab.TextChanged += new System.EventHandler(this.txtPasswordTrab_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarTodaLaDataToolStripMenuItem,
            this.tsPoblarBaseDatos});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // borrarTodaLaDataToolStripMenuItem
            // 
            this.borrarTodaLaDataToolStripMenuItem.Name = "borrarTodaLaDataToolStripMenuItem";
            this.borrarTodaLaDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.borrarTodaLaDataToolStripMenuItem.Text = "Borrar toda la data";
            this.borrarTodaLaDataToolStripMenuItem.Click += new System.EventHandler(this.borrarTodaLaDataToolStripMenuItem_Click);
            // 
            // tsPoblarBaseDatos
            // 
            this.tsPoblarBaseDatos.Name = "tsPoblarBaseDatos";
            this.tsPoblarBaseDatos.Size = new System.Drawing.Size(183, 22);
            this.tsPoblarBaseDatos.Text = "Poblar base de datos";
            this.tsPoblarBaseDatos.Click += new System.EventHandler(this.tsPoblarBaseDatos_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::EcoScooterGUI.Properties.Resources.scooter;
            this.pictureBox6.Location = new System.Drawing.Point(753, 275);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(304, 349);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::EcoScooterGUI.Properties.Resources.eco_logo;
            this.pictureBox3.Location = new System.Drawing.Point(237, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(528, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Trabajador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Usuario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // formInicioSesion
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.formInicioSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox txtLoginUs;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button cmdIniciarSesionUs;
        internal System.Windows.Forms.TextBox txtPasswordUs;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.CheckBox MostrarPassUs;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblCrearCuenta;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        internal System.Windows.Forms.TextBox txtLoginTrab;
        internal System.Windows.Forms.CheckBox MostrarPassTrab;
        private System.Windows.Forms.PictureBox pictureBox5;
        internal System.Windows.Forms.Button cmdIniciarSesionTrab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTodaLaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsPoblarBaseDatos;
        internal System.Windows.Forms.TextBox txtPasswordTrab;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

