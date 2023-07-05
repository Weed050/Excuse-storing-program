using System.Diagnostics;

namespace UnicodeCharacters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
                Debug.Write(b + " ");
            Debug.WriteLine("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
                Debug.Write(b + " ");
            Debug.WriteLine("");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}