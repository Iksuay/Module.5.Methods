using System;

(string Name, string[] Dishes) User;

Console.WriteLine("Введите имя пользователя");
User.Name = Console.ReadLine();

User.Dishes = new string[5];
for (int i = 0; i< User.Dishes.Length; i++)
{
    Console.WriteLine("Введите блюдо номер {0}", i + 1);
    User.Dishes[i] = Console.ReadLine();
}