namespace IksDimaEventSystem;

public class Observer
{
    public Observer()
    {
        MyEventSystem.TrySubscribe("AttackWaveStart", OnAttackWaveStart);
        MyEventSystem.TrySubscribe("AttackWaveEnd", OnAttackWaveEnd);
        MyEventSystem.TrySubscribe("DateTime", OnDateTime);
    }

    private void OnAttackWaveStart()
    {
        Console.WriteLine("началась атака монстров!");
    }

    private void OnAttackWaveEnd()
    {
        Console.WriteLine("атака монстров закончилась.");
    }

    private void OnDateTime()
    {
        Console.WriteLine("время пошло!");
    }
}
