using UnityEngine;

public class EnemyKilledObserver_LevelSystem : GameEventObserver
{
    private EnemyKilledSubject m_subject;
    private LevelSystem m_levelSystem;

    public EnemyKilledObserver_LevelSystem(LevelSystem ls)
    {
        m_levelSystem = ls;
    }

    public override void SetSubject(GameEventSubject sub)
    {
        m_subject = (EnemyKilledSubject)sub;
    }

    public override void UpdateInfo()
    {
        m_levelSystem.EnemyKilledCount = m_subject.KilledCount;
        Debug.Log("Update: " + m_levelSystem.EnemyKilledCount);
    }
}
