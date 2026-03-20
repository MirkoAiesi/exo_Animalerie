namespace exo_Animalerie;

public abstract class Animal
{
    public string Nom { get; set; }
    public double Poid { get; set; }
    public double Taille { get; set; }
    public string Sexe { get; set; }
    public int Age { get; set; }
    public int AgeHumain { get; set; }
    public DateTime DateArrive { get; set; }
    public int TauxDeces { get; set; }

    public abstract void Crier();
}