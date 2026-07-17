using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInspector
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AgeAttribute : Attribute
    {
        public int Age { get; set; }

        public AgeAttribute(int age)
        {
            Age = age;
        }
    }
}
