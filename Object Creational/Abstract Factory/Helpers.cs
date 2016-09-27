using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace AbstractFactory
{
    public static class Helpers
    {
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in Assembly.GetEntryAssembly().GetTypes()
                .Where(myType => myType.GetTypeInfo().IsClass && !myType.GetTypeInfo().IsAbstract && myType.GetTypeInfo().IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            return objects;
        }
    }
}
