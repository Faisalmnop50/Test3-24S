using System.Data;
using System.Windows.Forms.VisualStyles;

namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetButton1());
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged = 0;
            int r=0;
            textBox1_TextChanged = r;
            r = textBox2_TextChanged;
  
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

            int r = 0;
            textBox1_TextChanged = r;
            r = textBox2_TextChanged;


        }
        public void textBox3_TextChanged(object sender, EventArgs e) => button1 += 1;
        public void textBox4_TextChanged(object sender, EventArgs e)
        {

            for (int i = 1; i <= count; i++)
            {

                double number = i;
                    double.Parse(Console.ReadLine());
                sum += number;
            }
        }
                y = r / 2;
            textBox4_TextChanged = y;



        }

        public void button1_Click(object sender, EventArgs e)
        {
        button1_Click = ;
            

        }

        public void button2_Click(object sender, EventArgs e)
        {
        button2_Click = Clear;


        }
    }
}
