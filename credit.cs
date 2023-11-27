using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;// manipulation des images, couleurs,...
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization;// pour generer les exceptions

namespace projet_dotnet
{
    public partial class credit : Form
    {
        double tauxHT, tauxHTmensuel, montantdupret, mensualite, couttotal;// bcs we need the values 
       
        int years;
        String montantapayer, totalapayer;

        //on declare cette classe pq on est besoin des exceptions si un champ n'est pas rempli
        public class EmptyFieldException : Exception
        {
            public EmptyFieldException()
            {
            }

            public EmptyFieldException(string message)
                : base(message)
            {
            }

            public EmptyFieldException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
        public credit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////

            try
            {
                string username = txtAmountOfLoan.Text;
                if (string.IsNullOrEmpty(username))
                {
                    throw new EmptyFieldException("vérifiez que vous avez bien rempli tous les champs");
                }
                montantdupret = Convert.ToDouble(txtAmountOfLoan.Text);

            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception  )
            {
                MessageBox.Show("Une erreur s'est produite : ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }









            ////////////////////////////////////////////////////////////
            ///

            try
            {
                string username = txtAmountOfLoan.Text;
                if (string.IsNullOrEmpty(username))
                {
                    throw new EmptyFieldException("vérifiez que vous avez bien rempli tous les champs!!");
                }
                years = int.Parse(annee.Text);

             
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception  )
            {
                MessageBox.Show("Une erreur s'est produite : ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /////////////////////////////////////////////

     



            
            tauxHTmensuel = tauxHT / 1200;// pour calculer le taux mensuel
                                                      
                                                     
           

            mensualite = montantdupret * tauxHTmensuel / (1 - 1 / Math.Pow(1 + tauxHTmensuel,
                               years * 12));
            /*Math.Pow(1 + tauxHTmensuel, years * 12):calcule le nombre de paiements mensuels pendant toute la durée du prêt.
            Cela utilise la fonction Pow de la classe Math de C#,
            qui calcule la puissance d'un nombre*/

            //----------------------------------------------------------------

            montantapayer = String.Format("{0:N2} DHs", mensualite);
            lblMonthlyPayment.Text = (montantapayer);
            //------------------------------------------------------------------
            couttotal = mensualite * years * 12;
            totalapayer = String.Format("{0:N2} DHs", couttotal);
            lblTotalPayment.Text = (totalapayer);
            txtInterestRate.Text = String.Format("{0}", tauxHT);

            txtAmountOfLoan.Text = String.Format("{0:N2}", montantdupret);
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPayment_Click(object sender, EventArgs e)
        {

        }

        private void txtAmountOfLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void typedecredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typedecredit.SelectedItem != null)
            {
                string selectedItem = typedecredit.SelectedItem.ToString();

                // Set the value of the interest variable based on the selected item
                switch (selectedItem)
                {
                    case "prêts personnels":
                        tauxHT = 5;
                        break;
                    case "crédits professionnels":
                        tauxHT = 6;
                        break;
                    case "crédits immobiliers":
                        tauxHT = 4.1;
                        break;
                    default:
                
                        break;
                }
            }

        }

        private void annee_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltxtInterestRate_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Text = "";
            annee.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
            //typedecredit.Items.Text = "aucun";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("             Credetify" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Montant du prêt" + "\t" + txtAmountOfLoan.Text + " DH \n");
            rtfReceipt.AppendText("Durée du prêt " + "\t" + annee.Text + "\n");
            rtfReceipt.AppendText("Taux annuel HT" + "\t" + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Mensualité" + "\t" + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Coût de l'emprunt" + "\t" + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("----------------------Thank You-----------------------" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Voules-vous quitter?", "  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}