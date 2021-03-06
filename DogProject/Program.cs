// See https://aka.ms/new-console-template for more information


using DogProject.Models;
using static DogProject.Models.HaskyDogs;

var pets = new List<Dogs>();

pets.Add(new HaskyDog
{
    Age = 5,
    Name = "Hasky"
});

pets.Add(new ToyDog
{
    Age = 2,
    Name = "Paw Dog"
});



Console.WriteLine("Pick your pet enter option number");
for (int i = 0; i < pets.Count; i++)
{
    Console.WriteLine($"{i + 1}. {pets[i].Name}");
}

string? input = Console.ReadLine();
int option;
int.TryParse(input, out option);


var result = pets[option - 1];

if (result is ToyDog)
{
    Console.WriteLine("===================================");
    Console.WriteLine("Toy dog able to Bark only.");
    Console.WriteLine("===================================");
    var temp = result as ToyDog;
    temp?.Bark();
}
else
{

    Console.WriteLine("===================================");
    Console.WriteLine("Real dog able to Bark and eat.");
    Console.WriteLine("===================================");
    var temp = result as HaskyDog;
    temp?.Bark();
    temp?.Eat();
}

