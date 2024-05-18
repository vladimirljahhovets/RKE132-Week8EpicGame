string folderPath = @"C:\Users\\vljah\\source\\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath,villainFile)); 



//string[] heroes = { "Harry potter", "Luke skywalker", "Lara Croft", "Ironman" };
//string[] villains = { "Heljut Kalda", "Sauron", "Joker", "Dracula", "hitler" };
string[] weapon = { "blaster", "katana", "banana", "lego brick", "sword" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrenght = heroHP;
Console.WriteLine($"Today {hero} ({heroHP} HP )  with {heroWeapon} saves the day!");

string villian = GetRandomValueFromArray(villains); 
string villianWeapon = GetRandomValueFromArray(weapon);
int villianHP = GetCharacterHP(villian);
int villianStrikeStrenght = villianHP;
Console.WriteLine($"Today {villian} ({villianHP} HP) with  {villianWeapon}  tries take over the world");

while (heroHP > 0 && villianHP > 0)
{ 
heroHP = heroHP - Hit(villian , villianHP );
    villianHP = villianHP - Hit(hero , heroHP );
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villian} HP: {villianHP}");
if (heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villianHP > 0)
    Console.WriteLine($"Dark side wins!");
else
{
    Console.WriteLine("Draw!");
}
static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next( 0, someArray.Length );
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
static int GetCharacterHP(string characterName)
{ 
if (characterName.Length < 10)
    {  return 10; }
else 
        return characterName.Length;
}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");
    }
    else if (strike == characterHP -1) 
    {
        Console.WriteLine($"{characterName} made a critical hit !");
    }
    else 
    {
        Console.WriteLine($"{characterName} hit {strike}!");

    }
    return strike;
}











