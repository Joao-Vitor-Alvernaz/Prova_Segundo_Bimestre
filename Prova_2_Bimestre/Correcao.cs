using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_2_Bimestre
{
    public partial class Correcao : Form
    {
        private char[] gabarito_Certo = new char[10];
        public Correcao(char[] a)
        {
            InitializeComponent();
            gabarito_Certo = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resumo();
        }
        private void Resumo()
        {
            //Caso resposta do gabarito estiver espaço dara erro!
            char[] gabarito_Ver = new char[10];
            try
            {
                gabarito_Ver[0] = Convert.ToChar(textBox1.Text.ToUpper());
                gabarito_Ver[1] = Convert.ToChar(textBox2.Text.ToUpper());
                gabarito_Ver[2] = Convert.ToChar(textBox3.Text.ToUpper());
                gabarito_Ver[3] = Convert.ToChar(textBox4.Text.ToUpper());
                gabarito_Ver[4] = Convert.ToChar(textBox5.Text.ToUpper());
                gabarito_Ver[5] = Convert.ToChar(textBox6.Text.ToUpper());
                gabarito_Ver[6] = Convert.ToChar(textBox7.Text.ToUpper());
                gabarito_Ver[7] = Convert.ToChar(textBox8.Text.ToUpper());
                gabarito_Ver[8] = Convert.ToChar(textBox9.Text.ToUpper());
                gabarito_Ver[9] = Convert.ToChar(textBox10.Text.ToUpper());

                int acertos = 0;
                for (int i = 0; i < gabarito_Ver.Length; i++)
                {
                    if (gabarito_Ver[i] == gabarito_Certo[i])
                    {
                        acertos++;
                    }
                }
                label_Acertos.Text = ($"Acertos: {acertos}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo foi preenchido incorretamente!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
