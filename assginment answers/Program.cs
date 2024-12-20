using System;

namespace assginment_answers
{
    #region q1
    //public enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    #endregion
    #region q2
    //public struct Person
    //{
    //    public string Name;
    //    public int Age;

    //    // Constructor to initialize the properties
    //    public Person(string _name, int _age)
    //    {
    //        Name = _name;
    //        Age = _age;
    //    }
    //}
    #endregion
    #region q3
    //public enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    #endregion
    #region q4
    //i dont know answer
    #endregion
    #region q5
    //public enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    #endregion
    #region q6
    //public struct Point
    //{
    //    public double X;
    //    public double Y;


    //    public Point(double _x, double _y)
    //    {
    //        X = _x;
    //        Y = _y;
    //    }
    //}

    #endregion
    #region q7
    //public struct Person
    //{
    //    public string Name;
    //    public int Age;

    //    // Constructor to initialize Person
    //    public Person(string _name, int _age)
    //    {
    //        Name = _name;
    //        Age = _age;
    //    }
    //}

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //string[] days = Enum.GetNames(typeof(WeekDays));
            //foreach (var day in days)
            //{
            //    Console.WriteLine( day);
            //}
            #endregion
            #region q2
            //    Person[] persons = new Person[3];


            //persons[0] = new Person("ahmed", 30);
            //    persons[1] = new Person("mohamed", 25);
            //    persons[2] = new Person("mahmoud", 35);

            //    foreach (var person in persons)
            //    {
            //        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //    }

            #endregion
            #region q3
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("Invalid season name entered.");
            //}
            #endregion
            #region q4
            //i dont know answer
            #endregion
            #region q5
            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Colors color))
            //{

            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("Invalid color name entered.");
            //}

            #endregion
            #region q6
            //Console.WriteLine("Enter the coordinates for the first point (X Y):");
            //string[] input1 = Console.ReadLine().Split();
            //double x1 = Convert.ToDouble(input1[0]);
            //double y1 = Convert.ToDouble(input1[1]);
            //Point point1 = new Point(x1, y1);


            //Console.WriteLine("Enter the coordinates for the second point (X Y):");
            //string[] input2 = Console.ReadLine().Split();
            //double x2 = Convert.ToDouble(input2[0]);
            //double y2 = Convert.ToDouble(input2[1]);
            //Point point2 = new Point(x2, y2);


            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));


            //Console.WriteLine($"The distance between the points is: {distance}");
            #endregion
            #region q7
            //Person[] persons = new Person[3];

           
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    persons[i] = new Person(name, age);
            //}

            
            //Person oldestPerson = persons[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}

            
            //Console.WriteLine($"The oldest person is {oldestPerson.Name}  age {oldestPerson.Age}.");

            #endregion

        }
    }
}
