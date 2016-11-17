using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OrdrePrenom
{
    public partial class frmPrenom : Form
    {
        public frmPrenom()
        {
            InitializeComponent();
        }

        private void btnTrierLesNoms_Click(object sender, EventArgs e)
        {
            const string VOYELLES = "aeiouyAEIOUYéÉ";
            List<string> nomAvecDeuxVoyelles = new List<string>();
            int nbVoyelles = 0;

            const string NOM_FICHIER_A_LIRE = @"prenoms.txt";
            const string NOM_FICHIER_A_ECRIRE = @"sortie.txt";

            try
            {
                FileStream fichierALire = new FileStream(NOM_FICHIER_A_LIRE, FileMode.Open, FileAccess.Read);
                StreamReader lectureDeFichier = new StreamReader(fichierALire);
                string prenomLuParFichier;

                while ((prenomLuParFichier = lectureDeFichier.ReadLine()) != null)
                {
                    for (int i = 0; i < prenomLuParFichier.Length; i++)
                    {
                        if (VOYELLES.Contains(prenomLuParFichier[i]))
                        {
                            nbVoyelles++;
                        }
                    }

                    if (nbVoyelles % 2 == 0)
                    {
                        nomAvecDeuxVoyelles.Add(prenomLuParFichier);
                    }
                    nbVoyelles = 0;
                }
                nomAvecDeuxVoyelles.Sort();
                File.WriteAllLines(NOM_FICHIER_A_ECRIRE, nomAvecDeuxVoyelles);
                lectureDeFichier.Close();
                fichierALire.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Il y a eu une erreur lors de l'exécution du programme. Voici l'erreur : " + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
