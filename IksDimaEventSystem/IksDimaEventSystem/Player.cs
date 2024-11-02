namespace IksDimaEventSystem;

public class Player
{
    public Player()
    {
        PrepareToAttack();
    }

    private void PrepareToAttack()
    {
        MyEventSystem.TrySubscribe("AttackWaveStart", OnAttackWaveStart);
        MyEventSystem.TrySubscribe("AttackWaveEnd", OnAttackWaveEnd);
        MyEventSystem.TrySubscribe("DateTime", OnDateTime);
    }

    private void OnAttackWaveStart()
    {
        Console.WriteLine($"сейчас {DateTime.Now:dd.MM.yyyy HH:mm:ss}, начинаю отбиваться");
    }

    private void OnAttackWaveEnd()
    {
        Console.WriteLine("атака была отбита");
        MyEventSystem.TryUnsubscribe("AttackWaveEnd", OnAttackWaveEnd);
    }

    private void OnDateTime()
    {
        Console.WriteLine($"текущее время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
    }
}