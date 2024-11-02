// See https://aka.ms/new-console-template for more information

// Создаем события

using IksDimaEventSystem;

if (!MyEventSystem.TryCreateEvent("AttackWaveStart"))
{
    Console.WriteLine("Ошибка: Событие 'AttackWaveStart' уже существует.");
}

if (!MyEventSystem.TryCreateEvent("AttackWaveEnd"))
{
    Console.WriteLine("Ошибка: Событие 'AttackWaveEnd' уже существует.");
}

if (!MyEventSystem.TryCreateEvent("DateTime"))
{
    Console.WriteLine("Ошибка: Событие 'DateTime' уже существует.");
}

var player = new Player();
var observer = new Observer();

var timer = new Timer(state =>
{
    if (!MyEventSystem.TryCallEvent("DateTime"))
    {
        Console.WriteLine("Ошибка: Событие 'DateTime' не существует.");
    }
}, null, 0, 1000);

for (int i = 0; i < 2; i++)
{
    if (!MyEventSystem.TryCallEvent("AttackWaveStart"))
    {
        Console.WriteLine("Ошибка: Событие 'AttackWaveStart' не существует.");
    }
    Thread.Sleep(2000);

    if (!MyEventSystem.TryCallEvent("AttackWaveEnd"))
    {
        Console.WriteLine("Ошибка: Событие 'AttackWaveEnd' не существует.");
    }
    Thread.Sleep(2000);
}

MyEventSystem.Clear();

Console.WriteLine("Наслаждайтесь результатом КТ!");
