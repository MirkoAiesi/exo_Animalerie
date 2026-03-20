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
                Console.WriteLine(c.Nom +" "+ c.Race);
            }
            
        }
    }
}