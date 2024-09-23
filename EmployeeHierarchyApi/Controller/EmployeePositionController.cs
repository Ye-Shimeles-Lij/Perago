using System;
using System.Collection.Generic;
using System.Link;
using System.Net;
using System.Net.Http;
using System.Web.Http;
;

[ApiController]
[Route("api/[controller]")]
public class EmployeePositionController : ControllerBase
{
    private readonly IEmployeePositionRepository _repository;

    public EmployeePositionController(IEmployeePositionRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EmployeePosition position)
    {
        position.Id = Guid.NewGuid();
        await _repository.AddAsync(position);
        return CreatedAtAction(nameof(GetById), new { id = position.Id }, position);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var position = await _repository.GetByIdAsync(id);
        if (position == null) return NotFound();
        return Ok(position);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var positions = await _repository.GetAllAsync();
        return Ok(positions);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _repository.DeleteAsync(id);
        return NoContent();
    }
   
}

