namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public ICollection<EngineerMachine> JoinTable { get; set; }
  }
}