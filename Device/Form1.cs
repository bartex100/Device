namespace Device
{
    public partial class Form1 : Form
    {
        TV TV = new TV();
        public Form1()
        {
            InitializeComponent();
            TV.g=pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
