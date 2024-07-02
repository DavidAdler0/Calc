using System;

namespace Calc
{
    public partial class Form1 : Form
    {
        private TextBox active;

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            active = (TextBox)sender;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            active = (TextBox)sender;
        }

       
        private void MyClick(object sender, EventArgs e)
        {
            active.Text = ((Button)sender).Text;
        }

    private void Operator(object sender, EventArgs e)
        {
            comboBox1.Text = ((Button)sender).Text;
        }

        private void result_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    textBox3.Text = Convert.ToString(num1 / num2);
                    break;
                default:
                    break;
            }
        }
       
    }
}
