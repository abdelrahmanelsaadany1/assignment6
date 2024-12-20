using common;
namespace demo
{
    public enum grades
    {
        //lables
        A=2,B=1,C=3,Aplus=2,F=4
    }
    public enum gender
    {
        male=1,m=1,female=2,f=2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            //TypeA obj = new common.TypeA();
            //obj.z = 1;
            //// we can access z only
            #endregion
            #region Snum 
            //grades grades = grades.B;
            //if (grades==grades.A||grades==grades.Aplus)
            //{
            //    Console.WriteLine("your grade is excellent");
            //}
            //else
            //{
            //    Console.WriteLine("work harder next time");
            //}

            #endregion
            #region Struct
            //Point p1 = new Point(4,2);
            //Console.WriteLine($"points are :{p1.x} and {p1.y}");
            #endregion
            #region oop
            //it have four main parts (encapsulation -inheretance polymarphism- abstraction)
            #endregion
            #region encapsulation

            employee emp =new employee(10,"rana",20000);
            emp.setName("hana ahmed");
            Console.WriteLine(emp.getName());
            
       
            Console.WriteLine(emp.Salary);

            emp.age = 10;
            Console.WriteLine(emp.age);
            #endregion

        }
    }
}
