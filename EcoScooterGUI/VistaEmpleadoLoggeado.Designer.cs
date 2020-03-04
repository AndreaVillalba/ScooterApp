namespace EcoScooterGUI
{
    partial class formEmpleadoLoggeado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEmpleadoLoggeado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxRegisterScooter = new System.Windows.Forms.PictureBox();
            this.pboxRegisterStation = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegisterScooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegisterStation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(623, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar una estación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(178, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registrar un patinete";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(978, 33);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.adminlogo;
            this.pictureBox1.Location = new System.Drawing.Point(228, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pboxRegisterScooter
            // 
            this.pboxRegisterScooter.BackColor = System.Drawing.Color.AliceBlue;
            this.pboxRegisterScooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxRegisterScooter.Image = global::EcoScooterGUI.Properties.Resources.news;
            this.pboxRegisterScooter.Location = new System.Drawing.Point(124, 226);
            this.pboxRegisterScooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxRegisterScooter.Name = "pboxRegisterScooter";
            this.pboxRegisterScooter.Size = new System.Drawing.Size(298, 287);
            this.pboxRegisterScooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRegisterScooter.TabIndex = 1;
            this.pboxRegisterScooter.TabStop = false;
            this.pboxRegisterScooter.Click += new System.EventHandler(this.pboxRegisterScooter_Click);
            // 
            // pboxRegisterStation
            // 
            this.pboxRegisterStation.BackColor = System.Drawing.Color.AliceBlue;
            this.pboxRegisterStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxRegisterStation.Image = global::EcoScooterGUI.Properties.Resources.newstation;
            this.pboxRegisterStation.Location = new System.Drawing.Point(566, 226);
            this.pboxRegisterStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxRegisterStation.Name = "pboxRegisterStation";
            this.pboxRegisterStation.Size = new System.Drawing.Size(298, 287);
            this.pboxRegisterStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRegisterStation.TabIndex = 0;
            this.pboxRegisterStation.TabStop = false;
            this.pboxRegisterStation.Click += new System.EventHandler(this.pboxRegisterStation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(416, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Qué deseas hacer?";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.DarkGreen;
            this.panelUser.Location = new System.Drawing.Point(313, 170);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(356, 1);
            this.panelUser.TabIndex = 52;
            // 
            // formEmpleadoLoggeado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxRegisterScooter);
            this.Controls.Add(this.pboxRegisterStation);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formEmpleadoLoggeado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado loggeado";
            this.Load += new System.EventHandler(this.formEmpleadoLoggeado_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegisterScooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegisterStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxRegisterStation;
        private System.Windows.Forms.PictureBox pboxRegisterScooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Panel panelUser;
    }
}