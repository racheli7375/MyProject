using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPeoject.Common;
using MyProject.Mock;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {

            _permissionService = permissionService;
        }
        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            return await _permissionService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PermissionDTO> Get(int id)
        {
            return await _permissionService.GetByIdAsync(id);
        }
    }
}

