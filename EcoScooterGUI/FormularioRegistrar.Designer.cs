namespace EcoScooterGUI
{
    partial class formRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistrar));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdRegistroUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.menuEstacion = new System.Windows.Forms.MenuStrip();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuEstacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Location = new System.Drawing.Point(675, 230);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label1.Location = new System.Drawing.Point(537, 230);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(121, 18);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Nombre completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(204, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Identificacion (DNI)";
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd/MM/yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(468, 281);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateBirth.MaxDate = new System.DateTime(2019, 12, 13, 10, 42, 43, 0);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(149, 22);
            this.dateBirth.TabIndex = 6;
            this.dateBirth.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dateBirth.ValueChanged += new System.EventHandler(this.dateBirth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(304, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(55, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(659, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Telefono";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.DarkGreen;
            this.panelUser.Location = new System.Drawing.Point(51, 350);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(880, 2);
            this.panelUser.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(45, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "DATOS PERSONALES";
            // 
            // cmdRegistroUsuario
            // 
            this.cmdRegistroUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdRegistroUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistroUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdRegistroUsuario.Location = new System.Drawing.Point(416, 526);
            this.cmdRegistroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegistroUsuario.Name = "cmdRegistroUsuario";
            this.cmdRegistroUsuario.Size = new System.Drawing.Size(137, 44);
            this.cmdRegistroUsuario.TabIndex = 11;
            this.cmdRegistroUsuario.Text = "Registrar";
            this.cmdRegistroUsuario.UseVisualStyleBackColor = false;
            this.cmdRegistroUsuario.Click += new System.EventHandler(this.cmdRegistroUsuario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(733, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "CVV";
            // 
            // dateExpiration
            // 
            this.dateExpiration.CustomFormat = "dd/MM/yyyy";
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpiration.Location = new System.Drawing.Point(496, 414);
            this.dateExpiration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateExpiration.MaxDate = new System.DateTime(2029, 12, 13, 0, 0, 0, 0);
            this.dateExpiration.MinDate = new System.DateTime(2019, 12, 13, 0, 0, 0, 0);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(167, 22);
            this.dateExpiration.TabIndex = 9;
            this.dateExpiration.Value = new System.DateTime(2019, 12, 13, 0, 0, 0, 0);
            this.dateExpiration.ValueChanged += new System.EventHandler(this.dateExpiration_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(341, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fecha de Expiracion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(52, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 51;
            this.label11.Text = "Numero";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(781, 411);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Multiline = true;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(53, 22);
            this.txtCVV.TabIndex = 10;
            this.txtCVV.TextChanged += new System.EventHandler(this.txtCVV_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(51, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "MÉTODO DE PAGO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(531, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 58;
            this.label12.Text = "Contraseña";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(621, 137);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(269, 142);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(149, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(116, 411);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Mask = "0000 - 0000";
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PromptChar = ' ';
            this.txtCardNumber.Size = new System.Drawing.Size(167, 22);
            this.txtCardNumber.TabIndex = 8;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtTelephon
            // 
            this.txtTelephon.Location = new System.Drawing.Point(739, 278);
            this.txtTelephon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephon.Mask = "000 000 000";
            this.txtTelephon.Name = "txtTelephon";
            this.txtTelephon.Size = new System.Drawing.Size(149, 22);
            this.txtTelephon.TabIndex = 7;
            this.txtTelephon.TextChanged += new System.EventHandler(this.txtTelephon_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 281);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(349, 229);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Mask = "0000-0000-L";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PromptChar = ' ';
            this.txtDNI.Size = new System.Drawing.Size(95, 22);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // menuEstacion
            // 
            this.menuEstacion.BackColor = System.Drawing.Color.AliceBlue;
            this.menuEstacion.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuEstacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegresar});
            this.menuEstacion.Location = new System.Drawing.Point(0, 0);
            this.menuEstacion.Name = "menuEstacion";
            this.menuEstacion.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEstacion.Size = new System.Drawing.Size(982, 28);
            this.menuEstacion.TabIndex = 59;
            this.menuEstacion.Text = "menuStrip1";
            // 
            // tsRegresar
            // 
            this.tsRegresar.Name = "tsRegresar";
            this.tsRegresar.Size = new System.Drawing.Size(81, 24);
            this.tsRegresar.Text = "Regresar";
            this.tsRegresar.Click += new System.EventHandler(this.tsRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(51, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 2);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.user_logo;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(193, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Usuario";
            // 
            // formRegistrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 619);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuEstacion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtTelephon);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdRegistroUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.formRegistrar_Load);
            this.menuEstacion.ResumeLayout(false);
            this.menuEstacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBirth;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Panel panelUser;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button cmdRegistroUsuario;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateExpiration;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCVV;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.MaskedTextBox txtCardNumber;
        private System.Windows.Forms.MaskedTextBox txtTelephon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.MenuStrip menuEstacion;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label4;
    }
}