using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKilledObserver_Achievement : GameEventObserver
{
    AchievementSystem m_achievementSystem;

    public BossKilledObserver_Achievement(AchievementSystem achievementSystem)
    {
        m_achievementSystem = achievementSystem;
    }

    public override void SetSubject(GameEventSubject sub)
    {
        return;
    }

    public override void UpdateInfo()
    {
        m_achievementSystem.AddBossKilledCount();
    }

}
