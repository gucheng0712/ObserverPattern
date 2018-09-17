using System.Collections.Generic;

public abstract class GameEventSubject
{
    List<GameEventObserver> m_observers = new List<GameEventObserver>();

    public void RegisterObserver(GameEventObserver ob)
    {
        m_observers.Add(ob);
    }
    public void RemoveObserver(GameEventObserver ob)
    {
        m_observers.Remove(ob);
    }

    public virtual void Notify()
    {
        foreach (var o in m_observers)
        {
            o.UpdateInfo();
        }
    }

}
