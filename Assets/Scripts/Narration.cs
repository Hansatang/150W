using ObserverPattern;
using UnityEngine;

public class Narration : MonoBehaviour, IObserver
{
    [SerializeField] private Subject playerSubject;

    public void OnNotify(string data)
    {
        Debug.Log("The " + data + " has started");
    }

    private void OnEnable()
    {
        playerSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        playerSubject.RemoveObserver(this);
    }
}