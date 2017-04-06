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

        static void DisplayMenuSemaine()
        {
            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("1 - Créer le match de samedi prochain");
            Console.WriteLine("2 - Consulter l'historique des matchs");
            Console.WriteLine("3 - Consulter la base des contacts");
            Console.WriteLine("4 - Démrrer le match");
            Console.WriteLine("5 - Quitter");
        }

        static void Jeu()
        {
            int gains = 0;
            int semaine = 0;
            while (semaine < 8)
            {
                semaine++;
                Console.WriteLine("Semaine " + semaine);
                //Menu de la semaine
                Console.WriteLine($"Vous avez {gains} euros.");
                DisplayMenuSemaine();
                int.TryParse(Console.ReadLine(), out int choix);
                switch (choix)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Etes-vous sur de vouloir quitter ?");
                        Console.WriteLine("1 - Oui");
                        Console.WriteLine("2 - Non");
                        int.TryParse(Console.ReadLine(), out int choixQuit);
                        if (choixQuit == 1)
                            Environment.Exit(0);
                        break;
                }
                //Debreif

                //Continuer ou quitter
                if (semaine == 8)
                {
                    Console.WriteLine("Souhaitez-vous continuer ?");
                    Console.WriteLine("1 - Oui");
                    Console.WriteLine("2 - Non");
                    int.TryParse(Console.ReadLine(), out int choixSemaine);
                    if (choixSemaine == 1)
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
