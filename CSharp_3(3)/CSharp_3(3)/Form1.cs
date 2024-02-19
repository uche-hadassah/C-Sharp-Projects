namespace CSharp_3_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Look Sharp Fitness Center";
            label2.Text = "";
            label3.Text = "Programmed by Hadassah";
            button1.Text = "Clothing";
            button2.Text = "Equipment/Accessories";
            button3.Text = "Juice Bar";
            button4.Text = "Membership";
            button5.Text = "Personal Training";
            button6.Text = "Exit";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Clothing: Take an extra 30% off the clearance items";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Equipment/Accessories: Yoga mats - 25% off";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Juice Bar: Try a free serving of our new WheatBerry Shake";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Membership: First month personal training included";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Personal Training: 3 free sessions with membership renewal";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
