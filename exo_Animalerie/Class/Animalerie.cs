namespace exo_Animalerie;

public class Animalerie
{
    private List<Animal> Liste = new List<Animal>();
    public int NbrChien { get; set; }
    public int NbrChat { get; set; }
    public int NbrOiseau { get; set; }

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
            else if (n is Oiseau o)
            {
                Console.WriteLine($"{o.Nom} il est de couleur {o.Couleur}, il a {o.Age} ans ce qui fait {o.AgeHumain} ans en humain, il est enfermé dans une {o.Habitat}" );
            }
            
        }
    }

    public void CountAnimal()
    {
        foreach (Animal a in Liste)
        {
            switch (a)
            {
                case Chien c:
                    NbrChien++;
                    break;
                case Chat ca:
                    NbrChat++;
                    break;
                case Oiseau o:
                    NbrOiseau++;
                    break;
            }
        }
        Console.WriteLine($"Il ya {NbrChien} chien");
        Console.WriteLine($"Il ya {NbrChat} chat");
        Console.WriteLine($"Il ya {NbrOiseau} oiseau");
    }
    
}