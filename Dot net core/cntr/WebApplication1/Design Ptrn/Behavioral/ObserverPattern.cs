namespace WebApplication1.Design_Ptrn.Behavioral
{
    public interface Subject
    {
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        public void Notify();
    }
    public class StockGrabber : Subject
    {
       public double IBMStock  { get; set; }
       public double GOOGlestock { get; set; }
       public double AppleStock { get; set; }

        List< Observer> observers;
        public StockGrabber()
        {
            observers = new List< Observer>();
        }
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update(IBMStock,GOOGlestock,AppleStock);
            }
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            var index = observers.IndexOf(o);
            observers.RemoveAt(index);
        }
    }
    public interface Observer
    {
        public void Update(double IBMStock, double GOOGlestock, double apple);
    }
    public class StockObserver : Observer
    {
        Subject _subject;
        public StockObserver(Subject subject)
        {
            _subject = subject;
        }
        public void Update(double IBMStock, double GOOGlestock, double apple)
        {

        }
    }
}
