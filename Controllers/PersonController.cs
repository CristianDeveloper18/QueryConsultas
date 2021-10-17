using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;


// Nombre de la escuela
//Progrmacion Orientada a Servicios
//Joel Chuc
// Api QueryConsultas
// Hernandez Carrillo Cristian Santiago
//4to Cuatrimestre
//Grupo: B
//Parcial 1
namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("1")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("2")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("3")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("4")]
        public IActionResult GetByRangeAge(int Age, int age2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(Age,age2);
            return Ok(persons);
        }

    

        [HttpGet]
        [Route("5")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 


        [HttpGet]
        [Route("6")]
        public IActionResult GetContains(string palabra)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(palabra);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("7")]
        public IActionResult GetByAger(int age1, int age2, int age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger( age1,  age2,  age3);
            return Ok(persons);
        }


         [HttpGet]
        [Route("8")]
        public IActionResult GetByMaxAge(int Edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(Edad);
            return Ok(persons);
        } 


       

        [HttpGet]
        [Route("9")]
        public IActionResult GetPersonsOrdered(int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(Age);
            return Ok(persons);
        }

          [HttpGet]
        [Route("10")]
        public IActionResult GetPersonsOrderedDesc(int edad, int edad2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(edad, edad2);
            return Ok(persons);
        }

        [HttpGet]
        [Route("11")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("12")]
        public IActionResult ExistPerson(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(Apellido);
            return Ok(persons);
        }


    
        [HttpGet]
        [Route("13")]
        public IActionResult GetPerson(string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, age);
            return Ok(persons);
        }

       

        [HttpGet]
        [Route("14")]
        public IActionResult TakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("15")]
        public IActionResult SkipPerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("16")]
        public IActionResult SkipTakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job);
            return Ok(persons);
        }


    }
}