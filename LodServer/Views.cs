using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LodServer
{
    public class Views
    {
    public StandardView PeopleView(People people)
    {
      if (people == null)
      {
        return null;
      }

      return new StandardView( people.ID, people.Name, people.Sex);
    }

    public SpecialView DifferentView(People people)
    {
      if (people == null)
      {
        return null;
      }

      return new SpecialView(people.Sex, people.Name, people.Age);
    }
  }
}
