using DemoApi.Core.Models;
using DemoApi.Core.Repositories;

namespace DemoApi.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public ICollection<Person> GetPeople()
        {
            return _personRepository.GetPeople().ToList();
        }

        public Person GetPerson(int id)
        {
            return _personRepository.GetPeople().FirstOrDefault(x => x.Id == id);
        }
    }
}
