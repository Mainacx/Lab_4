
using Lab_4;
using System.Text;

namespace WindowsFormsApp11
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitalizeComponent();
        }
        
        private void button1_click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Form1 = this;
            form2.Show();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            Form2.richTextBox1.Text = LogicObj.GetPhrace()[0];
            Form2.richTextBox2.Text = LogicObj.GetPhrace()[1];
            Form2.richTextBox3.Text = LogicObj.GetPhrace()[2];
            Form2.richTextBox4.Text = LogicObj.GetPhrace()[3];
        }

        public string[] GetPhrace()
        {
            string path1 = "1.txt";
            var srcEncoding = Encoding.GetEncoding("windows-1251");
            using (StreamReader reader = new StreamReader(path1, enocoding: srcEnocding))
            {
                text1.Add(new TextDictionary { Text = reader.ReadToEnd(), Number = 1 });
            }
        }

    }

}

