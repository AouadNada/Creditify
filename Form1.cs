using projet_dotnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

 //code pour la gestion des sous fenetres
        private void OpenChildForm(Form childForm)
        {
            this.Font = SystemFonts.DefaultFont;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
//Pour intégrer le nouveau formulaire dans le formulaire parent
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
//on ajoute la sous fenetre au niveau du panel body
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pour la page home
            OpenChildForm(new Form2());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ouvrire form de calcul
             OpenChildForm(new credit());
            label1.Text = button2.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ouvrire form de about us
            OpenChildForm(new about());
            label1.Text = button3.Text;
        }
    }
}
