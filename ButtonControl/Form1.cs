namespace ButtonControl
{
    public partial class Form1 : Form
    {
        int index = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++index;
            if (index > 5)
                index = 1;
            picture.Image = Image.FromFile(index + ".bmp");
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
