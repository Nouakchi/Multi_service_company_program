using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_service_company_program
{
   public class Methodes
    {
        public static void active_button(Bunifu.Framework.UI.BunifuFlatButton button,Bunifu.Framework.UI.BunifuGradientPanel panel)
        {
            //initialiser un variable de type Bunifu.Framework.UI.BunifuFlatButton(button)
            Bunifu.Framework.UI.BunifuFlatButton btn;
            //une boucle pour modifier le borderstyle de toutes les buttons a la valeur none
            foreach (Control item in panel.Controls)
            {
                //si le controlde du panel de type button appliquer les modification
                if (item is Bunifu.Framework.UI.BunifuFlatButton)
                {
                btn = (Bunifu.Framework.UI.BunifuFlatButton)item;
                btn.BorderStyle = BorderStyle.None;
                }
            }
            //modifier le borderstyle du button selectionner a la valeur fixed3d
            btn = button;
            btn.BorderStyle = BorderStyle.Fixed3D;
        }

        public static void active_form(Form form,Label title_label,Panel menu_panel,string title)
        {
            //Renommer la tete du form
            title_label.Text = title;
            //determiner que c'est une sous-forme
            form.TopLevel = false;
            //ajouter la form au panel
            menu_panel.Controls.Add(form);
            //afficher la form sur la panel
            form.BringToFront();
            form.Show();
        }
    }
}
