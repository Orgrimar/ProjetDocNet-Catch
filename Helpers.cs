using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFightCatchApp
{
    // Cette classe ne contiendra que des méthodes statique d'aide
    // Ces méthodes n'ont pas besoin d'état por fonctionner, elles prennent quelque chose entrée et ont une sortie, d'ou leur attribt statique
    static class Helpers
    {
        /// <summary>
        /// Récupère l'entier rentré par l'utilisateur
        /// S'occupe de la gestion des erreurs et s'assure que le nombre choisi est compris entre les bornes
        /// </summary>
        /// <param name="minValue">Borne inférieure</param>
        /// <param name="maxValue">Borne supérieure</param>
        /// <returns>Le choix de l'utilisateur</returns>
        public static int GetUserChoice(int minValue, int maxValue)
        {
            // On définit notre variable de choix à une valeur qui ne peut pas être un bon choix
            int finalChoice = int.MinValue;

            // Tant que le choix n'est pas considéré valide (que le TryParse n'a pas fonctionné), on redemande
            while (finalChoice == int.MinValue)
            {
                Console.WriteLine($"Choisissez un nombre entre {minValue} et {maxValue}");
                string choiceAsString = Console.ReadLine();

                // On affiche un message d'erreur si la conversion n'est pas possible
                // On vérifie aussi qu'il est dans les bornes imposées, sinon on le remet à int.MinValue
                if (!int.TryParse(choiceAsString, out finalChoice)
                    || finalChoice > maxValue
                    || finalChoice < minValue)
                {
                    finalChoice = int.MinValue;
                    Console.WriteLine("Saisie incorrecte !");
                }
            }

            return finalChoice;
        }

        /// <summary>
        /// Récupère l'entrée de l'utilisateur sous forme d'entier
        /// </summary>
        /// <returns></returns>
        public static int GetUserChoice(string propertyName)
        {
            // On définit notre variable de choix à une valeur qui ne peut pas être un bon choix
            int finalChoice = int.MinValue;

            // Tant que le choix n'est pas considéré valide (que le TryParse n'a pas fonctionné), on redemande
            while (finalChoice == int.MinValue)
            {
                Console.WriteLine($"Choisissez un nombre pour {propertyName}: ");
                string choiceAsString = Console.ReadLine();

                // On affiche un message d'erreur si la conversion n'est pas possible
                if (!int.TryParse(choiceAsString, out finalChoice))
                {
                    Console.WriteLine("Saisie incorrecte !");
                }
            }

            return finalChoice;
        }

        /// <summary>
        /// Petite méthode d'aide pour afficher à l'utilisateur la demande d'une propriété et retourner ce qu'il a rentré
        /// </summary>
        /// <param name="propertyName">Nom de la propriété que l'on demande</param>
        /// <returns>Ce que l'utilisateur a rentré</returns>
        public static string GetUserEntry(string propertyName)
        {
            Console.WriteLine($"Entrez une valeur pour {propertyName} :");
            return Console.ReadLine();
        }
    }
}
