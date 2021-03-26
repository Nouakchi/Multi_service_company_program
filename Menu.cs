using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multi_service_company_program
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            clock.Start();
        }
        private void client_form_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "CLIENT";
            //selectionner le button
            Methodes.active_button(client_form,panel_choix);
            
        }

        private void employee_form_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "EMPLOYEE";
            //selectionner le button
            Methodes.active_button(employee_form, panel_choix);
        }

        private void service_form_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "SERVICE";
            //selectionner le button
            Methodes.active_button(service_form, panel_choix);
        }

        private void base_donne_form_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "BASE DE DONNES";
            //selectionner le button
            Methodes.active_button(base_donne_form, panel_choix);
        }

        private void accissibilite_form_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "ACCESSIBILITE";
            //selectionner le button
            Methodes.active_button(accissibilite_form, panel_choix);
        }

        private void log_out_butt_Click(object sender, EventArgs e)
        {
            //citez le titre du form active
            header_label.Text = "-";
            //selectionner le button
            Methodes.active_button(log_out_butt, panel_choix);
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            //renommer la tete du form
            header_label.Text = "HOME";
            //boucle pour reinitialiser le borderstyle de toutes les buttons
            foreach (Control item in panel_choix.Controls)
            {
                if (item is Bunifu.Framework.UI.BunifuFlatButton)
                {
                    Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)item;
                    btn.BorderStyle = BorderStyle.None;
                }
            }
        }
        //un boolean qui indique si la panel est visible ou pas
        bool est_visible;
        private void hide_button_Click(object sender, EventArgs e)
        {
            //verifier si la panel est ouverte ou non
            if (panel_choix.Size.Width.Equals(160))
            {
            //si la panel est ouverte
                //initialiser le variable avec une image utulisant leur repertoire
            Bitmap image = new Bitmap(@"C:\Users\PcGamerCasa.Ma\OneDrive\Bureau\soutenance\Multi_service_company_program\Properties\right_hide.png");
                //determiner l'image comme image du butoon
            hide_button.Image = image;
                //panel est visible
            est_visible = true;
                //lancement de l'evenement
            side_panel_timer.Start();
            }
            else
            {
             //si il est fermer
                Bitmap image = new Bitmap(@"C:\Users\PcGamerCasa.Ma\OneDrive\Bureau\soutenance\Multi_service_company_program\Properties\hide.png");
                hide_button.Image = image;
                //indiquer que la panel est fermer
                est_visible = false;
                //lancement de l'evenement
                side_panel_timer.Start();
            }
        }

        private void side_panel_timer_Tick(object sender, EventArgs e)
        {
            //si la panel est visible
            if (est_visible == true)
            {
                //si la panel est totalement  fermer
                if (panel_choix.Width == 40)
                {
                    //arreter l'evenement
                    side_panel_timer.Stop();
                    //indiquer que la panel est fermer
                    est_visible = false;
                }
                //si la panel n'est pas encore fermer
                else
                {
                    //reduire 40 px du width
                    panel_choix.Width -= 40;
                }
                
            }
            //si la panel est non visible
            else
            {
                //si la panel est totalement ouverte
                if (panel_choix.Width == 160)
                {
                    //arreter l'evenement
                    side_panel_timer.Stop();
                    //indiquer que la panel est visible
                    est_visible = true;
                }
                //si la panel n'est pas encore ouverte
                else
                {
                    //augmenter 40 px du width
                    panel_choix.Width += 40;
                }
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            side_panel_clock.Text = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToShortTimeString();
            slider_clock.Text =  DateTime.Now.Hour.ToString()+"\n"+ DateTime.Now.Minute.ToString() + "\n"+DateTime.Now.Second.ToString() + "\n";
        }
    }
}
