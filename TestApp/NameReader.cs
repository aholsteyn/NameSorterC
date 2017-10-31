using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestApp
{
    public class NameReader
    {
        public string FileName { get; set; }
        public NameReader(string fileName)
        {
            FileName = fileName;
        }

        public IEnumerable<Person> Process()
        {
            if (!File.Exists(FileName)) throw new FileNotFoundException("Cannot find the file: " + FileName);

            var persons =  new List<Person>();

            // Read all names and add a new person to the list
            File.ReadAllLines(FileName).ToList().ForEach(name => persons.Add(new Person(name)));
            
            return persons;
        }
    }
}
