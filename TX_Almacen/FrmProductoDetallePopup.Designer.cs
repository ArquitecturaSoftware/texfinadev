namespace TX_Almacen
{
    partial class FrmProductoDetallePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoDetallePopup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodbarra = new System.Windows.Forms.TextBox();
            this.btnCancelar_pop = new System.Windows.Forms.Button();
            this.btnAceptar_pop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtnrollo = new System.Windows.Forms.TextBox();
            this.txtnuitem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Und = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_desp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdIngreso = new System.Windows.Forms.Label();
            this.lblnuitem = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodbarra);
            this.groupBox1.Controls.Add(this.btnCancelar_pop);
            this.groupBox1.Controls.Add(this.btnAceptar_pop);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.txtpeso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";

            // 
            // txtCodbarra
            // 
            this.txtCodbarra.BackColor = System.Drawing.Color.White;
            this.txtCodbarra.Enabled = false;
            this.txtCodbarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodbarra.Location = new System.Drawing.Point(77, 11);
            this.txtCodbarra.Name = "txtCodbarra";
            this.txtCodbarra.ReadOnly = true;
            this.txtCodbarra.Size = new System.Drawing.Size(265, 20);
            this.txtCodbarra.TabIndex = 2;
            // 
            // btnCancelar_pop
            // 
            this.btnCancelar_pop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar_pop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_pop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar_pop.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar_pop.Image")));
            this.btnCancelar_pop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar_pop.Location = new System.Drawing.Point(196, 139);
            this.btnCancelar_pop.Name = "btnCancelar_pop";
            this.btnCancelar_pop.Size = new System.Drawing.Size(98, 23);
            this.btnCancelar_pop.TabIndex = 3;
            this.btnCancelar_pop.Text = "Terminar";
            this.btnCancelar_pop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnAceptar_pop.Location = new System.Drawing.Point(92, 139);
            this.btnAceptar_pop.Name = "btnAceptar_pop";
            this.btnAceptar_pop.Size = new System.Drawing.Size(98, 23);
            this.btnAceptar_pop.TabIndex = 2;
            this.btnAceptar_pop.Text = "Siguiente";
            this.btnAceptar_pop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar_pop.UseVisualStyleBackColor = false;
            this.btnAceptar_pop.Click += new System.EventHandler(this.btnAceptar_pop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.47368F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.txtnrollo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnuitem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtnrollo
            // 
            this.txtnrollo.BackColor = System.Drawing.Color.White;
            this.txtnrollo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrollo.Enabled = false;
            this.txtnrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrollo.Location = new System.Drawing.Point(244, 3);
            this.txtnrollo.Name = "txtnrollo";
            this.txtnrollo.Size = new System.Drawing.Size(82, 23);
            this.txtnrollo.TabIndex = 4;
            // 
            // txtnuitem
            // 
            this.txtnuitem.BackColor = System.Drawing.Color.White;
            this.txtnuitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnuitem.Enabled = false;
            this.txtnuitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuitem.Location = new System.Drawing.Point(69, 3);
            this.txtnuitem.Name = "txtnuitem";
            this.txtnuitem.Size = new System.Drawing.Size(82, 23);
            this.txtnuitem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "N Item :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Rollo :";
            // 
            // txtpeso
            // 
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpeso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.ForeColor = System.Drawing.Color.Red;
            this.txtpeso.Location = new System.Drawing.Point(159, 90);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(135, 29);
            this.txtpeso.TabIndex = 0;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpeso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso :";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.CodBarra,
            this.Und,
            this.Peso_desp,
            this.peso_real});
            this.dgDetalle.Location = new System.Drawing.Point(415, 20);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.Size = new System.Drawing.Size(470, 193);
            this.dgDetalle.TabIndex = 62;
            this.dgDetalle.Visible = false;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "nu_Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // CodBarra
            // 
            this.CodBarra.DataPropertyName = "Cod_Bar";
            this.CodBarra.HeaderText = "CodBarra";
            this.CodBarra.Name = "CodBarra";
            this.CodBarra.Width = 150;
            // 
            // Und
            // 
            this.Und.DataPropertyName = "qt_rollo_actual";
            this.Und.HeaderText = "Und.Rollo";
            this.Und.Name = "Und";
            // 
            // Peso_desp
            // 
            this.Peso_desp.DataPropertyName = "qt_peso_desp";
            this.Peso_desp.HeaderText = "Peso Desp";
            this.Peso_desp.Name = "Peso_desp";
            // 
            // peso_real
            // 
            this.peso_real.DataPropertyName = "qt_peso_real";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.peso_real.DefaultCellStyle = dataGridViewCellStyle2;
            this.peso_real.HeaderText = "Peso Real";
            this.peso_real.Name = "peso_real";
            // 
            // lblIdIngreso
            // 
            this.lblIdIngreso.AutoSize = true;
            this.lblIdIngreso.Location = new System.Drawing.Point(24, 9);
            this.lblIdIngreso.Name = "lblIdIngreso";
            this.lblIdIngreso.Size = new System.Drawing.Size(0, 13);
            this.lblIdIngreso.TabIndex = 63;
            this.lblIdIngreso.Visible = false;
            // 
            // lblnuitem
            // 
            this.lblnuitem.AutoSize = true;
            this.lblnuitem.Location = new System.Drawing.Point(471, 220);
            this.lblnuitem.Name = "lblnuitem";
            this.lblnuitem.Size = new System.Drawing.Size(0, 13);
            this.lblnuitem.TabIndex = 64;
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Location = new System.Drawing.Point(412, 4);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(0, 13);
            this.lblcont.TabIndex = 65;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmProductoDetallePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 199);
            this.Controls.Add(this.lblcont);
            this.Controls.Add(this.lblnuitem);
            this.Controls.Add(this.lblIdIngreso);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProductoDetallePopup";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Peso";
            this.Load += new System.EventHandler(this.FrmProductoDetallePopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductoDetallePopup_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnuitem;
        private System.Windows.Forms.TextBox txtnrollo;
        private System.Windows.Forms.Button btnCancelar_pop;
        private System.Windows.Forms.Button btnAceptar_pop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtCodbarra;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Und;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_desp;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_real;
        private System.Windows.Forms.Label lblIdIngreso;
        private System.Windows.Forms.Label lblnuitem;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}