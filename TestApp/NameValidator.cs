using System;
using System.IO;

namespace TestApp
{
    public class NameValidator
    {
        public void Validate(String name)
        {
            var namesCount = name.Split(' ').Length;
            if (namesCount <= 1 || namesCount > 4)
            {
                throw new IOException("Input name (" + name + ") has no last name or more than three given names");
            }
        }
    }
}
