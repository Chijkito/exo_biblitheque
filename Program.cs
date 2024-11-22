using ConsoleApp1;

class FirstProject
{
 
    public static void Main(string[] args)
    {
        List<Livre> livres = new List<Livre>();
        bool flag = true;
        while (flag)
        {
            Console.Write("Que voulez vous faire ?? \n 1.Ajouter un livre \n 2.Afficher tous les livres\n 3.Rechercher un livre par titre \n 4.Quitter \n");
            int response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    AddLivre(livres);
                    break;
                    
                case 2:
                    PrintAllLivre(livres);
                    break;
                
                case 3:
                    Console.WriteLine("Quel est le titre du livre ?");
                    string titre = Console.ReadLine();
                    Livre result = SearchLivreTitle(livres, titre);
                    if (result != null)
                    {
                        Console.WriteLine(result.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Le livre demander n'existe pas chez nous");
                    }
                    break;
                
                case 4:
                    flag = false;
                    break;
            }
        }

    }

    public static void AddLivre(List<Livre> livres)
    {
        Console.WriteLine("Titre du livre: ");
        string titre = Console.ReadLine();
        Console.WriteLine("Auteur du livre: ");
        string auteur = Console.ReadLine();
        livres.Add(new Livre(titre, auteur));
    }

     static void PrintAllLivre(List<Livre> livres)
    {
        if (livres.Count > 0)
        {
            foreach (var livre in livres)
            {
                Console.WriteLine(livre.ToString());
            }
        }
        else
        {
            Console.WriteLine("Il n'y a aucun livre dans la bibliothèque");
        }
    }

    public static Livre SearchLivreTitle(List<Livre> livres, string titre)
    {
        if (livres.Exists(livre => livre.GetTitre() == titre))
        {
            return livres.Find(livre => livre.GetTitre() == titre);
        } else
        {
            return null;
        }
    }
    
    public static void recur(Dictionary<string,int> dict)
    {
        if (dict["count"] > 0)
        {
            int searchNumber = int.Parse(Console.ReadLine());
            if (searchNumber> dict["random"])
            {
                Console.WriteLine("Cest moins!");
                dict["count"]--;
                recur(dict);
            }
            else if (searchNumber < dict["random"])
            {
                Console.WriteLine("Cest plus!");
                dict["count"]--;
                recur(dict);
            }
            else if (searchNumber == dict["random"])
            {
                Console.WriteLine("Bravo, tu as trouver mon nombre " + dict["random"] + " en " + dict["count"] + "tentatives restantes");
                dict["count"] = 0;
            }
            
        }else
        {
            Console.WriteLine("Dommage!, mon nombre était " + dict["random"]);
        }
    }
}