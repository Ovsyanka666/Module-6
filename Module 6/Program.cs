namespace Module6
{
    class Program
    {
        static void Main()
        {
            var department = GetCurrentDepartment();

            department.Company.Type = "Банк";
            department.Company.Name = "Открытие";
            department.City.Name = "Санкт-Петербург";

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }

            Bus bus = new Bus();
            //bus.Load = 12;
            bus.PrintStatus();

            Triangle triangle = new Triangle();
            triangle.a = 12;
            triangle.b = 10;
            triangle.c = 5;
            triangle.GetPerimeter();
            triangle.GetArea();

        }

        //Опишите классы C# для следующих геометрических объектов: треугольник, круг, квадрат.
        //В классах нужно объявить поля для длин сторон(радиус) и методы для получения площади и периметра(длины окружности) без их реализации и без конструкторов.

        class Triangle
        {
            public int a, b, c;
            
            public void GetPerimeter()
            {
                int per = a + b + c;
                Console.WriteLine("Perimeter is " + per);
            }

            public void GetArea()
            {
                int p = (a + b + c) / 2;
                double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("Area is " + area);
            }
        }

        class Circle
        {
            int rad;

            public void GetCircumference()
            {
                double c = 2 * Math.PI * rad;
                Console.WriteLine("Circumference is " + c);
            }

            public void GetArea()
            {
                double s = Math.PI * rad * rad;
                Console.WriteLine("Area is " + s);
            }
        }

        class Square
        {
            int a;

            public void GetPerimeter()
            {
                int per = a * 4;
                Console.WriteLine("Perimeter is " + per);
            }

            public void GetArea()
            {
                int s = a * a;
                Console.WriteLine("Area is " + s);
            }
        }

        static Department GetCurrentDepartment()
        {
            Department Department = new Department();
            Department.City = new City();
            Department.Company = new Company();

            return Department;
        }

        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }

        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load == null)
                {
                    Console.WriteLine("The bus is empty");
                }
                else
                {
                    Console.WriteLine("There are {0} passengers in the bus", Load);
                }
            }
        }

    }
}