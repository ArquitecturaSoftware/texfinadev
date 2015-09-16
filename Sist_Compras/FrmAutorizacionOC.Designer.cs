namespace Sist_Compras
{
    partial class FrmAutorizacionOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorizacionOC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnu_item = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idOC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAutorizar = new System.Windows.Forms.ToolStripButton();
            this.btnNAutorizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbplanta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutoriza = new System.Windows.Forms.CheckBox();
            this.chkPendiente = new System.Windows.Forms.CheckBox();
            this.chkNoAutorizar = new System.Windows.Forms.CheckBox();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this._estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ordenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_raznombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitidap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantaent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_ordenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizapor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mt_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_importa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_personal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_modcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_ordenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_local2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_aprueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha_inicio = new System.Windows.Forms.Label();
            this.lblfecha_fin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblnu_item});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txt_idOC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cbplanta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpfechafin);
            this.groupBox1.Controls.Add(this.dtpfechaini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(2, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_idOC
            // 
            this.txt_idOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_idOC.Location = new System.Drawing.Point(478, 59);
            this.txt_idOC.Name = "txt_idOC";
            this.txt_idOC.Size = new System.Drawing.Size(161, 20);
            this.txt_idOC.TabIndex = 23;
            this.txt_idOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idOC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nº OC";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAutorizar,
            this.btnNAutorizar,
            this.btnSalir});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(660, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(103, 93);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAutorizar
            // 
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
            // btnNAutorizar
            // 
            this.btnNAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("btnNAutorizar.Image")));
            this.btnNAutorizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNAutorizar.Name = "btnNAutorizar";
            this.btnNAutorizar.Size = new System.Drawing.Size(102, 28);
            this.btnNAutorizar.Text = "No Autorizar";
            this.btnNAutorizar.Click += new System.EventHandler(this.btnNAutorizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 28);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(141, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbplanta
            // 
            this.cbplanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbplanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbplanta.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbplanta.FormattingEnabled = true;
            this.cbplanta.Location = new System.Drawing.Point(478, 19);
            this.cbplanta.Name = "cbplanta";
            this.cbplanta.Size = new System.Drawing.Size(161, 21);
            this.cbplanta.TabIndex = 8;
            this.cbplanta.TextChanged += new System.EventHandler(this.cbplanta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Planta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.chkAutoriza);
            this.groupBox2.Controls.Add(this.chkPendiente);
            this.groupBox2.Controls.Add(this.chkNoAutorizar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver";
            // 
            // chkAutoriza
            // 
            this.chkAutoriza.AutoSize = true;
            this.chkAutoriza.Location = new System.Drawing.Point(35, 50);
            this.chkAutoriza.Name = "chkAutoriza";
            this.chkAutoriza.Size = new System.Drawing.Size(89, 17);
            this.chkAutoriza.TabIndex = 6;
            this.chkAutoriza.Text = "Autorizadas";
            this.chkAutoriza.UseVisualStyleBackColor = true;
            // 
            // chkPendiente
            // 
            this.chkPendiente.AutoSize = true;
            this.chkPendiente.Location = new System.Drawing.Point(35, 13);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(79, 17);
            this.chkPendiente.TabIndex = 4;
            this.chkPendiente.Text = "Pendiente";
            this.chkPendiente.UseVisualStyleBackColor = true;
            // 
            // chkNoAutorizar
            // 
            this.chkNoAutorizar.AutoSize = true;
            this.chkNoAutorizar.Location = new System.Drawing.Point(35, 31);
            this.chkNoAutorizar.Name = "chkNoAutorizar";
            this.chkNoAutorizar.Size = new System.Drawing.Size(92, 17);
            this.chkNoAutorizar.TabIndex = 5;
            this.chkNoAutorizar.Text = "No autorizar";
            this.chkNoAutorizar.UseVisualStyleBackColor = true;
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechafin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(141, 42);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(106, 20);
            this.dtpfechafin.TabIndex = 3;
            // 
            // dtpfechaini
            // 
            this.dtpfechaini.CalendarFont = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dtpfechaini.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpfechaini.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaini.Location = new System.Drawing.Point(141, 16);
            this.dtpfechaini.Name = "dtpfechaini";
            this.dtpfechaini.Size = new System.Drawing.Size(106, 20);
            this.dtpfechaini.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDetalle);
            this.groupBox3.Location = new System.Drawing.Point(2, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1148, 410);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToOrderColumns = true;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._estado,
            this.id_periodo,
            this.id_ordenco,
            this.origen,
            this.consoreq,
            this.cotiza,
            this.ds_condpago,
            this.ds_raznombre,
            this.priorid,
            this.plantapedido,
            this.emitidap,
            this.plantaent,
            this.fe_ordenco,
            this.modcomp,
            this.moneda,
            this.autorizapor,
            this.mt_total,
            this.id_importa,
            this.fe_entrega,
            this.id_local,
            this.id_personal,
            this.pedidop,
            this.id_personal2,
            this.id_modcomp,
            this.tipocomp,
            this.st_ordenco,
            this.id_local2,
            this.st_aprueba});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1142, 391);
            this.dgvDetalle.TabIndex = 2;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // _estado
            // 
            this._estado.DataPropertyName = "_estado";
            this._estado.HeaderText = "";
            this._estado.Name = "_estado";
            // 
            // id_periodo
            // 
            this.id_periodo.DataPropertyName = "id_periodo";
            this.id_periodo.HeaderText = "id_periodo";
            this.id_periodo.Name = "id_periodo";
            this.id_periodo.Visible = false;
            // 
            // id_ordenco
            // 
            this.id_ordenco.DataPropertyName = "id_ordenco";
            this.id_ordenco.HeaderText = "#O/C";
            this.id_ordenco.Name = "id_ordenco";
            this.id_ordenco.Width = 86;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen OC";
            this.origen.Name = "origen";
            this.origen.Visible = false;
            // 
            // consoreq
            // 
            this.consoreq.DataPropertyName = "consoreq";
            this.consoreq.HeaderText = "#Conso/Req";
            this.consoreq.Name = "consoreq";
            this.consoreq.Visible = false;
            // 
            // cotiza
            // 
            this.cotiza.DataPropertyName = "cotiza";
            this.cotiza.HeaderText = "#Cotizacion";
            this.cotiza.Name = "cotiza";
            this.cotiza.Visible = false;
            // 
            // ds_condpago
            // 
            this.ds_condpago.DataPropertyName = "ds_condpago";
            this.ds_condpago.HeaderText = "Condición";
            this.ds_condpago.Name = "ds_condpago";
            this.ds_condpago.Width = 86;
            // 
            // ds_raznombre
            // 
            this.ds_raznombre.DataPropertyName = "ds_raznombre";
            this.ds_raznombre.HeaderText = "Proveedor";
            this.ds_raznombre.Name = "ds_raznombre";
            this.ds_raznombre.Width = 87;
            // 
            // priorid
            // 
            this.priorid.DataPropertyName = "priorid";
            this.priorid.HeaderText = "Prioridad";
            this.priorid.Name = "priorid";
            this.priorid.Width = 86;
            // 
            // plantapedido
            // 
            this.plantapedido.DataPropertyName = "plantapedido";
            this.plantapedido.HeaderText = "Pedido En";
            this.plantapedido.Name = "plantapedido";
            this.plantapedido.Width = 87;
            // 
            // emitidap
            // 
            this.emitidap.DataPropertyName = "emitidap";
            this.emitidap.HeaderText = "Emitido Por";
            this.emitidap.Name = "emitidap";
            this.emitidap.Width = 87;
            // 
            // plantaent
            // 
            this.plantaent.DataPropertyName = "plantaent";
            this.plantaent.HeaderText = "Entrega En";
            this.plantaent.Name = "plantaent";
            this.plantaent.Width = 86;
            // 
            // fe_ordenco
            // 
            this.fe_ordenco.DataPropertyName = "fe_ordenco";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fe_ordenco.DefaultCellStyle = dataGridViewCellStyle2;
            this.fe_ordenco.HeaderText = "Fecha OC";
            this.fe_ordenco.Name = "fe_ordenco";
            this.fe_ordenco.Width = 87;
            // 
            // modcomp
            // 
            this.modcomp.DataPropertyName = "modcomp";
            this.modcomp.HeaderText = "Mod.Compra";
            this.modcomp.Name = "modcomp";
            this.modcomp.Width = 86;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "Moneda";
            this.moneda.Name = "moneda";
            this.moneda.Width = 87;
            // 
            // autorizapor
            // 
            this.autorizapor.DataPropertyName = "autorizapor";
            this.autorizapor.HeaderText = "Autorizado Por";
            this.autorizapor.Name = "autorizapor";
            this.autorizapor.Width = 87;
            // 
            // mt_total
            // 
            this.mt_total.DataPropertyName = "mt_total";
            this.mt_total.HeaderText = "Monto";
            this.mt_total.Name = "mt_total";
            this.mt_total.Width = 88;
            // 
            // id_importa
            // 
            this.id_importa.DataPropertyName = "id_importa";
            this.id_importa.HeaderText = "id_importa";
            this.id_importa.Name = "id_importa";
            this.id_importa.Visible = false;
            // 
            // fe_entrega
            // 
            this.fe_entrega.DataPropertyName = "fe_entrega";
            this.fe_entrega.HeaderText = "fe_entrega";
            this.fe_entrega.Name = "fe_entrega";
            this.fe_entrega.Visible = false;
            // 
            // id_local
            // 
            this.id_local.DataPropertyName = "id_local";
            this.id_local.HeaderText = "id_local";
            this.id_local.Name = "id_local";
            this.id_local.Visible = false;
            // 
            // id_personal
            // 
            this.id_personal.DataPropertyName = "id_personal";
            this.id_personal.HeaderText = "id_personal";
            this.id_personal.Name = "id_personal";
            this.id_personal.Visible = false;
            // 
            // pedidop
            // 
            this.pedidop.DataPropertyName = "pedidop";
            this.pedidop.HeaderText = "pedidop";
            this.pedidop.Name = "pedidop";
            this.pedidop.Visible = false;
            // 
            // id_personal2
            // 
            this.id_personal2.DataPropertyName = "id_personal2";
            this.id_personal2.HeaderText = "id_personal2";
            this.id_personal2.Name = "id_personal2";
            this.id_personal2.Visible = false;
            // 
            // id_modcomp
            // 
            this.id_modcomp.DataPropertyName = "id_modcomp";
            this.id_modcomp.HeaderText = "id_modcomp";
            this.id_modcomp.Name = "id_modcomp";
            this.id_modcomp.Visible = false;
            // 
            // tipocomp
            // 
            this.tipocomp.DataPropertyName = "tipocomp";
            this.tipocomp.HeaderText = "tipocomp";
            this.tipocomp.Name = "tipocomp";
            this.tipocomp.Visible = false;
            // 
            // st_ordenco
            // 
            this.st_ordenco.DataPropertyName = "st_ordenco";
            this.st_ordenco.HeaderText = "st_ordenco";
            this.st_ordenco.Name = "st_ordenco";
            this.st_ordenco.Visible = false;
            // 
            // id_local2
            // 
            this.id_local2.DataPropertyName = "id_local2";
            this.id_local2.HeaderText = "id_local2";
            this.id_local2.Name = "id_local2";
            this.id_local2.Visible = false;
            // 
            // st_aprueba
            // 
            this.st_aprueba.DataPropertyName = "st_aprueba";
            this.st_aprueba.HeaderText = "st_aprueba";
            this.st_aprueba.Name = "st_aprueba";
            this.st_aprueba.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autorización de Compra(s) desde el Día :";
            // 
            // lblFecha_inicio
            // 
            this.lblFecha_inicio.AutoSize = true;
            this.lblFecha_inicio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_inicio.Location = new System.Drawing.Point(295, 21);
            this.lblFecha_inicio.Name = "lblFecha_inicio";
            this.lblFecha_inicio.Size = new System.Drawing.Size(16, 13);
            this.lblFecha_inicio.TabIndex = 6;
            this.lblFecha_inicio.Text = "   ";
            // 
            // lblfecha_fin
            // 
            this.lblfecha_fin.AutoSize = true;
            this.lblfecha_fin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_fin.Location = new System.Drawing.Point(458, 21);
            this.lblfecha_fin.Name = "lblfecha_fin";
            this.lblfecha_fin.Size = new System.Drawing.Size(13, 13);
            this.lblfecha_fin.TabIndex = 7;
            this.lblfecha_fin.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasta el Día:";
            // 
            // FrmAutorizacionOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1150, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfecha_fin);
            this.Controls.Add(this.lblFecha_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAutorizacionOC";
            this.Text = "Autorización de Compra(s)";
            this.Load += new System.EventHandler(this.FrmAutorizacionOC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAutorizacionOC_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbplanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoriza;
        private System.Windows.Forms.CheckBox chkNoAutorizar;
        private System.Windows.Forms.CheckBox chkPendiente;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechaini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha_inicio;
        private System.Windows.Forms.Label lblfecha_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnu_item;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAutorizar;
        private System.Windows.Forms.ToolStripButton btnNAutorizar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txt_idOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ordenco;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_raznombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantapedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn emitidap;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_ordenco;
        private System.Windows.Forms.DataGridViewTextBoxColumn modcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_importa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_personal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_modcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_ordenco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_local2;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_aprueba;
    }
}