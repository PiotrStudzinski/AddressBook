using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class PersonService
    {
        public List<Person> Persons { get; set; }

        public PersonService()
        {
            Persons = new List<Person>();
        }

        public int AddNewPerson()
        {
            Person person = new Person();

            Console.WriteLine();
            Console.WriteLine("Adding a new contact:");
            Console.WriteLine();

            Console.Write("Please enter the id of the new person: ");
            var id = Console.ReadLine();
            int personId;
            Int32.TryParse(id, out personId);
            Console.Write("Please enter the first name of the new person: ");
            var firstName = Console.ReadLine();
            Console.Write("Please enter the last name of the new person: ");
            var lastName = Console.ReadLine();
            Console.Write("Please enter the phone of the new person: ");
            var phone = Console.ReadLine();
            Console.Write("Please enter the email of the new person: ");
            var email = Console.ReadLine();
            Console.Write("Please enter the address of the new person: ");
            var address = Console.ReadLine();
            Console.Write("Please enter the zip code of the new person: ");
            var zipCode = Console.ReadLine();
            Console.Write("Please enter the city of the new person: ");
            var city = Console.ReadLine();

            person.Id = personId;
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Phone = phone;
            person.Email = email;
            person.Address = address;
            person.ZipCode = zipCode;
            person.City = city;

            Persons.Add(person);
            return personId;
        }

        public void DetailPersonView(int detailId)
        {
            Person personToShow = new Person();

            foreach (var person in Persons)
            {
                if (person.Id == detailId)
                {
                    personToShow = person;
                    break;
                }
            }

            Console.WriteLine();
            //Console.WriteLine($"Person Id: {personToShow.Id}"); Zbędne
            Console.WriteLine($"Person first name: {personToShow.FirstName}");
            Console.WriteLine($"Person last name: {personToShow.LastName}");
            Console.WriteLine($"Person phone: {personToShow.Phone}");
            Console.WriteLine($"Person email: {personToShow.Email}");
            Console.WriteLine($"Person address: {personToShow.Address}");
            Console.WriteLine($"Person zip code: {personToShow.ZipCode}");
            Console.WriteLine($"Person city: {personToShow.City}");
        }

        public int PersonDetailSelectionView()
        {
            Console.WriteLine();
            Console.Write("Please enter id for person you want to show: ");
            var id = Console.ReadKey();
            int personId;
            Int32.TryParse(id.KeyChar.ToString(), out personId);
            Console.WriteLine();

            return personId;
        }

        public void AllPersonsView()
        {
            Console.WriteLine();
            Console.WriteLine("List of all contacts:");
            Console.WriteLine();

            foreach (var person in Persons)
            {
                Console.Write($"{person.Id} {person.FirstName} {person.LastName} {person.Phone} {person.Email} {person.Address} {person.ZipCode} {person.City}\n");
            }
        }

        public int RemovePersonView()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter id for person you want to remove: ");
            var id = Console.ReadKey();
            int personId;
            Int32.TryParse(id.KeyChar.ToString(), out personId);
            Console.WriteLine();

            return personId;
        }

        public void RemovePerson(int removeId)
        {
            Person personToRemove = new Person();
            
            foreach(var person in Persons)
            {
                if(person.Id == removeId)
                {
                    personToRemove = person;
                    break;
                }
            }

            Persons.Remove(personToRemove);
        }
    }
}
