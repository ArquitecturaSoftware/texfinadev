namespace Sist_Compras
{
    partial class FrmOrdenCompra_qry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenCompra_qry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgOrdenCompra = new System.Windows.Forms.DataGridView();
            this.id_ordenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_ordenco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_raznombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.txtfechaIni = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtcodOc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrazsoc = new System.Windows.Forms.TextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgOrdenCompra);
            this.groupBox2.Location = new System.Drawing.Point(3, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 309);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgOrdenCompra
            // 
            this.dgOrdenCompra.AllowUserToAddRows = false;
            this.dgOrdenCompra.AllowUserToOrderColumns = true;
            this.dgOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOrdenCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgOrdenCompra.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ordenco,
            this.fe_ordenco,
            this.ds_raznombre,
            this.id_op,
            this.Autorizado,
            this.Aprobado,
            this.ds_producto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrdenCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrdenCompra.Location = new System.Drawing.Point(3, 16);
            this.dgOrdenCompra.Name = "dgOrdenCompra";
            this.dgOrdenCompra.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgOrdenCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrdenCompra.Size = new System.Drawing.Size(955, 290);
            this.dgOrdenCompra.TabIndex = 5;
            this.dgOrdenCompra.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdenCompra_CellEnter);
            this.dgOrdenCompra.DoubleClick += new System.EventHandler(this.dgOrdenCompra_DoubleClick);
            this.dgOrdenCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgOrdenCompra_KeyDown);
            // 
            // id_ordenco
            // 
            this.id_ordenco.DataPropertyName = "id_ordenco";
            this.id_ordenco.Frozen = true;
            this.id_ordenco.HeaderText = "NºOC";
            this.id_ordenco.Name = "id_ordenco";
            this.id_ordenco.ReadOnly = true;
            this.id_ordenco.Width = 56;
            // 
            // fe_ordenco
            // 
            this.fe_ordenco.DataPropertyName = "fe_ordenco";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fe_ordenco.DefaultCellStyle = dataGridViewCellStyle2;
            this.fe_ordenco.Frozen = true;
            this.fe_ordenco.HeaderText = "fecha OC";
            this.fe_ordenco.Name = "fe_ordenco";
            this.fe_ordenco.ReadOnly = true;
            this.fe_ordenco.Width = 73;
            // 
            // ds_raznombre
            // 
            this.ds_raznombre.DataPropertyName = "ds_raznombre";
            this.ds_raznombre.Frozen = true;
            this.ds_raznombre.HeaderText = "Razon Social";
            this.ds_raznombre.Name = "ds_raznombre";
            this.ds_raznombre.Width = 92;
            // 
            // id_op
            // 
            this.id_op.DataPropertyName = "id_op";
            this.id_op.Frozen = true;
            this.id_op.HeaderText = "OP";
            this.id_op.Name = "id_op";
            this.id_op.ReadOnly = true;
            this.id_op.Width = 45;
            // 
            // Autorizado
            // 
            this.Autorizado.DataPropertyName = "Autorizado";
            this.Autorizado.Frozen = true;
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.Name = "Autorizado";
            this.Autorizado.ReadOnly = true;
            this.Autorizado.Width = 83;
            // 
            // Aprobado
            // 
            this.Aprobado.DataPropertyName = "Aprobado";
            this.Aprobado.Frozen = true;
            this.Aprobado.HeaderText = "Aprobado";
            this.Aprobado.Name = "Aprobado";
            this.Aprobado.ReadOnly = true;
            this.Aprobado.Width = 78;
            // 
            // ds_producto
            // 
            this.ds_producto.DataPropertyName = "ds_producto";
            this.ds_producto.Frozen = true;
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.ReadOnly = true;
            this.ds_producto.Width = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtfechaIni);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtcodOc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtrazsoc);
            this.groupBox1.Controls.Add(this.cbLocal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFechaFin.Location = new System.Drawing.Point(80, 45);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(70, 20);
            this.txtFechaFin.TabIndex = 20;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            this.txtFechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaFin_KeyPress);
            // 
            // txtfechaIni
            // 
            this.txtfechaIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtfechaIni.Location = new System.Drawing.Point(80, 19);
            this.txtfechaIni.Mask = "00/00/0000";
            this.txtfechaIni.Name = "txtfechaIni";
            this.txtfechaIni.Size = new System.Drawing.Size(70, 20);
            this.txtfechaIni.TabIndex = 19;
            this.txtfechaIni.ValidatingType = typeof(System.DateTime);
            this.txtfechaIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfechaIni_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(838, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtcodOc
            // 
            this.txtcodOc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtcodOc.Location = new System.Drawing.Point(607, 34);
            this.txtcodOc.Name = "txtcodOc";
            this.txtcodOc.Size = new System.Drawing.Size(204, 20);
            this.txtcodOc.TabIndex = 3;
            this.txtcodOc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodOc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código OC";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtproducto.Location = new System.Drawing.Point(607, 13);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(204, 20);
            this.txtproducto.TabIndex = 2;
            this.txtproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Producto:";
            // 
            // txtrazsoc
            // 
            this.txtrazsoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtrazsoc.Location = new System.Drawing.Point(306, 34);
            this.txtrazsoc.Name = "txtrazsoc";
            this.txtrazsoc.Size = new System.Drawing.Size(204, 20);
            this.txtrazsoc.TabIndex = 1;
            this.txtrazsoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrazsoc_KeyPress);
            // 
            // cbLocal
            // 
            this.cbLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(306, 11);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(121, 22);
            this.cbLocal.TabIndex = 6;
            this.cbLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLocal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Razón Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblNumItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Nº Item";
            // 
            // lblNumItem
            // 
            this.lblNumItem.Name = "lblNumItem";
            this.lblNumItem.Size = new System.Drawing.Size(13, 17);
            this.lblNumItem.Text = "  ";
            // 
            // FrmOrdenCompra_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(966, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmOrdenCompra_qry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de orden de compra";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrdenCompra_qry_KeyDown);
            this.Resize += new System.EventHandler(this.FrmOrdenCompra_qry_Resize);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgOrdenCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtcodOc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrazsoc;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumItem;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.MaskedTextBox txtfechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ordenco;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_ordenco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_raznombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
    }
}