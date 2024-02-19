namespace Week_3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "RED";
            button2.Text = "GREEN";
            button3.Text = "BLUE";
            button4.Text = "10";
            button5.Text = "15";
            button6.Text = "20";
            button7.Text = "25";
            button8.Text = "My Name";
            button9.Text = "My Course";
            button10.Text = "Clear";
            button11.Text = "Exit";
            label1.Text = "COMP-213 Visual programming";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 10L);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 15L);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 20L);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 25L);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Uche Hadassah";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Computer Science";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
