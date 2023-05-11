using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace onczendz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Yellow;
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int z = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;
            int suma = z + y;
            Random r = new Random();
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.Text = suma.ToString();
        }

        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int z = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;
            int suma = z + y;
            Random r = new Random();
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.Text = suma.ToString();
        }
    }
}