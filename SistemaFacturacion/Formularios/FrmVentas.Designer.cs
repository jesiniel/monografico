﻿namespace SistemaFacturacion.Formularios
    {
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.radioACredito = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioAlContado = new System.Windows.Forms.RadioButton();
            this.lblBus = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnBusc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.checkDescuento = new System.Windows.Forms.CheckBox();
            this.comboMedioPago = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.dateFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.DataGrivCliente = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textArticuloCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.BtnBuscarArticulo = new System.Windows.Forms.Button();
            this.GrivArticulo = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnVentaNew = new System.Windows.Forms.Button();
            this.btnCuadre = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.gridArticulosAVender = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrivArticulo)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosAVender)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioACredito
            // 
            this.radioACredito.AutoSize = true;
            this.radioACredito.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioACredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.radioACredito.Location = new System.Drawing.Point(202, 22);
            this.radioACredito.Name = "radioACredito";
            this.radioACredito.Size = new System.Drawing.Size(73, 20);
            this.radioACredito.TabIndex = 93;
            this.radioACredito.TabStop = true;
            this.radioACredito.Text = "Credito";
            this.radioACredito.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 175;
            this.label4.Text = "Tipo de Pago";
            // 
            // radioAlContado
            // 
            this.radioAlContado.AutoSize = true;
            this.radioAlContado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAlContado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.radioAlContado.Location = new System.Drawing.Point(105, 22);
            this.radioAlContado.Name = "radioAlContado";
            this.radioAlContado.Size = new System.Drawing.Size(97, 20);
            this.radioAlContado.TabIndex = 94;
            this.radioAlContado.TabStop = true;
            this.radioAlContado.Text = "Al Contado";
            this.radioAlContado.UseVisualStyleBackColor = true;
            this.radioAlContado.CheckedChanged += new System.EventHandler(this.radioAlContado_CheckedChanged);
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.lblBus.Location = new System.Drawing.Point(6, 91);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(63, 19);
            this.lblBus.TabIndex = 189;
            this.lblBus.Text = "Buscar";
            this.lblBus.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtB.Location = new System.Drawing.Point(75, 85);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(26, 34);
            this.txtB.TabIndex = 190;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.Visible = false;
            // 
            // btnBusc
            // 
            this.btnBusc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.btnBusc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBusc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBusc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusc.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusc.ForeColor = System.Drawing.Color.White;
            this.btnBusc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusc.Location = new System.Drawing.Point(107, 85);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(79, 35);
            this.btnBusc.TabIndex = 191;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = false;
            this.btnBusc.Visible = false;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.txtDescuento);
            this.groupBox4.Controls.Add(this.checkDescuento);
            this.groupBox4.Controls.Add(this.radioAlContado);
            this.groupBox4.Controls.Add(this.radioACredito);
            this.groupBox4.Controls.Add(this.comboMedioPago);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cboProv);
            this.groupBox4.Controls.Add(this.dateFechaVencimiento);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(619, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 135);
            this.groupBox4.TabIndex = 191;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Pagos";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(122, 98);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 198;
            this.txtDescuento.Visible = false;
            // 
            // checkDescuento
            // 
            this.checkDescuento.AutoSize = true;
            this.checkDescuento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDescuento.ForeColor = System.Drawing.Color.Gray;
            this.checkDescuento.Location = new System.Drawing.Point(20, 98);
            this.checkDescuento.Name = "checkDescuento";
            this.checkDescuento.Size = new System.Drawing.Size(96, 20);
            this.checkDescuento.TabIndex = 197;
            this.checkDescuento.Text = "Descuento";
            this.checkDescuento.UseVisualStyleBackColor = true;
            this.checkDescuento.CheckedChanged += new System.EventHandler(this.checkDescuento_CheckedChanged);
            // 
            // comboMedioPago
            // 
            this.comboMedioPago.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMedioPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.comboMedioPago.FormattingEnabled = true;
            this.comboMedioPago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheques",
            "Tarjeta Credito",
            "tPagos",
            "Paypal",
            "Trasferecia"});
            this.comboMedioPago.Location = new System.Drawing.Point(405, 93);
            this.comboMedioPago.Name = "comboMedioPago";
            this.comboMedioPago.Size = new System.Drawing.Size(228, 27);
            this.comboMedioPago.TabIndex = 196;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label11.Location = new System.Drawing.Point(281, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 193;
            this.label11.Text = "Fecha Facturacion";
            // 
            // cboProv
            // 
            this.cboProv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(122, 50);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(511, 24);
            this.cboProv.TabIndex = 194;
            // 
            // dateFechaVencimiento
            // 
            this.dateFechaVencimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.dateFechaVencimiento.Enabled = false;
            this.dateFechaVencimiento.Location = new System.Drawing.Point(405, 19);
            this.dateFechaVencimiento.Name = "dateFechaVencimiento";
            this.dateFechaVencimiento.Size = new System.Drawing.Size(228, 20);
            this.dateFechaVencimiento.TabIndex = 192;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label10.Location = new System.Drawing.Point(9, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 191;
            this.label10.Text = "Tipo de Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(281, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 195;
            this.label1.Text = "Medio de Pago";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lblCri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.btnBusc);
            this.groupBox1.Controls.Add(this.lblBus);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Location = new System.Drawing.Point(481, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 135);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.EnabledChanged += new System.EventHandler(this.groupBox1_EnabledChanged);
            // 
            // lblCri
            // 
            this.lblCri.AutoSize = true;
            this.lblCri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.lblCri.Location = new System.Drawing.Point(25, 59);
            this.lblCri.Name = "lblCri";
            this.lblCri.Size = new System.Drawing.Size(17, 19);
            this.lblCri.TabIndex = 199;
            this.lblCri.Text = "c";
            this.lblCri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCri.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 198;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Items.AddRange(new object[] {
            "Ventas Directa",
            "Cliente Exisentes"});
            this.cboCliente.Location = new System.Drawing.Point(75, 25);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(48, 27);
            this.cboCliente.TabIndex = 197;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cboCliente.EnabledChanged += new System.EventHandler(this.comboBox2_EnabledChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.DataGrivCliente);
            this.groupBox2.Location = new System.Drawing.Point(481, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 156);
            this.groupBox2.TabIndex = 193;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            this.groupBox2.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtCliente.Location = new System.Drawing.Point(10, 15);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(80, 34);
            this.txtCliente.TabIndex = 191;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGrivCliente
            // 
            this.DataGrivCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrivCliente.Location = new System.Drawing.Point(10, 57);
            this.DataGrivCliente.Name = "DataGrivCliente";
            this.DataGrivCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrivCliente.Size = new System.Drawing.Size(80, 93);
            this.DataGrivCliente.TabIndex = 0;
            this.DataGrivCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrivCliente_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.textArticuloCantidad);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnAgregarArticulo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBuscarArticulo);
            this.groupBox3.Controls.Add(this.BtnBuscarArticulo);
            this.groupBox3.Controls.Add(this.GrivArticulo);
            this.groupBox3.Location = new System.Drawing.Point(619, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 156);
            this.groupBox3.TabIndex = 194;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articulo";
            // 
            // textArticuloCantidad
            // 
            this.textArticuloCantidad.Location = new System.Drawing.Point(484, 25);
            this.textArticuloCantidad.Name = "textArticuloCantidad";
            this.textArticuloCantidad.Size = new System.Drawing.Size(61, 20);
            this.textArticuloCantidad.TabIndex = 203;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label7.Location = new System.Drawing.Point(418, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 202;
            this.label7.Text = "Cantidad";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnAgregarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArticulo.Image")));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(599, 20);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(42, 35);
            this.btnAgregarArticulo.TabIndex = 201;
            this.btnAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 200;
            this.label2.Text = "Articulo";
            // 
            // txtBuscarArticulo
            // 
            this.txtBuscarArticulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtBuscarArticulo.Location = new System.Drawing.Point(87, 20);
            this.txtBuscarArticulo.Multiline = true;
            this.txtBuscarArticulo.Name = "txtBuscarArticulo";
            this.txtBuscarArticulo.Size = new System.Drawing.Size(330, 31);
            this.txtBuscarArticulo.TabIndex = 199;
            this.txtBuscarArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBuscarArticulo
            // 
            this.BtnBuscarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnBuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarArticulo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarArticulo.Image")));
            this.BtnBuscarArticulo.Location = new System.Drawing.Point(551, 20);
            this.BtnBuscarArticulo.Name = "BtnBuscarArticulo";
            this.BtnBuscarArticulo.Size = new System.Drawing.Size(42, 35);
            this.BtnBuscarArticulo.TabIndex = 194;
            this.BtnBuscarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarArticulo.UseVisualStyleBackColor = false;
            this.BtnBuscarArticulo.Click += new System.EventHandler(this.BtnBuscarArticulo_Click);
            // 
            // GrivArticulo
            // 
            this.GrivArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrivArticulo.Location = new System.Drawing.Point(10, 57);
            this.GrivArticulo.Name = "GrivArticulo";
            this.GrivArticulo.Size = new System.Drawing.Size(631, 93);
            this.GrivArticulo.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Controls.Add(this.btnRemoveItem);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.gridArticulosAVender);
            this.groupBox5.Location = new System.Drawing.Point(741, 406);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(525, 246);
            this.groupBox5.TabIndex = 195;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Codigo";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(57, 25);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(35, 24);
            this.btnRemoveItem.TabIndex = 195;
            this.btnRemoveItem.Text = "x";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Visible = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnVentaNew);
            this.groupBox6.Controls.Add(this.btnCuadre);
            this.groupBox6.Controls.Add(this.btnCancelarFactura);
            this.groupBox6.Controls.Add(this.btnImprimir);
            this.groupBox6.Controls.Add(this.btnPagar);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtItbis);
            this.groupBox6.Controls.Add(this.txtTotal);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtCan);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtSubtotal);
            this.groupBox6.Location = new System.Drawing.Point(96, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 172);
            this.groupBox6.TabIndex = 181;
            this.groupBox6.TabStop = false;
            // 
            // btnVentaNew
            // 
            this.btnVentaNew.BackColor = System.Drawing.Color.Navy;
            this.btnVentaNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaNew.Enabled = false;
            this.btnVentaNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnVentaNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVentaNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaNew.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaNew.ForeColor = System.Drawing.Color.White;
            this.btnVentaNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaNew.Location = new System.Drawing.Point(6, 53);
            this.btnVentaNew.Name = "btnVentaNew";
            this.btnVentaNew.Size = new System.Drawing.Size(129, 35);
            this.btnVentaNew.TabIndex = 196;
            this.btnVentaNew.Text = "Imprimir Factura";
            this.btnVentaNew.UseVisualStyleBackColor = false;
            this.btnVentaNew.Visible = false;
            // 
            // btnCuadre
            // 
            this.btnCuadre.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCuadre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadre.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadre.ForeColor = System.Drawing.Color.White;
            this.btnCuadre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuadre.Location = new System.Drawing.Point(5, 94);
            this.btnCuadre.Name = "btnCuadre";
            this.btnCuadre.Size = new System.Drawing.Size(129, 35);
            this.btnCuadre.TabIndex = 195;
            this.btnCuadre.Text = "Cuadre Caja";
            this.btnCuadre.UseVisualStyleBackColor = false;
            this.btnCuadre.Visible = false;
            this.btnCuadre.Click += new System.EventHandler(this.btnCuadre_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFactura.Enabled = false;
            this.btnCancelarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnCancelarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFactura.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFactura.Location = new System.Drawing.Point(6, 12);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(129, 35);
            this.btnCancelarFactura.TabIndex = 194;
            this.btnCancelarFactura.Text = "Cancelar Factura";
            this.btnCancelarFactura.UseVisualStyleBackColor = false;
            this.btnCancelarFactura.Visible = false;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(6, 132);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 35);
            this.btnImprimir.TabIndex = 193;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(6, 131);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(120, 35);
            this.btnPagar.TabIndex = 192;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label6.Location = new System.Drawing.Point(186, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 181;
            this.label6.Text = "$ ITBIS";
            // 
            // txtItbis
            // 
            this.txtItbis.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtItbis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtItbis.Location = new System.Drawing.Point(270, 97);
            this.txtItbis.Multiline = true;
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(124, 34);
            this.txtItbis.TabIndex = 180;
            this.txtItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtTotal.Location = new System.Drawing.Point(270, 137);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 34);
            this.txtTotal.TabIndex = 168;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label9.Location = new System.Drawing.Point(149, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 179;
            this.label9.Text = "$ Subtotal";
            // 
            // txtCan
            // 
            this.txtCan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtCan.Location = new System.Drawing.Point(270, 19);
            this.txtCan.Multiline = true;
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(123, 34);
            this.txtCan.TabIndex = 164;
            this.txtCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(186, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 178;
            this.label8.Text = "$ Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(139)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(162, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 163;
            this.label5.Text = "Cantidad";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(185)))), ((int)(((byte)(243)))));
            this.txtSubtotal.Location = new System.Drawing.Point(269, 57);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(124, 34);
            this.txtSubtotal.TabIndex = 166;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridArticulosAVender
            // 
            this.gridArticulosAVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulosAVender.Location = new System.Drawing.Point(45, 49);
            this.gridArticulosAVender.Name = "gridArticulosAVender";
            this.gridArticulosAVender.Size = new System.Drawing.Size(45, 151);
            this.gridArticulosAVender.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(1, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 49);
            this.panel1.TabIndex = 197;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(31, 33);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(363, 422);
            this.groupBox7.TabIndex = 198;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "OPCION DEL COMBO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGULAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(36, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 95);
            this.button3.TabIndex = 0;
            this.button3.Text = "GRANDE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(189, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 95);
            this.button4.TabIndex = 0;
            this.button4.Text = "AÑADIR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(189, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 95);
            this.button6.TabIndex = 0;
            this.button6.Text = "QUITAR";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(36, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 95);
            this.button2.TabIndex = 0;
            this.button2.Text = "MEDIANO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1356, 719);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrivArticulo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosAVender)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.RadioButton radioAlContado;
        private System.Windows.Forms.RadioButton radioACredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboMedioPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboProv;
        private System.Windows.Forms.DateTimePicker dateFechaVencimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGrivCliente;
        private System.Windows.Forms.Label lblCri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GrivArticulo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnBuscarArticulo;
        private System.Windows.Forms.DataGridView gridArticulosAVender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarArticulo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox checkDescuento;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItbis;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox textArticuloCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCuadre;
        private System.Windows.Forms.Button btnVentaNew;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
    }