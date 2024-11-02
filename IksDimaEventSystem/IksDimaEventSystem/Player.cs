namespace IksDimaEventSystem;

public class Player
{
    public Player()
    {
        PrepareToAttack();
    }

    private void PrepareToAttack()
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
        Console.WriteLine($"Сейчас {DateTime.Now:dd.MM.yyyy HH:mm:ss}, готов к атаке");
    }

    private void OnAttackWaveEnd()
    {
        Console.WriteLine("Я успешно отбился");
        if (!MyEventSystem.TryUnsubscribe("AttackWaveEnd", OnAttackWaveEnd))
        {
            Console.WriteLine("Ошибка: Событие 'AttackWaveEnd' не существует.");
        }
    }

    private void OnDateTime()
    {
        Console.WriteLine($"текущее время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
    }
}