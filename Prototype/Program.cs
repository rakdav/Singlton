using Prototype;

IAnimal sheepDonor = new Sheep();
sheepDonor.SetName("Dolly");

IAnimal sheepClone = sheepDonor.Clone();
Console.WriteLine(sheepDonor.GetName());
sheepClone.SetName("Pepe");
Console.WriteLine(sheepClone.GetName());
