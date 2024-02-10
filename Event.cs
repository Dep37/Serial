
namespace serial {

public class Event {

    public List<Parent>? events { get; set; }
    
    public int LenghtEv ()
        {
            int x = events.Count;
            return x; 
        }
    public Parent indexEv (int index)
    {
        return events[index];
    }

    public object typeEv (int index)
    {
        return events[index].GetType();
    }

    // public Event (int index, string stroka)
    // {
    //     events[index].GetType().stroka;
    // }
}

}