namespace exo_Animalerie;

public class Chien : Animal
{
    
    public string CouleurCollier { get; set; }
    public bool Dresser { get; set; }
    public string Race { get; set; }
    public override string Crier()
    {
        throw new NotImplementedException();
    }
}