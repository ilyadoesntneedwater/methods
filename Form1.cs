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


namespace методы
{
    public partial class Form1 : Form
    {
        //string file1 = @"C:\Users\ILYA\Desktop\1.txt";
        //string file0 = @"C:\Users\ILYA\Desktop\0.txt";
        public Form1()
        {
            //InitializeComponent();

            //string word1 = "Word";
            //string word2 = "Is";
            //string word3 = "Word";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Word";
            //Method();
            //label1.Text = Location.ToString();
            //label1.Text = Method();
            //if (File.Exists(@"C:\Users\ILYA\Desktop\1.txt"))
            //{
            //    //MessageBox.Show("Файл есть", "Есть ли файл", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    Method();
            //}
            //if (File.Exists(@"C:\Users\ILYA\Desktop\11.txt"))
            //{
            //    Method();
            //}
            //if (File.Exists(file1))
            //{
            //    Method("Файл есть");
            //}
            //else
            //{
            //    Method("Файла нет");
            //}
            //Method(File.Exists(@"C:\Users\ILYA\Desktop\1.txt") ? "Файл есть" : "Файла нет");
            //if (File.Exists(file0))
            //{
            //    Method1();
            //}
            //else
            //{
            //    Method2();
            //}


            ////string Method()
            //{
            //    //label1.Text = "Word ";
            //    //return Location.ToString();

            //}
            //Method("Сообщение", "Заголовок");


            label1.Text = Slovo();
        }
        //Method(string message, string header)

        //MessageBox.Show("Файл есть", "Есть ли файл", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        //void Method2()
        //{
        //    MessageBox.Show("Файла нет", "Есть ли файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        string Slovo()
        {

            string word1 = "";
            string word2 = "Is";
            string word3 = "Word";
            return $"{word1} {word2} {word3}";
        }
    }
}










