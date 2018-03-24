using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaLiebreyLaTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tortuga t = new Tortuga();
            Liebre l = new Liebre();

            while(t.Lugar < 80 && l.Lugar < 80){
                t.Accion(t.Correr());
                l.Accion(l.Correr());

                textBox1.Text += "tortuga esta en metro " + t.Lugar + " y la liebre en el metro " + l.Lugar +"\r\n";
            }
            if(t.Lugar >= 80 && l.Lugar >= 80)
            {
                MessageBox.Show("Es un empate");
            }else if (t.Lugar >= 80)
            {
                MessageBox.Show("Gano la tortuga");
            }
            else if(l.Lugar>=80)
            {
                MessageBox.Show("Gano la liebre");
            }
            else
            {
                MessageBox.Show("no funciona bro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
