namespace WebApplication1.Design_Ptrn.Creational
{

    public abstract class EnemyShip
    {
        public int Damage { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine(Name + " : Displaying");
        }
        public void FollowHeroShip()
        {
            Console.Write(Name + ": following the Herro ship");
        }

    }

    public class UFOShip : EnemyShip
    {
        public UFOShip(string name)
        {
            Name = name;
            Damage = 20;

        }
    }

    public class BossUFOShip : EnemyShip
    {
        public BossUFOShip(string name)
        {
            Name = name;
            Damage = 40;

        }
    }
    public class RocketShip : EnemyShip
    {
        public RocketShip(string name)
        {
            Name = name;
            Damage = 10;

        }
    }

    public class EnemyShipFactory
    {
        public EnemyShip Create(int shipType, string name)
        {

            if (shipType == 0)
            {
                return new UFOShip(name);
            }
            else if (shipType == 1)
            {
                return new RocketShip(name);
            }
            else if (shipType == 3)
            {
                return new BossUFOShip(name);
            }
            else
            {
                return new UFOShip(name);

            }
        }
    }
}
