using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFightCatchApp
{
	class MenuDisplayer
	{
        /// <summary>
        /// Affiche un message de bienvenue
        /// </summary>

        public  List<Catcheur> Catcheurs;
        
        public MenuDisplayer()
        {
             Catcheurs = new List<Catcheur> {
                new Brute("L'ordonnateur des pompes funebres", StatutEnum.Disponible),
                new Brute("JudySunny", StatutEnum.Disponible),
                new Agile("Triple hache", StatutEnum.Disponible),
                new Agile("Dead poule", StatutEnum.Disponible),
                new Brute("Jarvan cinquième du nom", StatutEnum.Convalescense),
                new Agile("Madusa", StatutEnum.Disponible),
                new Agile("John Cinema", StatutEnum.Convalescense),
                new Brute("Jeff Radis", StatutEnum.Convalescense),
                new Brute("Raie Mysterieuse", StatutEnum.Disponible),
                new Brute("Chris Hart", StatutEnum.Disponible),
                new Agile("Bret Benoit", StatutEnum.Disponible)};
        }
        public void AfficheList()
        {
            int index = 0;
            
            foreach (Catcheur C1 in Catcheurs)
            {
                Console.Write($"{index++}.");
                Console.Write("Nom du catcheur : ");
                Console.Write(C1.Nom);
                Console.Write(" Point de vie: ");
                Console.Write(C1.Hp);
                Console.Write(" Attaque: ");
                Console.Write(C1.Str);
                Console.Write(" Defense: ");
                Console.Write(C1.Def);
                Console.Write(" Status : ");
                Console.WriteLine(C1.Statu);
                Console.WriteLine();

            }
        }
        public  int TestUserInput(int min, int max)
        {
            int intSelectedMenu;

            while (!int.TryParse(Console.ReadLine(), out intSelectedMenu) || intSelectedMenu > max - 1 || intSelectedMenu < min)
            {
                if (intSelectedMenu > max - 1 || intSelectedMenu < min)
                {
                    Console.WriteLine("Saisie incorrect !");
                }
                else
                {
                    Console.WriteLine("Ce n'est pas un nombre !");
                }
            }

            return intSelectedMenu;
        }
        public void SelectCatcheurs()
        {
            int select1, select2;
            Console.WriteLine("Veuiller choisir deux Catcheurs  dans la liste :");
            AfficheList();
            Console.WriteLine("Choix du premier catcheur : ");
            select1 = TestUserInput(0,Catcheurs.Count);    
            do
            {
                Console.WriteLine("Choix du second catcheur : ");
                select2 = TestUserInput(0, Catcheurs.Count);
                 
            } while (select1 == select2);
            Catcheur C1 = Catcheurs[select1];
            Catcheur C2 = Catcheurs[select2];
            Console.WriteLine("Catcheur choisi :");
            Console.WriteLine("Catcheur 1 : " + C1.Nom);
            Console.WriteLine("Catcheur 2 : " + C2.Nom);
        }
        public  void DisplayWelcomeMessage()
		{
			Console.WriteLine("*************************************************************************");
			Console.WriteLine("**Bienvenue dans l'application de combat de catch, prêt pour le combat ?*");
			Console.WriteLine("*************************************************************************");
		}
		public static void DisplayGoodByeMessage()
		{
			Console.WriteLine("Merci d'avoir participé au combat !");
			Console.WriteLine("A bientôt");
		}
        static void DisplayMenuSemaine()
        {
            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("1 - Créer le match de samedi prochain");
            Console.WriteLine("2 - Consulter l'historique des matchs");
            Console.WriteLine("3 - Consulter la base des contacts");
            Console.WriteLine("4 - Démarrer le match");
            Console.WriteLine("5 - Quitter");
        }
       
		private void Jeu()
		{
            
            Match match = new Match();
            int choix;
            int choixSemaine;
            int gains = 0;
            int semaine = 1;
			while (semaine <= 8)
			{
				Console.WriteLine("Semaine " + semaine);
                //Menu de la semaine
                Console.WriteLine($"Vous avez {gains} euros.");
                DisplayMenuSemaine();
                int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        {
                            SelectCatcheurs();
                            
                            //match.CommencerCombat(C1, C2);
                        }
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        {
                            AfficheList();
                        }
                        break;

                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Etes-vous sur de vouloir quitter ?");
                        Console.WriteLine("1 - Oui");
                        Console.WriteLine("2 - Non");
                        int choixQuit;
                        int.TryParse(Console.ReadLine(), out choixQuit);
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
					string choixstr;
					choixstr = Console.ReadLine();
					int.TryParse(choixstr, out choixSemaine);
					if (choixSemaine == 1)
                    {
                        semaine = 0;
                        DisplayGoodByeMessage();
                    }	
					Console.WriteLine("Nouvelle saison");
				}
                semaine++;
			}
		}

		private void MenuPrincipal()
		{
            DisplayWelcomeMessage();
			Console.WriteLine("1 - Jouer");
			Console.WriteLine("2 - Quitter");
			string choixstr;
			int choix;
			choixstr = Console.ReadLine();
			int.TryParse(choixstr, out choix);
			if (choix == 1)
            {
                Jeu();
            }
            else
            {
                DisplayGoodByeMessage();
            }
		}

		public void Appli()
		{
			bool quitter = false;
			while (!quitter)
			{
				MenuPrincipal();

				//Fin de programme
				Console.WriteLine("Souhaitez-vous quitter ?");
				Console.WriteLine("1 - Oui");
				Console.WriteLine("2 - Non");
				string choixstr;
				int choix;
				choixstr = Console.ReadLine();
				int.TryParse(choixstr, out choix);
				if (choix == 1)
                {
                    quitter = true;
                }
                else
                {
                    DisplayGoodByeMessage();
                }
					
			}
		}


		public static int GetChoiceInSecondMenu()
		{
			Console.WriteLine("**** Choix du type de personnage");
			Console.WriteLine("0. Retour au menu principal");
			Console.WriteLine("1. Vérifier la disponibilité des catcheurs");
			Console.WriteLine("2. Choisir deux catcheurs dans la Liste");

			return Helpers.GetUserChoice(0, 2);
		}
	}
}
