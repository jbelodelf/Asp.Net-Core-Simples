using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Core2.Models;

namespace WebApi.Core2.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class FuncionarioController : ControllerBase
    {
        private DataBaseContext _contex;

        public FuncionarioController(DataBaseContext contex)
        {
            _contex = contex;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<List<Models.Funcionario>>> Get()
        {
            return await _contex.funcionario.ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
