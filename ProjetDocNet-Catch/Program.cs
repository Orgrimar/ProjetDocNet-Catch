using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDocNet_Catch
{
    class Program
    {
        static void ChoixAction()
        {
            Random rnd = new Random();
            int action = rnd.Next(1, 2);
            switch (action)
            {
                case 1:
                    //Frapper(target, attaquant);
                    break;
                case 2:
                    //Defendre(target, attaquant);
                    break;
                case 3:
                    //CompSpec(target, attaquant);
                    break;
            }
        }

        static void Jeu()
        {
            int semaine = 0;
            while (semaine < 8)
            {
                semaine++;
                Console.WriteLine("Semaine " + semaine);
                //Menu de la semaine

                //Debreif

                //Continuer ou quitter
                if (semaine == 8)
                {
                    Console.WriteLine("Souhaitez-vous continuer ?");
                    Console.WriteLine("1 - Oui");
                    Console.WriteLine("2 - Non");
                    int.TryParse(Console.ReadLine(), out int choix);
                    if (choix == 1)
                        semaine = 0;
                    Console.WriteLine("Nouvelle saison");
                }
            }
        }

        static void MenuPrincipal()
        {
            Console.WriteLine("Bienvenue");
            Console.WriteLine("1 - Jouer");
            Console.WriteLine("2 - Quitter");
            int.TryParse(Console.ReadLine(), out int choix);
            if (choix == 1)
                Jeu();
        }

        static void Appli()
        {
            bool quitter = false;
            while (!quitter)
            {
                MenuPrincipal();

                //Fin de programme
                Console.WriteLine("Souhaitez-vous quitter ?");
                Console.WriteLine("1 - Oui");
                Console.WriteLine("2 - Non");
                int.TryParse(Console.ReadLine(), out int choix);
                if (choix == 1)
                    quitter = true;
            }
        }

        static void Main(string[] args)
        {
            Appli();
        }
    }
}
