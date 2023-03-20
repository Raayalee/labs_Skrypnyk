namespace lab04
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes;
        public Form1()
        {
            InitializeComponent();
            textBoxes = new TextBox[5];

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
            textBoxes[4] = textBox5;
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

            for (int idx = 0; idx < textBoxes.Length; idx++) {
                int num = idx + 1;

                if (string.IsNullOrEmpty(textBoxes[idx].Text))
                    richTextBox1.AppendText("Елемент " + num + ": Порожньо\n");
                else
                    richTextBox1.AppendText("Елемент " + num + ": " + textBoxes[idx].Text + '\n');
            }
        }
    }
}