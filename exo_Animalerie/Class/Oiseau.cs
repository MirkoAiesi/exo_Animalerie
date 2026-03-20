namespace exo_Animalerie;

public class Oiseau : Animal
{
    
    public string Couleur { get; set; }
    public string Habitat { get; set; }
    
    public override void Crier()
    {
        Console.WriteLine("Piou Piou");
    }
}