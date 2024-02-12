namespace ClassExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "RED";
            button2.Text = "GREEN";
            button3.Text = "BLUE";
            button4.Text = "YELLOW";
            button5.Text = "BROWN";
            button6.Text = "BLACK";
            button7.Text = "EXIT";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            label1.Text = "RED";
            this.BackColor = Color.Red;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            label1.Text = "GREEN";
            this.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            label1.Text = "BLUE";
            this.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            label1.Text = "YELLOW";
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            label1.Text = "BROWN";
            this.BackColor = Color.Brown;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            label1.Text = "BLACK";
            this.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
