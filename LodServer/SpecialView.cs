using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LodServer
{
  public class SpecialView
  {
    public SpecialView(string sex, string name, int age)
    {
      Age = age;
      Name = name;
      Sex = sex;
    }
    public  string Sex { set; get; }
    public string Name { set; get; }
    public int Age { set; get; }
  }
}
