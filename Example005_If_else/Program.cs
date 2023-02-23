Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! это маша!");
}
else
{
    Console.WriteLine("Привет, " + username);
}
