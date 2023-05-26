
namespace Sistema_De_Casillero
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.iconActualFormulario = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtnPaquete = new FontAwesome.Sharp.IconButton();
            this.btnCategorias = new FontAwesome.Sharp.IconButton();
            this.btnPaquetes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoInicio = new System.Windows.Forms.PictureBox();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualFormulario)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Controls.Add(this.pictureBox1);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 47);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1056, 634);
            this.panelEscritorio.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelBarraTitulo.Controls.Add(this.iconActualFormulario);
            this.panelBarraTitulo.Controls.Add(this.lblTituloFormulario);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1056, 47);
            this.panelBarraTitulo.TabIndex = 5;
            // 
            // iconActualFormulario
            // 
            this.iconActualFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconActualFormulario.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.iconActualFormulario.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconActualFormulario.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconActualFormulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualFormulario.IconSize = 27;
            this.iconActualFormulario.Location = new System.Drawing.Point(26, 11);
            this.iconActualFormulario.Name = "iconActualFormulario";
            this.iconActualFormulario.Size = new System.Drawing.Size(27, 27);
            this.iconActualFormulario.TabIndex = 2;
            this.iconActualFormulario.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.White;
            this.lblTituloFormulario.Location = new System.Drawing.Point(59, 21);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(42, 17);
            this.lblTituloFormulario.TabIndex = 1;
            this.lblTituloFormulario.Text = "Inicio";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.BtnPaquete);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.btnPaquetes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 4;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 320);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 60);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnPaquete
            // 
            this.BtnPaquete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPaquete.FlatAppearance.BorderSize = 0;
            this.BtnPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaquete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPaquete.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnPaquete.IconColor = System.Drawing.Color.White;
            this.BtnPaquete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPaquete.IconSize = 30;
            this.BtnPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPaquete.Location = new System.Drawing.Point(0, 260);
            this.BtnPaquete.Name = "BtnPaquete";
            this.BtnPaquete.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPaquete.Size = new System.Drawing.Size(220, 60);
            this.BtnPaquete.TabIndex = 8;
            this.BtnPaquete.Text = "Estantes";
            this.BtnPaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPaquete.UseVisualStyleBackColor = true;
            this.BtnPaquete.Click += new System.EventHandler(this.BtnPaquete_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnCategorias.IconColor = System.Drawing.Color.White;
            this.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategorias.IconSize = 30;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 200);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCategorias.Size = new System.Drawing.Size(220, 60);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click_1);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaquetes.FlatAppearance.BorderSize = 0;
            this.btnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquetes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaquetes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaquetes.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnPaquetes.IconColor = System.Drawing.Color.White;
            this.btnPaquetes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaquetes.IconSize = 30;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.Location = new System.Drawing.Point(0, 140);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaquetes.Size = new System.Drawing.Size(220, 60);
            this.btnPaquetes.TabIndex = 6;
            this.btnPaquetes.Text = "Paquetes";
            this.btnPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaquetes.UseVisualStyleBackColor = true;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logoInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // logoInicio
            // 
            this.logoInicio.Image = global::Sistema_De_Casillero.Properties.Resources.Logo;
            this.logoInicio.Location = new System.Drawing.Point(24, 21);
            this.logoInicio.Name = "logoInicio";
            this.logoInicio.Size = new System.Drawing.Size(150, 100);
            this.logoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoInicio.TabIndex = 0;
            this.logoInicio.TabStop = false;
            this.logoInicio.Click += new System.EventHandler(this.logoInicio_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 681);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualFormulario)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton BtnPaquete;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnPaquetes;
        private FontAwesome.Sharp.IconPictureBox iconActualFormulario;
    }
}

