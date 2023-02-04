// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


PosNumberSearch();
void PosNumberSearch()
{
Console.Write("Введите количество чисел: М = ");
int M = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("");

Console.WriteLine("Выбрано чисел - " + M + ". Введите их последовательно");

int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write(i + 1  + ") "); int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) count++;    
}
Console.WriteLine("Количество чисел больше 0: " + count);
}
