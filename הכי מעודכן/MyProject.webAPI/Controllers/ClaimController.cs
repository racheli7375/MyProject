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
    public class ClaimController : ControllerBase
    {
        private readonly IClaimeService _claimService;
   

        public ClaimController(IClaimeService claimService)
        {
            _claimService = claimService;
        }
        [HttpGet]
        public async Task< List<ClaimDTO>> Get()
        {
            return await _claimService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ClaimDTO> Get(int id)
        {
            return await _claimService.GetByIdAsync(id);
        }
    }
}
