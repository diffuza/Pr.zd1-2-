namespace Практическая_1_2
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void frmSumma_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // эта строка - ваш введенный код
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int summa = Math.Abs(Int32.Parse(txtA.Text)) +
               Math.Abs(Int32.Parse(txtB.Text));
            txtSumma.Text = summa.ToString();
                       
        }

        private void btnCount1_Click(object sender, EventArgs e)
        {
            int summa = Math.Abs(Int32.Parse(txtA.Text)) -
               Math.Abs(Int32.Parse(txtB.Text));
            txtSumma.Text = summa.ToString();
        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
            int summa = Math.Abs(Int32.Parse(txtA.Text)) *
               Math.Abs(Int32.Parse(txtB.Text));
            txtSumma.Text = summa.ToString();
        }

        private void btnCount3_Click(object sender, EventArgs e)
        {
            int summa = Math.Abs(Int32.Parse(txtA.Text)) /
               Math.Abs(Int32.Parse(txtB.Text));
            txtSumma.Text = summa.ToString();
        }
    }
}