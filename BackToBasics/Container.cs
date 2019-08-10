using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BackToBasics
{
    public class Container
    {
        private Dictionary<Type, Func<object>> _registeredTypes = new Dictionary<Type, Func<object>>();
        public void Register<Tin,Tout>()
        {
            _registeredTypes.Add(typeof(Tin), () => GetInstance(typeof(Tout)));
        }
        public T GetInstance<T>()
        {
            return (T)GetInstance(typeof(T));
        }

        public object GetInstance(Type type)
        {
            if(_registeredTypes.ContainsKey(type))
            {
                return _registeredTypes[type];
            }
            var constructors = type.GetConstructors().OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
            var args = constructors.GetParameters()
                .Select(param => GetInstance(param.ParameterType))
               .ToArray();
            return Activator.CreateInstance(type, args);
        }
    }
}
