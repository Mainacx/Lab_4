using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Lib;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form Form1 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logic.Upload_Dict(1, this.richTextBox5.Text);
            Logic.Upload_Dict(2, this.richTextBox6.Text);
            Logic.Upload_Dict(3, this.richTextBox7.Text);
            Logic.Upload_Dict(4, this.richTextBox8.Text);
            this.Close();
        }
    }
}
