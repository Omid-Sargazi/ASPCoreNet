using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tests01.Domain.Interfaces;
using Tests01.Domain.Models;

namespace Tests01.WebApi.Controllers
{
    public class AuthorsController:ControllerBase
    {
        private readonly IRepository<Author> _repository;
        public AuthorsController(IRepository<Author> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _repository.GetAllAsync();
            Console.WriteLine("Omid sargaxi");
            return Ok(authors);
        }
    }
}