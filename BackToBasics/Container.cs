using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BackToBasics
{
    public class Container
    {
        public object GetInstance(Type type)
        {
            var constructors = type.GetConstructors().OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
            var args = constructors.GetParameters()
                .Select(param => GetInstance(param.ParameterType))
               .ToArray();
            return Activator.CreateInstance(type, args);
        }
    }
}
