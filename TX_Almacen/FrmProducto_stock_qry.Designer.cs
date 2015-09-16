namespace TX_Almacen
{
    partial class FrmProducto_stock_qry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto_stock_qry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chk_cliente = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txtds_color = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nuItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dgProducto);
            this.groupBox2.Location = new System.Drawing.Point(2, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 275);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dgProducto
            // 
            this.dgProducto.AllowUserToAddRows = false;
            this.dgProducto.AllowUserToOrderColumns = true;
            this.dgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.dgProducto.Location = new System.Drawing.Point(3, 16);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducto.Size = new System.Drawing.Size(986, 256);
            this.dgProducto.TabIndex = 4;
            this.dgProducto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIngreso_CellEnter);
            this.dgProducto.DoubleClick += new System.EventHandler(this.dgIngreso_DoubleClick);
            this.dgProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProducto_KeyDown);
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.ReadOnly = true;
            this.idPeriodo.Width = 72;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "id_clipro";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.Visible = false;
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
            this.qt_rollo_actual.Width = 85;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.chk_cliente);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(909, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 27);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chk_cliente
            // 
            this.chk_cliente.AutoSize = true;
            this.chk_cliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_cliente.Location = new System.Drawing.Point(830, 19);
            this.chk_cliente.Name = "chk_cliente";
            this.chk_cliente.Size = new System.Drawing.Size(62, 18);
            this.chk_cliente.TabIndex = 1;
            this.chk_cliente.Text = "Texfina";
            this.chk_cliente.UseVisualStyleBackColor = true;
            this.chk_cliente.CheckedChanged += new System.EventHandler(this.chk_cliente_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.92405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_producto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtds_color, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_vendedor, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vendedor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color :";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Location = new System.Drawing.Point(65, 3);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(104, 20);
            this.txt_cliente.TabIndex = 2;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto  :";
            // 
            // txt_producto
            // 
            this.txt_producto.AcceptsReturn = true;
            this.txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_producto.Location = new System.Drawing.Point(262, 3);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(160, 20);
            this.txt_producto.TabIndex = 1;
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // txtds_color
            // 
            this.txtds_color.AcceptsReturn = true;
            this.txtds_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtds_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtds_color.Location = new System.Drawing.Point(485, 3);
            this.txtds_color.Name = "txtds_color";
            this.txtds_color.Size = new System.Drawing.Size(170, 20);
            this.txtds_color.TabIndex = 7;
            this.txtds_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtds_color_KeyPress);
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendedor.Location = new System.Drawing.Point(734, 3);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(75, 20);
            this.txt_vendedor.TabIndex = 5;
            this.txt_vendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendedor_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nuItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "Item";
            // 
            // nuItem
            // 
            this.nuItem.Name = "nuItem";
            this.nuItem.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmProducto_stock_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 354);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProducto_stock_qry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Stock";
            this.Load += new System.EventHandler(this.FrmProducto_stock_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProducto_stock_qry_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nuItem;
        private System.Windows.Forms.CheckBox chk_cliente;
        private System.Windows.Forms.TextBox txtds_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
    }
}