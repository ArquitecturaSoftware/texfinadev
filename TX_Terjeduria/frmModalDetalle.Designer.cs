namespace TX_Terjeduria
{
    partial class frmModalDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalDetalle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstructura = new System.Windows.Forms.TextBox();
            this.txtDistribucion = new System.Windows.Forms.TextBox();
            this.txtAlimenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblds_producto = new System.Windows.Forms.Label();
            this.btnHilo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnNuevoRow = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarRow = new System.Windows.Forms.ToolStripButton();
            this.dgmodalDet = new System.Windows.Forms.GroupBox();
            this.dgDetalleMall = new System.Windows.Forms.DataGridView();
            this.nu_secuen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nu_longmalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnumAliment = new System.Windows.Forms.TextBox();
            this.txtNumBobinas = new System.Windows.Forms.TextBox();
            this.txttension = new System.Windows.Forms.TextBox();
            this.txtporcHiloAcabado = new System.Windows.Forms.TextBox();
            this.txtporcHiloCrudo = new System.Windows.Forms.TextBox();
            this.txtetiqueta = new System.Windows.Forms.TextBox();
            this.txtpreuni = new System.Windows.Forms.TextBox();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.lblprov = new System.Windows.Forms.Label();
            this.btn_idProv = new System.Windows.Forms.Button();
            this.txtidprov = new System.Windows.Forms.TextBox();
            this.txttorsion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cblustre = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtlustre = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtcaracHilo = new System.Windows.Forms.TextBox();
            this.txttipfibra = new System.Windows.Forms.TextBox();
            this.txtHilo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar_pop = new System.Windows.Forms.Button();
            this.btnAceptar_pop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.dgmodalDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMall)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstructura);
            this.groupBox1.Controls.Add(this.txtDistribucion);
            this.groupBox1.Controls.Add(this.txtAlimenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEJIDO";
            // 
            // txtEstructura
            // 
            this.txtEstructura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtEstructura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstructura.Location = new System.Drawing.Point(95, 60);
            this.txtEstructura.MaxLength = 50;
            this.txtEstructura.Name = "txtEstructura";
            this.txtEstructura.Size = new System.Drawing.Size(328, 20);
            this.txtEstructura.TabIndex = 5;
            this.txtEstructura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstructura_KeyPress);
            // 
            // txtDistribucion
            // 
            this.txtDistribucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtDistribucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistribucion.Location = new System.Drawing.Point(95, 38);
            this.txtDistribucion.MaxLength = 30;
            this.txtDistribucion.Name = "txtDistribucion";
            this.txtDistribucion.Size = new System.Drawing.Size(328, 20);
            this.txtDistribucion.TabIndex = 4;
            this.txtDistribucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistribucion_KeyPress);
            // 
            // txtAlimenta
            // 
            this.txtAlimenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtAlimenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlimenta.Location = new System.Drawing.Point(95, 16);
            this.txtAlimenta.MaxLength = 3;
            this.txtAlimenta.Name = "txtAlimenta";
            this.txtAlimenta.Size = new System.Drawing.Size(47, 20);
            this.txtAlimenta.TabIndex = 3;
            this.txtAlimenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlimenta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estructura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distribución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Alimenta.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblds_producto);
            this.groupBox2.Controls.Add(this.btnHilo);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dgmodalDet);
            this.groupBox2.Controls.Add(this.txtnumAliment);
            this.groupBox2.Controls.Add(this.txtNumBobinas);
            this.groupBox2.Controls.Add(this.txttension);
            this.groupBox2.Controls.Add(this.txtporcHiloAcabado);
            this.groupBox2.Controls.Add(this.txtporcHiloCrudo);
            this.groupBox2.Controls.Add(this.txtetiqueta);
            this.groupBox2.Controls.Add(this.txtpreuni);
            this.groupBox2.Controls.Add(this.txtlote);
            this.groupBox2.Controls.Add(this.lblprov);
            this.groupBox2.Controls.Add(this.btn_idProv);
            this.groupBox2.Controls.Add(this.txtidprov);
            this.groupBox2.Controls.Add(this.txttorsion);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cblustre);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtlustre);
            this.groupBox2.Controls.Add(this.txttitulo);
            this.groupBox2.Controls.Add(this.txtcaracHilo);
            this.groupBox2.Controls.Add(this.txttipfibra);
            this.groupBox2.Controls.Add(this.txtHilo);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HILO";
            // 
            // lblds_producto
            // 
            this.lblds_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblds_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblds_producto.Location = new System.Drawing.Point(230, 10);
            this.lblds_producto.Name = "lblds_producto";
            this.lblds_producto.Size = new System.Drawing.Size(193, 19);
            this.lblds_producto.TabIndex = 106;
            // 
            // btnHilo
            // 
            this.btnHilo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHilo.Image = global::Sist_Compras.Properties.Resources.calendar;
            this.btnHilo.Location = new System.Drawing.Point(202, 9);
            this.btnHilo.Name = "btnHilo";
            this.btnHilo.Size = new System.Drawing.Size(22, 20);
            this.btnHilo.TabIndex = 104;
            this.btnHilo.UseVisualStyleBackColor = true;
            this.btnHilo.Click += new System.EventHandler(this.btnHilo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toolStrip3);
            this.groupBox4.Location = new System.Drawing.Point(414, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(34, 115);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoRow,
            this.btnEliminarRow});
            this.toolStrip3.Location = new System.Drawing.Point(7, 16);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(24, 96);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked);
            // 
            // btnNuevoRow
            // 
            this.btnNuevoRow.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoRow.Image")));
            this.btnNuevoRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoRow.Name = "btnNuevoRow";
            this.btnNuevoRow.Size = new System.Drawing.Size(21, 20);
            this.btnNuevoRow.Click += new System.EventHandler(this.btnNuevoRow_Click);
            // 
            // btnEliminarRow
            // 
            this.btnEliminarRow.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRow.Image")));
            this.btnEliminarRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarRow.Name = "btnEliminarRow";
            this.btnEliminarRow.Size = new System.Drawing.Size(21, 20);
            this.btnEliminarRow.Click += new System.EventHandler(this.btnEliminarRow_Click);
            // 
            // dgmodalDet
            // 
            this.dgmodalDet.Controls.Add(this.dgDetalleMall);
            this.dgmodalDet.Location = new System.Drawing.Point(200, 237);
            this.dgmodalDet.Name = "dgmodalDet";
            this.dgmodalDet.Size = new System.Drawing.Size(211, 117);
            this.dgmodalDet.TabIndex = 102;
            this.dgmodalDet.TabStop = false;
            // 
            // dgDetalleMall
            // 
            this.dgDetalleMall.AllowUserToAddRows = false;
            this.dgDetalleMall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalleMall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDetalleMall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleMall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nu_secuen,
            this.nu_item,
            this.nu_longmalla});
            this.dgDetalleMall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetalleMall.Location = new System.Drawing.Point(3, 16);
            this.dgDetalleMall.Name = "dgDetalleMall";
            this.dgDetalleMall.RowHeadersVisible = false;
            this.dgDetalleMall.Size = new System.Drawing.Size(205, 98);
            this.dgDetalleMall.TabIndex = 0;
            // 
            // nu_secuen
            // 
            this.nu_secuen.DataPropertyName = "nu_secuen";
            this.nu_secuen.HeaderText = "nu_secuen";
            this.nu_secuen.Name = "nu_secuen";
            this.nu_secuen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nu_secuen.Visible = false;
            // 
            // nu_item
            // 
            this.nu_item.DataPropertyName = "nu_item";
            this.nu_item.HeaderText = "nu_item";
            this.nu_item.Name = "nu_item";
            this.nu_item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nu_longmalla
            // 
            this.nu_longmalla.DataPropertyName = "nu_longmalla";
            this.nu_longmalla.HeaderText = "nu_longmalla";
            this.nu_longmalla.Name = "nu_longmalla";
            this.nu_longmalla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtnumAliment
            // 
            this.txtnumAliment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtnumAliment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumAliment.Location = new System.Drawing.Point(95, 325);
            this.txtnumAliment.Name = "txtnumAliment";
            this.txtnumAliment.Size = new System.Drawing.Size(66, 20);
            this.txtnumAliment.TabIndex = 101;
            this.txtnumAliment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumAliment_KeyPress);
            this.txtnumAliment.Leave += new System.EventHandler(this.txtnumAliment_Leave);
            // 
            // txtNumBobinas
            // 
            this.txtNumBobinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtNumBobinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumBobinas.Location = new System.Drawing.Point(95, 303);
            this.txtNumBobinas.Name = "txtNumBobinas";
            this.txtNumBobinas.Size = new System.Drawing.Size(66, 20);
            this.txtNumBobinas.TabIndex = 100;
            this.txtNumBobinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumBobinas_KeyPress);
            this.txtNumBobinas.Leave += new System.EventHandler(this.txtNumBobinas_Leave);
            // 
            // txttension
            // 
            this.txttension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txttension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttension.Location = new System.Drawing.Point(95, 281);
            this.txttension.Name = "txttension";
            this.txttension.Size = new System.Drawing.Size(99, 20);
            this.txttension.TabIndex = 99;
            this.txttension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttersion_KeyPress);
            this.txttension.Leave += new System.EventHandler(this.txttersion_Leave);
            // 
            // txtporcHiloAcabado
            // 
            this.txtporcHiloAcabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtporcHiloAcabado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtporcHiloAcabado.Location = new System.Drawing.Point(95, 259);
            this.txtporcHiloAcabado.Name = "txtporcHiloAcabado";
            this.txtporcHiloAcabado.Size = new System.Drawing.Size(66, 20);
            this.txtporcHiloAcabado.TabIndex = 98;
            this.txtporcHiloAcabado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtporcHiloAcabado_KeyPress);
            this.txtporcHiloAcabado.Leave += new System.EventHandler(this.txtporcHiloAcabado_Leave);
            // 
            // txtporcHiloCrudo
            // 
            this.txtporcHiloCrudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtporcHiloCrudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtporcHiloCrudo.Location = new System.Drawing.Point(95, 237);
            this.txtporcHiloCrudo.Name = "txtporcHiloCrudo";
            this.txtporcHiloCrudo.Size = new System.Drawing.Size(66, 20);
            this.txtporcHiloCrudo.TabIndex = 97;
            this.txtporcHiloCrudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtporcHiloCrudo_KeyPress);
            this.txtporcHiloCrudo.Leave += new System.EventHandler(this.txtporcHiloCrudo_Leave);
            // 
            // txtetiqueta
            // 
            this.txtetiqueta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtetiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtetiqueta.Location = new System.Drawing.Point(95, 215);
            this.txtetiqueta.MaxLength = 30;
            this.txtetiqueta.Name = "txtetiqueta";
            this.txtetiqueta.Size = new System.Drawing.Size(328, 20);
            this.txtetiqueta.TabIndex = 96;
            this.txtetiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtetiqueta_KeyPress);
            // 
            // txtpreuni
            // 
            this.txtpreuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtpreuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpreuni.Location = new System.Drawing.Point(292, 192);
            this.txtpreuni.Name = "txtpreuni";
            this.txtpreuni.Size = new System.Drawing.Size(66, 20);
            this.txtpreuni.TabIndex = 95;
            this.txtpreuni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreuni_KeyPress);
            this.txtpreuni.Leave += new System.EventHandler(this.txtpreuni_Leave);
            // 
            // txtlote
            // 
            this.txtlote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtlote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlote.Location = new System.Drawing.Point(95, 193);
            this.txtlote.MaxLength = 12;
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(66, 20);
            this.txtlote.TabIndex = 94;
            this.txtlote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlote_KeyPress);
            // 
            // lblprov
            // 
            this.lblprov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.lblprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprov.Location = new System.Drawing.Point(190, 171);
            this.lblprov.Name = "lblprov";
            this.lblprov.Size = new System.Drawing.Size(233, 19);
            this.lblprov.TabIndex = 93;
            // 
            // btn_idProv
            // 
            this.btn_idProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_idProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_idProv.Image = global::Sist_Compras.Properties.Resources.calendar;
            this.btn_idProv.Location = new System.Drawing.Point(164, 171);
            this.btn_idProv.Name = "btn_idProv";
            this.btn_idProv.Size = new System.Drawing.Size(22, 20);
            this.btn_idProv.TabIndex = 92;
            this.btn_idProv.UseVisualStyleBackColor = true;
            this.btn_idProv.Click += new System.EventHandler(this.btn_idProv_Click);
            // 
            // txtidprov
            // 
            this.txtidprov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtidprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidprov.Location = new System.Drawing.Point(95, 171);
            this.txtidprov.MaxLength = 6;
            this.txtidprov.Name = "txtidprov";
            this.txtidprov.Size = new System.Drawing.Size(66, 20);
            this.txtidprov.TabIndex = 91;
            this.txtidprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidprov_KeyPress);
            this.txtidprov.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtidprov_KeyUp);
            // 
            // txttorsion
            // 
            this.txttorsion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txttorsion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttorsion.Location = new System.Drawing.Point(349, 149);
            this.txttorsion.MaxLength = 5;
            this.txttorsion.Name = "txttorsion";
            this.txttorsion.Size = new System.Drawing.Size(74, 20);
            this.txttorsion.TabIndex = 90;
            this.txttorsion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttorsion_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(307, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 89;
            this.label19.Text = "Torsión";
            // 
            // cblustre
            // 
            this.cblustre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cblustre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblustre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cblustre.FormattingEnabled = true;
            this.cblustre.Location = new System.Drawing.Point(165, 149);
            this.cblustre.Name = "cblustre";
            this.cblustre.Size = new System.Drawing.Size(136, 21);
            this.cblustre.TabIndex = 20;
            this.cblustre.SelectionChangeCommitted += new System.EventHandler(this.cblustre_SelectionChangeCommitted);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Precio Uni.";
            // 
            // txtlustre
            // 
            this.txtlustre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtlustre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlustre.Location = new System.Drawing.Point(95, 149);
            this.txtlustre.MaxLength = 3;
            this.txtlustre.Name = "txtlustre";
            this.txtlustre.Size = new System.Drawing.Size(66, 20);
            this.txtlustre.TabIndex = 18;
            this.txtlustre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlustre_KeyPress);
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txttitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttitulo.Location = new System.Drawing.Point(95, 101);
            this.txttitulo.MaxLength = 100;
            this.txttitulo.Multiline = true;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(328, 46);
            this.txttitulo.TabIndex = 17;
            this.txttitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttitulo_KeyPress);
            // 
            // txtcaracHilo
            // 
            this.txtcaracHilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtcaracHilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcaracHilo.Location = new System.Drawing.Point(95, 79);
            this.txtcaracHilo.MaxLength = 50;
            this.txtcaracHilo.Name = "txtcaracHilo";
            this.txtcaracHilo.Size = new System.Drawing.Size(328, 20);
            this.txtcaracHilo.TabIndex = 16;
            this.txtcaracHilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcaracHilo_KeyPress);
            // 
            // txttipfibra
            // 
            this.txttipfibra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txttipfibra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipfibra.Location = new System.Drawing.Point(95, 31);
            this.txttipfibra.MaxLength = 100;
            this.txttipfibra.Multiline = true;
            this.txttipfibra.Name = "txttipfibra";
            this.txttipfibra.Size = new System.Drawing.Size(328, 46);
            this.txttipfibra.TabIndex = 15;
            this.txttipfibra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipfibra_KeyPress);
            // 
            // txtHilo
            // 
            this.txtHilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtHilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHilo.Location = new System.Drawing.Point(95, 9);
            this.txtHilo.MaxLength = 12;
            this.txtHilo.Name = "txtHilo";
            this.txtHilo.Size = new System.Drawing.Size(103, 20);
            this.txtHilo.TabIndex = 6;
            this.txtHilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHilo_KeyPress);
            this.txtHilo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHilo_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "# Aliment.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "# Bobinas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tension";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "%  Hilo Acabado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "%  Hilo Crudo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Etiqueta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Lote";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Lustre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Carac. Hilo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo Fibra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hilo";
            // 
            // btnCancelar_pop
            // 
            this.btnCancelar_pop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar_pop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar_pop.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar_pop.Image")));
            this.btnCancelar_pop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar_pop.Location = new System.Drawing.Point(345, 459);
            this.btnCancelar_pop.Name = "btnCancelar_pop";
            this.btnCancelar_pop.Size = new System.Drawing.Size(102, 23);
            this.btnCancelar_pop.TabIndex = 57;
            this.btnCancelar_pop.Text = "Cancelar";
            this.btnCancelar_pop.UseVisualStyleBackColor = false;
            this.btnCancelar_pop.Click += new System.EventHandler(this.btnCancelar_pop_Click);
            // 
            // btnAceptar_pop
            // 
            this.btnAceptar_pop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar_pop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar_pop.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar_pop.Image")));
            this.btnAceptar_pop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar_pop.Location = new System.Drawing.Point(249, 459);
            this.btnAceptar_pop.Name = "btnAceptar_pop";
            this.btnAceptar_pop.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar_pop.TabIndex = 56;
            this.btnAceptar_pop.Text = "Aceptar";
            this.btnAceptar_pop.UseVisualStyleBackColor = false;
            this.btnAceptar_pop.Click += new System.EventHandler(this.btnAceptar_pop_Click);
            // 
            // frmModalDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(467, 491);
            this.Controls.Add(this.btnCancelar_pop);
            this.Controls.Add(this.btnAceptar_pop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModalDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmModalDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.dgmodalDet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleMall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstructura;
        private System.Windows.Forms.TextBox txtDistribucion;
        private System.Windows.Forms.TextBox txtAlimenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cblustre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtlustre;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtcaracHilo;
        private System.Windows.Forms.TextBox txttipfibra;
        private System.Windows.Forms.TextBox txtHilo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox dgmodalDet;
        private System.Windows.Forms.DataGridView dgDetalleMall;
        private System.Windows.Forms.TextBox txtnumAliment;
        private System.Windows.Forms.TextBox txtNumBobinas;
        private System.Windows.Forms.TextBox txttension;
        private System.Windows.Forms.TextBox txtporcHiloAcabado;
        private System.Windows.Forms.TextBox txtporcHiloCrudo;
        private System.Windows.Forms.TextBox txtetiqueta;
        private System.Windows.Forms.TextBox txtpreuni;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label lblprov;
        private System.Windows.Forms.Button btn_idProv;
        private System.Windows.Forms.TextBox txtidprov;
        private System.Windows.Forms.TextBox txttorsion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnNuevoRow;
        private System.Windows.Forms.ToolStripButton btnEliminarRow;
        private System.Windows.Forms.Button btnCancelar_pop;
        private System.Windows.Forms.Button btnAceptar_pop;
        private System.Windows.Forms.Label lblds_producto;
        private System.Windows.Forms.Button btnHilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_secuen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nu_longmalla;
    }
}