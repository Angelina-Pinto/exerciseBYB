using exercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class FormProductsGrud : Form
    {
        public FormProductsGrud()
        {
            InitializeComponent();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            // Verifica si hay un elemento seleccionado en el ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtiene el primer item seleccionado
                ListViewItem itemSeleccionado = listView1.SelectedItems[0];

                // Obtiene el nombre del producto seleccionado
                string nombreProducto = itemSeleccionado.SubItems[0].Text; // Suponiendo que el nombre está en la primera columna

                // Elimina el producto de la lista
                EliminarProducto(nombreProducto);

                // Elimina el item del ListView
                listView1.Items.Remove(itemSeleccionado);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }

        private void EliminarProducto(string nombre)
        {
            // Busca el producto en la lista y lo elimina
            product productoAEliminar = product.ProductList.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (productoAEliminar != null)
            {
                product.ProductList.Remove(productoAEliminar);
            }
            else
            {
                MessageBox.Show("El producto no se encontró en la lista.");
            }
        }

        private void AddProductToListView(product product)
        {
            // Crear un ListViewItem con el nombre del producto
            ListViewItem item = new ListViewItem(product.Nombre);

            // Agregar subelementos: precio y fecha de creación
            item.SubItems.Add(product.Precio.ToString("C")); // Formatear como moneda
            item.SubItems.Add(product.FechaCreacion.ToShortDateString()); // Formato corto de fecha

            // Agregar el item al ListView
            listView1.Items.Add(item);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;  // Nombre del producto
            decimal precio;
            DateTime fechaCreacion;


            if (!decimal.TryParse(textBox2.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return; // Salir del método si el precio es inválido
            }

            if (!DateTime.TryParse(textBox3.Text, out fechaCreacion))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida.");
                return; // Salir del método si la fecha es inválida
            }

            product nuevoProducto = new product(nombre, precio, fechaCreacion);
            product.ProductList.Add(nuevoProducto);
            AddProductToListView(nuevoProducto);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtiene el primer item seleccionado
                ListViewItem itemSeleccionado = listView1.SelectedItems[0];

                // Obtiene el nombre del producto seleccionado
                string nombreProducto = itemSeleccionado.SubItems[0].Text; // Suponiendo que el nombre está en la primera columna

                // Elimina el producto de la lista
                EliminarProducto(nombreProducto);

                // Elimina el item del ListView
                listView1.Items.Remove(itemSeleccionado);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }
    }
}
