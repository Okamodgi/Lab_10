class Program
{
    static void Main(string[] args)
    {
        EventClass object1 = new EventClass("Объект 1");
        EventClass object2 = new EventClass("Объект 2");

        HandlerClass handler = new HandlerClass();

        object1.EventOccurred += handler.HandleEvent;
        object2.EventOccurred += handler.HandleEvent;

        object1.GenerateEvent();
        object2.GenerateEvent();
    }
}