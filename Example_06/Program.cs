Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
   Console.WriteLine("Ура маша!");
}
else 
{
Console.WriteLine("Привет , ");
Console.WriteLine(username);
}