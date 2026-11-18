namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            talbar.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            talbar.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            talbar.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            talbar.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            talbar.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            talbar.Text += "6";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            talbar.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            talbar.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            talbar.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            talbar.Text += "0";
        }
        private void ustgahsvvliin_Click(object sender, EventArgs e)
        {
            if (talbar.Text.Length > 0)
            {
                talbar.Text = talbar.Text.Substring(0, talbar.Text.Length - 1);
            }
        }

        private void neehhaalt_Click(object sender, EventArgs e)
        {
            talbar.Text += "(";
        }
        private void haahhaalt_Click(object sender, EventArgs e)
        {
            talbar.Text += ")";
        }
        private void ustgahbvgd_Click(object sender, EventArgs e)
        {
           talbar.Text = "";
        }

        private void tseg_Click(object sender, EventArgs e)
        {
            string bichver = talbar.Text;

            int bairlal = bichver.LastIndexOfAny(new char[] { '+', '-', '*', '/', '(', ')' });

            string suuliinToo = bichver.Substring(bairlal + 1);

            if (!suuliinToo.Contains("."))
            {
                talbar.Text += ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            talbar.Text += "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            
            talbar.Text += "-";
        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
            talbar.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            
            talbar.Text += "/";
        }
        private void tentsvv_Click(object sender, EventArgs e)
        {
            try
            {
                var husnegt = new System.Data.DataTable();
                var hariu = husnegt.Compute(talbar.Text, "");
                talbar.Text = hariu.ToString();
            }
            catch
            {
                MessageBox.Show("Буруу илэрхийлэл байна!");
            }
        }
    }
}
