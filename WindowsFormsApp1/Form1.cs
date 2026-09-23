using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double numberOne;
            double numberTwo;
            double result = 0;

            if (!double.TryParse(txtNumberOne.Text, out numberOne))
            {
                MessageBox.Show("Number one düzgün daxil edilməyib!");
                return;
            }

            if (!double.TryParse(txtNumberTwo.Text, out numberTwo))
            {
                MessageBox.Show("Number two düzgün daxil edilməyib!");
                return;
            }

            switch (cmbCommand.Text)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;

                case "-":
                    result = numberOne - numberTwo;
                    break;

                case "*":
                    result = numberOne * numberTwo;
                    break;

                case "/":
                    if (numberTwo == 0)
                    {
                        MessageBox.Show("0-a bölmək olmaz!");
                        return;
                    }

                    result = numberOne / numberTwo;
                    break;

                default:
                    MessageBox.Show("Əməliyyat seç!");
                    return;
            }

            lblAnswer.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Text = "0";
            txtNumberTwo.Text = "0";
            cmbCommand.SelectedIndex = 0;
            lblAnswer.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
