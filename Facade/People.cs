using System;
using System.Collections.Generic;

namespace Facade
{
    public static class People
    {
        public static List<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person() { FirstName="John", LastName="Koenig",
                    StartDate = DateTime.Parse("10/17/1975"), Rating=6 },
                new Person() { FirstName="Dylan", LastName="Hunt", 
                    StartDate = DateTime.Parse("10/02/2000"), Rating=8 },
                new Person() { FirstName="John", LastName="Crichton", 
                    StartDate = DateTime.Parse("03/19/1999"), Rating=7 },
                new Person() { FirstName="Dave", LastName="Lister", 
                    StartDate = DateTime.Parse("02/15/1988"), Rating=9 },
                new Person() { FirstName="John", LastName="Sheridan", 
                    StartDate = DateTime.Parse("01/26/1994"), Rating=6 },
                new Person() { FirstName="Dante", LastName="Montana", 
                    StartDate = DateTime.Parse("11/01/2000"), Rating=5 },
                new Person() { FirstName="Isaac", LastName="Gampu", 
                    StartDate = DateTime.Parse("09/10/1977"), Rating=4 }
            };
            return p;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
    }
}
