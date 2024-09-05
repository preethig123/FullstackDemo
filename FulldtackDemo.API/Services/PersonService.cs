
using FullstackDemo.API.Models;

namespace FullstackDemo.API.Services
{
    public class PersonService : IPersonService
    {
        public Person AddPerson(Person person)
        {
            // Since this is a mock, we just return the person object directly.
            return person;
        }
    }
}
