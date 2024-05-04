using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_Lib;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Form1 = this;
            form2.richTextBox5.Text = Logic.Load_Dict()[0];
            form2.richTextBox6.Text = Logic.Load_Dict()[1];
            form2.richTextBox7.Text = Logic.Load_Dict()[2];
            form2.richTextBox8.Text = Logic.Load_Dict()[3];
            form2.Show();
        }

        int Reg;
        bool randSelection;

        private void button1_click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.richTextBox5.Text = Logic.Load_Dict()[0];
            form2.richTextBox6.Text = Logic.Load_Dict()[1];
            form2.richTextBox7.Text = Logic.Load_Dict()[2];
            form2.richTextBox8.Text = Logic.Load_Dict()[3];

            int counter_sentence = Convert.ToInt16(textBox1.Text);
            richTextBox1.Text = Logic.Generate_Text(counter_sentence, Reg, randSelection);
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("The dictionary is empty. Please load data");
                return;
            }

            List<string> data = Logic.Get_txt_data(richTextBox1.Text);

            label3.Text = $"Symbols {data[0]}";
            label4.Text = $"Words {data[1]}";
            label7.Text = $"Uniq words{data[2]}";

            List<string> uniq_words = Logic.Chart_Names(richTextBox1.Text);
            List<int> Num_words = Logic.Chart_Nums(richTextBox1.Text);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < uniq_words.Count; i++)
            {
                chart1.Series[0].Points.AddXY(uniq_words[i], Num_words[i]);
                if (i == 4) { break; }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reg = this.comboBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            randSelection = checkBox1.Checked;
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
