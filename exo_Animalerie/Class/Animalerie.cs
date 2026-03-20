namespace exo_Animalerie;

public class Animalerie
{
    private List<Animal> Liste = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        Liste.Add(animal);
    }

    public void ShowAnimal()
    {
        foreach (Animal n in Liste)
        {
            if (n is Chien c)
            {
                Console.WriteLine($"{c.Nom} est un {c.Race}, son collier est {c.CouleurCollier}, il a {c.Age} ans ce qui fait {c.AgeHumain} années en humain");
            }
            else if (n is Chat ca)
            {
                Console.WriteLine($"{ca.Nom} il est très {ca.Caractere}, il a {ca.Age} ans ce qui fait {ca.AgeHumain} ans en humain, il a les griffes {(ca.CoupeGriffe ? "coupées" : "non-coupées")}" );
            }
            
        }
    }
}