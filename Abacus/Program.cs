// See https://aka.ms/new-console-template for more information
const int ITERATIONS_NUMBER = 4;
const int ITERATIONS_BREAK = 500;


Console.Clear();
Thread.Sleep(1000);
Console.Beep();
Console.WriteLine("3");
Thread.Sleep(1000);
Console.Beep();
Console.WriteLine("2");
Thread.Sleep(1000);
Console.Beep();
Console.WriteLine("1");
Thread.Sleep(1000);
Console.Clear();
var sum = 0;
for (int i = 0; i < ITERATIONS_NUMBER; i = i + 1)
{
    var random = new Random();
    var randomNumber = random.Next(1,9); //var - variable - змінна
    sum += randomNumber; 
    Console.WriteLine($"{i}: {randomNumber}");
    Thread.Sleep(ITERATIONS_BREAK);
    Console.Clear();
}
// Thread.Sleep(3000);
// Console.WriteLine(sum);
Console.WriteLine("будь ласка напишіт відповідь");
var answer = Console.ReadLine();
if (!int.TryParse(answer, out var result))
{
    Console.WriteLine("Вибачте, але то шо ви написали, взагалі не є числом. До побачення!");
    return;
}
if (sum == result)
{
    Console.WriteLine("відповідь правильна");
}
else
{
    Console.WriteLine("відповідь неправильна");
    Console.WriteLine($"Правильна відповідь: {sum}");
}
