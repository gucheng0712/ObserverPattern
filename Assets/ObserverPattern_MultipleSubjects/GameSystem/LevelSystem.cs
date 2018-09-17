using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] public int EnemyKilledCount { get; set; }

    public int targetKills = 10;
    public int level = 1;

    public void Start()
    {
        GameEventSystem.Instance.RegisterObserverByEventType(GameEventType.EnemyKilled, new EnemyKilledObserver_LevelSystem(this));
    }

    private void Update()
    {
        if (EnemyKilledCount >= targetKills)
        {
            Debug.Log("entering next level");
            EnterNextLevel();
        }
    }

    public void EnterNextLevel()
    {
        targetKills *= 2;
        level++;
        GameEventSystem.Instance.NotifyByEventType(GameEventType.NewLevel);
    }


}
