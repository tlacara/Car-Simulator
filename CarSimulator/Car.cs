using System;
namespace CarSimulator
{
    public class Car
    {
        protected double mass;
        protected string model;
        protected double dragArea;
        protected double engineForce;
        private double acc;
        private double pos;
        private double vel;
        private double fd;
        private double fn;
        public State myCarState;

        /// implement constructor and methods
        public Car()
        {
            mass = 0;
            model = null;
            dragArea = 0;
            engineForce = 0;
            myCarState = new State();
        }
        public Car(string model, double mass, double engineForce, double dragArea)
        {
            this.mass = mass;
            this.model = model;
            this.dragArea = dragArea;
            this.engineForce = engineForce;
            myCarState = new State();
            myCarState.set();
        }
        public string getModel()
        {
            return this.model;
        }
        public double getMass()
        {
            return this.mass;
        }
        public void accelerate(bool on)
        {

        }
        public void drive(double dt)
        {

            fd = 0.5 * 1.225 * dragArea * myCarState.velocity * myCarState.velocity;
            fn = engineForce - fd;
            acc = Physics1D.compute_acceleration(fn, mass);
            vel = Physics1D.compute_velocity(myCarState.velocity, acc, dt);
            pos = Physics1D.compute_position(myCarState.position, vel, dt);
            myCarState.set(pos, vel, acc, dt);

            Console.WriteLine("model:{0}, pos:{1}, vel:{2}, acc:{3}", getModel(), myCarState.position, myCarState.velocity, myCarState.acceleration);
        }

        public State getState()
        {
            return myCarState;
        }


        //implement inheritence
        public class Prius : Car
        {
            public Prius() : base()
            {
               
            }
            public Prius(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {
                //this.model = model;
                //this.mass = mass;
                //this.engineForce = engineForce;
                //this.dragArea = dragArea;
            }

        }
        public class Mazda : Car
        {
            public Mazda() : base()
            {

            }
            public Mazda(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {
                //this.model = model;
                //this.mass = mass;
                //this.engineForce = engineForce;
                //this.dragArea = dragArea;
            }

        }
        public class Tesla : Car
        {
            public Tesla() : base()
            {

            }
            public Tesla(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {
                //this.model = model;
                //this.mass = mass;
                //this.engineForce = engineForce;
                //this.dragArea = dragArea;
            }

        }
        public class Herbie : Car
        {
            public Herbie() : base()
            {

            }
            public Herbie(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {
                //this.model = model;
                //this.mass = mass;
                //this.engineForce = engineForce;
                //this.dragArea = dragArea;
            }

        }
    }
}
