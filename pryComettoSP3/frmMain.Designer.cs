namespace pryComettoSP3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mrcTurnos = new System.Windows.Forms.GroupBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblModeloAntiguo = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.txtDominioSeisChars = new System.Windows.Forms.TextBox();
            this.txtModeloAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.lblDominioSeisChars = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTurnos
            // 
            this.mrcTurnos.Controls.Add(this.lblTitular);
            this.mrcTurnos.Controls.Add(this.lblModelo);
            this.mrcTurnos.Controls.Add(this.lblDominio);
            this.mrcTurnos.Controls.Add(this.lblTurno);
            this.mrcTurnos.Controls.Add(this.txtTitular);
            this.mrcTurnos.Controls.Add(this.nudModelo);
            this.mrcTurnos.Controls.Add(this.txtTurno);
            this.mrcTurnos.Controls.Add(this.txtDominio);
            this.mrcTurnos.Location = new System.Drawing.Point(12, 12);
            this.mrcTurnos.Name = "mrcTurnos";
            this.mrcTurnos.Size = new System.Drawing.Size(479, 143);
            this.mrcTurnos.TabIndex = 0;
            this.mrcTurnos.TabStop = false;
            this.mrcTurnos.Text = "Registro de Turnos";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Enabled = false;
            this.lblTitular.Location = new System.Drawing.Point(6, 111);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 8;
            this.lblTitular.Text = "Titular";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Enabled = false;
            this.lblModelo.Location = new System.Drawing.Point(6, 82);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(99, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Año de Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Enabled = false;
            this.lblDominio.Location = new System.Drawing.Point(6, 53);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 6;
            this.lblDominio.Text = "Dominio";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(6, 22);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(90, 13);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Número de Turno";
            // 
            // txtTitular
            // 
            this.txtTitular.Enabled = false;
            this.txtTitular.Location = new System.Drawing.Point(111, 108);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(280, 20);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // nudModelo
            // 
            this.nudModelo.Enabled = false;
            this.nudModelo.Location = new System.Drawing.Point(111, 80);
            this.nudModelo.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudModelo.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(49, 20);
            this.nudModelo.TabIndex = 5;
            this.nudModelo.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(111, 19);
            this.txtTurno.MaxLength = 5;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(76, 20);
            this.txtTurno.TabIndex = 2;
            this.txtTurno.TextChanged += new System.EventHandler(this.txtTurno_TextChanged);
            this.txtTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurno_KeyPress);
            // 
            // txtDominio
            // 
            this.txtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDominio.Enabled = false;
            this.txtDominio.Location = new System.Drawing.Point(111, 50);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(112, 20);
            this.txtDominio.TabIndex = 4;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.lblModeloAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.txtDominioSeisChars);
            this.mrcEstadisticas.Controls.Add(this.txtModeloAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.lblDominioSeisChars);
            this.mrcEstadisticas.Location = new System.Drawing.Point(12, 200);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(479, 120);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadísticas";
            // 
            // lblModeloAntiguo
            // 
            this.lblModeloAntiguo.AutoSize = true;
            this.lblModeloAntiguo.Location = new System.Drawing.Point(6, 56);
            this.lblModeloAntiguo.Name = "lblModeloAntiguo";
            this.lblModeloAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblModeloAntiguo.TabIndex = 10;
            this.lblModeloAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(6, 22);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadTurnos.TabIndex = 9;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // txtDominioSeisChars
            // 
            this.txtDominioSeisChars.Location = new System.Drawing.Point(224, 87);
            this.txtDominioSeisChars.Name = "txtDominioSeisChars";
            this.txtDominioSeisChars.ReadOnly = true;
            this.txtDominioSeisChars.Size = new System.Drawing.Size(76, 20);
            this.txtDominioSeisChars.TabIndex = 6;
            // 
            // txtModeloAntiguo
            // 
            this.txtModeloAntiguo.Location = new System.Drawing.Point(224, 53);
            this.txtModeloAntiguo.Name = "txtModeloAntiguo";
            this.txtModeloAntiguo.ReadOnly = true;
            this.txtModeloAntiguo.Size = new System.Drawing.Size(76, 20);
            this.txtModeloAntiguo.TabIndex = 7;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(224, 19);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(76, 20);
            this.txtCantidadTurnos.TabIndex = 8;
            // 
            // lblDominioSeisChars
            // 
            this.lblDominioSeisChars.AutoSize = true;
            this.lblDominioSeisChars.Location = new System.Drawing.Point(6, 90);
            this.lblDominioSeisChars.Name = "lblDominioSeisChars";
            this.lblDominioSeisChars.Size = new System.Drawing.Size(189, 13);
            this.lblDominioSeisChars.TabIndex = 11;
            this.lblDominioSeisChars.Text = "Cantidad con Dominio de 6 Caracteres";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(497, 16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 35);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(497, 204);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 35);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(497, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 326);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Auto Test";
            this.mrcTurnos.ResumeLayout(false);
            this.mrcTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTurnos;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.Label lblModeloAntiguo;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.TextBox txtDominioSeisChars;
        private System.Windows.Forms.TextBox txtModeloAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblDominioSeisChars;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}

