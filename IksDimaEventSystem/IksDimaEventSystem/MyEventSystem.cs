namespace IksDimaEventSystem;

public static class MyEventSystem
{
    public static Dictionary<string, Action?> Actions = new();

    public static bool TryCreateEvent(string eventName)
    {
        if (Actions.ContainsKey(eventName))
        {
            return false;
        }

        Actions[eventName] = null;
        return true;
    }

    public static bool TryRemoveEvent(string eventName)
    {
        if (!Actions.ContainsKey(eventName))
        {
            return false;
        }

        Actions.Remove(eventName);
        return true;
    }

    public static bool TryCallEvent(string eventName)
    {
        if (!Actions.ContainsKey(eventName))
        {
            return false;
        }

        Actions[eventName]?.Invoke();
        return true;
    }

    public static bool TrySubscribe(string eventName, Action action)
    {
        if (!Actions.ContainsKey(eventName))
        {
            return false;
        }

        Actions[eventName] += action;
        return true;
    }

    public static bool TryUnsubscribe(string eventName, Action action)
    {
        if (!Actions.ContainsKey(eventName))
        {
            return false;
        }

        Actions[eventName] -= action;
        return true;
    }

    public static void Clear()
    {
        Actions.Clear();
    }
}