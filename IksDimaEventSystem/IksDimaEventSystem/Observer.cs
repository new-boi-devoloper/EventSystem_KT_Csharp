namespace IksDimaEventSystem;

public class Observer
{
    public Observer()
    {
        if (!MyEventSystem.TrySubscribe("AttackWaveStart", OnAttackWaveStart))
        {
            Console.WriteLine("Ошибка: Событие 'AttackWaveStart' не существует.");
        }

        if (!MyEventSystem.TrySubscribe("AttackWaveEnd", OnAttackWaveEnd))
        {
            Console.WriteLine("Ошибка: Событие 'AttackWaveEnd' не существует.");
        }

        if (!MyEventSystem.TrySubscribe("DateTime", OnDateTime))
        {
            Console.WriteLine("Ошибка: Событие 'DateTime' не существует.");
        }
    }

    private void OnAttackWaveStart()
    {
        Console.WriteLine("началась атака монстров");
    }

    private void OnAttackWaveEnd()
    {
        Console.WriteLine("атака монстров закончилась.");
    }

    private void OnDateTime()
    {
        Console.WriteLine("время пошло");
    }
}
