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
    public partial class FormAreaCalculation : Form
    {
        public FormAreaCalculation()
        {
            InitializeComponent();
        }
        private double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseTriangulo = double.Parse(textBoxBase.Text);
            double altura = double.Parse(textBoxAltura.Text);

            double area = CalcularAreaTriangulo(baseTriangulo, altura);

            labelResult.Text = $"Área: {area}";
        }
    }
}
