using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;

namespace NameSorterTest.TestUtils
{
    class MockData
    {
        private const String SINGLENAMEDATA = "Beau Tristan Bentley";
    
        private const String NOGIVENNAMESDATA = "Johnson";
    
        private const String EXCESSIVEGIVENNAMESDATA = "James Johnson Jones Jameson Smith";
    
        /**
         * Expected list of persons when unordered.
         * 
         */
        private IEnumerable<Person> EXPECTEDUNORDEREDLIST = new List<Person>() {
            new Person("Janet Parsons"),
            new Person("Vaughn Lewis"),
            new Person("Adonis Julius Archer"),
            new Person("Shelby Nathan Yoder"),
            new Person("Marin Alvarez"),
            new Person("London Lindsey"),
            new Person("Beau Tristan Bentley"),
            new Person("Leo Gardner"),
            new Person("Hunter Uriah Mathew Clarke"),
            new Person("Hunter Uriah Mathez Clarke"),
            new Person("Hunter Uriau Mathew Clarke"),
            new Person("Hunter Uriah Mathew Clarke"),
            new Person("Mikayla Lopez"),
            new Person("Frankie Conner Ritter")
        };
    
        /**
         * Expected list of persons when ordered.
         * 
         */
        private IEnumerable<Person> EXPECTEDORDEREDLIST = new List<Person>() {
            new Person("Marin Alvarez"),
            new Person("Adonis Julius Archer"),
            new Person("Beau Tristan Bentley"),
            new Person("Hunter Uriah Mathew Clarke"),
            new Person("Hunter Uriah Mathew Clarke"),
            new Person("Hunter Uriah Mathez Clarke"),
            new Person("Hunter Uriau Mathew Clarke"),
            new Person("Leo Gardner"),
            new Person("Vaughn Lewis"),
            new Person("London Lindsey"),
            new Person("Mikayla Lopez"),
            new Person("Janet Parsons"),
            new Person("Frankie Conner Ritter"),
            new Person("Shelby Nathan Yoder")
        };
    
        /**
         *
         * @return no data
         */
        public String NoGivenNamesData() {
            return NOGIVENNAMESDATA;
        }
    
        /**
         *
         * @return data without enough given names and last name
         */
        public String SingleNameData() {
            return SINGLENAMEDATA;
        }
    
        /**
         *
         * @return data with too many given names
         */
        public String ExcessiveGivenNamesData() {
            return EXCESSIVEGIVENNAMESDATA;
        }
    
        /**
         *
         * @return initial unordered list
         */
        public IEnumerable<Person> ExpectedUnorderedList() {
            return EXPECTEDUNORDEREDLIST;
        }
    
        /**
         *
         * @return expected ordered list
         */
        public IEnumerable<Person> ExpectedOrderedList() {
            return EXPECTEDORDEREDLIST;
        }
    }
}
