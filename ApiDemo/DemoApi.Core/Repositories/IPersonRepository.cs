using DemoApi.Core.Models;

namespace DemoApi.Core.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
    }
}
