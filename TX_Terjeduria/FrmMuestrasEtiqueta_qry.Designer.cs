namespace TX_Terjeduria
{
    partial class FrmMuestrasEtiqueta_qry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuestrasEtiqueta_qry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgMuestras = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_tfref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_correficha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ptmaq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumTfRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumTf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTejido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTejido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnutot = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.dgMuestras);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 274);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dgMuestras
            // 
            this.dgMuestras.AllowUserToAddRows = false;
            this.dgMuestras.AllowUserToOrderColumns = true;
            this.dgMuestras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMuestras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgMuestras.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgMuestras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMuestras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.id_producto,
            this.ds_producto,
            this.nu_tf,
            this.nu_tfref,
            this.nu_correficha,
            this.id_ptmaq,
            this.Destino,
            this.idCodBar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMuestras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMuestras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMuestras.Location = new System.Drawing.Point(3, 16);
            this.dgMuestras.Name = "dgMuestras";
            this.dgMuestras.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgMuestras.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMuestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMuestras.Size = new System.Drawing.Size(764, 255);
            this.dgMuestras.TabIndex = 3;
            this.dgMuestras.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_CellEnter);
            this.dgMuestras.DoubleClick += new System.EventHandler(this.dgMuestras_DoubleClick);
            this.dgMuestras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgMuestras_KeyDown);
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "RowNumber";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "idProducto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // ds_producto
            // 
            this.ds_producto.DataPropertyName = "ds_producto";
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.ReadOnly = true;
            // 
            // nu_tf
            // 
            this.nu_tf.DataPropertyName = "nu_tf";
            this.nu_tf.HeaderText = "Nº TF";
            this.nu_tf.Name = "nu_tf";
            this.nu_tf.ReadOnly = true;
            // 
            // nu_tfref
            // 
            this.nu_tfref.DataPropertyName = "nu_tfref";
            this.nu_tfref.HeaderText = "Nº TF Ref";
            this.nu_tfref.Name = "nu_tfref";
            this.nu_tfref.ReadOnly = true;
            // 
            // nu_correficha
            // 
            this.nu_correficha.DataPropertyName = "nu_correficha";
            this.nu_correficha.HeaderText = "Ficha";
            this.nu_correficha.Name = "nu_correficha";
            this.nu_correficha.ReadOnly = true;
            // 
            // id_ptmaq
            // 
            this.id_ptmaq.DataPropertyName = "id_ptmaq";
            this.id_ptmaq.HeaderText = "IdMaq";
            this.id_ptmaq.Name = "id_ptmaq";
            this.id_ptmaq.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // idCodBar
            // 
            this.idCodBar.DataPropertyName = "idCodBar";
            this.idCodBar.HeaderText = "idCodBar";
            this.idCodBar.Name = "idCodBar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // txtNumTfRef
            // 
            this.txtNumTfRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtNumTfRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumTfRef.Location = new System.Drawing.Point(647, 30);
            this.txtNumTfRef.Name = "txtNumTfRef";
            this.txtNumTfRef.Size = new System.Drawing.Size(70, 20);
            this.txtNumTfRef.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nº TfRef :";
            // 
            // txtNumTf
            // 
            this.txtNumTf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtNumTf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumTf.Location = new System.Drawing.Point(647, 3);
            this.txtNumTf.Name = "txtNumTf";
            this.txtNumTf.Size = new System.Drawing.Size(70, 20);
            this.txtNumTf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº TF :";
            // 
            // txtTejido
            // 
            this.txtTejido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtTejido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTejido.Location = new System.Drawing.Point(239, 3);
            this.txtTejido.Name = "txtTejido";
            this.txtTejido.Size = new System.Drawing.Size(218, 20);
            this.txtTejido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto  :";
            // 
            // txtFicha
            // 
            this.txtFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFicha.Location = new System.Drawing.Point(510, 3);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Size = new System.Drawing.Size(70, 20);
            this.txtFicha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ficha  :";
            // 
            // txtIdTejido
            // 
            this.txtIdTejido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtIdTejido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdTejido.Location = new System.Drawing.Point(82, 3);
            this.txtIdTejido.Name = "txtIdTejido";
            this.txtIdTejido.Size = new System.Drawing.Size(87, 20);
            this.txtIdTejido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Prod : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblnutot});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Nº Item";
            // 
            // lblnutot
            // 
            this.lblnutot.Name = "lblnutot";
            this.lblnutot.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumTfRef, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdTejido, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTejido, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumTf, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFicha, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 54);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // FrmMuestrasEtiqueta_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(770, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMuestrasEtiqueta_qry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Muestras";
            this.Load += new System.EventHandler(this.FrmMuestrasEtiqueta_qry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgMuestras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumTfRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumTf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTejido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTejido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnutot;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_tfref;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_correficha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ptmaq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}