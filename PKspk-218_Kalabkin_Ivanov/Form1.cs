using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKspk_218_Kalabkin_Ivanov
{
        
        public partial class Form1 : Form
    {
        public class Globals
        {
            public static int nm = 0, m;
            public static double delimoe = 0;

            public static double[] mas = new double[90];

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            double  n = (double)numericUpDown1.Value;
            Globals.delimoe = (int)numericUpDown1.Value;
            if (n == 0)
            {
                MessageBox.Show("Вы ввели ноль или отрицательное число, введите натуральное число! Например:1,2,3,4...");
                label1.Text = "Вы ввели ноль или отрицательное число, пожалуйста вводите числа больше нуля!";
                numericUpDown1.Value = 1;
                return;
            }
            Globals.nm = 0;
            Globals.m = 0;
            double s=0, lol = 0, sum = 0;
            if(n%1!=0)
            {
                MessageBox.Show("Программа не работает с дробными числами, введите натуральное число! Например:1,2,3,4....");
                label1.Text = "Дробные числа не являются натуральными, пожалуйста введите натурально число!";
                return;
            }

            for (int i = 1; i <= n; i++)
            {
         
                s = n / i;
                if (s % 1 == 0)
                {
                    if (n % s == 0)
                    {

                        if (s != lol)
                        {

                            Globals.mas[Globals.m] = s;
                            Globals.nm++;
                            sum += s;
                            lol = s;
                            Globals.m++;


                        }
                    }
                }
            }
            string RSAKey;
            if (Globals.m > 0)
            {
                RSAKey = "\n---------------------------------------\nОбщая сумма делителей: " + sum +";"+ "\nКоличество делителей:  " + Globals.nm +" ;" + "\nДелимое: " + n;
                richTextBox1.Text += RSAKey;
            }
            n = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Natural_Chisla". При необходимости она может быть перемещена или удалена.
            this.natural_ChislaTableAdapter.Fill(this.dataSet1.Natural_Chisla);
            label1.Text = "";

        }

        private void delim_chisloTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delitelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string progressbar;
            double RSAKey;
            double delimoe, k = 0;
            if (Globals.m > 0) 
            { 
                progressbar = "\n---------------------------------------\nЗаполнение таблицы...";
                richTextBox1.Text += progressbar;
            }
            else
            {
                progressbar = "\nВы не ввели натуральное число!";
                richTextBox1.Text += progressbar;
            }
            for (int i = 0; i < Globals.m; i++)
            {
                k++;
                natural_ChislaBindingSource.AddNew();
                RSAKey = Globals.mas[i];
                delitelTextBox.Text = RSAKey.ToString();
                delimoe = Globals.delimoe;
                delim_chisloTextBox.Text = delimoe.ToString();
                natural_ChislaBindingSource.EndEdit();
                natural_ChislaTableAdapter.Update(dataSet1);
            }
            if (Globals.m > 0)
            {
                progressbar = "\nТаблица заполнена, добавлено записей в таблицу: " + k + " ;";
                richTextBox1.Text += progressbar.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            string cs;
            cs = "\n---------------------------------------\nТаблица очищена ";
            richTextBox1.Text += cs.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value % 1 == 0)
            {
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.ThousandsSeparator = true;
            }
            else
            {
                numericUpDown1.DecimalPlaces = 2;
                numericUpDown1.ThousandsSeparator = true;
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Нажимать только после вывода!";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Убедитесь, что ввели натуральное число";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
