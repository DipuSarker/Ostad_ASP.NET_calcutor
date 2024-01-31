namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    a = Convert.ToInt32(textBox1.Text);
                }

                int b = 0;
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    b = Convert.ToInt32(textBox2.Text);
                }

                resultBox.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    a = Convert.ToInt32(textBox1.Text);
                }

                int b = 0;
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    b = Convert.ToInt32(textBox2.Text);
                }

                resultBox.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    a = Convert.ToInt32(textBox1.Text);
                }

                int b = 0;
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    b = Convert.ToInt32(textBox2.Text);
                }

                resultBox.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    a = Convert.ToInt32(textBox1.Text);
                }

                int b = 0;
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    b = Convert.ToInt32(textBox2.Text);
                }

                resultBox.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
