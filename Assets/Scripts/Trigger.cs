using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent DoSomething;

    public void OnTriggerStay2D()
    {
        DoSomething.Invoke();
    }

    public void OnTriggerStay()
    {
        DoSomething.Invoke();
    }
}
