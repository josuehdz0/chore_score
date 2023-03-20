using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chore_score.Controllers;


[ApiController]
[Route("api/[controller]")]

public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;

    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }


    [HttpGet]
    public ActionResult<List<Chore>> GetAll()
    {
        try 
        {
        return Ok(_choresService.GetAllChores());
        }
        catch (System.Exception e)
        {
        return BadRequest(e.Message);
        }
    }
}