namespace TX_Almacen
{
    partial class frmPersonal_qry
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnutot = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuSecuenContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAnulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feIngpla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRazSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuDocIden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtapenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblnutot});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 7;
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
            this.lblnutot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblnutot.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblnutot.Name = "lblnutot";
            this.lblnutot.Size = new System.Drawing.Size(19, 17);
            this.lblnutot.Text = "    ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPersonal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 264);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToOrderColumns = true;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPersonal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPersonal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.nuSecuenContra,
            this.idEmpresa,
            this.idCliProv,
            this.stAnulado,
            this.idEstado,
            this.feIngpla,
            this.dsEstado,
            this.idPuesto,
            this.dsCargo,
            this.idPersonal,
            this.dsRazSocial,
            this.nuDocIden});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonal.Location = new System.Drawing.Point(3, 16);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(986, 245);
            this.dgvPersonal.TabIndex = 4;
            this.dgvPersonal.DoubleClick += new System.EventHandler(this.dgvPersonal_DoubleClick);
            this.dgvPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPersonal_KeyDown);
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "N°";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 44;
            // 
            // nuSecuenContra
            // 
            this.nuSecuenContra.DataPropertyName = "nuSecuenContra";
            this.nuSecuenContra.HeaderText = "nuSecuenContra";
            this.nuSecuenContra.Name = "nuSecuenContra";
            this.nuSecuenContra.ReadOnly = true;
            this.nuSecuenContra.Visible = false;
            this.nuSecuenContra.Width = 106;
            // 
            // idEmpresa
            // 
            this.idEmpresa.DataPropertyName = "idEmpresa";
            this.idEmpresa.HeaderText = "idEmpresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            this.idEmpresa.Visible = false;
            this.idEmpresa.Width = 80;
            // 
            // idCliProv
            // 
            this.idCliProv.DataPropertyName = "idCliProv";
            this.idCliProv.HeaderText = "idCliProv";
            this.idCliProv.Name = "idCliProv";
            this.idCliProv.ReadOnly = true;
            this.idCliProv.Visible = false;
            this.idCliProv.Width = 76;
            // 
            // stAnulado
            // 
            this.stAnulado.DataPropertyName = "stAnulado";
            this.stAnulado.HeaderText = "stAnulado";
            this.stAnulado.Name = "stAnulado";
            this.stAnulado.ReadOnly = true;
            this.stAnulado.Visible = false;
            this.stAnulado.Width = 78;
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            this.idEstado.Width = 71;
            // 
            // feIngpla
            // 
            this.feIngpla.DataPropertyName = "feIngpla";
            this.feIngpla.HeaderText = "feIngpla";
            this.feIngpla.Name = "feIngpla";
            this.feIngpla.ReadOnly = true;
            this.feIngpla.Visible = false;
            this.feIngpla.Width = 70;
            // 
            // dsEstado
            // 
            this.dsEstado.DataPropertyName = "dsEstado";
            this.dsEstado.HeaderText = "dsEstado";
            this.dsEstado.Name = "dsEstado";
            this.dsEstado.ReadOnly = true;
            this.dsEstado.Visible = false;
            this.dsEstado.Width = 72;
            // 
            // idPuesto
            // 
            this.idPuesto.DataPropertyName = "idPuesto";
            this.idPuesto.HeaderText = "idPuesto";
            this.idPuesto.Name = "idPuesto";
            this.idPuesto.ReadOnly = true;
            this.idPuesto.Visible = false;
            this.idPuesto.Width = 71;
            // 
            // dsCargo
            // 
            this.dsCargo.DataPropertyName = "dsCargo";
            this.dsCargo.HeaderText = "dsCargo";
            this.dsCargo.Name = "dsCargo";
            this.dsCargo.ReadOnly = true;
            this.dsCargo.Visible = false;
            this.dsCargo.Width = 68;
            // 
            // idPersonal
            // 
            this.idPersonal.DataPropertyName = "idPersonal";
            this.idPersonal.HeaderText = "Codigo";
            this.idPersonal.Name = "idPersonal";
            this.idPersonal.ReadOnly = true;
            this.idPersonal.Width = 64;
            // 
            // dsRazSocial
            // 
            this.dsRazSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dsRazSocial.DataPropertyName = "dsRazSocial";
            this.dsRazSocial.HeaderText = "Apellidos y Nombres";
            this.dsRazSocial.Name = "dsRazSocial";
            this.dsRazSocial.ReadOnly = true;
            // 
            // nuDocIden
            // 
            this.nuDocIden.DataPropertyName = "nuDocIden";
            this.nuDocIden.HeaderText = "Doc.Identidad";
            this.nuDocIden.Name = "nuDocIden";
            this.nuDocIden.ReadOnly = true;
            this.nuDocIden.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtapenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // txtapenom
            // 
            this.txtapenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtapenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapenom.Location = new System.Drawing.Point(352, 13);
            this.txtapenom.Name = "txtapenom";
            this.txtapenom.Size = new System.Drawing.Size(257, 20);
            this.txtapenom.TabIndex = 1;
            this.txtapenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapenom_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido y Nombre :";
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdni.Location = new System.Drawing.Point(98, 34);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 3;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(98, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Personal : ";
            // 
            // frmPersonal_qry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmPersonal_qry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmPersonal_qry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPersonal_qry_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnutot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtapenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuSecuenContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAnulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn feIngpla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsRazSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuDocIden;
    }
}