using UnityEngine;

public class Narration : MonoBehaviour, IObserver
{
    [SerializeField] private Subject _playerSubject;
    public void OnNotify(string data)
    {
        Debug.Log("The "+ data +" has started");
    }

    private void OnEnable()
    {
        _playerSubject.AddObserver(this);
    }
        
    private void OnDisable()
    {
        _playerSubject.RemoveObserver(this);
    }
}