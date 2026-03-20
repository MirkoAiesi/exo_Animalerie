namespace exo_Animalerie;

public class Chat : Animal
{
    public Chat(string nom, double poid, double taille, string sexe, int age, int ageHumain, DateTime dateArrive, int tauxDeces, string caractere, bool coupeGriffe, bool poilLong) : base(nom, poid, taille, sexe, age, ageHumain, dateArrive, tauxDeces)
    {
        Caractere = caractere;
        CoupeGriffe = coupeGriffe;
        PoilLong = poilLong;
    }

    public string Caractere { get; set; }
    public bool CoupeGriffe { get; set; }
    public bool PoilLong { get; set; }
    
    public override void Crier()
    {
        Console.WriteLine("Miaou Miaou");
        return;
    }
}