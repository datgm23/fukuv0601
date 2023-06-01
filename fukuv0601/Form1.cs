namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = 10;
        string chr = "(ÅE-ÅE)";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;

            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "YuTanaka";
        }
    }
}