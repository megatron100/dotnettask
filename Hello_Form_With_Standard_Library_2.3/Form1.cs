using Hello_Standard_Library_2._1;

namespace Hello_Form_With_Standard_Library_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Greeter greeter = new Greeter();
            MessageBox.Show(greeter.Greet(textBox1.Text));
        }
    }
}