
using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double wartosc;
        private string operacja = " ";
        bool operacja_wcisniety = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //przypisanie przycisków do ich wartości 
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operacja_wcisniety))
                textBox1.Clear();
            
            operacja_wcisniety = false;
            Button b = (Button)sender;

        //brak mozliwosci wpisywania wielu przecinkow
            if (b.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + b.Text;
            }
            else
             textBox1.Text = textBox1.Text + b.Text; //wyswietlanie
             label2.Focus();
        }

        private void Czyszczacy_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            wartosc = 0;
            label1.Text = "";
            operacja = "";
            label2.Focus();
        }


        private void Zerujacy_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            label2.Focus();
        }

        private void operacja_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (wartosc != 0)
            {
                button12.PerformClick();
                operacja_wcisniety = true;
                operacja = b.Text;
                label1.Text = wartosc + " " + operacja;
                 
            }
            else
            {
                operacja = b.Text;
                try
                {
                    wartosc = Double.Parse(textBox1.Text);
                }
                catch
                {
                    textBox1.Text = "Błąd! Naciśnij C i spróbuj jeszcze raz wpisać liczbę.";
                    return;
                }

                operacja_wcisniety = true;
                label1.Text = wartosc + " " + operacja;
            }
            label2.Focus();

        }

        private void wynik_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            switch (operacja)
            {
                case "+":
                    textBox1.Text = (wartosc + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (wartosc - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (wartosc * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Nie dziel przez zero";
                        return;
                    }
                    else
                    {
                        textBox1.Text = (wartosc / Double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                    default:
                    break;
            }

                    try
                    {
                        wartosc = Double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        textBox1.Text = "Błąd! Naciśnij C i spróbuj jeszcze raz wpisać liczbę.";
                    }
                    operacja = "";
                    label2.Focus();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.Add:
                    button13.PerformClick();
                    break;
                case Keys.Subtract:
                    button14.PerformClick();
                    break;
                case Keys.Multiply:
                    button15.PerformClick();
                    break;
                case Keys.Divide:
                    button16.PerformClick();
                    break;
                case Keys.Decimal:
                    button18.PerformClick();
                    break;
                case Keys.Enter:
                   button12.PerformClick();
                    break;
            }

        }

        private void zmienSkorkeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void starWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StarW;
            ForeColor = Color.DarkRed;
            textBox1.BackColor = Color.Silver;
            label1.BackColor = Color.Silver;
        }

        private void myszkaMikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Myszka;
            ForeColor = Color.Purple;
            textBox1.BackColor = Color.PeachPuff;
            label1.BackColor = Color.PeachPuff;
        }

        private void krainaLoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.KrainaLodu;
            ForeColor = Color.MediumBlue;
            textBox1.BackColor = Color.LightSteelBlue;
            label1.BackColor = Color.LightSteelBlue;
        }

        private void KlasycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.klasyk;
            ForeColor = Color.Black;
            textBox1.BackColor = Color.Silver;
            label1.BackColor = Color.Silver;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Tahoma", 9, FontStyle.Bold);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Modern No.20", 16, FontStyle.Bold);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void Zegar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Obraz_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}


