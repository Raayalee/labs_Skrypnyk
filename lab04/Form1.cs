namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();

            if (string.IsNullOrEmpty(textBox1.Text))
                richTextBox1.AppendText("E������ 1: ��������\n");
            else
                richTextBox1.AppendText("E������ 1: " + textBox1.Text + '\n');

            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("E������ 2: ��������\n");
            else
                richTextBox1.AppendText("E������ 2: " + textBox2.Text + '\n');

            if (string.IsNullOrEmpty(textBox3.Text))
                richTextBox1.AppendText("E������ 3: ��������\n");
            else
                richTextBox1.AppendText("E������ 3: " + textBox3.Text + '\n');

            if (string.IsNullOrEmpty(textBox4.Text))
                richTextBox1.AppendText("E������ 4: ��������\n");
            else
                richTextBox1.AppendText("E������ 4: " + textBox4.Text + '\n');

            if (string.IsNullOrEmpty(textBox5.Text))
                richTextBox1.AppendText("E������ 5: ��������\n");
            else
                richTextBox1.AppendText("E������ 5: " + textBox5.Text + '\n');
        }
    }
}