#region License
// Copyright (c) Jeremy Skinner (http://www.jeremyskinner.co.uk)
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
// 
// The latest version of this file can be found at http://fluentvalidation.codeplex.com
#endregion
namespace FluentValidation.Internal
{
    using System;
    using System.Reflection;
    using Attributes;
    using Resources;

    using System.Linq;
    /// <summary>
    /// Keeps all the conditional compilation in one place.
    /// </summary>
    internal static class Compatibility
    {
        public static PropertyInfo GetPublicStaticProperty(this Type type, string propertyName)
        {
#if DNXCORE50
           // return type.GetRuntimeProperty(propertyName);
            return type.GetRuntimePropertyExt(propertyName);
#else
            return type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Static);
#endif
        }

        public static MethodInfo GetPublicInstanceMethod(this Type type, string name)
        {
#if DNXCORE50
   //  return type.GetRuntimeMethod(name, null);
       return     type.GetRuntimeMethodsExt(name,null);

#else
            return type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public);
#endif
        }

        public static PropertyInfo GetPublicInstanceProperty(this Type type, string name)
        {
#if DNXCORE50
           // return type.GetRuntimeProperty(name);
            return type.GetRuntimePropertyExt(name);
#else
            return type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
#endif
        }

        public static Func<string> CreateGetter(this PropertyInfo property)
        {
            Func<string> accessor;
#if DNXCORE50
            accessor = (Func<string>)property.GetMethod.CreateDelegate(typeof(Func<string>), property.GetMethod);
#else
            accessor = (Func<string>) Delegate.CreateDelegate(typeof (Func<string>), property.GetGetMethod());
#endif
            return accessor;
        }

        public static bool CanAssignTo(this Type type, Type other)
        {
#if DNXCORE50
            return other.GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());
#else
            return other.IsAssignableFrom(type);
#endif
        }

        public static ValidatorAttribute GetValidatorAttribute(this Type type)
        {
#if DNXCORE50
            //   var attribute = (ValidatorAttribute)type.GetTypeInfo().GetCustomAttribute<ValidatorAttribute>(true);
             var q = type.GetTypeInfo().CustomAttributes.FirstOrDefault(p=>p.AttributeType==typeof(ValidatorAttribute));
            // attribute = q as ValidatorAttribute;

            return null;
            //  type.GetTypeInfo().Attributes

#else
            var attribute = (ValidatorAttribute) Attribute.GetCustomAttribute(type, typeof (ValidatorAttribute));
             return attribute;
#endif

        }

        public static Assembly GetAssembly(this Type type)
        {
#if DNXCORE50
                    return typeof(Messages).GetTypeInfo().Assembly;
#else
            return typeof (Messages).Assembly;
#endif
        }

        public static MethodInfo GetDeclaredMethod(this Type type, string name)
        {
#if DNXCORE50
            return type.GetTypeInfo().GetDeclaredMethod(name);
#else
            return type.GetMethod(name, new Type[0]);
#endif
        }

        public static bool IsGenericType(this Type type)
        {
#if DNXCORE50
            return type.GetTypeInfo().IsGenericType;
#else
            return type.IsGenericType;
#endif
        }
    }



    public static class RuntimeMethodExtensions
    {
        public static MethodInfo GetRuntimeMethodsExt(this Type type, string name, params Type[] types)
        {
            var potentials = (from ele in type.GetTypeInfo().GetDeclaredMethods(name)
                let param = ele.GetParameters()
                select ele);
            return potentials.FirstOrDefault();
        }


        public static PropertyInfo GetRuntimePropertyExt(this Type type, string name)
        {
            var potentials = type.GetTypeInfo().GetDeclaredProperty(name);

            return potentials; //.FirstOrDefault();
        }


    }

}