namespace TX_Terjeduria
{
    partial class FrmMdi_TJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdi_TJ));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolproducto = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTela = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolactualizarTela = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolmuestrasEtiqueta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTela = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizarTela = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEtiquetaMuestras = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomape = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblperiodo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolArchivo,
            this.ToolMantenimiento,
            this.ToolOperaciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolArchivo
            // 
            this.ToolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaVerticalToolStripMenuItem,
            this.ventanaHorizontalToolStripMenuItem,
            this.ToolSalir});
            this.ToolArchivo.Name = "ToolArchivo";
            this.ToolArchivo.Size = new System.Drawing.Size(55, 20);
            this.ToolArchivo.Text = "&Archivo";
            // 
            // ventanaVerticalToolStripMenuItem
            // 
            this.ventanaVerticalToolStripMenuItem.Name = "ventanaVerticalToolStripMenuItem";
            this.ventanaVerticalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ventanaVerticalToolStripMenuItem.Text = "&Ventana vertical";
            this.ventanaVerticalToolStripMenuItem.Click += new System.EventHandler(this.ventanaVerticalToolStripMenuItem_Click);
            // 
            // ventanaHorizontalToolStripMenuItem
            // 
            this.ventanaHorizontalToolStripMenuItem.Name = "ventanaHorizontalToolStripMenuItem";
            this.ventanaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ventanaHorizontalToolStripMenuItem.Text = "&Ventana Horizontal";
            this.ventanaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ventanaHorizontalToolStripMenuItem_Click);
            // 
            // ToolSalir
            // 
            this.ToolSalir.Name = "ToolSalir";
            this.ToolSalir.Size = new System.Drawing.Size(165, 22);
            this.ToolSalir.Text = "&Salir";
            this.ToolSalir.Click += new System.EventHandler(this.ToolSalir_Click);
            // 
            // ToolMantenimiento
            // 
            this.ToolMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolproducto});
            this.ToolMantenimiento.Name = "ToolMantenimiento";
            this.ToolMantenimiento.Size = new System.Drawing.Size(89, 20);
            this.ToolMantenimiento.Text = "&Mantenimiento";
            // 
            // Toolproducto
            // 
            this.Toolproducto.Image = ((System.Drawing.Image)(resources.GetObject("Toolproducto.Image")));
            this.Toolproducto.Name = "Toolproducto";
            this.Toolproducto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.Toolproducto.Size = new System.Drawing.Size(151, 22);
            this.Toolproducto.Text = "&Producto";
            this.Toolproducto.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Toolproducto.Click += new System.EventHandler(this.Toolproducto_Click);
            // 
            // ToolOperaciones
            // 
            this.ToolOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTela,
            this.ToolactualizarTela,
            this.ToolmuestrasEtiqueta});
            this.ToolOperaciones.Name = "ToolOperaciones";
            this.ToolOperaciones.Size = new System.Drawing.Size(79, 20);
            this.ToolOperaciones.Text = "&Operaciones";
            // 
            // ToolTela
            // 
            this.ToolTela.Image = ((System.Drawing.Image)(resources.GetObject("ToolTela.Image")));
            this.ToolTela.Name = "ToolTela";
            this.ToolTela.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.ToolTela.Size = new System.Drawing.Size(182, 22);
            this.ToolTela.Text = "&Tela";
            this.ToolTela.Click += new System.EventHandler(this.ToolTela_Click);
            // 
            // ToolactualizarTela
            // 
            this.ToolactualizarTela.Image = ((System.Drawing.Image)(resources.GetObject("ToolactualizarTela.Image")));
            this.ToolactualizarTela.Name = "ToolactualizarTela";
            this.ToolactualizarTela.Size = new System.Drawing.Size(182, 22);
            this.ToolactualizarTela.Text = "&Actualizar Datos - Tela";
            this.ToolactualizarTela.Click += new System.EventHandler(this.ToolactualizarTela_Click);
            // 
            // ToolmuestrasEtiqueta
            // 
            this.ToolmuestrasEtiqueta.Image = ((System.Drawing.Image)(resources.GetObject("ToolmuestrasEtiqueta.Image")));
            this.ToolmuestrasEtiqueta.Name = "ToolmuestrasEtiqueta";
            this.ToolmuestrasEtiqueta.Size = new System.Drawing.Size(182, 22);
            this.ToolmuestrasEtiqueta.Text = "Muestras Etiqueta";
            this.ToolmuestrasEtiqueta.Click += new System.EventHandler(this.ToolmuestrasEtiqueta_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTela,
            this.toolStripSeparator3,
            this.btnActualizarTela,
            this.toolStripSeparator1,
            this.btnEtiquetaMuestras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 44);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTela
            // 
            this.btnTela.Image = ((System.Drawing.Image)(resources.GetObject("btnTela.Image")));
            this.btnTela.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTela.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTela.Name = "btnTela";
            this.btnTela.Size = new System.Drawing.Size(31, 41);
            this.btnTela.Text = "&Tela";
            this.btnTela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTela.Click += new System.EventHandler(this.btnTela_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // btnActualizarTela
            // 
            this.btnActualizarTela.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarTela.Image")));
            this.btnActualizarTela.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnActualizarTela.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizarTela.Name = "btnActualizarTela";
            this.btnActualizarTela.Size = new System.Drawing.Size(119, 41);
            this.btnActualizarTela.Text = "&Actualizar Datos - Tela";
            this.btnActualizarTela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizarTela.Click += new System.EventHandler(this.btnActualizarTela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btnEtiquetaMuestras
            // 
            this.btnEtiquetaMuestras.Image = ((System.Drawing.Image)(resources.GetObject("btnEtiquetaMuestras.Image")));
            this.btnEtiquetaMuestras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEtiquetaMuestras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEtiquetaMuestras.Name = "btnEtiquetaMuestras";
            this.btnEtiquetaMuestras.Size = new System.Drawing.Size(105, 41);
            this.btnEtiquetaMuestras.Text = "Etiqueta - Muestras";
            this.btnEtiquetaMuestras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEtiquetaMuestras.Click += new System.EventHandler(this.btnEtiquetaMuestras_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblusuario,
            this.toolStripStatusLabel2,
            this.lblNomape,
            this.toolStripStatusLabel3,
            this.lblperiodo,
            this.toolStripStatusLabel4,
            this.lblEmpresa,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.lblfecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(16, 17);
            this.lblusuario.Text = "   ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel2.Text = "Nombre: ";
            // 
            // lblNomape
            // 
            this.lblNomape.BackColor = System.Drawing.Color.Transparent;
            this.lblNomape.Name = "lblNomape";
            this.lblNomape.Size = new System.Drawing.Size(16, 17);
            this.lblNomape.Text = "   ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel3.Text = "Periodo :";
            // 
            // lblperiodo
            // 
            this.lblperiodo.BackColor = System.Drawing.Color.Transparent;
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(22, 17);
            this.lblperiodo.Text = "     ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel4.Text = "Empresa :";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(16, 17);
            this.lblEmpresa.Text = "   ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel6.Text = "                                    ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel5.Text = "Fecha";
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(19, 17);
            this.lblfecha.Text = "    ";
            // 
            // FrmMdi_TJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 549);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMdi_TJ";
            this.Text = "Modulo de Tejeduria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMdi_TJ_FormClosing);
            this.Load += new System.EventHandler(this.FrmMdi_TJ_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolArchivo;
        private System.Windows.Forms.ToolStripMenuItem ventanaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolSalir;
        private System.Windows.Forms.ToolStripMenuItem ToolMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem ToolOperaciones;
        private System.Windows.Forms.ToolStripMenuItem ToolTela;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblusuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblNomape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblperiodo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblfecha;
        private System.Windows.Forms.ToolStripMenuItem Toolproducto;
        private System.Windows.Forms.ToolStripMenuItem ToolactualizarTela;
        private System.Windows.Forms.ToolStripButton btnActualizarTela;
        private System.Windows.Forms.ToolStripMenuItem ToolmuestrasEtiqueta;
        private System.Windows.Forms.ToolStripButton btnEtiquetaMuestras;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}