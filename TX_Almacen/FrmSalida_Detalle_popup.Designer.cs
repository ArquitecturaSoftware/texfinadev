namespace TX_Almacen
{
    partial class FrmSalida_Detalle_popup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalida_Detalle_popup));
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.nu_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_mercado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_tela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nu_rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mt_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevoRow = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblnumrollo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblitem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtnu_rollo_pend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnurollo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnuitem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkigv_pop = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar_pop = new System.Windows.Forms.Button();
            this.btnAceptar_pop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtds_vendedor = new System.Windows.Forms.TextBox();
            this.txtid_vendedor = new System.Windows.Forms.TextBox();
            this.lblcolor = new System.Windows.Forms.TextBox();
            this.txtds_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.TextBox();
            this.txtid_cliente = new System.Windows.Forms.TextBox();
            this.txtpesoDesp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidcolor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnurollo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToAddRows = false;
            this.dgvSalida.AllowUserToOrderColumns = true;
            this.dgvSalida.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nu_item,
            this.CodBar,
            this.nu_tf,
            this.nu_op,
            this.id_mercado,
            this.id_tipo,
            this.tipo_tela,
            this.id_producto,
            this.ds_producto,
            this.id_color,
            this.ds_color,
            this._nu_rollo,
            this.peso_actual,
            this.qt_peso,
            this.mt_precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalida.Location = new System.Drawing.Point(6, 12);
            this.dgvSalida.Name = "dgvSalida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalida.Size = new System.Drawing.Size(630, 307);
            this.dgvSalida.TabIndex = 1;
            // 
            // nu_item
            // 
            this.nu_item.DataPropertyName = "nu_item";
            this.nu_item.HeaderText = "Item";
            this.nu_item.Name = "nu_item";
            this.nu_item.ReadOnly = true;
            // 
            // CodBar
            // 
            this.CodBar.DataPropertyName = "CodBar";
            this.CodBar.HeaderText = "Codigo Barra";
            this.CodBar.Name = "CodBar";
            this.CodBar.ReadOnly = true;
            this.CodBar.Width = 200;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "Nº TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.ReadOnly = true;
            // 
            // nu_op
            // 
            this.nu_op.DataPropertyName = "nu_op";
            this.nu_op.HeaderText = "Nª OP";
            this.nu_op.Name = "nu_op";
            this.nu_op.ReadOnly = true;
            // 
            // id_mercado
            // 
            this.id_mercado.HeaderText = "id_mercado";
            this.id_mercado.Name = "id_mercado";
            this.id_mercado.Visible = false;
            // 
            // id_tipo
            // 
            this.id_tipo.HeaderText = "id_tipo";
            this.id_tipo.Name = "id_tipo";
            this.id_tipo.Visible = false;
            // 
            // tipo_tela
            // 
            this.tipo_tela.HeaderText = "tipo_tela";
            this.tipo_tela.Name = "tipo_tela";
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Id Producto";
            this.id_producto.Name = "id_producto";
            // 
            // ds_producto
            // 
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.Width = 200;
            // 
            // id_color
            // 
            this.id_color.HeaderText = "idColor";
            this.id_color.Name = "id_color";
            this.id_color.Visible = false;
            // 
            // ds_color
            // 
            this.ds_color.HeaderText = "Color";
            this.ds_color.Name = "ds_color";
            this.ds_color.Width = 150;
            // 
            // _nu_rollo
            // 
            this._nu_rollo.HeaderText = "Nº Rollo";
            this._nu_rollo.Name = "_nu_rollo";
            // 
            // peso_actual
            // 
            this.peso_actual.DataPropertyName = "qt_peso";
            this.peso_actual.HeaderText = "peso_actual";
            this.peso_actual.Name = "peso_actual";
            // 
            // qt_peso
            // 
            this.qt_peso.HeaderText = "Peso";
            this.qt_peso.Name = "qt_peso";
            // 
            // mt_precio
            // 
            this.mt_precio.HeaderText = "Precio";
            this.mt_precio.Name = "mt_precio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.statusStrip1);
            this.groupBox2.Controls.Add(this.dgvSalida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 347);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoRow});
            this.toolStrip1.Location = new System.Drawing.Point(639, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(29, 306);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevoRow
            // 
            this.btnNuevoRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevoRow.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoRow.Image")));
            this.btnNuevoRow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevoRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoRow.Name = "btnNuevoRow";
            this.btnNuevoRow.Size = new System.Drawing.Size(26, 28);
            this.btnNuevoRow.Text = "Nuevo";
            this.btnNuevoRow.Click += new System.EventHandler(this.btnNuevoRow_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblnumrollo,
            this.toolStripStatusLabel1,
            this.lblitem});
            this.statusStrip1.Location = new System.Drawing.Point(3, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblnumrollo
            // 
            this.lblnumrollo.Name = "lblnumrollo";
            this.lblnumrollo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "# Item";
            // 
            // lblitem
            // 
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(13, 17);
            this.lblitem.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtnu_rollo_pend, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtnurollo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtprecio, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtnuitem, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 3, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 193);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 88);
            this.tableLayoutPanel2.TabIndex = 60;
            // 
            // txtnu_rollo_pend
            // 
            this.txtnu_rollo_pend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnu_rollo_pend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnu_rollo_pend.ForeColor = System.Drawing.Color.Red;
            this.txtnu_rollo_pend.Location = new System.Drawing.Point(116, 32);
            this.txtnu_rollo_pend.Name = "txtnu_rollo_pend";
            this.txtnu_rollo_pend.ReadOnly = true;
            this.txtnu_rollo_pend.Size = new System.Drawing.Size(90, 20);
            this.txtnu_rollo_pend.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nº Rollo :";
            // 
            // txtnurollo
            // 
            this.txtnurollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnurollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnurollo.ForeColor = System.Drawing.Color.Red;
            this.txtnurollo.Location = new System.Drawing.Point(116, 3);
            this.txtnurollo.Name = "txtnurollo";
            this.txtnurollo.ReadOnly = true;
            this.txtnurollo.Size = new System.Drawing.Size(90, 23);
            this.txtnurollo.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Precio :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "# Rollo Pendiente :";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio.ForeColor = System.Drawing.Color.Red;
            this.txtprecio.Location = new System.Drawing.Point(116, 58);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(90, 20);
            this.txtprecio.TabIndex = 90;
            // 
            // txtnuitem
            // 
            this.txtnuitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnuitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnuitem.Location = new System.Drawing.Point(212, 58);
            this.txtnuitem.Name = "txtnuitem";
            this.txtnuitem.ReadOnly = true;
            this.txtnuitem.Size = new System.Drawing.Size(162, 20);
            this.txtnuitem.TabIndex = 96;
            this.txtnuitem.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkigv_pop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 23);
            this.tableLayoutPanel1.TabIndex = 99;
            // 
            // chkigv_pop
            // 
            this.chkigv_pop.AutoSize = true;
            this.chkigv_pop.Checked = true;
            this.chkigv_pop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkigv_pop.Location = new System.Drawing.Point(70, 3);
            this.chkigv_pop.Name = "chkigv_pop";
            this.chkigv_pop.Size = new System.Drawing.Size(15, 14);
            this.chkigv_pop.TabIndex = 63;
            this.chkigv_pop.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 14);
            this.label11.TabIndex = 62;
            this.label11.Text = "Afecto.IGV";
            // 
            // btnCancelar_pop
            // 
            this.btnCancelar_pop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar_pop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_pop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar_pop.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar_pop.Image")));
            this.btnCancelar_pop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar_pop.Location = new System.Drawing.Point(231, 299);
            this.btnCancelar_pop.Name = "btnCancelar_pop";
            this.btnCancelar_pop.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar_pop.TabIndex = 64;
            this.btnCancelar_pop.Text = "Terminar";
            this.btnCancelar_pop.UseVisualStyleBackColor = false;
            this.btnCancelar_pop.Click += new System.EventHandler(this.btnCancelar_pop_Click);
            // 
            // btnAceptar_pop
            // 
            this.btnAceptar_pop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar_pop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar_pop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar_pop.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar_pop.Image")));
            this.btnAceptar_pop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar_pop.Location = new System.Drawing.Point(114, 299);
            this.btnAceptar_pop.Name = "btnAceptar_pop";
            this.btnAceptar_pop.Size = new System.Drawing.Size(105, 23);
            this.btnAceptar_pop.TabIndex = 63;
            this.btnAceptar_pop.Text = "Aceptar";
            this.btnAceptar_pop.UseVisualStyleBackColor = false;
            this.btnAceptar_pop.Click += new System.EventHandler(this.btnAceptar_pop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.btnCancelar_pop);
            this.groupBox1.Controls.Add(this.btnAceptar_pop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 347);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85714F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14286F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel3.Controls.Add(this.txtds_vendedor, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtid_vendedor, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblcolor, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtds_cliente, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblproducto, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtid_cliente, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtpesoDesp, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtstock, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtidcolor, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtidproducto, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 158);
            this.tableLayoutPanel3.TabIndex = 65;
            // 
            // txtds_vendedor
            // 
            this.txtds_vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtds_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtds_vendedor.Location = new System.Drawing.Point(205, 133);
            this.txtds_vendedor.Name = "txtds_vendedor";
            this.txtds_vendedor.ReadOnly = true;
            this.txtds_vendedor.Size = new System.Drawing.Size(259, 20);
            this.txtds_vendedor.TabIndex = 84;
            // 
            // txtid_vendedor
            // 
            this.txtid_vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtid_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid_vendedor.Location = new System.Drawing.Point(110, 133);
            this.txtid_vendedor.Name = "txtid_vendedor";
            this.txtid_vendedor.ReadOnly = true;
            this.txtid_vendedor.Size = new System.Drawing.Size(89, 20);
            this.txtid_vendedor.TabIndex = 83;
            // 
            // lblcolor
            // 
            this.lblcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcolor.Location = new System.Drawing.Point(205, 55);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.ReadOnly = true;
            this.lblcolor.Size = new System.Drawing.Size(259, 20);
            this.lblcolor.TabIndex = 75;
            // 
            // txtds_cliente
            // 
            this.txtds_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtds_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtds_cliente.Location = new System.Drawing.Point(205, 29);
            this.txtds_cliente.Name = "txtds_cliente";
            this.txtds_cliente.ReadOnly = true;
            this.txtds_cliente.Size = new System.Drawing.Size(259, 20);
            this.txtds_cliente.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Producto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 78;
            this.label3.Text = "Cliente";
            // 
            // lblproducto
            // 
            this.lblproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblproducto.Location = new System.Drawing.Point(205, 3);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.ReadOnly = true;
            this.lblproducto.Size = new System.Drawing.Size(259, 20);
            this.lblproducto.TabIndex = 76;
            // 
            // txtid_cliente
            // 
            this.txtid_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtid_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid_cliente.Location = new System.Drawing.Point(110, 29);
            this.txtid_cliente.Name = "txtid_cliente";
            this.txtid_cliente.ReadOnly = true;
            this.txtid_cliente.Size = new System.Drawing.Size(89, 20);
            this.txtid_cliente.TabIndex = 79;
            // 
            // txtpesoDesp
            // 
            this.txtpesoDesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtpesoDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesoDesp.Location = new System.Drawing.Point(110, 107);
            this.txtpesoDesp.Name = "txtpesoDesp";
            this.txtpesoDesp.ReadOnly = true;
            this.txtpesoDesp.Size = new System.Drawing.Size(89, 20);
            this.txtpesoDesp.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Color :";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Location = new System.Drawing.Point(110, 81);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(89, 20);
            this.txtstock.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "Vendedor";
            // 
            // txtidcolor
            // 
            this.txtidcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidcolor.Location = new System.Drawing.Point(110, 55);
            this.txtidcolor.Name = "txtidcolor";
            this.txtidcolor.ReadOnly = true;
            this.txtidcolor.Size = new System.Drawing.Size(89, 20);
            this.txtidcolor.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Peso Desp :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock Rollo :";
            // 
            // txtidproducto
            // 
            this.txtidproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproducto.Location = new System.Drawing.Point(110, 3);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.ReadOnly = true;
            this.txtidproducto.Size = new System.Drawing.Size(89, 20);
            this.txtidproducto.TabIndex = 17;
            // 
            // FrmSalida_Detalle_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSalida_Detalle_popup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Salida";
            this.Load += new System.EventHandler(this.FrmSalida_Detalle_popup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSalida_Detalle_popup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnurollo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblnumrollo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnuitem;
        private System.Windows.Forms.NumericUpDown txtnurollo;
        private System.Windows.Forms.Button btnCancelar_pop;
        private System.Windows.Forms.Button btnAceptar_pop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid_vendedor;
        private System.Windows.Forms.TextBox txtds_vendedor;
        private System.Windows.Forms.TextBox txtid_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtds_cliente;
        private System.Windows.Forms.TextBox txtpesoDesp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidcolor;
        private System.Windows.Forms.TextBox lblcolor;
        private System.Windows.Forms.TextBox lblproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnNuevoRow;
        private System.Windows.Forms.TextBox txtnu_rollo_pend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblitem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkigv_pop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_tela;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nu_rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn mt_precio;
    }
}