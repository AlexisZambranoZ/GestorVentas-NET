using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double precio = 0;


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");

  

            // Agregar las columnas al control ListView
            lvVenta.Columns.Add("Producto");
            lvVenta.Columns.Add("Cantidad");
            lvVenta.Columns.Add("Precio");
            lvVenta.Columns.Add("Precio Unitario");
            lvVenta.Columns.Add("Hora");
            lvVenta.Columns.Add("Descripcion");
            lvVenta.Columns[5].Width = 200; 
            // Ajustar el ancho de la quinta columna a 200 píxeles
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
       

        }

        private void txtboxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Variables opcionales con valores predeterminados
            string producto = string.Empty;
            double precioProducto = 0;
            int cantidad = 0;
            string descripcion = string.Empty;

            // Verificar si se han proporcionado valores en los campos de entrada
            if (!string.IsNullOrEmpty(txtBoxProducto.Text))
                producto = txtBoxProducto.Text;

            if (!string.IsNullOrEmpty(txtBoxPrecio.Text))
                precioProducto = double.Parse(txtBoxPrecio.Text);

            if (!string.IsNullOrEmpty(txtboxCantidad.Text))
                cantidad = int.Parse(txtboxCantidad.Text);

            if (!string.IsNullOrEmpty(txtBoxDesc.Text))
                descripcion = txtBoxDesc.Text;

            // Calcular el precio total del producto
            double precioTotalProducto = precioProducto * cantidad;

            // Actualizar el precio total
            precio += precioTotalProducto;
            lblPrecio.Text = precio.ToString("C");

            // Obtener la hora actual
            DateTime horaActual = DateTime.Now;

            // Agregar los valores a la lista
            ListViewItem item = new ListViewItem(producto);
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(precioTotalProducto.ToString("C"));
            lvVenta.Items.Add(item);
            item.SubItems.Add(precioProducto.ToString("C"));
            item.SubItems.Add(horaActual.ToString("HH:mm:ss")); // Agregar la hora actual
            item.SubItems.Add(descripcion);


            // Limpiar los campos de entrada después de agregar el producto
            txtBoxProducto.Text = string.Empty;
            txtBoxPrecio.Text = string.Empty;
            txtboxCantidad.Text = string.Empty;
            txtBoxDesc.Text = string.Empty;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            // Limpiar los campos de entrada y restablecer el precio total
            txtBoxProducto.Text = string.Empty;
            txtBoxPrecio.Text = string.Empty;
            txtboxCantidad.Text = string.Empty;
            precio = 0;
            lblPrecio.Text = precio.ToString("C");

            // Limpiar la lista
            lvVenta.Items.Clear();

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Detener el programa y cerrar la aplicación
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

     
    }
}
