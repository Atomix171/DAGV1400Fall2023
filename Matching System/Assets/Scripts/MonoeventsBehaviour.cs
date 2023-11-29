using UnityEngine.Events;
using UnityEngine;

public class MonoeventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent,awakeEvent,disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
