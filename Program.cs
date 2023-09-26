using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        { return ((Math.Exp(x) * Math.Log(Math.Abs(x))) / (1.0 / Math.Tan(3 * x - 1) * 1.0 / Math.Tan(3 * x - 1))); }
        private double f2(double x)
        { return (5 / (Math.Tan(2 * x + 3) + 1)); }
        private double f3(double x)
        { return (Math.Pow(3 * x - 1, 2) / (Math.Pow(x, 5) + Math.Pow(Math.Sin(x + 2), 3))); }

        public void tab(double xn = -5.2, double xk = 11.7, double h = 0.1, double a = 0.5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
