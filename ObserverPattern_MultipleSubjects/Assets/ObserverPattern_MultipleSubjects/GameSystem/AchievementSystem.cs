using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{

    [SerializeField] int m_enemyKilledCount;
    [SerializeField] int m_bossKilledCount;

    [SerializeField] int m_maxLevel = 1;

    private void Start()
    {
        GameEventSystem.Instance.RegisterObserverByEventType(GameEventType.EnemyKilled, new EnemyKilledObserver_Achievement(this));
        GameEventSystem.Instance.RegisterObserverByEventType(GameEventType.BossKilled, new BossKilledObserver_Achievement(this));
        GameEventSystem.Instance.RegisterObserverByEventType(GameEventType.NewLevel, new NewLevelObserver_Achievement(this));
    }

    public void AddEnemyKilledCount(int num = 1)
    {
        m_enemyKilledCount += num;
        Debug.Log("Achievement Enemy Killed: " + m_enemyKilledCount);
    }

    public void AddBossKilledCount(int num = 1)
    {
        m_bossKilledCount += num;
        Debug.Log("Achievement Boss Killed: " + m_bossKilledCount);
    }

    public void SetMaxLevel(int lv)
    {
        if (lv > m_maxLevel)
        {
            m_maxLevel = lv;
            Debug.Log("Achievement Level: " + m_maxLevel);
        }
    }

}
