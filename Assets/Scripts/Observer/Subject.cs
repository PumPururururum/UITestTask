using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<IObserver> _obserevers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _obserevers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _obserevers.Remove(observer);
    }
    protected void NotifyObservers()
    {
        _obserevers.ForEach((_observer) =>
        {
            _observer.OnNotify();
        });
    }
}
