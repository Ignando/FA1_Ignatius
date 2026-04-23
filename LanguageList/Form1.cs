namespace LanguageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter programming language";
            textBox1.ForeColor = Color.Gray;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                label2.Text = "Item already exists";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string removed = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);

                label2.Text = $"Removed '{removed}' at {DateTime.Now}";
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter programming language")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }
    }
}
