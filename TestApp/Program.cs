using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args == null || args.Length == 0)
                {
                    throw new ArgumentNullException("No input filename included. Please provide the file path to input data");
                }
                else
                {
                    // Read file with list of names
                    var persons = new NameReader(args[0]).Process();

                    // Order List
                    persons = new PersonComparator().OrderList(persons);

                    // Write file with ordered list of names
                    const string fileName = "sorted-names-list.txt";
                    new NameWriter().WriteNames(persons, fileName);
                }
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
