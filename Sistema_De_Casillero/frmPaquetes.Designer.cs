
namespace Sistema_De_Casillero
{
    partial class frmPaquetes
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgPaquetes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioAlmacenaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudPaquete = new System.Windows.Forms.NumericUpDown();
            this.nudAlmacenaje = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlmacenje = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.cboEstante = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.lblFechaLLegada = new System.Windows.Forms.Label();
            this.dtpFechaLLegada = new System.Windows.Forms.DateTimePicker();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaquetes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlmacenaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgPaquetes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(303, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 528);
            this.panel4.TabIndex = 15;
            // 
            // dtgPaquetes
            // 
            this.dtgPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.vendedor,
            this.descripcion,
            this.cantidad,
            this.precioAlmacenaje,
            this.precioPaquete,
            this.fechRetiro,
            this.empleado,
            this.receptor,
            this.FechaLlegada,
            this.categoria,
            this.estante});
            this.dtgPaquetes.Location = new System.Drawing.Point(22, 6);
            this.dtgPaquetes.Name = "dtgPaquetes";
            this.dtgPaquetes.Size = new System.Drawing.Size(715, 503);
            this.dtgPaquetes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion ";
            this.descripcion.Name = "descripcion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad de Piezas";
            this.cantidad.Name = "cantidad";
            // 
            // precioAlmacenaje
            // 
            this.precioAlmacenaje.HeaderText = "Precio de Almcenaje";
            this.precioAlmacenaje.Name = "precioAlmacenaje";
            // 
            // precioPaquete
            // 
            this.precioPaquete.HeaderText = "Precio de Paquete";
            this.precioPaquete.Name = "precioPaquete";
            // 
            // fechRetiro
            // 
            this.fechRetiro.HeaderText = "Fecha de Retiro";
            this.fechRetiro.Name = "fechRetiro";
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Atendido Por";
            this.empleado.Name = "empleado";
            // 
            // receptor
            // 
            this.receptor.HeaderText = "Receptor de Paquete";
            this.receptor.Name = "receptor";
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.HeaderText = "Fecha de LLegada";
            this.FechaLlegada.Name = "FechaLlegada";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // estante
            // 
            this.estante.HeaderText = "Estante";
            this.estante.Name = "estante";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 66);
            this.panel3.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(611, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 18);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 30);
            this.txtBuscar.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudPaquete);
            this.panel2.Controls.Add(this.nudAlmacenaje);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtReceptor);
            this.panel2.Controls.Add(this.lblReceptor);
            this.panel2.Controls.Add(this.lblFechaRetiro);
            this.panel2.Controls.Add(this.dtpFechaRetiro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblAlmacenje);
            this.panel2.Controls.Add(this.nudCantidad);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblEstante);
            this.panel2.Controls.Add(this.cboEstante);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cboCategorias);
            this.panel2.Controls.Add(this.lblFechaLLegada);
            this.panel2.Controls.Add(this.dtpFechaLLegada);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 594);
            this.panel2.TabIndex = 13;
            // 
            // nudPaquete
            // 
            this.nudPaquete.DecimalPlaces = 2;
            this.nudPaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaquete.Location = new System.Drawing.Point(180, 340);
            this.nudPaquete.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPaquete.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.nudPaquete.Name = "nudPaquete";
            this.nudPaquete.Size = new System.Drawing.Size(82, 23);
            this.nudPaquete.TabIndex = 27;
            this.nudPaquete.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // nudAlmacenaje
            // 
            this.nudAlmacenaje.DecimalPlaces = 2;
            this.nudAlmacenaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlmacenaje.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAlmacenaje.Location = new System.Drawing.Point(180, 306);
            this.nudAlmacenaje.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAlmacenaje.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAlmacenaje.Name = "nudAlmacenaje";
            this.nudAlmacenaje.Size = new System.Drawing.Size(82, 23);
            this.nudAlmacenaje.TabIndex = 26;
            this.nudAlmacenaje.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(29, 545);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 30);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(29, 509);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(235, 30);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(29, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(235, 31);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtReceptor
            // 
            this.txtReceptor.Location = new System.Drawing.Point(29, 442);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(235, 20);
            this.txtReceptor.TabIndex = 22;
            // 
            // lblReceptor
            // 
            this.lblReceptor.AutoSize = true;
            this.lblReceptor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptor.Location = new System.Drawing.Point(26, 422);
            this.lblReceptor.Name = "lblReceptor";
            this.lblReceptor.Size = new System.Drawing.Size(141, 17);
            this.lblReceptor.TabIndex = 21;
            this.lblReceptor.Text = "Nombre de receptor";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRetiro.Location = new System.Drawing.Point(26, 371);
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(105, 17);
            this.lblFechaRetiro.TabIndex = 19;
            this.lblFechaRetiro.Text = "Fecha de retiro";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRetiro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRetiro.Location = new System.Drawing.Point(29, 391);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(235, 21);
            this.dtpFechaRetiro.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Precio de paquete";
            // 
            // lblAlmacenje
            // 
            this.lblAlmacenje.AutoSize = true;
            this.lblAlmacenje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenje.Location = new System.Drawing.Point(26, 308);
            this.lblAlmacenje.Name = "lblAlmacenje";
            this.lblAlmacenje.Size = new System.Drawing.Size(151, 17);
            this.lblAlmacenje.TabIndex = 15;
            this.lblAlmacenje.Text = "Precio de almacenaje";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(103, 271);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(82, 23);
            this.nudCantidad.TabIndex = 14;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(26, 273);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(27, 204);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 61);
            this.txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 184);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstante.Location = new System.Drawing.Point(26, 127);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(55, 17);
            this.lblEstante.TabIndex = 10;
            this.lblEstante.Text = "Estante";
            // 
            // cboEstante
            // 
            this.cboEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstante.FormattingEnabled = true;
            this.cboEstante.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboEstante.Location = new System.Drawing.Point(27, 148);
            this.cboEstante.Name = "cboEstante";
            this.cboEstante.Size = new System.Drawing.Size(158, 25);
            this.cboEstante.TabIndex = 9;
            this.cboEstante.Text = "Seleccione...";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(26, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategorias
            // 
            this.cboCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Items.AddRange(new object[] {
            "Ropa",
            "Zapatos",
            "Juguetes"});
            this.cboCategorias.Location = new System.Drawing.Point(27, 93);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(158, 25);
            this.cboCategorias.TabIndex = 7;
            this.cboCategorias.Text = "Seleccione...";
            // 
            // lblFechaLLegada
            // 
            this.lblFechaLLegada.AutoSize = true;
            this.lblFechaLLegada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLLegada.Location = new System.Drawing.Point(24, 23);
            this.lblFechaLLegada.Name = "lblFechaLLegada";
            this.lblFechaLLegada.Size = new System.Drawing.Size(122, 17);
            this.lblFechaLLegada.TabIndex = 3;
            this.lblFechaLLegada.Text = "Fecha de llegada";
            // 
            // dtpFechaLLegada
            // 
            this.dtpFechaLLegada.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLLegada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLLegada.Location = new System.Drawing.Point(27, 43);
            this.dtpFechaLLegada.Name = "dtpFechaLLegada";
            this.dtpFechaLLegada.Size = new System.Drawing.Size(235, 21);
            this.dtpFechaLLegada.TabIndex = 6;
            // 
            // frmPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmPaquetes";
            this.Text = "frmPaquetes";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaquetes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlmacenaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgPaquetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioAlmacenaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn estante;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudPaquete;
        private System.Windows.Forms.NumericUpDown nudAlmacenaje;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label lblReceptor;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlmacenje;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.ComboBox cboEstante;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Label lblFechaLLegada;
        private System.Windows.Forms.DateTimePicker dtpFechaLLegada;
    }
}