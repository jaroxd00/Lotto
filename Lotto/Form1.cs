using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{

    public partial class Form1 : Form
    {

        int[] twoje = new int[6];
        int[] numbers = new int[6];
        int[] tab = new int[52];
        int cena = 0;
        int wygrana = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Zapis


                twoje[0] = Convert.ToInt32(textBox1.Text);
                twoje[1] = Convert.ToInt32(textBox2.Text);
                twoje[2] = Convert.ToInt32(textBox3.Text);
                twoje[3] = Convert.ToInt32(textBox4.Text);
                twoje[4] = Convert.ToInt32(textBox5.Text);
                twoje[5] = Convert.ToInt32(textBox6.Text);

                int czy = 0;
                for(int i = 0; i < 6; i++)
                {
                    for(int j=i+1; j< 6; j++)
                    {
                        if (twoje[i] == twoje[j])
                        {
                            czy = 1;
                        }
                    }
                }

                for(int i = 0; i < 6; i++)
                {
                    if (twoje[i] < 1) { czy = 1; }
                    if (twoje[i] > 49) { czy = 1; }
                }

                if (czy == 0)
                {

                    cena += 4;
                    textBox13.Text = cena.ToString();


                    textBox1.BackColor = Color.FromKnownColor(KnownColor.Window);
                    textBox2.BackColor = Color.FromKnownColor(KnownColor.Window);
                    textBox3.BackColor = Color.FromKnownColor(KnownColor.Window);
                    textBox4.BackColor = Color.FromKnownColor(KnownColor.Window);
                    textBox5.BackColor = Color.FromKnownColor(KnownColor.Window);
                    textBox6.BackColor = Color.FromKnownColor(KnownColor.Window);

                    textBox7.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox8.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox9.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox10.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox11.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox12.BackColor = Color.FromKnownColor(KnownColor.Control);





                    //Losowanie
                    Random rand = new Random();


                    int r = 0;

                    for (int i = 0; i < 52; i++)
                    {
                        tab[i] = 0;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        r = rand.Next(1, 50);

                        if (tab[r] == 0)
                        {
                            numbers[i] = r;
                            tab[r] = 1;
                        }
                        else
                        {
                            i--;
                        }
                    }

                    Array.Sort(numbers);

                    textBox7.Text = numbers[0].ToString();
                    textBox8.Text = numbers[1].ToString();
                    textBox9.Text = numbers[2].ToString();
                    textBox10.Text = numbers[3].ToString();
                    textBox11.Text = numbers[4].ToString();
                    textBox12.Text = numbers[5].ToString();
                }
                else
                {
                    MessageBox.Show("Numery podane przez ciebie muszą się różnić i być w zakresie 1-49");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ile = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (twoje[i] == numbers[j])
                    {
                        ile++;
                        switch (i)
                        {
                            case 0:
                                textBox1.BackColor = Color.Yellow ;
                                break;
                            case 1:
                                textBox2.BackColor = Color.Yellow;
                                break;
                            case 2:
                                textBox3.BackColor = Color.Yellow;
                                break;
                            case 3:
                                textBox4.BackColor = Color.Yellow;
                                break;
                            case 4:
                                textBox5.BackColor = Color.Yellow;
                                break;
                            case 5:
                                textBox6.BackColor = Color.Yellow;
                                break;
                        }
                        switch (j)
                        {
                            case 0:
                                textBox7.BackColor = Color.Yellow;
                                break;
                            case 1:
                                textBox8.BackColor = Color.Yellow;
                                break;
                            case 2:
                                textBox9.BackColor = Color.Yellow;
                                break;
                            case 3:
                                textBox10.BackColor = Color.Yellow;
                                break;
                            case 4:
                                textBox11.BackColor = Color.Yellow;
                                break;
                            case 5:
                                textBox12.BackColor = Color.Yellow;
                                break;
                        }

                    }
                }
            }

            label4.Text = ile.ToString();

            

            switch (ile)
            {
                
                case 3:
                    wygrana += 10;
                    break;
                case 4:
                    wygrana += 100;
                    break;
                case 5:
                    wygrana += 3500;
                    break;
                case 6:
                    wygrana += 1000000;
                    break;
            }
            textBox14.Text = wygrana.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

            textBox1.BackColor = Color.FromKnownColor(KnownColor.Window);
            textBox2.BackColor = Color.FromKnownColor(KnownColor.Window);
            textBox3.BackColor = Color.FromKnownColor(KnownColor.Window);
            textBox4.BackColor = Color.FromKnownColor(KnownColor.Window);
            textBox5.BackColor = Color.FromKnownColor(KnownColor.Window);
            textBox6.BackColor = Color.FromKnownColor(KnownColor.Window);

            textBox7.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox8.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox9.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox10.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox11.BackColor = Color.FromKnownColor(KnownColor.Control);
            textBox12.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cennikIWygraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cennik cennik = new Cennik();
            cennik.Show();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
