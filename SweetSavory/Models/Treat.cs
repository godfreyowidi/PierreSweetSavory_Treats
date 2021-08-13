using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string DisplayOrder { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}