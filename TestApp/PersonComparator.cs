using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    public class PersonComparator
    {
        public IEnumerable<Person> OrderList(IEnumerable<Person> persons)
        {
            return persons.OrderBy(p => p.Name.LastName).ThenBy(p => p.Name.GivenNames, StringComparer.OrdinalIgnoreCase);
        }
    }
}
