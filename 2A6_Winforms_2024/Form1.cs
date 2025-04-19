namespace _2A6_Winforms_2024
{
    public partial class Form1 : Form
    {
        private readonly Compteur _compteur;

        public Form1(Compteur compteur)
        {
            InitializeComponent();

            _compteur = compteur;

            textBoxCompteur.Text = compteur.Nom;

            Répercuter();
        }

        private void Répercuter()
        {
            textBoxCompteur.Text = _compteur.Compte.ToString();
            buttonReset.Enabled = _compteur.Compte != 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _compteur.Compte++;
            Répercuter();

            /*if (int.TryParse(textBoxCompteur.Text, out int compteur))
            {
                compteur++;
                textBoxCompteur.Text = compteur.ToString();
            }
            else
            {
                MessageBox.Show($"Impossible d'incrémenter '{textBoxCompteur.Text}'");
            }*/
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            _compteur.Compte--;
            Répercuter();

            /*if (int.TryParse(textBoxCompteur.Text, out int compteur) && compteur > 0)
            {
                compteur--;
                textBoxCompteur.Text = compteur.ToString();
            }
            else
            {
                MessageBox.Show($"Impossible de décrémenter '{textBoxCompteur.Text}'");
            }*/
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _compteur.Compte = 0;
            Répercuter();
        }

        private void textBoxCompteur_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((Keys)e.KeyChar == Keys.Return) 
            {
                if (int.TryParse(textBoxCompteur.Text, out int compte))
                {
                    _compteur.Compte = compte;
                    Répercuter();
                }
                else
                {
                    MessageBox.Show($"Le nombre {textBoxCompteur.Text} est invalide");
                    textBoxCompteur.Text = _compteur.Compte.ToString();
                }
            }
        }
    }
}
