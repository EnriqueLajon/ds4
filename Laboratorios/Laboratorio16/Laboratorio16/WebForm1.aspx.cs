using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "+") || (txt.Text == "-") || (txt.Text == "*") || (txt.Text == "/"))
            {
                txt.Text = ((Button)sender).Text;
            }
            else
                txt.Text = txt.Text + ((Button)sender).Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            a = float.Parse(txt.Text);
            b = '+';
            txt.Text = "+";
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            a = float.Parse(txt.Text);
            b = '-';
            txt.Text = "-";
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            a = float.Parse(txt.Text);
            b = '*';
            txt.Text = "*";
        }

        protected void div_Click(object sender, EventArgs e)
        {
            a = float.Parse(txt.Text);
            b = '/';
            txt.Text = "/";
        }

        protected void eql_Click(object sender, EventArgs e)
        {
            c = float.Parse(txt.Text);

            if (b == '/')
            {
                if (c != 0)
                {
                    d = a / c;
                    txt.Text = d.ToString();
                    a = d;
                }
                else
                {
                    txt.Text = "Error";
                }
            }
            else if (b == '+')
            {
                d = a + c;
                txt.Text = d.ToString();
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                txt.Text = d.ToString();
                a = d;
            }
            else if (b == '*')
            {
                d = a * c;
                txt.Text = d.ToString();
                a = d;
            }
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            a = 0;
            c = 0;
            d = 0;
        }
    }
}