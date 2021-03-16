using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular x = new Calcular();
            double radio = double.Parse(textBox1.Text);
            double circunferencia = x.Circunferencia(radio);
            double area = x.Area(radio);
            MessageBox.Show("Circunferencia del circulo: " + circunferencia + "\n" + "Area del circulo: " + area,
                "Circunferencia y Area de un Circulo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
