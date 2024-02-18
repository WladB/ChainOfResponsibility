using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chain_of_Responsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot();
            var operat = new Operator();
            var geek = new geek();

            bot.SetNext(operat).SetNext(geek);
            if (bot.Handle(textBox2.Text) != null)
            {
                textBox1.Text = bot.Handle(textBox2.Text).ToString();
            }
            else {
                MessageBox.Show("У тех підтримці вас нерозуміють");
                textBox2.Text = "";
            }
        }
    }
}
