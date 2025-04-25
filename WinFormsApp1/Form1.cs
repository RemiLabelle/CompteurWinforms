using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class RemiLabelle : Form
    {
        private readonly Compteur _compteur;
        private readonly Configuration _config;

        public RemiLabelle(Compteur compteur, Configuration config)
        {
            InitializeComponent();

            _compteur = compteur;
            _config = config;

            label1.Text = compteur.Nom;

            checkBoxActiverEdition.Checked = Convert.ToBoolean(_config.editable);
            switch (_config.multiplicateur)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 10:
                    radioButton10.Checked = true;
                    break;
                case 100:
                    radioButton100.Checked = true;
                    break;
                case 1000:
                    radioButton1000.Checked = true;
                    break;
            };
            comboBoxCouleur.SelectedIndex = _config.couleur;
            textBoxLog.Text = _config.log;

            Répercuter();
        }

        private int Multiplicateur()
        {
            if (radioButton1.Checked) return 1;
            if (radioButton10.Checked) return 10;
            if (radioButton100.Checked) return 100;
            if (radioButton1000.Checked) return 1000;
            throw new UnreachableException();
        }

        private void Répercuter()
        {
            textBoxCompteur.Text = _compteur.Compte.ToString();
            buttonReset.Enabled = _compteur.Compte != 0;
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            _compteur.Compte -= Multiplicateur();
            Répercuter();
            textBoxLog.AppendText($"Décrémentation de {Multiplicateur()}" + Environment.NewLine);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _compteur.Compte = 0;
            Répercuter();
            textBoxLog.AppendText("Remise à zéro" + Environment.NewLine);
        }

        private void textBoxCompteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Return)
            {
                if (int.TryParse(textBoxCompteur.Text, out int compte))
                {
                    _compteur.Compte = compte;
                    Répercuter();
                    textBoxLog.AppendText($"Compteur modifié pour {compte}" + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show($"Le nombre {textBoxCompteur.Text} est invalide.");
                    textBoxCompteur.Text = _compteur.Compte.ToString();
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _compteur.Compte += Multiplicateur();
            Répercuter();
            textBoxLog.AppendText($"Incrémentation de {Multiplicateur()}" + Environment.NewLine);
        }

        private void checkBoxActiverEdition_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCompteur.Enabled = checkBoxActiverEdition.Checked;
        }

        private void comboBoxCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choix = comboBoxCouleur.Items[comboBoxCouleur.SelectedIndex];
            label1.ForeColor = choix switch
            {
                "Noir" => Color.Black,
                "Rouge" => Color.Red,
                "Vert" => Color.Green,
                "Bleu" => Color.Blue,
                "Magenta" => Color.Magenta,
                _ => throw new UnreachableException("option invalide : " + choix)
            };
        }

        private void textBoxLog_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxLog.Text.Length == 0) { return; }
            if (MessageBox.Show("Effacer le log ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBoxLog.Text = "";
            }
        }

        private void RemiLabelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            _config.editable = checkBoxActiverEdition.Checked;
            _config.multiplicateur = Multiplicateur();
            _config.couleur = comboBoxCouleur.SelectedIndex;
            _config.log = textBoxLog.Text;
        }
    }
}
