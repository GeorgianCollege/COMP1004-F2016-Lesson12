using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson12
{
    public partial class OpacityForm : Form
    {
        public OpacityForm()
        {
            InitializeComponent();
        }

        private void OpacityScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            OpacityTextBox.Text = OpacityScrollBar.Value.ToString();
            ChangeOpacity(OpacityScrollBar.Value);
        }

        private void OpacityTextBox_TextChanged(object sender, EventArgs e)
        {
            int result = 0;

            if(Int32.TryParse(OpacityTextBox.Text, out result))
            {
                if ((result > 0) && (result < 101))
                {
                    OpacityScrollBar.Value = result;
                    ChangeOpacity(result);
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Value between 1 and 100", "Input Error");
                    OpacityTextBox.Text = "100";
                    OpacityTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Value", "Input Error");
                OpacityTextBox.Text = "100";
                OpacityTextBox.SelectAll();
            }
        }

        private void ChangeOpacity(int newOpacity)
        {
            this.Opacity = newOpacity / 100.0;
        }

        private void OpacityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OpacityTextBox.Text = "100";
            }
        }
    }
}
