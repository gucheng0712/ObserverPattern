using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilledObserver_Achievement : GameEventObserver
{
    // private EnemyKilledSubject m_subject;

    AchievementSystem m_achievementSystem;

    public EnemyKilledObserver_Achievement(AchievementSystem achievementSystem)
    {
        m_achievementSystem = achievementSystem;
    }

    public override void SetSubject(GameEventSubject sub)
    {
        // m_subject = (EnemyKilledSubject)sub;
    }

    public override void UpdateInfo()
    {
        m_achievementSystem.AddEnemyKilledCount();
    }
}
