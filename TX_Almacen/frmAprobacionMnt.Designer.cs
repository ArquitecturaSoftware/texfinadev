namespace TX_Almacen
{
    partial class frmAprobacionMnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAprobacionMnt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRow_total = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_idop = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lbltimer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAprobar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNAprobar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this._estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreqsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_direntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fe_autorizado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_autorizado_vent2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_autorizado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_aprobado_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRow_total});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1240, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Nro Registros";
            // 
            // lblRow_total
            // 
            this.lblRow_total.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow_total.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRow_total.Name = "lblRow_total";
            this.lblRow_total.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_idop,
            this.toolStripSeparator4,
            this.btnVistaPrevia,
            this.toolStripSeparator5,
            this.btnSalir});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1240, 31);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 28);
            this.toolStripLabel1.Text = "Nº Orden de pedido";
            // 
            // txt_idop
            // 
            this.txt_idop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_idop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idop.Name = "txt_idop";
            this.txt_idop.Size = new System.Drawing.Size(100, 31);
            this.txt_idop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idOC_KeyPress);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistaPrevia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.Image")));
            this.btnVistaPrevia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(100, 28);
            this.btnVistaPrevia.Text = "Vista previa";
            this.btnVistaPrevia.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.lbltimer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpfechafin);
            this.groupBox1.Controls.Add(this.dtpfechaini);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 114);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(596, 24);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(94, 39);
            this.btnExportar.TabIndex = 41;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(883, 36);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 13);
            this.lbltimer.TabIndex = 40;
            this.lbltimer.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Estado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAprobar,
            this.toolStripSeparator2,
            this.btnNAprobar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 80);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1234, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 35;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobar.Image")));
            this.btnAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprobar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(77, 28);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNAprobar
            // 
            this.btnNAprobar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNAprobar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnNAprobar.Image")));
            this.btnNAprobar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNAprobar.Name = "btnNAprobar";
            this.btnNAprobar.Size = new System.Drawing.Size(93, 28);
            this.btnNAprobar.Text = "No Aprobar";
            this.btnNAprobar.Click += new System.EventHandler(this.btnNAprobar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(491, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 40);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechafin.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(193, 38);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(106, 20);
            this.dtpfechafin.TabIndex = 33;
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechaini.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpfechaini.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(78, 38);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(106, 20);
            this.dtpfechaini.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha Inicio ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha Fin ";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(326, 37);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(147, 21);
            this.cbEstado.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 368);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToOrderColumns = true;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._estado,
            this.idPeriodo,
            this.idreqsalida,
            this.id_condpago,
            this.ds_condpago,
            this.id_clipro,
            this.ds_cliente,
            this.ds_direntrega,
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
            this.fe_autorizado1,
            this.ds_autorizado_vent2,
            this.fe_autorizado2,
            this.ds_aprobado_credito,
            this.fe_aprobado});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1234, 349);
            this.dgvDetalle.TabIndex = 19;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            this.dgvDetalle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalle_CellFormatting);
            // 
            // _estado
            // 
            this._estado.HeaderText = "";
            this._estado.Name = "_estado";
            this._estado.Width = 5;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.Width = 61;
            // 
            // idreqsalida
            // 
            this.idreqsalida.DataPropertyName = "idreqsalida";
            this.idreqsalida.HeaderText = "ID Req";
            this.idreqsalida.Name = "idreqsalida";
            this.idreqsalida.Width = 58;
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
            this.ds_condpago.Width = 74;
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
            this.ds_cliente.Width = 59;
            // 
            // ds_direntrega
            // 
            this.ds_direntrega.DataPropertyName = "ds_direntrega";
            this.ds_direntrega.HeaderText = "Dirección de Entrega del Cliente";
            this.ds_direntrega.Name = "ds_direntrega";
            this.ds_direntrega.Width = 158;
            // 
            // fe_requer
            // 
            this.fe_requer.DataPropertyName = "fe_requer";
            this.fe_requer.HeaderText = "Fecha OP";
            this.fe_requer.Name = "fe_requer";
            this.fe_requer.Width = 67;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.Width = 51;
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
            this.ds_emitidopor.Width = 79;
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
            this.ds_local.Width = 53;
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
            this.ds_vendedor.Width = 67;
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
            this.ds_tipsalida.Width = 74;
            // 
            // estado_
            // 
            this.estado_.DataPropertyName = "estado";
            this.estado_.HeaderText = "Estado";
            this.estado_.Name = "estado_";
            this.estado_.Width = 58;
            // 
            // ds_autorizado_vent
            // 
            this.ds_autorizado_vent.DataPropertyName = "ds_autorizado_vent";
            this.ds_autorizado_vent.HeaderText = "Autorizado por ventas";
            this.ds_autorizado_vent.Name = "ds_autorizado_vent";
            this.ds_autorizado_vent.Width = 118;
            // 
            // fe_autorizado1
            // 
            this.fe_autorizado1.DataPropertyName = "fe_autorizado";
            this.fe_autorizado1.HeaderText = "Autorizado1 Hora";
            this.fe_autorizado1.Name = "fe_autorizado1";
            this.fe_autorizado1.Width = 103;
            // 
            // ds_autorizado_vent2
            // 
            this.ds_autorizado_vent2.DataPropertyName = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.HeaderText = "Aprobado por Ventas2";
            this.ds_autorizado_vent2.Name = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.Width = 120;
            // 
            // fe_autorizado2
            // 
            this.fe_autorizado2.DataPropertyName = "fe_autorizado2";
            this.fe_autorizado2.HeaderText = "Autorizado2 Hora";
            this.fe_autorizado2.Name = "fe_autorizado2";
            this.fe_autorizado2.Width = 103;
            // 
            // ds_aprobado_credito
            // 
            this.ds_aprobado_credito.DataPropertyName = "ds_aprobado_credito";
            this.ds_aprobado_credito.HeaderText = "Aprobado por creditos";
            this.ds_aprobado_credito.Name = "ds_aprobado_credito";
            this.ds_aprobado_credito.Width = 121;
            // 
            // fe_aprobado
            // 
            this.fe_aprobado.DataPropertyName = "fe_aprobado";
            this.fe_aprobado.HeaderText = "Hora aprobado";
            this.fe_aprobado.Name = "fe_aprobado";
            this.fe_aprobado.Width = 92;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAprobacionMnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1240, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAprobacionMnt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobación de Orden de Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAprobacionOC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAprobacionOC_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRow_total;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_idop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnVistaPrevia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAprobar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNAprobar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreqsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_direntrega;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_autorizado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_autorizado_vent2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_autorizado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_aprobado_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_aprobado;
    }
}