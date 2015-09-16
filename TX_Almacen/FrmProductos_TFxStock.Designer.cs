namespace TX_Almacen
{
    partial class FrmProductos_TFxStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos_TFxStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnu_tf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtds_vendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkvendedor = new System.Windows.Forms.CheckBox();
            this.txtds_color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_raznombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_rollo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_peso_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRazsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgProducto);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 715);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtnu_tf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.txtds_vendedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.chkvendedor);
            this.groupBox1.Controls.Add(this.txtds_color);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_producto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1322, 78);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtnu_tf
            // 
            this.txtnu_tf.AcceptsReturn = true;
            this.txtnu_tf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnu_tf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnu_tf.Location = new System.Drawing.Point(247, 50);
            this.txtnu_tf.Name = "txtnu_tf";
            this.txtnu_tf.Size = new System.Drawing.Size(104, 20);
            this.txtnu_tf.TabIndex = 14;
            this.txtnu_tf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnu_tf_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nº TF :";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(956, 18);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(83, 27);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtds_vendedor
            // 
            this.txtds_vendedor.AcceptsReturn = true;
            this.txtds_vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtds_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtds_vendedor.Location = new System.Drawing.Point(591, 52);
            this.txtds_vendedor.Name = "txtds_vendedor";
            this.txtds_vendedor.Size = new System.Drawing.Size(157, 20);
            this.txtds_vendedor.TabIndex = 12;
            this.txtds_vendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtds_vendedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vendedor :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(876, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 27);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkvendedor
            // 
            this.chkvendedor.AutoSize = true;
            this.chkvendedor.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkvendedor.Location = new System.Drawing.Point(754, 24);
            this.chkvendedor.Name = "chkvendedor";
            this.chkvendedor.Size = new System.Drawing.Size(116, 17);
            this.chkvendedor.TabIndex = 10;
            this.chkvendedor.Text = "Vendedor Texfina";
            this.chkvendedor.UseVisualStyleBackColor = true;
            this.chkvendedor.CheckedChanged += new System.EventHandler(this.chkvendedor_CheckedChanged);
            // 
            // txtds_color
            // 
            this.txtds_color.AcceptsReturn = true;
            this.txtds_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtds_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtds_color.Location = new System.Drawing.Point(591, 22);
            this.txtds_color.Name = "txtds_color";
            this.txtds_color.Size = new System.Drawing.Size(157, 20);
            this.txtds_color.TabIndex = 7;
            this.txtds_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtds_color_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente :";
            // 
            // txt_producto
            // 
            this.txt_producto.AcceptsReturn = true;
            this.txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_producto.Location = new System.Drawing.Point(247, 24);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(273, 20);
            this.txt_producto.TabIndex = 1;
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto  :";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Location = new System.Drawing.Point(57, 24);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(123, 20);
            this.txt_cliente.TabIndex = 2;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // dgProducto
            // 
            this.dgProducto.AllowUserToAddRows = false;
            this.dgProducto.AllowUserToOrderColumns = true;
            this.dgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProducto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeriodo,
            this.nu_tf,
            this.id_clipro,
            this.ds_raznombre,
            this.id_producto,
            this.ds_producto,
            this.id_color,
            this.ds_color,
            this.qt_rollo_actual,
            this.reservado,
            this.qt_peso_actual,
            this.id_vendedor,
            this.dsRazsocial,
            this.st_estado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducto.Location = new System.Drawing.Point(0, 0);
            this.dgProducto.Name = "dgProducto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProducto.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgProducto.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducto.Size = new System.Drawing.Size(1322, 631);
            this.dgProducto.TabIndex = 5;
            this.dgProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducto_CellContentClick);
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Width = 72;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.Width = 44;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "id_clipro";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.Visible = false;
            this.id_clipro.Width = 78;
            // 
            // ds_raznombre
            // 
            this.ds_raznombre.DataPropertyName = "ds_raznombre";
            this.ds_raznombre.HeaderText = "Cliente";
            this.ds_raznombre.Name = "ds_raznombre";
            this.ds_raznombre.ReadOnly = true;
            this.ds_raznombre.Width = 72;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "idProducto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 88;
            // 
            // ds_producto
            // 
            this.ds_producto.DataPropertyName = "ds_producto";
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.ReadOnly = true;
            this.ds_producto.Width = 78;
            // 
            // id_color
            // 
            this.id_color.DataPropertyName = "id_color";
            this.id_color.HeaderText = "IdColor";
            this.id_color.Name = "id_color";
            this.id_color.ReadOnly = true;
            this.id_color.Width = 72;
            // 
            // ds_color
            // 
            this.ds_color.DataPropertyName = "ds_color";
            this.ds_color.HeaderText = "Color";
            this.ds_color.Name = "ds_color";
            this.ds_color.ReadOnly = true;
            this.ds_color.Width = 62;
            // 
            // qt_rollo_actual
            // 
            this.qt_rollo_actual.DataPropertyName = "qt_rollo_actual";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.qt_rollo_actual.DefaultCellStyle = dataGridViewCellStyle2;
            this.qt_rollo_actual.HeaderText = "Cant. Rollo";
            this.qt_rollo_actual.Name = "qt_rollo_actual";
            this.qt_rollo_actual.ReadOnly = true;
            this.qt_rollo_actual.Width = 92;
            // 
            // reservado
            // 
            this.reservado.DataPropertyName = "reservado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.reservado.DefaultCellStyle = dataGridViewCellStyle3;
            this.reservado.HeaderText = "Reservado";
            this.reservado.Name = "reservado";
            this.reservado.Width = 85;
            // 
            // qt_peso_actual
            // 
            this.qt_peso_actual.DataPropertyName = "qt_peso_actual";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.qt_peso_actual.DefaultCellStyle = dataGridViewCellStyle4;
            this.qt_peso_actual.HeaderText = "Peso";
            this.qt_peso_actual.Name = "qt_peso_actual";
            this.qt_peso_actual.ReadOnly = true;
            this.qt_peso_actual.Width = 56;
            // 
            // id_vendedor
            // 
            this.id_vendedor.DataPropertyName = "id_vendedor";
            this.id_vendedor.HeaderText = "id_vendedor";
            this.id_vendedor.Name = "id_vendedor";
            this.id_vendedor.ReadOnly = true;
            this.id_vendedor.Visible = false;
            this.id_vendedor.Width = 95;
            // 
            // dsRazsocial
            // 
            this.dsRazsocial.DataPropertyName = "dsRazsocial";
            this.dsRazsocial.HeaderText = "Vendedor";
            this.dsRazsocial.Name = "dsRazsocial";
            this.dsRazsocial.ReadOnly = true;
            this.dsRazsocial.Width = 81;
            // 
            // st_estado
            // 
            this.st_estado.DataPropertyName = "st_estado";
            this.st_estado.HeaderText = "Estado";
            this.st_estado.Name = "st_estado";
            this.st_estado.ReadOnly = true;
            this.st_estado.Width = 65;
            // 
            // FrmProductos_TFxStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1322, 715);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmProductos_TFxStock";
            this.Text = "Productos Stock por Partida";
            this.Load += new System.EventHandler(this.FrmProductos_TFxStock_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtds_vendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkvendedor;
        private System.Windows.Forms.TextBox txtds_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_raznombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_rollo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_peso_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsRazsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_estado;
        private System.Windows.Forms.TextBox txtnu_tf;
        private System.Windows.Forms.Label label5;
    }
}