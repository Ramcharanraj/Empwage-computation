﻿using System;
namespace empwage_computation
{
    class LengthOfLines
    {
        private double X1;
        private double X2;
        private double Y1;
        private double Y2;
        public LengthOfLines(double X1, double X2, double Y1, double Y2)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }
        public double Length()
        {
            double lengthofline = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(lengthofline);
            return lengthofline;

        }

        /// <summary>
        /// This method is used to print 
        /// </summary>
        public void Print(dynamic input)
        {
            Console.WriteLine(input);
        }
    }
}
