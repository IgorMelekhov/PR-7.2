using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PR_7._2
{
    static public partial class Calcul
    {
        static public double SquareFunc(double x)
        {
            double s=Math.Round((Math.PI * (x * x)), 3);
            return s; 
        }
        static public double LenghtFunc(double x)
        {
            double l = Math.Round(((2* Math.PI) *x),3);
            return l;
        }
        static public double SectorAreaFunc(double x, double y)
        {
            double sa = Math.Round((Math.PI * (x * x) * (y / 360)),3);
            return sa;
        }
    }
}
