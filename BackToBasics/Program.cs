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

            //Creating any instance
            var Testing = container.GetInstance<OtherTypes>();

            //RegisterAType from an Interface
            container.Register<IMaterial, Plastic>();
            var getObjPlastic = container.GetInstance<Plastic>();
            Console.ReadLine();
        }
    }
}
