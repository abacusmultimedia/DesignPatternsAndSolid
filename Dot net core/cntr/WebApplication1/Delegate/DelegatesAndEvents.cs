using System;

// Define a delegate for the event handler
public delegate void EventHandlerDelegate(object sender, EventArgs e);

// Subject (Publisher) class
public class Subject
{
    // Declare an event using the delegate
    public event EventHandlerDelegate StateChanged;

    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            if (_state != value)
            {
                _state = value;
                OnStateChanged(); // Notify observers when the state changes
            }
        }
    }

    // Notify observers when the state changes
    protected virtual void OnStateChanged()
    {
        StateChanged?.Invoke(this, EventArgs.Empty);
    }
}

// Observer (Subscriber) class
public class Observer
{
    public void Subscribe(Subject subject)
    {
        // Subscribe to the event
        subject.StateChanged += HandleStateChanged;
    }

    public void Unsubscribe(Subject subject)
    {
        // Unsubscribe from the event
        subject.StateChanged -= HandleStateChanged;
    }

    private void HandleStateChanged(object sender, EventArgs e)
    {
        // Handle the state change event
        if (sender is Subject subject)
        {
            Console.WriteLine($"Observer received state change notification. New state: {subject.State}");
        }
    }
}

class Programe
{
    static void Main()
    {
        Subject subject = new Subject();
        Observer observer1 = new Observer();
        Observer observer2 = new Observer();

        // Subscribe observers to the subject's event
        observer1.Subscribe(subject);
        observer2.Subscribe(subject);

        // Change the state of the subject
        subject.State = "New State 1";

        // Unsubscribe one observer
        observer1.Unsubscribe(subject);

        // Change the state again
        subject.State = "New State 2";
    }
}

