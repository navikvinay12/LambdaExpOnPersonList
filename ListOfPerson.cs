using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsOnList
{
    public class ListOfPerson
    {
        public static void AddingPersonDetailsIntoList(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));
            DisplayEachPersonDetails(listPersonsInCity);
        }
        public static void DisplayEachPersonDetails(List<Person> listPersonsInCity)
        {
            foreach(Person person in listPersonsInCity)
            {
                Console.WriteLine(person);
            }
        }
        public static void RetrievingTop2OlderPersonAgedOlderThan60(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine($"Name : {person.Name}        Age : {person.Age}");
            }
        }
        public static void FindingTeenAgers(List<Person> listPersonsInCity)     //between 13 to 19 years
        {
            if(listPersonsInCity.Any(e=>(e.Age>=13 && e.Age<=19)))
            {
                Console.WriteLine("Yes,we have some teen-agers in the list");
            }
        }
        public static void ChecksWhetherAllAgedGreaterThan10(List<Person> listPersonsInCity)
        {
            if(listPersonsInCity.All(e=>(e.Age>10)))    //checks whether all the people's ages are greater than Ten years or not:
            {
                Console.WriteLine("Yes , all the persons older than 10 years");
            }
        }
        public static void AverageAge(List<Person> listPersonsInCity)   //Average Age
        {
            Console.WriteLine("\nGetting Average of all the person's age...");
            double avgAge=listPersonsInCity.Average(e=>e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
        }
        public static void GivenNameExistsOrNot(List<Person> listPersonsInCity)
        {
            if(listPersonsInCity.Exists(e=>(e.Name=="SAM")))//checks whether a person having the name 'SAM' exists or not:
            {
                Console.WriteLine("Yes, A person having name  'SAM' exists in our list");
            }
        }
        public static void FindingPositionOfGivenPerson(List<Person> listPersonsInCity) //index position of given name
        {
            Console.WriteLine("\nChecking the index position of a person having name 'Smith' ...");
            int indexForSmith = listPersonsInCity.FindIndex(e => e.Name == "Smith");
            Console.WriteLine("In the list, The index position of a person having name 'Smith' is : " + indexForSmith);
        }
        public static void OldestPersonInList(List<Person> listPersonsInCity)//the oldest person in the list
        {
            Console.WriteLine("\nGetting the name of the most aged person in the list ...");
            Person p= listPersonsInCity.First(m=> m.Age == (listPersonsInCity.Max(e=>e.Age)));
            Console.WriteLine("The most aged person in our list is: " + p.Name + " whose age is: " + p.Age);
        }
        public static void TotalOfAllPeoplesAge(List<Person> listPersonsInCity) //total of all the peoples ages
        {
            Console.WriteLine("\nGetting Sum of all the person's age...");
            int sumOfAges = listPersonsInCity.Sum(e=>e.Age);
            Console.WriteLine("The sum of all the persons's age = " + sumOfAges);
        }
        public static void SkipPersonWhoseAgeIsLessThan60(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
            foreach(Person person in listPersonsInCity.SkipWhile(e=>e.Age<60))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
        public static void FindPersonWithNameBeginningWithAnyLetterOtherThan_S(List<Person> listPersonsInCity)
        {
            foreach(Person person in listPersonsInCity.TakeWhile(e=>e.Name.StartsWith("J")))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
        public static void ChecksWhetherAllPersonsHaveSSN(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nChecking all the persons have SSN or not ...");
            if(listPersonsInCity.TrueForAll(e=>e.SSN!=null))
            {
                Console.WriteLine("No person is found without SSN");
            }
        }
        public static void RemovePerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nRemoving all the persons record from list that have \"SAM\" name");
            listPersonsInCity.TrueForAll(e => e.Name == "SAM");
            if(listPersonsInCity.TrueForAll(e=>e.Name!= "SAM"))
            {
                Console.WriteLine("No person is found with 'SAM' name in current list");
            }
        }
        public static void SearchPersonViaSSN(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nFinding the person whose SSN = 203456876 in the list");
            Person person = listPersonsInCity.Find(e => (e.SSN == "203456876"));
            Console.WriteLine("The person having SSN '203456876' is : " + person.Name + " \t\tAge: " + person.Age);
        }
    }
}
