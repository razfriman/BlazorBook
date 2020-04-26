using System;

namespace BlazorBook
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class BlazorBookComponentAttribute : Attribute
    {
        public BlazorBookComponentAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
