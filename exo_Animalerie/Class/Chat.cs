namespace exo_Animalerie;

public class Chat : Animal
{
    public string Caractere { get; set; }
    public bool CoupeGriffe { get; set; }
    public bool PoilLong { get; set; }
    
    
    
    
    public override void Crier()
    {
        Console.WriteLine("Miaou Miaou");
        return;
    }
}