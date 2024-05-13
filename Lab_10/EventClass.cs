public delegate void EventHandler(string eventName);
class EventClass
{
    public event EventHandler EventOccurred;

    private string name;

    public EventClass(string name)
    {
        this.name = name;
    }

    public void GenerateEvent()
    {
        EventOccurred.Invoke(name);
    }
}