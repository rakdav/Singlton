namespace Singlton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 singlton = new Form2();
            singlton = Form2.getInstance();
            singlton.Show();
        }
    }
}
