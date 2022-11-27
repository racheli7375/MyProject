using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPeoject.Common;
using MyProject.Mock;
using MyProject.Services.Interfaces;
using MyProject.webAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleRepository)
        {

            _roleService = roleRepository;
        }
        [HttpGet]
        public async Task<List<RoleDTO>> Get()
        {
            return await _roleService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<RoleDTO> Get(int id)
        {
            return await _roleService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _roleService.DeleteAsync(id);
        }
        [HttpPut("{id},{name},{d}")]
        public async Task<RoleDTO> Put(int id,string name,string d)
        {
            RoleDTO r =await _roleService.UpdateAsync(new RoleDTO { Id = id, Name = name, Description = d });
            return r;
        }
        [HttpPost]
        //public async Task<RoleDTO> Post([FromBody] RoleModel model)
        //{

        //}
        //[HttpPost]
        //public async Task<RoleDTO> Post([FromBody] RoleModel model)
        //{
        //    var roleTask1 = _roleService.AddAsync(new RoleDTO());
        //    var roleTask2 = _roleService.AddAsync(new RoleDTO());
        //    var roleTask3 = _roleService.AddAsync(new RoleDTO());

        //    await Task.WhenAll(roleTask1, roleTask2);
        //    var x = await roleTask3;
        //    return roleTask1.Result;
        //}

    }
}
