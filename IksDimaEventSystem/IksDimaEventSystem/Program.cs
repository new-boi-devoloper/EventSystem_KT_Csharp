// See https://aka.ms/new-console-template for more information

// Создаем события

using IksDimaEventSystem;

MyEventSystem.TryCreateEvent("AttackWaveStart");
MyEventSystem.TryCreateEvent("AttackWaveEnd");
MyEventSystem.TryCreateEvent("DateTime");

var player = new Player();
var observer = new Observer();

var timer = new Timer(state =>
{
    MyEventSystem.TryCallEvent("DateTime");
}, null, 0, 1000);

for (int i = 0; i < 2; i++)
{
    MyEventSystem.TryCallEvent("AttackWaveStart");
    Thread.Sleep(2000);
    MyEventSystem.TryCallEvent("AttackWaveEnd");
    Thread.Sleep(2000);
}

MyEventSystem.Clear();

Console.WriteLine("Наслаждайтесь результатом!");