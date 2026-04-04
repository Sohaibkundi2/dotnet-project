namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DotNetEnv.Env.Load();

            string? correctName = Environment.GetEnvironmentVariable("DB_USERNAME");
            string? correctPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");


            string name = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (name == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields...");
            }
            else if (name == correctName && password == correctPassword)
            {
                MessageBox.Show("Logged In Successfully");
                Form2 dashboard = new Form2();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 dashboard = new Form2();

            dashboard.Show();

            this.Hide();
        }
    }
}
