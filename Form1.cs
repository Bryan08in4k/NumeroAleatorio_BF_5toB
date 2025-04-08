using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroAleatorio_BF_5toB
{
    public partial class Form1 : Form
    {
        int intentos = 0; // Inicializar la variable
        Random rand = new Random(); // Crea objeto que genere el número aleatorio 
        int aleatorio = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5;
            txt1.Text = intentos.ToString();
            aleatorio = rand.Next(1, 100); // aleatorio = número entre 1 a 100 
            MessageBox.Show($"{aleatorio}");
        }

        private void button1_click(object sender, EventArgs e)
        {
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt2.Text, out int num))
            {
                if (num == aleatorio)
                {
                    MessageBox.Show($"Ganó el juego. El número es {aleatorio}");
                    DialogResult resultado = MessageBox.Show("¿Quieres volver a jugar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txt1.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 100);
                    }

                }
                if (num > aleatorio)
                {
                    MessageBox.Show($"{num} es mayor al número aleatorio");
                    intentos = intentos - 1;
                    txt1.Text = intentos.ToString();
                }
                if (num < aleatorio)
                {
                    MessageBox.Show($"{num} es menor al número aleatorio");
                    intentos--; // Es lo mismo que intentos = intentos - 1; 
                    txt1.Text = intentos.ToString();
                }
                if (intentos == 0)
                {
                    DialogResult resultadp = MessageBox.Show("Se acabaron los intentos :c ¿Quieres volver a intenarlo","Game over",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                    if (resultado == DialogResult.No) 
                    {
                        MessageBox.Show("Suerte para la proxima");
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número valido");
            }

        }
    }
}
