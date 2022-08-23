using RestWithASPNET.Models;

namespace RestWithASPNET.services;

public interface IPersonService
{
    Person Create(Person person);
    Person FindByID(long id);
    Person Update(Person person);
    Person Delete(long id);
    List<Person> FindAll();
}