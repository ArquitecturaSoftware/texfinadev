namespace TX_Almacen
{
    partial class FrmAutorizacion2OP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorizacion2OP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_idop = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAutorizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNAutorizar = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnu_item = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.ds_autorizado_vent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_autorizado_vent2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_aprobado_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_idop,
            this.toolStripSeparator6,
            this.btnVistaPrevia,
            this.toolStripSeparator5,
            this.btnSalir});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1014, 31);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 28);
            this.toolStripLabel1.Text = "Nº Orden de Pedido";
            // 
            // txt_idop
            // 
            this.txt_idop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_idop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idop.Name = "txt_idop";
            this.txt_idop.Size = new System.Drawing.Size(100, 31);
            this.txt_idop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idop_KeyPress);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistaPrevia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.Image")));
            this.btnVistaPrevia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(97, 28);
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
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltimer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpfechafin);
            this.groupBox1.Controls.Add(this.dtpfechaini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(882, 37);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 13);
            this.lbltimer.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Autorización de Orden de Pedido(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Estado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAutorizar,
            this.toolStripSeparator1,
            this.btnNAutorizar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 96);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1008, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 33;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizar.Image")));
            this.btnAutorizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutorizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(86, 28);
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.ToolTipText = "Autorizar Pres. Control + A";
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNAutorizar
            // 
            this.btnNAutorizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("btnNAutorizar.Image")));
            this.btnNAutorizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNAutorizar.Name = "btnNAutorizar";
            this.btnNAutorizar.Size = new System.Drawing.Size(102, 28);
            this.btnNAutorizar.Text = "No Autorizar";
            this.btnNAutorizar.Click += new System.EventHandler(this.btnNAutorizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(480, 46);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(147, 21);
            this.cbEstado.TabIndex = 37;
            this.cbEstado.TextChanged += new System.EventHandler(this.cbEstado_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(238, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechafin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(357, 46);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(106, 20);
            this.dtpfechafin.TabIndex = 29;
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechaini.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpfechaini.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(238, 46);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(106, 20);
            this.dtpfechaini.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Fin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha Inicio ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 349);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.ds_autorizado_vent,
            this.ds_autorizado_vent2,
            this.ds_aprobado_credito,
            this.estado,
            this.estado2,
            this.estado3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
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
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1008, 327);
            this.dgvDetalle.TabIndex = 3;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblnu_item});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1014, 22);
            this.statusStrip1.TabIndex = 14;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _estado
            // 
            this._estado.DataPropertyName = "_estado";
            this._estado.HeaderText = "";
            this._estado.Name = "_estado";
            this._estado.Width = 5;
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
            this.idreqsalida.HeaderText = "id Req";
            this.idreqsalida.Name = "idreqsalida";
            this.idreqsalida.Width = 55;
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
            this.ds_condpago.HeaderText = "Cond. Pago";
            this.ds_condpago.Name = "ds_condpago";
            this.ds_condpago.Visible = false;
            this.ds_condpago.Width = 75;
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
            // ds_direntrega
            // 
            this.ds_direntrega.DataPropertyName = "ds_direntrega";
            this.ds_direntrega.HeaderText = "Dirección de Entrega del Cliente";
            this.ds_direntrega.Name = "ds_direntrega";
            this.ds_direntrega.Width = 117;
            // 
            // fe_requer
            // 
            this.fe_requer.DataPropertyName = "fe_requer";
            this.fe_requer.HeaderText = "Fecha";
            this.fe_requer.Name = "fe_requer";
            this.fe_requer.Width = 52;
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
            this.ds_emitidopor.Visible = false;
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
            // ds_autorizado_vent
            // 
            this.ds_autorizado_vent.DataPropertyName = "ds_autorizado_vent";
            this.ds_autorizado_vent.HeaderText = "Autorizado por Ventas";
            this.ds_autorizado_vent.Name = "ds_autorizado_vent";
            this.ds_autorizado_vent.Width = 85;
            // 
            // ds_autorizado_vent2
            // 
            this.ds_autorizado_vent2.DataPropertyName = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.HeaderText = "Autorizado por Ventas2";
            this.ds_autorizado_vent2.Name = "ds_autorizado_vent2";
            this.ds_autorizado_vent2.Width = 85;
            // 
            // ds_aprobado_credito
            // 
            this.ds_aprobado_credito.DataPropertyName = "ds_aprobado_credito";
            this.ds_aprobado_credito.HeaderText = "Aprobado por Creditos";
            this.ds_aprobado_credito.Name = "ds_aprobado_credito";
            this.ds_aprobado_credito.Width = 81;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO1";
            this.estado.Name = "estado";
            this.estado.Width = 70;
            // 
            // estado2
            // 
            this.estado2.DataPropertyName = "estado2";
            this.estado2.HeaderText = "ESTADO2";
            this.estado2.Name = "estado2";
            this.estado2.Width = 70;
            // 
            // estado3
            // 
            this.estado3.DataPropertyName = "estado3";
            this.estado3.HeaderText = "ESTADO3";
            this.estado3.Name = "estado3";
            this.estado3.Width = 70;
            // 
            // FrmAutorizacion2OP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 538);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FrmAutorizacion2OP";
            this.Text = "FrmAutorizacion2OP";
            this.Load += new System.EventHandler(this.FrmAutorizacion2OP_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_idop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnVistaPrevia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAutorizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNAutorizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnu_item;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_autorizado_vent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_autorizado_vent2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_aprobado_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado3;
    }
}