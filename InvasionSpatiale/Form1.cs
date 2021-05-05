using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvasionSpatiale
{
    public partial class Form1 : Form
    {
        bool gauche;

        bool droite;

        int vitesse = 5;

        int score = 0;

        bool estAppuye;

        int totalEnemies = 12;

        int vitesseJoueur = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gauche = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                droite = true;
            }
            if (e.KeyCode == Keys.Space && !estAppuye)
            {
                estAppuye = true;

                creationBalles();
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                gauche = false;
            }

            if (e.KeyCode == Keys.Right)
            {

                droite = false;
            }
            if (estAppuye)
            {
                estAppuye = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gauche)
            {
                joueur.Left -= vitesseJoueur;
            }
            else if (droite)
            {
                joueur.Left += vitesseJoueur;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "envahisseur")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(joueur.Bounds))
                    {
                        perdu();

                    }

                          ((PictureBox)x).Left += vitesse;

                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10;

                        ((PictureBox)x).Left = -50;
                    }
                }
            }
        }

        private void creationBalles()
        {
            PictureBox balle = new PictureBox();

            balle.Image = Properties.Resources.balle;

            balle.Size = new Size(5, 20);

            balle.Tag = "bullet";

            balle.Left = joueur.Left + joueur.Width / 2;

            balle.Top = joueur.Top - 20;

            this.Controls.Add(balle);

            balle.BringToFront();

        }

        private void perdu()
        {
            timer1.Stop();
            label1.Text += " Vous avez perdu";
        }
    }
}
