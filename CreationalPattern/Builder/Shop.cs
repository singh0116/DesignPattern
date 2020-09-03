using System;
using System.Collections.Generic;

namespace CreationalPattern.Builder
{
    /// <summary>
    /// The 'Directory' Class
    /// </summary>
    class Shop
    {
        private VehicleBuilder builder;

        /// <summary>
        /// Construct the complex object
        /// </summary>
        /// <param name="builder">VehicalBuilder instance</param>
        public void Construct(VehicleBuilder builder)
        {
            this.builder = builder;

            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheel();
            builder.BuildDoors();
        }

        /// <summary>
        /// Display vehicle properties
        /// </summary>
        public void ShowVehicle()
        {
            builder.Vehicle.Show();
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    class Vehicle
    {
        VehicleType vehicleType;
        Dictionary<VehiclePart, string> parts = new Dictionary<VehiclePart, string>();

        public Vehicle(VehicleType vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[VehiclePart part]
        {
            get { return parts[part]; }
            set { parts[part] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type : {0}", vehicleType);
            Console.WriteLine(" #Frame : {0}", this[VehiclePart.Frame]);
            Console.WriteLine(" #Engine : {0}", this[VehiclePart.Engine]);
            Console.WriteLine(" #Wheel : {0}", this[VehiclePart.Wheel]);
            Console.WriteLine(" #Door : {0}", this[VehiclePart.Door]);
        }
    }

    enum VehiclePart
    {
        Frame,
        Engine,
        Wheel,
        Door
    }

    enum VehicleType
    {
        Car,
        Scooter,
        MotorCycle
    }

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; private set; }

        public VehicleBuilder(VehicleType type)
        {
            Vehicle = new Vehicle(type);
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheel();
        public abstract void BuildDoors();
    }

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder() : base(VehicleType.Scooter)
        {

        }

        public override void BuildDoors()
        {
            this.Vehicle[VehiclePart.Door] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle[VehiclePart.Engine] = "50 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle[VehiclePart.Frame] = "Scooter Frame";
        }

        public override void BuildWheel()
        {
            this.Vehicle[VehiclePart.Wheel] = "2";
        }
    }

    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder() : base(VehicleType.MotorCycle)
        {

        }

        public override void BuildDoors()
        {
            this.Vehicle[VehiclePart.Door] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle[VehiclePart.Engine] = "300 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle[VehiclePart.Frame] = "Motor Cycle Frame";
        }

        public override void BuildWheel()
        {
            this.Vehicle[VehiclePart.Wheel] = "2";
        }
    }

    class CarBuilder : VehicleBuilder
    {
        public CarBuilder() : base(VehicleType.Car)
        {

        }

        public override void BuildDoors()
        {
            this.Vehicle[VehiclePart.Door] = "4";
        }

        public override void BuildEngine()
        {
            this.Vehicle[VehiclePart.Engine] = "1000 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle[VehiclePart.Frame] = "Car Frame";
        }

        public override void BuildWheel()
        {
            this.Vehicle[VehiclePart.Wheel] = "4";
        }
    }
}
