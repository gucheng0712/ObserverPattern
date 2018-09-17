public class EnemyKilledSubject : GameEventSubject
{
    public int KilledCount { get; private set; }

    public override void Notify()
    {
        KilledCount++;
        base.Notify();
    }

}
