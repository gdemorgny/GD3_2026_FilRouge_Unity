using UnityEngine;
using UnityEngine.Events;

public class UnityEventBroadcaster : MonoBehaviour
{
    
    [SerializeField] private UnityEvent onEvent = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onEvent?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
