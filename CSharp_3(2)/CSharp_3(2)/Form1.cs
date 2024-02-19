namespace CSharp_3_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Click Me";
            button2.Text = "Click Me Too";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
        }
    }
}
