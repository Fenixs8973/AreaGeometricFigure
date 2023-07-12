namespace AreaGeometricFigure
{
    public class Figure
    {
        //<summary>
        //Площадь круга по радиусу
        //</summary>
        public double Area(double a)
        {
            return Math.PI * Math.Pow(a, 2);
        }

        //<summary>
        //Площадь треугольника по 3 сторонам
        //</summary>
        public double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result;
            Console.WriteLine("Треугольник прямоугольный: " + RightTriangle(a, b, c));
            return result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //<summary>
        //Проверка прямоугольного треуголника
        //</summary>
        public bool RightTriangle(params double[] k)
        {
            if(k.Length > 3)
                return false;
            double a = 0;
            double b = 0;
            double c = k[0];
            int cIndex = 0;
            
            //Присваиваем переменной c самое большое значение
            for(int i = 0; i < 3; i++)
            {
                if(c < k[i])
                {
                    c = k[i];
                    cIndex = i;
                }
            }

            //Присваиваем значение остальным двум переменным
            for(int i = 0; i < 3; i++)
            {
                if(cIndex != i && a == 0)
                {
                    a = k[i];
                }
                else
                {
                    b = k[i];
                }
            }
            if(Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b,2))
                return true;
            else
                return false;
        }

        //<summary>
        //Unit тесты
        //</summary>
        public void UnitTest()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            if((Int32)Area(a) == 50)
                Console.WriteLine("Площадь круга ОК");
            else
                Console.WriteLine("Error: " + Area(a));
            if((Int32)Area(a, b, c) == 6)
                Console.WriteLine("Площадь треугольника ОК");
            else
                Console.WriteLine("Error: " + Area(a, b, c));
        }
    }
}
