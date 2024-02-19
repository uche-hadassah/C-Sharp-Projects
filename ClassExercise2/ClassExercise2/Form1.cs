namespace ClassExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Click Me";
            label1.ForeColor = Color.Black;
            this.BackColor = Color.Red;
        }
    }
}
