using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork4_3.Domain.Interfaces;
using HomeWork4_3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork4_3.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _sheetManager;

        public PersonController(IPersonManager sheetManager)
        {
            _sheetManager = sheetManager;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _sheetManager.GetItem(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            var id = _sheetManager.Create(person);
            return Ok(id);
        }
    }
}
