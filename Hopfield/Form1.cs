using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hopfield
{
    public partial class Form1 : Form
    {
        int[] inputArr = new int[9];
        int[] outputArr = new int[9];
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //refer to this code below for future use
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button1.BackColor == Color.White)
            {
                button1.BackColor = Color.Black;
                inputArr[0] = 1;
            }
            else
            {
                button1.BackColor = Color.White;
                inputArr[0] = -1;
            }           
        }
        //end

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                button2.BackColor = Color.Black;
            }
            else
            {
                button2.BackColor = Color.White;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (button3.BackColor == Color.White)
            {
                button3.BackColor = Color.Black;
            }
            else
            {
                button3.BackColor = Color.White;
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                button4.BackColor = Color.Black;
            }
            else
            {
                button4.BackColor = Color.White;
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (button5.BackColor == Color.White)
            {
                button5.BackColor = Color.Black;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (button7.BackColor == Color.White)
            {
                button7.BackColor = Color.Black;
            }
            else
            {
                button7.BackColor = Color.White;
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (button6.BackColor == Color.White)
            {
                button6.BackColor = Color.Black;
            }
            else
            {
                button6.BackColor = Color.White;
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (button8.BackColor == Color.White)
            {
                button8.BackColor = Color.Black;
            }
            else
            {
                button8.BackColor = Color.White;
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                button9.BackColor = Color.Black;
            }
            else
            {
                button9.BackColor = Color.White;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //for(int i = 1; i <= 9; i++)
            //{
            //}
            
            //call computation function from Hop here


            //this will show the ouput + or -
            if (outputArr[0] == -1) { btn1.BackColor = Color.White; } else { btn1.BackColor = Color.Black; }
            if (outputArr[1] == -1) { btn2.BackColor = Color.White; } else { btn2.BackColor = Color.Black; }
            if (outputArr[2] == -1) { btn3.BackColor = Color.White; } else { btn3.BackColor = Color.Black; }
            if (outputArr[3] == -1) { btn4.BackColor = Color.White; } else { btn4.BackColor = Color.Black; }
            if (outputArr[4] == -1) { btn5.BackColor = Color.White; } else { btn5.BackColor = Color.Black; }
            if (outputArr[5] == -1) { btn6.BackColor = Color.White; } else { btn6.BackColor = Color.Black; }
            if (outputArr[6] == -1) { btn7.BackColor = Color.White; } else { btn7.BackColor = Color.Black; }
            if (outputArr[7] == -1) { btn8.BackColor = Color.White; } else { btn8.BackColor = Color.Black; }
            if (outputArr[8] == -1) { btn9.BackColor = Color.White; } else { btn9.BackColor = Color.Black; }
        }
    }
}
