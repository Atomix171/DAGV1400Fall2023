using UnityEngine;
using UnityEngine.Events;


public class TirggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
