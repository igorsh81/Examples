Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
   Console.WriteLine("Ура маша!");
}
else 
{
Console.WriteLine("Привет , ");
Console.WriteLine(username);
}