namespace LambdaExpressionsOnList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            ListOfPerson.AddingPersonDetailsIntoList(listPersonsInCity);
            ListOfPerson.RetrievingTop2OlderPersonAgedOlderThan60(listPersonsInCity);
            ListOfPerson.FindingTeenAgers(listPersonsInCity);
            ListOfPerson.ChecksWhetherAllAgedGreaterThan10(listPersonsInCity);
            ListOfPerson.AverageAge(listPersonsInCity);
            ListOfPerson.GivenNameExistsOrNot(listPersonsInCity);
            ListOfPerson.FindingPositionOfGivenPerson(listPersonsInCity);
            ListOfPerson.OldestPersonInList(listPersonsInCity);
            ListOfPerson.TotalOfAllPeoplesAge(listPersonsInCity);
            ListOfPerson.SkipPersonWhoseAgeIsLessThan60(listPersonsInCity);
            ListOfPerson.FindPersonWithNameBeginningWithAnyLetterOtherThan_S(listPersonsInCity);
            ListOfPerson.ChecksWhetherAllPersonsHaveSSN(listPersonsInCity);
            ListOfPerson.RemovePerson(listPersonsInCity);
            ListOfPerson.SearchPersonViaSSN(listPersonsInCity);
        }
    }
}