namespace TX_Almacen
{
    partial class FrmListadoPrecio_qry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPrecio_qry));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nuItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idListPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_dens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_rend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuItem_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tipvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCondPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_mnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nutf = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
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
            this.statusStrip1.TabIndex = 17;
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
            this.groupBox2.Controls.Add(this.dgProducto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 276);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
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
            this.idListPrecio,
            this.id_producto,
            this.ds_producto,
            this.nu_tf,
            this.qt_ancho,
            this.qt_dens,
            this.qt_rend,
            this.nuItem_,
            this.ds_tipvent,
            this.dsColor,
            this.idtipventa,
            this.dsCondPago,
            this.dsTipoDocumento,
            this.precio_mnt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducto.Location = new System.Drawing.Point(3, 16);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducto.Size = new System.Drawing.Size(986, 257);
            this.dgProducto.TabIndex = 4;
            this.dgProducto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducto_CellEnter);
            this.dgProducto.DoubleClick += new System.EventHandler(this.dgProducto_DoubleClick);
            this.dgProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProducto_KeyDown);
            // 
            // idListPrecio
            // 
            this.idListPrecio.DataPropertyName = "idListPrecio";
            this.idListPrecio.Frozen = true;
            this.idListPrecio.HeaderText = "idListPrecio";
            this.idListPrecio.Name = "idListPrecio";
            this.idListPrecio.ReadOnly = true;
            this.idListPrecio.Visible = false;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.Frozen = true;
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            // 
            // ds_producto
            // 
            this.ds_producto.DataPropertyName = "ds_producto";
            this.ds_producto.Frozen = true;
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.ReadOnly = true;
            this.ds_producto.Width = 78;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "Nº TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.ReadOnly = true;
            this.nu_tf.Width = 59;
            // 
            // qt_ancho
            // 
            this.qt_ancho.DataPropertyName = "qt_ancho";
            this.qt_ancho.HeaderText = "Ancho";
            this.qt_ancho.Name = "qt_ancho";
            this.qt_ancho.ReadOnly = true;
            this.qt_ancho.Width = 65;
            // 
            // qt_dens
            // 
            this.qt_dens.DataPropertyName = "qt_dens";
            this.qt_dens.HeaderText = "Densidad";
            this.qt_dens.Name = "qt_dens";
            this.qt_dens.ReadOnly = true;
            this.qt_dens.Width = 80;
            // 
            // qt_rend
            // 
            this.qt_rend.DataPropertyName = "qt_rend";
            this.qt_rend.HeaderText = "Rendimiento";
            this.qt_rend.Name = "qt_rend";
            this.qt_rend.ReadOnly = true;
            // 
            // nuItem_
            // 
            this.nuItem_.DataPropertyName = "nuItem";
            this.nuItem_.HeaderText = "Item";
            this.nuItem_.Name = "nuItem_";
            this.nuItem_.ReadOnly = true;
            this.nuItem_.Width = 56;
            // 
            // ds_tipvent
            // 
            this.ds_tipvent.DataPropertyName = "ds_tipvent";
            this.ds_tipvent.HeaderText = "Venta";
            this.ds_tipvent.Name = "ds_tipvent";
            this.ds_tipvent.ReadOnly = true;
            this.ds_tipvent.Width = 62;
            // 
            // dsColor
            // 
            this.dsColor.DataPropertyName = "dsColor";
            this.dsColor.HeaderText = "Color";
            this.dsColor.Name = "dsColor";
            this.dsColor.ReadOnly = true;
            this.dsColor.Width = 62;
            // 
            // idtipventa
            // 
            this.idtipventa.DataPropertyName = "idtipventa";
            this.idtipventa.HeaderText = "idtipventa";
            this.idtipventa.Name = "idtipventa";
            this.idtipventa.ReadOnly = true;
            this.idtipventa.Visible = false;
            // 
            // dsCondPago
            // 
            this.dsCondPago.DataPropertyName = "dsCondPago";
            this.dsCondPago.HeaderText = "Cond.Pago";
            this.dsCondPago.Name = "dsCondPago";
            this.dsCondPago.ReadOnly = true;
            this.dsCondPago.Width = 88;
            // 
            // dsTipoDocumento
            // 
            this.dsTipoDocumento.DataPropertyName = "dsTipoDocumento";
            this.dsTipoDocumento.HeaderText = "Tip.Doc";
            this.dsTipoDocumento.Name = "dsTipoDocumento";
            this.dsTipoDocumento.ReadOnly = true;
            this.dsTipoDocumento.Width = 70;
            // 
            // precio_mnt
            // 
            this.precio_mnt.DataPropertyName = "precio_mnt";
            this.precio_mnt.HeaderText = "Precio";
            this.precio_mnt.Name = "precio_mnt";
            this.precio_mnt.ReadOnly = true;
            this.precio_mnt.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 49);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.12613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.87387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_producto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nutf, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto  :";
            // 
            // txt_producto
            // 
            this.txt_producto.AcceptsReturn = true;
            this.txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_producto.Location = new System.Drawing.Point(118, 3);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(296, 20);
            this.txt_producto.TabIndex = 1;
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº TF :";
            // 
            // txt_nutf
            // 
            this.txt_nutf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txt_nutf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nutf.Location = new System.Drawing.Point(504, 3);
            this.txt_nutf.Name = "txt_nutf";
            this.txt_nutf.Size = new System.Drawing.Size(95, 20);
            this.txt_nutf.TabIndex = 5;
            this.txt_nutf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nutf_KeyPress);
            // 
            // FrmListadoPrecio_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(992, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmListadoPrecio_qry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de precio";
            this.Load += new System.EventHandler(this.FrmListadoPrecio_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListadoPrecio_qry_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
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
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nutf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_dens;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_rend;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuItem_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tipvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCondPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_mnt;
    }
}