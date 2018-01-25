using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTTHGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Tinh(int a, int b) {
            return a + b;
        }
        public int Chia(int a, int b) {
            if (b != 0)
                return a / b;
            else return 0;
        }
    }
}
