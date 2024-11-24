namespace NumericUpDownControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void red_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb((int)red.Value, (int)green.Value, (int)blue.Value);
        }
    }
}
