namespace exo_Animalerie;

public class Oiseau : Animal
{
    public Oiseau(string nom, double poid, double taille, string sexe, int age, int ageHumain, DateTime dateArrive, int tauxDeces, string couleur, string habitat) : base(nom, poid, taille, sexe, age, ageHumain, dateArrive, tauxDeces)
    {
        Couleur = couleur;
        Habitat = habitat;
    }

    public string Couleur { get; set; }
    public string Habitat { get; set; }
    
    public override void Crier()
    {
        Console.WriteLine("Piou Piou");
    }
}