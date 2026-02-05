using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "A + B =";
            RunOperation("Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "A - B =";
            RunOperation("Sub");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "A * B =";
            RunOperation("Mul");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "A / B =";
            RunOperation("Div");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            label3.Text = "Result =";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "A^2 =";
            RunOperation("Square");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "1/A =";
            RunOperation("InvA");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "cos =";
            RunOperation("cos");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "ctn =";
            RunOperation("ctn");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = "tan =";
            RunOperation("tan");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = "sin =";
            RunOperation("sin");
        }

        void RunOperation(string MathOperation)       
            
        {
            MathFuctions ob = new MathFuctions();
            double n1 = 0, n2 = 0;
            double res = 0;
            string s1, s2;
            s1 = textBox1.Text;
            bool success1 = double.TryParse(s1, out n1);
            s2 = textBox2.Text;
            bool success2 = double.TryParse(s2, out n2);
            if (radioButton1.Checked==true)
            {
                if (!success1 || !success2)
                {
                    MessageBox.Show("please provide valid inputdata");
                    return;
                }
                else res = ob.calc(n1, n2, MathOperation);
            }
            if (radioButton2.Checked == true)
            {
                if (!success1)
                {
                    MessageBox.Show("please provide valid inputdata");
                    return;
                }
                if(MathOperation=="Add"|| MathOperation == "Sub"|| MathOperation == "Mul"|| MathOperation == "Div")
                {
                    MessageBox.Show("your operation is wrong");
                    return;
                }
                else res = ob.calc(n1, n2, MathOperation);
            }
            textBox3.Text = res.ToString();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MathFuctions.Mem = Convert.ToDouble(textBox3.Text);
              
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused == true) textBox2.Text = Convert.ToString(MathFuctions.Mem);
               else textBox1.Text = Convert.ToString(MathFuctions.Mem);
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.Red;
        }
    }
}
