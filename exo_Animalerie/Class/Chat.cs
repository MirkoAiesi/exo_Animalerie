using exo_Animalerie.Enum;

namespace exo_Animalerie;

public class Chat : Animal
{
    public Chat(string nom, double poid, double taille, string sexe, int age, DateTime dateArrive, EnumCaractere caractere, bool coupeGriffe, bool poilLong) : base(nom, poid, taille, sexe, age, dateArrive)
    {
        Caractere = caractere;
        CoupeGriffe = coupeGriffe;
        PoilLong = poilLong;
        TauxDeces = 0.5;
        AgeHumain = ToAgeHumain();
        
    }

    public EnumCaractere Caractere { get; set; }
    public bool CoupeGriffe { get; set; }
    public bool PoilLong { get; set; }
    
    public override void Crier()
    {
        Console.WriteLine("Miaou Miaou");
        return;
    }

    public override int ToAgeHumain()
    {
        return ((Age - 2) * 4) + 24;
    }
}