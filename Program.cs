using System;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double solution1;
            solution1 = EquationSolve.SolveEquation(-1.0, -2.0, -3.0);
            

            double l1;
            l1 = geometry.CalculateVector2DLength(2.0, 4.0);

            double l2;
            l2 = geometry.CalculateDistance2D(0.0, 0.0, 2.0, 2.0);

            double l3;
            l3 = geometry.CalculateVector3DLength(1.0, 2.0, 3.0);

            double l4;
            l4 = geometry.GetSphereVolume(4.0);

            double l5;
            l5 = geometry.GetRectangleArea(4.0, 5.0);

            double l6;
            l6 = Utils.GetMinValue(2, 3);

            double l7;
            l7 = Utils.GetMaxValue(2, 3);

            bool l8;
            l8 = Utils.IsEven(42);

            Ejercicio.Ejercicio1();
            Ejercicio.Ejercicio2(43);


            


        }
    }
}
