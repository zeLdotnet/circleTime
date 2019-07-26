using System;
using System.Collections.Generic;
using System.Text;


namespace Lab10_CircleTime
{
    public class Circle
    {
        #region Fields
        private double radius;
        #endregion

        #region Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        #endregion

        #region Constructors
      

        public Circle(double _radius)
        {
            radius = _radius;
        }
        #endregion


        #region Methods
        public double CalculateArea(double input)
        {
            return Math.Round(Math.PI*(Math.Pow(radius,2)),2);
        }

        public double CalculateCircumference(double input)
        {
            return Math.Round((2 * Math.PI * radius),2);
        }
        #endregion
    }
}
