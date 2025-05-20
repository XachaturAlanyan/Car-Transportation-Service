//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//namespace ADONET
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int option = 1;
//            do
//            {
//                Console.WriteLine("1. Add person | 2. Update person | 3. Delete person | 4. Get people | 5. Get person by id | 0. Exit");
//                Console.Write("Your option: ");
//                option = int.Parse(Console.ReadLine());
//                IPersonRepository personRepository = new PersonRepository();
//                Person person = null;
//                switch (option)
//                {
//                    case 0:
//                        break;
//                    case 1:
//                        person = PersonHelper.ReadPersonDataFromConsole();
//                        personRepository.AddPerson(person);
//                        break;
//                    case 2:
//                        Console.Write("Enter person id: ");
//                        int personId = int.Parse(Console.ReadLine());
//                        person = PersonHelper.ReadPersonDataFromConsole();
//                        person.Id = personId;
//                        personRepository.UpdatePerson(person);
//                        break;
//                    case 3:
//                        Console.Write("Enter person id: ");
//                        int id = int.Parse(Console.ReadLine());
//                        personRepository.DeletePerson(id);
//                        break;
//                    case 4:
//                        personRepository
//                            .FindAllPersons()
//                            .ForEach(p => Console.WriteLine($"Id: {p.Id} | Name: {p.Name} | Surname: {p.Surname} | Age: {p.Age}"));
//                        break;
//                    case 5:
//                        Console.Write("Enter person id: ");
//                        int pId = int.Parse(Console.ReadLine());
//                        person = personRepository.FindPerson(pId);
//                        Console.WriteLine($"Id: {person.Id} | Name: {person.Name} | Surname: {person.Surname} | Age: {person.Age}");
//                        break;
//                }
//            }
//            while (option != 0);
//        }
//    }
//    public static class PersonHelper
//    {
//        public static Person ReadPersonDataFromConsole()
//        {
//            Person person = new Person();
//            Console.Write($"Enter person name: ");
//            person.Name = Console.ReadLine();
//            Console.Write($"Enter person surname: ");
//            person.Surname = Console.ReadLine();
//            Console.Write($"Enter person age: ");
//            person.Age = int.Parse(Console.ReadLine());
//            return person;
//        }
//    }
//    public class Person
//    {
//        public Person(int id, string name, string surname, int age)
//        {
//            Id = id;
//            Name = name;
//            Surname = surname;
//            Age = age;
//        }
//        public Person()
//        {
//        }
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public int Age { get; set; }
//    }
//    public interface IPersonRepository
//    {
//        void AddPerson(Person person);
//        Person FindPerson(int id);
//        List<Person> FindAllPersons();
//        void UpdatePerson(Person person);
//        void DeletePerson(int id);
//    }
//    public class PersonRepository : IPersonRepository
//    {
//        public const string CONNECTION_STRING = "Data Source=.;Initial Catalog=University;Integrated Security=True;Encrypt=False";//"Data Source=.;Initial Catalog=Company;Integrated Security=True;Encrypt=False";
//        public void AddPerson(Person person)
//        {
//            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "insert into Person values(@Name, @Surname, @Age)";
//                    command.Parameters.Add(new SqlParameter("@Name", person.Name));
//                    command.Parameters.Add(new SqlParameter("@Surname", person.Surname));
//                    command.Parameters.Add(new SqlParameter("@Age", person.Age));
//                    command.ExecuteNonQuery();
//                }
//            }
//        }
//        public void DeletePerson(int id)
//        {
//            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "DELETE FROM Person WHERE Id = @Id";
//                    command.Parameters.Add(new SqlParameter("@Id", id));
//                    command.ExecuteNonQuery();
//                }
//            }
//        }
//        public List<Person> FindAllPersons()
//        {
//            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//            {
//                connection.Open();
//                List<Person> people = new List<Person>();
//                using (SqlCommand command = new SqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "select * from Person";
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Person person = new Person();
//                            person.Id = int.Parse(reader["Id"].ToString());
//                            person.Name = reader["Name"].ToString();
//                            person.Surname = reader["Surname"].ToString();
//                            person.Age = int.Parse(reader["Age"].ToString());
//                            people.Add(person);
//                        }
//                    }
//                }
//                return people;
//            }
//        }
//        public Person FindPerson(int id)
//        {
//            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//            {
//                connection.Open();
//                Person person = new Person();
//                using (SqlCommand command = new SqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "select * from Person where Id = @Id";
//                    command.Parameters.Add(new SqlParameter("@Id", id));
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            person.Id = int.Parse(reader["Id"].ToString());
//                            person.Name = reader["Name"].ToString();
//                            person.Surname = reader["Surname"].ToString();
//                            person.Age = int.Parse(reader["Age"].ToString());
//                        }
//                    }
//                }
//                return person;
//            }
//        }
//        public void UpdatePerson(Person person)
//        {
//            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "update Person set Name = @Name,Surname = @Surname, Age = @Age where Id = @Id";
//                    command.Parameters.Add(new SqlParameter("@Id", person.Id));
//                    command.Parameters.Add(new SqlParameter("@Name", person.Name));
//                    command.Parameters.Add(new SqlParameter("@Surname", person.Surname));
//                    command.Parameters.Add(new SqlParameter("@Age", person.Age));
//                    command.ExecuteNonQuery();
//                }
//            }
//        }
//    }
//}