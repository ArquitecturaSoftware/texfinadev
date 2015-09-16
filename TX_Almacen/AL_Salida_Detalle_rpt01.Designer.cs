namespace TX_Almacen
{
    partial class Frm_Salida_Detalle_rpt01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Salida_Detalle_rpt01));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.txtid_vendedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbTiptela = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.cbMercado = new System.Windows.Forms.ComboBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtidColor = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1223, 25);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(58, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(69, 22);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.lblvendedor);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnVendedor);
            this.splitContainer1.Panel1.Controls.Add(this.txtid_vendedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtFechaIni);
            this.splitContainer1.Panel1.Controls.Add(this.dtFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.cbTipo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.txtidCliente);
            this.splitContainer1.Panel1.Controls.Add(this.btnCliente);
            this.splitContainer1.Panel1.Controls.Add(this.lblCliente);
            this.splitContainer1.Panel1.Controls.Add(this.cbTiptela);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.txtidProducto);
            this.splitContainer1.Panel1.Controls.Add(this.cbMercado);
            this.splitContainer1.Panel1.Controls.Add(this.btnProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.lblProducto);
            this.splitContainer1.Panel1.Controls.Add(this.lblColor);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.btnColor);
            this.splitContainer1.Panel1.Controls.Add(this.txtidColor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crystalReportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1223, 728);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 75;
            // 
            // lblvendedor
            // 
            this.lblvendedor.AutoSize = true;
            this.lblvendedor.Location = new System.Drawing.Point(347, 129);
            this.lblvendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(0, 13);
            this.lblvendedor.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 87;
            this.label5.Text = "Vendedor:";
            // 
            // btnVendedor
            // 
            this.btnVendedor.BackColor = System.Drawing.Color.White;
            this.btnVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnVendedor.Image")));
            this.btnVendedor.Location = new System.Drawing.Point(308, 126);
            this.btnVendedor.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(29, 21);
            this.btnVendedor.TabIndex = 89;
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // txtid_vendedor
            // 
            this.txtid_vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtid_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid_vendedor.Location = new System.Drawing.Point(206, 126);
            this.txtid_vendedor.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtid_vendedor.Name = "txtid_vendedor";
            this.txtid_vendedor.Size = new System.Drawing.Size(94, 20);
            this.txtid_vendedor.TabIndex = 88;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(773, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 30);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Fin";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(69, 34);
            this.dtFechaIni.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(140, 20);
            this.dtFechaIni.TabIndex = 2;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(245, 34);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(140, 20);
            this.dtFechaFin.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(520, 100);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(169, 21);
            this.cbTipo.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "Tipo:";
            // 
            // txtidCliente
            // 
            this.txtidCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidCliente.Location = new System.Drawing.Point(206, 58);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(94, 20);
            this.txtidCliente.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(309, 58);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(29, 21);
            this.btnCliente.TabIndex = 68;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(347, 61);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 69;
            // 
            // cbTiptela
            // 
            this.cbTiptela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbTiptela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiptela.FormattingEnabled = true;
            this.cbTiptela.Location = new System.Drawing.Point(521, 72);
            this.cbTiptela.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbTiptela.Name = "cbTiptela";
            this.cbTiptela.Size = new System.Drawing.Size(168, 21);
            this.cbTiptela.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 80;
            this.label11.Text = "Tipo Tela:";
            // 
            // txtidProducto
            // 
            this.txtidProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidProducto.Location = new System.Drawing.Point(206, 79);
            this.txtidProducto.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(94, 20);
            this.txtidProducto.TabIndex = 71;
            // 
            // cbMercado
            // 
            this.cbMercado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbMercado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMercado.FormattingEnabled = true;
            this.cbMercado.Location = new System.Drawing.Point(521, 49);
            this.cbMercado.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbMercado.Name = "cbMercado";
            this.cbMercado.Size = new System.Drawing.Size(168, 21);
            this.cbMercado.TabIndex = 79;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.White;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.Location = new System.Drawing.Point(309, 79);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(29, 21);
            this.btnProducto.TabIndex = 72;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Mercado:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(347, 82);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 13);
            this.lblProducto.TabIndex = 73;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(347, 105);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 13);
            this.lblColor.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 74;
            this.label9.Text = "Color:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(309, 102);
            this.btnColor.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(29, 21);
            this.btnColor.TabIndex = 76;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtidColor
            // 
            this.txtidColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidColor.Location = new System.Drawing.Point(206, 102);
            this.txtidColor.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtidColor.Name = "txtidColor";
            this.txtidColor.Size = new System.Drawing.Size(94, 20);
            this.txtidColor.TabIndex = 75;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1223, 589);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 234;
            // 
            // Frm_Salida_Detalle_rpt01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1223, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Salida_Detalle_rpt01";
            this.Text = "AL_Salida_Detalle_rpt01";
            this.Load += new System.EventHandler(this.AL_Salida_Detalle_rpt01_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbTiptela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.ComboBox cbMercado;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtidColor;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.TextBox txtid_vendedor;
    }
}