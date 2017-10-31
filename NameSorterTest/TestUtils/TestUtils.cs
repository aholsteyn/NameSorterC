using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;

namespace NameSorterTest.TestUtils
{
    public class TestUtils
    {
        /**
         * As cannot assert between lists of objects due to different hash codes,
         * convert to list of names so they can be compared
         * @param persons - list of persons
         * @return list of names
         */
        public static IEnumerable<String> ConvertPersonListToNameList(IEnumerable<Person> persons) {
            var personsNames = new List<String>();
            persons.ToList().ForEach(p => personsNames.Add(p.Name.ToString()));
            return personsNames;
        }
    }
}
