using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zpracovat_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            string prijmeni = textBox2.Text;
            int vek = Convert.ToInt32(numericUpDown1.Value);
            int odpadky = Convert.ToInt32(numericUpDown1.Value);
            Clovek clovek1 = new Clovek(textBox1.Text,textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            Clovek clovek2 = new Clovek(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            clovek1.VyhodOdpadky(odpadky);
            clovek1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uklizecka uklizecka1 = new Uklizecka(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            uklizecka1.DejSacek();
            uklizecka1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uklizecka uklizecka1 = new Uklizecka(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            Uklizecka uklizecka2 = new Uklizecka(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            uklizecka1.VynesKos();
            uklizecka1.ToString();
        }
    }
}
