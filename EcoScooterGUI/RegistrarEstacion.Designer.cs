namespace EcoScooterGUI
{
    partial class formRegistrarEstacion
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
            this.menuEstacion = new System.Windows.Forms.MenuStrip();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.cmdRegistrarEstacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuEstacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEstacion
            // 
            this.menuEstacion.BackColor = System.Drawing.Color.AliceBlue;
            this.menuEstacion.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuEstacion.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuEstacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegresar,
            this.tsCerrarSesion});
            this.menuEstacion.Location = new System.Drawing.Point(0, 0);
            this.menuEstacion.Name = "menuEstacion";
            this.menuEstacion.Size = new System.Drawing.Size(978, 33);
            this.menuEstacion.TabIndex = 0;
            this.menuEstacion.Text = "menuStrip1";
            // 
            // tsRegresar
            // 
            this.tsRegresar.Name = "tsRegresar";
            this.tsRegresar.Size = new System.Drawing.Size(96, 29);
            this.tsRegresar.Text = "Regresar";
            this.tsRegresar.Click += new System.EventHandler(this.tsRegresar_Click);
            // 
            // tsCerrarSesion
            // 
            this.tsCerrarSesion.Name = "tsCerrarSesion";
            this.tsCerrarSesion.Size = new System.Drawing.Size(130, 29);
            this.tsCerrarSesion.Text = "Cerrar sesión";
            this.tsCerrarSesion.Click += new System.EventHandler(this.tsCerrarSesion_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(616, 293);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(307, 26);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "Direccion";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(616, 370);
            this.txtStationID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(307, 26);
            this.txtStationID.TabIndex = 2;
            this.txtStationID.Text = "ID";
            this.txtStationID.Click += new System.EventHandler(this.txtStationID_Click);
            this.txtStationID.TextChanged += new System.EventHandler(this.txtStationID_TextChanged);
            // 
            // cmdRegistrarEstacion
            // 
            this.cmdRegistrarEstacion.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdRegistrarEstacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRegistrarEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrarEstacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarEstacion.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdRegistrarEstacion.Location = new System.Drawing.Point(435, 547);
            this.cmdRegistrarEstacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegistrarEstacion.Name = "cmdRegistrarEstacion";
            this.cmdRegistrarEstacion.Size = new System.Drawing.Size(154, 55);
            this.cmdRegistrarEstacion.TabIndex = 5;
            this.cmdRegistrarEstacion.Text = "Registrar";
            this.cmdRegistrarEstacion.UseVisualStyleBackColor = false;
            this.cmdRegistrarEstacion.Click += new System.EventHandler(this.cmdRegistrarEstacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.adminlogo;
            this.pictureBox1.Location = new System.Drawing.Point(225, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(126, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dirección en la que se encuentra la nueva estación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(126, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID que se la va asignar a la nueva estación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(126, 441);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Latitud de la nueva estación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(126, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Longitud de la nueva estación:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(616, 442);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 26);
            this.txtLatitud.TabIndex = 20;
            this.txtLatitud.TextChanged += new System.EventHandler(this.txtLatitud_TextChanged_1);
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(616, 500);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 26);
            this.txtLongitud.TabIndex = 21;
            this.txtLongitud.TextChanged += new System.EventHandler(this.txtLongitud_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(211, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(607, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Introduzca los datos de la estación que deseas registrar";
            // 
            // formRegistrarEstacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRegistrarEstacion);
            this.Controls.Add(this.txtStationID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.menuEstacion);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuEstacion;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formRegistrarEstacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarEstacion";
            this.Load += new System.EventHandler(this.formRegistrarEstacion_Load);
            this.menuEstacion.ResumeLayout(false);
            this.menuEstacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEstacion;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarSesion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStationID;
        private System.Windows.Forms.Button cmdRegistrarEstacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label5;
    }
}