using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tarea_gama
{
    public partial class Form1 : Form
    {
        double promedio;
        double notaCompletivoFinal;
        public Form1()
        {
            InitializeComponent();

            textBox5.ReadOnly = true;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNota2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "") return;

            double notaCompletivo = double.Parse(textBox6.Text);

            // 50% promedio + 50% completivo
            notaCompletivoFinal = (promedio * 0.50) + (notaCompletivo * 0.50);

            if (notaCompletivoFinal <= 69)
            {
                textBox7.Enabled = true;
                textBox8.Text = "Debe ir a extraordinario";
            }
            else
            {
                textBox8.Text = "APROBADO EN COMPLETIVO";
                textBox7.Enabled = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
         {
            if (textBox7.Text == "") return;

            double notaExtra = double.Parse(textBox7.Text);

            double notaExtraFinal = (promedio * 0.30) + (notaExtra * 0.70);

            if (notaExtraFinal <= 69)
            {
                textBox8.Text = "REPROBADO";
            }
            else if (notaExtraFinal > 69)
            {
                textBox8.Text = "APROBADO EN EXTRAORDINARIO";
            }
        }
       }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
       
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNota3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
              textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Debe ingresar las 4 notas");
                return;
            }

            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);

            promedio = (n1 + n2 + n3 + n4) / 4;
            textBox5.Text = promedio.ToString("0.00");

            if (promedio <= 69)
            {
                textBox6.Enabled = true;
                textBox8.Text = "Debe ir a completivo";
            }
            else
            {
                textBox8.Text = "APROBADO";
                textBox6.Enabled = false;
                textBox7.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }
    }
}
