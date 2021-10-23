using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // Todos los datos
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar nombre, correo, anio de nacimiento
        public IEnumerable<Object> GetField(){
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age *-1).Year,
                CorreoElectronico = person.Email
            });
            return query;
        }

        // retornar genero especifico
        public IEnumerable<Person> GetByGender(char gender){
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }

        // edad de 20 a 30
        public IEnumerable<Person> GetByRangeAge(int Age, int age2){
          
            var query = _persons.Where(person => person.Age >= Age && person.Age <= age2);
            return query;
        }

        // Diferentes trabajos
            public IEnumerable<string> GetJobs(){
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }
 
        // retornar valores que contengan
        public IEnumerable<Person> GetContains(String palabra){
            var query = _persons.Where(person => person.FirstName.Contains(palabra));
            return query; //no me importa donde lo contenga
        }

        // retornar valores que contengan 25 35 45
        public IEnumerable<Person> GetByAger(int age1, int age2, int age3){
            var ages = new List<int>{age1, age2, age3};
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query; 
        }
    

        public IEnumerable<Person> GetByMaxAge(int Edad){
            var query = _persons.Where(person => person.Age <= Edad);
            return query;
        }
        
    
        // retornar elementos ordenados
        public IEnumerable<Person> GetPersonsOrdered(int age){
           
            var query = _persons.Where(person => person.Age > age)
                        .OrderBy(person => person.Age);
            return query;
        }

        public IEnumerable<Person> GetPersonsOrderedDesc(int edad, int edad2){
            var gender = 'M';
            var query = _persons.Where(person => person.Gender == gender && person.Age >= edad && person.Age <= edad2)
                        .OrderByDescending(person => person.LastName);
            return query;
        }

            public int CountPerson(char gender)
        {
            
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }

         // Evalua si un elemento existe
        public bool ExistPerson(string Apellido)
        {

            var query = _persons.Exists(person => person.LastName == Apellido);
            return query;
        }

        // retorno cantidad de elementos
        public int CountPeople(){
            var age = 37;
            var query = _persons.Count(person => person.Age == age);
            return query;
        }
        

    
        // retornar solo un elemento
        public Person GetPerson(string job, int age)
        {
            
            var query = _persons.FirstOrDefault(person => person.Job == job && person.Age == age);
            return query;
        }

        // retornar solamente unos elementos
        public IEnumerable<Person> TakePerson(string job, int take)
        {
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }

        // retornar elementos saltando posición
        public IEnumerable<Person> SkipPerson(string job, int skip)
        {
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }

        
        public IEnumerable<Person> TakeLastPerson()
        {
            var job = "Geological Engineer";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).TakeLast(take);
            return query;
        }
        public IEnumerable<Person> SkipTakePerson(string job, int skip, int take)
        {
           
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }
        
    }
}