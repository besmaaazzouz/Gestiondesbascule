using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiondesbascules
{
    public partial class Form1 : Form
    {
        private const int TargetWidth = 599; // Largeur cible pour le panel2

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3; // Augmente la largeur du panel
            int progress = (int)((panel2.Width / (float)TargetWidth) * 100); // Calcul du pourcentage
            label3.Text = $"{progress}%"; // Mise � jour du texte du label

            // V�rifiez si la largeur cible est atteinte
            if (panel2.Width >= TargetWidth)
            {
                timer1.Stop(); // Arr�ter le timer
                Connexion connexion = new Connexion();
                connexion.Show(); // Afficher la fen�tre suivante
                this.Hide(); // Masquer le formulaire actuel
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15; // D�finir l'intervalle pour le timer
            timer1.Start(); // D�marrer le timer
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Action � effectuer lorsqu'on clique sur pictureBox1
        }
    }
}
