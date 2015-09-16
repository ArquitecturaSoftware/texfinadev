namespace TX_Sistema
{
    partial class MDI_Sistema
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolArchivo,
            this.operacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 1;
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
            // 
            // ventanaHorizontalToolStripMenuItem
            // 
            this.ventanaHorizontalToolStripMenuItem.Name = "ventanaHorizontalToolStripMenuItem";
            this.ventanaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ventanaHorizontalToolStripMenuItem.Text = "&Ventana Horizontal";
            // 
            // ToolSalir
            // 
            this.ToolSalir.Name = "ToolSalir";
            this.ToolSalir.Size = new System.Drawing.Size(165, 22);
            this.ToolSalir.Text = "&Salir";
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisoToolStripMenuItem});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.operacionToolStripMenuItem.Text = "&Operacion";
            // 
            // permisoToolStripMenuItem
            // 
            this.permisoToolStripMenuItem.Name = "permisoToolStripMenuItem";
            this.permisoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permisoToolStripMenuItem.Text = "&Permiso";
            this.permisoToolStripMenuItem.Click += new System.EventHandler(this.permisoToolStripMenuItem_Click);
            // 
            // MDI_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 525);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_Sistema";
            this.Text = "MDI_Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolArchivo;
        private System.Windows.Forms.ToolStripMenuItem ventanaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolSalir;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisoToolStripMenuItem;

    }
}