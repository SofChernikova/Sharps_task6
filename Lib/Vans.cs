﻿namespace Lib
{
    internal class Vans : PublicTransport
    {
        private int engine { get; set; }

        public override string Move()
        {
            return "Transport moved";
        }

        public double FindEngineDisplacement(double cylinderDiameter, double pistonStroke, int numberOfCylinders)
        {
            return (cylinderDiameter * pistonStroke) * numberOfCylinders;
        }
    }
}
