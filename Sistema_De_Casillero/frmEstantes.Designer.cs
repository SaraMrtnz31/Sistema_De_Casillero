
namespace Sistema_De_Casillero
{
    partial class frmEstantes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEstantes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblErrorCat = new System.Windows.Forms.Label();
            this.lblErrorCodEstante = new System.Windows.Forms.Label();
            this.nudNumEstante = new System.Windows.Forms.NumericUpDown();
            this.txtCodEstante = new System.Windows.Forms.TextBox();
            this.lblCodEstante = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumEstante = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstantes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEstante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.dgvEstantes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(303, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 594);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 63);
            this.panel1.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(82, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 20);
            this.lblBuscar.TabIndex = 37;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBuscar.Location = new System.Drawing.Point(150, 25);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(500, 25);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // dgvEstantes
            // 
            this.dgvEstantes.AllowUserToAddRows = false;
            this.dgvEstantes.AllowUserToDeleteRows = false;
            this.dgvEstantes.AllowUserToOrderColumns = true;
            this.dgvEstantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstantes.Location = new System.Drawing.Point(19, 73);
            this.dgvEstantes.Name = "dgvEstantes";
            this.dgvEstantes.ReadOnly = true;
            this.dgvEstantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstantes.Size = new System.Drawing.Size(709, 495);
            this.dgvEstantes.TabIndex = 0;
            this.dgvEstantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstantes_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblErrorCat);
            this.panel2.Controls.Add(this.lblErrorCodEstante);
            this.panel2.Controls.Add(this.nudNumEstante);
            this.panel2.Controls.Add(this.txtCodEstante);
            this.panel2.Controls.Add(this.lblCodEstante);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cboCategorias);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblNumEstante);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 594);
            this.panel2.TabIndex = 22;
            // 
            // lblErrorCat
            // 
            this.lblErrorCat.AutoSize = true;
            this.lblErrorCat.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCat.Location = new System.Drawing.Point(120, 151);
            this.lblErrorCat.Name = "lblErrorCat";
            this.lblErrorCat.Size = new System.Drawing.Size(158, 16);
            this.lblErrorCat.TabIndex = 36;
            this.lblErrorCat.Text = "*seleccione una categoría*";
            this.lblErrorCat.Visible = false;
            // 
            // lblErrorCodEstante
            // 
            this.lblErrorCodEstante.AutoSize = true;
            this.lblErrorCodEstante.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCodEstante.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodEstante.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodEstante.Location = new System.Drawing.Point(167, 34);
            this.lblErrorCodEstante.Name = "lblErrorCodEstante";
            this.lblErrorCodEstante.Size = new System.Drawing.Size(115, 16);
            this.lblErrorCodEstante.TabIndex = 35;
            this.lblErrorCodEstante.Text = "*ingrese un código*";
            this.lblErrorCodEstante.Visible = false;
            // 
            // nudNumEstante
            // 
            this.nudNumEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumEstante.Location = new System.Drawing.Point(33, 109);
            this.nudNumEstante.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumEstante.Name = "nudNumEstante";
            this.nudNumEstante.Size = new System.Drawing.Size(120, 23);
            this.nudNumEstante.TabIndex = 34;
            this.nudNumEstante.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCodEstante
            // 
            this.txtCodEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEstante.Location = new System.Drawing.Point(31, 54);
            this.txtCodEstante.MaxLength = 6;
            this.txtCodEstante.Name = "txtCodEstante";
            this.txtCodEstante.Size = new System.Drawing.Size(235, 23);
            this.txtCodEstante.TabIndex = 33;
            this.txtCodEstante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodEstante_KeyUp);
            // 
            // lblCodEstante
            // 
            this.lblCodEstante.AutoSize = true;
            this.lblCodEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEstante.Location = new System.Drawing.Point(30, 34);
            this.lblCodEstante.Name = "lblCodEstante";
            this.lblCodEstante.Size = new System.Drawing.Size(131, 17);
            this.lblCodEstante.TabIndex = 32;
            this.lblCodEstante.Text = "Código de estante";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(30, 149);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 31;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategorias
            // 
            this.cboCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.ForeColor = System.Drawing.Color.Black;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(31, 170);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(233, 25);
            this.cboCategorias.TabIndex = 30;
            this.cboCategorias.Text = "Seleccione...";
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(29, 246);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 97);
            this.txtDescripcion.TabIndex = 29;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 219);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNumEstante
            // 
            this.lblNumEstante.AutoSize = true;
            this.lblNumEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEstante.Location = new System.Drawing.Point(30, 89);
            this.lblNumEstante.Name = "lblNumEstante";
            this.lblNumEstante.Size = new System.Drawing.Size(133, 17);
            this.lblNumEstante.TabIndex = 26;
            this.lblNumEstante.Text = "Número de estante";
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
            this.btnEliminar.Location = new System.Drawing.Point(29, 538);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 30);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(29, 502);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(235, 30);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(29, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(235, 31);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmEstantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "frmEstantes";
            this.Text = "frmEstantes";
            this.Load += new System.EventHandler(this.frmEstantes_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstantes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEstante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvEstantes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumEstante;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox txtCodEstante;
        private System.Windows.Forms.Label lblCodEstante;
        private System.Windows.Forms.NumericUpDown nudNumEstante;
        private System.Windows.Forms.Label lblErrorCat;
        private System.Windows.Forms.Label lblErrorCodEstante;
        private System.Windows.Forms.Label lblBuscar;
    }
}