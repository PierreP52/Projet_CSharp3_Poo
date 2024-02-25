using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet03
{
    public partial class FrmPrincipale : Form
    {
        decimal resultat = 0;
        //on récupère ici le bonbon que l'utilisateur a séléctionné une fois la selection est valide.
        private static Candy bonbonChoisi;
        public FrmPrincipale()
        {
            InitializeComponent();
            //initialisation des textbox
            TxtChoix.Text = "0";
            comboBox1.Text = "0";
            lblPrix.Text = "00";
            lblPercu.Text = "00";
            lblRemis.Text = "00";
            //on désactive les composants mentionnés dans les étapes (voir énoncé)
            //exemple
            cmdAjouter.Enabled = false;
            comboBox1.Enabled = false;
            cmdAcheter.Enabled = false;

            lblMessage.Visible = false;
            lblBonbon.Visible = false;
            //...

        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {

          
                decimal argent = decimal.Parse(comboBox1.Text);
                resultat = argent + resultat;
                

                lblPercu.Text = resultat.ToString("C");


        }

        private void cmdAcheter_Click(object sender, EventArgs e)
        {
            if (resultat >= bonbonChoisi.Price)
            {
                decimal remis = resultat - bonbonChoisi.Price;
                lblRemis.Text = remis.ToString("C");
                lblMessage.Visible = true;
                lblBonbon.Visible = true;
                lblMessage.Text = "Prenez votre friandise";
                lblBonbon.Text = bonbonChoisi.Name;
                int selection = int.Parse(TxtChoix.Text);

                switch (selection)
                {
                    case 1:
                        pictureBoxWM.Image = Properties.Resources._01_wacky_monkey;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        pictureBoxWM.Image = Properties.Resources._02_toxic_waste;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        pictureBoxWM.Image = Properties.Resources._03_thumbs_up;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        pictureBoxWM.Image = Properties.Resources._04_text_messenger;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        pictureBoxWM.Image = Properties.Resources._05_bague_bonbon_fruit;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        pictureBoxWM.Image = Properties.Resources._06_sweetarts_wonka;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 7:
                        pictureBoxWM.Image = Properties.Resources._07_sucon_flip_phone;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 8:
                        pictureBoxWM.Image = Properties.Resources._08_batonnet_popeye;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 9:
                        pictureBoxWM.Image = Properties.Resources._09_sour_foamy_suret;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 10:
                        pictureBoxWM.Image = Properties.Resources._10_runts_wonka_24un;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 11:
                        pictureBoxWM.Image = Properties.Resources._11_rouleau_rockets;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 12:
                        pictureBoxWM.Image = Properties.Resources._12_rocket_geant;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 13:
                        pictureBoxWM.Image = Properties.Resources._13_sifflet_vrac;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 14:
                        pictureBoxWM.Image = Properties.Resources._14_shock_rock_framboise_bleue;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 15:
                        pictureBoxWM.Image = Properties.Resources._16_shark_bite;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 16:
                        pictureBoxWM.Image = Properties.Resources._17_gobstoppers;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 17:
                        pictureBoxWM.Image = Properties.Resources._18_gyro_pop;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 18:
                        pictureBoxWM.Image = Properties.Resources._19_kadunks;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 19:
                        pictureBoxWM.Image = Properties.Resources._20_licky_loot;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 20:
                        pictureBoxWM.Image = Properties.Resources._20_licky_loot;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 21:
                        pictureBoxWM.Image = Properties.Resources._21_oublies_wafers;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 22:
                        pictureBoxWM.Image = Properties.Resources._22_poubelle_bonbon;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 23:
                        pictureBoxWM.Image = Properties.Resources._23_nerds_pechefruit;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 24:
                        pictureBoxWM.Image = Properties.Resources._24_nerds_raisinfraise;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 25:
                        pictureBoxWM.Image = Properties.Resources._25_nerds_vague_et_plage;
                        pictureBoxWM.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
            }
            else 
            {
                MessageBox.Show("Veuillez rajouter de la monnaie ou Recommencer", "Erreur");
            }
        }

        private void TxtChoix_TextChanged(object sender, EventArgs e)
        {
          
        }
        //bouton vérifier stock: fonction de vérification de la selection puis le stock
        private void cmdVerifierStock_Click(object sender, EventArgs e)
        {
            

            if (int.Parse(TxtChoix.Text) < 1 || int.Parse(TxtChoix.Text) > 25)
            {
                MessageBox.Show("selection du bonbon invalide, il faut choisir de 1 à 25","Erreur");
            }
            else
            {
                int selection = int.Parse(TxtChoix.Text);
                bonbonChoisi = Program.GetCandy(selection);
                if (bonbonChoisi.Stock == 0)
                {
                    MessageBox.Show(bonbonChoisi.Name + " n'est plus en stock! Veuillez choisir un autre produit.", "Stock vide!");
                    pictureBoxWM.Visible = false;
                    comboBox1.Enabled = false;
                    cmdAcheter.Enabled = false;
                    cmdAjouter.Enabled = false;
                    TxtChoix.Text = "0";
                    comboBox1.Text = "0";
                    lblPrix.Text = "00";
                    lblPercu.Text = "00";
                    lblRemis.Text = "00";
                    lblSelection.Text = "00";
                }
                else 
                {
                    lblSelection.Text = selection.ToString();
                    lblPrix.Text = bonbonChoisi.Price.ToString("C");

                    pictureBoxWM.Visible = true;
                    comboBox1.Enabled = true;
                    cmdAcheter.Enabled = true;
                    cmdAjouter.Enabled = true;

                }
                
            }


        }

        private void cmdRecommencer_Click(object sender, EventArgs e)
        {
            if (resultat > 0)
            {
                lblRemis.Text = lblPercu.Text;
                MessageBox.Show($"Votre monnaie est de {lblRemis.Text}", "Monnaie rendue.");
            }
            
            TxtChoix.Text = "0";
            comboBox1.Text = "0";
            lblPrix.Text = "00";
            lblPercu.Text = "00";
            lblRemis.Text = "00";
            lblSelection.Text = "00";

            cmdAjouter.Enabled = false;
            comboBox1.Enabled = false;
            cmdAcheter.Enabled = false;

            lblMessage.Visible = false;
            lblBonbon.Visible = false;
            resultat = 0;
            pictureBoxWM.Image = null;
            

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter la machine à bonbon?",
                          "Message de confirmation",
                          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
