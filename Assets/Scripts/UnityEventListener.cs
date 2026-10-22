using UnityEngine;
using UnityEngine.Events;

public class UnityEventListener : MonoBehaviour
{
    public void OnEventBroadcast()
    {
        Debug.Log("UnityEventListener");
    }
}
