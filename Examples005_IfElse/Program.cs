// Приветствие любимчика по имени, с нижнем регистром
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура! Это же ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет: ");
    Console.WriteLine(username);
}