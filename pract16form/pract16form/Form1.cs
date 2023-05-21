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
using System.Collections;

namespace pract16form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string loadedText = File.ReadAllText("numb.txt");
            Queue<int> positive = new Queue<int>();
            Queue<int> negaitive = new Queue<int>();

            foreach (string s in loadedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                int number = int.Parse(s);
                if (number >= 0) positive.Enqueue(number);
                else negaitive.Enqueue(number);
            }
            label1.Text = "положительные:" + string.Join(", ", positive);
            label2.Text = "отрицательнные:" +string.Join(", ", negaitive);

        }
    }
}
