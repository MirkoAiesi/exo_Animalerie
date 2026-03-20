using System.ComponentModel.DataAnnotations.Schema;
using exo_Animalerie.Enum;

namespace exo_Animalerie;

public class Chien : Animal
{
    public Chien(string nom, double poid, double taille, string sexe, int age, int ageHumain, DateTime dateArrive, int tauxDeces, EnumCollier couleurCollier, string dresser, EnumRace race) : base(nom, poid, taille, sexe, age, ageHumain, dateArrive, tauxDeces)
    {
        CouleurCollier = couleurCollier;
        Dresser = dresser;
        Race = race;
    }

    public EnumCollier CouleurCollier { get; set; }
    public string Dresser { get; set; }
    public EnumRace Race { get; set; }
    public override void Crier()
    {
        Console.WriteLine("Wouf wouf");
        return;
    }
}