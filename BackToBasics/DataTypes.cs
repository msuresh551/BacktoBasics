using System;
using System.Collections.Generic;
using System.Text;

namespace BackToBasics
{
   public class DataTypes
    {
        int i { get; set; }
        public DataTypes()
        {
            
        }
        public void defaultIntegervalue()
        {
            Console.WriteLine("Integer dataType default values is " + i);
        }
    }
    public class OtherTypes
    {
        public DataTypes objDType;
        public OtherTypes()
        {

        }
        public OtherTypes(DataTypes obj)
        {
            Console.WriteLine("Calling from Other Types");
            objDType = obj;            
            objDType.defaultIntegervalue();
        }
    }
}
