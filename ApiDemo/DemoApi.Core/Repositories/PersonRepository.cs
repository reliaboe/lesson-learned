using DemoApi.Core.Models;

namespace DemoApi.Core.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            var a = new Person
            {
                Id = 1,
                FirstName = "Hans",
                LastName = "Hansen"
            };
            yield return a;

            var b = new Person
            {
                Id = 2,
                FirstName = "Nils",
                LastName = "Nilsen"
            };
            yield return b;

        }
    }
}
