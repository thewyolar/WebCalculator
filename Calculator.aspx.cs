using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        public static bool flag;
        private static double result;
        private static double operation;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 0)
                TextBox2.Text = "0";
            else
                return;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0")
                return;
            else
                TextBox2.Text = "0";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" && TextBox1.Text == string.Empty)
                return;
            else
            {
                TextBox1.Text = string.Empty;
                TextBox2.Text = "0";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0")
                return;
            else if (TextBox2.Text.Length == 1)
                TextBox2.Text = "0";
            else
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "7";
            }
            else
                TextBox2.Text = TextBox2.Text + "7";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "8";
            }
            else
                TextBox2.Text = TextBox2.Text + "8";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "9";
            }
            else
                TextBox2.Text = TextBox2.Text + "9";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "4";
            }
            else
                TextBox2.Text = TextBox2.Text + "4";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "5";
            }
            else
                TextBox2.Text = TextBox2.Text + "5";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "6";
            }
            else
                TextBox2.Text = TextBox2.Text + "6";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "1";
            }
            else
                TextBox2.Text = TextBox2.Text + "1";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "2";
            }
            else
                TextBox2.Text = TextBox2.Text + "2";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "0" || flag)
            {
                flag = false;
                TextBox2.Text = "3";
            }
            else
                TextBox2.Text = TextBox2.Text + "3";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                TextBox2.Text = "0";
            }
            else if (TextBox2.Text == "0")
                flag = false;
            else if (TextBox2.Text == "error")
                TextBox2.Text = "0";
            else
                TextBox2.Text = TextBox2.Text + "0";
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox2.Text + ",";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            flag = true;
            operation = 1;
            result = double.Parse(TextBox2.Text);
            TextBox1.Text = TextBox2.Text + " + ";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            flag = true;
            operation = 2;
            result = double.Parse(TextBox2.Text);
            TextBox1.Text = TextBox2.Text + " - ";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            flag = true;
            operation = 3;
            result = double.Parse(TextBox2.Text);
            TextBox1.Text = TextBox2.Text + " × ";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            flag = true;
            operation = 4;
            result = double.Parse(TextBox2.Text);
            TextBox1.Text = TextBox2.Text + " ÷ ";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                    result += double.Parse(TextBox2.Text);
                    TextBox1.Text += TextBox2.Text;
                    TextBox2.Text = result.ToString();
                    break;
                case 2:
                    result -= double.Parse(TextBox2.Text);
                    TextBox1.Text += TextBox2.Text;
                    TextBox2.Text = result.ToString();
                    break;
                case 3:
                    result *= double.Parse(TextBox2.Text);
                    TextBox1.Text += TextBox2.Text;
                    TextBox2.Text = result.ToString();
                    break;
                case 4:
                    if (TextBox2.Text == "0")
                    {
                        TextBox2.Text = "error";
                    }
                    else
                    {
                        result /= double.Parse(TextBox2.Text);
                        TextBox1.Text += TextBox2.Text;
                        TextBox2.Text = result.ToString();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}