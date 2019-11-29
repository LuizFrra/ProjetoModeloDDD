using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.API.Models;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientAppService clientService;

        private IMapper mapper;

        public ClientController(IClientAppService clientService, IMapper mapper)
        {
            this.clientService = clientService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = clientService.GetAll();
            var clientsModel = mapper.Map<ICollection<ClientModel>>(clients);
            return Ok(clientsModel);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ClientModel clientModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = clientService.Add(mapper.Map<Client>(clientModel));

            if (client == 1)
                return Created("Create", clientModel);
            else 
                return BadRequest(clientModel);
        }
    }
}