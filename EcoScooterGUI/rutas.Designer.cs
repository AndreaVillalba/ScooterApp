namespace EcoScooterGUI
{
    partial class formRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRutas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.bsRutas = new System.Windows.Forms.BindingSource(this.components);
            this.dgwRutas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdBuscarRutas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegresar,
            this.tsCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsRegresar
            // 
            this.tsRegresar.Name = "tsRegresar";
            this.tsRegresar.Size = new System.Drawing.Size(81, 26);
            this.tsRegresar.Text = "Regresar";
            this.tsRegresar.Click += new System.EventHandler(this.tsRegresar_Click);
            // 
            // tsCerrarSesion
            // 
            this.tsCerrarSesion.Name = "tsCerrarSesion";
            this.tsCerrarSesion.Size = new System.Drawing.Size(110, 26);
            this.tsCerrarSesion.Text = "Cerrar Sesión";
            this.tsCerrarSesion.Click += new System.EventHandler(this.tsCerrarSesion_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(108, 48);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(261, 22);
            this.dateFrom.TabIndex = 5;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(108, 139);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(261, 22);
            this.dateTo.TabIndex = 6;
            // 
            // dgwRutas
            // 
            this.dgwRutas.AllowUserToAddRows = false;
            this.dgwRutas.AllowUserToDeleteRows = false;
            this.dgwRutas.AllowUserToOrderColumns = true;
            this.dgwRutas.AutoGenerateColumns = false;
            this.dgwRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwRutas.BackgroundColor = System.Drawing.Color.White;
            this.dgwRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fech_ini,
            this.fech_fin,
            this.price,
            this.originStation,
            this.destinationStation});
            this.dgwRutas.DataSource = this.bsRutas;
            this.dgwRutas.GridColor = System.Drawing.Color.AliceBlue;
            this.dgwRutas.Location = new System.Drawing.Point(35, 305);
            this.dgwRutas.Name = "dgwRutas";
            this.dgwRutas.ReadOnly = true;
            this.dgwRutas.RowHeadersWidth = 51;
            this.dgwRutas.RowTemplate.Height = 24;
            this.dgwRutas.Size = new System.Drawing.Size(904, 302);
            this.dgwRutas.TabIndex = 7;
            // 
            // id
            // 
            this.id.DataPropertyName = "ds_id";
            this.id.HeaderText = "Rental ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fech_ini
            // 
            this.fech_ini.DataPropertyName = "ds_start";
            this.fech_ini.HeaderText = "Fecha de inicio";
            this.fech_ini.MinimumWidth = 6;
            this.fech_ini.Name = "fech_ini";
            this.fech_ini.ReadOnly = true;
            // 
            // fech_fin
            // 
            this.fech_fin.DataPropertyName = "ds_end";
            this.fech_fin.HeaderText = "Fecha de fin";
            this.fech_fin.MinimumWidth = 6;
            this.fech_fin.Name = "fech_fin";
            this.fech_fin.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "ds_price";
            this.price.HeaderText = "Precio ";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // originStation
            // 
            this.originStation.DataPropertyName = "ds_originStation";
            this.originStation.HeaderText = "Estacion de origen";
            this.originStation.MinimumWidth = 6;
            this.originStation.Name = "originStation";
            this.originStation.ReadOnly = true;
            // 
            // destinationStation
            // 
            this.destinationStation.DataPropertyName = "ds_destinationStation";
            this.destinationStation.HeaderText = "Estacion de destino";
            this.destinationStation.MinimumWidth = 6;
            this.destinationStation.Name = "destinationStation";
            this.destinationStation.ReadOnly = true;
            // 
            // cmdBuscarRutas
            // 
            this.cmdBuscarRutas.BackColor = System.Drawing.Color.White;
            this.cmdBuscarRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscarRutas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarRutas.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdBuscarRutas.Location = new System.Drawing.Point(492, 66);
            this.cmdBuscarRutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBuscarRutas.Name = "cmdBuscarRutas";
            this.cmdBuscarRutas.Size = new System.Drawing.Size(144, 44);
            this.cmdBuscarRutas.TabIndex = 8;
            this.cmdBuscarRutas.Text = "Buscar rutas";
            this.cmdBuscarRutas.UseVisualStyleBackColor = false;
            this.cmdBuscarRutas.Click += new System.EventHandler(this.cmdBuscarRutas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmdBuscarRutas);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Location = new System.Drawing.Point(141, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(724, 172);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(113, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(108, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(137, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aquí podras consultar las diferentes rutas realizadas entre dos fechas determinad" +
    "as";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(295, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Te encuentras en el buscador de recorrido";
            // 
            // formRutas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwRutas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 666);
            this.MinimumSize = new System.Drawing.Size(1000, 666);
            this.Name = "formRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas del usuario";
            this.Load += new System.EventHandler(this.formRutas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarSesion;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DataGridView dgwRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fech_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn fech_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn originStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationStation;
        private System.Windows.Forms.Button cmdBuscarRutas;
        private System.Windows.Forms.BindingSource bsRutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}