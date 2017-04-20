using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFightCatchApp
{
	class MainClass
	{

       

        public static void Main(string[] args)
		{
           MenuDisplayer jeu = new MenuDisplayer();

         
            //Console.WriteLine("Veuiller choisir deux Catcheurs :");
           // Console.WriteLine("Choix du premier catcheur : ");
            //string namec1 = Console.ReadLine();
            //Console.WriteLine("Choix du second catcheur : ");
            //string namec2 = Console.ReadLine();



             //Catcheur C1 = jeu.Catcheurs.Find(x => x.Nom == namec1);
             //Catcheur C2 = jeu.Catcheurs.Find(x => x.Nom == namec2);

            jeu.Appli();
            Console.WriteLine("Appuyer sur n'importe quels touche pour continuer...");
            Console.ReadLine();
		}
	}
}
