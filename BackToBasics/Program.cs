using System;

namespace BackToBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            Console.WriteLine("Hello welcome to Programming World!");

            var obj = (DataTypes)container.GetInstance(typeof(DataTypes));
            obj.defaultIntegervalue();
            var otherType = (OtherTypes)container.GetInstance(typeof(OtherTypes));


            Console.ReadLine();
        }
    }
}
