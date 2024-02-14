namespace WebApplication1.Design_Ptrn
{
    public class Animal
    {
       public Fly flyType;
        public string TryToFly()
        {
            return flyType.canFly();
        }
        public void setFlayingAbility(Fly fly)
        {
            flyType = fly;
        }
    }
    public class Duck :Animal { 
    
       public Duck()
        {
            flyType = new CanFly();
        }

    }

    public class Dog : Animal
    {

        public Dog()
        {
            flyType = new CantFly();
        }
    }

    //////////// Fly 

    public interface Fly
    {
        public string canFly();
    }
    public class CantFly : Fly
    {
        public string canFly()
        {
            return "No, I cant Flay";
        }
    }
    public class CanFly : Fly
    {
        public string canFly()
        {
            return "Yes, I can Flay";
        }
    }



}
