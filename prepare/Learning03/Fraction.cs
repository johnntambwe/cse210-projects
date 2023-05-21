using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning03
{
    public class Fraction
    {
        private int _top;
        private double _bottom;
        public Fraction(int top, double bottom)
        {
            _top = top;
            _bottom = bottom;
        }


        public int GetTop()
        {
            return _top;
        }
        public void SetTop(int top)
        {
            _top = top;
        }
       
          public double SetBottom()
        {
            return _bottom;
        }
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string fraction = $"{_top} " + "/" + $" {_bottom}";
            return fraction;
        }

        public double GetFractionDouble()
        {
            return  _top / _bottom;
        }

        
    }
}