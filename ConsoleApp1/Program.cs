Console.WriteLine("Write your name:");
string name = Console.ReadLine();

while (name == "")
{
    Console.Clear();
    Console.WriteLine("write a name dickhead!");
    name = Console.ReadLine();
}
Console.Clear();
Console.WriteLine($"sup {name}!");
Console.ReadLine();

int HeroHp = 100;
int VillainHp = 100;

string HeroName = $"{name}";
string VillainName = "Jonkler";

Random generator = new Random();

Console.Clear();
Console.WriteLine("Why so solemn?");
Console.ReadKey();
Console.WriteLine($"{HeroName}: {HeroHp} {VillainName}: {VillainHp}");
Console.ReadKey();
while (HeroHp > 0 && VillainHp > 0)
{
    Console.WriteLine("-========NY RUNDA========-");
    int HeroDamage = generator.Next(20);
    VillainHp -= HeroDamage;
    VillainHp = Math.Max(0, VillainHp);
    Console.WriteLine($"{HeroName} deals {HeroDamage} damage to {VillainName}.");

    int VillainDamage = generator.Next(20);
    HeroHp -= VillainDamage;
    HeroHp = Math.Max(0, HeroHp);
    Console.WriteLine($"{VillainName} deals {VillainDamage} damage to {HeroName}.");
    Console.ReadLine();
    Console.WriteLine($"{HeroName}: {HeroHp} {VillainName}: {VillainHp}");

    Console.WriteLine("Kilck a button to continue.");
    Console.ReadKey();
}
Console.WriteLine("-=========FIGHT OVER========-");
Console.ReadKey();
if (HeroHp == 0 && VillainHp == 0)
{
    Console.Clear();
    Console.WriteLine("TIE, NOBODY WINS.");
}
else if (HeroHp == 0)
{
    Console.Clear();
    Console.WriteLine($"{HeroName} WINS");
}
else
{
    Console.Clear();
    Console.WriteLine($"{VillainName} WINS");
}
Console.WriteLine("Kilck a button to continue.");
Console.ReadKey();

