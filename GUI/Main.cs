using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SMP_proiect
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void umiditate_TextChanged(object sender, EventArgs e)
        {
           string a = serialPort1.ReadLine();
           umiditate.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = serialPort1.ReadLine();//citesc de pe portul serial
            umiditate.Text = a.ToString();

        }

        private void Main_Load(object sender, EventArgs e)//portul se deschide la pornirea aplicatiei. verific daca placa este conectata
        {
            try
            {
                serialPort1.Open();
            }

            catch(Exception)
            {
                MessageBox.Show("Conectati placa de dezvoltare");
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apasati butonul Afisare umiditate pt a vedea umiditaatea din ghiveci.\n Pt a seta o noua referinta a umiditatii introduceti valoarea dorita in campul Noua valoare a umiditatii si apasati OK");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int cmd = Int32.Parse(textBox2.Text);
            byte [] b = BitConverter.GetBytes(cmd);
            serialPort1.Write(b, 0, 2);*/
            serialPort1.WriteLine(textBox2.Text);
        }
    }
}
