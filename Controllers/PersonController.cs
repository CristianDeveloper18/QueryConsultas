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
        [Route("ApiPersona_Consultar_Todos")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ApiPersona_Consultar_Nombre,Correo,Anio")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ApiPersona_Consultar_Genero")]
        public IActionResult GetByGender(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ApiPersona_Consultar_Edad")]
        public IActionResult GetByRangeAge(int Age, int age2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(Age,age2);
            return Ok(persons);
        }

    

        [HttpGet]
        [Route("ApiPersona_Consultar_Trabajos")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 


        [HttpGet]
        [Route("ApiPersona_Consultar_Palabra")]
        public IActionResult GetContains(string palabra)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(palabra);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ApiPersona_Consultar_EdadesEspec")]
        public IActionResult GetByAger(int age1, int age2, int age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger( age1,  age2,  age3);
            return Ok(persons);
        }


         [HttpGet]
        [Route("ApiPersona_Consultar_EdadMayor")]
        public IActionResult GetByMaxAge(int Edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(Edad);
            return Ok(persons);
        } 


       

        [HttpGet]
        [Route("ApiPersona_Consultar_EdadOrdered")]
        public IActionResult GetPersonsOrdered(int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(Age);
            return Ok(persons);
        }

          [HttpGet]
        [Route("ApiPersona_Consultar_EdadDesc")]
        public IActionResult GetPersonsOrderedDesc(int edad, int edad2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(edad, edad2);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ApiPersona_Consultar_GeneroF")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ApiPersona_Consultar_Apellido")]
        public IActionResult ExistPerson(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(Apellido);
            return Ok(persons);
        }


    
        [HttpGet]
        [Route("ApiPersona_Consultar_TrabajoEspec")]
        public IActionResult GetPerson(string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, age);
            return Ok(persons);
        }

       

        [HttpGet]
        [Route("ApiPersona_Consultar_PersonasTrab")]
        public IActionResult TakePerson(string job, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job,take);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ApiPersona_Consultar_OmitaTrabaj")]
        public IActionResult SkipPerson(string job, int skip)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job, skip);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ApiPersona_Consultar_OmitaRetorneTrabaj")]
        public IActionResult SkipTakePerson(string job, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job,skip,take);
            return Ok(persons);
        }


    }
}