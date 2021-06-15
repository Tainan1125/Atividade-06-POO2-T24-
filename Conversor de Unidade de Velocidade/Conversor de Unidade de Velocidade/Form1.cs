using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Unidade_de_Velocidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float c = 3.6f;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = 0;
            if(float.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Conversão feita com sucesso");

                float z = (x * c);

                label5.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a conversão, número inválido!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float y = 0;
            if (float.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Conversão feita com sucesso");

                float z2 = (y / c);

                label6.Text = z2.ToString();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a conversão, número inválido!");
            }

        }
    }
}
