using System.Runtime.ConstrainedExecution;

namespace FactoryMethod_V1.Class
{
    abstract class Transport
    {
        public abstract void Deliver();
    }

    class Truck : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Deliver by Truck");
        }
    }

    class Ship : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Deliver by Ship");
        }
    }

    abstract class Creator : Transport
    {
        public abstract Transport CreateTransport();
        
    }

    class RoadLogistics : Creator
    {
        public override Truck CreateTransport()
        {
            System.Console.WriteLine("Truck Created");
            return new Truck();            
        }

        public override void Deliver()
        {
            Truck truck = CreateTransport();
            truck.Deliver();
        }
    }

    class OceanLogistics : Creator
    {
        public override Ship CreateTransport()
        {
            System.Console.WriteLine("Ship Created");
            return new Ship();
        }

        public override void Deliver()
        {
            Ship ship = CreateTransport();
            ship.Deliver();
        }
    }
}