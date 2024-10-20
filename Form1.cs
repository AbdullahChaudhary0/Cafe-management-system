namespace Cafe_Management_System
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            this.Hide();
            thirdForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Creating second form
            Form2 secondForm = new Form2();
            this.Hide();
            secondForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creating second form
            Form2 secondForm = new Form2();
            this.Hide();
            secondForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Creating second form
            Form2 secondForm = new Form2();
            this.Hide();
            secondForm.ShowDialog();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            this.Hide();
            customerLogin.ShowDialog(); 
        }
    }
}