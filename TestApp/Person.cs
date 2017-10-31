using System;

namespace TestApp
{
    public class Person
    {
        public Name Name;

        public Person(String name)
        {
            Name = new Name(name);
        }
    }
}
