using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public ICollection<EngineerMachine> JoinTable { get; set; }
  }
}