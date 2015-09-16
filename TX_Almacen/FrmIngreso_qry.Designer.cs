namespace TX_Almacen
{
    partial class FrmIngreso_qry
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgIngreso = new System.Windows.Forms.DataGridView();
            this.idIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_peso_desp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_densidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtdsproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nutf = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nuItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngreso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dgIngreso);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 280);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgIngreso
            // 
            this.dgIngreso.AllowUserToAddRows = false;
            this.dgIngreso.AllowUserToOrderColumns = true;
            this.dgIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgIngreso.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIngreso,
            this.nu_Item,
            this.nu_tf,
            this.nu_op,
            this.id_clipro,
            this.dsCliente,
            this.id_producto,
            this.dsProducto,
            this.id_color,
            this.dsColor,
            this.qt_rollo,
            this.qt_peso_desp,
            this.qt_ancho,
            this.qt_densidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgIngreso.Location = new System.Drawing.Point(3, 16);
            this.dgIngreso.Name = "dgIngreso";
            this.dgIngreso.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgIngreso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIngreso.Size = new System.Drawing.Size(986, 261);
            this.dgIngreso.TabIndex = 4;
            this.dgIngreso.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIngreso_CellEnter);
            this.dgIngreso.DoubleClick += new System.EventHandler(this.dgIngreso_DoubleClick);
            this.dgIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgIngreso_KeyDown);
            // 
            // idIngreso
            // 
            this.idIngreso.DataPropertyName = "idIngreso";
            this.idIngreso.HeaderText = "idIngreso";
            this.idIngreso.Name = "idIngreso";
            this.idIngreso.ReadOnly = true;
            this.idIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idIngreso.Width = 81;
            // 
            // nu_Item
            // 
            this.nu_Item.DataPropertyName = "nu_Item";
            this.nu_Item.HeaderText = "Item";
            this.nu_Item.Name = "nu_Item";
            this.nu_Item.ReadOnly = true;
            this.nu_Item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nu_Item.Width = 56;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.ReadOnly = true;
            this.nu_tf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nu_tf.Width = 44;
            // 
            // nu_op
            // 
            this.nu_op.DataPropertyName = "nu_op";
            this.nu_op.HeaderText = "Nº OP";
            this.nu_op.Name = "nu_op";
            this.nu_op.ReadOnly = true;
            this.nu_op.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nu_op.Width = 60;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "ID Cliente";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.ReadOnly = true;
            this.id_clipro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_clipro.Width = 80;
            // 
            // dsCliente
            // 
            this.dsCliente.DataPropertyName = "dsCliente";
            this.dsCliente.HeaderText = "Cliente";
            this.dsCliente.Name = "dsCliente";
            this.dsCliente.ReadOnly = true;
            this.dsCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dsCliente.Width = 72;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_producto.Width = 86;
            // 
            // dsProducto
            // 
            this.dsProducto.DataPropertyName = "dsProducto";
            this.dsProducto.HeaderText = "Producto";
            this.dsProducto.Name = "dsProducto";
            this.dsProducto.ReadOnly = true;
            this.dsProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dsProducto.Width = 78;
            // 
            // id_color
            // 
            this.id_color.DataPropertyName = "id_color";
            this.id_color.HeaderText = "ID Color";
            this.id_color.Name = "id_color";
            this.id_color.ReadOnly = true;
            this.id_color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_color.Width = 71;
            // 
            // dsColor
            // 
            this.dsColor.DataPropertyName = "dsColor";
            this.dsColor.HeaderText = "Color";
            this.dsColor.Name = "dsColor";
            this.dsColor.ReadOnly = true;
            this.dsColor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dsColor.Width = 62;
            // 
            // qt_rollo
            // 
            this.qt_rollo.DataPropertyName = "qt_rollo";
            this.qt_rollo.HeaderText = "Cant. Rollo";
            this.qt_rollo.Name = "qt_rollo";
            this.qt_rollo.ReadOnly = true;
            this.qt_rollo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qt_rollo.Width = 85;
            // 
            // qt_peso_desp
            // 
            this.qt_peso_desp.DataPropertyName = "qt_peso_desp";
            this.qt_peso_desp.HeaderText = "Peso Desp";
            this.qt_peso_desp.Name = "qt_peso_desp";
            this.qt_peso_desp.ReadOnly = true;
            this.qt_peso_desp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qt_peso_desp.Width = 78;
            // 
            // qt_ancho
            // 
            this.qt_ancho.DataPropertyName = "qt_ancho";
            this.qt_ancho.HeaderText = "Ancho";
            this.qt_ancho.Name = "qt_ancho";
            this.qt_ancho.ReadOnly = true;
            this.qt_ancho.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qt_ancho.Width = 65;
            // 
            // qt_densidad
            // 
            this.qt_densidad.DataPropertyName = "qt_densidad";
            this.qt_densidad.HeaderText = "Densidad";
            this.qt_densidad.Name = "qt_densidad";
            this.qt_densidad.ReadOnly = true;
            this.qt_densidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qt_densidad.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.91943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.08057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 523F));
            this.tableLayoutPanel1.Controls.Add(this.txtdsproducto, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nutf, 3, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtdsproducto
            // 
            this.txtdsproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtdsproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdsproducto.Location = new System.Drawing.Point(453, 3);
            this.txtdsproducto.Name = "txtdsproducto";
            this.txtdsproducto.Size = new System.Drawing.Size(257, 20);
            this.txtdsproducto.TabIndex = 5;
            this.txtdsproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdsproducto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Ingreso: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(101, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº tf  :";
            // 
            // txt_nutf
            // 
            this.txt_nutf.AcceptsReturn = true;
            this.txt_nutf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_nutf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nutf.Location = new System.Drawing.Point(260, 3);
            this.txt_nutf.Name = "txt_nutf";
            this.txt_nutf.Size = new System.Drawing.Size(96, 20);
            this.txt_nutf.TabIndex = 1;
            this.txt_nutf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nutf_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nuItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 12;
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
            // FrmIngreso_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmIngreso_qry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIngreso_qry_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIngreso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdsproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nutf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_peso_desp;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_densidad;
    }
}