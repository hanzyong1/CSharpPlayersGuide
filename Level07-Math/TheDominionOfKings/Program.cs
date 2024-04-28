int pointPerEstate = 1;
int pointPerDuchy = 3;
int pointPerProvince = 6;

Console.WriteLine("How many estates do you have?");
int numberOfEstates = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
int numberOfDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many provinces do you have?");
int numberOfProvinces = Convert.ToInt32(Console.ReadLine());

int total = (numberOfEstates * pointPerEstate) + (numberOfDuchies * pointPerDuchy) + (numberOfProvinces * pointPerProvince);
Console.WriteLine($"Your points: {total}");