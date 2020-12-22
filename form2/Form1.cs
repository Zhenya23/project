using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        string info;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Clear();
                FindWord findWord = new FindWord() { Path_to_File = textBox1.Text, Finding_word = textBox2.Text };
                await Task.Run(() =>
                {
                    info = findWord.Find_in_Directory();
                });
                textBox3.Text += info;

            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {

                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
