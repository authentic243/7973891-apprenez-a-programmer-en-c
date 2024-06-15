namespace P1C4;

public class Livre
{
    Livre monLivre = new Livre ();

    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int NombreDePages { get; set; }

    monLivre.Titre = "The almanac";
    monLivre.Auteur = "Naval Ravikant";
    monLivre.NombreDePages = 245;
}
