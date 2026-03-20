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
    public double TauxDeces { get; set; }

    public abstract void Crier();

    public Animal(string nom, double poid, double taille, string sexe, int age, DateTime dateArrive)
    {
        Nom = nom;
        Poid = poid;
        Taille = taille;
        Sexe = sexe;
        Age = age;
        DateArrive = dateArrive;
    }

    public abstract int ToAgeHumain();

}