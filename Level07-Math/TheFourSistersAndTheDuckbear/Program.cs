Console.WriteLine("What is the number of chocolate eggs gathered today?");
int numberOfChocolateEggs = Convert.ToInt32(Console.ReadLine());

int numberOfSisters = 4;
int chocolateEggsForDuckbear;
int chocolateEggsForEachSister;

chocolateEggsForDuckbear = numberOfChocolateEggs % numberOfSisters;

chocolateEggsForEachSister = (numberOfChocolateEggs - chocolateEggsForDuckbear) / numberOfSisters;

Console.WriteLine($"{chocolateEggsForDuckbear} chocolate eggs for duckbear.");
Console.WriteLine($"{chocolateEggsForEachSister} chocolate eggs for each sister.");