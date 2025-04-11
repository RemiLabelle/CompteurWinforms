namespace _2A6_Winforms_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCompteur.Text, out int compteur))
            {
                compteur++;
                textBoxCompteur.Text = compteur.ToString();
            }
            else
            {
                MessageBox.Show($"Impossible d'incrémenter '{textBoxCompteur.Text}'");
            }
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCompteur.Text, out int compteur) && compteur > 0)
            {
                compteur--;
                textBoxCompteur.Text = compteur.ToString();
            }
            else
            {
                MessageBox.Show($"Impossible de décrémenter '{textBoxCompteur.Text}'");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCompteur.Text = "0";
        }
    }
}
