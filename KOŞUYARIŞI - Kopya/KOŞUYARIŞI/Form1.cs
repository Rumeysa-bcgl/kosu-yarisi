using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOŞUYARIŞI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birincisonauzaklik, ikincisonauzaklik, ucuncusonauzaklik;

        Random rasgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           


            int birincikisiningenisligi = pictureBox3.Width;
            int ikincikisiningenisligi = pictureBox2.Width;
            int ucuncukisiningenisligi = pictureBox1.Width;

            int bitisuzakligi = label4.Left;

            pictureBox3.Left = pictureBox3.Left + rasgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rasgele.Next(5, 15);
            pictureBox1.Left = pictureBox1.Left + rasgele.Next(5, 15);

            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label5.Text = "1 numaralı koşucu önde gidiyor";

            }
            if (pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox1.Left + 5)
            {
                label5.Text = "2 numaralı koşucu öne geçti";

            }
            if (pictureBox1.Left > pictureBox3.Left + 5 && pictureBox1.Left > pictureBox2.Left + 5)
            {
                label5.Text = "3 numaralı koşucu önde";
            }

            if (birincikisiningenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label5.Text = "1 numaralı koşucu yarışı kazandı!!!";

            }
            if (ikincikisiningenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label5.Text = "2 numaralı koşucu yarışı kazandı!!!";

            }
            if (ucuncukisiningenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label5.Text = "3 numaralı koşucu yarışı kazandı!!!";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birincisonauzaklik = pictureBox3.Left;
            ikincisonauzaklik = pictureBox2.Left;
            ucuncusonauzaklik = pictureBox1.Left;

        }

        
    }
}
