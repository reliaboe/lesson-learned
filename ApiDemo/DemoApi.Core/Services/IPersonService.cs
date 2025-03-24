using DemoApi.Core.Models;

namespace DemoApi.Core.Services
{
    public interface IPersonService
    {
        ICollection<Person> GetPeople();
        Person GetPerson(int id);
    }
}
