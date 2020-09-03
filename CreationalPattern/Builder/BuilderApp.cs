using CorePattern.Core;
using System;

namespace CreationalPattern.Builder
{
    public class BuilderApp : IBubbleApp
    {
        public void Execute()
        {
            var shop = new Shop();

            // Construct and display vehicles
            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();

            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            // Wait for user
            Console.ReadKey();
        }
    }
}
