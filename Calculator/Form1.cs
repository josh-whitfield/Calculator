using System;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int n;

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                {
                    txtDisplay.Text = txtDisplay.Text + ".";
                }
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                {
                    txtDisplay.Text = txtDisplay.Text + "/";
                }
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                { 
                    txtDisplay.Text = txtDisplay.Text + "X";
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                {
                    txtDisplay.Text = txtDisplay.Text + "-";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                {
                    txtDisplay.Text = txtDisplay.Text + "+";
                }
            }
        }

        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = txtDisplay.Text + "(";
            }
            else if (!int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) && txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) != ")")
            {
                txtDisplay.Text = txtDisplay.Text + "(";
            }
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) || txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) == ")")
                {
                    txtDisplay.Text = txtDisplay.Text + ")";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("Input data before pressing enter!");
            }
            else
            {
                if (int.TryParse(txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1), out n) == false && txtDisplay.Text.Substring(txtDisplay.Text.Length - 1, 1) != ")")
                {
                    MessageBox.Show("Invalid character at end of string.");
                }
                else
                {
                    string result = "";
                    string formula = txtDisplay.Text.Replace(" ", "");
                    formula = txtDisplay.Text.Replace("X", "*");
                    try
                    {
                        result = new DataTable().Compute(formula, null).ToString();
                    }
                    catch (Exception)
                    {
                        result = "Error";
                    }
                    
                    txtDisplay.Text = result;
                }
            }
        }

        private void btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEquals_Click(this, EventArgs.Empty);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                btnBack_Click(this, EventArgs.Empty);
            }
            else
            {
                switch (e.KeyChar.ToString())
                {
                    case "0":
                        btn0_Click(this, EventArgs.Empty);
                        break;
                    case "1":
                        btn1_Click(this, EventArgs.Empty);
                        break;
                    case "2":
                        btn2_Click(this, EventArgs.Empty);
                        break;
                    case "3":
                        btn3_Click(this, EventArgs.Empty);
                        break;
                    case "4":
                        btn4_Click(this, EventArgs.Empty);
                        break;
                    case "5":
                        btn5_Click(this, EventArgs.Empty);
                        break;
                    case "6":
                        btn6_Click(this, EventArgs.Empty);
                        break;
                    case "7":
                        btn7_Click(this, EventArgs.Empty);
                        break;
                    case "8":
                        btn8_Click(this, EventArgs.Empty);
                        break;
                    case "9":
                        btn9_Click(this, EventArgs.Empty);
                        break;
                    case ".":
                        btnDot_Click(this, EventArgs.Empty);
                        break;
                    case "/":
                        btnDiv_Click(this, EventArgs.Empty);
                        break;
                    case "*":
                        btnMul_Click(this, EventArgs.Empty);
                        break;
                    case "x":
                        btnMul_Click(this, EventArgs.Empty);
                        break;
                    case "-":
                        btnSub_Click(this, EventArgs.Empty);
                        break;
                    case "+":
                        btnAdd_Click(this, EventArgs.Empty);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
