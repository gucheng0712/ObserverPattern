using System.Collections.Generic;
using UnityEngine;

public enum GameEventType
{
    Null,
    EnemyKilled,
    BossKilled,
    NewLevel
}

public class GameEventSystem : MonoBehaviour
{
    Dictionary<GameEventType, GameEventSubject> m_gameEvents = new Dictionary<GameEventType, GameEventSubject>();
    public static GameEventSystem Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    protected void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    private GameEventSubject GetGameEventType(GameEventType e)
    {
        if (!m_gameEvents.ContainsKey(e))
        {
            switch (e)
            {
                case GameEventType.EnemyKilled:
                    m_gameEvents.Add(GameEventType.EnemyKilled, new EnemyKilledSubject());
                    break;
                case GameEventType.BossKilled:
                    m_gameEvents.Add(GameEventType.BossKilled, new BossKilledSubject());
                    break;
                case GameEventType.NewLevel:
                    m_gameEvents.Add(GameEventType.NewLevel, new NewLevelSubject());
                    break;
                default:
                    Debug.LogError("No such event type" + e);
                    return null;
            }

        }
        return m_gameEvents[e];
    }

    public void RegisterObserverByEventType(GameEventType e, GameEventObserver ob)
    {
        GameEventSubject sub = GetGameEventType(e);
        sub.RegisterObserver(ob);
        ob.SetSubject(sub);
    }

    public void RemoveObserverByEventType(GameEventType e, GameEventObserver ob)
    {
        GetGameEventType(e).RemoveObserver(ob);
        ob.SetSubject(null);
    }

    public void NotifyByEventType(GameEventType e)
    {
        GameEventSubject sub = GetGameEventType(e);

        if (sub != null)
        {
            sub.Notify();
        }
    }




}
