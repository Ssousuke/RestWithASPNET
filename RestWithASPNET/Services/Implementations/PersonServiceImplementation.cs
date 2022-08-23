using RestWithASPNET.Models;

namespace RestWithASPNET.services.implementations;

public class PersonServiceImplementation : IPersonService
{
    private volatile int count;

    public Person Create(Person person)
    {
        return person;
    }

    public Person FindByID(long id)
    {
        return new Person()
        {
            Id = 1,
            Address = "Socopo",
            FirstName = "China",
            LastName = "Farias",
            Gender = "Masculino"
        };
    }

    public Person Update(Person person)
    {
        return person;
    }

    public Person Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Person> FindAll()
    {
        List<Person> persons = new List<Person>();
        for (int i = 0; i < 8; i++)
        {
            Person person = MockPerson(i);
            persons.Add(person);
        }

        return persons;
    }

    private Person MockPerson(int i)
    {
        return new Person()
        {
            Id = IncrementAndGet(),
            Address = "Socopo",
            FirstName = "China",
            LastName = "Farias",
            Gender = "Masculino"
        };
    }

    private long IncrementAndGet()
    {
        return Interlocked.Increment(ref count);
    }
}