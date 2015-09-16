namespace TX_Almacen
{
    partial class frmProducto_qry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto_qry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgproducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtpresentacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nuItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codfox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Tipgasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dgproducto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 257);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // dgproducto
            // 
            this.dgproducto.AllowUserToAddRows = false;
            this.dgproducto.AllowUserToOrderColumns = true;
            this.dgproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgproducto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgproducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Codfox,
            this.Pres,
            this.Producto,
            this.Presenta,
            this.UM,
            this.Peso_Bruto,
            this.Id_Tipgasto,
            this.Tipo_gasto,
            this.idPresentacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgproducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgproducto.Location = new System.Drawing.Point(3, 16);
            this.dgproducto.Name = "dgproducto";
            this.dgproducto.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgproducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgproducto.Size = new System.Drawing.Size(986, 238);
            this.dgproducto.TabIndex = 4;
            this.dgproducto.DoubleClick += new System.EventHandler(this.dgproducto_DoubleClick);
            this.dgproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgproducto_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnProducto);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtpresentacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // btnProducto
            // 
            this.btnProducto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(688, 12);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(92, 27);
            this.btnProducto.TabIndex = 12;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(606, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 27);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtpresentacion
            // 
            this.txtpresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtpresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpresentacion.Location = new System.Drawing.Point(304, 38);
            this.txtpresentacion.Name = "txtpresentacion";
            this.txtpresentacion.Size = new System.Drawing.Size(257, 20);
            this.txtpresentacion.TabIndex = 5;
            this.txtpresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpresentacion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Presentación :";
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdes.Location = new System.Drawing.Point(304, 12);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(257, 20);
            this.txtdes.TabIndex = 1;
            this.txtdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdes_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción  :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(68, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nuItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 10;
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
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 69;
            // 
            // Codfox
            // 
            this.Codfox.DataPropertyName = "idProdFox";
            this.Codfox.HeaderText = "Cod Fox";
            this.Codfox.Name = "Codfox";
            this.Codfox.Width = 74;
            // 
            // Pres
            // 
            this.Pres.DataPropertyName = "Pres";
            this.Pres.HeaderText = "Pres";
            this.Pres.Name = "Pres";
            this.Pres.ReadOnly = true;
            this.Pres.Width = 55;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.FillWeight = 253.1915F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 78;
            // 
            // Presenta
            // 
            this.Presenta.DataPropertyName = "Presenta";
            this.Presenta.FillWeight = 74.46809F;
            this.Presenta.HeaderText = "Presenta";
            this.Presenta.Name = "Presenta";
            this.Presenta.ReadOnly = true;
            this.Presenta.Width = 78;
            // 
            // UM
            // 
            this.UM.DataPropertyName = "UM";
            this.UM.FillWeight = 74.46809F;
            this.UM.HeaderText = "UM";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
            this.UM.Width = 50;
            // 
            // Peso_Bruto
            // 
            this.Peso_Bruto.DataPropertyName = "Peso Bruto";
            this.Peso_Bruto.FillWeight = 74.46809F;
            this.Peso_Bruto.HeaderText = "Peso Bruto";
            this.Peso_Bruto.Name = "Peso_Bruto";
            this.Peso_Bruto.ReadOnly = true;
            this.Peso_Bruto.Width = 89;
            // 
            // Id_Tipgasto
            // 
            this.Id_Tipgasto.DataPropertyName = "id_tipogsto";
            this.Id_Tipgasto.FillWeight = 74.46809F;
            this.Id_Tipgasto.HeaderText = "Id Tipgasto";
            this.Id_Tipgasto.Name = "Id_Tipgasto";
            this.Id_Tipgasto.Width = 88;
            // 
            // Tipo_gasto
            // 
            this.Tipo_gasto.DataPropertyName = "ds_tipogsto";
            this.Tipo_gasto.FillWeight = 74.46809F;
            this.Tipo_gasto.HeaderText = "Tipo gasto";
            this.Tipo_gasto.Name = "Tipo_gasto";
            this.Tipo_gasto.Width = 84;
            // 
            // idPresentacion
            // 
            this.idPresentacion.DataPropertyName = "id_prodprese";
            this.idPresentacion.FillWeight = 74.46809F;
            this.idPresentacion.HeaderText = "idPresentacion";
            this.idPresentacion.Name = "idPresentacion";
            this.idPresentacion.ReadOnly = true;
            this.idPresentacion.Width = 110;
            // 
            // frmProducto_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(992, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProducto_qry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Producto";
            this.Load += new System.EventHandler(this.frmProducto_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProducto_qry_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgproducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nuItem;
        private System.Windows.Forms.TextBox txtpresentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgproducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codfox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tipgasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresentacion;
    }
}