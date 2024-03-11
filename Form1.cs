namespace Square_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int lowerLimit = 0;
            int upperLimit = 10;
            int countBy = 1;
            listBox1.Items.Clear();

            try
            {
                lowerLimit = int.Parse(txt_LowerLimit.Text);
                upperLimit = int.Parse(txt_UpperLimit.Text);
                countBy = int.Parse(txt_CountBy.Text);

                if(lowerLimit > upperLimit)
                {
                    //swap
                    int temp = lowerLimit;
                    lowerLimit = upperLimit;
                    upperLimit = temp;
                }

                //for loop example
                for (int x = lowerLimit; x <= upperLimit; x = x + countBy)
                {
                    listBox1.Items.Add("x = " + x + " squared = " + x * x);
                }

            }
            catch
            {
                MessageBox.Show("ONLY Numbers Please");
            }


        }

        
    }
}
