using UnityEngine;

public class Boss : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Killed();
        }
    }

    private void Killed()
    {
        GameEventSystem.Instance.NotifyByEventType(GameEventType.BossKilled);
    }
}
