namespace TX_Sistema
{
    partial class frmPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermiso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnEliminarRow = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldsUusuario = new System.Windows.Forms.Label();
            this.btnBuscarUusuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvModulo = new System.Windows.Forms.DataGridView();
            this.chkestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._idModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.idModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCopiar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGrabar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVistaPrevia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this._btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevo_ = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminarRow});
            this.toolStrip3.Location = new System.Drawing.Point(815, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(64, 460);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnEliminarRow
            // 
            this.btnEliminarRow.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRow.Image")));
            this.btnEliminarRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarRow.Name = "btnEliminarRow";
            this.btnEliminarRow.Size = new System.Drawing.Size(61, 20);
            this.btnEliminarRow.Text = "Eliminar";
            this.btnEliminarRow.Click += new System.EventHandler(this.btnEliminarRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Location = new System.Drawing.Point(93, 12);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(68, 20);
            this.txtIdUsuario.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.groupBox1.Controls.Add(this.lbldsUusuario);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.btnBuscarUusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 43);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            // 
            // lbldsUusuario
            // 
            this.lbldsUusuario.AutoSize = true;
            this.lbldsUusuario.Location = new System.Drawing.Point(195, 16);
            this.lbldsUusuario.Name = "lbldsUusuario";
            this.lbldsUusuario.Size = new System.Drawing.Size(0, 13);
            this.lbldsUusuario.TabIndex = 107;
            // 
            // btnBuscarUusuario
            // 
            this.btnBuscarUusuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarUusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarUusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUusuario.Image = global::TX_Sistema.Properties.Resources.calendar;
            this.btnBuscarUusuario.Location = new System.Drawing.Point(167, 11);
            this.btnBuscarUusuario.Name = "btnBuscarUusuario";
            this.btnBuscarUusuario.Size = new System.Drawing.Size(22, 20);
            this.btnBuscarUusuario.TabIndex = 106;
            this.btnBuscarUusuario.UseVisualStyleBackColor = false;
            this.btnBuscarUusuario.Click += new System.EventHandler(this.btnBuscarUusuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 508);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(8, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvModulo);
            this.splitContainer1.Panel1.Controls.Add(this.btnProcesar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetalle);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 462);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvModulo
            // 
            this.dgvModulo.AllowUserToAddRows = false;
            this.dgvModulo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvModulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvModulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkestado,
            this._idModulo,
            this.ds_modulo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModulo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvModulo.GridColor = System.Drawing.SystemColors.Control;
            this.dgvModulo.Location = new System.Drawing.Point(10, 40);
            this.dgvModulo.Name = "dgvModulo";
            this.dgvModulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvModulo.RowHeadersVisible = false;
            this.dgvModulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulo.Size = new System.Drawing.Size(167, 397);
            this.dgvModulo.TabIndex = 7;
            // 
            // chkestado
            // 
            this.chkestado.HeaderText = "";
            this.chkestado.Name = "chkestado";
            this.chkestado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkestado.Width = 50;
            // 
            // _idModulo
            // 
            this._idModulo.DataPropertyName = "idModulo";
            this._idModulo.HeaderText = "idModulo";
            this._idModulo.Name = "_idModulo";
            this._idModulo.Visible = false;
            // 
            // ds_modulo
            // 
            this.ds_modulo.DataPropertyName = "ds_modulo";
            this.ds_modulo.HeaderText = "modulo";
            this.ds_modulo.Name = "ds_modulo";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(10, 11);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(167, 23);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModulo,
            this.dsModulo,
            this.id_formulario,
            this.ds_Formulario,
            this.BtnNuevo,
            this.btnCopiar,
            this.btnEditar,
            this.btnGrabar,
            this.btnImprimir,
            this.btnBuscar,
            this.btnVistaPrevia,
            this.Form});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 3);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(809, 438);
            this.dgvDetalle.TabIndex = 3;
            this.dgvDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalle_CurrentCellDirtyStateChanged);
            this.dgvDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetalle_DataError);
            // 
            // idModulo
            // 
            this.idModulo.DataPropertyName = "idModulo";
            this.idModulo.HeaderText = "idModulo";
            this.idModulo.MinimumWidth = 50;
            this.idModulo.Name = "idModulo";
            this.idModulo.Visible = false;
            this.idModulo.Width = 50;
            // 
            // dsModulo
            // 
            this.dsModulo.DataPropertyName = "ds_modulo";
            this.dsModulo.HeaderText = "Modulo";
            this.dsModulo.Name = "dsModulo";
            this.dsModulo.Width = 150;
            // 
            // id_formulario
            // 
            this.id_formulario.DataPropertyName = "id_formulario";
            this.id_formulario.HeaderText = "idFormulario";
            this.id_formulario.Name = "id_formulario";
            this.id_formulario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_formulario.Visible = false;
            this.id_formulario.Width = 50;
            // 
            // ds_Formulario
            // 
            this.ds_Formulario.DataPropertyName = "ds_formulario";
            this.ds_Formulario.HeaderText = "Formulario";
            this.ds_Formulario.Name = "ds_Formulario";
            this.ds_Formulario.Width = 200;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.DataPropertyName = "btnNuevo";
            this.BtnNuevo.HeaderText = "Nuevo";
            this.BtnNuevo.Name = "BtnNuevo";
            // 
            // btnCopiar
            // 
            this.btnCopiar.DataPropertyName = "btnCopiar";
            this.btnCopiar.HeaderText = "Copiar";
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Width = 50;
            // 
            // btnEditar
            // 
            this.btnEditar.DataPropertyName = "btnEditar";
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Width = 50;
            // 
            // btnGrabar
            // 
            this.btnGrabar.DataPropertyName = "btnGrabar";
            this.btnGrabar.HeaderText = "Grabar";
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Width = 50;
            // 
            // btnImprimir
            // 
            this.btnImprimir.DataPropertyName = "btnImprimir";
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Width = 50;
            // 
            // btnBuscar
            // 
            this.btnBuscar.DataPropertyName = "btnBuscar";
            this.btnBuscar.HeaderText = "Buscar";
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Width = 50;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.DataPropertyName = "btnVistaPrevia";
            this.btnVistaPrevia.HeaderText = "Vista Previa";
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Width = 50;
            // 
            // Form
            // 
            this.Form.DataPropertyName = "btnForm";
            this.Form.HeaderText = "Form";
            this.Form.Name = "Form";
            this.Form.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnGrabar,
            this.toolStripSeparator1,
            this.txtBuscar,
            this._btnBuscar,
            this.toolStripSeparator2,
            this.btnNuevo_});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip1.TabIndex = 109;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btnGrabar
            // 
            this._btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("_btnGrabar.Image")));
            this._btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnGrabar.Name = "_btnGrabar";
            this._btnGrabar.Size = new System.Drawing.Size(60, 22);
            this._btnGrabar.Text = "Grabar";
            this._btnGrabar.Click += new System.EventHandler(this._btnGrabar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("_btnBuscar.Image")));
            this._btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(59, 22);
            this._btnBuscar.Text = "Buscar";
            this._btnBuscar.Click += new System.EventHandler(this._btnBuscar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNuevo_
            // 
            this.btnNuevo_.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo_.Image")));
            this.btnNuevo_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo_.Name = "btnNuevo_";
            this.btnNuevo_.Size = new System.Drawing.Size(58, 22);
            this.btnNuevo_.Text = "Nuevo";
            this.btnNuevo_.Click += new System.EventHandler(this.btnNuevo__Click);
            // 
            // frmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1085, 560);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permiso";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPermiso_Load);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnEliminarRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnBuscarUusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lbldsUusuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _btnGrabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton _btnBuscar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dgvModulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_formulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Formulario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BtnNuevo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnCopiar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnGrabar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnVistaPrevia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Form;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNuevo_;
    }
}