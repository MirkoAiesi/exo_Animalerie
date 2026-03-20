using exo_Animalerie;
using exo_Animalerie.Enum;

Animalerie animalerie = new Animalerie();
Animal chien = new Chien("Toby", 60, 72, "male", 2, new DateTime(2024, 03, 14), EnumCollier.bleu, "Dresser", EnumRace.Rotweiler);
Animal chien2 = new Chien("Douki", 8, 30, "male", 6, new DateTime(2020, 03, 14), EnumCollier.bleu, "Dresser", EnumRace.Rotweiler);
Animal chat = new Chat("Garfield", 10, 50, "male", 10, new DateTime(2016, 07, 18), EnumCaractere.farouche , true, true );
//Animal oiseau = new Oiseau();

animalerie.AddAnimal(chien);
animalerie.AddAnimal(chien2);
animalerie.AddAnimal(chat);
animalerie.ShowAnimal();