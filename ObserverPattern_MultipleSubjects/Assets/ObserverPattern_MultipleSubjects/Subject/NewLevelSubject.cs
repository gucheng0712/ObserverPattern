using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevelSubject : GameEventSubject
{
    public int StageCount { get; private set; }

    public override void Notify()
    {
        StageCount++;
        base.Notify();
    }

}
