using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minhaterapia.Models;
using minhaterapia.Repositories;
using minhaterapia.Repositories.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace minhaterapia.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PacienteController : ControllerBase
{
    private readonly IPacientesRepositorio service;

    public PacienteController(IPacientesRepositorio pacientesRepositorio)
    {
        service = pacientesRepositorio;
    }

    //[EnableCors("AllowOrigin")]
    [HttpGet]
    [Route("BuscarPacientes")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task <ActionResult<List<PacienteController>>> BuscarPacientes()
    {
        List<PacientesModel> pacientes= await service.BuscarPacientes();
        return Ok(pacientes);
    }

    [HttpGet]
    [Route("PacientesCompleto")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<List<ProfilePaciente>>> PacientesCompleto()
    {
        List<ProfilePaciente> profile = await service.PacientesCompleto();
        return Ok(profile);
    }

    [HttpGet("{id}")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<PacienteController>> BuscarPorID(int id)
    {
        PacientesModel paciente = await service.BuscarPorID(id);
        return Ok(paciente);
    }

    [HttpPost]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<PacientesModel>> Cadastrar([FromBody] PacientesModel pacienteModel)
    {
        PacientesModel paciente= await service.Adicionar(pacienteModel);

        return Ok(paciente);
    }

    [HttpPut("{id}")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<PacientesModel>> Atualizar([FromBody] PacientesModel pacienteModel, int id)
    {
        pacienteModel.ID = id;
        
        PacientesModel paciente = await service.Atualizar(pacienteModel, id);

        return Ok(paciente);
    }

    [HttpPatch("{id}")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<PacientesModel>> AtualizarEspecifico([FromBody] PacientesModel pacienteModel, int id)
    {
        pacienteModel.ID = id;

        PacientesModel paciente = await service.Atualizar(pacienteModel, id);

        return Ok(paciente);
    }

    [HttpDelete("{id}")]
    [ProducesDefaultResponseTypeAttribute()]
    public async Task<ActionResult<PacientesModel>> Apagar(int id)
    {
        
        bool apagado= await service.Apagar(id);
        
        return Ok(apagado);

        
    }
}


