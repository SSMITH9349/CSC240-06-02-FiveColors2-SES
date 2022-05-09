namespace CSC240_06_02_FiveColors2_SES
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UxBlueRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UxBlueRButton.Checked)
                this.BackColor = Color.Blue;
            else if (UxGreenButton.Checked)
                this.BackColor = Color.Green;
            else if (UxPurpleRButton.Checked)
                this.BackColor = Color.Purple;
            else if (UxRedRButton.Checked)
                this.BackColor = (Color)Color.Red;
            else if (UxYellowRButton.Checked)
                this.BackColor = (Color)Color.Yellow;
        }
    }
}