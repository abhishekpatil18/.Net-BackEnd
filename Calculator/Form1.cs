namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue=0;
        string opPerformed = "";
        bool isOpPerformed=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "0")|| (isOpPerformed))
            {
                textBox1.Clear();
            }
            isOpPerformed=false;
            
            Button number = (Button)sender;        
            if(number.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                textBox1.Text = textBox1.Text + number.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + number.Text;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
            isOpPerformed =true;
            Button op = (Button)sender;

            if (resultValue != 0)
            {
                equle.PerformClick();
                opPerformed = op.Text;
                lCurrentOp.Text = resultValue + " " + opPerformed;
            }
            else
            {
             opPerformed=op.Text;
            resultValue=Double.Parse(textBox1.Text);
            lCurrentOp.Text = resultValue + " " + opPerformed;
            }
        }

        private void clearEverything_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void equle_Click(object sender, EventArgs e)
        {
            switch(opPerformed){
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox1.Text);
            lCurrentOp.Text = " ";
        }

        
    }
}