using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduino_led
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//la apasarea butonului led on se srie pe port valoarea 1
        {
            serialPort1.Write("1");
        }

        private void Form1_Load(object sender, EventArgs e)//blocul try-catch
        {
            try
            {
                serialPort1.Open();// la pornirea aplicatie se dechide portul serial
            }

            catch(Exception)
            {
                MessageBox.Show("Connect your board to computer with usb cable");
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//
        {
            serialPort1.Write("0");//la apasarea butonului led on se srie pe port valoarea 1
        }
    }
}
