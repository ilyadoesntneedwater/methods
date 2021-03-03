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

namespace методы2
{
    public partial class Form1 : Form
    {
        //string word1 = "Word";
        // string word2 = "Is";
        //string word3 = "Word";
        string file = @"C:\Users\ILYA\Desktop\1.txt";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Slovo("Is");
            //if (Look(file) == true)
            //{
            //    label1.Text = Say(file, null);
            //}
            //else
            //{
            //    label1.Text = Say(file, "не ");
            //}
            label1.Text = Look(file) ? Say(file, null) : Say(file, "не ");
        }
        //string Slovo(string line)
        //{ 
        //return $"{word1} {line} {word3}";
        //}    
        bool Look(string line)
        {
            //if (File.Exists(line))
            //{
            //    return true;
            //}
            //else
            //{ 
            //return false;
            //}
            return File.Exists(line) ? true : false;
        }
        
        string Say(string line, string line2)
        {
            return $"Файл\n{line}\n{line2}существует";
        }    
    }

}
