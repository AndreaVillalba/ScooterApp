namespace EcoScooterGUI
{
    partial class formRegistrarScooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistrarScooter));
            this.cboxEstacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuEstacion = new System.Windows.Forms.MenuStrip();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnDisponible = new System.Windows.Forms.RadioButton();
            this.rbtnUso = new System.Windows.Forms.RadioButton();
            this.rbtnMantenimiento = new System.Windows.Forms.RadioButton();
            this.registerDate = new System.Windows.Forms.DateTimePicker();
            this.cmdRegistrarScooter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuEstacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxEstacion
            // 
            this.cboxEstacion.FormattingEnabled = true;
            this.cboxEstacion.Location = new System.Drawing.Point(659, 458);
            this.cboxEstacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEstacion.Name = "cboxEstacion";
            this.cboxEstacion.Size = new System.Drawing.Size(178, 28);
            this.cboxEstacion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(132, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Seleccione la fecha en la que se registro el patinete:";
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
            this.menuEstacion.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEstacion.Size = new System.Drawing.Size(978, 33);
            this.menuEstacion.TabIndex = 53;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(132, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "Seleccione el estado en que se encuentra el patinete:";
            // 
            // rbtnDisponible
            // 
            this.rbtnDisponible.AutoSize = true;
            this.rbtnDisponible.Location = new System.Drawing.Point(21, 16);
            this.rbtnDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnDisponible.Name = "rbtnDisponible";
            this.rbtnDisponible.Size = new System.Drawing.Size(108, 24);
            this.rbtnDisponible.TabIndex = 2;
            this.rbtnDisponible.TabStop = true;
            this.rbtnDisponible.Text = "Disponible";
            this.rbtnDisponible.UseVisualStyleBackColor = true;
            this.rbtnDisponible.CheckedChanged += new System.EventHandler(this.rbtnDisponible_CheckedChanged);
            // 
            // rbtnUso
            // 
            this.rbtnUso.AutoSize = true;
            this.rbtnUso.Location = new System.Drawing.Point(21, 65);
            this.rbtnUso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnUso.Name = "rbtnUso";
            this.rbtnUso.Size = new System.Drawing.Size(87, 24);
            this.rbtnUso.TabIndex = 4;
            this.rbtnUso.TabStop = true;
            this.rbtnUso.Text = "En Uso";
            this.rbtnUso.UseVisualStyleBackColor = true;
            this.rbtnUso.CheckedChanged += new System.EventHandler(this.rbtnUso_CheckedChanged);
            // 
            // rbtnMantenimiento
            // 
            this.rbtnMantenimiento.AutoSize = true;
            this.rbtnMantenimiento.Location = new System.Drawing.Point(21, 40);
            this.rbtnMantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMantenimiento.Name = "rbtnMantenimiento";
            this.rbtnMantenimiento.Size = new System.Drawing.Size(139, 24);
            this.rbtnMantenimiento.TabIndex = 3;
            this.rbtnMantenimiento.TabStop = true;
            this.rbtnMantenimiento.Text = "Mantenimiento";
            this.rbtnMantenimiento.UseVisualStyleBackColor = true;
            this.rbtnMantenimiento.CheckedChanged += new System.EventHandler(this.rbtnMantenimiento_CheckedChanged);
            // 
            // registerDate
            // 
            this.registerDate.CustomFormat = "dd/MM/yyyy";
            this.registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registerDate.Location = new System.Drawing.Point(612, 289);
            this.registerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(178, 26);
            this.registerDate.TabIndex = 1;
            // 
            // cmdRegistrarScooter
            // 
            this.cmdRegistrarScooter.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdRegistrarScooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrarScooter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarScooter.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdRegistrarScooter.Location = new System.Drawing.Point(406, 526);
            this.cmdRegistrarScooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegistrarScooter.Name = "cmdRegistrarScooter";
            this.cmdRegistrarScooter.Size = new System.Drawing.Size(119, 52);
            this.cmdRegistrarScooter.TabIndex = 6;
            this.cmdRegistrarScooter.Text = "Registrar ";
            this.cmdRegistrarScooter.UseVisualStyleBackColor = false;
            this.cmdRegistrarScooter.Click += new System.EventHandler(this.cmdRegistrarScooter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(132, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Seleccione la estación en la que se va a registrar el patinete:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.adminlogo;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.rbtnMantenimiento);
            this.groupBox1.Controls.Add(this.rbtnDisponible);
            this.groupBox1.Controls.Add(this.rbtnUso);
            this.groupBox1.Location = new System.Drawing.Point(613, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 92);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(204, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 33);
            this.label4.TabIndex = 64;
            this.label4.Text = "Introduzca los datos del patinete que desea registrar";
            // 
            // formRegistrarScooter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdRegistrarScooter);
            this.Controls.Add(this.registerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuEstacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxEstacion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formRegistrarScooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarScooter";
            this.Load += new System.EventHandler(this.RegistrarScooter_Load);
            this.menuEstacion.ResumeLayout(false);
            this.menuEstacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxEstacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuEstacion;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnDisponible;
        private System.Windows.Forms.RadioButton rbtnUso;
        private System.Windows.Forms.RadioButton rbtnMantenimiento;
        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.Button cmdRegistrarScooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}