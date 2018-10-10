using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Input
    {
        List<Observer> observers;
        int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                this.Execute();
            }
        }

        public Input()
        {
            this.observers = new List<Observer>();
        }

        public void AddObserver(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Execute()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
