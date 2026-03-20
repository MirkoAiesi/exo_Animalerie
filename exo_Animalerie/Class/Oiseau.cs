namespace exo_Animalerie;

public class Oiseau : Animal
{
    public Oiseau(string nom, double poid, double taille, string sexe, int age, DateTime dateArrive, string couleur, string habitat) : base(nom, poid, taille, sexe, age, dateArrive)
    {
        Couleur = couleur;
        Habitat = habitat;
        TauxDeces = 3;
        AgeHumain = ToAgeHumain();
    }

    public string Couleur { get; set; }
    public string Habitat { get; set; }
    
    public override void Crier()
    {
        Console.WriteLine("Piou Piou");
    }

    public override int ToAgeHumain()
    {
        return Age * 5;
    }
}