using System;
using System.Collections.Generic;
using System.Reflection;

namespace Anvil.Elements.Functional
{
    public class TypeDropdown<T> : Dropdown<Type>
    {
        public TypeDropdown() : base(GetTypes()) { }

        static Type[] GetTypes()
        {
            Type baseType = typeof(T);
            
            List<Type> foundTypes = new();

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                foreach (TypeInfo type in assembly.DefinedTypes)
                {
                    if (!baseType.IsAssignableFrom(type) || !type.IsClass || type.IsAbstract) continue;
                    
                    foundTypes.Add(type);
                }
            }

            return foundTypes.ToArray();
        }
    }
}