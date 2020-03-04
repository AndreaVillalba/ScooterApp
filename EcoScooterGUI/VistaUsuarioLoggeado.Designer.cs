namespace EcoScooterGUI
{
    partial class formVistaUserLogged
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVistaUserLogged));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEstacion = new System.Windows.Forms.ComboBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMisRutas = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDevolver = new System.Windows.Forms.PictureBox();
            this.btnAlquilar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlquilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(398, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "¿Qué quieres hacer?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(401, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "¡Hola, bienvenido!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(335, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 27);
            this.label2.TabIndex = 49;
            this.label2.Text = "¿En qué estación te encuentras?";
            // 
            // cboxEstacion
            // 
            this.cboxEstacion.FormattingEnabled = true;
            this.cboxEstacion.Location = new System.Drawing.Point(402, 125);
            this.cboxEstacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstacion.Name = "cboxEstacion";
            this.cboxEstacion.Size = new System.Drawing.Size(165, 24);
            this.cboxEstacion.TabIndex = 50;
            this.cboxEstacion.SelectedIndexChanged += new System.EventHandler(this.cboxEstacion_SelectedIndexChanged);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.DarkGreen;
            this.panelUser.Location = new System.Drawing.Point(309, 167);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(356, 1);
            this.panelUser.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(613, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "Devolver un patinete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(171, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "Alquilar un patinete";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMisRutas,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMisRutas
            // 
            this.tsMisRutas.Name = "tsMisRutas";
            this.tsMisRutas.Size = new System.Drawing.Size(82, 26);
            this.tsMisRutas.Text = "Mis rutas";
            this.tsMisRutas.Click += new System.EventHandler(this.tsMisRutas_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.Image = global::EcoScooterGUI.Properties.Resources._return;
            this.btnDevolver.Location = new System.Drawing.Point(573, 228);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(284, 275);
            this.btnDevolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.TabStop = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAlquilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlquilar.Image = global::EcoScooterGUI.Properties.Resources.rent1;
            this.btnAlquilar.Location = new System.Drawing.Point(131, 228);
            this.btnAlquilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(275, 275);
            this.btnAlquilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAlquilar.TabIndex = 0;
            this.btnAlquilar.TabStop = false;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // formVistaUserLogged
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 619);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.cboxEstacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnAlquilar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formVistaUserLogged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario Loggeado";
            this.Load += new System.EventHandler(this.formVistaUserLogged_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlquilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAlquilar;
        private System.Windows.Forms.PictureBox btnDevolver;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEstacion;
        internal System.Windows.Forms.Panel panelUser;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMisRutas;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}