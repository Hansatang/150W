﻿using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<IObserver> _observers = new();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
        
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }
        
    protected void NotifyObservers(string data)
    {
        _observers.ForEach((_observers) =>
        {
            _observers.OnNotify(data);
        });
    }
}