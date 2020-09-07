using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversi_suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonconvert(object sender, EventArgs e)
        {
            double celcius;
            double reamur;
            double fahrenheit;
            double kelvin;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            if (comboBox1.SelectedItem == "Celcius")
            {
                celcius = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked == true)
                    textBox2.Text = celcius.ToString();

                if (checkBox2.Checked == true)
                {
                    reamur = 4 / 5.0 * celcius;
                    textBox3.Text = reamur.ToString();
                }
                if (checkBox3.Checked == true)
                {
                    fahrenheit = 9 / 5.0 * celcius + 32;
                    textBox4.Text = fahrenheit.ToString();
                }
                if (checkBox4.Checked == true)
                {
                    kelvin = celcius + 273;
                    textBox5.Text = kelvin.ToString();
                }
            }

            if (comboBox1.SelectedItem == "Reamur")
            {
                reamur = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked == true)
                {
                    celcius = 5 / 4.0 * reamur;
                    textBox2.Text = celcius.ToString();
                }
                if (checkBox2.Checked == true)
                    textBox3.Text = reamur.ToString();

                if (checkBox3.Checked == true)
                {
                    fahrenheit = 9 / 4.0 * reamur + 32;
                    textBox4.Text = fahrenheit.ToString();
                }
                if (checkBox4.Checked == true)
                {
                    kelvin = 5 / 4.0 * reamur + 273;
                    textBox5.Text = kelvin.ToString();
                }
            }
            if (comboBox1.SelectedItem == "Fahrenheit")
            {
                fahrenheit = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked == true)
                {
                    celcius = 5 / 9.0 * (fahrenheit - 32);
                    textBox2.Text = celcius.ToString();
                }
                if (checkBox2.Checked == true)
                {
                    reamur = 4 / 9.0 * (fahrenheit - 32);
                    textBox3.Text = reamur.ToString();
                }

                if (checkBox3.Checked == true)
                {
                    textBox4.Text = fahrenheit.ToString();
                }
                if (checkBox4.Checked == true)
                {
                    kelvin = 5 / 9.0 * (fahrenheit - 32) + 273;
                    textBox5.Text = kelvin.ToString();
                }
            }

            if (comboBox1.SelectedItem == "Kelvin")
            {
                kelvin = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked == true)
                {
                    celcius = kelvin - 273;
                    textBox2.Text = celcius.ToString();
                }
                if (checkBox2.Checked == true)
                {
                    reamur = 4 / 5.0 * (kelvin - 273);
                    textBox3.Text = reamur.ToString();
                }
                if (checkBox3.Checked == true)
                {
                    fahrenheit = 9 / 5.0 * (kelvin - 273) + 32;
                    textBox4.Text = fahrenheit.ToString();
                }
                if (checkBox4.Checked == true)
                    textBox5.Text = kelvin.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonreset(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void buttonexit(object sender, EventArgs e)
        {
            DialogResult keluar = MessageBox.Show("Yakin ingin keluar?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (keluar == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

    }
}
    
