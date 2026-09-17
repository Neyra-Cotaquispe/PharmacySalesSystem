namespace PharmacySalesSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            // ── Declaración de controles ──────────────────────────────
            this.lblTitulo          = new System.Windows.Forms.Label();

            // Sección Izquierda – Productos
            this.lblSeccion1        = new System.Windows.Forms.Label();
            this.lblCodigo          = new System.Windows.Forms.Label();
            this.txtCodigo          = new System.Windows.Forms.TextBox();
            this.lblNombreProducto  = new System.Windows.Forms.Label();
            this.txtNombreProducto  = new System.Windows.Forms.TextBox();
            this.lblCategoria       = new System.Windows.Forms.Label();
            this.txtCategoria       = new System.Windows.Forms.TextBox();
            this.lblPrecio          = new System.Windows.Forms.Label();
            this.txtPrecio          = new System.Windows.Forms.TextBox();
            this.lblStock           = new System.Windows.Forms.Label();
            this.txtStock           = new System.Windows.Forms.TextBox();
            this.lblCantidad        = new System.Windows.Forms.Label();
            this.txtCantidad        = new System.Windows.Forms.TextBox();
            this.btnRegistrar       = new System.Windows.Forms.Button();
            this.btnBuscar          = new System.Windows.Forms.Button();
            this.btnMostrar         = new System.Windows.Forms.Button();
            this.btnAgregar         = new System.Windows.Forms.Button();

            // Sección Central – Venta Activa
            this.lblVentaActiva     = new System.Windows.Forms.Label();
            this.dgvVenta           = new System.Windows.Forms.DataGridView();
            this.btnEliminar        = new System.Windows.Forms.Button();

            // Sección Derecha – Cliente y Pago
            this.lblSeccion3        = new System.Windows.Forms.Label();
            this.lblNombreCliente   = new System.Windows.Forms.Label();
            this.txtNombreCliente   = new System.Windows.Forms.TextBox();
            this.lblTelefono        = new System.Windows.Forms.Label();
            this.txtTelefono        = new System.Windows.Forms.TextBox();
            this.lblNumReceta       = new System.Windows.Forms.Label();
            this.txtNumReceta       = new System.Windows.Forms.TextBox();
            this.lblDoctor          = new System.Windows.Forms.Label();
            this.txtDoctor          = new System.Windows.Forms.TextBox();
            this.lblSubtotal        = new System.Windows.Forms.Label();
            this.txtSubtotal        = new System.Windows.Forms.TextBox();
            this.lblIGV             = new System.Windows.Forms.Label();
            this.txtIGV             = new System.Windows.Forms.TextBox();
            this.lblTotalLabel      = new System.Windows.Forms.Label();
            this.txtTotal           = new System.Windows.Forms.TextBox();
            this.lblEfectivo        = new System.Windows.Forms.Label();
            this.txtEfectivo        = new System.Windows.Forms.TextBox();
            this.lblCambio          = new System.Windows.Forms.Label();
            this.txtCambio          = new System.Windows.Forms.TextBox();
            this.btnCalcularCambio  = new System.Windows.Forms.Button();

            // Botones inferiores principales
            this.btnTotal           = new System.Windows.Forms.Button();
            this.btnImprimir        = new System.Windows.Forms.Button();
            this.btnNuevaVenta      = new System.Windows.Forms.Button();
            this.btnSalir           = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();

            // ── lblTitulo ────────────────────────────────────────────
            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location  = new System.Drawing.Point(10, 12);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(950, 38);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "PHARMACY SALES MANAGEMENT SYSTEM";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblSeccion1 (Encabezado Productos) ──────────────────
            this.lblSeccion1.AutoSize  = false;
            this.lblSeccion1.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSeccion1.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccion1.ForeColor = System.Drawing.Color.White;
            this.lblSeccion1.Location  = new System.Drawing.Point(10, 58);
            this.lblSeccion1.Name      = "lblSeccion1";
            this.lblSeccion1.Size      = new System.Drawing.Size(275, 22);
            this.lblSeccion1.TabIndex  = 1;
            this.lblSeccion1.Text      = "SELECCIÓN DE PRODUCTOS Y CATEGORÍAS";
            this.lblSeccion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblCodigo ────────────────────────────────────────────
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 95);
            this.lblCodigo.Name     = "lblCodigo";
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text     = "Código:";

            // ── txtCodigo ────────────────────────────────────────────
            this.txtCodigo.Location = new System.Drawing.Point(105, 92);
            this.txtCodigo.Name     = "txtCodigo";
            this.txtCodigo.Size     = new System.Drawing.Size(178, 23);
            this.txtCodigo.TabIndex = 3;

            // ── lblNombreProducto ────────────────────────────────────
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 125);
            this.lblNombreProducto.Name     = "lblNombreProducto";
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text     = "Nombre:";

            // ── txtNombreProducto ────────────────────────────────────
            this.txtNombreProducto.Location = new System.Drawing.Point(105, 122);
            this.txtNombreProducto.Name     = "txtNombreProducto";
            this.txtNombreProducto.Size     = new System.Drawing.Size(178, 23);
            this.txtNombreProducto.TabIndex = 5;

            // ── lblCategoria ─────────────────────────────────────────
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 155);
            this.lblCategoria.Name     = "lblCategoria";
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text     = "Categoría:";

            // ── txtCategoria ─────────────────────────────────────────
            this.txtCategoria.Location = new System.Drawing.Point(105, 152);
            this.txtCategoria.Name     = "txtCategoria";
            this.txtCategoria.Size     = new System.Drawing.Size(178, 23);
            this.txtCategoria.TabIndex = 7;

            // ── lblPrecio ────────────────────────────────────────────
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 185);
            this.lblPrecio.Name     = "lblPrecio";
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text     = "Precio S/.";

            // ── txtPrecio ────────────────────────────────────────────
            this.txtPrecio.Location = new System.Drawing.Point(105, 182);
            this.txtPrecio.Name     = "txtPrecio";
            this.txtPrecio.Size     = new System.Drawing.Size(178, 23);
            this.txtPrecio.TabIndex = 9;

            // ── lblStock ─────────────────────────────────────────────
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 215);
            this.lblStock.Name     = "lblStock";
            this.lblStock.TabIndex = 10;
            this.lblStock.Text     = "Stock:";

            // ── txtStock ─────────────────────────────────────────────
            this.txtStock.Location = new System.Drawing.Point(105, 212);
            this.txtStock.Name     = "txtStock";
            this.txtStock.Size     = new System.Drawing.Size(178, 23);
            this.txtStock.TabIndex = 11;

            // ── lblCantidad ──────────────────────────────────────────
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 245);
            this.lblCantidad.Name     = "lblCantidad";
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text     = "Cantidad:";

            // ── txtCantidad ──────────────────────────────────────────
            this.txtCantidad.Location = new System.Drawing.Point(105, 242);
            this.txtCantidad.Name     = "txtCantidad";
            this.txtCantidad.Size     = new System.Drawing.Size(178, 23);
            this.txtCantidad.TabIndex = 13;

            // ── btnRegistrar ─────────────────────────────────────────
            this.btnRegistrar.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location  = new System.Drawing.Point(10, 278);
            this.btnRegistrar.Name      = "btnRegistrar";
            this.btnRegistrar.Size      = new System.Drawing.Size(135, 30);
            this.btnRegistrar.TabIndex  = 14;
            this.btnRegistrar.Text      = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click    += new System.EventHandler(this.btnRegistrar_Click);

            // ── btnBuscar ────────────────────────────────────────────
            this.btnBuscar.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location  = new System.Drawing.Point(150, 278);
            this.btnBuscar.Name      = "btnBuscar";
            this.btnBuscar.Size      = new System.Drawing.Size(135, 30);
            this.btnBuscar.TabIndex  = 15;
            this.btnBuscar.Text      = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click    += new System.EventHandler(this.btnBuscar_Click);

            // ── btnMostrar ───────────────────────────────────────────
            this.btnMostrar.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.Location  = new System.Drawing.Point(10, 318);
            this.btnMostrar.Name      = "btnMostrar";
            this.btnMostrar.Size      = new System.Drawing.Size(135, 30);
            this.btnMostrar.TabIndex  = 16;
            this.btnMostrar.Text      = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click    += new System.EventHandler(this.btnMostrar_Click);

            // ── btnAgregar ───────────────────────────────────────────
            this.btnAgregar.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location  = new System.Drawing.Point(150, 318);
            this.btnAgregar.Name      = "btnAgregar";
            this.btnAgregar.Size      = new System.Drawing.Size(135, 30);
            this.btnAgregar.TabIndex  = 17;
            this.btnAgregar.Text      = "Agregar a Venta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click    += new System.EventHandler(this.btnAgregar_Click);

            // ── lblVentaActiva (Encabezado Centro) ───────────────────
            this.lblVentaActiva.AutoSize  = false;
            this.lblVentaActiva.BackColor = System.Drawing.Color.SteelBlue;
            this.lblVentaActiva.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblVentaActiva.ForeColor = System.Drawing.Color.White;
            this.lblVentaActiva.Location  = new System.Drawing.Point(295, 58);
            this.lblVentaActiva.Name      = "lblVentaActiva";
            this.lblVentaActiva.Size      = new System.Drawing.Size(370, 22);
            this.lblVentaActiva.TabIndex  = 18;
            this.lblVentaActiva.Text      = "LISTA DE VENTA ACTIVA";
            this.lblVentaActiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── dgvVenta ─────────────────────────────────────────────
            this.dgvVenta.AllowUserToAddRows    = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.Location      = new System.Drawing.Point(295, 84);
            this.dgvVenta.Name          = "dgvVenta";
            this.dgvVenta.ReadOnly      = true;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size          = new System.Drawing.Size(370, 300);
            this.dgvVenta.TabIndex      = 19;

            // ── btnEliminar ──────────────────────────────────────────
            this.btnEliminar.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location  = new System.Drawing.Point(295, 392);
            this.btnEliminar.Name      = "btnEliminar";
            this.btnEliminar.Size      = new System.Drawing.Size(370, 30);
            this.btnEliminar.TabIndex  = 20;
            this.btnEliminar.Text      = "Eliminar Producto de la Venta";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click    += new System.EventHandler(this.btnEliminar_Click);

            // ── lblSeccion3 (Encabezado Derecha) ─────────────────────
            this.lblSeccion3.AutoSize  = false;
            this.lblSeccion3.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSeccion3.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccion3.ForeColor = System.Drawing.Color.White;
            this.lblSeccion3.Location  = new System.Drawing.Point(675, 58);
            this.lblSeccion3.Name      = "lblSeccion3";
            this.lblSeccion3.Size      = new System.Drawing.Size(285, 35);
            this.lblSeccion3.TabIndex  = 21;
            this.lblSeccion3.Text      = "INFORMACIÓN DEL CLIENTE Y RECETA / PAGO";
            this.lblSeccion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblNombreCliente ─────────────────────────────────────
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(677, 100);
            this.lblNombreCliente.Name     = "lblNombreCliente";
            this.lblNombreCliente.TabIndex = 22;
            this.lblNombreCliente.Text     = "Nombre del Cliente";

            // ── txtNombreCliente ─────────────────────────────────────
            this.txtNombreCliente.Location = new System.Drawing.Point(815, 97);
            this.txtNombreCliente.Name     = "txtNombreCliente";
            this.txtNombreCliente.Size     = new System.Drawing.Size(143, 23);
            this.txtNombreCliente.TabIndex = 23;

            // ── lblTelefono ──────────────────────────────────────────
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(677, 130);
            this.lblTelefono.Name     = "lblTelefono";
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text     = "Teléfono";

            // ── txtTelefono ──────────────────────────────────────────
            this.txtTelefono.Location = new System.Drawing.Point(815, 127);
            this.txtTelefono.Name     = "txtTelefono";
            this.txtTelefono.Size     = new System.Drawing.Size(143, 23);
            this.txtTelefono.TabIndex = 25;

            // ── lblNumReceta ─────────────────────────────────────────
            this.lblNumReceta.AutoSize = true;
            this.lblNumReceta.Location = new System.Drawing.Point(677, 160);
            this.lblNumReceta.Name     = "lblNumReceta";
            this.lblNumReceta.TabIndex = 26;
            this.lblNumReceta.Text     = "No. Receta";

            // ── txtNumReceta ─────────────────────────────────────────
            this.txtNumReceta.Location = new System.Drawing.Point(815, 157);
            this.txtNumReceta.Name     = "txtNumReceta";
            this.txtNumReceta.Size     = new System.Drawing.Size(143, 23);
            this.txtNumReceta.TabIndex = 27;

            // ── lblDoctor ────────────────────────────────────────────
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(677, 190);
            this.lblDoctor.Name     = "lblDoctor";
            this.lblDoctor.TabIndex = 28;
            this.lblDoctor.Text     = "Nombre del Doctor";

            // ── txtDoctor ────────────────────────────────────────────
            this.txtDoctor.Location = new System.Drawing.Point(815, 187);
            this.txtDoctor.Name     = "txtDoctor";
            this.txtDoctor.Size     = new System.Drawing.Size(143, 23);
            this.txtDoctor.TabIndex = 29;

            // ── lblSubtotal ──────────────────────────────────────────
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font     = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(677, 232);
            this.lblSubtotal.Name     = "lblSubtotal";
            this.lblSubtotal.TabIndex = 30;
            this.lblSubtotal.Text     = "SubTotal";

            // ── txtSubtotal ──────────────────────────────────────────
            this.txtSubtotal.BackColor  = System.Drawing.Color.LightYellow;
            this.txtSubtotal.Font       = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Location   = new System.Drawing.Point(815, 229);
            this.txtSubtotal.Name       = "txtSubtotal";
            this.txtSubtotal.ReadOnly   = true;
            this.txtSubtotal.Size       = new System.Drawing.Size(143, 23);
            this.txtSubtotal.TabIndex   = 31;
            this.txtSubtotal.TextAlign  = System.Windows.Forms.HorizontalAlignment.Right;

            // ── lblIGV ───────────────────────────────────────────────
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font     = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIGV.Location = new System.Drawing.Point(677, 262);
            this.lblIGV.Name     = "lblIGV";
            this.lblIGV.TabIndex = 32;
            this.lblIGV.Text     = "IGV (18%)";

            // ── txtIGV ───────────────────────────────────────────────
            this.txtIGV.BackColor  = System.Drawing.Color.LightYellow;
            this.txtIGV.Font       = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtIGV.Location   = new System.Drawing.Point(815, 259);
            this.txtIGV.Name       = "txtIGV";
            this.txtIGV.ReadOnly   = true;
            this.txtIGV.Size       = new System.Drawing.Size(143, 23);
            this.txtIGV.TabIndex   = 33;
            this.txtIGV.TextAlign  = System.Windows.Forms.HorizontalAlignment.Right;

            // ── lblTotalLabel ────────────────────────────────────────
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font     = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(677, 292);
            this.lblTotalLabel.Name     = "lblTotalLabel";
            this.lblTotalLabel.TabIndex = 34;
            this.lblTotalLabel.Text     = "Total";

            // ── txtTotal ─────────────────────────────────────────────
            this.txtTotal.BackColor  = System.Drawing.Color.LightGreen;
            this.txtTotal.Font       = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location   = new System.Drawing.Point(815, 289);
            this.txtTotal.Name       = "txtTotal";
            this.txtTotal.ReadOnly   = true;
            this.txtTotal.Size       = new System.Drawing.Size(143, 23);
            this.txtTotal.TabIndex   = 35;
            this.txtTotal.TextAlign  = System.Windows.Forms.HorizontalAlignment.Right;

            // ── lblEfectivo ──────────────────────────────────────────
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(677, 322);
            this.lblEfectivo.Name     = "lblEfectivo";
            this.lblEfectivo.TabIndex = 36;
            this.lblEfectivo.Text     = "Efectivo Recibido";

            // ── txtEfectivo ──────────────────────────────────────────
            this.txtEfectivo.Location  = new System.Drawing.Point(815, 319);
            this.txtEfectivo.Name      = "txtEfectivo";
            this.txtEfectivo.Size      = new System.Drawing.Size(143, 23);
            this.txtEfectivo.TabIndex  = 37;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // ── lblCambio ────────────────────────────────────────────
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(677, 352);
            this.lblCambio.Name     = "lblCambio";
            this.lblCambio.TabIndex = 38;
            this.lblCambio.Text     = "Cambio";

            // ── txtCambio ────────────────────────────────────────────
            this.txtCambio.BackColor  = System.Drawing.Color.LightCyan;
            this.txtCambio.Location   = new System.Drawing.Point(815, 349);
            this.txtCambio.Name       = "txtCambio";
            this.txtCambio.ReadOnly   = true;
            this.txtCambio.Size       = new System.Drawing.Size(143, 23);
            this.txtCambio.TabIndex   = 39;
            this.txtCambio.TextAlign  = System.Windows.Forms.HorizontalAlignment.Right;

            // ── btnCalcularCambio ────────────────────────────────────
            this.btnCalcularCambio.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCalcularCambio.Location  = new System.Drawing.Point(675, 382);
            this.btnCalcularCambio.Name      = "btnCalcularCambio";
            this.btnCalcularCambio.Size      = new System.Drawing.Size(285, 30);
            this.btnCalcularCambio.TabIndex  = 40;
            this.btnCalcularCambio.Text      = "Calcular Cambio";
            this.btnCalcularCambio.UseVisualStyleBackColor = true;
            this.btnCalcularCambio.Click    += new System.EventHandler(this.btnCalcularCambio_Click);

            // ── btnTotal (inferior) ───────────────────────────────────
            this.btnTotal.Font      = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnTotal.Location  = new System.Drawing.Point(10, 432);
            this.btnTotal.Name      = "btnTotal";
            this.btnTotal.Size      = new System.Drawing.Size(225, 50);
            this.btnTotal.TabIndex  = 41;
            this.btnTotal.Text      = "TOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click    += new System.EventHandler(this.btnTotal_Click);

            // ── btnImprimir ───────────────────────────────────────────
            this.btnImprimir.Font      = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Location  = new System.Drawing.Point(245, 432);
            this.btnImprimir.Name      = "btnImprimir";
            this.btnImprimir.Size      = new System.Drawing.Size(225, 50);
            this.btnImprimir.TabIndex  = 42;
            this.btnImprimir.Text      = "IMPRIMIR RECIBO";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click    += new System.EventHandler(this.btnImprimir_Click);

            // ── btnNuevaVenta ─────────────────────────────────────────
            this.btnNuevaVenta.Font      = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnNuevaVenta.Location  = new System.Drawing.Point(480, 432);
            this.btnNuevaVenta.Name      = "btnNuevaVenta";
            this.btnNuevaVenta.Size      = new System.Drawing.Size(225, 50);
            this.btnNuevaVenta.TabIndex  = 43;
            this.btnNuevaVenta.Text      = "NUEVA VENTA";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click    += new System.EventHandler(this.btnNuevaVenta_Click);

            // ── btnSalir ──────────────────────────────────────────────
            this.btnSalir.Font      = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location  = new System.Drawing.Point(715, 432);
            this.btnSalir.Name      = "btnSalir";
            this.btnSalir.Size      = new System.Drawing.Size(245, 50);
            this.btnSalir.TabIndex  = 44;
            this.btnSalir.Text      = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click    += new System.EventHandler(this.btnSalir_Click);

            // ── Form1 ────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(970, 495);
            this.Text                = "Pharmacy Sales Management System";
            this.Name                = "Form1";

            // Agregar controles al formulario
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSeccion1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblVentaActiva);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSeccion3);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNumReceta);
            this.Controls.Add(this.txtNumReceta);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.btnCalcularCambio);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnSalir);

            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Declaración de variables de los controles ────────────────
        private System.Windows.Forms.Label       lblTitulo;
        private System.Windows.Forms.Label       lblSeccion1;
        private System.Windows.Forms.Label       lblCodigo;
        private System.Windows.Forms.TextBox     txtCodigo;
        private System.Windows.Forms.Label       lblNombreProducto;
        private System.Windows.Forms.TextBox     txtNombreProducto;
        private System.Windows.Forms.Label       lblCategoria;
        private System.Windows.Forms.TextBox     txtCategoria;
        private System.Windows.Forms.Label       lblPrecio;
        private System.Windows.Forms.TextBox     txtPrecio;
        private System.Windows.Forms.Label       lblStock;
        private System.Windows.Forms.TextBox     txtStock;
        private System.Windows.Forms.Label       lblCantidad;
        private System.Windows.Forms.TextBox     txtCantidad;
        private System.Windows.Forms.Button      btnRegistrar;
        private System.Windows.Forms.Button      btnBuscar;
        private System.Windows.Forms.Button      btnMostrar;
        private System.Windows.Forms.Button      btnAgregar;
        private System.Windows.Forms.Label       lblVentaActiva;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button      btnEliminar;
        private System.Windows.Forms.Label       lblSeccion3;
        private System.Windows.Forms.Label       lblNombreCliente;
        private System.Windows.Forms.TextBox     txtNombreCliente;
        private System.Windows.Forms.Label       lblTelefono;
        private System.Windows.Forms.TextBox     txtTelefono;
        private System.Windows.Forms.Label       lblNumReceta;
        private System.Windows.Forms.TextBox     txtNumReceta;
        private System.Windows.Forms.Label       lblDoctor;
        private System.Windows.Forms.TextBox     txtDoctor;
        private System.Windows.Forms.Label       lblSubtotal;
        private System.Windows.Forms.TextBox     txtSubtotal;
        private System.Windows.Forms.Label       lblIGV;
        private System.Windows.Forms.TextBox     txtIGV;
        private System.Windows.Forms.Label       lblTotalLabel;
        private System.Windows.Forms.TextBox     txtTotal;
        private System.Windows.Forms.Label       lblEfectivo;
        private System.Windows.Forms.TextBox     txtEfectivo;
        private System.Windows.Forms.Label       lblCambio;
        private System.Windows.Forms.TextBox     txtCambio;
        private System.Windows.Forms.Button      btnCalcularCambio;
        private System.Windows.Forms.Button      btnTotal;
        private System.Windows.Forms.Button      btnImprimir;
        private System.Windows.Forms.Button      btnNuevaVenta;
        private System.Windows.Forms.Button      btnSalir;
    }
}
