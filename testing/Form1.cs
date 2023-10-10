using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        string[] Grades;
        public int x;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(x);
            x = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(x);
            x++;
        }
    }
}
