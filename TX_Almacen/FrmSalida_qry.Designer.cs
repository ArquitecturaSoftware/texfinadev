namespace TX_Almacen
{
    partial class FrmSalida_qry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalida_qry));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nuItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgSalida = new System.Windows.Forms.DataGridView();
            this.idSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreqsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mt_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtdsproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nutf = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalida)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nuItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 15;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dgSalida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 276);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dgSalida
            // 
            this.dgSalida.AllowUserToAddRows = false;
            this.dgSalida.AllowUserToOrderColumns = true;
            this.dgSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSalida.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalida,
            this.idreqsalida,
            this.nu_op,
            this.nu_tf,
            this.id_clipro,
            this.dsCliente,
            this.id_producto,
            this.ds_producto,
            this.id_color,
            this.ds_color,
            this.qt_rollo,
            this.qt_peso,
            this.mt_precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSalida.Location = new System.Drawing.Point(3, 16);
            this.dgSalida.Name = "dgSalida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalida.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgSalida.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalida.Size = new System.Drawing.Size(986, 257);
            this.dgSalida.TabIndex = 5;
            this.dgSalida.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalida_CellEnter);
            this.dgSalida.DoubleClick += new System.EventHandler(this.dgSalida_DoubleClick);
            this.dgSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSalida_KeyDown);
            // 
            // idSalida
            // 
            this.idSalida.DataPropertyName = "idSalida";
            this.idSalida.HeaderText = "Id Salida";
            this.idSalida.Name = "idSalida";
            this.idSalida.ReadOnly = true;
            this.idSalida.Width = 78;
            // 
            // idreqsalida
            // 
            this.idreqsalida.DataPropertyName = "idreqsalida";
            this.idreqsalida.HeaderText = "Id Req";
            this.idreqsalida.Name = "idreqsalida";
            this.idreqsalida.ReadOnly = true;
            this.idreqsalida.Width = 65;
            // 
            // nu_op
            // 
            this.nu_op.DataPropertyName = "nu_op";
            this.nu_op.HeaderText = "OP";
            this.nu_op.Name = "nu_op";
            this.nu_op.ReadOnly = true;
            this.nu_op.Width = 49;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.ReadOnly = true;
            this.nu_tf.Width = 44;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "id_clipro";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.ReadOnly = true;
            this.id_clipro.Visible = false;
            // 
            // dsCliente
            // 
            this.dsCliente.DataPropertyName = "dsCliente";
            this.dsCliente.HeaderText = "Cliente";
            this.dsCliente.Name = "dsCliente";
            this.dsCliente.ReadOnly = true;
            this.dsCliente.Width = 72;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "Id Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 91;
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
            this.id_color.HeaderText = "id_color";
            this.id_color.Name = "id_color";
            this.id_color.ReadOnly = true;
            this.id_color.Visible = false;
            // 
            // ds_color
            // 
            this.ds_color.DataPropertyName = "ds_color";
            this.ds_color.HeaderText = "Color";
            this.ds_color.Name = "ds_color";
            this.ds_color.ReadOnly = true;
            this.ds_color.Width = 62;
            // 
            // qt_rollo
            // 
            this.qt_rollo.DataPropertyName = "qt_rollo";
            this.qt_rollo.HeaderText = "Qt Rollo";
            this.qt_rollo.Name = "qt_rollo";
            this.qt_rollo.ReadOnly = true;
            this.qt_rollo.Width = 77;
            // 
            // qt_peso
            // 
            this.qt_peso.DataPropertyName = "qt_peso";
            this.qt_peso.HeaderText = "Qt Peso";
            this.qt_peso.Name = "qt_peso";
            this.qt_peso.ReadOnly = true;
            this.qt_peso.Width = 73;
            // 
            // mt_precio
            // 
            this.mt_precio.DataPropertyName = "mt_precio";
            this.mt_precio.HeaderText = "Precio";
            this.mt_precio.Name = "mt_precio";
            this.mt_precio.ReadOnly = true;
            this.mt_precio.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.87156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.12844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.txtdsproducto, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nutf, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtdsproducto
            // 
            this.txtdsproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtdsproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdsproducto.Location = new System.Drawing.Point(467, 3);
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
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Salida: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(100, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº tf  :";
            // 
            // txt_nutf
            // 
            this.txt_nutf.AcceptsReturn = true;
            this.txt_nutf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_nutf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nutf.Location = new System.Drawing.Point(263, 3);
            this.txt_nutf.Name = "txt_nutf";
            this.txt_nutf.Size = new System.Drawing.Size(96, 20);
            this.txt_nutf.TabIndex = 1;
            this.txt_nutf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nutf_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(846, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 31);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmSalida_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSalida_qry";
            this.ShowIcon = false;
            this.Text = "Consulta de Salidas";
            this.Load += new System.EventHandler(this.FrmSalida_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSalida_qry_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtdsproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nutf;
        private System.Windows.Forms.DataGridView dgSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreqsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn mt_precio;
        private System.Windows.Forms.Button btnBuscar;
    }
}