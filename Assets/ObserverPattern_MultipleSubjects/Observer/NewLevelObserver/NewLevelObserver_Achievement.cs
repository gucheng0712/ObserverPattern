using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevelObserver_Achievement : GameEventObserver
{
    AchievementSystem m_achievementSystem;

    NewLevelSubject m_subject;

    public NewLevelObserver_Achievement(AchievementSystem achievementSystem)
    {
        m_achievementSystem = achievementSystem;
    }

    public override void SetSubject(GameEventSubject sub)
    {
        m_subject = (NewLevelSubject)sub;
    }

    public override void UpdateInfo()
    {
        m_achievementSystem.SetMaxLevel(m_subject.StageCount);
    }
}
