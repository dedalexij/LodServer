using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LodServer
{
  public class Maincontroller : Controller
  {
    public Maincontroller(IOptions<PeopleList> peopleList, Views views)
    {
      _views = views;
      _peopleList = peopleList.Value;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_peopleList.People.Select(_views.PeopleView));
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
      var people = _peopleList.People.SingleOrDefault(person => person.ID == id);

      if (people == null)
      {
        return NotFound("Person not exist");
      }

      return Ok(_views.DifferentView(people));
    }

    private readonly PeopleList _peopleList;
    private readonly Views _views;
  }
}
