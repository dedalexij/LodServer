using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LodServer
{
  public class StandardView
  {
    public StandardView(string id, string name, string sex)
    {
      ID = id;
      Sex = sex;
      Name = name;
    }
    public string ID { set; get; }
    public string Name { set; get; }
    public string Sex { set; get; }
  }
}
