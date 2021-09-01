using System;
using System.Collections.Generic;
using castles_and_knights.Models;
using castles_and_knights.Services;
using Microsoft.AspNetCore.Mvc;

namespace castles_and_knights.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class KnightsController : ControllerBase
  {
    private readonly KnightsService _knightsService;

    public KnightsController(KnightsService knightsService)
    {
      _knightsService = knightsService;
    }

    //GetAll
    [HttpGet]
    public ActionResult<IEnumerable<knight>> Get()
    {
      try
      {
        IEnumerable<knight> knights = _knightsService.Get();
        return Ok(knights);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // GetById
    [HttpGet("{id}")]
    public ActionResult<knight> Get(int id)
    {
      try
      {
        knight knight = _knightsService.Get(id);
        return Ok(knight);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}