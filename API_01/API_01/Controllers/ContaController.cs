﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_01.Data;
using API_01.Models;
using API_01.Interfaces.Service;

namespace API_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;

        }

        // GET: api/Conta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaModel>>> GetConta()
        {
            return Ok(_contaService.GetAll());
        }

        // GET: api/Conta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaModel>> GetContaModel(int id)
        {
            var contaModel = _contaService.GetOne(id);

            if (contaModel == null)
            {
                return NotFound();
            }

            return contaModel;
        }

        // PUT: api/Conta/5
        [HttpPut("{id}")]
        public ActionResult<ContaModel> PutContaModel(int id, ContaModel contaModel)
        {
            if (id != contaModel.Id)
            {
                return BadRequest();
            }

            var response = _contaService.Update(contaModel);

            if (response == null)
                return NotFound();
            return Ok(response);

        }
    }

    // POST: api/Conta
    [HttpPost]
    public ActionResult<ContaModel> PostContaModel(ContaModel contaModel)
    {

        var response = _contaService.Insert(contaModel);

        if (response == null)
            return BadRequest();

        return CreatedAtAction("GetContaModel", new { id = contaModel.Id }, contaModel);

    }

    // DELETE: api/Conta/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<ContaModel>> DeleteContaModel(int id)
    {
        var response = _contaService.GetOne(id);
        if (response == null)
        {
            return NotFound();
        }
        if (!_contaService.Delete(id))
            return BadRequest();

        return Ok();
    }

    private bool ContaModelExists(int id)
    {
        return _contaService.Conta.Any(e => e.Id == id);
    }
}

