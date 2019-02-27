using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        public static List<Realty> realtyList = new List<Realty>();

        static void Main(string[] args)
        {
            Menu();
        }
        // Menu
        public static void Menu()
        {
            Console.WriteLine("Gestion du parc immobilier de l'agence" + Environment.NewLine + $"Le stock immobilier de l'agence est actuellement de : {realtyList.Count} biens");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Menu de l'application");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("1 : Afficher la liste des biens" + Environment.NewLine +
                "2 : Ajouter un appartement" + Environment.NewLine +
                "3 : Ajouter une maison" + Environment.NewLine +
                "4 : Ajouter un parking" + Environment.NewLine +
                "5 : Supprimer un bien" + Environment.NewLine +
                "6 : Quitter l'application");
            string userChoice = Console.ReadLine();
            SelectOption(userChoice);
        }
        // Options du menu
        public static void SelectOption(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    ListRealty();
                    break;
                case "2":
                    AddFlat();
                    break;
                case "3":
                    AddHouse();
                    break;
                case "4":
                    AddParking();
                    break;
                case "5":
                    DeleteRealty();
                    break;
                case "6":
                    Exit();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur, entrez un chiffre correspondant à une option du menu !");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nAppuyer sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        // Revenir au menu
        public static void ReturnToMenu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nAppuyer sur une touche pour revenir au Menu.");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        // Lister les biens
        public static void ListRealty()
        {
            if (realtyList.Count == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aucun bien n'a été ajouté.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Liste des Biens :\n");

                foreach (Realty item in realtyList)
                {
                    Console.WriteLine(item);
                    //Console.WriteLine(item.ToString());
                }
            }
            ReturnToMenu();
        }
        // Effacer les biens 
        public static void DeleteRealty()
        {
            Console.Clear();
            Console.WriteLine("Suppression d'un bien du parc immobilier\n");
            Console.WriteLine("Numéro du bien que vous souhaitez supprimer : ");
            int toDelete;
            int del = -1;
            bool delOk = int.TryParse(Console.ReadLine(), out toDelete);
            if (delOk == true)
            {
                foreach (Realty item in realtyList)
                {
                    if (toDelete == item.RegisterNumber)
                    {
                        del = realtyList.IndexOf(item);
                        //realtyList.RemoveAt(del);
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine("\nBien supprimé !");
                        //break;
                    }
                }
                if (del >= 0)
                {
                    realtyList.RemoveAt(del);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nBien supprimé !");
                }
                else
                {
                    Console.WriteLine("Erreur, entrez un numéro d'enregistrement valide");
                }
            }
            else
            {
                Console.WriteLine("Erreur, entrez un numéro d'enregistrement");
            }
            ReturnToMenu();
        }
        // Quitter appli
        public static void Exit()
        {
            Console.WriteLine("Etes-vous sûr de vouloir quitter l'application ? Y / N");
            string confirmExit = Console.ReadLine();
            if (confirmExit == "Y")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }
        // Ajouter un appartement
        public static void AddFlat()
        {
            Console.WriteLine("Ajouter un appartement");
            Console.Clear();
            Console.WriteLine("Veuillez saisir un n° d'enregistrement : ");
            // Faire une méthode TryParse peut être pratique : réduit le code et peut être réutilisée partout
            int registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la localisation : ");
            string location = Console.ReadLine();
            Console.WriteLine("Veuillez saisir superficie : ");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le loyer : ");
            int rent = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre de pièces : ");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir l'étage : ");
            int floor = int.Parse(Console.ReadLine());
            Flat flat = new Flat(registerNumber, location, area, rent, rooms, floor);
            realtyList.Add(flat);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAppartement ajouté avec succès !");
            ReturnToMenu();
        }
        // Ajouter une maison
        public static void AddHouse()
        {
            Console.WriteLine("Ajouter une maison");
            Console.Clear();
            Console.WriteLine("Veuillez saisir un n° d'enregistrement : ");
            int registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la localisation : ");
            string location = Console.ReadLine();
            Console.WriteLine("Veuillez saisir superficie : ");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le loyer : ");
            int rent = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre de pièces : ");
            int rooms = int.Parse(Console.ReadLine());
            Home house = new Home(registerNumber, location, area, rent, rooms);
            realtyList.Add(house);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMaison ajoutée avec succès !");
            ReturnToMenu();
        }
        // Ajouter un parking
        public static void AddParking()
        {
            Console.WriteLine("Ajouter un parking");
            Console.Clear();
            Console.WriteLine("Veuillez saisir un n° d'enregistrement : ");
            int registerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la localisation : ");
            string location = Console.ReadLine();
            Console.WriteLine("Veuillez saisir superficie : ");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le loyer : ");
            int rent = int.Parse(Console.ReadLine());
            Parking park = new Parking(registerNumber, location, area, rent);
            realtyList.Add(park);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nParking ajouté avec succès !");
            ReturnToMenu();
        }

        //CORRECTION :
        //Méthode pour supprimer un bien
        //public static void deleteRealty()
        //{
        //    Console.WriteLine("\nSuppression  d'un bien du parc immobilier");
        //    Console.WriteLine("Numéro du bien que vous souhaitez supprimer ?");
        //    var userChoice = Console.ReadLine();//Déclaration de la variable qui récupére l'entrée user
        //    Realty registerNumberToRemove = null;//attribution d'une valeur à registerNumberToRemove pour éviter les conflits s'il ne récupère pas de valeur
        //    if (int.TryParse(userChoice, out int value))// si la conversion du userChoice en int fonctionne, alors attribution de cette valeur à "value"
        //    {
        //        foreach (Realty realty in listOfRealty)//pour chaque item de la liste
        //        {
        //            if (realty.RegisterNumber == value)//si un registerNumber correspond à "value"
        //            {
        //                registerNumberToRemove = realty;//Attribution de la valeur de realty(qui a matché) à registerNumberToRemove
        //            }
        //        }

        //        if (registerNumberToRemove == null)//s'il n'y a aucun match
        //        {
        //            Console.WriteLine("Le bien que vous recherchez n'existe pas ou plus.");
        //        }
        //        else
        //        {
        //            listOfRealty.Remove(registerNumberToRemove);//Suppression du bien demandé
        //            Console.WriteLine("\nLe bien a été supprimé avec succès !");
        //        }
        //    }
        //    else //si le parse int n'a pas fonctionné
        //    {
        //        Console.WriteLine("Il y a une erreur dans la saisie.");
        //    }
        //    menu();
        //}

        //Méthode pour vérifier que les entrées user soit bien de type int
        //public static int IntVerification(string number)
        //{
        //    while (true)//Boucle infini temps que number n'est pas un int
        //    {
        //        if (int.TryParse(number, out int value))
        //        {
        //            return value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Il y a une erreur dans la saisie. Veuillez recommencer en tapant un nombre entier.");
        //            number = Console.ReadLine();
        //        }
        //    }
        //}

    }
}
