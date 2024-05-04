using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 530);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.ForeColor = SystemColors.ButtonHighlight;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Генерация текста";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Информация о тексте";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DimGray;
            richTextBox1.Location = new Point(21, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(463, 389);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.Location = new Point(512, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DimGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(512, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Tag = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(512, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Случайный выбор";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(512, 281);
            button1.Name = "button1";
            button1.Size = new Size(258, 48);
            button1.TabIndex = 5;
            button1.Text = "Сгенерировать текст";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 32);
            label1.Name = "label1";
            label1.Size = new Size(280, 20);
            label1.TabIndex = 7;
            label1.Text = "Укажите длину текста в предложениях:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 124);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 8;
            label2.Text = "Выберите регистр:";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepPink;
            button3.FlatAppearance.BorderColor = Color.DeepPink;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(512, 373);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(258, 48);
            button3.TabIndex = 9;
            button3.Text = "Посмотреть словарь данных";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 55);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 148);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 262);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(844, 522);
            Controls.Add(tabControl1);
            Name = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private Button button1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label2;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Button button3;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Label label5;
        private Label label4;
        private Label label3;
    }
}
