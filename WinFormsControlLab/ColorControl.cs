using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLab
{
    public partial class ColorControl : UserControl
    {
        private bool type = true;

        private Color color;

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                panel1.BackColor = color;
            }
        }

        private char[] symbs = "0123456789ABCDIFabcdif".ToCharArray();
        public ColorControl()
        {
            InitializeComponent();
            color = Color.FromArgb(0, 0, 0);
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3.KeyPress += TextBox1_KeyPress;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;
            textBox3.TextChanged += TextBox3_TextChanged;
            radioButton1.Select();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int val;
            int.TryParse(textBox1.Text, out val);
            if (type)
            {
                if (val >= 255 || textBox1.Text.Length > 3)
                {
                    textBox1.Text = "255";
                }
            } else
            {
                if (textBox1.Text.Length == 0) return;
                val = Convert.ToInt32(textBox1.Text, 16);
                if (val >= 255 || textBox1.Text.Length > 3)
                {
                    textBox1.Text = "FF";
                }
            }
            onChangeColor();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (type)
            {
                int.TryParse(textBox2.Text, out val);
                if (val >= 255 || textBox2.Text.Length > 3)
                {
                    textBox2.Text = "255";
                }
            }
            else
            {
                if (textBox2.Text.Length == 0) return;
                val = Convert.ToInt32(textBox2.Text, 16);
                if (val >= 255 || textBox2.Text.Length > 3)
                {
                    textBox2.Text = "FF";
                }
            }
            onChangeColor();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (type)
            {
                int.TryParse(textBox3.Text, out val);
                if (val >= 255 || textBox3.Text.Length > 3)
                {
                    textBox3.Text = "255";
                }
            }
            else
            {
                if (textBox3.Text.Length == 0) return;
                val = Convert.ToInt32(textBox3.Text, 16);
                if (val >= 255 || textBox3.Text.Length > 3)
                {
                    textBox3.Text = "FF";
                }
            }
            onChangeColor();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (type)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
                base.OnKeyPress(e);
            } else
            {
                if (!check16(e.KeyChar))
                    e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private bool check16(char s) 
        {
            foreach(char c in symbs)
            {
                if (s == c) return true;
            }
            return false;
        }
        private void onChangeColor()
        {
            int r = 0, d = 0, b = 0;
            if (type)
            {
                int.TryParse(textBox1.Text, out r);
                int.TryParse(textBox2.Text, out d);
                int.TryParse(textBox3.Text, out b);
            } else
            {
                if (textBox1.Text.Length != 0) r = Convert.ToInt32(textBox1.Text, 16);
                if (textBox2.Text.Length != 0) d = Convert.ToInt32(textBox2.Text, 16);
                if (textBox3.Text.Length != 0) b = Convert.ToInt32(textBox3.Text, 16);
            }
            panel1.BackColor = (color = Color.FromArgb(r, d, b));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            Color = Color.FromArgb(0, 0, 0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            Color = Color.FromArgb(0, 0, 0);
        }
    }
}
