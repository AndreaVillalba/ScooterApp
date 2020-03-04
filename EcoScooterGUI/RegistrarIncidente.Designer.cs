namespace EcoScooterGUI
{
    partial class formRegistrarIncidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistrarIncidente));
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmdGuardarIncidente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuEstacion = new System.Windows.Forms.MenuStrip();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuEstacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDescription.Location = new System.Drawing.Point(184, 209);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(609, 277);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "";
            // 
            // cmdGuardarIncidente
            // 
            this.cmdGuardarIncidente.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdGuardarIncidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardarIncidente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarIncidente.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdGuardarIncidente.Location = new System.Drawing.Point(405, 526);
            this.cmdGuardarIncidente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGuardarIncidente.Name = "cmdGuardarIncidente";
            this.cmdGuardarIncidente.Size = new System.Drawing.Size(137, 44);
            this.cmdGuardarIncidente.TabIndex = 1;
            this.cmdGuardarIncidente.Text = "Enviar";
            this.cmdGuardarIncidente.UseVisualStyleBackColor = false;
            this.cmdGuardarIncidente.Click += new System.EventHandler(this.cmdGuardarIncidente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoScooterGUI.Properties.Resources.eco_logo;
            this.pictureBox1.Location = new System.Drawing.Point(351, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.menuEstacion.Size = new System.Drawing.Size(978, 33);
            this.menuEstacion.TabIndex = 60;
            this.menuEstacion.Text = "menuStrip1";
            // 
            // tsRegresar
            // 
            this.tsRegresar.Name = "tsRegresar";
            this.tsRegresar.Size = new System.Drawing.Size(96, 29);
            this.tsRegresar.Text = "Regresar";
            this.tsRegresar.Click += new System.EventHandler(this.tsRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(234, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 33);
            this.label1.TabIndex = 61;
            this.label1.Text = "Lamentamos que le haya ocurrido un incidente durante su trayecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(327, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 33);
            this.label2.TabIndex = 62;
            this.label2.Text = "Por favor relate un informe de lo sucedido";
            // 
            // formRegistrarIncidente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuEstacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdGuardarIncidente);
            this.Controls.Add(this.txtDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formRegistrarIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Incidente";
            this.Load += new System.EventHandler(this.formRegistrarIncidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuEstacion.ResumeLayout(false);
            this.menuEstacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button cmdGuardarIncidente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuEstacion;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}