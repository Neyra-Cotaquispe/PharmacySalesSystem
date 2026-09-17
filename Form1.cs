using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySalesSystem
{
    public partial class Form1 : Form
    {
        // Matrices para almacenar productos y ventas
        string[,] productos = new string[50, 5]; // [codigo, nombre, categoria, precio, stock]
        string[,] venta    = new string[50, 5];  // [codigo, nombre, cantidad, precioUnit, total]

        int filaProducto = -1;
        int filaVenta    = -1;

        public Form1()
        {
            InitializeComponent();

            // Configurar columnas del DataGridView de ventas
            dgvVenta.Columns.Add("colCodigo",   "Código");
            dgvVenta.Columns.Add("colProducto", "Producto");
            dgvVenta.Columns.Add("colCantidad", "Cantidad");
            dgvVenta.Columns.Add("colPrecio",   "Precio Unit.");
            dgvVenta.Columns.Add("colTotal",    "Total S/.");

            dgvVenta.Columns[0].Width = 60;
            dgvVenta.Columns[1].Width = 140;
            dgvVenta.Columns[2].Width = 60;
            dgvVenta.Columns[3].Width = 75;
            dgvVenta.Columns[4].Width = 75;
        }

        // ─────────────────────────────────────────────────────────────
        // REGISTRAR PRODUCTO
        // ─────────────────────────────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombreProducto.Text == "" ||
                txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Complete todos los campos para registrar el producto");
                return;
            }

            filaProducto = filaProducto + 1;

            if (filaProducto >= 50)
            {
                MessageBox.Show("Capacidad máxima alcanzada. No se pueden registrar más productos.");
                filaProducto = 49;
                return;
            }

            productos[filaProducto, 0] = txtCodigo.Text;
            productos[filaProducto, 1] = txtNombreProducto.Text;
            productos[filaProducto, 2] = txtCategoria.Text;
            productos[filaProducto, 3] = txtPrecio.Text;
            productos[filaProducto, 4] = txtStock.Text;

            MessageBox.Show("Producto registrado correctamente");

            txtCodigo.Text          = "";
            txtNombreProducto.Text  = "";
            txtCategoria.Text       = "";
            txtPrecio.Text          = "";
            txtStock.Text           = "";
        }

        // ─────────────────────────────────────────────────────────────
        // BUSCAR PRODUCTO POR CÓDIGO
        // ─────────────────────────────────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del producto a buscar");
                return;
            }

            string codigo    = txtCodigo.Text;
            int    pos       = 0;
            bool   encontrado = false;

            while (pos <= filaProducto)
            {
                if (codigo == productos[pos, 0])
                {
                    txtNombreProducto.Text = productos[pos, 1];
                    txtCategoria.Text      = productos[pos, 2];
                    txtPrecio.Text         = productos[pos, 3];
                    txtStock.Text          = productos[pos, 4];
                    encontrado = true;
                    MessageBox.Show("Producto encontrado");
                    break;
                }
                pos = pos + 1;
            }

            if (encontrado == false)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        // ─────────────────────────────────────────────────────────────
        // MOSTRAR TODOS LOS PRODUCTOS (INVENTARIO)
        // ─────────────────────────────────────────────────────────────
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (filaProducto == -1)
            {
                MessageBox.Show("No hay productos registrados en el inventario");
                return;
            }

            string lista = "===== INVENTARIO DE PRODUCTOS =====\n\n";
            lista = lista + "CÓD\tNOMBRE\t\tCATEGORÍA\tPRECIO\t\tSTOCK\n";
            lista = lista + "-----------------------------------------------------------\n";

            int i = 0;
            while (i <= filaProducto)
            {
                lista = lista + productos[i, 0] + "\t"
                              + productos[i, 1] + "\t\t"
                              + productos[i, 2] + "\t\t"
                              + "S/." + productos[i, 3] + "\t\t"
                              + productos[i, 4] + "\n";
                i = i + 1;
            }

            MessageBox.Show(lista, "Inventario de Productos");
        }

        // ─────────────────────────────────────────────────────────────
        // AGREGAR PRODUCTO A LA VENTA ACTIVA
        // ─────────────────────────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del producto");
                return;
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad a vender");
                return;
            }

            string codigo     = txtCodigo.Text;
            int    pos        = 0;
            bool   encontrado = false;

            while (pos <= filaProducto)
            {
                if (codigo == productos[pos, 0])
                {
                    encontrado = true;

                    int cantidad = int.Parse(txtCantidad.Text);
                    int stock    = int.Parse(productos[pos, 4]);

                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a cero");
                        return;
                    }

                    if (cantidad > stock)
                    {
                        MessageBox.Show("Stock insuficiente. Stock disponible: " + productos[pos, 4]);
                        return;
                    }

                    double precioUnit    = double.Parse(productos[pos, 3]);
                    double totalProducto = cantidad * precioUnit;

                    filaVenta = filaVenta + 1;
                    venta[filaVenta, 0] = productos[pos, 0];
                    venta[filaVenta, 1] = productos[pos, 1];
                    venta[filaVenta, 2] = txtCantidad.Text;
                    venta[filaVenta, 3] = productos[pos, 3];
                    venta[filaVenta, 4] = totalProducto.ToString("F2");

                    dgvVenta.Rows.Add(
                        venta[filaVenta, 0],
                        venta[filaVenta, 1],
                        venta[filaVenta, 2],
                        venta[filaVenta, 3],
                        venta[filaVenta, 4]
                    );

                    MessageBox.Show("Producto agregado a la venta");
                    txtCantidad.Text = "";
                    break;
                }
                pos = pos + 1;
            }

            if (encontrado == false)
            {
                MessageBox.Show("Producto no encontrado. Primero búsquelo por código.");
            }
        }

        // ─────────────────────────────────────────────────────────────
        // ELIMINAR PRODUCTO DE LA VENTA
        // ─────────────────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta activa");
                return;
            }

            if (dgvVenta.SelectedRows.Count > 0)
            {
                dgvVenta.Rows.Remove(dgvVenta.SelectedRows[0]);
                filaVenta = filaVenta - 1;

                // Limpiar totales al modificar la venta
                txtSubtotal.Text = "";
                txtIGV.Text      = "";
                txtTotal.Text    = "";
                txtCambio.Text   = "";

                MessageBox.Show("Producto eliminado de la venta");
            }
            else
            {
                MessageBox.Show("Seleccione una fila del producto a eliminar");
            }
        }

        // ─────────────────────────────────────────────────────────────
        // CALCULAR TOTAL (botón inferior principal)
        // ─────────────────────────────────────────────────────────────
        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta activa");
                return;
            }

            double subtotal = 0;
            int    i        = 0;

            while (i < dgvVenta.Rows.Count)
            {
                subtotal = subtotal + double.Parse(dgvVenta.Rows[i].Cells[4].Value.ToString());
                i = i + 1;
            }

            double igv   = subtotal * 0.18;
            double total = subtotal + igv;

            txtSubtotal.Text = subtotal.ToString("F2");
            txtIGV.Text      = igv.ToString("F2");
            txtTotal.Text    = total.ToString("F2");

            MessageBox.Show("Total calculado.\nIngrese el efectivo recibido y presione 'Calcular Cambio'.");
        }

        // ─────────────────────────────────────────────────────────────
        // CALCULAR CAMBIO
        // ─────────────────────────────────────────────────────────────
        private void btnCalcularCambio_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Primero presione el botón TOTAL");
                return;
            }

            if (txtEfectivo.Text == "")
            {
                MessageBox.Show("Ingrese el efectivo recibido");
                return;
            }

            double efectivo = double.Parse(txtEfectivo.Text);
            double total    = double.Parse(txtTotal.Text);

            if (efectivo < total)
            {
                MessageBox.Show("Efectivo insuficiente. Faltan: S/. " + (total - efectivo).ToString("F2"));
                txtCambio.Text = "0.00";
                return;
            }

            double cambio  = efectivo - total;
            txtCambio.Text = cambio.ToString("F2");
            MessageBox.Show("Cambio a devolver: S/. " + cambio.ToString("F2"));
        }

        // ─────────────────────────────────────────────────────────────
        // IMPRIMIR RECIBO
        // ─────────────────────────────────────────────────────────────
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta activa");
                return;
            }

            if (txtTotal.Text == "")
            {
                MessageBox.Show("Primero presione el botón TOTAL para calcular");
                return;
            }

            string recibo = "";
            recibo = recibo + "==========================================\n";
            recibo = recibo + "    PHARMACY SALES MANAGEMENT SYSTEM\n";
            recibo = recibo + "==========================================\n";
            recibo = recibo + "Cliente  : " + txtNombreCliente.Text + "\n";
            recibo = recibo + "Teléfono : " + txtTelefono.Text      + "\n";
            recibo = recibo + "Receta   : " + txtNumReceta.Text     + "\n";
            recibo = recibo + "Doctor   : " + txtDoctor.Text        + "\n";
            recibo = recibo + "------------------------------------------\n";
            recibo = recibo + "PRODUCTO\t\tCANT\tPRECIO\tTOTAL\n";
            recibo = recibo + "------------------------------------------\n";

            int i = 0;
            while (i < dgvVenta.Rows.Count)
            {
                recibo = recibo
                    + dgvVenta.Rows[i].Cells[1].Value.ToString() + "\t\t"
                    + dgvVenta.Rows[i].Cells[2].Value.ToString() + "\t"
                    + dgvVenta.Rows[i].Cells[3].Value.ToString() + "\t"
                    + dgvVenta.Rows[i].Cells[4].Value.ToString() + "\n";
                i = i + 1;
            }

            recibo = recibo + "------------------------------------------\n";
            recibo = recibo + "SubTotal       : S/. " + txtSubtotal.Text + "\n";
            recibo = recibo + "IGV (18%)      : S/. " + txtIGV.Text      + "\n";
            recibo = recibo + "TOTAL          : S/. " + txtTotal.Text    + "\n";
            recibo = recibo + "Efectivo Rec.  : S/. " + txtEfectivo.Text + "\n";
            recibo = recibo + "Cambio         : S/. " + txtCambio.Text   + "\n";
            recibo = recibo + "==========================================\n";
            recibo = recibo + "         ¡Gracias por su compra!\n";
            recibo = recibo + "==========================================";

            MessageBox.Show(recibo, "RECIBO DE VENTA");
        }

        // ─────────────────────────────────────────────────────────────
        // NUEVA VENTA
        // ─────────────────────────────────────────────────────────────
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea iniciar una nueva venta?\nSe limpiarán todos los datos actuales.",
                "Nueva Venta",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // Limpiar DataGridView y reiniciar fila
                dgvVenta.Rows.Clear();
                filaVenta = -1;

                // Limpiar matriz de venta
                int i = 0;
                while (i < 50)
                {
                    int j = 0;
                    while (j < 5)
                    {
                        venta[i, j] = "";
                        j = j + 1;
                    }
                    i = i + 1;
                }

                // Limpiar sección cliente
                txtNombreCliente.Text = "";
                txtTelefono.Text      = "";
                txtNumReceta.Text     = "";
                txtDoctor.Text        = "";

                // Limpiar sección pagos
                txtSubtotal.Text = "";
                txtIGV.Text      = "";
                txtTotal.Text    = "";
                txtEfectivo.Text = "";
                txtCambio.Text   = "";

                // Limpiar sección producto
                txtCodigo.Text         = "";
                txtNombreProducto.Text = "";
                txtCategoria.Text      = "";
                txtPrecio.Text         = "";
                txtStock.Text          = "";
                txtCantidad.Text       = "";

                MessageBox.Show("Nueva venta iniciada correctamente");
            }
        }

        // ─────────────────────────────────────────────────────────────
        // SALIR
        // ─────────────────────────────────────────────────────────────
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Salir",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
