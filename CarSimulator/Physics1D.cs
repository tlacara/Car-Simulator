using System;
namespace CarSimulator
{

    public class Physics1D
    {
        // Implement the methods
        // Implement the methods
        public static double compute_position(double x0, double v, double dt)
        {
            double position;
            position = v * dt + x0;
            return position;
        }
        public static double compute_velocity(double v0, double a, double dt)
        {
            double velocity;
            velocity = a * dt + v0;
            return velocity;
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        {
            double velocity;
            velocity = (x1 - x0) / (t1 - t0);
            return velocity;
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        {
            double acceleration;
            acceleration = (v1 - v0) / (t1 - t0);
            return acceleration;
        }
        public static double compute_acceleration(double f, double m)
        {
            double acceleration;
            acceleration = f / m;
            return acceleration;
        }
    }
}
