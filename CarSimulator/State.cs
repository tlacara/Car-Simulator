using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)

        public void set()
        {
            position = 0;
            velocity = 0;
            acceleration = 0;
            time = 0;
        }

        public void set(double pos, double vel, double acc, double tim)
        {
            position = pos;
            velocity = vel;
            acceleration = acc;
            time = tim;
        }
    }
}
