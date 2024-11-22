namespace ConsoleApp1;

public class User
{
    private string name;
    private string email;
    private List<Livre> enpruntedBook;

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
        this.enpruntedBook = new List<Livre>();
    }

    public void EmpruntBook(Livre livre)
    {
        if (enpruntedBook.Count <= 3)
        {
            if (livre.IsDisponible())
            {
                this.enpruntedBook.Add(livre);
                livre.SetDisponible(false);
                Console.WriteLine("Vous avez emprunté le livre " + livre.GetTitre());
            }
            else
            {
                Console.WriteLine("Ce livre n'est pas disponible pour le moment");
            }
        }
        else
        {
            Console.WriteLine("Vous ne pouvez pas enprumté plus de 3 livres");
        }
        
    }
    
    
}