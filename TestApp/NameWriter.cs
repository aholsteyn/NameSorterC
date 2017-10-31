using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestApp
{
    public class NameWriter
    {
        // Write names to given file path
        public void WriteNames(IEnumerable<Person> persons, string fileName)
        {
            using (TextWriter tw = new StreamWriter(fileName))
            {
                var personsList = persons.ToList();
                var name = personsList.First().Name.ToString();
                tw.Write(name);
                Console.Write(name);
                personsList.RemoveAt(0);
                personsList.ForEach(p =>
                    {
                        tw.WriteLine();
                        Console.WriteLine();
                        name = p.Name.ToString();
                        tw.Write(name);
                        Console.Write(name);
                    });
            }
        }
    }
}
