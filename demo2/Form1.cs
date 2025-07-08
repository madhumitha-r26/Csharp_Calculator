namespace demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            double result = value1 - value2;
            label3.Text = result.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            double result = value1 + value2;
            label3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            double result = value1 * value2;
            label3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            double result = value1 / value2;
            label3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
