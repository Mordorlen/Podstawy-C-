using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silnia
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pobieram stopień
            int stopien = Convert.ToInt32(Stopien.Text);
            int silnia = 1;
            for (int i = 1; i <= stopien; i++)
            {
                //oblicz silnie
                silnia = silnia * i;

            }
            //wyświetl wynik
            Wynik.Text = silnia.ToString();
        }
    }
}
