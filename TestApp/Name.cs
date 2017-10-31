using System;
using System.IO;

namespace TestApp
{
    public class Name
    {
        public string LastName { get; set; }
        public string GivenNames { get; set; }

        public Name(String name)
        {
            new NameValidator().Validate(name);
            SetName(name);
        }

        private void SetName(string name)
        {
            var lastWordIndex = name.LastIndexOf(' ');
            LastName = name.Substring(lastWordIndex + 1);
            GivenNames = name.Substring(0, lastWordIndex);
        }

        public override string ToString() {
            return GivenNames + " " + LastName;
        }
    }
}
