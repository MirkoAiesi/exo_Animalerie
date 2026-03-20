using exo_Animalerie;
using exo_Animalerie.Enum;

Console.WriteLine("test a l'aide");

Animalerie animalerie = new Animalerie();
Animal chien = new Chien("Toby", 60, 72, "male", 2,14, new DateTime(2024, 03, 14), 1, EnumCollier.bleu, "Dresser", EnumRace.Rotweiler);
//Animal chat = new Chat();
//Animal oiseau = new Oiseau();

animalerie.AddAnimal(chien);
animalerie.ShowAnimal();