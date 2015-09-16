namespace TX_Almacen
{
    partial class FrmLiberarOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiberarOP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLiberarOC = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechaini = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtnu_op = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnu_item = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.chkActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreqsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_requer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_emitidopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tipsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_autorizado_vent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_autorizado_vent2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_aprobado_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLiberarOC,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 31);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLiberarOC
            // 
            this.btnLiberarOC.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberarOC.Image")));
            this.btnLiberarOC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLiberarOC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLiberarOC.Name = "btnLiberarOC";
            this.btnLiberarOC.Size = new System.Drawing.Size(154, 28);
            this.btnLiberarOC.Text = "Liberar Orden  de Pedido";
            this.btnLiberarOC.Click += new System.EventHandler(this.btnLiberarOC_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtfechafin);
            this.groupBox1.Controls.Add(this.txtfechaini);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtnu_op);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtfechafin
            // 
            this.txtfechafin.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechafin.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.txtfechafin.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(101, 41);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(119, 20);
            this.txtfechafin.TabIndex = 35;
            // 
            // txtfechaini
            // 
            this.txtfechaini.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaini.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.txtfechaini.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.txtfechaini.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechaini.Location = new System.Drawing.Point(101, 15);
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.Size = new System.Drawing.Size(119, 20);
            this.txtfechaini.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(421, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtnu_op
            // 
            this.txtnu_op.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnu_op.Location = new System.Drawing.Point(285, 14);
            this.txtnu_op.Name = "txtnu_op";
            this.txtnu_op.Size = new System.Drawing.Size(100, 20);
            this.txtnu_op.TabIndex = 5;
            this.txtnu_op.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnu_op_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº OP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblnu_item});
            this.statusStrip1.Location = new System.Drawing.Point(0, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1061, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Nº Items";
            // 
            // lblnu_item
            // 
            this.lblnu_item.Name = "lblnu_item";
            this.lblnu_item.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetalle);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 691);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 13;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToOrderColumns = true;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkActivo,
            this.idPeriodo,
            this.idreqsalida,
            this.id_condpago,
            this.ds_condpago,
            this.id_clipro,
            this.ds_cliente,
            this.fe_requer,
            this.hora,
            this.idpersonal1,
            this.ds_emitidopor,
            this.id_local,
            this.ds_local,
            this.id_vendedor,
            this.ds_vendedor,
            this.id_tipsalida,
            this.ds_tipsalida,
            this.estado_,
            this.ds_autorizado_vent,
            this.ds_autorizado_vent2,
            this.ds_aprobado_credito});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(1061, 601);
            this.dgvDetalle.TabIndex = 20;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // chkActivo
            // 
            this.chkActivo.HeaderText = "";
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Width = 5;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.Width = 60;
            // 
            // idreqsalida
            // 
            this.idreqsalida.DataPropertyName = "idreqsalida";
            this.idreqsalida.HeaderText = "ID Req";
            this.idreqsalida.Name = "idreqsalida";
            this.idreqsalida.Width = 53;
            // 
            // id_condpago
            // 
            this.id_condpago.DataPropertyName = "id_condpago";
            this.id_condpago.HeaderText = "id_condpago";
            this.id_condpago.Name = "id_condpago";
            this.id_condpago.Visible = false;
            this.id_condpago.Width = 81;
            // 
            // ds_condpago
            // 
            this.ds_condpago.DataPropertyName = "ds_condpago";
            this.ds_condpago.HeaderText = "Cond.Pago";
            this.ds_condpago.Name = "ds_condpago";
            this.ds_condpago.Width = 73;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "id_clipro";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.Visible = false;
            this.id_clipro.Width = 66;
            // 
            // ds_cliente
            // 
            this.ds_cliente.DataPropertyName = "ds_cliente";
            this.ds_cliente.HeaderText = "Cliente";
            this.ds_cliente.Name = "ds_cliente";
            this.ds_cliente.Width = 58;
            // 
            // fe_requer
            // 
            this.fe_requer.DataPropertyName = "fe_requer";
            this.fe_requer.HeaderText = "Fecha OP";
            this.fe_requer.Name = "fe_requer";
            this.fe_requer.Width = 61;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.Width = 50;
            // 
            // idpersonal1
            // 
            this.idpersonal1.DataPropertyName = "idpersonal1";
            this.idpersonal1.HeaderText = "idpersonal1";
            this.idpersonal1.Name = "idpersonal1";
            this.idpersonal1.Visible = false;
            this.idpersonal1.Width = 77;
            // 
            // ds_emitidopor
            // 
            this.ds_emitidopor.DataPropertyName = "ds_emitidopor";
            this.ds_emitidopor.HeaderText = "Emitido Por";
            this.ds_emitidopor.Name = "ds_emitidopor";
            this.ds_emitidopor.Width = 72;
            // 
            // id_local
            // 
            this.id_local.DataPropertyName = "id_local";
            this.id_local.HeaderText = "id_local";
            this.id_local.Name = "id_local";
            this.id_local.Visible = false;
            this.id_local.Width = 62;
            // 
            // ds_local
            // 
            this.ds_local.DataPropertyName = "ds_local";
            this.ds_local.HeaderText = "Local";
            this.ds_local.Name = "ds_local";
            this.ds_local.Width = 52;
            // 
            // id_vendedor
            // 
            this.id_vendedor.DataPropertyName = "id_vendedor";
            this.id_vendedor.HeaderText = "id_vendedor";
            this.id_vendedor.Name = "id_vendedor";
            this.id_vendedor.Visible = false;
            this.id_vendedor.Width = 78;
            // 
            // ds_vendedor
            // 
            this.ds_vendedor.DataPropertyName = "ds_vendedor";
            this.ds_vendedor.HeaderText = "Vendedor";
            this.ds_vendedor.Name = "ds_vendedor";
            this.ds_vendedor.Width = 66;
            // 
            // id_tipsalida
            // 
            this.id_tipsalida.DataPropertyName = "id_tipsalida";
            this.id_tipsalida.HeaderText = "id_tipsalida";
            this.id_tipsalida.Name = "id_tipsalida";
            this.id_tipsalida.Visible = false;
            this.id_tipsalida.Width = 78;
            // 
            // ds_tipsalida
            // 
            this.ds_tipsalida.DataPropertyName = "ds_tipsalida";
            this.ds_tipsalida.HeaderText = "Tip. Salida";
            this.ds_tipsalida.Name = "ds_tipsalida";
            this.ds_tipsalida.Width = 68;
            // 
            // estado_
            // 
            this.estado_.DataPropertyName = "estado";
            this.estado_.HeaderText = "Estado";
            this.estado_.Name = "estado_";
            this.estado_.Width = 57;
            // 
            // ds_autorizado_vent
            // 
            this.ds_autorizado_vent.DataPropertyName = "ds_autorizado_vent";
            this.ds_autorizado_vent.HeaderText = "Autorizado por ventas";
            this.ds_autorizado_vent.Name = "ds_autorizado_vent";
            this.ds_autorizado_vent.Width = 85;
            // 
            // ds_autorizado_vent2
            // 
            this.ds_autorizado_vent2.DataPropertyName = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.HeaderText = "Aprobado por Ventas2";
            this.ds_autorizado_vent2.Name = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.Width = 81;
            // 
            // ds_aprobado_credito
            // 
            this.ds_aprobado_credito.DataPropertyName = "ds_aprobado_credito";
            this.ds_aprobado_credito.HeaderText = "Aprobado por creditos";
            this.ds_aprobado_credito.Name = "ds_aprobado_credito";
            this.ds_aprobado_credito.Width = 81;
            // 
            // FrmLiberarOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 744);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmLiberarOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar Orden de Pedido";
            this.Load += new System.EventHandler(this.FrmLiberarOP_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLiberarOC;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtnu_op;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnu_item;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreqsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_requer;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_emitidopor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tipsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_autorizado_vent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_autorizado_vent2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_aprobado_credito;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechaini;
    }
}