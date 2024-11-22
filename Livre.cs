namespace ConsoleApp1;

public class Livre
{
    private string titre;
    private string auteur;
    private bool disponible;

    public Livre(string titre, string auteur, bool disponible)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.disponible = disponible;
    }
    
    public Livre(string titre, string auteur)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.disponible = true;
    }

    public override string ToString()
    {
        if (this.disponible)
        {
            return "'" + this.titre + "' de "+ this.auteur + " est disponible";
        }
        else
        {
            return "'" + this.titre + "' de " + this.auteur + " n'est plus disponible";
        }
    }

    public string GetTitre() { return this.titre; }
    public string GetAuteur() { return this.auteur; }
    public bool IsDisponible() { return this.disponible; }
    
    public void SetDisponible(bool disponible){ this.disponible = disponible; }
}