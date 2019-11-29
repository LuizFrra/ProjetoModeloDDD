using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.API.Models;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientRepository clientRepository;

        private IMapper mapper;

        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            this.clientRepository = clientRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = clientRepository.GetAll();
            var clientsModel = mapper.Map<ICollection<ClientModel>>(clients);
            return Ok(clientsModel);
        }
    }
}