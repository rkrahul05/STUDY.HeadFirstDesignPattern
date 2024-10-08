﻿namespace HeadFirstDesignPattern.TheObserverPattern.Interface
{
    public interface Subject
    {
        void RegisterObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObserver();
    }
}
