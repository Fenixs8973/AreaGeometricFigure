using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaGeometricFigure
{
    public class Area
    {
        public static double area;
        
        public double Figure(double a, double b, double c)
        {
            double[] Values = new double[3] {a, b, c};//Хранит значения и из него будем получать колличество сторон
            int NumberOfSides = 0;
            foreach (double item in Values)
            {
                if (item > 0)//Считаем колличество сторон
                    NumberOfSides += 1;
                else
                    break;
            }

            switch(NumberOfSides)//Для разного колличества сторон свой метод вычисления площади
            {
                case 1://1 сторона - площадь круга
                    area = Math.PI * Values[0] * Values[0];
                    return area;
                case 3://3 стороны - площадь треугольника
                    double p = Values[0] + Values[1] + Values[2];
                    area = Math.Sqrt(p * (p - Values[0]) * (p - Values[1]) * (p - Values[2]));
                    return area;
                default:
                    return area;
            }
        }
        public bool RightTriangle(double a, double b, double c)//Проверка на прямоугольность треугольника
        {
            double BigerSide;
            

            if (a > b)
            {
                BigerSide = a;
                a = b;//Приравниваем меньшие переменные к меньшим значениям
                b = c;//Учитывая, что в прямоугольном треугольнике большая сторона - C => BigerSide = C
                      //А остальные значения сдвигаются
            }
            else if(b > c)
            {
                BigerSide = b;
                b = c;
            } 
            else
            {
                BigerSide = c;
            }


            if(Math.Pow(BigerSide, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
               return true;
            }
            else
                return false;
            
        }
    }
}
