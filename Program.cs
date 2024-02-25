using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet03
{
    static class Program
    {
        /*=====> NOTRE TABLEAU DES DONNÉES BONBONS : variable globale que vous pouvez utiliser dans tous les fichiers de code <=====*/
        public static Candy[] candies;
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            //chargement des données des bonbon du fichier candies.data
            candies = Data.LoadCandies();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipale());
        }
        public static Candy GetCandy(int selection)
        {
            return candies[selection - 1];
        }

    }
}
