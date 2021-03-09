using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;

namespace WinFormsControlLab
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            double x;
            if (!double.TryParse(Text, out x))
                ForeColor = Color.Red;
            else
                ForeColor = Color.Black;
            base.OnTextChanged(e);
        }
    }
}
