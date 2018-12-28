using System.Collections.Generic;
using System.Threading;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        // Contador responsável por gerar um fake ID já que não estamos
        // acessando nenhum banco de dados...
        private volatile int count;

        // Método responsável por criar uma nova pessoa (Insert)
        // Se tivéssemos um banco de dados esse seria o momento de persistir os dados.
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
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
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person Last Name " + i,
                Address = "Some Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Ezequiel Herique",
                LastName = "Campana",
                Address = "Rua Alcebíades Fontes Leite",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
