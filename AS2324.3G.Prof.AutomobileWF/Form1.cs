namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccelerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccelera_Click(object sender, EventArgs e)
        {
            velocita += stepAccelerazione;

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

        }

        private void chkAccensione_CheckedChange(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;
            if (chkAccensione.Checked == true && chkCinture.Checked == false)
            {
                MessageBox.Show("Allaccia le cinture");
            }
        }

        private void cmbStrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStrada.SelectedIndex == 0)
            {
                prbVelocita.Maximum = 50;
            }
            else if(cmbStrada.SelectedIndex == 1)
            {
                prbVelocita.Maximum = 90;
            }
            else if(cmbStrada.SelectedIndex == 2)
            {
                prbVelocita.Maximum = 130;
            }
        }


    }
}
