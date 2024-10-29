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
    }
}
